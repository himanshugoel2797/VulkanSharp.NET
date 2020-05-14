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
            Unknown = 0,
            GpuOnly = 1,
            CpuOnly = 2,
            CpuToGpu = 3,
            GpuToCpu = 4,
            CpuCopy = 5,
            GpuLazilyAllocated = 6,
            MaxEnum = 0x7FFFFFFF
        }

        public enum VmaAllocationCreateFlags
        {
            DedicatedMemoryBit = 0x00000001,
            NeverAllocateBit = 0x00000002,
            MappedBit = 0x00000004,
            CanBecomeLostBit = 0x00000008,
            CanMakeOtherLostBit = 0x00000010,
            UserDataCopyStringBit = 0x00000020,
            UpperAddressBit = 0x00000040,
            DontBindBit = 0x00000080,
            WithinBudgetBit = 0x00000100,
            StrategyBestFitBit = 0x00010000,
            StrategyWorstFitBit = 0x00020000,
            StrategyFirstFitBit = 0x00040000,
            StrategyMinMemoryBit = StrategyBestFitBit,
            StrategyMinTimeBit = StrategyFirstFitBit,
            StrategyMinFragmentationBit = StrategyWorstFitBit,

            StrategyMask =
            StrategyBestFitBit |
            StrategyWorstFitBit |
            StrategyFirstFitBit,
            MaxEnum = 0x7FFFFFFF
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

        public static VkResult vmaCreateBuffer(IntPtr allocator, ManagedPtrArray<VkBufferCreateInfo> pBufferCreateInfo, ManagedPtrArray<VmaAllocationCreateInfo> pAllocationCreateInfo, IntPtr* pBuffer, IntPtr* pAllocation, ManagedPtrArray<VmaAllocationInfo> pAllocationInfo) { throw new NotImplementedException(); }
        public static void vmaDestroyBuffer(IntPtr allocator, IntPtr buffer, IntPtr allocation) { throw new NotImplementedException(); }
        public static VkResult vmaCreateImage(IntPtr allocator, ManagedPtrArray<VkImageCreateInfo> pImageCreateInfo, ManagedPtrArray<VmaAllocationCreateInfo> pAllocationCreateInfo, IntPtr* pImage, IntPtr* pAllocation, ManagedPtrArray<VmaAllocationInfo> pAllocationInfo) { throw new NotImplementedException(); }
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
