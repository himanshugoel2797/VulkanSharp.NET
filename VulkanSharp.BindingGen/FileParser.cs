﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;

namespace VulkanSharp.BindingGen
{
    class VkEnumDef
    {
        public string Name;
        public Dictionary<string, string> Values;

        public VkEnumDef()
        {
            Values = new Dictionary<string, string>();
        }

        public override string ToString()
        {
            return $"Name: {Name}, Value Count: {Values.Count}";
        }
    }

    class ParameterDef
    {
        public string TypeName;
        public string ParamName;
        public int Offset;
        public int ElementCount;

        public override string ToString()
        {
            return $"Name: {ParamName}, Type: {TypeName}";
        }
    }

    class VkStructDef
    {
        public string Name;
        public List<ParameterDef> Parameters;
        public int Len;

        public VkStructDef()
        {
            Parameters = new List<ParameterDef>();
        }

        public override string ToString()
        {
            return $"Name: {Name}, MemberCount: {Parameters.Count}";
        }
    }

    class VkFuncDef
    {
        public string Name;
        public string ReturnType;
        public List<ParameterDef> Parameters;

        public VkFuncDef()
        {
            Parameters = new List<ParameterDef>();
        }

        public override string ToString()
        {
            return $"Name: {Name}, ParameterCount: {Parameters.Count}, ReturnType: {ReturnType}";
        }
    }

    class VkDefineDef
    {
        public string Name;
        public string Value;
        public Type ValType;

        public override string ToString()
        {
            return $"Name: {Name}, Value: {Value}";
        }
    }

    class FileParser
    {
        string path;
        string[] files;
        string constFile;
        string enumFile;
        string structFile;
        string unionFile;
        string funcFile;

        public string ConstantFile { get => constFile; }
        public string EnumFile { get => enumFile; }
        public string StructFile { get => structFile; }
        public string UnionFile { get => unionFile; }
        public string FuncFile { get => funcFile; }

        string funcPtrDefs;
        string funcPtrInit;

        List<VkDefineDef> defines;
        List<VkEnumDef> enums;
        List<VkStructDef> structs;
        List<VkStructDef> unions;
        List<VkFuncDef> funcs;
        Dictionary<string, string> typedefs;

        public FileParser(string path, string[] files)
        {
            this.path = path;
            this.files = files;
            defines = new List<VkDefineDef>();
            enums = new List<VkEnumDef>();
            structs = new List<VkStructDef>();
            unions = new List<VkStructDef>();
            funcs = new List<VkFuncDef>();
            typedefs = new Dictionary<string, string>();
        }

        public void Process()
        {
            //read all defines starting with VK, put them in a list
            for (int i = 0; i < files.Length; i++)
                ProcessDefines(File.ReadAllLines(Path.Combine(path, files[i])));
            //read all enums starting with Vk, resolve named values
            for (int i = 0; i < files.Length; i++)
                ProcessEnums(File.ReadAllLines(Path.Combine(path, files[i])));
            //read all structs starting with Vk, convert to correctly sized types
            for (int i = 0; i < files.Length; i++)
                ProcessStructs(File.ReadAllLines(Path.Combine(path, files[i])));
            //read all unions starting with Vk, convert to correctly sized types
            for (int i = 0; i < files.Length; i++)
                ProcessUnions(File.ReadAllLines(Path.Combine(path, files[i])));
            //read all function definitions starting with vk
            for (int i = 0; i < files.Length; i++)
                ProcessFuncs(File.ReadAllLines(Path.Combine(path, files[i])));
            //read all typedefs that aren't struct/enum defs
            for (int i = 0; i < files.Length; i++)
                ProcessTypedefs(File.ReadAllLines(Path.Combine(path, files[i])));

            var keys = typedefs.Keys.ToArray();
            foreach (var k in keys)
            {
                var v = typedefs[k];
                while (typedefs.ContainsKey(v))
                {
                    v = typedefs[v];
                }
                typedefs[k] = CleanTypeName(v);
            }

            for (int i = 0; i < structs.Count; i++)
            {
                ComputeStructSize(structs[i]);
            }

            for (int i = 0; i < unions.Count; i++)
            {
                ComputeUnionSize(unions[i]);
            }

            //emit defines as constants in class: VulkanSharp.Raw.VkDefines
            EmitConstants();

            //emit enums in namespace VulkanSharp.Raw
            EmitEnums();

            //emit structs with layout attributes in namespace VulkanSharp.Raw
            EmitUnions();
            EmitStructs();

            //emit function definitions in class: VulkanSharp.Raw.VkFuncs
            EmitFuncs();

            File.WriteAllText("../../../../vkConsts.cs", constFile);
            File.WriteAllText("../../../../vkEnums.cs", enumFile);
            File.WriteAllText("../../../../vkStructs.cs", structFile);
            File.WriteAllText("../../../../vkUnions.cs", unionFile);
            File.WriteAllText("../../../../vkFuncs.cs", funcFile);
        }

