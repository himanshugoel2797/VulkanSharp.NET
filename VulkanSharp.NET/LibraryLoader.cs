﻿using System;
using System.Runtime.InteropServices;

namespace VulkanSharp.Raw
{
    public unsafe static partial class Vk
    {
        static IntPtr libHndl;
        static Vk()
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
