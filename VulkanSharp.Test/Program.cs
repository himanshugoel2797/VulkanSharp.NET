using System;
using static VulkanSharp.Raw.VkFuncs;

namespace VulkanSharp.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                IntPtr inst = IntPtr.Zero;
                var res = vkCreateInstance(new VkInstanceCreateInfo[]
                {
                    new VkInstanceCreateInfo()
                    {
                        sType = VkStructureType.StructureTypeInstanceCreateInfo,
                        enabledExtensionCount = 0,
                        enabledLayerCount = 0,
                        flags = 0,
                        pNext = IntPtr.Zero,
                        ppEnabledExtensionNames = null,
                        ppEnabledLayerNames = null,
                        pApplicationInfo = new VkApplicationInfo[]
                        {
                            new VkApplicationInfo()
                            {
                                sType = VkStructureType.StructureTypeApplicationInfo,
                                pApplicationName = "Vulkan Test",
                                pEngineName = "Test Engine",
                                apiVersion = VkApiVersion12,
                                applicationVersion = 0,
                                engineVersion = 0,
                                pNext = IntPtr.Zero
                            }
                        }
                    }
                }, null, &inst);
                Console.WriteLine(res);
            }
        }
    }
}