        #region Parser
        private void ProcessDefines(string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                var s = lines[i].Trim();
                if (s.StartsWith("#define VK_"))
                {
                    var p = s.Split(' ').Where(a => !string.IsNullOrWhiteSpace(a)).ToArray();
                    var d = new VkDefineDef();
                    d.Name = p[1];
                    d.Value = p[2];
                    for (int j = 3; j < p.Length; j++)
                        d.Value += " " + p[j];
                    while (d.Value.StartsWith("(") && d.Value.EndsWith(")"))
                        d.Value = d.Value.Substring(1, d.Value.Length - 2);
                    defines.Add(d);
                }
            }
        }

        private void ProcessEnums(string[] lines)
        {
            //check for 'typedef enum'
            //extract name,
            //store values as is, can translate in a separate pass
            VkEnumDef d = null;
            for (int i = 0; i < lines.Length; i++)
            {
                var s = lines[i].Trim();
                var p = s.Split(' ').Where(a => !string.IsNullOrWhiteSpace(a)).ToArray();
                if (s.StartsWith("typedef enum Vk"))
                {
                    d = new VkEnumDef();
                    d.Name = p[2];
                }
                else if (d != null)
                {
                    if (s.StartsWith("}"))
                    {
                        enums.Add(d);
                        d = null;
                    }
                    else
                    {
                        if (p.Length < 3) throw new Exception("Enum member doesn't have a value assigned, will need to track order");
                        var p_v = p[2];
                        for (int j = 3; j < p.Length; j++)
                            p_v += p[j];

                        d.Values.Add(p[0], p_v.Trim(','));
                    }
                }
            }
        }

        private void ProcessStructs(string[] lines)
        {
            //check for 'typedef struct'
            //extract name
            //store values split into type and name
            //convert types and names in a separate pass
            VkStructDef d = null;
            for (int i = 0; i < lines.Length; i++)
            {
                var s = lines[i].Trim();
                var p = s.Split(' ').Where(a => !string.IsNullOrWhiteSpace(a)).ToArray();
                if (s.StartsWith("typedef struct Vk"))
                {
                    d = new VkStructDef();
                    d.Name = p[2];
                }
                else if (d != null)
                {
                    if (s.StartsWith("}"))
                    {
                        structs.Add(d);
                        d = null;
                    }
                    else
                    {
                        if (p.Length < 2) throw new Exception();
                        var tName = "";
                        for (int j = 0; j < p.Length - 1; j++)
                            tName += p[j] + " ";
                        d.Parameters.Add(new ParameterDef()
                        {
                            ParamName = p[p.Length - 1].Trim(';'),
                            TypeName = tName.Trim()
                        });
                    }
                }
            }
        }

        private void ProcessUnions(string[] lines)
        {
            //check for 'typedef struct'
            //extract name
            //store values split into type and name
            //convert types and names in a separate pass
            VkStructDef d = null;
            for (int i = 0; i < lines.Length; i++)
            {
                var s = lines[i].Trim();
                var p = s.Split(' ').Where(a => !string.IsNullOrWhiteSpace(a)).ToArray();
                if (s.StartsWith("typedef union Vk"))
                {
                    d = new VkStructDef();
                    d.Name = p[2];
                }
                else if (d != null)
                {
                    if (s.StartsWith("}"))
                    {
                        unions.Add(d);
                        d = null;
                    }
                    else
                    {
                        if (p.Length < 2) throw new Exception();
                        var tName = "";
                        for (int j = 0; j < p.Length - 1; j++)
                            tName += p[j] + " ";
                        d.Parameters.Add(new ParameterDef()
                        {
                            ParamName = p[p.Length - 1].Trim(';'),
                            TypeName = tName.Trim()
                        });
                    }
                }
            }
        }

