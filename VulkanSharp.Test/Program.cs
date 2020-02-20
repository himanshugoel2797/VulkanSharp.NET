using System;
using VulkanSharp.Raw;

namespace VulkanSharp.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                IntPtr inst = IntPtr.Zero;
                var res = VkFuncs.vkCreateInstance(new VkInstanceCreateInfo[]
                {
                    new VkInstanceCreateInfo()
                    {
                        sType = VkStructureType.VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO,
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
                                sType = VkStructureType.VK_STRUCTURE_TYPE_APPLICATION_INFO,
                                pApplicationName = "Vulkan Test",
                                pEngineName = "Test Engine",
                                apiVersion = VkDefines.VK_API_VERSION_1_2,
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
