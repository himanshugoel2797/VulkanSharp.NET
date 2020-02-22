using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using static VulkanSharp.Raw.Vk;

namespace VulkanSharp.Raw
{
    public static unsafe class Vma
    {
        static IntPtr libHndl;
        static Vma()
        {
            //Load assembly based on platform
            bool isLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);

            string libname = "VulkanMemoryAllocator.dll";
            if (isLinux) libname = "libVulkanMemoryAllocator.so";

            libHndl = NativeLibrary.Load(libname);
            InitPtrs();
        }

        public enum VmaAllocatorCreateFlagBits
        {
            VMA_ALLOCATOR_CREATE_EXTERNALLY_SYNCHRONIZED_BIT = 0x00000001,
            VMA_ALLOCATOR_CREATE_KHR_DEDICATED_ALLOCATION_BIT = 0x00000002,
            VMA_ALLOCATOR_CREATE_KHR_BIND_MEMORY2_BIT = 0x00000004,
            VMA_ALLOCATOR_CREATE_EXT_MEMORY_BUDGET_BIT = 0x00000008,
            VMA_ALLOCATOR_CREATE_AMD_DEVICE_COHERENT_MEMORY_BIT = 0x00000010,

            VMA_ALLOCATOR_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
        }

        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
        public unsafe struct VmaAllocatorCreateInfo
        {
            [FieldOffset(0)] public uint flags;
            [FieldOffset(8)] public IntPtr physicalDevice;
            [FieldOffset(16)] public IntPtr device;
            [FieldOffset(24)] public ulong preferredLargeHeapBlockSize;
            [FieldOffset(32)] public IntPtr pAllocationCallbacks;
            [FieldOffset(40)] public IntPtr pDeviceMemoryCallbacks;
            [FieldOffset(48)] public uint frameInUseCount;
            [FieldOffset(56)] public ulong* pHeapSizeLimit;
            [FieldOffset(64)] public IntPtr pVulkanFunctions;
            [FieldOffset(72)] public IntPtr pRecordSettings;
            [FieldOffset(80)] public IntPtr instance;
            [FieldOffset(88)] public uint vulkanApiVersion;
        }
        public static ManagedPtr<VmaAllocatorCreateInfo> Pointer(this VmaAllocatorCreateInfo i) => new ManagedPtr<VmaAllocatorCreateInfo>(i);
        public static ManagedPtrArray<VmaAllocatorCreateInfo> Pointer(this VmaAllocatorCreateInfo[] i) => new ManagedPtrArray<VmaAllocatorCreateInfo>(i);
        public static VkResult vmaCreateAllocator(IntPtr pCreateInfo, IntPtr* pAllocator) { throw new NotImplementedException(); }
        public static void vmaDestroyAllocator(IntPtr pAllocator) { throw new NotImplementedException(); }

        public enum VmaMemoryUsage
        {
            MEMORY_USAGE_UNKNOWN = 0,
            MEMORY_USAGE_GPU_ONLY = 1,
            MEMORY_USAGE_CPU_ONLY = 2,
            MEMORY_USAGE_CPU_TO_GPU = 3,
            MEMORY_USAGE_GPU_TO_CPU = 4,
            MEMORY_USAGE_CPU_COPY = 5,
            MEMORY_USAGE_GPU_LAZILY_ALLOCATED = 6,
            MEMORY_USAGE_MAX_ENUM = 0x7FFFFFFF
        }

        public enum VmaAllocationCreateFlags
        {
            ALLOCATION_CREATE_DEDICATED_MEMORY_BIT = 0x00000001,
            ALLOCATION_CREATE_NEVER_ALLOCATE_BIT = 0x00000002,
            ALLOCATION_CREATE_MAPPED_BIT = 0x00000004,
            ALLOCATION_CREATE_CAN_BECOME_LOST_BIT = 0x00000008,
            ALLOCATION_CREATE_CAN_MAKE_OTHER_LOST_BIT = 0x00000010,
            ALLOCATION_CREATE_USER_DATA_COPY_STRING_BIT = 0x00000020,
            ALLOCATION_CREATE_UPPER_ADDRESS_BIT = 0x00000040,
            ALLOCATION_CREATE_DONT_BIND_BIT = 0x00000080,
            ALLOCATION_CREATE_WITHIN_BUDGET_BIT = 0x00000100,
            ALLOCATION_CREATE_STRATEGY_BEST_FIT_BIT = 0x00010000,
            ALLOCATION_CREATE_STRATEGY_WORST_FIT_BIT = 0x00020000,
            ALLOCATION_CREATE_STRATEGY_FIRST_FIT_BIT = 0x00040000,
            ALLOCATION_CREATE_STRATEGY_MIN_MEMORY_BIT = ALLOCATION_CREATE_STRATEGY_BEST_FIT_BIT,
            ALLOCATION_CREATE_STRATEGY_MIN_TIME_BIT = ALLOCATION_CREATE_STRATEGY_FIRST_FIT_BIT,
            ALLOCATION_CREATE_STRATEGY_MIN_FRAGMENTATION_BIT = ALLOCATION_CREATE_STRATEGY_WORST_FIT_BIT,