        private void ProcessFuncs(string[] lines)
        {
            //check for VKAPI_ATTR
            //extract return type, store name and parameters
            //convert types and names in a separate pass
            VkFuncDef d = null;
            for (int i = 0; i < lines.Length; i++)
            {
                var s = lines[i].Trim();
                var p = s.Split(' ').Where(a => !string.IsNullOrWhiteSpace(a)).ToArray();
                if (s.StartsWith("VKAPI_ATTR"))
                {
                    d = new VkFuncDef();
                    d.ReturnType = "";
                    //stuff between VKAPI_ATTR and VKAPI_CALL is the return type
                    int j = 1;
                    for (; j < p.Length; j++)
                        if (p[j] != "VKAPI_CALL")
                            d.ReturnType += p[j] + " ";
                        else
                        {
                            d.ReturnType = d.ReturnType.Trim();
                            break;
                        }
                    j++;
                    d.Name = p[j].Trim('(');
                }
                else if (d != null)
                {
                    //parse the parameter
                    var tName = "";
                    for (int j = 0; j < p.Length - 1; j++)
                        tName += p[j] + " ";
                    d.Parameters.Add(new ParameterDef()
                    {
                        TypeName = tName.Trim(),
                        ParamName = p[p.Length - 1].Replace(",", "").Replace(");", "")
                    });

                    if (s.EndsWith(");"))
                    {
                        funcs.Add(d);
                        d = null;
                    }
                }
            }
        }

