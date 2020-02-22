using Mono.Cecil;
using Mono.Cecil.Cil;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace VulkanSharp.BindingGen
{
    class Program
    {
        static List<string> files;
        static string path = @"I:\VulkanSDK\1.2.131.2\Include\vulkan";

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
            process = Process.Start( new ProcessStartInfo()
            {
                FileName = "dotnet",
                Arguments = "build ../../../../VulkanSharp.NET/VulkanSharp.NET.csproj -c Release",
                WorkingDirectory = Environment.CurrentDirectory
            });
            process.WaitForExit();

            //Load assembly
            ModuleDefinition mod = ModuleDefinition.ReadModule("../../../../VulkanSharp.NET/bin/Release/netcoreapp3.1/VulkanSharp.NET.dll");

            //generate interface implementation
            foreach (TypeDefinition type in mod.Types)
                if (type.Name == "Vk")
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
            mod.Write("../../../../VulkanSharp.NET.dll");
        }
    }
}
