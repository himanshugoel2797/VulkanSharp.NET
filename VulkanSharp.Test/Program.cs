using System;
using static VulkanSharp.Raw.Vk;
using static VulkanSharp.Raw.Glfw;

namespace VulkanSharp.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                glfwInit();
                glfwWindowHint(GlfwClientApi, GlfwNoApi);
                glfwWindowHint(GlfwResizable, GlfwFalse);
                var window = glfwCreateWindow(800, 600, "Vulkan", null, null);

                while(glfwWindowShouldClose(window) == 0)
                {
                    glfwPollEvents();
                }
                glfwDestroyWindow(window);
                glfwTerminate();

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
