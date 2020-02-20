using Mono.Cecil;
using Mono.Cecil.Cil;
using System;

namespace VukanSharp.Rewrite
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"I:\Code\VulkanSharp.NET\VulkanSharp.NET\bin\Debug\netcoreapp3.1\VulkanSharp.NET.dll";
            string outFile = "../../../../VulkanSharp.NET.dll";

            //Load assembly
            ModuleDefinition mod = ModuleDefinition.ReadModule(filename);

            //generate interface implementation
            foreach (TypeDefinition type in mod.Types)
                if (type.Name == "VkFuncs")
                    foreach (MethodDefinition mthd in type.Methods)
                        if (!mthd.IsConstructor && mthd.IsStatic && mthd.Name != "InitPtrs")
                        {

                            FieldReference f = null;
                            for (int i = 0; i < type.Fields.Count; i++)
                                if (type.Fields[i].Name == mthd.Name + "_hndl")
                                {
                                    f = type.Fields[i];
                                    break;
                                }
                            if (f == null) throw new Exception("Field not found.");

                            var proc = mthd.Body.GetILProcessor();
                            for (int i = 0; i < proc.Body.Instructions.Count; i++)
                                proc.Remove(proc.Body.Instructions[i--]);

                            //Load pointer value
                            for (int i = 0; i < mthd.Parameters.Count; i++)
                                proc.Emit(OpCodes.Ldarg, i);

                            proc.Emit(OpCodes.Ldsfld, f);
                            //Calli
                            var cSite = new CallSite(mthd.ReturnType);
                            for (int i = 0; i < mthd.Parameters.Count; i++) cSite.Parameters.Add(mthd.Parameters[i]);
                            cSite.CallingConvention = MethodCallingConvention.StdCall;
                            cSite.HasThis = false;
                            
                            proc.Emit(OpCodes.Calli, cSite);
                            proc.Emit(OpCodes.Ret);
                        }
            mod.Write(outFile);
        }
    }
}