        private void ProcessTypedefs(string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                var s = lines[i].Trim();
                var p = s.Split(' ').Where(a => !string.IsNullOrWhiteSpace(a)).ToArray();
                if (p.Length > 2 && p[0] == "typedef" && p[1] != "enum" && p[1] != "struct" && p[1] != "union" && !s.Contains("VKAPI_PTR"))
                {
                    typedefs.Add(p[2].TrimEnd(';'), p[1]);
                }
                else if (s.StartsWith("VK_DEFINE_HANDLE"))
                {
                    int sV = s.LastIndexOf('(') + 1;
                    var tname = s.Substring(sV, s.IndexOf(')') - sV);

                    typedefs.Add(tname, "IntPtr");
                }
                else if (s.StartsWith("VK_DEFINE_NON_DISPATCHABLE_HANDLE"))
                {
                    int sV = s.LastIndexOf('(') + 1;
                    var tname = s.Substring(sV, s.IndexOf(')') - sV);

                    typedefs.Add(tname, "IntPtr");
                }
            }
        }
        #endregion

        private int GetDefineValue(VkDefineDef d)
        {
            return int.Parse(d.Value);
        }

        private string CleanItemName(string tn)
        {
            if (tn == "object")
                return "@object";
            if (tn == "event")
                return "@event";
            return tn;
        }

        private string CleanTypeName(string tn)
        {
            int end_ptr = 0;
            var p = tn.Split(' ').ToList();
            for (int i = 0; i < p.Count; i++)
                if (p[i] == "const")
                    p.RemoveAt(i--);
                else if (p[i] == "const*")
                {
                    end_ptr++;
                    p.RemoveAt(i--);
                }
                else if (p[i] == "*")
                {
                    end_ptr++;
                    p.RemoveAt(i--);
                }
            if (p.Count > 1)
            {
#warning Add smarter handling for non-typedef struct pointers
                if (p[0] == "struct")
                    return "IntPtr";
                throw new Exception("More typename parts than expected.");
            }
            end_ptr += p[0].ToCharArray().Count(a => a == '*');
            tn = p[0].Trim('*');
            if (typedefs.ContainsKey(tn))
                tn = typedefs[tn];

            if (tn.StartsWith("PFN_"))
                tn = "IntPtr";
            while (end_ptr-- > 0)
                tn += "*";

            switch (tn)
            {
                case "uint8_t":
                    tn = "byte";
                    break;
                case "uint8_t*":
                    tn = "byte*";
                    break;
                case "uint16_t":
                    tn = "ushort";
                    break;
                case "uint16_t*":
                    tn = "ushort*";
                    break;
                case "uint32_t":
                    tn = "uint";
                    break;
                case "uint32_t*":
                    tn = "uint*";
                    break;
                case "int32_t":
                    tn = "int";
                    break;
                case "int32_t*":
                    tn = "int*";
                    break;
                case "uint64_t":
                    tn = "ulong";
                    break;
                case "uint64_t*":
                    tn = "ulong*";
                    break;
                case "int64_t":
                    tn = "long";
                    break;
                case "int64_t*":
                    tn = "long*";
                    break;
                case "size_t":
                    tn = "ulong";
                    break;
                case "size_t*":
                    tn = "ulong*";
                    break;
                case "void*":
                    tn = "IntPtr";
                    break;
                case "char*":
                    tn = "string";
                    break;
                case "char**":
                    tn = "string[]";
                    break;
                case "HANDLE":
                case "HWND":
                case "HINSTANCE":
                case "HMONITOR":
                case "Window":
                case "VisualID":
                case "Display*":
                    tn = "IntPtr";
                    break;
                case "HANDLE*":
                case "SECURITY_ATTRIBUTES*":
                    tn = "IntPtr*";
                    break;
                case "LPCWSTR":
                    tn = "string";
                    break;
                case "DWORD":
                    tn = "uint";
                    break;
                default:
                    break;
            }

            return tn;
        }

        private int GetTypeSize(string tn)
        {
            unsafe
            {
                int end_ptr = tn.ToCharArray().Count(a => a == '*');
                tn = tn.Trim('*');
                if (end_ptr > 0) return sizeof(IntPtr);

                switch (tn)
                {
                    case "byte":
                        return sizeof(byte);
                    case "char":
                        return sizeof(byte);
                    case "ushort":
                        return sizeof(ushort);
                    case "uint":
                        return sizeof(uint);
                    case "int":
                        return sizeof(int);
                    case "float":
                        return sizeof(float);
                    case "double":
                        return sizeof(double);
                    case "ulong":
                        return sizeof(ulong);
                    case "long":
                        return sizeof(long);
                    case "string":
                    case "IntPtr":
                    case "UIntPtr":
                    case "Window":
                        return sizeof(IntPtr);
                    case "string[]":
                        return sizeof(IntPtr);
                    default:
                        if (enums.Any(a => a.Name == tn))
                            return sizeof(int);
                        if (structs.Any(a => a.Name == tn))
                        {
                            var v = structs.Find(a => a.Name == tn);
                            if (v.Len == 0) ComputeStructSize(v);
                            return v.Len;
                        }
                        if (unions.Any(a => a.Name == tn))
                        {
                            var v = unions.Find(a => a.Name == tn);
                            if (v.Len == 0) ComputeUnionSize(v);
                            return v.Len;
                        }
                        if (structs.Any(a => a.Name + "[]" == tn))
                        {
                            return 8;
                        }
                        if (unions.Any(a => a.Name + "[]" == tn))
                        {
                            return 8;
                        }
                        throw new Exception("Unrecognized Type");
                }
            }
        }

        private int GetElementCount(ref string name)
        {
            int cnt = 1;
            var p = name.Split('[');
            if (p.Length > 1)
            {
                var elen_str = p[1].Trim(']');
                if (!int.TryParse(elen_str, out cnt))
                    cnt = GetDefineValue(defines.Find(a => a.Name == elen_str));
                name = p[0] + "[" + cnt + "]";
            }
            return cnt;
        }
        private void ComputeStructSize(VkStructDef d)
        {
            int off = 0;
            for (int j = 0; j < d.Parameters.Count; j++)
            {
                int element_sz = GetTypeSize(CleanTypeName(d.Parameters[j].TypeName));
                if (off % element_sz != 0) off += element_sz - (off % element_sz);
                d.Parameters[j].Offset = off;

                int cnt = GetElementCount(ref d.Parameters[j].ParamName);
                d.Parameters[j].ElementCount = cnt;
                off += cnt * element_sz;
            }
            d.Len = off;
        }

        private void ComputeUnionSize(VkStructDef d)
        {
            int off = 0;
            for (int j = 0; j < d.Parameters.Count; j++)
            {
                d.Parameters[j].Offset = 0;
                int element_sz = GetTypeSize(CleanTypeName(d.Parameters[j].TypeName));
                off = Math.Max(off, element_sz);
            }
            d.Len = off;
        }

        #region Emitter
        private string ConvertConstName(string n, bool rmVk = false)
        {
            //return n;
            if (int.TryParse(n, out _))
                return n;

            string convertPart(string n)
            {
                if (int.TryParse(n, out _))
                    return n;

                var p = n.Split('_');
                var p_str = "";
                for (int i = 0; i < p.Length; i++)
                {
                    if (rmVk && p[i] == "VK") continue;
                    var tmp = char.ToUpper(p[i][0]) + p[i].ToLowerInvariant().Substring(1);
                    p_str += tmp;
                }
                return p_str;
            }

            var p0_str = "";
            var p0 = n.Split('-');
            for (int i = 0; i < p0.Length; i++)
            {
                var p1_str = "";
                var p1 = p0[i].Split(' ');
                for (int j = 0; j < p1.Length; j++)
                {
                    bool hasLParen = p1[j].StartsWith('(');
                    bool hasRParen = p1[j].EndsWith(')');

                    p1_str += convertPart(p1[j].TrimStart('(').TrimEnd(')')) + " ";

                    if (hasLParen) p1_str = "(" + p1_str;
                    if (hasRParen) p1_str += ")";
                }
                p1_str = p1_str.Trim();
                p0_str += p1_str + "-";
            }
            return p0_str.Trim('-');
        }

        private void EmitConstants()
        {
            constFile = "namespace VulkanSharp.Raw {\n";
            constFile += "\tpublic unsafe static partial class Vk {\n";

            void handleDef(VkDefineDef d)
            {
                if (int.TryParse(d.Value, out _))
                {
                    constFile += $"\t\t\tpublic const int {ConvertConstName(d.Name)} = {d.Value};\n";
                    d.ValType = typeof(int);
                }
                else if ((d.Value.EndsWith("f") | d.Value.EndsWith("F")) && float.TryParse(d.Value.TrimEnd('f').TrimEnd('F'), out _))
                {
                    constFile += $"\t\t\tpublic const float {ConvertConstName(d.Name)} = {d.Value};\n";
                    d.ValType = typeof(float);
                }
                else if ((d.Value.EndsWith("u") | d.Value.EndsWith("U")) && uint.TryParse(d.Value.TrimStart('~').TrimEnd('u').TrimEnd('U'), out _))
                {
                    constFile += $"\t\t\tpublic const uint {ConvertConstName(d.Name)} = {d.Value};\n";
                    d.ValType = typeof(uint);
                }
                else if ((d.Value.EndsWith("ull") | d.Value.EndsWith("ULL")) && ulong.TryParse(d.Value.TrimStart('~').Replace("ull", "").Replace("ULL", ""), out _))
                {
                    constFile += $"\t\t\tpublic const ulong {ConvertConstName(d.Name)} = {d.Value.Substring(0, d.Value.Length - 1)};\n";
                    d.ValType = typeof(ulong);
                }
                else if (d.Value.StartsWith("\""))
                {
                    constFile += $"\t\t\tpublic const string {ConvertConstName(d.Name)} = {d.Value};\n";
                    d.ValType = typeof(string);
                }
                else if (d.Name.StartsWith("VK_MAKE_VERSION"))
                {
                    //skip
#warning May need proper handling and parsing
                }
                else if (d.Name.StartsWith("VK_VERSION_MAJOR"))
                {
                    //skip
#warning May need proper handling and parsing
                }
                else if (d.Name.StartsWith("VK_VERSION_MINOR"))
                {
                    //skip
#warning May need proper handling and parsing
                }
                else if (d.Name.StartsWith("VK_VERSION_PATCH"))
                {
                    //skip
#warning May need proper handling and parsing
                }
                else if (d.Name.StartsWith("VK_DEFINE_HANDLE"))
                {
                    //skip
#warning May need proper handling and parsing
                }
                else if (d.Name.StartsWith("VK_DEFINE_NON_DISPATCHABLE_HANDLE"))
                {
                    //skip
#warning May need proper handling and parsing
                }
                else if (d.Value.StartsWith("VK_MAKE_VERSION"))
                {
                    //generate value
                    int startV = d.Value.LastIndexOf('(') + 1;
                    var v = d.Value.Substring(startV, d.Value.IndexOf(')') - startV).Split(',').ToArray();
                    uint major = uint.Parse(v[0]);
                    uint minor = uint.Parse(v[1]);
                    uint patch = uint.Parse(v[2]);

                    constFile += $"\t\t\tpublic const uint {ConvertConstName(d.Name)} = {((major) << 22) | ((minor) << 12) | (patch)};\n";
                    d.ValType = typeof(uint);
                }
                else if (d.Value.Contains('-'))
                {
                    //~0U-N
                    constFile += $"\t\t\tpublic const uint {ConvertConstName(d.Name)} = {d.Value};\n";
                    d.ValType = typeof(uint);
                }
                else if (defines.Any(a => a.Name == d.Value))
                {
                    for (int j = 0; j < defines.Count; j++)
                        if (defines[j].Name == d.Value)
                        {
                            if (defines[j].ValType == null)
                                handleDef(defines[j]);
                            constFile += $"\t\t\tpublic const {defines[j].ValType.FullName} {ConvertConstName(d.Name)} = {ConvertConstName(d.Value)};\n";
                            break;
                        }
                }
                else throw new Exception("Unknown Constant Value Type");
            }


            for (int i = 0; i < defines.Count; i++)
            {
                var d = defines[i];
                if (d.ValType == null)
                    handleDef(d);
            }

            constFile += "\t}\n";
            constFile += "}\n";
        }

        private void EmitEnums()
        {
            enumFile = "namespace VulkanSharp.Raw {\n";
            enumFile += "\tpublic unsafe static partial class Vk {\n";
            for (int i = 0; i < enums.Count; i++)
            {
                var d = enums[i];
                var dict = new Dictionary<string, string>();
                enumFile += $"\t\tpublic enum {d.Name} {{\n";
                foreach (var kvp in d.Values)
                {
                    //Convert enum name
                    var k = ConvertConstName(kvp.Key, true);
                    var v = ConvertConstName(kvp.Value, true);

                    if (!dict.ContainsKey(k))
                    {
                        dict[k] = v;
                        enumFile += $"\t\t\t{k} = {v},\n";
                    }
                }
                enumFile += "\t\t}\n";
            }
            enumFile += "\t}\n";
            enumFile += "}\n";
        }

        private void EmitUnions()
        {
            unionFile = "using System;\nusing System.Runtime.InteropServices;\nnamespace VulkanSharp.Raw {\n";
            unionFile += "\tpublic unsafe static partial class Vk {\n";
            for (int i = 0; i < unions.Count; i++)
            {
                var d = unions[i];
                unionFile += $"\t\t[StructLayout(LayoutKind.Explicit, CharSet = CharSet.{(d.Name.Contains("Win32") ? CharSet.Unicode : CharSet.Ansi)})]\n";
                unionFile += $"\t\tpublic unsafe struct {d.Name} {{\n";
                foreach (var kvp in d.Parameters)
                {
                    if (kvp.ParamName.Contains('['))
                    {
                        var tn = CleanTypeName(kvp.TypeName);
                        if (tn == "byte" || tn == "short" || tn == "int" || tn == "long" || tn == "ushort")
                            unionFile += $"\t\t\t[FieldOffset({kvp.Offset})]public fixed {tn} {CleanItemName(kvp.ParamName)};\n";
                        else
                            unionFile += $"\t\t\t[FieldOffset({kvp.Offset})][MarshalAs(UnmanagedType.ByValArray, SizeConst={kvp.ElementCount})] public {tn}[] {CleanItemName(kvp.ParamName).Split('[')[0]};\n";
                    }
                    else
                    {
                        var attr = "";
                        var tn = CleanTypeName(kvp.TypeName);
                        if (structs.Any(a => tn == a.Name + "*"))
                        {
                            tn = tn.Trim('*') + "[]";
                            attr = "[MarshalAs(UnmanagedType.LPArray)]";
                        }
                        if (unions.Any(a => tn == a.Name + "*"))
                        {
                            tn = tn.Trim('*') + "[]";
                            attr = "[MarshalAs(UnmanagedType.LPArray)]";
                        }
                        unionFile += $"\t\t\t[FieldOffset({kvp.Offset})]{attr}public {tn} {CleanItemName(kvp.ParamName)};\n";
                    }
                }
                unionFile += "\t\t}\n";
            }
            unionFile += "\t}\n";
            unionFile += "}\n";
        }

        private void EmitStructs()
        {
            structFile = "using System;\nusing System.Runtime.InteropServices;\nnamespace VulkanSharp.Raw {\n";
            structFile += "\tpublic unsafe static partial class Vk {\n";
            for (int i = 0; i < structs.Count; i++)
            {
                var d = structs[i];
                structFile += $"\t\t[StructLayout(LayoutKind.Explicit, CharSet = CharSet.{(d.Name.Contains("Win32") ? CharSet.Unicode : CharSet.Ansi)})]\n";
                structFile += $"\t\tpublic unsafe struct {d.Name} {{\n";
                foreach (var kvp in d.Parameters)
                {
                    //if (typedefs.ContainsKey(kvp.TypeName.TrimEnd('*')))
                    if (kvp.ParamName.Contains('['))
                    {
                        var tn = CleanTypeName(kvp.TypeName);
                        if (tn == "byte" || tn == "short" || tn == "int" || tn == "long" || tn == "ushort")
                            structFile += $"\t\t\t[FieldOffset({kvp.Offset})]public fixed {tn} {CleanItemName(kvp.ParamName)};\n";
                        else
                            structFile += $"\t\t\t[FieldOffset({kvp.Offset})][MarshalAs(UnmanagedType.ByValArray, SizeConst={kvp.ElementCount})] public {tn}[] {CleanItemName(kvp.ParamName).Split('[')[0]};\n";
                    }
                    else
                    {
                        var attr = "";
                        var tn = CleanTypeName(kvp.TypeName);
                        if (structs.Any(a => tn == a.Name + "*"))
                        {
                            tn = tn.Trim('*') + "[]";
                            attr = "[MarshalAs(UnmanagedType.ByValArray)]";
                        }
                        if (unions.Any(a => tn == a.Name + "*"))
                        {
                            tn = tn.Trim('*') + "[]";
                            attr = "[MarshalAs(UnmanagedType.ByValArray)]";
                        }
                        if (tn == "string[]")
                        {
                            attr = "[MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.LPStr)]";
                        }
                        structFile += $"\t\t\t[FieldOffset({kvp.Offset})]{attr}public {tn} {CleanItemName(kvp.ParamName)};\n";
                    }
                }
                structFile += "\t\t}\n";
            }
            structFile += "\t}\n";
            structFile += "}\n";
        }

        private void EmitFuncs()
        {
            funcPtrInit += "\t\tprivate static void InitPtrs() {\n";

            funcFile = "using System;\nusing System.Runtime.InteropServices;\nnamespace VulkanSharp.Raw {\n";
            funcFile += "\tpublic unsafe static partial class Vk {\n";
            for (int i = 0; i < funcs.Count; i++)
            {
                funcPtrDefs += $"\t\tinternal static IntPtr {funcs[i].Name}_hndl;\n";
                funcPtrInit += $"\t\t\tNativeLibrary.TryGetExport(libHndl, \"{funcs[i].Name}\", out {funcs[i].Name}_hndl);\n";

                funcFile += $"\t\tpublic static {CleanTypeName(funcs[i].ReturnType)} {funcs[i].Name}(";
                for (int j = 0; j < funcs[i].Parameters.Count; j++)
                {
                    if (funcs[i].Parameters[j].ParamName.Contains('['))
                    {
                        funcs[i].Parameters[j].ElementCount = GetElementCount(ref funcs[i].Parameters[j].ParamName);
                        var tn = CleanTypeName(funcs[i].Parameters[j].TypeName);
                        funcFile += $"[MarshalAs(UnmanagedType.LPArray, SizeConst={funcs[i].Parameters[j].ElementCount})] {tn}[] {CleanItemName(funcs[i].Parameters[j].ParamName).Split('[')[0]}, ";
                    }
                    else
                    {
                        var attr = "";
                        var tn = CleanTypeName(funcs[i].Parameters[j].TypeName);
                        if (structs.Any(a => tn == a.Name + "*"))
                        {
                            tn = tn.Trim('*') + "[]";
                            attr = "[MarshalAs(UnmanagedType.LPArray)]";
                        }
                        if (unions.Any(a => tn == a.Name + "*"))
                        {
                            tn = tn.Trim('*') + "[]";
                            attr = "[MarshalAs(UnmanagedType.LPArray)]";
                        }
                        funcFile += $"{attr}{tn} {CleanItemName(funcs[i].Parameters[j].ParamName)}, ";
                    }
                }
                funcFile = funcFile.Trim().Trim(',');
                funcFile += ") { throw new NotImplementedException(); }\n";
            }
            funcPtrInit += "\t\t}\n";

            funcFile += funcPtrDefs;
            funcFile += funcPtrInit;

            funcFile += "\t}\n";
            funcFile += "}\n";

            funcPtrDefs += "}\n";
        }
        #endregion
    }
}
