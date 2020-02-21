using System;
using System.Runtime.InteropServices;

namespace VulkanSharp.Raw
{
    public unsafe static partial class Glfw
    {
        static IntPtr libHndl;
        static Glfw()
        {
            bool isLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);

            string libname = "glfw3.dll";
            if (isLinux) libname = "libglfw.so.3";

            libHndl = NativeLibrary.Load(libname);
            InitPtrs();
        }
    }
}