            ALLOCATION_CREATE_STRATEGY_MASK =
            ALLOCATION_CREATE_STRATEGY_BEST_FIT_BIT |
            ALLOCATION_CREATE_STRATEGY_WORST_FIT_BIT |
            ALLOCATION_CREATE_STRATEGY_FIRST_FIT_BIT,
            ALLOCATION_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
        }

        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
        public unsafe struct VmaAllocationCreateInfo
        {
            [FieldOffset(0)] public VmaAllocationCreateFlags flags;
            [FieldOffset(4)] public VmaMemoryUsage usage;
            [FieldOffset(8)] public VkMemoryPropertyFlags requiredFlags;
            [FieldOffset(12)] public VkMemoryPropertyFlags preferredFlags;
            [FieldOffset(16)] public uint memoryTypeBits;
            [FieldOffset(24)] public IntPtr pool;
            [FieldOffset(32)] public void* pUserData;
        }
        public static ManagedPtr<VmaAllocationCreateInfo> Pointer(this VmaAllocationCreateInfo i) => new ManagedPtr<VmaAllocationCreateInfo>(i);
        public static ManagedPtrArray<VmaAllocationCreateInfo> Pointer(this VmaAllocationCreateInfo[] i) => new ManagedPtrArray<VmaAllocationCreateInfo>(i);

        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
        public unsafe struct VmaAllocationInfo
        {
            [FieldOffset(0)] public uint memoryType;
            [FieldOffset(8)] public IntPtr deviceMemory;
            [FieldOffset(16)] public ulong offset;
            [FieldOffset(24)] public ulong size;
            [FieldOffset(32)] public void* pMappedData;
            [FieldOffset(40)] public void* pUserData;
        }
        public static ManagedPtr<VmaAllocationInfo> Pointer(this VmaAllocationInfo i) => new ManagedPtr<VmaAllocationInfo>(i);
        public static ManagedPtrArray<VmaAllocationInfo> Pointer(this VmaAllocationInfo[] i) => new ManagedPtrArray<VmaAllocationInfo>(i);

        public static VkResult vmaCreateBuffer(IntPtr allocator, IntPtr pBufferCreateInfo, IntPtr pAllocationCreateInfo, IntPtr* pBuffer, IntPtr* pAllocation, IntPtr pAllocationInfo) { throw new NotImplementedException(); }
        public static void vmaDestroyBuffer(IntPtr allocator, IntPtr buffer, IntPtr allocation) { throw new NotImplementedException(); }
        public static VkResult vmaCreateImage(IntPtr allocator, IntPtr pImageCreateInfo, IntPtr pAllocationCreateInfo, IntPtr* pImage, IntPtr* pAllocation, IntPtr pAllocationInfo) { throw new NotImplementedException(); }
        public static void vmaDestroyImage(IntPtr allocator, IntPtr image, IntPtr allocation) { throw new NotImplementedException(); }

        internal static IntPtr vmaCreateAllocator_hndl;
        internal static IntPtr vmaDestroyAllocator_hndl;
        internal static IntPtr vmaCreateBuffer_hndl;
        internal static IntPtr vmaDestroyBuffer_hndl;
        internal static IntPtr vmaCreateImage_hndl;
        internal static IntPtr vmaDestroyImage_hndl;

        private static void InitPtrs()
        {
            NativeLibrary.TryGetExport(libHndl, "vmaCreateAllocator", out vmaCreateAllocator_hndl);
            NativeLibrary.TryGetExport(libHndl, "vmaDestroyAllocator", out vmaDestroyAllocator_hndl);
            NativeLibrary.TryGetExport(libHndl, "vmaCreateBuffer", out vmaCreateBuffer_hndl);
            NativeLibrary.TryGetExport(libHndl, "vmaDestroyBuffer", out vmaDestroyBuffer_hndl);
            NativeLibrary.TryGetExport(libHndl, "vmaCreateImage", out vmaCreateImage_hndl);
            NativeLibrary.TryGetExport(libHndl, "vmaDestroyImage", out vmaDestroyImage_hndl);
        }
    }
}
