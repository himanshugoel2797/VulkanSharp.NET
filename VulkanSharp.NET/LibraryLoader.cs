using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace VulkanSharp.Raw
{
    public unsafe static partial class VkFuncs
    {
        static IntPtr libHndl;
        static VkFuncs()
        {
            //Load assembly based on platform
            bool isLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);

            string libname = "vulkan-1.dll";
            if (isLinux) libname = "libvulkan.so.1";

            libHndl = NativeLibrary.Load(libname);
            InitPtrs();
        }
    }
}
