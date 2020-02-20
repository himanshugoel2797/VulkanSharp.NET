using System;
using System.Collections.Generic;

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
        }
    }
}
