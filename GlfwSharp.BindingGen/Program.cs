using Mono.Cecil;
using Mono.Cecil.Cil;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace GlfwSharp.BindingGen
{
    class Program
    {
        static List<string> files;
        static string path = @"I:\glfw-3.3.1.bin.WIN64\include\GLFW";

        static void Main(string[] args)
        {
            files = new List<string>();

            files.Add("glfw3.h");

            FileParser p = new FileParser(path, files.ToArray());
            p.Process();

            //Rewrite
            var process = Process.Start(new ProcessStartInfo()
            {
                FileName = "dotnet",
                Arguments = "clean ../../../../GlfwSharp.NET/GlfwSharp.NET.csproj -c Release",
                WorkingDirectory = Environment.CurrentDirectory
            });
            process.WaitForExit();
            process = Process.Start(new ProcessStartInfo()
            {
                FileName = "dotnet",
                Arguments = "build ../../../../GlfwSharp.NET/GlfwSharp.NET.csproj -c Release",
                WorkingDirectory = Environment.CurrentDirectory
            });
            process.WaitForExit();

            //Load assembly
            ModuleDefinition mod = ModuleDefinition.ReadModule("../../../../GlfwSharp.NET/bin/Release/netcoreapp3.1/GlfwSharp.NET.dll");

            //generate interface implementation
            foreach (TypeDefinition type in mod.Types)
                if (type.Name == "Glfw")
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
            mod.Write("../../../../GlfwSharp.NET.dll");
        }
    }
}
