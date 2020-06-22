using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Rocks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace VulkanSharp.BindingGen
{
    static class Extensions
    {
        public static TypeReference MakeGenericType(this TypeReference self, params TypeReference[] arguments)
        {
            if (self.GenericParameters.Count != arguments.Length)
                throw new ArgumentException();

            var instance = new GenericInstanceType(self);
            foreach (var argument in arguments)
                instance.GenericArguments.Add(argument);

            return instance;
        }
        public static MethodReference MakeGeneric(this MethodReference self, params TypeReference[] arguments)
        {
            var reference = new MethodReference(self.Name, self.ReturnType)
            {
                DeclaringType = self.DeclaringType.MakeGenericType(arguments),
                HasThis = self.HasThis,
                ExplicitThis = self.ExplicitThis,
                CallingConvention = self.CallingConvention,
            };

            foreach (var parameter in self.Parameters)
                reference.Parameters.Add(new ParameterDefinition(parameter.ParameterType));

            foreach (var generic_parameter in self.GenericParameters)
                reference.GenericParameters.Add(new GenericParameter(generic_parameter.Name, reference));

            return reference;
        }
    }

    class Program
    {
        static List<string> files;
        static string path = @"I:\VulkanSDK\1.2.141.2\Include\vulkan"; //@"/usr/include/vulkan";
        static void Main(string[] args)
        {
            files = new List<string>();

            files.Add("vulkan_win32.h");
            files.Add("vulkan_wayland.h");
            files.Add("vulkan_xlib.h");
            files.Add("vulkan_core.h");

            FileParser p = new FileParser(path, files.ToArray());
            p.Process();

            //Rewrite
            var process = Process.Start(new ProcessStartInfo()
            {
                FileName = "dotnet",
                Arguments = "clean ../../../../VulkanSharp.NET/VulkanSharp.NET.csproj -c Release",
                WorkingDirectory = Environment.CurrentDirectory
            });
            process.WaitForExit();
            process = Process.Start(new ProcessStartInfo()
            {
                FileName = "dotnet",
                Arguments = "build ../../../../VulkanSharp.NET/VulkanSharp.NET.csproj -c Release",
                WorkingDirectory = Environment.CurrentDirectory
            });
            process.WaitForExit();

            //Load assembly
            ModuleDefinition mod = ModuleDefinition.ReadModule("../../../../VulkanSharp.NET/bin/Release/netcoreapp3.1/VulkanSharp.NET.dll");

            //find relevant cast function

            MethodDefinition ptr_def = null;
            MethodReference ptr_def_ref = null;
            foreach (TypeDefinition type in mod.Types)
                if (type.Name == "ManagedPtrArray`1")
                    foreach (MethodDefinition mthd in type.Methods)
                        if (mthd.Name == "get_Pointer")
                        {
                            ptr_def = mthd;
                            ptr_def_ref = mod.ImportReference(ptr_def);
                            break;
                        }

            //generate interface implementation
            var intptr_type = mod.ImportReference(typeof(IntPtr));
            foreach (TypeDefinition type in mod.Types)
                if (type.Name == "Vk" || type.Name == "Vma")
                    foreach (MethodDefinition mthd in type.Methods)
                        if (!mthd.IsConstructor && mthd.IsStatic && mthd.Name != "InitPtrs" && mthd.Name != "Pointer")
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
                                if (mthd.Parameters[i].ParameterType.Name == "ManagedPtrArray`1")
                                {
                                    var l0 = proc.Create(OpCodes.Ldarg, i);
                                    var l1 = proc.Create(OpCodes.Nop);

                                    proc.Emit(OpCodes.Ldarg, i);
                                    //if (arg != null) l0
                                    proc.Emit(OpCodes.Brtrue_S, l0);
                                    proc.Emit(OpCodes.Ldc_I4_0);
                                    proc.Emit(OpCodes.Conv_I);
                                    proc.Emit(OpCodes.Br_S, l1);
                                    //goto l1
                                    //l0:
                                    proc.Append(l0);
                                    proc.Emit(OpCodes.Callvirt, ptr_def_ref.MakeGeneric(((GenericInstanceType)mthd.Parameters[i].ParameterType).GenericArguments.ToArray()));
                                    //l1:
                                    proc.Append(l1);
                                }
                                else
                                {
                                    proc.Emit(OpCodes.Ldarg, i);
                                }

                            proc.Emit(OpCodes.Ldsfld, f);
                            //Calli
                            var cSite = new CallSite(mthd.ReturnType);
                            for (int i = 0; i < mthd.Parameters.Count; i++)
                                if (mthd.Parameters[i].ParameterType.Name == "ManagedPtrArray`1")
                                {
                                    cSite.Parameters.Add(new ParameterDefinition(intptr_type));
                                }
                                else
                                {
                                    cSite.Parameters.Add(mthd.Parameters[i]);
                                }
                            cSite.CallingConvention = MethodCallingConvention.StdCall;
                            cSite.HasThis = false;

                            proc.Emit(OpCodes.Calli, cSite);
                            proc.Emit(OpCodes.Ret);
                        }
            mod.Write("../../../../VulkanSharp.NET.dll");
            Console.WriteLine("Done!");
        }
    }
}
