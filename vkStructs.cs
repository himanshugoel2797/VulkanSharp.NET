using System;
using System.Runtime.InteropServices;
namespace VulkanSharp.Raw {
	public unsafe static partial class Vk {
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkWin32SurfaceCreateInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(24)]public IntPtr hinstance;
			[FieldOffset(32)]public IntPtr hwnd;
		}

        public static ManagedPtr<VkWin32SurfaceCreateInfoKHR> Pointer(this VkWin32SurfaceCreateInfoKHR i) => new ManagedPtr<VkWin32SurfaceCreateInfoKHR>(i);
        public static ManagedPtr<VkWin32SurfaceCreateInfoKHR[]> Pointer(this VkWin32SurfaceCreateInfoKHR[] i) => new ManagedPtr<VkWin32SurfaceCreateInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkImportMemoryWin32HandleInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalMemoryHandleTypeFlagBits handleType;
			[FieldOffset(24)]public IntPtr handle;
			[FieldOffset(32)]public string name;
		}

        public static ManagedPtr<VkImportMemoryWin32HandleInfoKHR> Pointer(this VkImportMemoryWin32HandleInfoKHR i) => new ManagedPtr<VkImportMemoryWin32HandleInfoKHR>(i);
        public static ManagedPtr<VkImportMemoryWin32HandleInfoKHR[]> Pointer(this VkImportMemoryWin32HandleInfoKHR[] i) => new ManagedPtr<VkImportMemoryWin32HandleInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkExportMemoryWin32HandleInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr* pAttributes;
			[FieldOffset(24)]public uint dwAccess;
			[FieldOffset(32)]public string name;
		}

        public static ManagedPtr<VkExportMemoryWin32HandleInfoKHR> Pointer(this VkExportMemoryWin32HandleInfoKHR i) => new ManagedPtr<VkExportMemoryWin32HandleInfoKHR>(i);
        public static ManagedPtr<VkExportMemoryWin32HandleInfoKHR[]> Pointer(this VkExportMemoryWin32HandleInfoKHR[] i) => new ManagedPtr<VkExportMemoryWin32HandleInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkMemoryWin32HandlePropertiesKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint memoryTypeBits;
		}

        public static ManagedPtr<VkMemoryWin32HandlePropertiesKHR> Pointer(this VkMemoryWin32HandlePropertiesKHR i) => new ManagedPtr<VkMemoryWin32HandlePropertiesKHR>(i);
        public static ManagedPtr<VkMemoryWin32HandlePropertiesKHR[]> Pointer(this VkMemoryWin32HandlePropertiesKHR[] i) => new ManagedPtr<VkMemoryWin32HandlePropertiesKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkMemoryGetWin32HandleInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr memory;
			[FieldOffset(24)]public VkExternalMemoryHandleTypeFlagBits handleType;
		}

        public static ManagedPtr<VkMemoryGetWin32HandleInfoKHR> Pointer(this VkMemoryGetWin32HandleInfoKHR i) => new ManagedPtr<VkMemoryGetWin32HandleInfoKHR>(i);
        public static ManagedPtr<VkMemoryGetWin32HandleInfoKHR[]> Pointer(this VkMemoryGetWin32HandleInfoKHR[] i) => new ManagedPtr<VkMemoryGetWin32HandleInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint acquireCount;
			[FieldOffset(24)]public IntPtr* pAcquireSyncs;
			[FieldOffset(32)]public ulong* pAcquireKeys;
			[FieldOffset(40)]public uint* pAcquireTimeouts;
			[FieldOffset(48)]public uint releaseCount;
			[FieldOffset(56)]public IntPtr* pReleaseSyncs;
			[FieldOffset(64)]public ulong* pReleaseKeys;
		}

        public static ManagedPtr<VkWin32KeyedMutexAcquireReleaseInfoKHR> Pointer(this VkWin32KeyedMutexAcquireReleaseInfoKHR i) => new ManagedPtr<VkWin32KeyedMutexAcquireReleaseInfoKHR>(i);
        public static ManagedPtr<VkWin32KeyedMutexAcquireReleaseInfoKHR[]> Pointer(this VkWin32KeyedMutexAcquireReleaseInfoKHR[] i) => new ManagedPtr<VkWin32KeyedMutexAcquireReleaseInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkImportSemaphoreWin32HandleInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr semaphore;
			[FieldOffset(24)]public uint flags;
			[FieldOffset(28)]public VkExternalSemaphoreHandleTypeFlagBits handleType;
			[FieldOffset(32)]public IntPtr handle;
			[FieldOffset(40)]public string name;
		}

        public static ManagedPtr<VkImportSemaphoreWin32HandleInfoKHR> Pointer(this VkImportSemaphoreWin32HandleInfoKHR i) => new ManagedPtr<VkImportSemaphoreWin32HandleInfoKHR>(i);
        public static ManagedPtr<VkImportSemaphoreWin32HandleInfoKHR[]> Pointer(this VkImportSemaphoreWin32HandleInfoKHR[] i) => new ManagedPtr<VkImportSemaphoreWin32HandleInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkExportSemaphoreWin32HandleInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr* pAttributes;
			[FieldOffset(24)]public uint dwAccess;
			[FieldOffset(32)]public string name;
		}

        public static ManagedPtr<VkExportSemaphoreWin32HandleInfoKHR> Pointer(this VkExportSemaphoreWin32HandleInfoKHR i) => new ManagedPtr<VkExportSemaphoreWin32HandleInfoKHR>(i);
        public static ManagedPtr<VkExportSemaphoreWin32HandleInfoKHR[]> Pointer(this VkExportSemaphoreWin32HandleInfoKHR[] i) => new ManagedPtr<VkExportSemaphoreWin32HandleInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkD3D12FenceSubmitInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint waitSemaphoreValuesCount;
			[FieldOffset(24)]public ulong* pWaitSemaphoreValues;
			[FieldOffset(32)]public uint signalSemaphoreValuesCount;
			[FieldOffset(40)]public ulong* pSignalSemaphoreValues;
		}

        public static ManagedPtr<VkD3D12FenceSubmitInfoKHR> Pointer(this VkD3D12FenceSubmitInfoKHR i) => new ManagedPtr<VkD3D12FenceSubmitInfoKHR>(i);
        public static ManagedPtr<VkD3D12FenceSubmitInfoKHR[]> Pointer(this VkD3D12FenceSubmitInfoKHR[] i) => new ManagedPtr<VkD3D12FenceSubmitInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkSemaphoreGetWin32HandleInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr semaphore;
			[FieldOffset(24)]public VkExternalSemaphoreHandleTypeFlagBits handleType;
		}

        public static ManagedPtr<VkSemaphoreGetWin32HandleInfoKHR> Pointer(this VkSemaphoreGetWin32HandleInfoKHR i) => new ManagedPtr<VkSemaphoreGetWin32HandleInfoKHR>(i);
        public static ManagedPtr<VkSemaphoreGetWin32HandleInfoKHR[]> Pointer(this VkSemaphoreGetWin32HandleInfoKHR[] i) => new ManagedPtr<VkSemaphoreGetWin32HandleInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkImportFenceWin32HandleInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr fence;
			[FieldOffset(24)]public uint flags;
			[FieldOffset(28)]public VkExternalFenceHandleTypeFlagBits handleType;
			[FieldOffset(32)]public IntPtr handle;
			[FieldOffset(40)]public string name;
		}

        public static ManagedPtr<VkImportFenceWin32HandleInfoKHR> Pointer(this VkImportFenceWin32HandleInfoKHR i) => new ManagedPtr<VkImportFenceWin32HandleInfoKHR>(i);
        public static ManagedPtr<VkImportFenceWin32HandleInfoKHR[]> Pointer(this VkImportFenceWin32HandleInfoKHR[] i) => new ManagedPtr<VkImportFenceWin32HandleInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkExportFenceWin32HandleInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr* pAttributes;
			[FieldOffset(24)]public uint dwAccess;
			[FieldOffset(32)]public string name;
		}

        public static ManagedPtr<VkExportFenceWin32HandleInfoKHR> Pointer(this VkExportFenceWin32HandleInfoKHR i) => new ManagedPtr<VkExportFenceWin32HandleInfoKHR>(i);
        public static ManagedPtr<VkExportFenceWin32HandleInfoKHR[]> Pointer(this VkExportFenceWin32HandleInfoKHR[] i) => new ManagedPtr<VkExportFenceWin32HandleInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkFenceGetWin32HandleInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr fence;
			[FieldOffset(24)]public VkExternalFenceHandleTypeFlagBits handleType;
		}

        public static ManagedPtr<VkFenceGetWin32HandleInfoKHR> Pointer(this VkFenceGetWin32HandleInfoKHR i) => new ManagedPtr<VkFenceGetWin32HandleInfoKHR>(i);
        public static ManagedPtr<VkFenceGetWin32HandleInfoKHR[]> Pointer(this VkFenceGetWin32HandleInfoKHR[] i) => new ManagedPtr<VkFenceGetWin32HandleInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkImportMemoryWin32HandleInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint handleType;
			[FieldOffset(24)]public IntPtr handle;
		}

        public static ManagedPtr<VkImportMemoryWin32HandleInfoNV> Pointer(this VkImportMemoryWin32HandleInfoNV i) => new ManagedPtr<VkImportMemoryWin32HandleInfoNV>(i);
        public static ManagedPtr<VkImportMemoryWin32HandleInfoNV[]> Pointer(this VkImportMemoryWin32HandleInfoNV[] i) => new ManagedPtr<VkImportMemoryWin32HandleInfoNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkExportMemoryWin32HandleInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr* pAttributes;
			[FieldOffset(24)]public uint dwAccess;
		}

        public static ManagedPtr<VkExportMemoryWin32HandleInfoNV> Pointer(this VkExportMemoryWin32HandleInfoNV i) => new ManagedPtr<VkExportMemoryWin32HandleInfoNV>(i);
        public static ManagedPtr<VkExportMemoryWin32HandleInfoNV[]> Pointer(this VkExportMemoryWin32HandleInfoNV[] i) => new ManagedPtr<VkExportMemoryWin32HandleInfoNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint acquireCount;
			[FieldOffset(24)]public IntPtr* pAcquireSyncs;
			[FieldOffset(32)]public ulong* pAcquireKeys;
			[FieldOffset(40)]public uint* pAcquireTimeoutMilliseconds;
			[FieldOffset(48)]public uint releaseCount;
			[FieldOffset(56)]public IntPtr* pReleaseSyncs;
			[FieldOffset(64)]public ulong* pReleaseKeys;
		}

        public static ManagedPtr<VkWin32KeyedMutexAcquireReleaseInfoNV> Pointer(this VkWin32KeyedMutexAcquireReleaseInfoNV i) => new ManagedPtr<VkWin32KeyedMutexAcquireReleaseInfoNV>(i);
        public static ManagedPtr<VkWin32KeyedMutexAcquireReleaseInfoNV[]> Pointer(this VkWin32KeyedMutexAcquireReleaseInfoNV[] i) => new ManagedPtr<VkWin32KeyedMutexAcquireReleaseInfoNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSurfaceFullScreenExclusiveInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkFullScreenExclusiveEXT fullScreenExclusive;
		}

        public static ManagedPtr<VkSurfaceFullScreenExclusiveInfoEXT> Pointer(this VkSurfaceFullScreenExclusiveInfoEXT i) => new ManagedPtr<VkSurfaceFullScreenExclusiveInfoEXT>(i);
        public static ManagedPtr<VkSurfaceFullScreenExclusiveInfoEXT[]> Pointer(this VkSurfaceFullScreenExclusiveInfoEXT[] i) => new ManagedPtr<VkSurfaceFullScreenExclusiveInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSurfaceCapabilitiesFullScreenExclusiveEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint fullScreenExclusiveSupported;
		}

        public static ManagedPtr<VkSurfaceCapabilitiesFullScreenExclusiveEXT> Pointer(this VkSurfaceCapabilitiesFullScreenExclusiveEXT i) => new ManagedPtr<VkSurfaceCapabilitiesFullScreenExclusiveEXT>(i);
        public static ManagedPtr<VkSurfaceCapabilitiesFullScreenExclusiveEXT[]> Pointer(this VkSurfaceCapabilitiesFullScreenExclusiveEXT[] i) => new ManagedPtr<VkSurfaceCapabilitiesFullScreenExclusiveEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkSurfaceFullScreenExclusiveWin32InfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr hmonitor;
		}

        public static ManagedPtr<VkSurfaceFullScreenExclusiveWin32InfoEXT> Pointer(this VkSurfaceFullScreenExclusiveWin32InfoEXT i) => new ManagedPtr<VkSurfaceFullScreenExclusiveWin32InfoEXT>(i);
        public static ManagedPtr<VkSurfaceFullScreenExclusiveWin32InfoEXT[]> Pointer(this VkSurfaceFullScreenExclusiveWin32InfoEXT[] i) => new ManagedPtr<VkSurfaceFullScreenExclusiveWin32InfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkWaylandSurfaceCreateInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(24)]public IntPtr display;
			[FieldOffset(32)]public IntPtr surface;
		}

        public static ManagedPtr<VkWaylandSurfaceCreateInfoKHR> Pointer(this VkWaylandSurfaceCreateInfoKHR i) => new ManagedPtr<VkWaylandSurfaceCreateInfoKHR>(i);
        public static ManagedPtr<VkWaylandSurfaceCreateInfoKHR[]> Pointer(this VkWaylandSurfaceCreateInfoKHR[] i) => new ManagedPtr<VkWaylandSurfaceCreateInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkXlibSurfaceCreateInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(24)]public IntPtr dpy;
			[FieldOffset(32)]public IntPtr window;
		}

        public static ManagedPtr<VkXlibSurfaceCreateInfoKHR> Pointer(this VkXlibSurfaceCreateInfoKHR i) => new ManagedPtr<VkXlibSurfaceCreateInfoKHR>(i);
        public static ManagedPtr<VkXlibSurfaceCreateInfoKHR[]> Pointer(this VkXlibSurfaceCreateInfoKHR[] i) => new ManagedPtr<VkXlibSurfaceCreateInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkApplicationInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public string pApplicationName;
			[FieldOffset(24)]public uint applicationVersion;
			[FieldOffset(32)]public string pEngineName;
			[FieldOffset(40)]public uint engineVersion;
			[FieldOffset(44)]public uint apiVersion;
		}

        public static ManagedPtr<VkApplicationInfo> Pointer(this VkApplicationInfo i) => new ManagedPtr<VkApplicationInfo>(i);
        public static ManagedPtr<VkApplicationInfo[]> Pointer(this VkApplicationInfo[] i) => new ManagedPtr<VkApplicationInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkInstanceCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(24)]public IntPtr pApplicationInfo;
			[FieldOffset(32)]public uint enabledLayerCount;
			[FieldOffset(40)]public IntPtr* ppEnabledLayerNames;
			[FieldOffset(48)]public uint enabledExtensionCount;
			[FieldOffset(56)]public IntPtr* ppEnabledExtensionNames;
		}

        public static ManagedPtr<VkInstanceCreateInfo> Pointer(this VkInstanceCreateInfo i) => new ManagedPtr<VkInstanceCreateInfo>(i);
        public static ManagedPtr<VkInstanceCreateInfo[]> Pointer(this VkInstanceCreateInfo[] i) => new ManagedPtr<VkInstanceCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAllocationCallbacks {
			[FieldOffset(0)]public IntPtr pUserData;
			[FieldOffset(8)]public IntPtr pfnAllocation;
			[FieldOffset(16)]public IntPtr pfnReallocation;
			[FieldOffset(24)]public IntPtr pfnFree;
			[FieldOffset(32)]public IntPtr pfnInternalAllocation;
			[FieldOffset(40)]public IntPtr pfnInternalFree;
		}

        public static ManagedPtr<VkAllocationCallbacks> Pointer(this VkAllocationCallbacks i) => new ManagedPtr<VkAllocationCallbacks>(i);
        public static ManagedPtr<VkAllocationCallbacks[]> Pointer(this VkAllocationCallbacks[] i) => new ManagedPtr<VkAllocationCallbacks[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceFeatures {
			[FieldOffset(0)]public uint robustBufferAccess;
			[FieldOffset(4)]public uint fullDrawIndexUint32;
			[FieldOffset(8)]public uint imageCubeArray;
			[FieldOffset(12)]public uint independentBlend;
			[FieldOffset(16)]public uint geometryShader;
			[FieldOffset(20)]public uint tessellationShader;
			[FieldOffset(24)]public uint sampleRateShading;
			[FieldOffset(28)]public uint dualSrcBlend;
			[FieldOffset(32)]public uint logicOp;
			[FieldOffset(36)]public uint multiDrawIndirect;
			[FieldOffset(40)]public uint drawIndirectFirstInstance;
			[FieldOffset(44)]public uint depthClamp;
			[FieldOffset(48)]public uint depthBiasClamp;
			[FieldOffset(52)]public uint fillModeNonSolid;
			[FieldOffset(56)]public uint depthBounds;
			[FieldOffset(60)]public uint wideLines;
			[FieldOffset(64)]public uint largePoints;
			[FieldOffset(68)]public uint alphaToOne;
			[FieldOffset(72)]public uint multiViewport;
			[FieldOffset(76)]public uint samplerAnisotropy;
			[FieldOffset(80)]public uint textureCompressionETC2;
			[FieldOffset(84)]public uint textureCompressionASTC_LDR;
			[FieldOffset(88)]public uint textureCompressionBC;
			[FieldOffset(92)]public uint occlusionQueryPrecise;
			[FieldOffset(96)]public uint pipelineStatisticsQuery;
			[FieldOffset(100)]public uint vertexPipelineStoresAndAtomics;
			[FieldOffset(104)]public uint fragmentStoresAndAtomics;
			[FieldOffset(108)]public uint shaderTessellationAndGeometryPointSize;
			[FieldOffset(112)]public uint shaderImageGatherExtended;
			[FieldOffset(116)]public uint shaderStorageImageExtendedFormats;
			[FieldOffset(120)]public uint shaderStorageImageMultisample;
			[FieldOffset(124)]public uint shaderStorageImageReadWithoutFormat;
			[FieldOffset(128)]public uint shaderStorageImageWriteWithoutFormat;
			[FieldOffset(132)]public uint shaderUniformBufferArrayDynamicIndexing;
			[FieldOffset(136)]public uint shaderSampledImageArrayDynamicIndexing;
			[FieldOffset(140)]public uint shaderStorageBufferArrayDynamicIndexing;
			[FieldOffset(144)]public uint shaderStorageImageArrayDynamicIndexing;
			[FieldOffset(148)]public uint shaderClipDistance;
			[FieldOffset(152)]public uint shaderCullDistance;
			[FieldOffset(156)]public uint shaderFloat64;
			[FieldOffset(160)]public uint shaderInt64;
			[FieldOffset(164)]public uint shaderInt16;
			[FieldOffset(168)]public uint shaderResourceResidency;
			[FieldOffset(172)]public uint shaderResourceMinLod;
			[FieldOffset(176)]public uint sparseBinding;
			[FieldOffset(180)]public uint sparseResidencyBuffer;
			[FieldOffset(184)]public uint sparseResidencyImage2D;
			[FieldOffset(188)]public uint sparseResidencyImage3D;
			[FieldOffset(192)]public uint sparseResidency2Samples;
			[FieldOffset(196)]public uint sparseResidency4Samples;
			[FieldOffset(200)]public uint sparseResidency8Samples;
			[FieldOffset(204)]public uint sparseResidency16Samples;
			[FieldOffset(208)]public uint sparseResidencyAliased;
			[FieldOffset(212)]public uint variableMultisampleRate;
			[FieldOffset(216)]public uint inheritedQueries;
		}

        public static ManagedPtr<VkPhysicalDeviceFeatures> Pointer(this VkPhysicalDeviceFeatures i) => new ManagedPtr<VkPhysicalDeviceFeatures>(i);
        public static ManagedPtr<VkPhysicalDeviceFeatures[]> Pointer(this VkPhysicalDeviceFeatures[] i) => new ManagedPtr<VkPhysicalDeviceFeatures[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkFormatProperties {
			[FieldOffset(0)]public uint linearTilingFeatures;
			[FieldOffset(4)]public uint optimalTilingFeatures;
			[FieldOffset(8)]public uint bufferFeatures;
		}

        public static ManagedPtr<VkFormatProperties> Pointer(this VkFormatProperties i) => new ManagedPtr<VkFormatProperties>(i);
        public static ManagedPtr<VkFormatProperties[]> Pointer(this VkFormatProperties[] i) => new ManagedPtr<VkFormatProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExtent3D {
			[FieldOffset(0)]public uint width;
			[FieldOffset(4)]public uint height;
			[FieldOffset(8)]public uint depth;
		}

        public static ManagedPtr<VkExtent3D> Pointer(this VkExtent3D i) => new ManagedPtr<VkExtent3D>(i);
        public static ManagedPtr<VkExtent3D[]> Pointer(this VkExtent3D[] i) => new ManagedPtr<VkExtent3D[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageFormatProperties {
			[FieldOffset(0)]public VkExtent3D maxExtent;
			[FieldOffset(12)]public uint maxMipLevels;
			[FieldOffset(16)]public uint maxArrayLayers;
			[FieldOffset(20)]public uint sampleCounts;
			[FieldOffset(24)]public ulong maxResourceSize;
		}

        public static ManagedPtr<VkImageFormatProperties> Pointer(this VkImageFormatProperties i) => new ManagedPtr<VkImageFormatProperties>(i);
        public static ManagedPtr<VkImageFormatProperties[]> Pointer(this VkImageFormatProperties[] i) => new ManagedPtr<VkImageFormatProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceLimits {
			[FieldOffset(0)]public uint maxImageDimension1D;
			[FieldOffset(4)]public uint maxImageDimension2D;
			[FieldOffset(8)]public uint maxImageDimension3D;
			[FieldOffset(12)]public uint maxImageDimensionCube;
			[FieldOffset(16)]public uint maxImageArrayLayers;
			[FieldOffset(20)]public uint maxTexelBufferElements;
			[FieldOffset(24)]public uint maxUniformBufferRange;
			[FieldOffset(28)]public uint maxStorageBufferRange;
			[FieldOffset(32)]public uint maxPushConstantsSize;
			[FieldOffset(36)]public uint maxMemoryAllocationCount;
			[FieldOffset(40)]public uint maxSamplerAllocationCount;
			[FieldOffset(48)]public ulong bufferImageGranularity;
			[FieldOffset(56)]public ulong sparseAddressSpaceSize;
			[FieldOffset(64)]public uint maxBoundDescriptorSets;
			[FieldOffset(68)]public uint maxPerStageDescriptorSamplers;
			[FieldOffset(72)]public uint maxPerStageDescriptorUniformBuffers;
			[FieldOffset(76)]public uint maxPerStageDescriptorStorageBuffers;
			[FieldOffset(80)]public uint maxPerStageDescriptorSampledImages;
			[FieldOffset(84)]public uint maxPerStageDescriptorStorageImages;
			[FieldOffset(88)]public uint maxPerStageDescriptorInputAttachments;
			[FieldOffset(92)]public uint maxPerStageResources;
			[FieldOffset(96)]public uint maxDescriptorSetSamplers;
			[FieldOffset(100)]public uint maxDescriptorSetUniformBuffers;
			[FieldOffset(104)]public uint maxDescriptorSetUniformBuffersDynamic;
			[FieldOffset(108)]public uint maxDescriptorSetStorageBuffers;
			[FieldOffset(112)]public uint maxDescriptorSetStorageBuffersDynamic;
			[FieldOffset(116)]public uint maxDescriptorSetSampledImages;
			[FieldOffset(120)]public uint maxDescriptorSetStorageImages;
			[FieldOffset(124)]public uint maxDescriptorSetInputAttachments;
			[FieldOffset(128)]public uint maxVertexInputAttributes;
			[FieldOffset(132)]public uint maxVertexInputBindings;
			[FieldOffset(136)]public uint maxVertexInputAttributeOffset;
			[FieldOffset(140)]public uint maxVertexInputBindingStride;
			[FieldOffset(144)]public uint maxVertexOutputComponents;
			[FieldOffset(148)]public uint maxTessellationGenerationLevel;
			[FieldOffset(152)]public uint maxTessellationPatchSize;
			[FieldOffset(156)]public uint maxTessellationControlPerVertexInputComponents;
			[FieldOffset(160)]public uint maxTessellationControlPerVertexOutputComponents;
			[FieldOffset(164)]public uint maxTessellationControlPerPatchOutputComponents;
			[FieldOffset(168)]public uint maxTessellationControlTotalOutputComponents;
			[FieldOffset(172)]public uint maxTessellationEvaluationInputComponents;
			[FieldOffset(176)]public uint maxTessellationEvaluationOutputComponents;
			[FieldOffset(180)]public uint maxGeometryShaderInvocations;
			[FieldOffset(184)]public uint maxGeometryInputComponents;
			[FieldOffset(188)]public uint maxGeometryOutputComponents;
			[FieldOffset(192)]public uint maxGeometryOutputVertices;
			[FieldOffset(196)]public uint maxGeometryTotalOutputComponents;
			[FieldOffset(200)]public uint maxFragmentInputComponents;
			[FieldOffset(204)]public uint maxFragmentOutputAttachments;
			[FieldOffset(208)]public uint maxFragmentDualSrcAttachments;
			[FieldOffset(212)]public uint maxFragmentCombinedOutputResources;
			[FieldOffset(216)]public uint maxComputeSharedMemorySize;
			[FieldOffset(220)][MarshalAs(UnmanagedType.ByValArray, SizeConst=3)] public uint[] maxComputeWorkGroupCount;
			[FieldOffset(232)]public uint maxComputeWorkGroupInvocations;
			[FieldOffset(236)][MarshalAs(UnmanagedType.ByValArray, SizeConst=3)] public uint[] maxComputeWorkGroupSize;
			[FieldOffset(248)]public uint subPixelPrecisionBits;
			[FieldOffset(252)]public uint subTexelPrecisionBits;
			[FieldOffset(256)]public uint mipmapPrecisionBits;
			[FieldOffset(260)]public uint maxDrawIndexedIndexValue;
			[FieldOffset(264)]public uint maxDrawIndirectCount;
			[FieldOffset(268)]public float maxSamplerLodBias;
			[FieldOffset(272)]public float maxSamplerAnisotropy;
			[FieldOffset(276)]public uint maxViewports;
			[FieldOffset(280)][MarshalAs(UnmanagedType.ByValArray, SizeConst=2)] public uint[] maxViewportDimensions;
			[FieldOffset(288)][MarshalAs(UnmanagedType.ByValArray, SizeConst=2)] public float[] viewportBoundsRange;
			[FieldOffset(296)]public uint viewportSubPixelBits;
			[FieldOffset(304)]public ulong minMemoryMapAlignment;
			[FieldOffset(312)]public ulong minTexelBufferOffsetAlignment;
			[FieldOffset(320)]public ulong minUniformBufferOffsetAlignment;
			[FieldOffset(328)]public ulong minStorageBufferOffsetAlignment;
			[FieldOffset(336)]public int minTexelOffset;
			[FieldOffset(340)]public uint maxTexelOffset;
			[FieldOffset(344)]public int minTexelGatherOffset;
			[FieldOffset(348)]public uint maxTexelGatherOffset;
			[FieldOffset(352)]public float minInterpolationOffset;
			[FieldOffset(356)]public float maxInterpolationOffset;
			[FieldOffset(360)]public uint subPixelInterpolationOffsetBits;
			[FieldOffset(364)]public uint maxFramebufferWidth;
			[FieldOffset(368)]public uint maxFramebufferHeight;
			[FieldOffset(372)]public uint maxFramebufferLayers;
			[FieldOffset(376)]public uint framebufferColorSampleCounts;
			[FieldOffset(380)]public uint framebufferDepthSampleCounts;
			[FieldOffset(384)]public uint framebufferStencilSampleCounts;
			[FieldOffset(388)]public uint framebufferNoAttachmentsSampleCounts;
			[FieldOffset(392)]public uint maxColorAttachments;
			[FieldOffset(396)]public uint sampledImageColorSampleCounts;
			[FieldOffset(400)]public uint sampledImageIntegerSampleCounts;
			[FieldOffset(404)]public uint sampledImageDepthSampleCounts;
			[FieldOffset(408)]public uint sampledImageStencilSampleCounts;
			[FieldOffset(412)]public uint storageImageSampleCounts;
			[FieldOffset(416)]public uint maxSampleMaskWords;
			[FieldOffset(420)]public uint timestampComputeAndGraphics;
			[FieldOffset(424)]public float timestampPeriod;
			[FieldOffset(428)]public uint maxClipDistances;
			[FieldOffset(432)]public uint maxCullDistances;
			[FieldOffset(436)]public uint maxCombinedClipAndCullDistances;
			[FieldOffset(440)]public uint discreteQueuePriorities;
			[FieldOffset(444)][MarshalAs(UnmanagedType.ByValArray, SizeConst=2)] public float[] pointSizeRange;
			[FieldOffset(452)][MarshalAs(UnmanagedType.ByValArray, SizeConst=2)] public float[] lineWidthRange;
			[FieldOffset(460)]public float pointSizeGranularity;
			[FieldOffset(464)]public float lineWidthGranularity;
			[FieldOffset(468)]public uint strictLines;
			[FieldOffset(472)]public uint standardSampleLocations;
			[FieldOffset(480)]public ulong optimalBufferCopyOffsetAlignment;
			[FieldOffset(488)]public ulong optimalBufferCopyRowPitchAlignment;
			[FieldOffset(496)]public ulong nonCoherentAtomSize;
		}

        public static ManagedPtr<VkPhysicalDeviceLimits> Pointer(this VkPhysicalDeviceLimits i) => new ManagedPtr<VkPhysicalDeviceLimits>(i);
        public static ManagedPtr<VkPhysicalDeviceLimits[]> Pointer(this VkPhysicalDeviceLimits[] i) => new ManagedPtr<VkPhysicalDeviceLimits[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceSparseProperties {
			[FieldOffset(0)]public uint residencyStandard2DBlockShape;
			[FieldOffset(4)]public uint residencyStandard2DMultisampleBlockShape;
			[FieldOffset(8)]public uint residencyStandard3DBlockShape;
			[FieldOffset(12)]public uint residencyAlignedMipSize;
			[FieldOffset(16)]public uint residencyNonResidentStrict;
		}

        public static ManagedPtr<VkPhysicalDeviceSparseProperties> Pointer(this VkPhysicalDeviceSparseProperties i) => new ManagedPtr<VkPhysicalDeviceSparseProperties>(i);
        public static ManagedPtr<VkPhysicalDeviceSparseProperties[]> Pointer(this VkPhysicalDeviceSparseProperties[] i) => new ManagedPtr<VkPhysicalDeviceSparseProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceProperties {
			[FieldOffset(0)]public uint apiVersion;
			[FieldOffset(4)]public uint driverVersion;
			[FieldOffset(8)]public uint vendorID;
			[FieldOffset(12)]public uint deviceID;
			[FieldOffset(16)]public VkPhysicalDeviceType deviceType;
			[FieldOffset(20)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] deviceName;
			[FieldOffset(276)]public fixed byte pipelineCacheUUID[16];
			[FieldOffset(504)]public VkPhysicalDeviceLimits limits;
			[FieldOffset(1020)]public VkPhysicalDeviceSparseProperties sparseProperties;
		}

        public static ManagedPtr<VkPhysicalDeviceProperties> Pointer(this VkPhysicalDeviceProperties i) => new ManagedPtr<VkPhysicalDeviceProperties>(i);
        public static ManagedPtr<VkPhysicalDeviceProperties[]> Pointer(this VkPhysicalDeviceProperties[] i) => new ManagedPtr<VkPhysicalDeviceProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkQueueFamilyProperties {
			[FieldOffset(0)]public uint queueFlags;
			[FieldOffset(4)]public uint queueCount;
			[FieldOffset(8)]public uint timestampValidBits;
			[FieldOffset(12)]public VkExtent3D minImageTransferGranularity;
		}

        public static ManagedPtr<VkQueueFamilyProperties> Pointer(this VkQueueFamilyProperties i) => new ManagedPtr<VkQueueFamilyProperties>(i);
        public static ManagedPtr<VkQueueFamilyProperties[]> Pointer(this VkQueueFamilyProperties[] i) => new ManagedPtr<VkQueueFamilyProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryType {
			[FieldOffset(0)]public uint propertyFlags;
			[FieldOffset(4)]public uint heapIndex;
		}

        public static ManagedPtr<VkMemoryType> Pointer(this VkMemoryType i) => new ManagedPtr<VkMemoryType>(i);
        public static ManagedPtr<VkMemoryType[]> Pointer(this VkMemoryType[] i) => new ManagedPtr<VkMemoryType[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryHeap {
			[FieldOffset(0)]public ulong size;
			[FieldOffset(8)]public uint flags;
		}

        public static ManagedPtr<VkMemoryHeap> Pointer(this VkMemoryHeap i) => new ManagedPtr<VkMemoryHeap>(i);
        public static ManagedPtr<VkMemoryHeap[]> Pointer(this VkMemoryHeap[] i) => new ManagedPtr<VkMemoryHeap[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceMemoryProperties {
			[FieldOffset(0)]public uint memoryTypeCount;
			[FieldOffset(8)][MarshalAs(UnmanagedType.ByValArray, SizeConst=32)] public VkMemoryType[] memoryTypes;
			[FieldOffset(264)]public uint memoryHeapCount;
			[FieldOffset(276)][MarshalAs(UnmanagedType.ByValArray, SizeConst=16)] public VkMemoryHeap[] memoryHeaps;
		}

        public static ManagedPtr<VkPhysicalDeviceMemoryProperties> Pointer(this VkPhysicalDeviceMemoryProperties i) => new ManagedPtr<VkPhysicalDeviceMemoryProperties>(i);
        public static ManagedPtr<VkPhysicalDeviceMemoryProperties[]> Pointer(this VkPhysicalDeviceMemoryProperties[] i) => new ManagedPtr<VkPhysicalDeviceMemoryProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceQueueCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint queueFamilyIndex;
			[FieldOffset(24)]public uint queueCount;
			[FieldOffset(32)]public float* pQueuePriorities;
		}

        public static ManagedPtr<VkDeviceQueueCreateInfo> Pointer(this VkDeviceQueueCreateInfo i) => new ManagedPtr<VkDeviceQueueCreateInfo>(i);
        public static ManagedPtr<VkDeviceQueueCreateInfo[]> Pointer(this VkDeviceQueueCreateInfo[] i) => new ManagedPtr<VkDeviceQueueCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint queueCreateInfoCount;
			[FieldOffset(24)]public IntPtr pQueueCreateInfos;
			[FieldOffset(32)]public uint enabledLayerCount;
			[FieldOffset(40)]public IntPtr* ppEnabledLayerNames;
			[FieldOffset(48)]public uint enabledExtensionCount;
			[FieldOffset(56)]public IntPtr* ppEnabledExtensionNames;
			[FieldOffset(64)]public IntPtr pEnabledFeatures;
		}

        public static ManagedPtr<VkDeviceCreateInfo> Pointer(this VkDeviceCreateInfo i) => new ManagedPtr<VkDeviceCreateInfo>(i);
        public static ManagedPtr<VkDeviceCreateInfo[]> Pointer(this VkDeviceCreateInfo[] i) => new ManagedPtr<VkDeviceCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExtensionProperties {
			[FieldOffset(0)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] extensionName;
			[FieldOffset(256)]public uint specVersion;
		}

        public static ManagedPtr<VkExtensionProperties> Pointer(this VkExtensionProperties i) => new ManagedPtr<VkExtensionProperties>(i);
        public static ManagedPtr<VkExtensionProperties[]> Pointer(this VkExtensionProperties[] i) => new ManagedPtr<VkExtensionProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkLayerProperties {
			[FieldOffset(0)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] layerName;
			[FieldOffset(256)]public uint specVersion;
			[FieldOffset(260)]public uint implementationVersion;
			[FieldOffset(264)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] description;
		}

        public static ManagedPtr<VkLayerProperties> Pointer(this VkLayerProperties i) => new ManagedPtr<VkLayerProperties>(i);
        public static ManagedPtr<VkLayerProperties[]> Pointer(this VkLayerProperties[] i) => new ManagedPtr<VkLayerProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSubmitInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint waitSemaphoreCount;
			[FieldOffset(24)]public IntPtr* pWaitSemaphores;
			[FieldOffset(32)]public uint* pWaitDstStageMask;
			[FieldOffset(40)]public uint commandBufferCount;
			[FieldOffset(48)]public IntPtr* pCommandBuffers;
			[FieldOffset(56)]public uint signalSemaphoreCount;
			[FieldOffset(64)]public IntPtr* pSignalSemaphores;
		}

        public static ManagedPtr<VkSubmitInfo> Pointer(this VkSubmitInfo i) => new ManagedPtr<VkSubmitInfo>(i);
        public static ManagedPtr<VkSubmitInfo[]> Pointer(this VkSubmitInfo[] i) => new ManagedPtr<VkSubmitInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryAllocateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong allocationSize;
			[FieldOffset(24)]public uint memoryTypeIndex;
		}

        public static ManagedPtr<VkMemoryAllocateInfo> Pointer(this VkMemoryAllocateInfo i) => new ManagedPtr<VkMemoryAllocateInfo>(i);
        public static ManagedPtr<VkMemoryAllocateInfo[]> Pointer(this VkMemoryAllocateInfo[] i) => new ManagedPtr<VkMemoryAllocateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMappedMemoryRange {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr memory;
			[FieldOffset(24)]public ulong offset;
			[FieldOffset(32)]public ulong size;
		}

        public static ManagedPtr<VkMappedMemoryRange> Pointer(this VkMappedMemoryRange i) => new ManagedPtr<VkMappedMemoryRange>(i);
        public static ManagedPtr<VkMappedMemoryRange[]> Pointer(this VkMappedMemoryRange[] i) => new ManagedPtr<VkMappedMemoryRange[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryRequirements {
			[FieldOffset(0)]public ulong size;
			[FieldOffset(8)]public ulong alignment;
			[FieldOffset(16)]public uint memoryTypeBits;
		}

        public static ManagedPtr<VkMemoryRequirements> Pointer(this VkMemoryRequirements i) => new ManagedPtr<VkMemoryRequirements>(i);
        public static ManagedPtr<VkMemoryRequirements[]> Pointer(this VkMemoryRequirements[] i) => new ManagedPtr<VkMemoryRequirements[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSparseImageFormatProperties {
			[FieldOffset(0)]public uint aspectMask;
			[FieldOffset(12)]public VkExtent3D imageGranularity;
			[FieldOffset(24)]public uint flags;
		}

        public static ManagedPtr<VkSparseImageFormatProperties> Pointer(this VkSparseImageFormatProperties i) => new ManagedPtr<VkSparseImageFormatProperties>(i);
        public static ManagedPtr<VkSparseImageFormatProperties[]> Pointer(this VkSparseImageFormatProperties[] i) => new ManagedPtr<VkSparseImageFormatProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSparseImageMemoryRequirements {
			[FieldOffset(0)]public VkSparseImageFormatProperties formatProperties;
			[FieldOffset(28)]public uint imageMipTailFirstLod;
			[FieldOffset(32)]public ulong imageMipTailSize;
			[FieldOffset(40)]public ulong imageMipTailOffset;
			[FieldOffset(48)]public ulong imageMipTailStride;
		}

        public static ManagedPtr<VkSparseImageMemoryRequirements> Pointer(this VkSparseImageMemoryRequirements i) => new ManagedPtr<VkSparseImageMemoryRequirements>(i);
        public static ManagedPtr<VkSparseImageMemoryRequirements[]> Pointer(this VkSparseImageMemoryRequirements[] i) => new ManagedPtr<VkSparseImageMemoryRequirements[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSparseMemoryBind {
			[FieldOffset(0)]public ulong resourceOffset;
			[FieldOffset(8)]public ulong size;
			[FieldOffset(16)]public IntPtr memory;
			[FieldOffset(24)]public ulong memoryOffset;
			[FieldOffset(32)]public uint flags;
		}

        public static ManagedPtr<VkSparseMemoryBind> Pointer(this VkSparseMemoryBind i) => new ManagedPtr<VkSparseMemoryBind>(i);
        public static ManagedPtr<VkSparseMemoryBind[]> Pointer(this VkSparseMemoryBind[] i) => new ManagedPtr<VkSparseMemoryBind[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSparseBufferMemoryBindInfo {
			[FieldOffset(0)]public IntPtr buffer;
			[FieldOffset(8)]public uint bindCount;
			[FieldOffset(16)]public IntPtr pBinds;
		}

        public static ManagedPtr<VkSparseBufferMemoryBindInfo> Pointer(this VkSparseBufferMemoryBindInfo i) => new ManagedPtr<VkSparseBufferMemoryBindInfo>(i);
        public static ManagedPtr<VkSparseBufferMemoryBindInfo[]> Pointer(this VkSparseBufferMemoryBindInfo[] i) => new ManagedPtr<VkSparseBufferMemoryBindInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSparseImageOpaqueMemoryBindInfo {
			[FieldOffset(0)]public IntPtr image;
			[FieldOffset(8)]public uint bindCount;
			[FieldOffset(16)]public IntPtr pBinds;
		}

        public static ManagedPtr<VkSparseImageOpaqueMemoryBindInfo> Pointer(this VkSparseImageOpaqueMemoryBindInfo i) => new ManagedPtr<VkSparseImageOpaqueMemoryBindInfo>(i);
        public static ManagedPtr<VkSparseImageOpaqueMemoryBindInfo[]> Pointer(this VkSparseImageOpaqueMemoryBindInfo[] i) => new ManagedPtr<VkSparseImageOpaqueMemoryBindInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageSubresource {
			[FieldOffset(0)]public uint aspectMask;
			[FieldOffset(4)]public uint mipLevel;
			[FieldOffset(8)]public uint arrayLayer;
		}

        public static ManagedPtr<VkImageSubresource> Pointer(this VkImageSubresource i) => new ManagedPtr<VkImageSubresource>(i);
        public static ManagedPtr<VkImageSubresource[]> Pointer(this VkImageSubresource[] i) => new ManagedPtr<VkImageSubresource[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkOffset3D {
			[FieldOffset(0)]public int x;
			[FieldOffset(4)]public int y;
			[FieldOffset(8)]public int z;
		}

        public static ManagedPtr<VkOffset3D> Pointer(this VkOffset3D i) => new ManagedPtr<VkOffset3D>(i);
        public static ManagedPtr<VkOffset3D[]> Pointer(this VkOffset3D[] i) => new ManagedPtr<VkOffset3D[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSparseImageMemoryBind {
			[FieldOffset(0)]public VkImageSubresource subresource;
			[FieldOffset(12)]public VkOffset3D offset;
			[FieldOffset(24)]public VkExtent3D extent;
			[FieldOffset(40)]public IntPtr memory;
			[FieldOffset(48)]public ulong memoryOffset;
			[FieldOffset(56)]public uint flags;
		}

        public static ManagedPtr<VkSparseImageMemoryBind> Pointer(this VkSparseImageMemoryBind i) => new ManagedPtr<VkSparseImageMemoryBind>(i);
        public static ManagedPtr<VkSparseImageMemoryBind[]> Pointer(this VkSparseImageMemoryBind[] i) => new ManagedPtr<VkSparseImageMemoryBind[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSparseImageMemoryBindInfo {
			[FieldOffset(0)]public IntPtr image;
			[FieldOffset(8)]public uint bindCount;
			[FieldOffset(16)]public IntPtr pBinds;
		}

        public static ManagedPtr<VkSparseImageMemoryBindInfo> Pointer(this VkSparseImageMemoryBindInfo i) => new ManagedPtr<VkSparseImageMemoryBindInfo>(i);
        public static ManagedPtr<VkSparseImageMemoryBindInfo[]> Pointer(this VkSparseImageMemoryBindInfo[] i) => new ManagedPtr<VkSparseImageMemoryBindInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBindSparseInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint waitSemaphoreCount;
			[FieldOffset(24)]public IntPtr* pWaitSemaphores;
			[FieldOffset(32)]public uint bufferBindCount;
			[FieldOffset(40)]public IntPtr pBufferBinds;
			[FieldOffset(48)]public uint imageOpaqueBindCount;
			[FieldOffset(56)]public IntPtr pImageOpaqueBinds;
			[FieldOffset(64)]public uint imageBindCount;
			[FieldOffset(72)]public IntPtr pImageBinds;
			[FieldOffset(80)]public uint signalSemaphoreCount;
			[FieldOffset(88)]public IntPtr* pSignalSemaphores;
		}

        public static ManagedPtr<VkBindSparseInfo> Pointer(this VkBindSparseInfo i) => new ManagedPtr<VkBindSparseInfo>(i);
        public static ManagedPtr<VkBindSparseInfo[]> Pointer(this VkBindSparseInfo[] i) => new ManagedPtr<VkBindSparseInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkFenceCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
		}

        public static ManagedPtr<VkFenceCreateInfo> Pointer(this VkFenceCreateInfo i) => new ManagedPtr<VkFenceCreateInfo>(i);
        public static ManagedPtr<VkFenceCreateInfo[]> Pointer(this VkFenceCreateInfo[] i) => new ManagedPtr<VkFenceCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSemaphoreCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
		}

        public static ManagedPtr<VkSemaphoreCreateInfo> Pointer(this VkSemaphoreCreateInfo i) => new ManagedPtr<VkSemaphoreCreateInfo>(i);
        public static ManagedPtr<VkSemaphoreCreateInfo[]> Pointer(this VkSemaphoreCreateInfo[] i) => new ManagedPtr<VkSemaphoreCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkEventCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
		}

        public static ManagedPtr<VkEventCreateInfo> Pointer(this VkEventCreateInfo i) => new ManagedPtr<VkEventCreateInfo>(i);
        public static ManagedPtr<VkEventCreateInfo[]> Pointer(this VkEventCreateInfo[] i) => new ManagedPtr<VkEventCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkQueryPoolCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public VkQueryType queryType;
			[FieldOffset(24)]public uint queryCount;
			[FieldOffset(28)]public uint pipelineStatistics;
		}

        public static ManagedPtr<VkQueryPoolCreateInfo> Pointer(this VkQueryPoolCreateInfo i) => new ManagedPtr<VkQueryPoolCreateInfo>(i);
        public static ManagedPtr<VkQueryPoolCreateInfo[]> Pointer(this VkQueryPoolCreateInfo[] i) => new ManagedPtr<VkQueryPoolCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBufferCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(24)]public ulong size;
			[FieldOffset(32)]public uint usage;
			[FieldOffset(36)]public VkSharingMode sharingMode;
			[FieldOffset(40)]public uint queueFamilyIndexCount;
			[FieldOffset(48)]public uint* pQueueFamilyIndices;
		}

        public static ManagedPtr<VkBufferCreateInfo> Pointer(this VkBufferCreateInfo i) => new ManagedPtr<VkBufferCreateInfo>(i);
        public static ManagedPtr<VkBufferCreateInfo[]> Pointer(this VkBufferCreateInfo[] i) => new ManagedPtr<VkBufferCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBufferViewCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(24)]public IntPtr buffer;
			[FieldOffset(32)]public VkFormat format;
			[FieldOffset(40)]public ulong offset;
			[FieldOffset(48)]public ulong range;
		}

        public static ManagedPtr<VkBufferViewCreateInfo> Pointer(this VkBufferViewCreateInfo i) => new ManagedPtr<VkBufferViewCreateInfo>(i);
        public static ManagedPtr<VkBufferViewCreateInfo[]> Pointer(this VkBufferViewCreateInfo[] i) => new ManagedPtr<VkBufferViewCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public VkImageType imageType;
			[FieldOffset(24)]public VkFormat format;
			[FieldOffset(36)]public VkExtent3D extent;
			[FieldOffset(48)]public uint mipLevels;
			[FieldOffset(52)]public uint arrayLayers;
			[FieldOffset(56)]public VkSampleCountFlagBits samples;
			[FieldOffset(60)]public VkImageTiling tiling;
			[FieldOffset(64)]public uint usage;
			[FieldOffset(68)]public VkSharingMode sharingMode;
			[FieldOffset(72)]public uint queueFamilyIndexCount;
			[FieldOffset(80)]public uint* pQueueFamilyIndices;
			[FieldOffset(88)]public VkImageLayout initialLayout;
		}

        public static ManagedPtr<VkImageCreateInfo> Pointer(this VkImageCreateInfo i) => new ManagedPtr<VkImageCreateInfo>(i);
        public static ManagedPtr<VkImageCreateInfo[]> Pointer(this VkImageCreateInfo[] i) => new ManagedPtr<VkImageCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSubresourceLayout {
			[FieldOffset(0)]public ulong offset;
			[FieldOffset(8)]public ulong size;
			[FieldOffset(16)]public ulong rowPitch;
			[FieldOffset(24)]public ulong arrayPitch;
			[FieldOffset(32)]public ulong depthPitch;
		}

        public static ManagedPtr<VkSubresourceLayout> Pointer(this VkSubresourceLayout i) => new ManagedPtr<VkSubresourceLayout>(i);
        public static ManagedPtr<VkSubresourceLayout[]> Pointer(this VkSubresourceLayout[] i) => new ManagedPtr<VkSubresourceLayout[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkComponentMapping {
			[FieldOffset(0)]public VkComponentSwizzle r;
			[FieldOffset(4)]public VkComponentSwizzle g;
			[FieldOffset(8)]public VkComponentSwizzle b;
			[FieldOffset(12)]public VkComponentSwizzle a;
		}

        public static ManagedPtr<VkComponentMapping> Pointer(this VkComponentMapping i) => new ManagedPtr<VkComponentMapping>(i);
        public static ManagedPtr<VkComponentMapping[]> Pointer(this VkComponentMapping[] i) => new ManagedPtr<VkComponentMapping[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageSubresourceRange {
			[FieldOffset(0)]public uint aspectMask;
			[FieldOffset(4)]public uint baseMipLevel;
			[FieldOffset(8)]public uint levelCount;
			[FieldOffset(12)]public uint baseArrayLayer;
			[FieldOffset(16)]public uint layerCount;
		}

        public static ManagedPtr<VkImageSubresourceRange> Pointer(this VkImageSubresourceRange i) => new ManagedPtr<VkImageSubresourceRange>(i);
        public static ManagedPtr<VkImageSubresourceRange[]> Pointer(this VkImageSubresourceRange[] i) => new ManagedPtr<VkImageSubresourceRange[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageViewCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(24)]public IntPtr image;
			[FieldOffset(32)]public VkImageViewType viewType;
			[FieldOffset(36)]public VkFormat format;
			[FieldOffset(48)]public VkComponentMapping components;
			[FieldOffset(80)]public VkImageSubresourceRange subresourceRange;
		}

        public static ManagedPtr<VkImageViewCreateInfo> Pointer(this VkImageViewCreateInfo i) => new ManagedPtr<VkImageViewCreateInfo>(i);
        public static ManagedPtr<VkImageViewCreateInfo[]> Pointer(this VkImageViewCreateInfo[] i) => new ManagedPtr<VkImageViewCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkShaderModuleCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(24)]public ulong codeSize;
			[FieldOffset(32)]public uint* pCode;
		}

        public static ManagedPtr<VkShaderModuleCreateInfo> Pointer(this VkShaderModuleCreateInfo i) => new ManagedPtr<VkShaderModuleCreateInfo>(i);
        public static ManagedPtr<VkShaderModuleCreateInfo[]> Pointer(this VkShaderModuleCreateInfo[] i) => new ManagedPtr<VkShaderModuleCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineCacheCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(24)]public ulong initialDataSize;
			[FieldOffset(32)]public IntPtr pInitialData;
		}

        public static ManagedPtr<VkPipelineCacheCreateInfo> Pointer(this VkPipelineCacheCreateInfo i) => new ManagedPtr<VkPipelineCacheCreateInfo>(i);
        public static ManagedPtr<VkPipelineCacheCreateInfo[]> Pointer(this VkPipelineCacheCreateInfo[] i) => new ManagedPtr<VkPipelineCacheCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSpecializationMapEntry {
			[FieldOffset(0)]public uint constantID;
			[FieldOffset(4)]public uint offset;
			[FieldOffset(8)]public ulong size;
		}

        public static ManagedPtr<VkSpecializationMapEntry> Pointer(this VkSpecializationMapEntry i) => new ManagedPtr<VkSpecializationMapEntry>(i);
        public static ManagedPtr<VkSpecializationMapEntry[]> Pointer(this VkSpecializationMapEntry[] i) => new ManagedPtr<VkSpecializationMapEntry[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSpecializationInfo {
			[FieldOffset(0)]public uint mapEntryCount;
			[FieldOffset(8)]public IntPtr pMapEntries;
			[FieldOffset(16)]public ulong dataSize;
			[FieldOffset(24)]public IntPtr pData;
		}

        public static ManagedPtr<VkSpecializationInfo> Pointer(this VkSpecializationInfo i) => new ManagedPtr<VkSpecializationInfo>(i);
        public static ManagedPtr<VkSpecializationInfo[]> Pointer(this VkSpecializationInfo[] i) => new ManagedPtr<VkSpecializationInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineShaderStageCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public VkShaderStageFlagBits stage;
			[FieldOffset(24)]public IntPtr module;
			[FieldOffset(32)]public string pName;
			[FieldOffset(40)]public IntPtr pSpecializationInfo;
		}

        public static ManagedPtr<VkPipelineShaderStageCreateInfo> Pointer(this VkPipelineShaderStageCreateInfo i) => new ManagedPtr<VkPipelineShaderStageCreateInfo>(i);
        public static ManagedPtr<VkPipelineShaderStageCreateInfo[]> Pointer(this VkPipelineShaderStageCreateInfo[] i) => new ManagedPtr<VkPipelineShaderStageCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkVertexInputBindingDescription {
			[FieldOffset(0)]public uint binding;
			[FieldOffset(4)]public uint stride;
			[FieldOffset(8)]public VkVertexInputRate inputRate;
		}

        public static ManagedPtr<VkVertexInputBindingDescription> Pointer(this VkVertexInputBindingDescription i) => new ManagedPtr<VkVertexInputBindingDescription>(i);
        public static ManagedPtr<VkVertexInputBindingDescription[]> Pointer(this VkVertexInputBindingDescription[] i) => new ManagedPtr<VkVertexInputBindingDescription[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkVertexInputAttributeDescription {
			[FieldOffset(0)]public uint location;
			[FieldOffset(4)]public uint binding;
			[FieldOffset(8)]public VkFormat format;
			[FieldOffset(12)]public uint offset;
		}

        public static ManagedPtr<VkVertexInputAttributeDescription> Pointer(this VkVertexInputAttributeDescription i) => new ManagedPtr<VkVertexInputAttributeDescription>(i);
        public static ManagedPtr<VkVertexInputAttributeDescription[]> Pointer(this VkVertexInputAttributeDescription[] i) => new ManagedPtr<VkVertexInputAttributeDescription[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineVertexInputStateCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint vertexBindingDescriptionCount;
			[FieldOffset(24)]public IntPtr pVertexBindingDescriptions;
			[FieldOffset(32)]public uint vertexAttributeDescriptionCount;
			[FieldOffset(40)]public IntPtr pVertexAttributeDescriptions;
		}

        public static ManagedPtr<VkPipelineVertexInputStateCreateInfo> Pointer(this VkPipelineVertexInputStateCreateInfo i) => new ManagedPtr<VkPipelineVertexInputStateCreateInfo>(i);
        public static ManagedPtr<VkPipelineVertexInputStateCreateInfo[]> Pointer(this VkPipelineVertexInputStateCreateInfo[] i) => new ManagedPtr<VkPipelineVertexInputStateCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineInputAssemblyStateCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public VkPrimitiveTopology topology;
			[FieldOffset(24)]public uint primitiveRestartEnable;
		}

        public static ManagedPtr<VkPipelineInputAssemblyStateCreateInfo> Pointer(this VkPipelineInputAssemblyStateCreateInfo i) => new ManagedPtr<VkPipelineInputAssemblyStateCreateInfo>(i);
        public static ManagedPtr<VkPipelineInputAssemblyStateCreateInfo[]> Pointer(this VkPipelineInputAssemblyStateCreateInfo[] i) => new ManagedPtr<VkPipelineInputAssemblyStateCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineTessellationStateCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint patchControlPoints;
		}

        public static ManagedPtr<VkPipelineTessellationStateCreateInfo> Pointer(this VkPipelineTessellationStateCreateInfo i) => new ManagedPtr<VkPipelineTessellationStateCreateInfo>(i);
        public static ManagedPtr<VkPipelineTessellationStateCreateInfo[]> Pointer(this VkPipelineTessellationStateCreateInfo[] i) => new ManagedPtr<VkPipelineTessellationStateCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkViewport {
			[FieldOffset(0)]public float x;
			[FieldOffset(4)]public float y;
			[FieldOffset(8)]public float width;
			[FieldOffset(12)]public float height;
			[FieldOffset(16)]public float minDepth;
			[FieldOffset(20)]public float maxDepth;
		}

        public static ManagedPtr<VkViewport> Pointer(this VkViewport i) => new ManagedPtr<VkViewport>(i);
        public static ManagedPtr<VkViewport[]> Pointer(this VkViewport[] i) => new ManagedPtr<VkViewport[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkOffset2D {
			[FieldOffset(0)]public int x;
			[FieldOffset(4)]public int y;
		}

        public static ManagedPtr<VkOffset2D> Pointer(this VkOffset2D i) => new ManagedPtr<VkOffset2D>(i);
        public static ManagedPtr<VkOffset2D[]> Pointer(this VkOffset2D[] i) => new ManagedPtr<VkOffset2D[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExtent2D {
			[FieldOffset(0)]public uint width;
			[FieldOffset(4)]public uint height;
		}

        public static ManagedPtr<VkExtent2D> Pointer(this VkExtent2D i) => new ManagedPtr<VkExtent2D>(i);
        public static ManagedPtr<VkExtent2D[]> Pointer(this VkExtent2D[] i) => new ManagedPtr<VkExtent2D[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRect2D {
			[FieldOffset(0)]public VkOffset2D offset;
			[FieldOffset(8)]public VkExtent2D extent;
		}

        public static ManagedPtr<VkRect2D> Pointer(this VkRect2D i) => new ManagedPtr<VkRect2D>(i);
        public static ManagedPtr<VkRect2D[]> Pointer(this VkRect2D[] i) => new ManagedPtr<VkRect2D[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineViewportStateCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint viewportCount;
			[FieldOffset(24)]public IntPtr pViewports;
			[FieldOffset(32)]public uint scissorCount;
			[FieldOffset(40)]public IntPtr pScissors;
		}

        public static ManagedPtr<VkPipelineViewportStateCreateInfo> Pointer(this VkPipelineViewportStateCreateInfo i) => new ManagedPtr<VkPipelineViewportStateCreateInfo>(i);
        public static ManagedPtr<VkPipelineViewportStateCreateInfo[]> Pointer(this VkPipelineViewportStateCreateInfo[] i) => new ManagedPtr<VkPipelineViewportStateCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineRasterizationStateCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint depthClampEnable;
			[FieldOffset(24)]public uint rasterizerDiscardEnable;
			[FieldOffset(28)]public VkPolygonMode polygonMode;
			[FieldOffset(32)]public uint cullMode;
			[FieldOffset(36)]public VkFrontFace frontFace;
			[FieldOffset(40)]public uint depthBiasEnable;
			[FieldOffset(44)]public float depthBiasConstantFactor;
			[FieldOffset(48)]public float depthBiasClamp;
			[FieldOffset(52)]public float depthBiasSlopeFactor;
			[FieldOffset(56)]public float lineWidth;
		}

        public static ManagedPtr<VkPipelineRasterizationStateCreateInfo> Pointer(this VkPipelineRasterizationStateCreateInfo i) => new ManagedPtr<VkPipelineRasterizationStateCreateInfo>(i);
        public static ManagedPtr<VkPipelineRasterizationStateCreateInfo[]> Pointer(this VkPipelineRasterizationStateCreateInfo[] i) => new ManagedPtr<VkPipelineRasterizationStateCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineMultisampleStateCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public VkSampleCountFlagBits rasterizationSamples;
			[FieldOffset(24)]public uint sampleShadingEnable;
			[FieldOffset(28)]public float minSampleShading;
			[FieldOffset(32)]public uint* pSampleMask;
			[FieldOffset(40)]public uint alphaToCoverageEnable;
			[FieldOffset(44)]public uint alphaToOneEnable;
		}

        public static ManagedPtr<VkPipelineMultisampleStateCreateInfo> Pointer(this VkPipelineMultisampleStateCreateInfo i) => new ManagedPtr<VkPipelineMultisampleStateCreateInfo>(i);
        public static ManagedPtr<VkPipelineMultisampleStateCreateInfo[]> Pointer(this VkPipelineMultisampleStateCreateInfo[] i) => new ManagedPtr<VkPipelineMultisampleStateCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkStencilOpState {
			[FieldOffset(0)]public VkStencilOp failOp;
			[FieldOffset(4)]public VkStencilOp passOp;
			[FieldOffset(8)]public VkStencilOp depthFailOp;
			[FieldOffset(12)]public VkCompareOp compareOp;
			[FieldOffset(16)]public uint compareMask;
			[FieldOffset(20)]public uint writeMask;
			[FieldOffset(24)]public uint reference;
		}

        public static ManagedPtr<VkStencilOpState> Pointer(this VkStencilOpState i) => new ManagedPtr<VkStencilOpState>(i);
        public static ManagedPtr<VkStencilOpState[]> Pointer(this VkStencilOpState[] i) => new ManagedPtr<VkStencilOpState[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineDepthStencilStateCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint depthTestEnable;
			[FieldOffset(24)]public uint depthWriteEnable;
			[FieldOffset(28)]public VkCompareOp depthCompareOp;
			[FieldOffset(32)]public uint depthBoundsTestEnable;
			[FieldOffset(36)]public uint stencilTestEnable;
			[FieldOffset(56)]public VkStencilOpState front;
			[FieldOffset(84)]public VkStencilOpState back;
			[FieldOffset(112)]public float minDepthBounds;
			[FieldOffset(116)]public float maxDepthBounds;
		}

        public static ManagedPtr<VkPipelineDepthStencilStateCreateInfo> Pointer(this VkPipelineDepthStencilStateCreateInfo i) => new ManagedPtr<VkPipelineDepthStencilStateCreateInfo>(i);
        public static ManagedPtr<VkPipelineDepthStencilStateCreateInfo[]> Pointer(this VkPipelineDepthStencilStateCreateInfo[] i) => new ManagedPtr<VkPipelineDepthStencilStateCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineColorBlendAttachmentState {
			[FieldOffset(0)]public uint blendEnable;
			[FieldOffset(4)]public VkBlendFactor srcColorBlendFactor;
			[FieldOffset(8)]public VkBlendFactor dstColorBlendFactor;
			[FieldOffset(12)]public VkBlendOp colorBlendOp;
			[FieldOffset(16)]public VkBlendFactor srcAlphaBlendFactor;
			[FieldOffset(20)]public VkBlendFactor dstAlphaBlendFactor;
			[FieldOffset(24)]public VkBlendOp alphaBlendOp;
			[FieldOffset(28)]public uint colorWriteMask;
		}

        public static ManagedPtr<VkPipelineColorBlendAttachmentState> Pointer(this VkPipelineColorBlendAttachmentState i) => new ManagedPtr<VkPipelineColorBlendAttachmentState>(i);
        public static ManagedPtr<VkPipelineColorBlendAttachmentState[]> Pointer(this VkPipelineColorBlendAttachmentState[] i) => new ManagedPtr<VkPipelineColorBlendAttachmentState[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineColorBlendStateCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint logicOpEnable;
			[FieldOffset(24)]public VkLogicOp logicOp;
			[FieldOffset(28)]public uint attachmentCount;
			[FieldOffset(32)]public IntPtr pAttachments;
			[FieldOffset(40)][MarshalAs(UnmanagedType.ByValArray, SizeConst=4)] public float[] blendConstants;
		}

        public static ManagedPtr<VkPipelineColorBlendStateCreateInfo> Pointer(this VkPipelineColorBlendStateCreateInfo i) => new ManagedPtr<VkPipelineColorBlendStateCreateInfo>(i);
        public static ManagedPtr<VkPipelineColorBlendStateCreateInfo[]> Pointer(this VkPipelineColorBlendStateCreateInfo[] i) => new ManagedPtr<VkPipelineColorBlendStateCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineDynamicStateCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint dynamicStateCount;
			[FieldOffset(24)]public VkDynamicState* pDynamicStates;
		}

        public static ManagedPtr<VkPipelineDynamicStateCreateInfo> Pointer(this VkPipelineDynamicStateCreateInfo i) => new ManagedPtr<VkPipelineDynamicStateCreateInfo>(i);
        public static ManagedPtr<VkPipelineDynamicStateCreateInfo[]> Pointer(this VkPipelineDynamicStateCreateInfo[] i) => new ManagedPtr<VkPipelineDynamicStateCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkGraphicsPipelineCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint stageCount;
			[FieldOffset(24)]public IntPtr pStages;
			[FieldOffset(32)]public IntPtr pVertexInputState;
			[FieldOffset(40)]public IntPtr pInputAssemblyState;
			[FieldOffset(48)]public IntPtr pTessellationState;
			[FieldOffset(56)]public IntPtr pViewportState;
			[FieldOffset(64)]public IntPtr pRasterizationState;
			[FieldOffset(72)]public IntPtr pMultisampleState;
			[FieldOffset(80)]public IntPtr pDepthStencilState;
			[FieldOffset(88)]public IntPtr pColorBlendState;
			[FieldOffset(96)]public IntPtr pDynamicState;
			[FieldOffset(104)]public IntPtr layout;
			[FieldOffset(112)]public IntPtr renderPass;
			[FieldOffset(120)]public uint subpass;
			[FieldOffset(128)]public IntPtr basePipelineHandle;
			[FieldOffset(136)]public int basePipelineIndex;
		}

        public static ManagedPtr<VkGraphicsPipelineCreateInfo> Pointer(this VkGraphicsPipelineCreateInfo i) => new ManagedPtr<VkGraphicsPipelineCreateInfo>(i);
        public static ManagedPtr<VkGraphicsPipelineCreateInfo[]> Pointer(this VkGraphicsPipelineCreateInfo[] i) => new ManagedPtr<VkGraphicsPipelineCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkComputePipelineCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(48)]public VkPipelineShaderStageCreateInfo stage;
			[FieldOffset(96)]public IntPtr layout;
			[FieldOffset(104)]public IntPtr basePipelineHandle;
			[FieldOffset(112)]public int basePipelineIndex;
		}

        public static ManagedPtr<VkComputePipelineCreateInfo> Pointer(this VkComputePipelineCreateInfo i) => new ManagedPtr<VkComputePipelineCreateInfo>(i);
        public static ManagedPtr<VkComputePipelineCreateInfo[]> Pointer(this VkComputePipelineCreateInfo[] i) => new ManagedPtr<VkComputePipelineCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPushConstantRange {
			[FieldOffset(0)]public uint stageFlags;
			[FieldOffset(4)]public uint offset;
			[FieldOffset(8)]public uint size;
		}

        public static ManagedPtr<VkPushConstantRange> Pointer(this VkPushConstantRange i) => new ManagedPtr<VkPushConstantRange>(i);
        public static ManagedPtr<VkPushConstantRange[]> Pointer(this VkPushConstantRange[] i) => new ManagedPtr<VkPushConstantRange[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineLayoutCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint setLayoutCount;
			[FieldOffset(24)]public IntPtr* pSetLayouts;
			[FieldOffset(32)]public uint pushConstantRangeCount;
			[FieldOffset(40)]public IntPtr pPushConstantRanges;
		}

        public static ManagedPtr<VkPipelineLayoutCreateInfo> Pointer(this VkPipelineLayoutCreateInfo i) => new ManagedPtr<VkPipelineLayoutCreateInfo>(i);
        public static ManagedPtr<VkPipelineLayoutCreateInfo[]> Pointer(this VkPipelineLayoutCreateInfo[] i) => new ManagedPtr<VkPipelineLayoutCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSamplerCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public VkFilter magFilter;
			[FieldOffset(24)]public VkFilter minFilter;
			[FieldOffset(28)]public VkSamplerMipmapMode mipmapMode;
			[FieldOffset(32)]public VkSamplerAddressMode addressModeU;
			[FieldOffset(36)]public VkSamplerAddressMode addressModeV;
			[FieldOffset(40)]public VkSamplerAddressMode addressModeW;
			[FieldOffset(44)]public float mipLodBias;
			[FieldOffset(48)]public uint anisotropyEnable;
			[FieldOffset(52)]public float maxAnisotropy;
			[FieldOffset(56)]public uint compareEnable;
			[FieldOffset(60)]public VkCompareOp compareOp;
			[FieldOffset(64)]public float minLod;
			[FieldOffset(68)]public float maxLod;
			[FieldOffset(72)]public VkBorderColor borderColor;
			[FieldOffset(76)]public uint unnormalizedCoordinates;
		}

        public static ManagedPtr<VkSamplerCreateInfo> Pointer(this VkSamplerCreateInfo i) => new ManagedPtr<VkSamplerCreateInfo>(i);
        public static ManagedPtr<VkSamplerCreateInfo[]> Pointer(this VkSamplerCreateInfo[] i) => new ManagedPtr<VkSamplerCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorSetLayoutBinding {
			[FieldOffset(0)]public uint binding;
			[FieldOffset(4)]public VkDescriptorType descriptorType;
			[FieldOffset(8)]public uint descriptorCount;
			[FieldOffset(12)]public uint stageFlags;
			[FieldOffset(16)]public IntPtr* pImmutableSamplers;
		}

        public static ManagedPtr<VkDescriptorSetLayoutBinding> Pointer(this VkDescriptorSetLayoutBinding i) => new ManagedPtr<VkDescriptorSetLayoutBinding>(i);
        public static ManagedPtr<VkDescriptorSetLayoutBinding[]> Pointer(this VkDescriptorSetLayoutBinding[] i) => new ManagedPtr<VkDescriptorSetLayoutBinding[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorSetLayoutCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint bindingCount;
			[FieldOffset(24)]public IntPtr pBindings;
		}

        public static ManagedPtr<VkDescriptorSetLayoutCreateInfo> Pointer(this VkDescriptorSetLayoutCreateInfo i) => new ManagedPtr<VkDescriptorSetLayoutCreateInfo>(i);
        public static ManagedPtr<VkDescriptorSetLayoutCreateInfo[]> Pointer(this VkDescriptorSetLayoutCreateInfo[] i) => new ManagedPtr<VkDescriptorSetLayoutCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorPoolSize {
			[FieldOffset(0)]public VkDescriptorType type;
			[FieldOffset(4)]public uint descriptorCount;
		}

        public static ManagedPtr<VkDescriptorPoolSize> Pointer(this VkDescriptorPoolSize i) => new ManagedPtr<VkDescriptorPoolSize>(i);
        public static ManagedPtr<VkDescriptorPoolSize[]> Pointer(this VkDescriptorPoolSize[] i) => new ManagedPtr<VkDescriptorPoolSize[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorPoolCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint maxSets;
			[FieldOffset(24)]public uint poolSizeCount;
			[FieldOffset(32)]public IntPtr pPoolSizes;
		}

        public static ManagedPtr<VkDescriptorPoolCreateInfo> Pointer(this VkDescriptorPoolCreateInfo i) => new ManagedPtr<VkDescriptorPoolCreateInfo>(i);
        public static ManagedPtr<VkDescriptorPoolCreateInfo[]> Pointer(this VkDescriptorPoolCreateInfo[] i) => new ManagedPtr<VkDescriptorPoolCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorSetAllocateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr descriptorPool;
			[FieldOffset(24)]public uint descriptorSetCount;
			[FieldOffset(32)]public IntPtr* pSetLayouts;
		}

        public static ManagedPtr<VkDescriptorSetAllocateInfo> Pointer(this VkDescriptorSetAllocateInfo i) => new ManagedPtr<VkDescriptorSetAllocateInfo>(i);
        public static ManagedPtr<VkDescriptorSetAllocateInfo[]> Pointer(this VkDescriptorSetAllocateInfo[] i) => new ManagedPtr<VkDescriptorSetAllocateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorImageInfo {
			[FieldOffset(0)]public IntPtr sampler;
			[FieldOffset(8)]public IntPtr imageView;
			[FieldOffset(16)]public VkImageLayout imageLayout;
		}

        public static ManagedPtr<VkDescriptorImageInfo> Pointer(this VkDescriptorImageInfo i) => new ManagedPtr<VkDescriptorImageInfo>(i);
        public static ManagedPtr<VkDescriptorImageInfo[]> Pointer(this VkDescriptorImageInfo[] i) => new ManagedPtr<VkDescriptorImageInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorBufferInfo {
			[FieldOffset(0)]public IntPtr buffer;
			[FieldOffset(8)]public ulong offset;
			[FieldOffset(16)]public ulong range;
		}

        public static ManagedPtr<VkDescriptorBufferInfo> Pointer(this VkDescriptorBufferInfo i) => new ManagedPtr<VkDescriptorBufferInfo>(i);
        public static ManagedPtr<VkDescriptorBufferInfo[]> Pointer(this VkDescriptorBufferInfo[] i) => new ManagedPtr<VkDescriptorBufferInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkWriteDescriptorSet {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr dstSet;
			[FieldOffset(24)]public uint dstBinding;
			[FieldOffset(28)]public uint dstArrayElement;
			[FieldOffset(32)]public uint descriptorCount;
			[FieldOffset(36)]public VkDescriptorType descriptorType;
			[FieldOffset(40)]public IntPtr pImageInfo;
			[FieldOffset(48)]public IntPtr pBufferInfo;
			[FieldOffset(56)]public IntPtr* pTexelBufferView;
		}

        public static ManagedPtr<VkWriteDescriptorSet> Pointer(this VkWriteDescriptorSet i) => new ManagedPtr<VkWriteDescriptorSet>(i);
        public static ManagedPtr<VkWriteDescriptorSet[]> Pointer(this VkWriteDescriptorSet[] i) => new ManagedPtr<VkWriteDescriptorSet[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkCopyDescriptorSet {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr srcSet;
			[FieldOffset(24)]public uint srcBinding;
			[FieldOffset(28)]public uint srcArrayElement;
			[FieldOffset(32)]public IntPtr dstSet;
			[FieldOffset(40)]public uint dstBinding;
			[FieldOffset(44)]public uint dstArrayElement;
			[FieldOffset(48)]public uint descriptorCount;
		}

        public static ManagedPtr<VkCopyDescriptorSet> Pointer(this VkCopyDescriptorSet i) => new ManagedPtr<VkCopyDescriptorSet>(i);
        public static ManagedPtr<VkCopyDescriptorSet[]> Pointer(this VkCopyDescriptorSet[] i) => new ManagedPtr<VkCopyDescriptorSet[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkFramebufferCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(24)]public IntPtr renderPass;
			[FieldOffset(32)]public uint attachmentCount;
			[FieldOffset(40)]public IntPtr* pAttachments;
			[FieldOffset(48)]public uint width;
			[FieldOffset(52)]public uint height;
			[FieldOffset(56)]public uint layers;
		}

        public static ManagedPtr<VkFramebufferCreateInfo> Pointer(this VkFramebufferCreateInfo i) => new ManagedPtr<VkFramebufferCreateInfo>(i);
        public static ManagedPtr<VkFramebufferCreateInfo[]> Pointer(this VkFramebufferCreateInfo[] i) => new ManagedPtr<VkFramebufferCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAttachmentDescription {
			[FieldOffset(0)]public uint flags;
			[FieldOffset(4)]public VkFormat format;
			[FieldOffset(8)]public VkSampleCountFlagBits samples;
			[FieldOffset(12)]public VkAttachmentLoadOp loadOp;
			[FieldOffset(16)]public VkAttachmentStoreOp storeOp;
			[FieldOffset(20)]public VkAttachmentLoadOp stencilLoadOp;
			[FieldOffset(24)]public VkAttachmentStoreOp stencilStoreOp;
			[FieldOffset(28)]public VkImageLayout initialLayout;
			[FieldOffset(32)]public VkImageLayout finalLayout;
		}

        public static ManagedPtr<VkAttachmentDescription> Pointer(this VkAttachmentDescription i) => new ManagedPtr<VkAttachmentDescription>(i);
        public static ManagedPtr<VkAttachmentDescription[]> Pointer(this VkAttachmentDescription[] i) => new ManagedPtr<VkAttachmentDescription[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAttachmentReference {
			[FieldOffset(0)]public uint attachment;
			[FieldOffset(4)]public VkImageLayout layout;
		}

        public static ManagedPtr<VkAttachmentReference> Pointer(this VkAttachmentReference i) => new ManagedPtr<VkAttachmentReference>(i);
        public static ManagedPtr<VkAttachmentReference[]> Pointer(this VkAttachmentReference[] i) => new ManagedPtr<VkAttachmentReference[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSubpassDescription {
			[FieldOffset(0)]public uint flags;
			[FieldOffset(4)]public VkPipelineBindPoint pipelineBindPoint;
			[FieldOffset(8)]public uint inputAttachmentCount;
			[FieldOffset(16)]public IntPtr pInputAttachments;
			[FieldOffset(24)]public uint colorAttachmentCount;
			[FieldOffset(32)]public IntPtr pColorAttachments;
			[FieldOffset(40)]public IntPtr pResolveAttachments;
			[FieldOffset(48)]public IntPtr pDepthStencilAttachment;
			[FieldOffset(56)]public uint preserveAttachmentCount;
			[FieldOffset(64)]public uint* pPreserveAttachments;
		}

        public static ManagedPtr<VkSubpassDescription> Pointer(this VkSubpassDescription i) => new ManagedPtr<VkSubpassDescription>(i);
        public static ManagedPtr<VkSubpassDescription[]> Pointer(this VkSubpassDescription[] i) => new ManagedPtr<VkSubpassDescription[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSubpassDependency {
			[FieldOffset(0)]public uint srcSubpass;
			[FieldOffset(4)]public uint dstSubpass;
			[FieldOffset(8)]public uint srcStageMask;
			[FieldOffset(12)]public uint dstStageMask;
			[FieldOffset(16)]public uint srcAccessMask;
			[FieldOffset(20)]public uint dstAccessMask;
			[FieldOffset(24)]public uint dependencyFlags;
		}

        public static ManagedPtr<VkSubpassDependency> Pointer(this VkSubpassDependency i) => new ManagedPtr<VkSubpassDependency>(i);
        public static ManagedPtr<VkSubpassDependency[]> Pointer(this VkSubpassDependency[] i) => new ManagedPtr<VkSubpassDependency[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRenderPassCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint attachmentCount;
			[FieldOffset(24)]public IntPtr pAttachments;
			[FieldOffset(32)]public uint subpassCount;
			[FieldOffset(40)]public IntPtr pSubpasses;
			[FieldOffset(48)]public uint dependencyCount;
			[FieldOffset(56)]public IntPtr pDependencies;
		}

        public static ManagedPtr<VkRenderPassCreateInfo> Pointer(this VkRenderPassCreateInfo i) => new ManagedPtr<VkRenderPassCreateInfo>(i);
        public static ManagedPtr<VkRenderPassCreateInfo[]> Pointer(this VkRenderPassCreateInfo[] i) => new ManagedPtr<VkRenderPassCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkCommandPoolCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint queueFamilyIndex;
		}

        public static ManagedPtr<VkCommandPoolCreateInfo> Pointer(this VkCommandPoolCreateInfo i) => new ManagedPtr<VkCommandPoolCreateInfo>(i);
        public static ManagedPtr<VkCommandPoolCreateInfo[]> Pointer(this VkCommandPoolCreateInfo[] i) => new ManagedPtr<VkCommandPoolCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkCommandBufferAllocateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr commandPool;
			[FieldOffset(24)]public VkCommandBufferLevel level;
			[FieldOffset(28)]public uint commandBufferCount;
		}

        public static ManagedPtr<VkCommandBufferAllocateInfo> Pointer(this VkCommandBufferAllocateInfo i) => new ManagedPtr<VkCommandBufferAllocateInfo>(i);
        public static ManagedPtr<VkCommandBufferAllocateInfo[]> Pointer(this VkCommandBufferAllocateInfo[] i) => new ManagedPtr<VkCommandBufferAllocateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkCommandBufferInheritanceInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr renderPass;
			[FieldOffset(24)]public uint subpass;
			[FieldOffset(32)]public IntPtr framebuffer;
			[FieldOffset(40)]public uint occlusionQueryEnable;
			[FieldOffset(44)]public uint queryFlags;
			[FieldOffset(48)]public uint pipelineStatistics;
		}

        public static ManagedPtr<VkCommandBufferInheritanceInfo> Pointer(this VkCommandBufferInheritanceInfo i) => new ManagedPtr<VkCommandBufferInheritanceInfo>(i);
        public static ManagedPtr<VkCommandBufferInheritanceInfo[]> Pointer(this VkCommandBufferInheritanceInfo[] i) => new ManagedPtr<VkCommandBufferInheritanceInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkCommandBufferBeginInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(24)]public IntPtr pInheritanceInfo;
		}

        public static ManagedPtr<VkCommandBufferBeginInfo> Pointer(this VkCommandBufferBeginInfo i) => new ManagedPtr<VkCommandBufferBeginInfo>(i);
        public static ManagedPtr<VkCommandBufferBeginInfo[]> Pointer(this VkCommandBufferBeginInfo[] i) => new ManagedPtr<VkCommandBufferBeginInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBufferCopy {
			[FieldOffset(0)]public ulong srcOffset;
			[FieldOffset(8)]public ulong dstOffset;
			[FieldOffset(16)]public ulong size;
		}

        public static ManagedPtr<VkBufferCopy> Pointer(this VkBufferCopy i) => new ManagedPtr<VkBufferCopy>(i);
        public static ManagedPtr<VkBufferCopy[]> Pointer(this VkBufferCopy[] i) => new ManagedPtr<VkBufferCopy[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageSubresourceLayers {
			[FieldOffset(0)]public uint aspectMask;
			[FieldOffset(4)]public uint mipLevel;
			[FieldOffset(8)]public uint baseArrayLayer;
			[FieldOffset(12)]public uint layerCount;
		}

        public static ManagedPtr<VkImageSubresourceLayers> Pointer(this VkImageSubresourceLayers i) => new ManagedPtr<VkImageSubresourceLayers>(i);
        public static ManagedPtr<VkImageSubresourceLayers[]> Pointer(this VkImageSubresourceLayers[] i) => new ManagedPtr<VkImageSubresourceLayers[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageCopy {
			[FieldOffset(0)]public VkImageSubresourceLayers srcSubresource;
			[FieldOffset(24)]public VkOffset3D srcOffset;
			[FieldOffset(48)]public VkImageSubresourceLayers dstSubresource;
			[FieldOffset(72)]public VkOffset3D dstOffset;
			[FieldOffset(84)]public VkExtent3D extent;
		}

        public static ManagedPtr<VkImageCopy> Pointer(this VkImageCopy i) => new ManagedPtr<VkImageCopy>(i);
        public static ManagedPtr<VkImageCopy[]> Pointer(this VkImageCopy[] i) => new ManagedPtr<VkImageCopy[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageBlit {
			[FieldOffset(0)]public VkImageSubresourceLayers srcSubresource;
			[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray, SizeConst=2)] public VkOffset3D[] srcOffsets;
			[FieldOffset(48)]public VkImageSubresourceLayers dstSubresource;
			[FieldOffset(72)][MarshalAs(UnmanagedType.ByValArray, SizeConst=2)] public VkOffset3D[] dstOffsets;
		}

        public static ManagedPtr<VkImageBlit> Pointer(this VkImageBlit i) => new ManagedPtr<VkImageBlit>(i);
        public static ManagedPtr<VkImageBlit[]> Pointer(this VkImageBlit[] i) => new ManagedPtr<VkImageBlit[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBufferImageCopy {
			[FieldOffset(0)]public ulong bufferOffset;
			[FieldOffset(8)]public uint bufferRowLength;
			[FieldOffset(12)]public uint bufferImageHeight;
			[FieldOffset(16)]public VkImageSubresourceLayers imageSubresource;
			[FieldOffset(36)]public VkOffset3D imageOffset;
			[FieldOffset(48)]public VkExtent3D imageExtent;
		}

        public static ManagedPtr<VkBufferImageCopy> Pointer(this VkBufferImageCopy i) => new ManagedPtr<VkBufferImageCopy>(i);
        public static ManagedPtr<VkBufferImageCopy[]> Pointer(this VkBufferImageCopy[] i) => new ManagedPtr<VkBufferImageCopy[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkClearDepthStencilValue {
			[FieldOffset(0)]public float depth;
			[FieldOffset(4)]public uint stencil;
		}

        public static ManagedPtr<VkClearDepthStencilValue> Pointer(this VkClearDepthStencilValue i) => new ManagedPtr<VkClearDepthStencilValue>(i);
        public static ManagedPtr<VkClearDepthStencilValue[]> Pointer(this VkClearDepthStencilValue[] i) => new ManagedPtr<VkClearDepthStencilValue[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkClearAttachment {
			[FieldOffset(0)]public uint aspectMask;
			[FieldOffset(4)]public uint colorAttachment;
			[FieldOffset(8)]public VkClearValue clearValue;
		}

        public static ManagedPtr<VkClearAttachment> Pointer(this VkClearAttachment i) => new ManagedPtr<VkClearAttachment>(i);
        public static ManagedPtr<VkClearAttachment[]> Pointer(this VkClearAttachment[] i) => new ManagedPtr<VkClearAttachment[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkClearRect {
			[FieldOffset(0)]public VkRect2D rect;
			[FieldOffset(16)]public uint baseArrayLayer;
			[FieldOffset(20)]public uint layerCount;
		}

        public static ManagedPtr<VkClearRect> Pointer(this VkClearRect i) => new ManagedPtr<VkClearRect>(i);
        public static ManagedPtr<VkClearRect[]> Pointer(this VkClearRect[] i) => new ManagedPtr<VkClearRect[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageResolve {
			[FieldOffset(0)]public VkImageSubresourceLayers srcSubresource;
			[FieldOffset(24)]public VkOffset3D srcOffset;
			[FieldOffset(48)]public VkImageSubresourceLayers dstSubresource;
			[FieldOffset(72)]public VkOffset3D dstOffset;
			[FieldOffset(84)]public VkExtent3D extent;
		}

        public static ManagedPtr<VkImageResolve> Pointer(this VkImageResolve i) => new ManagedPtr<VkImageResolve>(i);
        public static ManagedPtr<VkImageResolve[]> Pointer(this VkImageResolve[] i) => new ManagedPtr<VkImageResolve[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryBarrier {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint srcAccessMask;
			[FieldOffset(20)]public uint dstAccessMask;
		}

        public static ManagedPtr<VkMemoryBarrier> Pointer(this VkMemoryBarrier i) => new ManagedPtr<VkMemoryBarrier>(i);
        public static ManagedPtr<VkMemoryBarrier[]> Pointer(this VkMemoryBarrier[] i) => new ManagedPtr<VkMemoryBarrier[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBufferMemoryBarrier {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint srcAccessMask;
			[FieldOffset(20)]public uint dstAccessMask;
			[FieldOffset(24)]public uint srcQueueFamilyIndex;
			[FieldOffset(28)]public uint dstQueueFamilyIndex;
			[FieldOffset(32)]public IntPtr buffer;
			[FieldOffset(40)]public ulong offset;
			[FieldOffset(48)]public ulong size;
		}

        public static ManagedPtr<VkBufferMemoryBarrier> Pointer(this VkBufferMemoryBarrier i) => new ManagedPtr<VkBufferMemoryBarrier>(i);
        public static ManagedPtr<VkBufferMemoryBarrier[]> Pointer(this VkBufferMemoryBarrier[] i) => new ManagedPtr<VkBufferMemoryBarrier[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageMemoryBarrier {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint srcAccessMask;
			[FieldOffset(20)]public uint dstAccessMask;
			[FieldOffset(24)]public VkImageLayout oldLayout;
			[FieldOffset(28)]public VkImageLayout newLayout;
			[FieldOffset(32)]public uint srcQueueFamilyIndex;
			[FieldOffset(36)]public uint dstQueueFamilyIndex;
			[FieldOffset(40)]public IntPtr image;
			[FieldOffset(60)]public VkImageSubresourceRange subresourceRange;
		}

        public static ManagedPtr<VkImageMemoryBarrier> Pointer(this VkImageMemoryBarrier i) => new ManagedPtr<VkImageMemoryBarrier>(i);
        public static ManagedPtr<VkImageMemoryBarrier[]> Pointer(this VkImageMemoryBarrier[] i) => new ManagedPtr<VkImageMemoryBarrier[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRenderPassBeginInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr renderPass;
			[FieldOffset(24)]public IntPtr framebuffer;
			[FieldOffset(32)]public VkRect2D renderArea;
			[FieldOffset(48)]public uint clearValueCount;
			[FieldOffset(56)]public IntPtr pClearValues;
		}

        public static ManagedPtr<VkRenderPassBeginInfo> Pointer(this VkRenderPassBeginInfo i) => new ManagedPtr<VkRenderPassBeginInfo>(i);
        public static ManagedPtr<VkRenderPassBeginInfo[]> Pointer(this VkRenderPassBeginInfo[] i) => new ManagedPtr<VkRenderPassBeginInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDispatchIndirectCommand {
			[FieldOffset(0)]public uint x;
			[FieldOffset(4)]public uint y;
			[FieldOffset(8)]public uint z;
		}

        public static ManagedPtr<VkDispatchIndirectCommand> Pointer(this VkDispatchIndirectCommand i) => new ManagedPtr<VkDispatchIndirectCommand>(i);
        public static ManagedPtr<VkDispatchIndirectCommand[]> Pointer(this VkDispatchIndirectCommand[] i) => new ManagedPtr<VkDispatchIndirectCommand[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDrawIndexedIndirectCommand {
			[FieldOffset(0)]public uint indexCount;
			[FieldOffset(4)]public uint instanceCount;
			[FieldOffset(8)]public uint firstIndex;
			[FieldOffset(12)]public int vertexOffset;
			[FieldOffset(16)]public uint firstInstance;
		}

        public static ManagedPtr<VkDrawIndexedIndirectCommand> Pointer(this VkDrawIndexedIndirectCommand i) => new ManagedPtr<VkDrawIndexedIndirectCommand>(i);
        public static ManagedPtr<VkDrawIndexedIndirectCommand[]> Pointer(this VkDrawIndexedIndirectCommand[] i) => new ManagedPtr<VkDrawIndexedIndirectCommand[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDrawIndirectCommand {
			[FieldOffset(0)]public uint vertexCount;
			[FieldOffset(4)]public uint instanceCount;
			[FieldOffset(8)]public uint firstVertex;
			[FieldOffset(12)]public uint firstInstance;
		}

        public static ManagedPtr<VkDrawIndirectCommand> Pointer(this VkDrawIndirectCommand i) => new ManagedPtr<VkDrawIndirectCommand>(i);
        public static ManagedPtr<VkDrawIndirectCommand[]> Pointer(this VkDrawIndirectCommand[] i) => new ManagedPtr<VkDrawIndirectCommand[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBaseOutStructure {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
		}

        public static ManagedPtr<VkBaseOutStructure> Pointer(this VkBaseOutStructure i) => new ManagedPtr<VkBaseOutStructure>(i);
        public static ManagedPtr<VkBaseOutStructure[]> Pointer(this VkBaseOutStructure[] i) => new ManagedPtr<VkBaseOutStructure[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBaseInStructure {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
		}

        public static ManagedPtr<VkBaseInStructure> Pointer(this VkBaseInStructure i) => new ManagedPtr<VkBaseInStructure>(i);
        public static ManagedPtr<VkBaseInStructure[]> Pointer(this VkBaseInStructure[] i) => new ManagedPtr<VkBaseInStructure[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceSubgroupProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint subgroupSize;
			[FieldOffset(20)]public uint supportedStages;
			[FieldOffset(24)]public uint supportedOperations;
			[FieldOffset(28)]public uint quadOperationsInAllStages;
		}

        public static ManagedPtr<VkPhysicalDeviceSubgroupProperties> Pointer(this VkPhysicalDeviceSubgroupProperties i) => new ManagedPtr<VkPhysicalDeviceSubgroupProperties>(i);
        public static ManagedPtr<VkPhysicalDeviceSubgroupProperties[]> Pointer(this VkPhysicalDeviceSubgroupProperties[] i) => new ManagedPtr<VkPhysicalDeviceSubgroupProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBindBufferMemoryInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr buffer;
			[FieldOffset(24)]public IntPtr memory;
			[FieldOffset(32)]public ulong memoryOffset;
		}

        public static ManagedPtr<VkBindBufferMemoryInfo> Pointer(this VkBindBufferMemoryInfo i) => new ManagedPtr<VkBindBufferMemoryInfo>(i);
        public static ManagedPtr<VkBindBufferMemoryInfo[]> Pointer(this VkBindBufferMemoryInfo[] i) => new ManagedPtr<VkBindBufferMemoryInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBindImageMemoryInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr image;
			[FieldOffset(24)]public IntPtr memory;
			[FieldOffset(32)]public ulong memoryOffset;
		}

        public static ManagedPtr<VkBindImageMemoryInfo> Pointer(this VkBindImageMemoryInfo i) => new ManagedPtr<VkBindImageMemoryInfo>(i);
        public static ManagedPtr<VkBindImageMemoryInfo[]> Pointer(this VkBindImageMemoryInfo[] i) => new ManagedPtr<VkBindImageMemoryInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDevice16BitStorageFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint storageBuffer16BitAccess;
			[FieldOffset(20)]public uint uniformAndStorageBuffer16BitAccess;
			[FieldOffset(24)]public uint storagePushConstant16;
			[FieldOffset(28)]public uint storageInputOutput16;
		}

        public static ManagedPtr<VkPhysicalDevice16BitStorageFeatures> Pointer(this VkPhysicalDevice16BitStorageFeatures i) => new ManagedPtr<VkPhysicalDevice16BitStorageFeatures>(i);
        public static ManagedPtr<VkPhysicalDevice16BitStorageFeatures[]> Pointer(this VkPhysicalDevice16BitStorageFeatures[] i) => new ManagedPtr<VkPhysicalDevice16BitStorageFeatures[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryDedicatedRequirements {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint prefersDedicatedAllocation;
			[FieldOffset(20)]public uint requiresDedicatedAllocation;
		}

        public static ManagedPtr<VkMemoryDedicatedRequirements> Pointer(this VkMemoryDedicatedRequirements i) => new ManagedPtr<VkMemoryDedicatedRequirements>(i);
        public static ManagedPtr<VkMemoryDedicatedRequirements[]> Pointer(this VkMemoryDedicatedRequirements[] i) => new ManagedPtr<VkMemoryDedicatedRequirements[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryDedicatedAllocateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr image;
			[FieldOffset(24)]public IntPtr buffer;
		}

        public static ManagedPtr<VkMemoryDedicatedAllocateInfo> Pointer(this VkMemoryDedicatedAllocateInfo i) => new ManagedPtr<VkMemoryDedicatedAllocateInfo>(i);
        public static ManagedPtr<VkMemoryDedicatedAllocateInfo[]> Pointer(this VkMemoryDedicatedAllocateInfo[] i) => new ManagedPtr<VkMemoryDedicatedAllocateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryAllocateFlagsInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint deviceMask;
		}

        public static ManagedPtr<VkMemoryAllocateFlagsInfo> Pointer(this VkMemoryAllocateFlagsInfo i) => new ManagedPtr<VkMemoryAllocateFlagsInfo>(i);
        public static ManagedPtr<VkMemoryAllocateFlagsInfo[]> Pointer(this VkMemoryAllocateFlagsInfo[] i) => new ManagedPtr<VkMemoryAllocateFlagsInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceGroupRenderPassBeginInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint deviceMask;
			[FieldOffset(20)]public uint deviceRenderAreaCount;
			[FieldOffset(24)]public IntPtr pDeviceRenderAreas;
		}

        public static ManagedPtr<VkDeviceGroupRenderPassBeginInfo> Pointer(this VkDeviceGroupRenderPassBeginInfo i) => new ManagedPtr<VkDeviceGroupRenderPassBeginInfo>(i);
        public static ManagedPtr<VkDeviceGroupRenderPassBeginInfo[]> Pointer(this VkDeviceGroupRenderPassBeginInfo[] i) => new ManagedPtr<VkDeviceGroupRenderPassBeginInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceGroupCommandBufferBeginInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint deviceMask;
		}

        public static ManagedPtr<VkDeviceGroupCommandBufferBeginInfo> Pointer(this VkDeviceGroupCommandBufferBeginInfo i) => new ManagedPtr<VkDeviceGroupCommandBufferBeginInfo>(i);
        public static ManagedPtr<VkDeviceGroupCommandBufferBeginInfo[]> Pointer(this VkDeviceGroupCommandBufferBeginInfo[] i) => new ManagedPtr<VkDeviceGroupCommandBufferBeginInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceGroupSubmitInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint waitSemaphoreCount;
			[FieldOffset(24)]public uint* pWaitSemaphoreDeviceIndices;
			[FieldOffset(32)]public uint commandBufferCount;
			[FieldOffset(40)]public uint* pCommandBufferDeviceMasks;
			[FieldOffset(48)]public uint signalSemaphoreCount;
			[FieldOffset(56)]public uint* pSignalSemaphoreDeviceIndices;
		}

        public static ManagedPtr<VkDeviceGroupSubmitInfo> Pointer(this VkDeviceGroupSubmitInfo i) => new ManagedPtr<VkDeviceGroupSubmitInfo>(i);
        public static ManagedPtr<VkDeviceGroupSubmitInfo[]> Pointer(this VkDeviceGroupSubmitInfo[] i) => new ManagedPtr<VkDeviceGroupSubmitInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceGroupBindSparseInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint resourceDeviceIndex;
			[FieldOffset(20)]public uint memoryDeviceIndex;
		}

        public static ManagedPtr<VkDeviceGroupBindSparseInfo> Pointer(this VkDeviceGroupBindSparseInfo i) => new ManagedPtr<VkDeviceGroupBindSparseInfo>(i);
        public static ManagedPtr<VkDeviceGroupBindSparseInfo[]> Pointer(this VkDeviceGroupBindSparseInfo[] i) => new ManagedPtr<VkDeviceGroupBindSparseInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBindBufferMemoryDeviceGroupInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint deviceIndexCount;
			[FieldOffset(24)]public uint* pDeviceIndices;
		}

        public static ManagedPtr<VkBindBufferMemoryDeviceGroupInfo> Pointer(this VkBindBufferMemoryDeviceGroupInfo i) => new ManagedPtr<VkBindBufferMemoryDeviceGroupInfo>(i);
        public static ManagedPtr<VkBindBufferMemoryDeviceGroupInfo[]> Pointer(this VkBindBufferMemoryDeviceGroupInfo[] i) => new ManagedPtr<VkBindBufferMemoryDeviceGroupInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBindImageMemoryDeviceGroupInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint deviceIndexCount;
			[FieldOffset(24)]public uint* pDeviceIndices;
			[FieldOffset(32)]public uint splitInstanceBindRegionCount;
			[FieldOffset(40)]public IntPtr pSplitInstanceBindRegions;
		}

        public static ManagedPtr<VkBindImageMemoryDeviceGroupInfo> Pointer(this VkBindImageMemoryDeviceGroupInfo i) => new ManagedPtr<VkBindImageMemoryDeviceGroupInfo>(i);
        public static ManagedPtr<VkBindImageMemoryDeviceGroupInfo[]> Pointer(this VkBindImageMemoryDeviceGroupInfo[] i) => new ManagedPtr<VkBindImageMemoryDeviceGroupInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceGroupProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint physicalDeviceCount;
			[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray, SizeConst=32)] public IntPtr[] physicalDevices;
			[FieldOffset(280)]public uint subsetAllocation;
		}

        public static ManagedPtr<VkPhysicalDeviceGroupProperties> Pointer(this VkPhysicalDeviceGroupProperties i) => new ManagedPtr<VkPhysicalDeviceGroupProperties>(i);
        public static ManagedPtr<VkPhysicalDeviceGroupProperties[]> Pointer(this VkPhysicalDeviceGroupProperties[] i) => new ManagedPtr<VkPhysicalDeviceGroupProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceGroupDeviceCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint physicalDeviceCount;
			[FieldOffset(24)]public IntPtr* pPhysicalDevices;
		}

        public static ManagedPtr<VkDeviceGroupDeviceCreateInfo> Pointer(this VkDeviceGroupDeviceCreateInfo i) => new ManagedPtr<VkDeviceGroupDeviceCreateInfo>(i);
        public static ManagedPtr<VkDeviceGroupDeviceCreateInfo[]> Pointer(this VkDeviceGroupDeviceCreateInfo[] i) => new ManagedPtr<VkDeviceGroupDeviceCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBufferMemoryRequirementsInfo2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr buffer;
		}

        public static ManagedPtr<VkBufferMemoryRequirementsInfo2> Pointer(this VkBufferMemoryRequirementsInfo2 i) => new ManagedPtr<VkBufferMemoryRequirementsInfo2>(i);
        public static ManagedPtr<VkBufferMemoryRequirementsInfo2[]> Pointer(this VkBufferMemoryRequirementsInfo2[] i) => new ManagedPtr<VkBufferMemoryRequirementsInfo2[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageMemoryRequirementsInfo2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr image;
		}

        public static ManagedPtr<VkImageMemoryRequirementsInfo2> Pointer(this VkImageMemoryRequirementsInfo2 i) => new ManagedPtr<VkImageMemoryRequirementsInfo2>(i);
        public static ManagedPtr<VkImageMemoryRequirementsInfo2[]> Pointer(this VkImageMemoryRequirementsInfo2[] i) => new ManagedPtr<VkImageMemoryRequirementsInfo2[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageSparseMemoryRequirementsInfo2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr image;
		}

        public static ManagedPtr<VkImageSparseMemoryRequirementsInfo2> Pointer(this VkImageSparseMemoryRequirementsInfo2 i) => new ManagedPtr<VkImageSparseMemoryRequirementsInfo2>(i);
        public static ManagedPtr<VkImageSparseMemoryRequirementsInfo2[]> Pointer(this VkImageSparseMemoryRequirementsInfo2[] i) => new ManagedPtr<VkImageSparseMemoryRequirementsInfo2[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryRequirements2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(20)]public VkMemoryRequirements memoryRequirements;
		}

        public static ManagedPtr<VkMemoryRequirements2> Pointer(this VkMemoryRequirements2 i) => new ManagedPtr<VkMemoryRequirements2>(i);
        public static ManagedPtr<VkMemoryRequirements2[]> Pointer(this VkMemoryRequirements2[] i) => new ManagedPtr<VkMemoryRequirements2[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSparseImageMemoryRequirements2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(56)]public VkSparseImageMemoryRequirements memoryRequirements;
		}

        public static ManagedPtr<VkSparseImageMemoryRequirements2> Pointer(this VkSparseImageMemoryRequirements2 i) => new ManagedPtr<VkSparseImageMemoryRequirements2>(i);
        public static ManagedPtr<VkSparseImageMemoryRequirements2[]> Pointer(this VkSparseImageMemoryRequirements2[] i) => new ManagedPtr<VkSparseImageMemoryRequirements2[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceFeatures2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(220)]public VkPhysicalDeviceFeatures features;
		}

        public static ManagedPtr<VkPhysicalDeviceFeatures2> Pointer(this VkPhysicalDeviceFeatures2 i) => new ManagedPtr<VkPhysicalDeviceFeatures2>(i);
        public static ManagedPtr<VkPhysicalDeviceFeatures2[]> Pointer(this VkPhysicalDeviceFeatures2[] i) => new ManagedPtr<VkPhysicalDeviceFeatures2[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceProperties2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(1040)]public VkPhysicalDeviceProperties properties;
		}

        public static ManagedPtr<VkPhysicalDeviceProperties2> Pointer(this VkPhysicalDeviceProperties2 i) => new ManagedPtr<VkPhysicalDeviceProperties2>(i);
        public static ManagedPtr<VkPhysicalDeviceProperties2[]> Pointer(this VkPhysicalDeviceProperties2[] i) => new ManagedPtr<VkPhysicalDeviceProperties2[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkFormatProperties2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(24)]public VkFormatProperties formatProperties;
		}

        public static ManagedPtr<VkFormatProperties2> Pointer(this VkFormatProperties2 i) => new ManagedPtr<VkFormatProperties2>(i);
        public static ManagedPtr<VkFormatProperties2[]> Pointer(this VkFormatProperties2[] i) => new ManagedPtr<VkFormatProperties2[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageFormatProperties2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(32)]public VkImageFormatProperties imageFormatProperties;
		}

        public static ManagedPtr<VkImageFormatProperties2> Pointer(this VkImageFormatProperties2 i) => new ManagedPtr<VkImageFormatProperties2>(i);
        public static ManagedPtr<VkImageFormatProperties2[]> Pointer(this VkImageFormatProperties2[] i) => new ManagedPtr<VkImageFormatProperties2[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceImageFormatInfo2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkFormat format;
			[FieldOffset(20)]public VkImageType type;
			[FieldOffset(24)]public VkImageTiling tiling;
			[FieldOffset(28)]public uint usage;
			[FieldOffset(32)]public uint flags;
		}

        public static ManagedPtr<VkPhysicalDeviceImageFormatInfo2> Pointer(this VkPhysicalDeviceImageFormatInfo2 i) => new ManagedPtr<VkPhysicalDeviceImageFormatInfo2>(i);
        public static ManagedPtr<VkPhysicalDeviceImageFormatInfo2[]> Pointer(this VkPhysicalDeviceImageFormatInfo2[] i) => new ManagedPtr<VkPhysicalDeviceImageFormatInfo2[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkQueueFamilyProperties2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(24)]public VkQueueFamilyProperties queueFamilyProperties;
		}

        public static ManagedPtr<VkQueueFamilyProperties2> Pointer(this VkQueueFamilyProperties2 i) => new ManagedPtr<VkQueueFamilyProperties2>(i);
        public static ManagedPtr<VkQueueFamilyProperties2[]> Pointer(this VkQueueFamilyProperties2[] i) => new ManagedPtr<VkQueueFamilyProperties2[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceMemoryProperties2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(468)]public VkPhysicalDeviceMemoryProperties memoryProperties;
		}

        public static ManagedPtr<VkPhysicalDeviceMemoryProperties2> Pointer(this VkPhysicalDeviceMemoryProperties2 i) => new ManagedPtr<VkPhysicalDeviceMemoryProperties2>(i);
        public static ManagedPtr<VkPhysicalDeviceMemoryProperties2[]> Pointer(this VkPhysicalDeviceMemoryProperties2[] i) => new ManagedPtr<VkPhysicalDeviceMemoryProperties2[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSparseImageFormatProperties2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(28)]public VkSparseImageFormatProperties properties;
		}

        public static ManagedPtr<VkSparseImageFormatProperties2> Pointer(this VkSparseImageFormatProperties2 i) => new ManagedPtr<VkSparseImageFormatProperties2>(i);
        public static ManagedPtr<VkSparseImageFormatProperties2[]> Pointer(this VkSparseImageFormatProperties2[] i) => new ManagedPtr<VkSparseImageFormatProperties2[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceSparseImageFormatInfo2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkFormat format;
			[FieldOffset(20)]public VkImageType type;
			[FieldOffset(24)]public VkSampleCountFlagBits samples;
			[FieldOffset(28)]public uint usage;
			[FieldOffset(32)]public VkImageTiling tiling;
		}

        public static ManagedPtr<VkPhysicalDeviceSparseImageFormatInfo2> Pointer(this VkPhysicalDeviceSparseImageFormatInfo2 i) => new ManagedPtr<VkPhysicalDeviceSparseImageFormatInfo2>(i);
        public static ManagedPtr<VkPhysicalDeviceSparseImageFormatInfo2[]> Pointer(this VkPhysicalDeviceSparseImageFormatInfo2[] i) => new ManagedPtr<VkPhysicalDeviceSparseImageFormatInfo2[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDevicePointClippingProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPointClippingBehavior pointClippingBehavior;
		}

        public static ManagedPtr<VkPhysicalDevicePointClippingProperties> Pointer(this VkPhysicalDevicePointClippingProperties i) => new ManagedPtr<VkPhysicalDevicePointClippingProperties>(i);
        public static ManagedPtr<VkPhysicalDevicePointClippingProperties[]> Pointer(this VkPhysicalDevicePointClippingProperties[] i) => new ManagedPtr<VkPhysicalDevicePointClippingProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkInputAttachmentAspectReference {
			[FieldOffset(0)]public uint subpass;
			[FieldOffset(4)]public uint inputAttachmentIndex;
			[FieldOffset(8)]public uint aspectMask;
		}

        public static ManagedPtr<VkInputAttachmentAspectReference> Pointer(this VkInputAttachmentAspectReference i) => new ManagedPtr<VkInputAttachmentAspectReference>(i);
        public static ManagedPtr<VkInputAttachmentAspectReference[]> Pointer(this VkInputAttachmentAspectReference[] i) => new ManagedPtr<VkInputAttachmentAspectReference[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRenderPassInputAttachmentAspectCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint aspectReferenceCount;
			[FieldOffset(24)]public IntPtr pAspectReferences;
		}

        public static ManagedPtr<VkRenderPassInputAttachmentAspectCreateInfo> Pointer(this VkRenderPassInputAttachmentAspectCreateInfo i) => new ManagedPtr<VkRenderPassInputAttachmentAspectCreateInfo>(i);
        public static ManagedPtr<VkRenderPassInputAttachmentAspectCreateInfo[]> Pointer(this VkRenderPassInputAttachmentAspectCreateInfo[] i) => new ManagedPtr<VkRenderPassInputAttachmentAspectCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageViewUsageCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint usage;
		}

        public static ManagedPtr<VkImageViewUsageCreateInfo> Pointer(this VkImageViewUsageCreateInfo i) => new ManagedPtr<VkImageViewUsageCreateInfo>(i);
        public static ManagedPtr<VkImageViewUsageCreateInfo[]> Pointer(this VkImageViewUsageCreateInfo[] i) => new ManagedPtr<VkImageViewUsageCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineTessellationDomainOriginStateCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkTessellationDomainOrigin domainOrigin;
		}

        public static ManagedPtr<VkPipelineTessellationDomainOriginStateCreateInfo> Pointer(this VkPipelineTessellationDomainOriginStateCreateInfo i) => new ManagedPtr<VkPipelineTessellationDomainOriginStateCreateInfo>(i);
        public static ManagedPtr<VkPipelineTessellationDomainOriginStateCreateInfo[]> Pointer(this VkPipelineTessellationDomainOriginStateCreateInfo[] i) => new ManagedPtr<VkPipelineTessellationDomainOriginStateCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRenderPassMultiviewCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint subpassCount;
			[FieldOffset(24)]public uint* pViewMasks;
			[FieldOffset(32)]public uint dependencyCount;
			[FieldOffset(40)]public int* pViewOffsets;
			[FieldOffset(48)]public uint correlationMaskCount;
			[FieldOffset(56)]public uint* pCorrelationMasks;
		}

        public static ManagedPtr<VkRenderPassMultiviewCreateInfo> Pointer(this VkRenderPassMultiviewCreateInfo i) => new ManagedPtr<VkRenderPassMultiviewCreateInfo>(i);
        public static ManagedPtr<VkRenderPassMultiviewCreateInfo[]> Pointer(this VkRenderPassMultiviewCreateInfo[] i) => new ManagedPtr<VkRenderPassMultiviewCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceMultiviewFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint multiview;
			[FieldOffset(20)]public uint multiviewGeometryShader;
			[FieldOffset(24)]public uint multiviewTessellationShader;
		}

        public static ManagedPtr<VkPhysicalDeviceMultiviewFeatures> Pointer(this VkPhysicalDeviceMultiviewFeatures i) => new ManagedPtr<VkPhysicalDeviceMultiviewFeatures>(i);
        public static ManagedPtr<VkPhysicalDeviceMultiviewFeatures[]> Pointer(this VkPhysicalDeviceMultiviewFeatures[] i) => new ManagedPtr<VkPhysicalDeviceMultiviewFeatures[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceMultiviewProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint maxMultiviewViewCount;
			[FieldOffset(20)]public uint maxMultiviewInstanceIndex;
		}

        public static ManagedPtr<VkPhysicalDeviceMultiviewProperties> Pointer(this VkPhysicalDeviceMultiviewProperties i) => new ManagedPtr<VkPhysicalDeviceMultiviewProperties>(i);
        public static ManagedPtr<VkPhysicalDeviceMultiviewProperties[]> Pointer(this VkPhysicalDeviceMultiviewProperties[] i) => new ManagedPtr<VkPhysicalDeviceMultiviewProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceVariablePointersFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint variablePointersStorageBuffer;
			[FieldOffset(20)]public uint variablePointers;
		}

        public static ManagedPtr<VkPhysicalDeviceVariablePointersFeatures> Pointer(this VkPhysicalDeviceVariablePointersFeatures i) => new ManagedPtr<VkPhysicalDeviceVariablePointersFeatures>(i);
        public static ManagedPtr<VkPhysicalDeviceVariablePointersFeatures[]> Pointer(this VkPhysicalDeviceVariablePointersFeatures[] i) => new ManagedPtr<VkPhysicalDeviceVariablePointersFeatures[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceProtectedMemoryFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint protectedMemory;
		}

        public static ManagedPtr<VkPhysicalDeviceProtectedMemoryFeatures> Pointer(this VkPhysicalDeviceProtectedMemoryFeatures i) => new ManagedPtr<VkPhysicalDeviceProtectedMemoryFeatures>(i);
        public static ManagedPtr<VkPhysicalDeviceProtectedMemoryFeatures[]> Pointer(this VkPhysicalDeviceProtectedMemoryFeatures[] i) => new ManagedPtr<VkPhysicalDeviceProtectedMemoryFeatures[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceProtectedMemoryProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint protectedNoFault;
		}

        public static ManagedPtr<VkPhysicalDeviceProtectedMemoryProperties> Pointer(this VkPhysicalDeviceProtectedMemoryProperties i) => new ManagedPtr<VkPhysicalDeviceProtectedMemoryProperties>(i);
        public static ManagedPtr<VkPhysicalDeviceProtectedMemoryProperties[]> Pointer(this VkPhysicalDeviceProtectedMemoryProperties[] i) => new ManagedPtr<VkPhysicalDeviceProtectedMemoryProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceQueueInfo2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint queueFamilyIndex;
			[FieldOffset(24)]public uint queueIndex;
		}

        public static ManagedPtr<VkDeviceQueueInfo2> Pointer(this VkDeviceQueueInfo2 i) => new ManagedPtr<VkDeviceQueueInfo2>(i);
        public static ManagedPtr<VkDeviceQueueInfo2[]> Pointer(this VkDeviceQueueInfo2[] i) => new ManagedPtr<VkDeviceQueueInfo2[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkProtectedSubmitInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint protectedSubmit;
		}

        public static ManagedPtr<VkProtectedSubmitInfo> Pointer(this VkProtectedSubmitInfo i) => new ManagedPtr<VkProtectedSubmitInfo>(i);
        public static ManagedPtr<VkProtectedSubmitInfo[]> Pointer(this VkProtectedSubmitInfo[] i) => new ManagedPtr<VkProtectedSubmitInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSamplerYcbcrConversionCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkFormat format;
			[FieldOffset(20)]public VkSamplerYcbcrModelConversion ycbcrModel;
			[FieldOffset(24)]public VkSamplerYcbcrRange ycbcrRange;
			[FieldOffset(32)]public VkComponentMapping components;
			[FieldOffset(48)]public VkChromaLocation xChromaOffset;
			[FieldOffset(52)]public VkChromaLocation yChromaOffset;
			[FieldOffset(56)]public VkFilter chromaFilter;
			[FieldOffset(60)]public uint forceExplicitReconstruction;
		}

        public static ManagedPtr<VkSamplerYcbcrConversionCreateInfo> Pointer(this VkSamplerYcbcrConversionCreateInfo i) => new ManagedPtr<VkSamplerYcbcrConversionCreateInfo>(i);
        public static ManagedPtr<VkSamplerYcbcrConversionCreateInfo[]> Pointer(this VkSamplerYcbcrConversionCreateInfo[] i) => new ManagedPtr<VkSamplerYcbcrConversionCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSamplerYcbcrConversionInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr conversion;
		}

        public static ManagedPtr<VkSamplerYcbcrConversionInfo> Pointer(this VkSamplerYcbcrConversionInfo i) => new ManagedPtr<VkSamplerYcbcrConversionInfo>(i);
        public static ManagedPtr<VkSamplerYcbcrConversionInfo[]> Pointer(this VkSamplerYcbcrConversionInfo[] i) => new ManagedPtr<VkSamplerYcbcrConversionInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBindImagePlaneMemoryInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkImageAspectFlagBits planeAspect;
		}

        public static ManagedPtr<VkBindImagePlaneMemoryInfo> Pointer(this VkBindImagePlaneMemoryInfo i) => new ManagedPtr<VkBindImagePlaneMemoryInfo>(i);
        public static ManagedPtr<VkBindImagePlaneMemoryInfo[]> Pointer(this VkBindImagePlaneMemoryInfo[] i) => new ManagedPtr<VkBindImagePlaneMemoryInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImagePlaneMemoryRequirementsInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkImageAspectFlagBits planeAspect;
		}

        public static ManagedPtr<VkImagePlaneMemoryRequirementsInfo> Pointer(this VkImagePlaneMemoryRequirementsInfo i) => new ManagedPtr<VkImagePlaneMemoryRequirementsInfo>(i);
        public static ManagedPtr<VkImagePlaneMemoryRequirementsInfo[]> Pointer(this VkImagePlaneMemoryRequirementsInfo[] i) => new ManagedPtr<VkImagePlaneMemoryRequirementsInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceSamplerYcbcrConversionFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint samplerYcbcrConversion;
		}

        public static ManagedPtr<VkPhysicalDeviceSamplerYcbcrConversionFeatures> Pointer(this VkPhysicalDeviceSamplerYcbcrConversionFeatures i) => new ManagedPtr<VkPhysicalDeviceSamplerYcbcrConversionFeatures>(i);
        public static ManagedPtr<VkPhysicalDeviceSamplerYcbcrConversionFeatures[]> Pointer(this VkPhysicalDeviceSamplerYcbcrConversionFeatures[] i) => new ManagedPtr<VkPhysicalDeviceSamplerYcbcrConversionFeatures[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSamplerYcbcrConversionImageFormatProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint combinedImageSamplerDescriptorCount;
		}

        public static ManagedPtr<VkSamplerYcbcrConversionImageFormatProperties> Pointer(this VkSamplerYcbcrConversionImageFormatProperties i) => new ManagedPtr<VkSamplerYcbcrConversionImageFormatProperties>(i);
        public static ManagedPtr<VkSamplerYcbcrConversionImageFormatProperties[]> Pointer(this VkSamplerYcbcrConversionImageFormatProperties[] i) => new ManagedPtr<VkSamplerYcbcrConversionImageFormatProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorUpdateTemplateEntry {
			[FieldOffset(0)]public uint dstBinding;
			[FieldOffset(4)]public uint dstArrayElement;
			[FieldOffset(8)]public uint descriptorCount;
			[FieldOffset(12)]public VkDescriptorType descriptorType;
			[FieldOffset(16)]public ulong offset;
			[FieldOffset(24)]public ulong stride;
		}

        public static ManagedPtr<VkDescriptorUpdateTemplateEntry> Pointer(this VkDescriptorUpdateTemplateEntry i) => new ManagedPtr<VkDescriptorUpdateTemplateEntry>(i);
        public static ManagedPtr<VkDescriptorUpdateTemplateEntry[]> Pointer(this VkDescriptorUpdateTemplateEntry[] i) => new ManagedPtr<VkDescriptorUpdateTemplateEntry[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorUpdateTemplateCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint descriptorUpdateEntryCount;
			[FieldOffset(24)]public IntPtr pDescriptorUpdateEntries;
			[FieldOffset(32)]public VkDescriptorUpdateTemplateType templateType;
			[FieldOffset(40)]public IntPtr descriptorSetLayout;
			[FieldOffset(48)]public VkPipelineBindPoint pipelineBindPoint;
			[FieldOffset(56)]public IntPtr pipelineLayout;
			[FieldOffset(64)]public uint set;
		}

        public static ManagedPtr<VkDescriptorUpdateTemplateCreateInfo> Pointer(this VkDescriptorUpdateTemplateCreateInfo i) => new ManagedPtr<VkDescriptorUpdateTemplateCreateInfo>(i);
        public static ManagedPtr<VkDescriptorUpdateTemplateCreateInfo[]> Pointer(this VkDescriptorUpdateTemplateCreateInfo[] i) => new ManagedPtr<VkDescriptorUpdateTemplateCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExternalMemoryProperties {
			[FieldOffset(0)]public uint externalMemoryFeatures;
			[FieldOffset(4)]public uint exportFromImportedHandleTypes;
			[FieldOffset(8)]public uint compatibleHandleTypes;
		}

        public static ManagedPtr<VkExternalMemoryProperties> Pointer(this VkExternalMemoryProperties i) => new ManagedPtr<VkExternalMemoryProperties>(i);
        public static ManagedPtr<VkExternalMemoryProperties[]> Pointer(this VkExternalMemoryProperties[] i) => new ManagedPtr<VkExternalMemoryProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceExternalImageFormatInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalMemoryHandleTypeFlagBits handleType;
		}

        public static ManagedPtr<VkPhysicalDeviceExternalImageFormatInfo> Pointer(this VkPhysicalDeviceExternalImageFormatInfo i) => new ManagedPtr<VkPhysicalDeviceExternalImageFormatInfo>(i);
        public static ManagedPtr<VkPhysicalDeviceExternalImageFormatInfo[]> Pointer(this VkPhysicalDeviceExternalImageFormatInfo[] i) => new ManagedPtr<VkPhysicalDeviceExternalImageFormatInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExternalImageFormatProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(24)]public VkExternalMemoryProperties externalMemoryProperties;
		}

        public static ManagedPtr<VkExternalImageFormatProperties> Pointer(this VkExternalImageFormatProperties i) => new ManagedPtr<VkExternalImageFormatProperties>(i);
        public static ManagedPtr<VkExternalImageFormatProperties[]> Pointer(this VkExternalImageFormatProperties[] i) => new ManagedPtr<VkExternalImageFormatProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceExternalBufferInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint usage;
			[FieldOffset(24)]public VkExternalMemoryHandleTypeFlagBits handleType;
		}

        public static ManagedPtr<VkPhysicalDeviceExternalBufferInfo> Pointer(this VkPhysicalDeviceExternalBufferInfo i) => new ManagedPtr<VkPhysicalDeviceExternalBufferInfo>(i);
        public static ManagedPtr<VkPhysicalDeviceExternalBufferInfo[]> Pointer(this VkPhysicalDeviceExternalBufferInfo[] i) => new ManagedPtr<VkPhysicalDeviceExternalBufferInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExternalBufferProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(24)]public VkExternalMemoryProperties externalMemoryProperties;
		}

        public static ManagedPtr<VkExternalBufferProperties> Pointer(this VkExternalBufferProperties i) => new ManagedPtr<VkExternalBufferProperties>(i);
        public static ManagedPtr<VkExternalBufferProperties[]> Pointer(this VkExternalBufferProperties[] i) => new ManagedPtr<VkExternalBufferProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceIDProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public fixed byte deviceUUID[16];
			[FieldOffset(32)]public fixed byte driverUUID[16];
			[FieldOffset(48)]public fixed byte deviceLUID[8];
			[FieldOffset(56)]public uint deviceNodeMask;
			[FieldOffset(60)]public uint deviceLUIDValid;
		}

        public static ManagedPtr<VkPhysicalDeviceIDProperties> Pointer(this VkPhysicalDeviceIDProperties i) => new ManagedPtr<VkPhysicalDeviceIDProperties>(i);
        public static ManagedPtr<VkPhysicalDeviceIDProperties[]> Pointer(this VkPhysicalDeviceIDProperties[] i) => new ManagedPtr<VkPhysicalDeviceIDProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExternalMemoryImageCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint handleTypes;
		}

        public static ManagedPtr<VkExternalMemoryImageCreateInfo> Pointer(this VkExternalMemoryImageCreateInfo i) => new ManagedPtr<VkExternalMemoryImageCreateInfo>(i);
        public static ManagedPtr<VkExternalMemoryImageCreateInfo[]> Pointer(this VkExternalMemoryImageCreateInfo[] i) => new ManagedPtr<VkExternalMemoryImageCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExternalMemoryBufferCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint handleTypes;
		}

        public static ManagedPtr<VkExternalMemoryBufferCreateInfo> Pointer(this VkExternalMemoryBufferCreateInfo i) => new ManagedPtr<VkExternalMemoryBufferCreateInfo>(i);
        public static ManagedPtr<VkExternalMemoryBufferCreateInfo[]> Pointer(this VkExternalMemoryBufferCreateInfo[] i) => new ManagedPtr<VkExternalMemoryBufferCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExportMemoryAllocateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint handleTypes;
		}

        public static ManagedPtr<VkExportMemoryAllocateInfo> Pointer(this VkExportMemoryAllocateInfo i) => new ManagedPtr<VkExportMemoryAllocateInfo>(i);
        public static ManagedPtr<VkExportMemoryAllocateInfo[]> Pointer(this VkExportMemoryAllocateInfo[] i) => new ManagedPtr<VkExportMemoryAllocateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceExternalFenceInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalFenceHandleTypeFlagBits handleType;
		}

        public static ManagedPtr<VkPhysicalDeviceExternalFenceInfo> Pointer(this VkPhysicalDeviceExternalFenceInfo i) => new ManagedPtr<VkPhysicalDeviceExternalFenceInfo>(i);
        public static ManagedPtr<VkPhysicalDeviceExternalFenceInfo[]> Pointer(this VkPhysicalDeviceExternalFenceInfo[] i) => new ManagedPtr<VkPhysicalDeviceExternalFenceInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExternalFenceProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint exportFromImportedHandleTypes;
			[FieldOffset(20)]public uint compatibleHandleTypes;
			[FieldOffset(24)]public uint externalFenceFeatures;
		}

        public static ManagedPtr<VkExternalFenceProperties> Pointer(this VkExternalFenceProperties i) => new ManagedPtr<VkExternalFenceProperties>(i);
        public static ManagedPtr<VkExternalFenceProperties[]> Pointer(this VkExternalFenceProperties[] i) => new ManagedPtr<VkExternalFenceProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExportFenceCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint handleTypes;
		}

        public static ManagedPtr<VkExportFenceCreateInfo> Pointer(this VkExportFenceCreateInfo i) => new ManagedPtr<VkExportFenceCreateInfo>(i);
        public static ManagedPtr<VkExportFenceCreateInfo[]> Pointer(this VkExportFenceCreateInfo[] i) => new ManagedPtr<VkExportFenceCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExportSemaphoreCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint handleTypes;
		}

        public static ManagedPtr<VkExportSemaphoreCreateInfo> Pointer(this VkExportSemaphoreCreateInfo i) => new ManagedPtr<VkExportSemaphoreCreateInfo>(i);
        public static ManagedPtr<VkExportSemaphoreCreateInfo[]> Pointer(this VkExportSemaphoreCreateInfo[] i) => new ManagedPtr<VkExportSemaphoreCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceExternalSemaphoreInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalSemaphoreHandleTypeFlagBits handleType;
		}

        public static ManagedPtr<VkPhysicalDeviceExternalSemaphoreInfo> Pointer(this VkPhysicalDeviceExternalSemaphoreInfo i) => new ManagedPtr<VkPhysicalDeviceExternalSemaphoreInfo>(i);
        public static ManagedPtr<VkPhysicalDeviceExternalSemaphoreInfo[]> Pointer(this VkPhysicalDeviceExternalSemaphoreInfo[] i) => new ManagedPtr<VkPhysicalDeviceExternalSemaphoreInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExternalSemaphoreProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint exportFromImportedHandleTypes;
			[FieldOffset(20)]public uint compatibleHandleTypes;
			[FieldOffset(24)]public uint externalSemaphoreFeatures;
		}

        public static ManagedPtr<VkExternalSemaphoreProperties> Pointer(this VkExternalSemaphoreProperties i) => new ManagedPtr<VkExternalSemaphoreProperties>(i);
        public static ManagedPtr<VkExternalSemaphoreProperties[]> Pointer(this VkExternalSemaphoreProperties[] i) => new ManagedPtr<VkExternalSemaphoreProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceMaintenance3Properties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint maxPerSetDescriptors;
			[FieldOffset(24)]public ulong maxMemoryAllocationSize;
		}

        public static ManagedPtr<VkPhysicalDeviceMaintenance3Properties> Pointer(this VkPhysicalDeviceMaintenance3Properties i) => new ManagedPtr<VkPhysicalDeviceMaintenance3Properties>(i);
        public static ManagedPtr<VkPhysicalDeviceMaintenance3Properties[]> Pointer(this VkPhysicalDeviceMaintenance3Properties[] i) => new ManagedPtr<VkPhysicalDeviceMaintenance3Properties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorSetLayoutSupport {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint supported;
		}

        public static ManagedPtr<VkDescriptorSetLayoutSupport> Pointer(this VkDescriptorSetLayoutSupport i) => new ManagedPtr<VkDescriptorSetLayoutSupport>(i);
        public static ManagedPtr<VkDescriptorSetLayoutSupport[]> Pointer(this VkDescriptorSetLayoutSupport[] i) => new ManagedPtr<VkDescriptorSetLayoutSupport[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShaderDrawParametersFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint shaderDrawParameters;
		}

        public static ManagedPtr<VkPhysicalDeviceShaderDrawParametersFeatures> Pointer(this VkPhysicalDeviceShaderDrawParametersFeatures i) => new ManagedPtr<VkPhysicalDeviceShaderDrawParametersFeatures>(i);
        public static ManagedPtr<VkPhysicalDeviceShaderDrawParametersFeatures[]> Pointer(this VkPhysicalDeviceShaderDrawParametersFeatures[] i) => new ManagedPtr<VkPhysicalDeviceShaderDrawParametersFeatures[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceVulkan11Features {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint storageBuffer16BitAccess;
			[FieldOffset(20)]public uint uniformAndStorageBuffer16BitAccess;
			[FieldOffset(24)]public uint storagePushConstant16;
			[FieldOffset(28)]public uint storageInputOutput16;
			[FieldOffset(32)]public uint multiview;
			[FieldOffset(36)]public uint multiviewGeometryShader;
			[FieldOffset(40)]public uint multiviewTessellationShader;
			[FieldOffset(44)]public uint variablePointersStorageBuffer;
			[FieldOffset(48)]public uint variablePointers;
			[FieldOffset(52)]public uint protectedMemory;
			[FieldOffset(56)]public uint samplerYcbcrConversion;
			[FieldOffset(60)]public uint shaderDrawParameters;
		}

        public static ManagedPtr<VkPhysicalDeviceVulkan11Features> Pointer(this VkPhysicalDeviceVulkan11Features i) => new ManagedPtr<VkPhysicalDeviceVulkan11Features>(i);
        public static ManagedPtr<VkPhysicalDeviceVulkan11Features[]> Pointer(this VkPhysicalDeviceVulkan11Features[] i) => new ManagedPtr<VkPhysicalDeviceVulkan11Features[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceVulkan11Properties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public fixed byte deviceUUID[16];
			[FieldOffset(32)]public fixed byte driverUUID[16];
			[FieldOffset(48)]public fixed byte deviceLUID[8];
			[FieldOffset(56)]public uint deviceNodeMask;
			[FieldOffset(60)]public uint deviceLUIDValid;
			[FieldOffset(64)]public uint subgroupSize;
			[FieldOffset(68)]public uint subgroupSupportedStages;
			[FieldOffset(72)]public uint subgroupSupportedOperations;
			[FieldOffset(76)]public uint subgroupQuadOperationsInAllStages;
			[FieldOffset(80)]public VkPointClippingBehavior pointClippingBehavior;
			[FieldOffset(84)]public uint maxMultiviewViewCount;
			[FieldOffset(88)]public uint maxMultiviewInstanceIndex;
			[FieldOffset(92)]public uint protectedNoFault;
			[FieldOffset(96)]public uint maxPerSetDescriptors;
			[FieldOffset(104)]public ulong maxMemoryAllocationSize;
		}

        public static ManagedPtr<VkPhysicalDeviceVulkan11Properties> Pointer(this VkPhysicalDeviceVulkan11Properties i) => new ManagedPtr<VkPhysicalDeviceVulkan11Properties>(i);
        public static ManagedPtr<VkPhysicalDeviceVulkan11Properties[]> Pointer(this VkPhysicalDeviceVulkan11Properties[] i) => new ManagedPtr<VkPhysicalDeviceVulkan11Properties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceVulkan12Features {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint samplerMirrorClampToEdge;
			[FieldOffset(20)]public uint drawIndirectCount;
			[FieldOffset(24)]public uint storageBuffer8BitAccess;
			[FieldOffset(28)]public uint uniformAndStorageBuffer8BitAccess;
			[FieldOffset(32)]public uint storagePushConstant8;
			[FieldOffset(36)]public uint shaderBufferInt64Atomics;
			[FieldOffset(40)]public uint shaderSharedInt64Atomics;
			[FieldOffset(44)]public uint shaderFloat16;
			[FieldOffset(48)]public uint shaderInt8;
			[FieldOffset(52)]public uint descriptorIndexing;
			[FieldOffset(56)]public uint shaderInputAttachmentArrayDynamicIndexing;
			[FieldOffset(60)]public uint shaderUniformTexelBufferArrayDynamicIndexing;
			[FieldOffset(64)]public uint shaderStorageTexelBufferArrayDynamicIndexing;
			[FieldOffset(68)]public uint shaderUniformBufferArrayNonUniformIndexing;
			[FieldOffset(72)]public uint shaderSampledImageArrayNonUniformIndexing;
			[FieldOffset(76)]public uint shaderStorageBufferArrayNonUniformIndexing;
			[FieldOffset(80)]public uint shaderStorageImageArrayNonUniformIndexing;
			[FieldOffset(84)]public uint shaderInputAttachmentArrayNonUniformIndexing;
			[FieldOffset(88)]public uint shaderUniformTexelBufferArrayNonUniformIndexing;
			[FieldOffset(92)]public uint shaderStorageTexelBufferArrayNonUniformIndexing;
			[FieldOffset(96)]public uint descriptorBindingUniformBufferUpdateAfterBind;
			[FieldOffset(100)]public uint descriptorBindingSampledImageUpdateAfterBind;
			[FieldOffset(104)]public uint descriptorBindingStorageImageUpdateAfterBind;
			[FieldOffset(108)]public uint descriptorBindingStorageBufferUpdateAfterBind;
			[FieldOffset(112)]public uint descriptorBindingUniformTexelBufferUpdateAfterBind;
			[FieldOffset(116)]public uint descriptorBindingStorageTexelBufferUpdateAfterBind;
			[FieldOffset(120)]public uint descriptorBindingUpdateUnusedWhilePending;
			[FieldOffset(124)]public uint descriptorBindingPartiallyBound;
			[FieldOffset(128)]public uint descriptorBindingVariableDescriptorCount;
			[FieldOffset(132)]public uint runtimeDescriptorArray;
			[FieldOffset(136)]public uint samplerFilterMinmax;
			[FieldOffset(140)]public uint scalarBlockLayout;
			[FieldOffset(144)]public uint imagelessFramebuffer;
			[FieldOffset(148)]public uint uniformBufferStandardLayout;
			[FieldOffset(152)]public uint shaderSubgroupExtendedTypes;
			[FieldOffset(156)]public uint separateDepthStencilLayouts;
			[FieldOffset(160)]public uint hostQueryReset;
			[FieldOffset(164)]public uint timelineSemaphore;
			[FieldOffset(168)]public uint bufferDeviceAddress;
			[FieldOffset(172)]public uint bufferDeviceAddressCaptureReplay;
			[FieldOffset(176)]public uint bufferDeviceAddressMultiDevice;
			[FieldOffset(180)]public uint vulkanMemoryModel;
			[FieldOffset(184)]public uint vulkanMemoryModelDeviceScope;
			[FieldOffset(188)]public uint vulkanMemoryModelAvailabilityVisibilityChains;
			[FieldOffset(192)]public uint shaderOutputViewportIndex;
			[FieldOffset(196)]public uint shaderOutputLayer;
			[FieldOffset(200)]public uint subgroupBroadcastDynamicId;
		}

        public static ManagedPtr<VkPhysicalDeviceVulkan12Features> Pointer(this VkPhysicalDeviceVulkan12Features i) => new ManagedPtr<VkPhysicalDeviceVulkan12Features>(i);
        public static ManagedPtr<VkPhysicalDeviceVulkan12Features[]> Pointer(this VkPhysicalDeviceVulkan12Features[] i) => new ManagedPtr<VkPhysicalDeviceVulkan12Features[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkConformanceVersion {
			[FieldOffset(0)]public byte major;
			[FieldOffset(1)]public byte minor;
			[FieldOffset(2)]public byte subminor;
			[FieldOffset(3)]public byte patch;
		}

        public static ManagedPtr<VkConformanceVersion> Pointer(this VkConformanceVersion i) => new ManagedPtr<VkConformanceVersion>(i);
        public static ManagedPtr<VkConformanceVersion[]> Pointer(this VkConformanceVersion[] i) => new ManagedPtr<VkConformanceVersion[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceVulkan12Properties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDriverId driverID;
			[FieldOffset(20)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] driverName;
			[FieldOffset(276)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] driverInfo;
			[FieldOffset(532)]public VkConformanceVersion conformanceVersion;
			[FieldOffset(536)]public VkShaderFloatControlsIndependence denormBehaviorIndependence;
			[FieldOffset(540)]public VkShaderFloatControlsIndependence roundingModeIndependence;
			[FieldOffset(544)]public uint shaderSignedZeroInfNanPreserveFloat16;
			[FieldOffset(548)]public uint shaderSignedZeroInfNanPreserveFloat32;
			[FieldOffset(552)]public uint shaderSignedZeroInfNanPreserveFloat64;
			[FieldOffset(556)]public uint shaderDenormPreserveFloat16;
			[FieldOffset(560)]public uint shaderDenormPreserveFloat32;
			[FieldOffset(564)]public uint shaderDenormPreserveFloat64;
			[FieldOffset(568)]public uint shaderDenormFlushToZeroFloat16;
			[FieldOffset(572)]public uint shaderDenormFlushToZeroFloat32;
			[FieldOffset(576)]public uint shaderDenormFlushToZeroFloat64;
			[FieldOffset(580)]public uint shaderRoundingModeRTEFloat16;
			[FieldOffset(584)]public uint shaderRoundingModeRTEFloat32;
			[FieldOffset(588)]public uint shaderRoundingModeRTEFloat64;
			[FieldOffset(592)]public uint shaderRoundingModeRTZFloat16;
			[FieldOffset(596)]public uint shaderRoundingModeRTZFloat32;
			[FieldOffset(600)]public uint shaderRoundingModeRTZFloat64;
			[FieldOffset(604)]public uint maxUpdateAfterBindDescriptorsInAllPools;
			[FieldOffset(608)]public uint shaderUniformBufferArrayNonUniformIndexingNative;
			[FieldOffset(612)]public uint shaderSampledImageArrayNonUniformIndexingNative;
			[FieldOffset(616)]public uint shaderStorageBufferArrayNonUniformIndexingNative;
			[FieldOffset(620)]public uint shaderStorageImageArrayNonUniformIndexingNative;
			[FieldOffset(624)]public uint shaderInputAttachmentArrayNonUniformIndexingNative;
			[FieldOffset(628)]public uint robustBufferAccessUpdateAfterBind;
			[FieldOffset(632)]public uint quadDivergentImplicitLod;
			[FieldOffset(636)]public uint maxPerStageDescriptorUpdateAfterBindSamplers;
			[FieldOffset(640)]public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
			[FieldOffset(644)]public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
			[FieldOffset(648)]public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
			[FieldOffset(652)]public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
			[FieldOffset(656)]public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
			[FieldOffset(660)]public uint maxPerStageUpdateAfterBindResources;
			[FieldOffset(664)]public uint maxDescriptorSetUpdateAfterBindSamplers;
			[FieldOffset(668)]public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
			[FieldOffset(672)]public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
			[FieldOffset(676)]public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
			[FieldOffset(680)]public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
			[FieldOffset(684)]public uint maxDescriptorSetUpdateAfterBindSampledImages;
			[FieldOffset(688)]public uint maxDescriptorSetUpdateAfterBindStorageImages;
			[FieldOffset(692)]public uint maxDescriptorSetUpdateAfterBindInputAttachments;
			[FieldOffset(696)]public uint supportedDepthResolveModes;
			[FieldOffset(700)]public uint supportedStencilResolveModes;
			[FieldOffset(704)]public uint independentResolveNone;
			[FieldOffset(708)]public uint independentResolve;
			[FieldOffset(712)]public uint filterMinmaxSingleComponentFormats;
			[FieldOffset(716)]public uint filterMinmaxImageComponentMapping;
			[FieldOffset(720)]public ulong maxTimelineSemaphoreValueDifference;
			[FieldOffset(728)]public uint framebufferIntegerColorSampleCounts;
		}

        public static ManagedPtr<VkPhysicalDeviceVulkan12Properties> Pointer(this VkPhysicalDeviceVulkan12Properties i) => new ManagedPtr<VkPhysicalDeviceVulkan12Properties>(i);
        public static ManagedPtr<VkPhysicalDeviceVulkan12Properties[]> Pointer(this VkPhysicalDeviceVulkan12Properties[] i) => new ManagedPtr<VkPhysicalDeviceVulkan12Properties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageFormatListCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint viewFormatCount;
			[FieldOffset(24)]public VkFormat* pViewFormats;
		}

        public static ManagedPtr<VkImageFormatListCreateInfo> Pointer(this VkImageFormatListCreateInfo i) => new ManagedPtr<VkImageFormatListCreateInfo>(i);
        public static ManagedPtr<VkImageFormatListCreateInfo[]> Pointer(this VkImageFormatListCreateInfo[] i) => new ManagedPtr<VkImageFormatListCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAttachmentDescription2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public VkFormat format;
			[FieldOffset(24)]public VkSampleCountFlagBits samples;
			[FieldOffset(28)]public VkAttachmentLoadOp loadOp;
			[FieldOffset(32)]public VkAttachmentStoreOp storeOp;
			[FieldOffset(36)]public VkAttachmentLoadOp stencilLoadOp;
			[FieldOffset(40)]public VkAttachmentStoreOp stencilStoreOp;
			[FieldOffset(44)]public VkImageLayout initialLayout;
			[FieldOffset(48)]public VkImageLayout finalLayout;
		}

        public static ManagedPtr<VkAttachmentDescription2> Pointer(this VkAttachmentDescription2 i) => new ManagedPtr<VkAttachmentDescription2>(i);
        public static ManagedPtr<VkAttachmentDescription2[]> Pointer(this VkAttachmentDescription2[] i) => new ManagedPtr<VkAttachmentDescription2[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAttachmentReference2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint attachment;
			[FieldOffset(20)]public VkImageLayout layout;
			[FieldOffset(24)]public uint aspectMask;
		}

        public static ManagedPtr<VkAttachmentReference2> Pointer(this VkAttachmentReference2 i) => new ManagedPtr<VkAttachmentReference2>(i);
        public static ManagedPtr<VkAttachmentReference2[]> Pointer(this VkAttachmentReference2[] i) => new ManagedPtr<VkAttachmentReference2[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSubpassDescription2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public VkPipelineBindPoint pipelineBindPoint;
			[FieldOffset(24)]public uint viewMask;
			[FieldOffset(28)]public uint inputAttachmentCount;
			[FieldOffset(32)]public IntPtr pInputAttachments;
			[FieldOffset(40)]public uint colorAttachmentCount;
			[FieldOffset(48)]public IntPtr pColorAttachments;
			[FieldOffset(56)]public IntPtr pResolveAttachments;
			[FieldOffset(64)]public IntPtr pDepthStencilAttachment;
			[FieldOffset(72)]public uint preserveAttachmentCount;
			[FieldOffset(80)]public uint* pPreserveAttachments;
		}

        public static ManagedPtr<VkSubpassDescription2> Pointer(this VkSubpassDescription2 i) => new ManagedPtr<VkSubpassDescription2>(i);
        public static ManagedPtr<VkSubpassDescription2[]> Pointer(this VkSubpassDescription2[] i) => new ManagedPtr<VkSubpassDescription2[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSubpassDependency2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint srcSubpass;
			[FieldOffset(20)]public uint dstSubpass;
			[FieldOffset(24)]public uint srcStageMask;
			[FieldOffset(28)]public uint dstStageMask;
			[FieldOffset(32)]public uint srcAccessMask;
			[FieldOffset(36)]public uint dstAccessMask;
			[FieldOffset(40)]public uint dependencyFlags;
			[FieldOffset(44)]public int viewOffset;
		}

        public static ManagedPtr<VkSubpassDependency2> Pointer(this VkSubpassDependency2 i) => new ManagedPtr<VkSubpassDependency2>(i);
        public static ManagedPtr<VkSubpassDependency2[]> Pointer(this VkSubpassDependency2[] i) => new ManagedPtr<VkSubpassDependency2[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRenderPassCreateInfo2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint attachmentCount;
			[FieldOffset(24)]public IntPtr pAttachments;
			[FieldOffset(32)]public uint subpassCount;
			[FieldOffset(40)]public IntPtr pSubpasses;
			[FieldOffset(48)]public uint dependencyCount;
			[FieldOffset(56)]public IntPtr pDependencies;
			[FieldOffset(64)]public uint correlatedViewMaskCount;
			[FieldOffset(72)]public uint* pCorrelatedViewMasks;
		}

        public static ManagedPtr<VkRenderPassCreateInfo2> Pointer(this VkRenderPassCreateInfo2 i) => new ManagedPtr<VkRenderPassCreateInfo2>(i);
        public static ManagedPtr<VkRenderPassCreateInfo2[]> Pointer(this VkRenderPassCreateInfo2[] i) => new ManagedPtr<VkRenderPassCreateInfo2[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSubpassBeginInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkSubpassContents contents;
		}

        public static ManagedPtr<VkSubpassBeginInfo> Pointer(this VkSubpassBeginInfo i) => new ManagedPtr<VkSubpassBeginInfo>(i);
        public static ManagedPtr<VkSubpassBeginInfo[]> Pointer(this VkSubpassBeginInfo[] i) => new ManagedPtr<VkSubpassBeginInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSubpassEndInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
		}

        public static ManagedPtr<VkSubpassEndInfo> Pointer(this VkSubpassEndInfo i) => new ManagedPtr<VkSubpassEndInfo>(i);
        public static ManagedPtr<VkSubpassEndInfo[]> Pointer(this VkSubpassEndInfo[] i) => new ManagedPtr<VkSubpassEndInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDevice8BitStorageFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint storageBuffer8BitAccess;
			[FieldOffset(20)]public uint uniformAndStorageBuffer8BitAccess;
			[FieldOffset(24)]public uint storagePushConstant8;
		}

        public static ManagedPtr<VkPhysicalDevice8BitStorageFeatures> Pointer(this VkPhysicalDevice8BitStorageFeatures i) => new ManagedPtr<VkPhysicalDevice8BitStorageFeatures>(i);
        public static ManagedPtr<VkPhysicalDevice8BitStorageFeatures[]> Pointer(this VkPhysicalDevice8BitStorageFeatures[] i) => new ManagedPtr<VkPhysicalDevice8BitStorageFeatures[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceDriverProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDriverId driverID;
			[FieldOffset(20)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] driverName;
			[FieldOffset(276)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] driverInfo;
			[FieldOffset(532)]public VkConformanceVersion conformanceVersion;
		}

        public static ManagedPtr<VkPhysicalDeviceDriverProperties> Pointer(this VkPhysicalDeviceDriverProperties i) => new ManagedPtr<VkPhysicalDeviceDriverProperties>(i);
        public static ManagedPtr<VkPhysicalDeviceDriverProperties[]> Pointer(this VkPhysicalDeviceDriverProperties[] i) => new ManagedPtr<VkPhysicalDeviceDriverProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShaderAtomicInt64Features {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint shaderBufferInt64Atomics;
			[FieldOffset(20)]public uint shaderSharedInt64Atomics;
		}

        public static ManagedPtr<VkPhysicalDeviceShaderAtomicInt64Features> Pointer(this VkPhysicalDeviceShaderAtomicInt64Features i) => new ManagedPtr<VkPhysicalDeviceShaderAtomicInt64Features>(i);
        public static ManagedPtr<VkPhysicalDeviceShaderAtomicInt64Features[]> Pointer(this VkPhysicalDeviceShaderAtomicInt64Features[] i) => new ManagedPtr<VkPhysicalDeviceShaderAtomicInt64Features[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShaderFloat16Int8Features {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint shaderFloat16;
			[FieldOffset(20)]public uint shaderInt8;
		}

        public static ManagedPtr<VkPhysicalDeviceShaderFloat16Int8Features> Pointer(this VkPhysicalDeviceShaderFloat16Int8Features i) => new ManagedPtr<VkPhysicalDeviceShaderFloat16Int8Features>(i);
        public static ManagedPtr<VkPhysicalDeviceShaderFloat16Int8Features[]> Pointer(this VkPhysicalDeviceShaderFloat16Int8Features[] i) => new ManagedPtr<VkPhysicalDeviceShaderFloat16Int8Features[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceFloatControlsProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkShaderFloatControlsIndependence denormBehaviorIndependence;
			[FieldOffset(20)]public VkShaderFloatControlsIndependence roundingModeIndependence;
			[FieldOffset(24)]public uint shaderSignedZeroInfNanPreserveFloat16;
			[FieldOffset(28)]public uint shaderSignedZeroInfNanPreserveFloat32;
			[FieldOffset(32)]public uint shaderSignedZeroInfNanPreserveFloat64;
			[FieldOffset(36)]public uint shaderDenormPreserveFloat16;
			[FieldOffset(40)]public uint shaderDenormPreserveFloat32;
			[FieldOffset(44)]public uint shaderDenormPreserveFloat64;
			[FieldOffset(48)]public uint shaderDenormFlushToZeroFloat16;
			[FieldOffset(52)]public uint shaderDenormFlushToZeroFloat32;
			[FieldOffset(56)]public uint shaderDenormFlushToZeroFloat64;
			[FieldOffset(60)]public uint shaderRoundingModeRTEFloat16;
			[FieldOffset(64)]public uint shaderRoundingModeRTEFloat32;
			[FieldOffset(68)]public uint shaderRoundingModeRTEFloat64;
			[FieldOffset(72)]public uint shaderRoundingModeRTZFloat16;
			[FieldOffset(76)]public uint shaderRoundingModeRTZFloat32;
			[FieldOffset(80)]public uint shaderRoundingModeRTZFloat64;
		}

        public static ManagedPtr<VkPhysicalDeviceFloatControlsProperties> Pointer(this VkPhysicalDeviceFloatControlsProperties i) => new ManagedPtr<VkPhysicalDeviceFloatControlsProperties>(i);
        public static ManagedPtr<VkPhysicalDeviceFloatControlsProperties[]> Pointer(this VkPhysicalDeviceFloatControlsProperties[] i) => new ManagedPtr<VkPhysicalDeviceFloatControlsProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorSetLayoutBindingFlagsCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint bindingCount;
			[FieldOffset(24)]public uint* pBindingFlags;
		}

        public static ManagedPtr<VkDescriptorSetLayoutBindingFlagsCreateInfo> Pointer(this VkDescriptorSetLayoutBindingFlagsCreateInfo i) => new ManagedPtr<VkDescriptorSetLayoutBindingFlagsCreateInfo>(i);
        public static ManagedPtr<VkDescriptorSetLayoutBindingFlagsCreateInfo[]> Pointer(this VkDescriptorSetLayoutBindingFlagsCreateInfo[] i) => new ManagedPtr<VkDescriptorSetLayoutBindingFlagsCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceDescriptorIndexingFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint shaderInputAttachmentArrayDynamicIndexing;
			[FieldOffset(20)]public uint shaderUniformTexelBufferArrayDynamicIndexing;
			[FieldOffset(24)]public uint shaderStorageTexelBufferArrayDynamicIndexing;
			[FieldOffset(28)]public uint shaderUniformBufferArrayNonUniformIndexing;
			[FieldOffset(32)]public uint shaderSampledImageArrayNonUniformIndexing;
			[FieldOffset(36)]public uint shaderStorageBufferArrayNonUniformIndexing;
			[FieldOffset(40)]public uint shaderStorageImageArrayNonUniformIndexing;
			[FieldOffset(44)]public uint shaderInputAttachmentArrayNonUniformIndexing;
			[FieldOffset(48)]public uint shaderUniformTexelBufferArrayNonUniformIndexing;
			[FieldOffset(52)]public uint shaderStorageTexelBufferArrayNonUniformIndexing;
			[FieldOffset(56)]public uint descriptorBindingUniformBufferUpdateAfterBind;
			[FieldOffset(60)]public uint descriptorBindingSampledImageUpdateAfterBind;
			[FieldOffset(64)]public uint descriptorBindingStorageImageUpdateAfterBind;
			[FieldOffset(68)]public uint descriptorBindingStorageBufferUpdateAfterBind;
			[FieldOffset(72)]public uint descriptorBindingUniformTexelBufferUpdateAfterBind;
			[FieldOffset(76)]public uint descriptorBindingStorageTexelBufferUpdateAfterBind;
			[FieldOffset(80)]public uint descriptorBindingUpdateUnusedWhilePending;
			[FieldOffset(84)]public uint descriptorBindingPartiallyBound;
			[FieldOffset(88)]public uint descriptorBindingVariableDescriptorCount;
			[FieldOffset(92)]public uint runtimeDescriptorArray;
		}

        public static ManagedPtr<VkPhysicalDeviceDescriptorIndexingFeatures> Pointer(this VkPhysicalDeviceDescriptorIndexingFeatures i) => new ManagedPtr<VkPhysicalDeviceDescriptorIndexingFeatures>(i);
        public static ManagedPtr<VkPhysicalDeviceDescriptorIndexingFeatures[]> Pointer(this VkPhysicalDeviceDescriptorIndexingFeatures[] i) => new ManagedPtr<VkPhysicalDeviceDescriptorIndexingFeatures[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceDescriptorIndexingProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint maxUpdateAfterBindDescriptorsInAllPools;
			[FieldOffset(20)]public uint shaderUniformBufferArrayNonUniformIndexingNative;
			[FieldOffset(24)]public uint shaderSampledImageArrayNonUniformIndexingNative;
			[FieldOffset(28)]public uint shaderStorageBufferArrayNonUniformIndexingNative;
			[FieldOffset(32)]public uint shaderStorageImageArrayNonUniformIndexingNative;
			[FieldOffset(36)]public uint shaderInputAttachmentArrayNonUniformIndexingNative;
			[FieldOffset(40)]public uint robustBufferAccessUpdateAfterBind;
			[FieldOffset(44)]public uint quadDivergentImplicitLod;
			[FieldOffset(48)]public uint maxPerStageDescriptorUpdateAfterBindSamplers;
			[FieldOffset(52)]public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
			[FieldOffset(56)]public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
			[FieldOffset(60)]public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
			[FieldOffset(64)]public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
			[FieldOffset(68)]public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
			[FieldOffset(72)]public uint maxPerStageUpdateAfterBindResources;
			[FieldOffset(76)]public uint maxDescriptorSetUpdateAfterBindSamplers;
			[FieldOffset(80)]public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
			[FieldOffset(84)]public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
			[FieldOffset(88)]public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
			[FieldOffset(92)]public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
			[FieldOffset(96)]public uint maxDescriptorSetUpdateAfterBindSampledImages;
			[FieldOffset(100)]public uint maxDescriptorSetUpdateAfterBindStorageImages;
			[FieldOffset(104)]public uint maxDescriptorSetUpdateAfterBindInputAttachments;
		}

        public static ManagedPtr<VkPhysicalDeviceDescriptorIndexingProperties> Pointer(this VkPhysicalDeviceDescriptorIndexingProperties i) => new ManagedPtr<VkPhysicalDeviceDescriptorIndexingProperties>(i);
        public static ManagedPtr<VkPhysicalDeviceDescriptorIndexingProperties[]> Pointer(this VkPhysicalDeviceDescriptorIndexingProperties[] i) => new ManagedPtr<VkPhysicalDeviceDescriptorIndexingProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint descriptorSetCount;
			[FieldOffset(24)]public uint* pDescriptorCounts;
		}

        public static ManagedPtr<VkDescriptorSetVariableDescriptorCountAllocateInfo> Pointer(this VkDescriptorSetVariableDescriptorCountAllocateInfo i) => new ManagedPtr<VkDescriptorSetVariableDescriptorCountAllocateInfo>(i);
        public static ManagedPtr<VkDescriptorSetVariableDescriptorCountAllocateInfo[]> Pointer(this VkDescriptorSetVariableDescriptorCountAllocateInfo[] i) => new ManagedPtr<VkDescriptorSetVariableDescriptorCountAllocateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorSetVariableDescriptorCountLayoutSupport {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint maxVariableDescriptorCount;
		}

        public static ManagedPtr<VkDescriptorSetVariableDescriptorCountLayoutSupport> Pointer(this VkDescriptorSetVariableDescriptorCountLayoutSupport i) => new ManagedPtr<VkDescriptorSetVariableDescriptorCountLayoutSupport>(i);
        public static ManagedPtr<VkDescriptorSetVariableDescriptorCountLayoutSupport[]> Pointer(this VkDescriptorSetVariableDescriptorCountLayoutSupport[] i) => new ManagedPtr<VkDescriptorSetVariableDescriptorCountLayoutSupport[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSubpassDescriptionDepthStencilResolve {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkResolveModeFlagBits depthResolveMode;
			[FieldOffset(20)]public VkResolveModeFlagBits stencilResolveMode;
			[FieldOffset(24)]public IntPtr pDepthStencilResolveAttachment;
		}

        public static ManagedPtr<VkSubpassDescriptionDepthStencilResolve> Pointer(this VkSubpassDescriptionDepthStencilResolve i) => new ManagedPtr<VkSubpassDescriptionDepthStencilResolve>(i);
        public static ManagedPtr<VkSubpassDescriptionDepthStencilResolve[]> Pointer(this VkSubpassDescriptionDepthStencilResolve[] i) => new ManagedPtr<VkSubpassDescriptionDepthStencilResolve[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceDepthStencilResolveProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint supportedDepthResolveModes;
			[FieldOffset(20)]public uint supportedStencilResolveModes;
			[FieldOffset(24)]public uint independentResolveNone;
			[FieldOffset(28)]public uint independentResolve;
		}

        public static ManagedPtr<VkPhysicalDeviceDepthStencilResolveProperties> Pointer(this VkPhysicalDeviceDepthStencilResolveProperties i) => new ManagedPtr<VkPhysicalDeviceDepthStencilResolveProperties>(i);
        public static ManagedPtr<VkPhysicalDeviceDepthStencilResolveProperties[]> Pointer(this VkPhysicalDeviceDepthStencilResolveProperties[] i) => new ManagedPtr<VkPhysicalDeviceDepthStencilResolveProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceScalarBlockLayoutFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint scalarBlockLayout;
		}

        public static ManagedPtr<VkPhysicalDeviceScalarBlockLayoutFeatures> Pointer(this VkPhysicalDeviceScalarBlockLayoutFeatures i) => new ManagedPtr<VkPhysicalDeviceScalarBlockLayoutFeatures>(i);
        public static ManagedPtr<VkPhysicalDeviceScalarBlockLayoutFeatures[]> Pointer(this VkPhysicalDeviceScalarBlockLayoutFeatures[] i) => new ManagedPtr<VkPhysicalDeviceScalarBlockLayoutFeatures[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageStencilUsageCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint stencilUsage;
		}

        public static ManagedPtr<VkImageStencilUsageCreateInfo> Pointer(this VkImageStencilUsageCreateInfo i) => new ManagedPtr<VkImageStencilUsageCreateInfo>(i);
        public static ManagedPtr<VkImageStencilUsageCreateInfo[]> Pointer(this VkImageStencilUsageCreateInfo[] i) => new ManagedPtr<VkImageStencilUsageCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSamplerReductionModeCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkSamplerReductionMode reductionMode;
		}

        public static ManagedPtr<VkSamplerReductionModeCreateInfo> Pointer(this VkSamplerReductionModeCreateInfo i) => new ManagedPtr<VkSamplerReductionModeCreateInfo>(i);
        public static ManagedPtr<VkSamplerReductionModeCreateInfo[]> Pointer(this VkSamplerReductionModeCreateInfo[] i) => new ManagedPtr<VkSamplerReductionModeCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceSamplerFilterMinmaxProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint filterMinmaxSingleComponentFormats;
			[FieldOffset(20)]public uint filterMinmaxImageComponentMapping;
		}

        public static ManagedPtr<VkPhysicalDeviceSamplerFilterMinmaxProperties> Pointer(this VkPhysicalDeviceSamplerFilterMinmaxProperties i) => new ManagedPtr<VkPhysicalDeviceSamplerFilterMinmaxProperties>(i);
        public static ManagedPtr<VkPhysicalDeviceSamplerFilterMinmaxProperties[]> Pointer(this VkPhysicalDeviceSamplerFilterMinmaxProperties[] i) => new ManagedPtr<VkPhysicalDeviceSamplerFilterMinmaxProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceVulkanMemoryModelFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint vulkanMemoryModel;
			[FieldOffset(20)]public uint vulkanMemoryModelDeviceScope;
			[FieldOffset(24)]public uint vulkanMemoryModelAvailabilityVisibilityChains;
		}

        public static ManagedPtr<VkPhysicalDeviceVulkanMemoryModelFeatures> Pointer(this VkPhysicalDeviceVulkanMemoryModelFeatures i) => new ManagedPtr<VkPhysicalDeviceVulkanMemoryModelFeatures>(i);
        public static ManagedPtr<VkPhysicalDeviceVulkanMemoryModelFeatures[]> Pointer(this VkPhysicalDeviceVulkanMemoryModelFeatures[] i) => new ManagedPtr<VkPhysicalDeviceVulkanMemoryModelFeatures[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceImagelessFramebufferFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint imagelessFramebuffer;
		}

        public static ManagedPtr<VkPhysicalDeviceImagelessFramebufferFeatures> Pointer(this VkPhysicalDeviceImagelessFramebufferFeatures i) => new ManagedPtr<VkPhysicalDeviceImagelessFramebufferFeatures>(i);
        public static ManagedPtr<VkPhysicalDeviceImagelessFramebufferFeatures[]> Pointer(this VkPhysicalDeviceImagelessFramebufferFeatures[] i) => new ManagedPtr<VkPhysicalDeviceImagelessFramebufferFeatures[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkFramebufferAttachmentImageInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint usage;
			[FieldOffset(24)]public uint width;
			[FieldOffset(28)]public uint height;
			[FieldOffset(32)]public uint layerCount;
			[FieldOffset(36)]public uint viewFormatCount;
			[FieldOffset(40)]public VkFormat* pViewFormats;
		}

        public static ManagedPtr<VkFramebufferAttachmentImageInfo> Pointer(this VkFramebufferAttachmentImageInfo i) => new ManagedPtr<VkFramebufferAttachmentImageInfo>(i);
        public static ManagedPtr<VkFramebufferAttachmentImageInfo[]> Pointer(this VkFramebufferAttachmentImageInfo[] i) => new ManagedPtr<VkFramebufferAttachmentImageInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkFramebufferAttachmentsCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint attachmentImageInfoCount;
			[FieldOffset(24)]public IntPtr pAttachmentImageInfos;
		}

        public static ManagedPtr<VkFramebufferAttachmentsCreateInfo> Pointer(this VkFramebufferAttachmentsCreateInfo i) => new ManagedPtr<VkFramebufferAttachmentsCreateInfo>(i);
        public static ManagedPtr<VkFramebufferAttachmentsCreateInfo[]> Pointer(this VkFramebufferAttachmentsCreateInfo[] i) => new ManagedPtr<VkFramebufferAttachmentsCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRenderPassAttachmentBeginInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint attachmentCount;
			[FieldOffset(24)]public IntPtr* pAttachments;
		}

        public static ManagedPtr<VkRenderPassAttachmentBeginInfo> Pointer(this VkRenderPassAttachmentBeginInfo i) => new ManagedPtr<VkRenderPassAttachmentBeginInfo>(i);
        public static ManagedPtr<VkRenderPassAttachmentBeginInfo[]> Pointer(this VkRenderPassAttachmentBeginInfo[] i) => new ManagedPtr<VkRenderPassAttachmentBeginInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceUniformBufferStandardLayoutFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint uniformBufferStandardLayout;
		}

        public static ManagedPtr<VkPhysicalDeviceUniformBufferStandardLayoutFeatures> Pointer(this VkPhysicalDeviceUniformBufferStandardLayoutFeatures i) => new ManagedPtr<VkPhysicalDeviceUniformBufferStandardLayoutFeatures>(i);
        public static ManagedPtr<VkPhysicalDeviceUniformBufferStandardLayoutFeatures[]> Pointer(this VkPhysicalDeviceUniformBufferStandardLayoutFeatures[] i) => new ManagedPtr<VkPhysicalDeviceUniformBufferStandardLayoutFeatures[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint shaderSubgroupExtendedTypes;
		}

        public static ManagedPtr<VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures> Pointer(this VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures i) => new ManagedPtr<VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures>(i);
        public static ManagedPtr<VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures[]> Pointer(this VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures[] i) => new ManagedPtr<VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint separateDepthStencilLayouts;
		}

        public static ManagedPtr<VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures> Pointer(this VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures i) => new ManagedPtr<VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures>(i);
        public static ManagedPtr<VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures[]> Pointer(this VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures[] i) => new ManagedPtr<VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAttachmentReferenceStencilLayout {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkImageLayout stencilLayout;
		}

        public static ManagedPtr<VkAttachmentReferenceStencilLayout> Pointer(this VkAttachmentReferenceStencilLayout i) => new ManagedPtr<VkAttachmentReferenceStencilLayout>(i);
        public static ManagedPtr<VkAttachmentReferenceStencilLayout[]> Pointer(this VkAttachmentReferenceStencilLayout[] i) => new ManagedPtr<VkAttachmentReferenceStencilLayout[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAttachmentDescriptionStencilLayout {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkImageLayout stencilInitialLayout;
			[FieldOffset(20)]public VkImageLayout stencilFinalLayout;
		}

        public static ManagedPtr<VkAttachmentDescriptionStencilLayout> Pointer(this VkAttachmentDescriptionStencilLayout i) => new ManagedPtr<VkAttachmentDescriptionStencilLayout>(i);
        public static ManagedPtr<VkAttachmentDescriptionStencilLayout[]> Pointer(this VkAttachmentDescriptionStencilLayout[] i) => new ManagedPtr<VkAttachmentDescriptionStencilLayout[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceHostQueryResetFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint hostQueryReset;
		}

        public static ManagedPtr<VkPhysicalDeviceHostQueryResetFeatures> Pointer(this VkPhysicalDeviceHostQueryResetFeatures i) => new ManagedPtr<VkPhysicalDeviceHostQueryResetFeatures>(i);
        public static ManagedPtr<VkPhysicalDeviceHostQueryResetFeatures[]> Pointer(this VkPhysicalDeviceHostQueryResetFeatures[] i) => new ManagedPtr<VkPhysicalDeviceHostQueryResetFeatures[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceTimelineSemaphoreFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint timelineSemaphore;
		}

        public static ManagedPtr<VkPhysicalDeviceTimelineSemaphoreFeatures> Pointer(this VkPhysicalDeviceTimelineSemaphoreFeatures i) => new ManagedPtr<VkPhysicalDeviceTimelineSemaphoreFeatures>(i);
        public static ManagedPtr<VkPhysicalDeviceTimelineSemaphoreFeatures[]> Pointer(this VkPhysicalDeviceTimelineSemaphoreFeatures[] i) => new ManagedPtr<VkPhysicalDeviceTimelineSemaphoreFeatures[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceTimelineSemaphoreProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong maxTimelineSemaphoreValueDifference;
		}

        public static ManagedPtr<VkPhysicalDeviceTimelineSemaphoreProperties> Pointer(this VkPhysicalDeviceTimelineSemaphoreProperties i) => new ManagedPtr<VkPhysicalDeviceTimelineSemaphoreProperties>(i);
        public static ManagedPtr<VkPhysicalDeviceTimelineSemaphoreProperties[]> Pointer(this VkPhysicalDeviceTimelineSemaphoreProperties[] i) => new ManagedPtr<VkPhysicalDeviceTimelineSemaphoreProperties[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSemaphoreTypeCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkSemaphoreType semaphoreType;
			[FieldOffset(24)]public ulong initialValue;
		}

        public static ManagedPtr<VkSemaphoreTypeCreateInfo> Pointer(this VkSemaphoreTypeCreateInfo i) => new ManagedPtr<VkSemaphoreTypeCreateInfo>(i);
        public static ManagedPtr<VkSemaphoreTypeCreateInfo[]> Pointer(this VkSemaphoreTypeCreateInfo[] i) => new ManagedPtr<VkSemaphoreTypeCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkTimelineSemaphoreSubmitInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint waitSemaphoreValueCount;
			[FieldOffset(24)]public ulong* pWaitSemaphoreValues;
			[FieldOffset(32)]public uint signalSemaphoreValueCount;
			[FieldOffset(40)]public ulong* pSignalSemaphoreValues;
		}

        public static ManagedPtr<VkTimelineSemaphoreSubmitInfo> Pointer(this VkTimelineSemaphoreSubmitInfo i) => new ManagedPtr<VkTimelineSemaphoreSubmitInfo>(i);
        public static ManagedPtr<VkTimelineSemaphoreSubmitInfo[]> Pointer(this VkTimelineSemaphoreSubmitInfo[] i) => new ManagedPtr<VkTimelineSemaphoreSubmitInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSemaphoreWaitInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint semaphoreCount;
			[FieldOffset(24)]public IntPtr* pSemaphores;
			[FieldOffset(32)]public ulong* pValues;
		}

        public static ManagedPtr<VkSemaphoreWaitInfo> Pointer(this VkSemaphoreWaitInfo i) => new ManagedPtr<VkSemaphoreWaitInfo>(i);
        public static ManagedPtr<VkSemaphoreWaitInfo[]> Pointer(this VkSemaphoreWaitInfo[] i) => new ManagedPtr<VkSemaphoreWaitInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSemaphoreSignalInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr semaphore;
			[FieldOffset(24)]public ulong value;
		}

        public static ManagedPtr<VkSemaphoreSignalInfo> Pointer(this VkSemaphoreSignalInfo i) => new ManagedPtr<VkSemaphoreSignalInfo>(i);
        public static ManagedPtr<VkSemaphoreSignalInfo[]> Pointer(this VkSemaphoreSignalInfo[] i) => new ManagedPtr<VkSemaphoreSignalInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint bufferDeviceAddress;
			[FieldOffset(20)]public uint bufferDeviceAddressCaptureReplay;
			[FieldOffset(24)]public uint bufferDeviceAddressMultiDevice;
		}

        public static ManagedPtr<VkPhysicalDeviceBufferDeviceAddressFeatures> Pointer(this VkPhysicalDeviceBufferDeviceAddressFeatures i) => new ManagedPtr<VkPhysicalDeviceBufferDeviceAddressFeatures>(i);
        public static ManagedPtr<VkPhysicalDeviceBufferDeviceAddressFeatures[]> Pointer(this VkPhysicalDeviceBufferDeviceAddressFeatures[] i) => new ManagedPtr<VkPhysicalDeviceBufferDeviceAddressFeatures[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBufferDeviceAddressInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr buffer;
		}

        public static ManagedPtr<VkBufferDeviceAddressInfo> Pointer(this VkBufferDeviceAddressInfo i) => new ManagedPtr<VkBufferDeviceAddressInfo>(i);
        public static ManagedPtr<VkBufferDeviceAddressInfo[]> Pointer(this VkBufferDeviceAddressInfo[] i) => new ManagedPtr<VkBufferDeviceAddressInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBufferOpaqueCaptureAddressCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong opaqueCaptureAddress;
		}

        public static ManagedPtr<VkBufferOpaqueCaptureAddressCreateInfo> Pointer(this VkBufferOpaqueCaptureAddressCreateInfo i) => new ManagedPtr<VkBufferOpaqueCaptureAddressCreateInfo>(i);
        public static ManagedPtr<VkBufferOpaqueCaptureAddressCreateInfo[]> Pointer(this VkBufferOpaqueCaptureAddressCreateInfo[] i) => new ManagedPtr<VkBufferOpaqueCaptureAddressCreateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryOpaqueCaptureAddressAllocateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong opaqueCaptureAddress;
		}

        public static ManagedPtr<VkMemoryOpaqueCaptureAddressAllocateInfo> Pointer(this VkMemoryOpaqueCaptureAddressAllocateInfo i) => new ManagedPtr<VkMemoryOpaqueCaptureAddressAllocateInfo>(i);
        public static ManagedPtr<VkMemoryOpaqueCaptureAddressAllocateInfo[]> Pointer(this VkMemoryOpaqueCaptureAddressAllocateInfo[] i) => new ManagedPtr<VkMemoryOpaqueCaptureAddressAllocateInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceMemoryOpaqueCaptureAddressInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr memory;
		}

        public static ManagedPtr<VkDeviceMemoryOpaqueCaptureAddressInfo> Pointer(this VkDeviceMemoryOpaqueCaptureAddressInfo i) => new ManagedPtr<VkDeviceMemoryOpaqueCaptureAddressInfo>(i);
        public static ManagedPtr<VkDeviceMemoryOpaqueCaptureAddressInfo[]> Pointer(this VkDeviceMemoryOpaqueCaptureAddressInfo[] i) => new ManagedPtr<VkDeviceMemoryOpaqueCaptureAddressInfo[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSurfaceCapabilitiesKHR {
			[FieldOffset(0)]public uint minImageCount;
			[FieldOffset(4)]public uint maxImageCount;
			[FieldOffset(8)]public VkExtent2D currentExtent;
			[FieldOffset(16)]public VkExtent2D minImageExtent;
			[FieldOffset(24)]public VkExtent2D maxImageExtent;
			[FieldOffset(32)]public uint maxImageArrayLayers;
			[FieldOffset(36)]public uint supportedTransforms;
			[FieldOffset(40)]public VkSurfaceTransformFlagBitsKHR currentTransform;
			[FieldOffset(44)]public uint supportedCompositeAlpha;
			[FieldOffset(48)]public uint supportedUsageFlags;
		}

        public static ManagedPtr<VkSurfaceCapabilitiesKHR> Pointer(this VkSurfaceCapabilitiesKHR i) => new ManagedPtr<VkSurfaceCapabilitiesKHR>(i);
        public static ManagedPtr<VkSurfaceCapabilitiesKHR[]> Pointer(this VkSurfaceCapabilitiesKHR[] i) => new ManagedPtr<VkSurfaceCapabilitiesKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSurfaceFormatKHR {
			[FieldOffset(0)]public VkFormat format;
			[FieldOffset(4)]public VkColorSpaceKHR colorSpace;
		}

        public static ManagedPtr<VkSurfaceFormatKHR> Pointer(this VkSurfaceFormatKHR i) => new ManagedPtr<VkSurfaceFormatKHR>(i);
        public static ManagedPtr<VkSurfaceFormatKHR[]> Pointer(this VkSurfaceFormatKHR[] i) => new ManagedPtr<VkSurfaceFormatKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSwapchainCreateInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(24)]public IntPtr surface;
			[FieldOffset(32)]public uint minImageCount;
			[FieldOffset(36)]public VkFormat imageFormat;
			[FieldOffset(40)]public VkColorSpaceKHR imageColorSpace;
			[FieldOffset(48)]public VkExtent2D imageExtent;
			[FieldOffset(56)]public uint imageArrayLayers;
			[FieldOffset(60)]public uint imageUsage;
			[FieldOffset(64)]public VkSharingMode imageSharingMode;
			[FieldOffset(68)]public uint queueFamilyIndexCount;
			[FieldOffset(72)]public uint* pQueueFamilyIndices;
			[FieldOffset(80)]public VkSurfaceTransformFlagBitsKHR preTransform;
			[FieldOffset(84)]public VkCompositeAlphaFlagBitsKHR compositeAlpha;
			[FieldOffset(88)]public VkPresentModeKHR presentMode;
			[FieldOffset(92)]public uint clipped;
			[FieldOffset(96)]public IntPtr oldSwapchain;
		}

        public static ManagedPtr<VkSwapchainCreateInfoKHR> Pointer(this VkSwapchainCreateInfoKHR i) => new ManagedPtr<VkSwapchainCreateInfoKHR>(i);
        public static ManagedPtr<VkSwapchainCreateInfoKHR[]> Pointer(this VkSwapchainCreateInfoKHR[] i) => new ManagedPtr<VkSwapchainCreateInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPresentInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint waitSemaphoreCount;
			[FieldOffset(24)]public IntPtr* pWaitSemaphores;
			[FieldOffset(32)]public uint swapchainCount;
			[FieldOffset(40)]public IntPtr* pSwapchains;
			[FieldOffset(48)]public uint* pImageIndices;
			[FieldOffset(56)]public VkResult* pResults;
		}

        public static ManagedPtr<VkPresentInfoKHR> Pointer(this VkPresentInfoKHR i) => new ManagedPtr<VkPresentInfoKHR>(i);
        public static ManagedPtr<VkPresentInfoKHR[]> Pointer(this VkPresentInfoKHR[] i) => new ManagedPtr<VkPresentInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageSwapchainCreateInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr swapchain;
		}

        public static ManagedPtr<VkImageSwapchainCreateInfoKHR> Pointer(this VkImageSwapchainCreateInfoKHR i) => new ManagedPtr<VkImageSwapchainCreateInfoKHR>(i);
        public static ManagedPtr<VkImageSwapchainCreateInfoKHR[]> Pointer(this VkImageSwapchainCreateInfoKHR[] i) => new ManagedPtr<VkImageSwapchainCreateInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBindImageMemorySwapchainInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr swapchain;
			[FieldOffset(24)]public uint imageIndex;
		}

        public static ManagedPtr<VkBindImageMemorySwapchainInfoKHR> Pointer(this VkBindImageMemorySwapchainInfoKHR i) => new ManagedPtr<VkBindImageMemorySwapchainInfoKHR>(i);
        public static ManagedPtr<VkBindImageMemorySwapchainInfoKHR[]> Pointer(this VkBindImageMemorySwapchainInfoKHR[] i) => new ManagedPtr<VkBindImageMemorySwapchainInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAcquireNextImageInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr swapchain;
			[FieldOffset(24)]public ulong timeout;
			[FieldOffset(32)]public IntPtr semaphore;
			[FieldOffset(40)]public IntPtr fence;
			[FieldOffset(48)]public uint deviceMask;
		}

        public static ManagedPtr<VkAcquireNextImageInfoKHR> Pointer(this VkAcquireNextImageInfoKHR i) => new ManagedPtr<VkAcquireNextImageInfoKHR>(i);
        public static ManagedPtr<VkAcquireNextImageInfoKHR[]> Pointer(this VkAcquireNextImageInfoKHR[] i) => new ManagedPtr<VkAcquireNextImageInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceGroupPresentCapabilitiesKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)][MarshalAs(UnmanagedType.ByValArray, SizeConst=32)] public uint[] presentMask;
			[FieldOffset(144)]public uint modes;
		}

        public static ManagedPtr<VkDeviceGroupPresentCapabilitiesKHR> Pointer(this VkDeviceGroupPresentCapabilitiesKHR i) => new ManagedPtr<VkDeviceGroupPresentCapabilitiesKHR>(i);
        public static ManagedPtr<VkDeviceGroupPresentCapabilitiesKHR[]> Pointer(this VkDeviceGroupPresentCapabilitiesKHR[] i) => new ManagedPtr<VkDeviceGroupPresentCapabilitiesKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceGroupPresentInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint swapchainCount;
			[FieldOffset(24)]public uint* pDeviceMasks;
			[FieldOffset(32)]public VkDeviceGroupPresentModeFlagBitsKHR mode;
		}

        public static ManagedPtr<VkDeviceGroupPresentInfoKHR> Pointer(this VkDeviceGroupPresentInfoKHR i) => new ManagedPtr<VkDeviceGroupPresentInfoKHR>(i);
        public static ManagedPtr<VkDeviceGroupPresentInfoKHR[]> Pointer(this VkDeviceGroupPresentInfoKHR[] i) => new ManagedPtr<VkDeviceGroupPresentInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceGroupSwapchainCreateInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint modes;
		}

        public static ManagedPtr<VkDeviceGroupSwapchainCreateInfoKHR> Pointer(this VkDeviceGroupSwapchainCreateInfoKHR i) => new ManagedPtr<VkDeviceGroupSwapchainCreateInfoKHR>(i);
        public static ManagedPtr<VkDeviceGroupSwapchainCreateInfoKHR[]> Pointer(this VkDeviceGroupSwapchainCreateInfoKHR[] i) => new ManagedPtr<VkDeviceGroupSwapchainCreateInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayPropertiesKHR {
			[FieldOffset(0)]public IntPtr display;
			[FieldOffset(8)]public string displayName;
			[FieldOffset(16)]public VkExtent2D physicalDimensions;
			[FieldOffset(24)]public VkExtent2D physicalResolution;
			[FieldOffset(32)]public uint supportedTransforms;
			[FieldOffset(36)]public uint planeReorderPossible;
			[FieldOffset(40)]public uint persistentContent;
		}

        public static ManagedPtr<VkDisplayPropertiesKHR> Pointer(this VkDisplayPropertiesKHR i) => new ManagedPtr<VkDisplayPropertiesKHR>(i);
        public static ManagedPtr<VkDisplayPropertiesKHR[]> Pointer(this VkDisplayPropertiesKHR[] i) => new ManagedPtr<VkDisplayPropertiesKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayModeParametersKHR {
			[FieldOffset(0)]public VkExtent2D visibleRegion;
			[FieldOffset(8)]public uint refreshRate;
		}

        public static ManagedPtr<VkDisplayModeParametersKHR> Pointer(this VkDisplayModeParametersKHR i) => new ManagedPtr<VkDisplayModeParametersKHR>(i);
        public static ManagedPtr<VkDisplayModeParametersKHR[]> Pointer(this VkDisplayModeParametersKHR[] i) => new ManagedPtr<VkDisplayModeParametersKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayModePropertiesKHR {
			[FieldOffset(0)]public IntPtr displayMode;
			[FieldOffset(12)]public VkDisplayModeParametersKHR parameters;
		}

        public static ManagedPtr<VkDisplayModePropertiesKHR> Pointer(this VkDisplayModePropertiesKHR i) => new ManagedPtr<VkDisplayModePropertiesKHR>(i);
        public static ManagedPtr<VkDisplayModePropertiesKHR[]> Pointer(this VkDisplayModePropertiesKHR[] i) => new ManagedPtr<VkDisplayModePropertiesKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayModeCreateInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(24)]public VkDisplayModeParametersKHR parameters;
		}

        public static ManagedPtr<VkDisplayModeCreateInfoKHR> Pointer(this VkDisplayModeCreateInfoKHR i) => new ManagedPtr<VkDisplayModeCreateInfoKHR>(i);
        public static ManagedPtr<VkDisplayModeCreateInfoKHR[]> Pointer(this VkDisplayModeCreateInfoKHR[] i) => new ManagedPtr<VkDisplayModeCreateInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayPlaneCapabilitiesKHR {
			[FieldOffset(0)]public uint supportedAlpha;
			[FieldOffset(8)]public VkOffset2D minSrcPosition;
			[FieldOffset(16)]public VkOffset2D maxSrcPosition;
			[FieldOffset(24)]public VkExtent2D minSrcExtent;
			[FieldOffset(32)]public VkExtent2D maxSrcExtent;
			[FieldOffset(40)]public VkOffset2D minDstPosition;
			[FieldOffset(48)]public VkOffset2D maxDstPosition;
			[FieldOffset(56)]public VkExtent2D minDstExtent;
			[FieldOffset(64)]public VkExtent2D maxDstExtent;
		}

        public static ManagedPtr<VkDisplayPlaneCapabilitiesKHR> Pointer(this VkDisplayPlaneCapabilitiesKHR i) => new ManagedPtr<VkDisplayPlaneCapabilitiesKHR>(i);
        public static ManagedPtr<VkDisplayPlaneCapabilitiesKHR[]> Pointer(this VkDisplayPlaneCapabilitiesKHR[] i) => new ManagedPtr<VkDisplayPlaneCapabilitiesKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayPlanePropertiesKHR {
			[FieldOffset(0)]public IntPtr currentDisplay;
			[FieldOffset(8)]public uint currentStackIndex;
		}

        public static ManagedPtr<VkDisplayPlanePropertiesKHR> Pointer(this VkDisplayPlanePropertiesKHR i) => new ManagedPtr<VkDisplayPlanePropertiesKHR>(i);
        public static ManagedPtr<VkDisplayPlanePropertiesKHR[]> Pointer(this VkDisplayPlanePropertiesKHR[] i) => new ManagedPtr<VkDisplayPlanePropertiesKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplaySurfaceCreateInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(24)]public IntPtr displayMode;
			[FieldOffset(32)]public uint planeIndex;
			[FieldOffset(36)]public uint planeStackIndex;
			[FieldOffset(40)]public VkSurfaceTransformFlagBitsKHR transform;
			[FieldOffset(44)]public float globalAlpha;
			[FieldOffset(48)]public VkDisplayPlaneAlphaFlagBitsKHR alphaMode;
			[FieldOffset(56)]public VkExtent2D imageExtent;
		}

        public static ManagedPtr<VkDisplaySurfaceCreateInfoKHR> Pointer(this VkDisplaySurfaceCreateInfoKHR i) => new ManagedPtr<VkDisplaySurfaceCreateInfoKHR>(i);
        public static ManagedPtr<VkDisplaySurfaceCreateInfoKHR[]> Pointer(this VkDisplaySurfaceCreateInfoKHR[] i) => new ManagedPtr<VkDisplaySurfaceCreateInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayPresentInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkRect2D srcRect;
			[FieldOffset(32)]public VkRect2D dstRect;
			[FieldOffset(48)]public uint persistent;
		}

        public static ManagedPtr<VkDisplayPresentInfoKHR> Pointer(this VkDisplayPresentInfoKHR i) => new ManagedPtr<VkDisplayPresentInfoKHR>(i);
        public static ManagedPtr<VkDisplayPresentInfoKHR[]> Pointer(this VkDisplayPresentInfoKHR[] i) => new ManagedPtr<VkDisplayPresentInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImportMemoryFdInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalMemoryHandleTypeFlagBits handleType;
			[FieldOffset(20)]public int fd;
		}

        public static ManagedPtr<VkImportMemoryFdInfoKHR> Pointer(this VkImportMemoryFdInfoKHR i) => new ManagedPtr<VkImportMemoryFdInfoKHR>(i);
        public static ManagedPtr<VkImportMemoryFdInfoKHR[]> Pointer(this VkImportMemoryFdInfoKHR[] i) => new ManagedPtr<VkImportMemoryFdInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryFdPropertiesKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint memoryTypeBits;
		}

        public static ManagedPtr<VkMemoryFdPropertiesKHR> Pointer(this VkMemoryFdPropertiesKHR i) => new ManagedPtr<VkMemoryFdPropertiesKHR>(i);
        public static ManagedPtr<VkMemoryFdPropertiesKHR[]> Pointer(this VkMemoryFdPropertiesKHR[] i) => new ManagedPtr<VkMemoryFdPropertiesKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryGetFdInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr memory;
			[FieldOffset(24)]public VkExternalMemoryHandleTypeFlagBits handleType;
		}

        public static ManagedPtr<VkMemoryGetFdInfoKHR> Pointer(this VkMemoryGetFdInfoKHR i) => new ManagedPtr<VkMemoryGetFdInfoKHR>(i);
        public static ManagedPtr<VkMemoryGetFdInfoKHR[]> Pointer(this VkMemoryGetFdInfoKHR[] i) => new ManagedPtr<VkMemoryGetFdInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImportSemaphoreFdInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr semaphore;
			[FieldOffset(24)]public uint flags;
			[FieldOffset(28)]public VkExternalSemaphoreHandleTypeFlagBits handleType;
			[FieldOffset(32)]public int fd;
		}

        public static ManagedPtr<VkImportSemaphoreFdInfoKHR> Pointer(this VkImportSemaphoreFdInfoKHR i) => new ManagedPtr<VkImportSemaphoreFdInfoKHR>(i);
        public static ManagedPtr<VkImportSemaphoreFdInfoKHR[]> Pointer(this VkImportSemaphoreFdInfoKHR[] i) => new ManagedPtr<VkImportSemaphoreFdInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSemaphoreGetFdInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr semaphore;
			[FieldOffset(24)]public VkExternalSemaphoreHandleTypeFlagBits handleType;
		}

        public static ManagedPtr<VkSemaphoreGetFdInfoKHR> Pointer(this VkSemaphoreGetFdInfoKHR i) => new ManagedPtr<VkSemaphoreGetFdInfoKHR>(i);
        public static ManagedPtr<VkSemaphoreGetFdInfoKHR[]> Pointer(this VkSemaphoreGetFdInfoKHR[] i) => new ManagedPtr<VkSemaphoreGetFdInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDevicePushDescriptorPropertiesKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint maxPushDescriptors;
		}

        public static ManagedPtr<VkPhysicalDevicePushDescriptorPropertiesKHR> Pointer(this VkPhysicalDevicePushDescriptorPropertiesKHR i) => new ManagedPtr<VkPhysicalDevicePushDescriptorPropertiesKHR>(i);
        public static ManagedPtr<VkPhysicalDevicePushDescriptorPropertiesKHR[]> Pointer(this VkPhysicalDevicePushDescriptorPropertiesKHR[] i) => new ManagedPtr<VkPhysicalDevicePushDescriptorPropertiesKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRectLayerKHR {
			[FieldOffset(0)]public VkOffset2D offset;
			[FieldOffset(8)]public VkExtent2D extent;
			[FieldOffset(16)]public uint layer;
		}

        public static ManagedPtr<VkRectLayerKHR> Pointer(this VkRectLayerKHR i) => new ManagedPtr<VkRectLayerKHR>(i);
        public static ManagedPtr<VkRectLayerKHR[]> Pointer(this VkRectLayerKHR[] i) => new ManagedPtr<VkRectLayerKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPresentRegionKHR {
			[FieldOffset(0)]public uint rectangleCount;
			[FieldOffset(8)]public IntPtr pRectangles;
		}

        public static ManagedPtr<VkPresentRegionKHR> Pointer(this VkPresentRegionKHR i) => new ManagedPtr<VkPresentRegionKHR>(i);
        public static ManagedPtr<VkPresentRegionKHR[]> Pointer(this VkPresentRegionKHR[] i) => new ManagedPtr<VkPresentRegionKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPresentRegionsKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint swapchainCount;
			[FieldOffset(24)]public IntPtr pRegions;
		}

        public static ManagedPtr<VkPresentRegionsKHR> Pointer(this VkPresentRegionsKHR i) => new ManagedPtr<VkPresentRegionsKHR>(i);
        public static ManagedPtr<VkPresentRegionsKHR[]> Pointer(this VkPresentRegionsKHR[] i) => new ManagedPtr<VkPresentRegionsKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSharedPresentSurfaceCapabilitiesKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint sharedPresentSupportedUsageFlags;
		}

        public static ManagedPtr<VkSharedPresentSurfaceCapabilitiesKHR> Pointer(this VkSharedPresentSurfaceCapabilitiesKHR i) => new ManagedPtr<VkSharedPresentSurfaceCapabilitiesKHR>(i);
        public static ManagedPtr<VkSharedPresentSurfaceCapabilitiesKHR[]> Pointer(this VkSharedPresentSurfaceCapabilitiesKHR[] i) => new ManagedPtr<VkSharedPresentSurfaceCapabilitiesKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImportFenceFdInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr fence;
			[FieldOffset(24)]public uint flags;
			[FieldOffset(28)]public VkExternalFenceHandleTypeFlagBits handleType;
			[FieldOffset(32)]public int fd;
		}

        public static ManagedPtr<VkImportFenceFdInfoKHR> Pointer(this VkImportFenceFdInfoKHR i) => new ManagedPtr<VkImportFenceFdInfoKHR>(i);
        public static ManagedPtr<VkImportFenceFdInfoKHR[]> Pointer(this VkImportFenceFdInfoKHR[] i) => new ManagedPtr<VkImportFenceFdInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkFenceGetFdInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr fence;
			[FieldOffset(24)]public VkExternalFenceHandleTypeFlagBits handleType;
		}

        public static ManagedPtr<VkFenceGetFdInfoKHR> Pointer(this VkFenceGetFdInfoKHR i) => new ManagedPtr<VkFenceGetFdInfoKHR>(i);
        public static ManagedPtr<VkFenceGetFdInfoKHR[]> Pointer(this VkFenceGetFdInfoKHR[] i) => new ManagedPtr<VkFenceGetFdInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDevicePerformanceQueryFeaturesKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint performanceCounterQueryPools;
			[FieldOffset(20)]public uint performanceCounterMultipleQueryPools;
		}

        public static ManagedPtr<VkPhysicalDevicePerformanceQueryFeaturesKHR> Pointer(this VkPhysicalDevicePerformanceQueryFeaturesKHR i) => new ManagedPtr<VkPhysicalDevicePerformanceQueryFeaturesKHR>(i);
        public static ManagedPtr<VkPhysicalDevicePerformanceQueryFeaturesKHR[]> Pointer(this VkPhysicalDevicePerformanceQueryFeaturesKHR[] i) => new ManagedPtr<VkPhysicalDevicePerformanceQueryFeaturesKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDevicePerformanceQueryPropertiesKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint allowCommandBufferQueryCopies;
		}

        public static ManagedPtr<VkPhysicalDevicePerformanceQueryPropertiesKHR> Pointer(this VkPhysicalDevicePerformanceQueryPropertiesKHR i) => new ManagedPtr<VkPhysicalDevicePerformanceQueryPropertiesKHR>(i);
        public static ManagedPtr<VkPhysicalDevicePerformanceQueryPropertiesKHR[]> Pointer(this VkPhysicalDevicePerformanceQueryPropertiesKHR[] i) => new ManagedPtr<VkPhysicalDevicePerformanceQueryPropertiesKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPerformanceCounterKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPerformanceCounterUnitKHR unit;
			[FieldOffset(20)]public VkPerformanceCounterScopeKHR scope;
			[FieldOffset(24)]public VkPerformanceCounterStorageKHR storage;
			[FieldOffset(28)]public fixed byte uuid[16];
		}

        public static ManagedPtr<VkPerformanceCounterKHR> Pointer(this VkPerformanceCounterKHR i) => new ManagedPtr<VkPerformanceCounterKHR>(i);
        public static ManagedPtr<VkPerformanceCounterKHR[]> Pointer(this VkPerformanceCounterKHR[] i) => new ManagedPtr<VkPerformanceCounterKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPerformanceCounterDescriptionKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] name;
			[FieldOffset(276)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] category;
			[FieldOffset(532)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] description;
		}

        public static ManagedPtr<VkPerformanceCounterDescriptionKHR> Pointer(this VkPerformanceCounterDescriptionKHR i) => new ManagedPtr<VkPerformanceCounterDescriptionKHR>(i);
        public static ManagedPtr<VkPerformanceCounterDescriptionKHR[]> Pointer(this VkPerformanceCounterDescriptionKHR[] i) => new ManagedPtr<VkPerformanceCounterDescriptionKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkQueryPoolPerformanceCreateInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint queueFamilyIndex;
			[FieldOffset(20)]public uint counterIndexCount;
			[FieldOffset(24)]public uint* pCounterIndices;
		}

        public static ManagedPtr<VkQueryPoolPerformanceCreateInfoKHR> Pointer(this VkQueryPoolPerformanceCreateInfoKHR i) => new ManagedPtr<VkQueryPoolPerformanceCreateInfoKHR>(i);
        public static ManagedPtr<VkQueryPoolPerformanceCreateInfoKHR[]> Pointer(this VkQueryPoolPerformanceCreateInfoKHR[] i) => new ManagedPtr<VkQueryPoolPerformanceCreateInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAcquireProfilingLockInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(24)]public ulong timeout;
		}

        public static ManagedPtr<VkAcquireProfilingLockInfoKHR> Pointer(this VkAcquireProfilingLockInfoKHR i) => new ManagedPtr<VkAcquireProfilingLockInfoKHR>(i);
        public static ManagedPtr<VkAcquireProfilingLockInfoKHR[]> Pointer(this VkAcquireProfilingLockInfoKHR[] i) => new ManagedPtr<VkAcquireProfilingLockInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPerformanceQuerySubmitInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint counterPassIndex;
		}

        public static ManagedPtr<VkPerformanceQuerySubmitInfoKHR> Pointer(this VkPerformanceQuerySubmitInfoKHR i) => new ManagedPtr<VkPerformanceQuerySubmitInfoKHR>(i);
        public static ManagedPtr<VkPerformanceQuerySubmitInfoKHR[]> Pointer(this VkPerformanceQuerySubmitInfoKHR[] i) => new ManagedPtr<VkPerformanceQuerySubmitInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceSurfaceInfo2KHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr surface;
		}

        public static ManagedPtr<VkPhysicalDeviceSurfaceInfo2KHR> Pointer(this VkPhysicalDeviceSurfaceInfo2KHR i) => new ManagedPtr<VkPhysicalDeviceSurfaceInfo2KHR>(i);
        public static ManagedPtr<VkPhysicalDeviceSurfaceInfo2KHR[]> Pointer(this VkPhysicalDeviceSurfaceInfo2KHR[] i) => new ManagedPtr<VkPhysicalDeviceSurfaceInfo2KHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSurfaceCapabilities2KHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(52)]public VkSurfaceCapabilitiesKHR surfaceCapabilities;
		}

        public static ManagedPtr<VkSurfaceCapabilities2KHR> Pointer(this VkSurfaceCapabilities2KHR i) => new ManagedPtr<VkSurfaceCapabilities2KHR>(i);
        public static ManagedPtr<VkSurfaceCapabilities2KHR[]> Pointer(this VkSurfaceCapabilities2KHR[] i) => new ManagedPtr<VkSurfaceCapabilities2KHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSurfaceFormat2KHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkSurfaceFormatKHR surfaceFormat;
		}

        public static ManagedPtr<VkSurfaceFormat2KHR> Pointer(this VkSurfaceFormat2KHR i) => new ManagedPtr<VkSurfaceFormat2KHR>(i);
        public static ManagedPtr<VkSurfaceFormat2KHR[]> Pointer(this VkSurfaceFormat2KHR[] i) => new ManagedPtr<VkSurfaceFormat2KHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayProperties2KHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(44)]public VkDisplayPropertiesKHR displayProperties;
		}

        public static ManagedPtr<VkDisplayProperties2KHR> Pointer(this VkDisplayProperties2KHR i) => new ManagedPtr<VkDisplayProperties2KHR>(i);
        public static ManagedPtr<VkDisplayProperties2KHR[]> Pointer(this VkDisplayProperties2KHR[] i) => new ManagedPtr<VkDisplayProperties2KHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayPlaneProperties2KHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(24)]public VkDisplayPlanePropertiesKHR displayPlaneProperties;
		}

        public static ManagedPtr<VkDisplayPlaneProperties2KHR> Pointer(this VkDisplayPlaneProperties2KHR i) => new ManagedPtr<VkDisplayPlaneProperties2KHR>(i);
        public static ManagedPtr<VkDisplayPlaneProperties2KHR[]> Pointer(this VkDisplayPlaneProperties2KHR[] i) => new ManagedPtr<VkDisplayPlaneProperties2KHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayModeProperties2KHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(24)]public VkDisplayModePropertiesKHR displayModeProperties;
		}

        public static ManagedPtr<VkDisplayModeProperties2KHR> Pointer(this VkDisplayModeProperties2KHR i) => new ManagedPtr<VkDisplayModeProperties2KHR>(i);
        public static ManagedPtr<VkDisplayModeProperties2KHR[]> Pointer(this VkDisplayModeProperties2KHR[] i) => new ManagedPtr<VkDisplayModeProperties2KHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayPlaneInfo2KHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr mode;
			[FieldOffset(24)]public uint planeIndex;
		}

        public static ManagedPtr<VkDisplayPlaneInfo2KHR> Pointer(this VkDisplayPlaneInfo2KHR i) => new ManagedPtr<VkDisplayPlaneInfo2KHR>(i);
        public static ManagedPtr<VkDisplayPlaneInfo2KHR[]> Pointer(this VkDisplayPlaneInfo2KHR[] i) => new ManagedPtr<VkDisplayPlaneInfo2KHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayPlaneCapabilities2KHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(72)]public VkDisplayPlaneCapabilitiesKHR capabilities;
		}

        public static ManagedPtr<VkDisplayPlaneCapabilities2KHR> Pointer(this VkDisplayPlaneCapabilities2KHR i) => new ManagedPtr<VkDisplayPlaneCapabilities2KHR>(i);
        public static ManagedPtr<VkDisplayPlaneCapabilities2KHR[]> Pointer(this VkDisplayPlaneCapabilities2KHR[] i) => new ManagedPtr<VkDisplayPlaneCapabilities2KHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShaderClockFeaturesKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint shaderSubgroupClock;
			[FieldOffset(20)]public uint shaderDeviceClock;
		}

        public static ManagedPtr<VkPhysicalDeviceShaderClockFeaturesKHR> Pointer(this VkPhysicalDeviceShaderClockFeaturesKHR i) => new ManagedPtr<VkPhysicalDeviceShaderClockFeaturesKHR>(i);
        public static ManagedPtr<VkPhysicalDeviceShaderClockFeaturesKHR[]> Pointer(this VkPhysicalDeviceShaderClockFeaturesKHR[] i) => new ManagedPtr<VkPhysicalDeviceShaderClockFeaturesKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSurfaceProtectedCapabilitiesKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint supportsProtected;
		}

        public static ManagedPtr<VkSurfaceProtectedCapabilitiesKHR> Pointer(this VkSurfaceProtectedCapabilitiesKHR i) => new ManagedPtr<VkSurfaceProtectedCapabilitiesKHR>(i);
        public static ManagedPtr<VkSurfaceProtectedCapabilitiesKHR[]> Pointer(this VkSurfaceProtectedCapabilitiesKHR[] i) => new ManagedPtr<VkSurfaceProtectedCapabilitiesKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint pipelineExecutableInfo;
		}

        public static ManagedPtr<VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR> Pointer(this VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR i) => new ManagedPtr<VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR>(i);
        public static ManagedPtr<VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR[]> Pointer(this VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR[] i) => new ManagedPtr<VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr pipeline;
		}

        public static ManagedPtr<VkPipelineInfoKHR> Pointer(this VkPipelineInfoKHR i) => new ManagedPtr<VkPipelineInfoKHR>(i);
        public static ManagedPtr<VkPipelineInfoKHR[]> Pointer(this VkPipelineInfoKHR[] i) => new ManagedPtr<VkPipelineInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineExecutablePropertiesKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint stages;
			[FieldOffset(20)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] name;
			[FieldOffset(276)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] description;
			[FieldOffset(532)]public uint subgroupSize;
		}

        public static ManagedPtr<VkPipelineExecutablePropertiesKHR> Pointer(this VkPipelineExecutablePropertiesKHR i) => new ManagedPtr<VkPipelineExecutablePropertiesKHR>(i);
        public static ManagedPtr<VkPipelineExecutablePropertiesKHR[]> Pointer(this VkPipelineExecutablePropertiesKHR[] i) => new ManagedPtr<VkPipelineExecutablePropertiesKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineExecutableInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr pipeline;
			[FieldOffset(24)]public uint executableIndex;
		}

        public static ManagedPtr<VkPipelineExecutableInfoKHR> Pointer(this VkPipelineExecutableInfoKHR i) => new ManagedPtr<VkPipelineExecutableInfoKHR>(i);
        public static ManagedPtr<VkPipelineExecutableInfoKHR[]> Pointer(this VkPipelineExecutableInfoKHR[] i) => new ManagedPtr<VkPipelineExecutableInfoKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineExecutableStatisticKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] name;
			[FieldOffset(272)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] description;
			[FieldOffset(528)]public VkPipelineExecutableStatisticFormatKHR format;
			[FieldOffset(536)]public VkPipelineExecutableStatisticValueKHR value;
		}

        public static ManagedPtr<VkPipelineExecutableStatisticKHR> Pointer(this VkPipelineExecutableStatisticKHR i) => new ManagedPtr<VkPipelineExecutableStatisticKHR>(i);
        public static ManagedPtr<VkPipelineExecutableStatisticKHR[]> Pointer(this VkPipelineExecutableStatisticKHR[] i) => new ManagedPtr<VkPipelineExecutableStatisticKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineExecutableInternalRepresentationKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] name;
			[FieldOffset(272)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] description;
			[FieldOffset(528)]public uint isText;
			[FieldOffset(536)]public ulong dataSize;
			[FieldOffset(544)]public IntPtr pData;
		}

        public static ManagedPtr<VkPipelineExecutableInternalRepresentationKHR> Pointer(this VkPipelineExecutableInternalRepresentationKHR i) => new ManagedPtr<VkPipelineExecutableInternalRepresentationKHR>(i);
        public static ManagedPtr<VkPipelineExecutableInternalRepresentationKHR[]> Pointer(this VkPipelineExecutableInternalRepresentationKHR[] i) => new ManagedPtr<VkPipelineExecutableInternalRepresentationKHR[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDebugReportCallbackCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(24)]public IntPtr pfnCallback;
			[FieldOffset(32)]public IntPtr pUserData;
		}

        public static ManagedPtr<VkDebugReportCallbackCreateInfoEXT> Pointer(this VkDebugReportCallbackCreateInfoEXT i) => new ManagedPtr<VkDebugReportCallbackCreateInfoEXT>(i);
        public static ManagedPtr<VkDebugReportCallbackCreateInfoEXT[]> Pointer(this VkDebugReportCallbackCreateInfoEXT[] i) => new ManagedPtr<VkDebugReportCallbackCreateInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineRasterizationStateRasterizationOrderAMD {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkRasterizationOrderAMD rasterizationOrder;
		}

        public static ManagedPtr<VkPipelineRasterizationStateRasterizationOrderAMD> Pointer(this VkPipelineRasterizationStateRasterizationOrderAMD i) => new ManagedPtr<VkPipelineRasterizationStateRasterizationOrderAMD>(i);
        public static ManagedPtr<VkPipelineRasterizationStateRasterizationOrderAMD[]> Pointer(this VkPipelineRasterizationStateRasterizationOrderAMD[] i) => new ManagedPtr<VkPipelineRasterizationStateRasterizationOrderAMD[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDebugMarkerObjectNameInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDebugReportObjectTypeEXT objectType;
			[FieldOffset(24)]public ulong @object;
			[FieldOffset(32)]public string pObjectName;
		}

        public static ManagedPtr<VkDebugMarkerObjectNameInfoEXT> Pointer(this VkDebugMarkerObjectNameInfoEXT i) => new ManagedPtr<VkDebugMarkerObjectNameInfoEXT>(i);
        public static ManagedPtr<VkDebugMarkerObjectNameInfoEXT[]> Pointer(this VkDebugMarkerObjectNameInfoEXT[] i) => new ManagedPtr<VkDebugMarkerObjectNameInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDebugMarkerObjectTagInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDebugReportObjectTypeEXT objectType;
			[FieldOffset(24)]public ulong @object;
			[FieldOffset(32)]public ulong tagName;
			[FieldOffset(40)]public ulong tagSize;
			[FieldOffset(48)]public IntPtr pTag;
		}

        public static ManagedPtr<VkDebugMarkerObjectTagInfoEXT> Pointer(this VkDebugMarkerObjectTagInfoEXT i) => new ManagedPtr<VkDebugMarkerObjectTagInfoEXT>(i);
        public static ManagedPtr<VkDebugMarkerObjectTagInfoEXT[]> Pointer(this VkDebugMarkerObjectTagInfoEXT[] i) => new ManagedPtr<VkDebugMarkerObjectTagInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDebugMarkerMarkerInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public string pMarkerName;
			[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray, SizeConst=4)] public float[] color;
		}

        public static ManagedPtr<VkDebugMarkerMarkerInfoEXT> Pointer(this VkDebugMarkerMarkerInfoEXT i) => new ManagedPtr<VkDebugMarkerMarkerInfoEXT>(i);
        public static ManagedPtr<VkDebugMarkerMarkerInfoEXT[]> Pointer(this VkDebugMarkerMarkerInfoEXT[] i) => new ManagedPtr<VkDebugMarkerMarkerInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDedicatedAllocationImageCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint dedicatedAllocation;
		}

        public static ManagedPtr<VkDedicatedAllocationImageCreateInfoNV> Pointer(this VkDedicatedAllocationImageCreateInfoNV i) => new ManagedPtr<VkDedicatedAllocationImageCreateInfoNV>(i);
        public static ManagedPtr<VkDedicatedAllocationImageCreateInfoNV[]> Pointer(this VkDedicatedAllocationImageCreateInfoNV[] i) => new ManagedPtr<VkDedicatedAllocationImageCreateInfoNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDedicatedAllocationBufferCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint dedicatedAllocation;
		}

        public static ManagedPtr<VkDedicatedAllocationBufferCreateInfoNV> Pointer(this VkDedicatedAllocationBufferCreateInfoNV i) => new ManagedPtr<VkDedicatedAllocationBufferCreateInfoNV>(i);
        public static ManagedPtr<VkDedicatedAllocationBufferCreateInfoNV[]> Pointer(this VkDedicatedAllocationBufferCreateInfoNV[] i) => new ManagedPtr<VkDedicatedAllocationBufferCreateInfoNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDedicatedAllocationMemoryAllocateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr image;
			[FieldOffset(24)]public IntPtr buffer;
		}

        public static ManagedPtr<VkDedicatedAllocationMemoryAllocateInfoNV> Pointer(this VkDedicatedAllocationMemoryAllocateInfoNV i) => new ManagedPtr<VkDedicatedAllocationMemoryAllocateInfoNV>(i);
        public static ManagedPtr<VkDedicatedAllocationMemoryAllocateInfoNV[]> Pointer(this VkDedicatedAllocationMemoryAllocateInfoNV[] i) => new ManagedPtr<VkDedicatedAllocationMemoryAllocateInfoNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceTransformFeedbackFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint transformFeedback;
			[FieldOffset(20)]public uint geometryStreams;
		}

        public static ManagedPtr<VkPhysicalDeviceTransformFeedbackFeaturesEXT> Pointer(this VkPhysicalDeviceTransformFeedbackFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceTransformFeedbackFeaturesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceTransformFeedbackFeaturesEXT[]> Pointer(this VkPhysicalDeviceTransformFeedbackFeaturesEXT[] i) => new ManagedPtr<VkPhysicalDeviceTransformFeedbackFeaturesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceTransformFeedbackPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint maxTransformFeedbackStreams;
			[FieldOffset(20)]public uint maxTransformFeedbackBuffers;
			[FieldOffset(24)]public ulong maxTransformFeedbackBufferSize;
			[FieldOffset(32)]public uint maxTransformFeedbackStreamDataSize;
			[FieldOffset(36)]public uint maxTransformFeedbackBufferDataSize;
			[FieldOffset(40)]public uint maxTransformFeedbackBufferDataStride;
			[FieldOffset(44)]public uint transformFeedbackQueries;
			[FieldOffset(48)]public uint transformFeedbackStreamsLinesTriangles;
			[FieldOffset(52)]public uint transformFeedbackRasterizationStreamSelect;
			[FieldOffset(56)]public uint transformFeedbackDraw;
		}

        public static ManagedPtr<VkPhysicalDeviceTransformFeedbackPropertiesEXT> Pointer(this VkPhysicalDeviceTransformFeedbackPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceTransformFeedbackPropertiesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceTransformFeedbackPropertiesEXT[]> Pointer(this VkPhysicalDeviceTransformFeedbackPropertiesEXT[] i) => new ManagedPtr<VkPhysicalDeviceTransformFeedbackPropertiesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineRasterizationStateStreamCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint rasterizationStream;
		}

        public static ManagedPtr<VkPipelineRasterizationStateStreamCreateInfoEXT> Pointer(this VkPipelineRasterizationStateStreamCreateInfoEXT i) => new ManagedPtr<VkPipelineRasterizationStateStreamCreateInfoEXT>(i);
        public static ManagedPtr<VkPipelineRasterizationStateStreamCreateInfoEXT[]> Pointer(this VkPipelineRasterizationStateStreamCreateInfoEXT[] i) => new ManagedPtr<VkPipelineRasterizationStateStreamCreateInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageViewHandleInfoNVX {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr imageView;
			[FieldOffset(24)]public VkDescriptorType descriptorType;
			[FieldOffset(32)]public IntPtr sampler;
		}

        public static ManagedPtr<VkImageViewHandleInfoNVX> Pointer(this VkImageViewHandleInfoNVX i) => new ManagedPtr<VkImageViewHandleInfoNVX>(i);
        public static ManagedPtr<VkImageViewHandleInfoNVX[]> Pointer(this VkImageViewHandleInfoNVX[] i) => new ManagedPtr<VkImageViewHandleInfoNVX[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkTextureLODGatherFormatPropertiesAMD {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint supportsTextureGatherLODBiasAMD;
		}

        public static ManagedPtr<VkTextureLODGatherFormatPropertiesAMD> Pointer(this VkTextureLODGatherFormatPropertiesAMD i) => new ManagedPtr<VkTextureLODGatherFormatPropertiesAMD>(i);
        public static ManagedPtr<VkTextureLODGatherFormatPropertiesAMD[]> Pointer(this VkTextureLODGatherFormatPropertiesAMD[] i) => new ManagedPtr<VkTextureLODGatherFormatPropertiesAMD[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkShaderResourceUsageAMD {
			[FieldOffset(0)]public uint numUsedVgprs;
			[FieldOffset(4)]public uint numUsedSgprs;
			[FieldOffset(8)]public uint ldsSizePerLocalWorkGroup;
			[FieldOffset(16)]public ulong ldsUsageSizeInBytes;
			[FieldOffset(24)]public ulong scratchMemUsageInBytes;
		}

        public static ManagedPtr<VkShaderResourceUsageAMD> Pointer(this VkShaderResourceUsageAMD i) => new ManagedPtr<VkShaderResourceUsageAMD>(i);
        public static ManagedPtr<VkShaderResourceUsageAMD[]> Pointer(this VkShaderResourceUsageAMD[] i) => new ManagedPtr<VkShaderResourceUsageAMD[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkShaderStatisticsInfoAMD {
			[FieldOffset(0)]public uint shaderStageMask;
			[FieldOffset(32)]public VkShaderResourceUsageAMD resourceUsage;
			[FieldOffset(64)]public uint numPhysicalVgprs;
			[FieldOffset(68)]public uint numPhysicalSgprs;
			[FieldOffset(72)]public uint numAvailableVgprs;
			[FieldOffset(76)]public uint numAvailableSgprs;
			[FieldOffset(80)][MarshalAs(UnmanagedType.ByValArray, SizeConst=3)] public uint[] computeWorkGroupSize;
		}

        public static ManagedPtr<VkShaderStatisticsInfoAMD> Pointer(this VkShaderStatisticsInfoAMD i) => new ManagedPtr<VkShaderStatisticsInfoAMD>(i);
        public static ManagedPtr<VkShaderStatisticsInfoAMD[]> Pointer(this VkShaderStatisticsInfoAMD[] i) => new ManagedPtr<VkShaderStatisticsInfoAMD[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceCornerSampledImageFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint cornerSampledImage;
		}

        public static ManagedPtr<VkPhysicalDeviceCornerSampledImageFeaturesNV> Pointer(this VkPhysicalDeviceCornerSampledImageFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceCornerSampledImageFeaturesNV>(i);
        public static ManagedPtr<VkPhysicalDeviceCornerSampledImageFeaturesNV[]> Pointer(this VkPhysicalDeviceCornerSampledImageFeaturesNV[] i) => new ManagedPtr<VkPhysicalDeviceCornerSampledImageFeaturesNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExternalImageFormatPropertiesNV {
			[FieldOffset(0)]public VkImageFormatProperties imageFormatProperties;
			[FieldOffset(32)]public uint externalMemoryFeatures;
			[FieldOffset(36)]public uint exportFromImportedHandleTypes;
			[FieldOffset(40)]public uint compatibleHandleTypes;
		}

        public static ManagedPtr<VkExternalImageFormatPropertiesNV> Pointer(this VkExternalImageFormatPropertiesNV i) => new ManagedPtr<VkExternalImageFormatPropertiesNV>(i);
        public static ManagedPtr<VkExternalImageFormatPropertiesNV[]> Pointer(this VkExternalImageFormatPropertiesNV[] i) => new ManagedPtr<VkExternalImageFormatPropertiesNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExternalMemoryImageCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint handleTypes;
		}

        public static ManagedPtr<VkExternalMemoryImageCreateInfoNV> Pointer(this VkExternalMemoryImageCreateInfoNV i) => new ManagedPtr<VkExternalMemoryImageCreateInfoNV>(i);
        public static ManagedPtr<VkExternalMemoryImageCreateInfoNV[]> Pointer(this VkExternalMemoryImageCreateInfoNV[] i) => new ManagedPtr<VkExternalMemoryImageCreateInfoNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExportMemoryAllocateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint handleTypes;
		}

        public static ManagedPtr<VkExportMemoryAllocateInfoNV> Pointer(this VkExportMemoryAllocateInfoNV i) => new ManagedPtr<VkExportMemoryAllocateInfoNV>(i);
        public static ManagedPtr<VkExportMemoryAllocateInfoNV[]> Pointer(this VkExportMemoryAllocateInfoNV[] i) => new ManagedPtr<VkExportMemoryAllocateInfoNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkValidationFlagsEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint disabledValidationCheckCount;
			[FieldOffset(24)]public VkValidationCheckEXT* pDisabledValidationChecks;
		}

        public static ManagedPtr<VkValidationFlagsEXT> Pointer(this VkValidationFlagsEXT i) => new ManagedPtr<VkValidationFlagsEXT>(i);
        public static ManagedPtr<VkValidationFlagsEXT[]> Pointer(this VkValidationFlagsEXT[] i) => new ManagedPtr<VkValidationFlagsEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint textureCompressionASTC_HDR;
		}

        public static ManagedPtr<VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT> Pointer(this VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT[]> Pointer(this VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT[] i) => new ManagedPtr<VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageViewASTCDecodeModeEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkFormat decodeMode;
		}

        public static ManagedPtr<VkImageViewASTCDecodeModeEXT> Pointer(this VkImageViewASTCDecodeModeEXT i) => new ManagedPtr<VkImageViewASTCDecodeModeEXT>(i);
        public static ManagedPtr<VkImageViewASTCDecodeModeEXT[]> Pointer(this VkImageViewASTCDecodeModeEXT[] i) => new ManagedPtr<VkImageViewASTCDecodeModeEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceASTCDecodeFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint decodeModeSharedExponent;
		}

        public static ManagedPtr<VkPhysicalDeviceASTCDecodeFeaturesEXT> Pointer(this VkPhysicalDeviceASTCDecodeFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceASTCDecodeFeaturesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceASTCDecodeFeaturesEXT[]> Pointer(this VkPhysicalDeviceASTCDecodeFeaturesEXT[] i) => new ManagedPtr<VkPhysicalDeviceASTCDecodeFeaturesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkConditionalRenderingBeginInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr buffer;
			[FieldOffset(24)]public ulong offset;
			[FieldOffset(32)]public uint flags;
		}

        public static ManagedPtr<VkConditionalRenderingBeginInfoEXT> Pointer(this VkConditionalRenderingBeginInfoEXT i) => new ManagedPtr<VkConditionalRenderingBeginInfoEXT>(i);
        public static ManagedPtr<VkConditionalRenderingBeginInfoEXT[]> Pointer(this VkConditionalRenderingBeginInfoEXT[] i) => new ManagedPtr<VkConditionalRenderingBeginInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceConditionalRenderingFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint conditionalRendering;
			[FieldOffset(20)]public uint inheritedConditionalRendering;
		}

        public static ManagedPtr<VkPhysicalDeviceConditionalRenderingFeaturesEXT> Pointer(this VkPhysicalDeviceConditionalRenderingFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceConditionalRenderingFeaturesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceConditionalRenderingFeaturesEXT[]> Pointer(this VkPhysicalDeviceConditionalRenderingFeaturesEXT[] i) => new ManagedPtr<VkPhysicalDeviceConditionalRenderingFeaturesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkCommandBufferInheritanceConditionalRenderingInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint conditionalRenderingEnable;
		}

        public static ManagedPtr<VkCommandBufferInheritanceConditionalRenderingInfoEXT> Pointer(this VkCommandBufferInheritanceConditionalRenderingInfoEXT i) => new ManagedPtr<VkCommandBufferInheritanceConditionalRenderingInfoEXT>(i);
        public static ManagedPtr<VkCommandBufferInheritanceConditionalRenderingInfoEXT[]> Pointer(this VkCommandBufferInheritanceConditionalRenderingInfoEXT[] i) => new ManagedPtr<VkCommandBufferInheritanceConditionalRenderingInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceGeneratedCommandsFeaturesNVX {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint computeBindingPointSupport;
		}

        public static ManagedPtr<VkDeviceGeneratedCommandsFeaturesNVX> Pointer(this VkDeviceGeneratedCommandsFeaturesNVX i) => new ManagedPtr<VkDeviceGeneratedCommandsFeaturesNVX>(i);
        public static ManagedPtr<VkDeviceGeneratedCommandsFeaturesNVX[]> Pointer(this VkDeviceGeneratedCommandsFeaturesNVX[] i) => new ManagedPtr<VkDeviceGeneratedCommandsFeaturesNVX[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceGeneratedCommandsLimitsNVX {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint maxIndirectCommandsLayoutTokenCount;
			[FieldOffset(20)]public uint maxObjectEntryCounts;
			[FieldOffset(24)]public uint minSequenceCountBufferOffsetAlignment;
			[FieldOffset(28)]public uint minSequenceIndexBufferOffsetAlignment;
			[FieldOffset(32)]public uint minCommandsTokenBufferOffsetAlignment;
		}

        public static ManagedPtr<VkDeviceGeneratedCommandsLimitsNVX> Pointer(this VkDeviceGeneratedCommandsLimitsNVX i) => new ManagedPtr<VkDeviceGeneratedCommandsLimitsNVX>(i);
        public static ManagedPtr<VkDeviceGeneratedCommandsLimitsNVX[]> Pointer(this VkDeviceGeneratedCommandsLimitsNVX[] i) => new ManagedPtr<VkDeviceGeneratedCommandsLimitsNVX[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkIndirectCommandsTokenNVX {
			[FieldOffset(0)]public VkIndirectCommandsTokenTypeNVX tokenType;
			[FieldOffset(8)]public IntPtr buffer;
			[FieldOffset(16)]public ulong offset;
		}

        public static ManagedPtr<VkIndirectCommandsTokenNVX> Pointer(this VkIndirectCommandsTokenNVX i) => new ManagedPtr<VkIndirectCommandsTokenNVX>(i);
        public static ManagedPtr<VkIndirectCommandsTokenNVX[]> Pointer(this VkIndirectCommandsTokenNVX[] i) => new ManagedPtr<VkIndirectCommandsTokenNVX[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkIndirectCommandsLayoutTokenNVX {
			[FieldOffset(0)]public VkIndirectCommandsTokenTypeNVX tokenType;
			[FieldOffset(4)]public uint bindingUnit;
			[FieldOffset(8)]public uint dynamicCount;
			[FieldOffset(12)]public uint divisor;
		}

        public static ManagedPtr<VkIndirectCommandsLayoutTokenNVX> Pointer(this VkIndirectCommandsLayoutTokenNVX i) => new ManagedPtr<VkIndirectCommandsLayoutTokenNVX>(i);
        public static ManagedPtr<VkIndirectCommandsLayoutTokenNVX[]> Pointer(this VkIndirectCommandsLayoutTokenNVX[] i) => new ManagedPtr<VkIndirectCommandsLayoutTokenNVX[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkIndirectCommandsLayoutCreateInfoNVX {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPipelineBindPoint pipelineBindPoint;
			[FieldOffset(20)]public uint flags;
			[FieldOffset(24)]public uint tokenCount;
			[FieldOffset(32)]public IntPtr pTokens;
		}

        public static ManagedPtr<VkIndirectCommandsLayoutCreateInfoNVX> Pointer(this VkIndirectCommandsLayoutCreateInfoNVX i) => new ManagedPtr<VkIndirectCommandsLayoutCreateInfoNVX>(i);
        public static ManagedPtr<VkIndirectCommandsLayoutCreateInfoNVX[]> Pointer(this VkIndirectCommandsLayoutCreateInfoNVX[] i) => new ManagedPtr<VkIndirectCommandsLayoutCreateInfoNVX[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkCmdProcessCommandsInfoNVX {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr objectTable;
			[FieldOffset(24)]public IntPtr indirectCommandsLayout;
			[FieldOffset(32)]public uint indirectCommandsTokenCount;
			[FieldOffset(40)]public IntPtr pIndirectCommandsTokens;
			[FieldOffset(48)]public uint maxSequencesCount;
			[FieldOffset(56)]public IntPtr targetCommandBuffer;
			[FieldOffset(64)]public IntPtr sequencesCountBuffer;
			[FieldOffset(72)]public ulong sequencesCountOffset;
			[FieldOffset(80)]public IntPtr sequencesIndexBuffer;
			[FieldOffset(88)]public ulong sequencesIndexOffset;
		}

        public static ManagedPtr<VkCmdProcessCommandsInfoNVX> Pointer(this VkCmdProcessCommandsInfoNVX i) => new ManagedPtr<VkCmdProcessCommandsInfoNVX>(i);
        public static ManagedPtr<VkCmdProcessCommandsInfoNVX[]> Pointer(this VkCmdProcessCommandsInfoNVX[] i) => new ManagedPtr<VkCmdProcessCommandsInfoNVX[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkCmdReserveSpaceForCommandsInfoNVX {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr objectTable;
			[FieldOffset(24)]public IntPtr indirectCommandsLayout;
			[FieldOffset(32)]public uint maxSequencesCount;
		}

        public static ManagedPtr<VkCmdReserveSpaceForCommandsInfoNVX> Pointer(this VkCmdReserveSpaceForCommandsInfoNVX i) => new ManagedPtr<VkCmdReserveSpaceForCommandsInfoNVX>(i);
        public static ManagedPtr<VkCmdReserveSpaceForCommandsInfoNVX[]> Pointer(this VkCmdReserveSpaceForCommandsInfoNVX[] i) => new ManagedPtr<VkCmdReserveSpaceForCommandsInfoNVX[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkObjectTableCreateInfoNVX {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint objectCount;
			[FieldOffset(24)]public VkObjectEntryTypeNVX* pObjectEntryTypes;
			[FieldOffset(32)]public uint* pObjectEntryCounts;
			[FieldOffset(40)]public uint* pObjectEntryUsageFlags;
			[FieldOffset(48)]public uint maxUniformBuffersPerDescriptor;
			[FieldOffset(52)]public uint maxStorageBuffersPerDescriptor;
			[FieldOffset(56)]public uint maxStorageImagesPerDescriptor;
			[FieldOffset(60)]public uint maxSampledImagesPerDescriptor;
			[FieldOffset(64)]public uint maxPipelineLayouts;
		}

        public static ManagedPtr<VkObjectTableCreateInfoNVX> Pointer(this VkObjectTableCreateInfoNVX i) => new ManagedPtr<VkObjectTableCreateInfoNVX>(i);
        public static ManagedPtr<VkObjectTableCreateInfoNVX[]> Pointer(this VkObjectTableCreateInfoNVX[] i) => new ManagedPtr<VkObjectTableCreateInfoNVX[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkObjectTableEntryNVX {
			[FieldOffset(0)]public VkObjectEntryTypeNVX type;
			[FieldOffset(4)]public uint flags;
		}

        public static ManagedPtr<VkObjectTableEntryNVX> Pointer(this VkObjectTableEntryNVX i) => new ManagedPtr<VkObjectTableEntryNVX>(i);
        public static ManagedPtr<VkObjectTableEntryNVX[]> Pointer(this VkObjectTableEntryNVX[] i) => new ManagedPtr<VkObjectTableEntryNVX[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkObjectTablePipelineEntryNVX {
			[FieldOffset(0)]public VkObjectEntryTypeNVX type;
			[FieldOffset(4)]public uint flags;
			[FieldOffset(8)]public IntPtr pipeline;
		}

        public static ManagedPtr<VkObjectTablePipelineEntryNVX> Pointer(this VkObjectTablePipelineEntryNVX i) => new ManagedPtr<VkObjectTablePipelineEntryNVX>(i);
        public static ManagedPtr<VkObjectTablePipelineEntryNVX[]> Pointer(this VkObjectTablePipelineEntryNVX[] i) => new ManagedPtr<VkObjectTablePipelineEntryNVX[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkObjectTableDescriptorSetEntryNVX {
			[FieldOffset(0)]public VkObjectEntryTypeNVX type;
			[FieldOffset(4)]public uint flags;
			[FieldOffset(8)]public IntPtr pipelineLayout;
			[FieldOffset(16)]public IntPtr descriptorSet;
		}

        public static ManagedPtr<VkObjectTableDescriptorSetEntryNVX> Pointer(this VkObjectTableDescriptorSetEntryNVX i) => new ManagedPtr<VkObjectTableDescriptorSetEntryNVX>(i);
        public static ManagedPtr<VkObjectTableDescriptorSetEntryNVX[]> Pointer(this VkObjectTableDescriptorSetEntryNVX[] i) => new ManagedPtr<VkObjectTableDescriptorSetEntryNVX[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkObjectTableVertexBufferEntryNVX {
			[FieldOffset(0)]public VkObjectEntryTypeNVX type;
			[FieldOffset(4)]public uint flags;
			[FieldOffset(8)]public IntPtr buffer;
		}

        public static ManagedPtr<VkObjectTableVertexBufferEntryNVX> Pointer(this VkObjectTableVertexBufferEntryNVX i) => new ManagedPtr<VkObjectTableVertexBufferEntryNVX>(i);
        public static ManagedPtr<VkObjectTableVertexBufferEntryNVX[]> Pointer(this VkObjectTableVertexBufferEntryNVX[] i) => new ManagedPtr<VkObjectTableVertexBufferEntryNVX[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkObjectTableIndexBufferEntryNVX {
			[FieldOffset(0)]public VkObjectEntryTypeNVX type;
			[FieldOffset(4)]public uint flags;
			[FieldOffset(8)]public IntPtr buffer;
			[FieldOffset(16)]public VkIndexType indexType;
		}

        public static ManagedPtr<VkObjectTableIndexBufferEntryNVX> Pointer(this VkObjectTableIndexBufferEntryNVX i) => new ManagedPtr<VkObjectTableIndexBufferEntryNVX>(i);
        public static ManagedPtr<VkObjectTableIndexBufferEntryNVX[]> Pointer(this VkObjectTableIndexBufferEntryNVX[] i) => new ManagedPtr<VkObjectTableIndexBufferEntryNVX[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkObjectTablePushConstantEntryNVX {
			[FieldOffset(0)]public VkObjectEntryTypeNVX type;
			[FieldOffset(4)]public uint flags;
			[FieldOffset(8)]public IntPtr pipelineLayout;
			[FieldOffset(16)]public uint stageFlags;
		}

        public static ManagedPtr<VkObjectTablePushConstantEntryNVX> Pointer(this VkObjectTablePushConstantEntryNVX i) => new ManagedPtr<VkObjectTablePushConstantEntryNVX>(i);
        public static ManagedPtr<VkObjectTablePushConstantEntryNVX[]> Pointer(this VkObjectTablePushConstantEntryNVX[] i) => new ManagedPtr<VkObjectTablePushConstantEntryNVX[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkViewportWScalingNV {
			[FieldOffset(0)]public float xcoeff;
			[FieldOffset(4)]public float ycoeff;
		}

        public static ManagedPtr<VkViewportWScalingNV> Pointer(this VkViewportWScalingNV i) => new ManagedPtr<VkViewportWScalingNV>(i);
        public static ManagedPtr<VkViewportWScalingNV[]> Pointer(this VkViewportWScalingNV[] i) => new ManagedPtr<VkViewportWScalingNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineViewportWScalingStateCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint viewportWScalingEnable;
			[FieldOffset(20)]public uint viewportCount;
			[FieldOffset(24)]public IntPtr pViewportWScalings;
		}

        public static ManagedPtr<VkPipelineViewportWScalingStateCreateInfoNV> Pointer(this VkPipelineViewportWScalingStateCreateInfoNV i) => new ManagedPtr<VkPipelineViewportWScalingStateCreateInfoNV>(i);
        public static ManagedPtr<VkPipelineViewportWScalingStateCreateInfoNV[]> Pointer(this VkPipelineViewportWScalingStateCreateInfoNV[] i) => new ManagedPtr<VkPipelineViewportWScalingStateCreateInfoNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSurfaceCapabilities2EXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint minImageCount;
			[FieldOffset(20)]public uint maxImageCount;
			[FieldOffset(24)]public VkExtent2D currentExtent;
			[FieldOffset(32)]public VkExtent2D minImageExtent;
			[FieldOffset(40)]public VkExtent2D maxImageExtent;
			[FieldOffset(48)]public uint maxImageArrayLayers;
			[FieldOffset(52)]public uint supportedTransforms;
			[FieldOffset(56)]public VkSurfaceTransformFlagBitsKHR currentTransform;
			[FieldOffset(60)]public uint supportedCompositeAlpha;
			[FieldOffset(64)]public uint supportedUsageFlags;
			[FieldOffset(68)]public uint supportedSurfaceCounters;
		}

        public static ManagedPtr<VkSurfaceCapabilities2EXT> Pointer(this VkSurfaceCapabilities2EXT i) => new ManagedPtr<VkSurfaceCapabilities2EXT>(i);
        public static ManagedPtr<VkSurfaceCapabilities2EXT[]> Pointer(this VkSurfaceCapabilities2EXT[] i) => new ManagedPtr<VkSurfaceCapabilities2EXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayPowerInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDisplayPowerStateEXT powerState;
		}

        public static ManagedPtr<VkDisplayPowerInfoEXT> Pointer(this VkDisplayPowerInfoEXT i) => new ManagedPtr<VkDisplayPowerInfoEXT>(i);
        public static ManagedPtr<VkDisplayPowerInfoEXT[]> Pointer(this VkDisplayPowerInfoEXT[] i) => new ManagedPtr<VkDisplayPowerInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceEventInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDeviceEventTypeEXT deviceEvent;
		}

        public static ManagedPtr<VkDeviceEventInfoEXT> Pointer(this VkDeviceEventInfoEXT i) => new ManagedPtr<VkDeviceEventInfoEXT>(i);
        public static ManagedPtr<VkDeviceEventInfoEXT[]> Pointer(this VkDeviceEventInfoEXT[] i) => new ManagedPtr<VkDeviceEventInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayEventInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDisplayEventTypeEXT displayEvent;
		}

        public static ManagedPtr<VkDisplayEventInfoEXT> Pointer(this VkDisplayEventInfoEXT i) => new ManagedPtr<VkDisplayEventInfoEXT>(i);
        public static ManagedPtr<VkDisplayEventInfoEXT[]> Pointer(this VkDisplayEventInfoEXT[] i) => new ManagedPtr<VkDisplayEventInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSwapchainCounterCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint surfaceCounters;
		}

        public static ManagedPtr<VkSwapchainCounterCreateInfoEXT> Pointer(this VkSwapchainCounterCreateInfoEXT i) => new ManagedPtr<VkSwapchainCounterCreateInfoEXT>(i);
        public static ManagedPtr<VkSwapchainCounterCreateInfoEXT[]> Pointer(this VkSwapchainCounterCreateInfoEXT[] i) => new ManagedPtr<VkSwapchainCounterCreateInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRefreshCycleDurationGOOGLE {
			[FieldOffset(0)]public ulong refreshDuration;
		}

        public static ManagedPtr<VkRefreshCycleDurationGOOGLE> Pointer(this VkRefreshCycleDurationGOOGLE i) => new ManagedPtr<VkRefreshCycleDurationGOOGLE>(i);
        public static ManagedPtr<VkRefreshCycleDurationGOOGLE[]> Pointer(this VkRefreshCycleDurationGOOGLE[] i) => new ManagedPtr<VkRefreshCycleDurationGOOGLE[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPastPresentationTimingGOOGLE {
			[FieldOffset(0)]public uint presentID;
			[FieldOffset(8)]public ulong desiredPresentTime;
			[FieldOffset(16)]public ulong actualPresentTime;
			[FieldOffset(24)]public ulong earliestPresentTime;
			[FieldOffset(32)]public ulong presentMargin;
		}

        public static ManagedPtr<VkPastPresentationTimingGOOGLE> Pointer(this VkPastPresentationTimingGOOGLE i) => new ManagedPtr<VkPastPresentationTimingGOOGLE>(i);
        public static ManagedPtr<VkPastPresentationTimingGOOGLE[]> Pointer(this VkPastPresentationTimingGOOGLE[] i) => new ManagedPtr<VkPastPresentationTimingGOOGLE[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPresentTimeGOOGLE {
			[FieldOffset(0)]public uint presentID;
			[FieldOffset(8)]public ulong desiredPresentTime;
		}

        public static ManagedPtr<VkPresentTimeGOOGLE> Pointer(this VkPresentTimeGOOGLE i) => new ManagedPtr<VkPresentTimeGOOGLE>(i);
        public static ManagedPtr<VkPresentTimeGOOGLE[]> Pointer(this VkPresentTimeGOOGLE[] i) => new ManagedPtr<VkPresentTimeGOOGLE[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPresentTimesInfoGOOGLE {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint swapchainCount;
			[FieldOffset(24)]public IntPtr pTimes;
		}

        public static ManagedPtr<VkPresentTimesInfoGOOGLE> Pointer(this VkPresentTimesInfoGOOGLE i) => new ManagedPtr<VkPresentTimesInfoGOOGLE>(i);
        public static ManagedPtr<VkPresentTimesInfoGOOGLE[]> Pointer(this VkPresentTimesInfoGOOGLE[] i) => new ManagedPtr<VkPresentTimesInfoGOOGLE[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint perViewPositionAllComponents;
		}

        public static ManagedPtr<VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX> Pointer(this VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX i) => new ManagedPtr<VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX>(i);
        public static ManagedPtr<VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX[]> Pointer(this VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX[] i) => new ManagedPtr<VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkViewportSwizzleNV {
			[FieldOffset(0)]public VkViewportCoordinateSwizzleNV x;
			[FieldOffset(4)]public VkViewportCoordinateSwizzleNV y;
			[FieldOffset(8)]public VkViewportCoordinateSwizzleNV z;
			[FieldOffset(12)]public VkViewportCoordinateSwizzleNV w;
		}

        public static ManagedPtr<VkViewportSwizzleNV> Pointer(this VkViewportSwizzleNV i) => new ManagedPtr<VkViewportSwizzleNV>(i);
        public static ManagedPtr<VkViewportSwizzleNV[]> Pointer(this VkViewportSwizzleNV[] i) => new ManagedPtr<VkViewportSwizzleNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineViewportSwizzleStateCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint viewportCount;
			[FieldOffset(24)]public IntPtr pViewportSwizzles;
		}

        public static ManagedPtr<VkPipelineViewportSwizzleStateCreateInfoNV> Pointer(this VkPipelineViewportSwizzleStateCreateInfoNV i) => new ManagedPtr<VkPipelineViewportSwizzleStateCreateInfoNV>(i);
        public static ManagedPtr<VkPipelineViewportSwizzleStateCreateInfoNV[]> Pointer(this VkPipelineViewportSwizzleStateCreateInfoNV[] i) => new ManagedPtr<VkPipelineViewportSwizzleStateCreateInfoNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceDiscardRectanglePropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint maxDiscardRectangles;
		}

        public static ManagedPtr<VkPhysicalDeviceDiscardRectanglePropertiesEXT> Pointer(this VkPhysicalDeviceDiscardRectanglePropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceDiscardRectanglePropertiesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceDiscardRectanglePropertiesEXT[]> Pointer(this VkPhysicalDeviceDiscardRectanglePropertiesEXT[] i) => new ManagedPtr<VkPhysicalDeviceDiscardRectanglePropertiesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineDiscardRectangleStateCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public VkDiscardRectangleModeEXT discardRectangleMode;
			[FieldOffset(24)]public uint discardRectangleCount;
			[FieldOffset(32)]public IntPtr pDiscardRectangles;
		}

        public static ManagedPtr<VkPipelineDiscardRectangleStateCreateInfoEXT> Pointer(this VkPipelineDiscardRectangleStateCreateInfoEXT i) => new ManagedPtr<VkPipelineDiscardRectangleStateCreateInfoEXT>(i);
        public static ManagedPtr<VkPipelineDiscardRectangleStateCreateInfoEXT[]> Pointer(this VkPipelineDiscardRectangleStateCreateInfoEXT[] i) => new ManagedPtr<VkPipelineDiscardRectangleStateCreateInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public float primitiveOverestimationSize;
			[FieldOffset(20)]public float maxExtraPrimitiveOverestimationSize;
			[FieldOffset(24)]public float extraPrimitiveOverestimationSizeGranularity;
			[FieldOffset(28)]public uint primitiveUnderestimation;
			[FieldOffset(32)]public uint conservativePointAndLineRasterization;
			[FieldOffset(36)]public uint degenerateTrianglesRasterized;
			[FieldOffset(40)]public uint degenerateLinesRasterized;
			[FieldOffset(44)]public uint fullyCoveredFragmentShaderInputVariable;
			[FieldOffset(48)]public uint conservativeRasterizationPostDepthCoverage;
		}

        public static ManagedPtr<VkPhysicalDeviceConservativeRasterizationPropertiesEXT> Pointer(this VkPhysicalDeviceConservativeRasterizationPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceConservativeRasterizationPropertiesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceConservativeRasterizationPropertiesEXT[]> Pointer(this VkPhysicalDeviceConservativeRasterizationPropertiesEXT[] i) => new ManagedPtr<VkPhysicalDeviceConservativeRasterizationPropertiesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineRasterizationConservativeStateCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public VkConservativeRasterizationModeEXT conservativeRasterizationMode;
			[FieldOffset(24)]public float extraPrimitiveOverestimationSize;
		}

        public static ManagedPtr<VkPipelineRasterizationConservativeStateCreateInfoEXT> Pointer(this VkPipelineRasterizationConservativeStateCreateInfoEXT i) => new ManagedPtr<VkPipelineRasterizationConservativeStateCreateInfoEXT>(i);
        public static ManagedPtr<VkPipelineRasterizationConservativeStateCreateInfoEXT[]> Pointer(this VkPipelineRasterizationConservativeStateCreateInfoEXT[] i) => new ManagedPtr<VkPipelineRasterizationConservativeStateCreateInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceDepthClipEnableFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint depthClipEnable;
		}

        public static ManagedPtr<VkPhysicalDeviceDepthClipEnableFeaturesEXT> Pointer(this VkPhysicalDeviceDepthClipEnableFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceDepthClipEnableFeaturesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceDepthClipEnableFeaturesEXT[]> Pointer(this VkPhysicalDeviceDepthClipEnableFeaturesEXT[] i) => new ManagedPtr<VkPhysicalDeviceDepthClipEnableFeaturesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineRasterizationDepthClipStateCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint depthClipEnable;
		}

        public static ManagedPtr<VkPipelineRasterizationDepthClipStateCreateInfoEXT> Pointer(this VkPipelineRasterizationDepthClipStateCreateInfoEXT i) => new ManagedPtr<VkPipelineRasterizationDepthClipStateCreateInfoEXT>(i);
        public static ManagedPtr<VkPipelineRasterizationDepthClipStateCreateInfoEXT[]> Pointer(this VkPipelineRasterizationDepthClipStateCreateInfoEXT[] i) => new ManagedPtr<VkPipelineRasterizationDepthClipStateCreateInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkXYColorEXT {
			[FieldOffset(0)]public float x;
			[FieldOffset(4)]public float y;
		}

        public static ManagedPtr<VkXYColorEXT> Pointer(this VkXYColorEXT i) => new ManagedPtr<VkXYColorEXT>(i);
        public static ManagedPtr<VkXYColorEXT[]> Pointer(this VkXYColorEXT[] i) => new ManagedPtr<VkXYColorEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkHdrMetadataEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkXYColorEXT displayPrimaryRed;
			[FieldOffset(24)]public VkXYColorEXT displayPrimaryGreen;
			[FieldOffset(32)]public VkXYColorEXT displayPrimaryBlue;
			[FieldOffset(40)]public VkXYColorEXT whitePoint;
			[FieldOffset(48)]public float maxLuminance;
			[FieldOffset(52)]public float minLuminance;
			[FieldOffset(56)]public float maxContentLightLevel;
			[FieldOffset(60)]public float maxFrameAverageLightLevel;
		}

        public static ManagedPtr<VkHdrMetadataEXT> Pointer(this VkHdrMetadataEXT i) => new ManagedPtr<VkHdrMetadataEXT>(i);
        public static ManagedPtr<VkHdrMetadataEXT[]> Pointer(this VkHdrMetadataEXT[] i) => new ManagedPtr<VkHdrMetadataEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDebugUtilsObjectNameInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkObjectType objectType;
			[FieldOffset(24)]public ulong objectHandle;
			[FieldOffset(32)]public string pObjectName;
		}

        public static ManagedPtr<VkDebugUtilsObjectNameInfoEXT> Pointer(this VkDebugUtilsObjectNameInfoEXT i) => new ManagedPtr<VkDebugUtilsObjectNameInfoEXT>(i);
        public static ManagedPtr<VkDebugUtilsObjectNameInfoEXT[]> Pointer(this VkDebugUtilsObjectNameInfoEXT[] i) => new ManagedPtr<VkDebugUtilsObjectNameInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDebugUtilsObjectTagInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkObjectType objectType;
			[FieldOffset(24)]public ulong objectHandle;
			[FieldOffset(32)]public ulong tagName;
			[FieldOffset(40)]public ulong tagSize;
			[FieldOffset(48)]public IntPtr pTag;
		}

        public static ManagedPtr<VkDebugUtilsObjectTagInfoEXT> Pointer(this VkDebugUtilsObjectTagInfoEXT i) => new ManagedPtr<VkDebugUtilsObjectTagInfoEXT>(i);
        public static ManagedPtr<VkDebugUtilsObjectTagInfoEXT[]> Pointer(this VkDebugUtilsObjectTagInfoEXT[] i) => new ManagedPtr<VkDebugUtilsObjectTagInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDebugUtilsLabelEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public string pLabelName;
			[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray, SizeConst=4)] public float[] color;
		}

        public static ManagedPtr<VkDebugUtilsLabelEXT> Pointer(this VkDebugUtilsLabelEXT i) => new ManagedPtr<VkDebugUtilsLabelEXT>(i);
        public static ManagedPtr<VkDebugUtilsLabelEXT[]> Pointer(this VkDebugUtilsLabelEXT[] i) => new ManagedPtr<VkDebugUtilsLabelEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDebugUtilsMessengerCallbackDataEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(24)]public string pMessageIdName;
			[FieldOffset(32)]public int messageIdNumber;
			[FieldOffset(40)]public string pMessage;
			[FieldOffset(48)]public uint queueLabelCount;
			[FieldOffset(56)]public IntPtr pQueueLabels;
			[FieldOffset(64)]public uint cmdBufLabelCount;
			[FieldOffset(72)]public IntPtr pCmdBufLabels;
			[FieldOffset(80)]public uint objectCount;
			[FieldOffset(88)]public IntPtr pObjects;
		}

        public static ManagedPtr<VkDebugUtilsMessengerCallbackDataEXT> Pointer(this VkDebugUtilsMessengerCallbackDataEXT i) => new ManagedPtr<VkDebugUtilsMessengerCallbackDataEXT>(i);
        public static ManagedPtr<VkDebugUtilsMessengerCallbackDataEXT[]> Pointer(this VkDebugUtilsMessengerCallbackDataEXT[] i) => new ManagedPtr<VkDebugUtilsMessengerCallbackDataEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDebugUtilsMessengerCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint messageSeverity;
			[FieldOffset(24)]public uint messageType;
			[FieldOffset(32)]public IntPtr pfnUserCallback;
			[FieldOffset(40)]public IntPtr pUserData;
		}

        public static ManagedPtr<VkDebugUtilsMessengerCreateInfoEXT> Pointer(this VkDebugUtilsMessengerCreateInfoEXT i) => new ManagedPtr<VkDebugUtilsMessengerCreateInfoEXT>(i);
        public static ManagedPtr<VkDebugUtilsMessengerCreateInfoEXT[]> Pointer(this VkDebugUtilsMessengerCreateInfoEXT[] i) => new ManagedPtr<VkDebugUtilsMessengerCreateInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceInlineUniformBlockFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint inlineUniformBlock;
			[FieldOffset(20)]public uint descriptorBindingInlineUniformBlockUpdateAfterBind;
		}

        public static ManagedPtr<VkPhysicalDeviceInlineUniformBlockFeaturesEXT> Pointer(this VkPhysicalDeviceInlineUniformBlockFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceInlineUniformBlockFeaturesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceInlineUniformBlockFeaturesEXT[]> Pointer(this VkPhysicalDeviceInlineUniformBlockFeaturesEXT[] i) => new ManagedPtr<VkPhysicalDeviceInlineUniformBlockFeaturesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceInlineUniformBlockPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint maxInlineUniformBlockSize;
			[FieldOffset(20)]public uint maxPerStageDescriptorInlineUniformBlocks;
			[FieldOffset(24)]public uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
			[FieldOffset(28)]public uint maxDescriptorSetInlineUniformBlocks;
			[FieldOffset(32)]public uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
		}

        public static ManagedPtr<VkPhysicalDeviceInlineUniformBlockPropertiesEXT> Pointer(this VkPhysicalDeviceInlineUniformBlockPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceInlineUniformBlockPropertiesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceInlineUniformBlockPropertiesEXT[]> Pointer(this VkPhysicalDeviceInlineUniformBlockPropertiesEXT[] i) => new ManagedPtr<VkPhysicalDeviceInlineUniformBlockPropertiesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkWriteDescriptorSetInlineUniformBlockEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint dataSize;
			[FieldOffset(24)]public IntPtr pData;
		}

        public static ManagedPtr<VkWriteDescriptorSetInlineUniformBlockEXT> Pointer(this VkWriteDescriptorSetInlineUniformBlockEXT i) => new ManagedPtr<VkWriteDescriptorSetInlineUniformBlockEXT>(i);
        public static ManagedPtr<VkWriteDescriptorSetInlineUniformBlockEXT[]> Pointer(this VkWriteDescriptorSetInlineUniformBlockEXT[] i) => new ManagedPtr<VkWriteDescriptorSetInlineUniformBlockEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorPoolInlineUniformBlockCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint maxInlineUniformBlockBindings;
		}

        public static ManagedPtr<VkDescriptorPoolInlineUniformBlockCreateInfoEXT> Pointer(this VkDescriptorPoolInlineUniformBlockCreateInfoEXT i) => new ManagedPtr<VkDescriptorPoolInlineUniformBlockCreateInfoEXT>(i);
        public static ManagedPtr<VkDescriptorPoolInlineUniformBlockCreateInfoEXT[]> Pointer(this VkDescriptorPoolInlineUniformBlockCreateInfoEXT[] i) => new ManagedPtr<VkDescriptorPoolInlineUniformBlockCreateInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSampleLocationEXT {
			[FieldOffset(0)]public float x;
			[FieldOffset(4)]public float y;
		}

        public static ManagedPtr<VkSampleLocationEXT> Pointer(this VkSampleLocationEXT i) => new ManagedPtr<VkSampleLocationEXT>(i);
        public static ManagedPtr<VkSampleLocationEXT[]> Pointer(this VkSampleLocationEXT[] i) => new ManagedPtr<VkSampleLocationEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSampleLocationsInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkSampleCountFlagBits sampleLocationsPerPixel;
			[FieldOffset(24)]public VkExtent2D sampleLocationGridSize;
			[FieldOffset(32)]public uint sampleLocationsCount;
			[FieldOffset(40)]public IntPtr pSampleLocations;
		}

        public static ManagedPtr<VkSampleLocationsInfoEXT> Pointer(this VkSampleLocationsInfoEXT i) => new ManagedPtr<VkSampleLocationsInfoEXT>(i);
        public static ManagedPtr<VkSampleLocationsInfoEXT[]> Pointer(this VkSampleLocationsInfoEXT[] i) => new ManagedPtr<VkSampleLocationsInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAttachmentSampleLocationsEXT {
			[FieldOffset(0)]public uint attachmentIndex;
			[FieldOffset(48)]public VkSampleLocationsInfoEXT sampleLocationsInfo;
		}

        public static ManagedPtr<VkAttachmentSampleLocationsEXT> Pointer(this VkAttachmentSampleLocationsEXT i) => new ManagedPtr<VkAttachmentSampleLocationsEXT>(i);
        public static ManagedPtr<VkAttachmentSampleLocationsEXT[]> Pointer(this VkAttachmentSampleLocationsEXT[] i) => new ManagedPtr<VkAttachmentSampleLocationsEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSubpassSampleLocationsEXT {
			[FieldOffset(0)]public uint subpassIndex;
			[FieldOffset(48)]public VkSampleLocationsInfoEXT sampleLocationsInfo;
		}

        public static ManagedPtr<VkSubpassSampleLocationsEXT> Pointer(this VkSubpassSampleLocationsEXT i) => new ManagedPtr<VkSubpassSampleLocationsEXT>(i);
        public static ManagedPtr<VkSubpassSampleLocationsEXT[]> Pointer(this VkSubpassSampleLocationsEXT[] i) => new ManagedPtr<VkSubpassSampleLocationsEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRenderPassSampleLocationsBeginInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint attachmentInitialSampleLocationsCount;
			[FieldOffset(24)]public IntPtr pAttachmentInitialSampleLocations;
			[FieldOffset(32)]public uint postSubpassSampleLocationsCount;
			[FieldOffset(40)]public IntPtr pPostSubpassSampleLocations;
		}

        public static ManagedPtr<VkRenderPassSampleLocationsBeginInfoEXT> Pointer(this VkRenderPassSampleLocationsBeginInfoEXT i) => new ManagedPtr<VkRenderPassSampleLocationsBeginInfoEXT>(i);
        public static ManagedPtr<VkRenderPassSampleLocationsBeginInfoEXT[]> Pointer(this VkRenderPassSampleLocationsBeginInfoEXT[] i) => new ManagedPtr<VkRenderPassSampleLocationsBeginInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineSampleLocationsStateCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint sampleLocationsEnable;
			[FieldOffset(48)]public VkSampleLocationsInfoEXT sampleLocationsInfo;
		}

        public static ManagedPtr<VkPipelineSampleLocationsStateCreateInfoEXT> Pointer(this VkPipelineSampleLocationsStateCreateInfoEXT i) => new ManagedPtr<VkPipelineSampleLocationsStateCreateInfoEXT>(i);
        public static ManagedPtr<VkPipelineSampleLocationsStateCreateInfoEXT[]> Pointer(this VkPipelineSampleLocationsStateCreateInfoEXT[] i) => new ManagedPtr<VkPipelineSampleLocationsStateCreateInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceSampleLocationsPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint sampleLocationSampleCounts;
			[FieldOffset(24)]public VkExtent2D maxSampleLocationGridSize;
			[FieldOffset(32)][MarshalAs(UnmanagedType.ByValArray, SizeConst=2)] public float[] sampleLocationCoordinateRange;
			[FieldOffset(40)]public uint sampleLocationSubPixelBits;
			[FieldOffset(44)]public uint variableSampleLocations;
		}

        public static ManagedPtr<VkPhysicalDeviceSampleLocationsPropertiesEXT> Pointer(this VkPhysicalDeviceSampleLocationsPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceSampleLocationsPropertiesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceSampleLocationsPropertiesEXT[]> Pointer(this VkPhysicalDeviceSampleLocationsPropertiesEXT[] i) => new ManagedPtr<VkPhysicalDeviceSampleLocationsPropertiesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMultisamplePropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExtent2D maxSampleLocationGridSize;
		}

        public static ManagedPtr<VkMultisamplePropertiesEXT> Pointer(this VkMultisamplePropertiesEXT i) => new ManagedPtr<VkMultisamplePropertiesEXT>(i);
        public static ManagedPtr<VkMultisamplePropertiesEXT[]> Pointer(this VkMultisamplePropertiesEXT[] i) => new ManagedPtr<VkMultisamplePropertiesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint advancedBlendCoherentOperations;
		}

        public static ManagedPtr<VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT> Pointer(this VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT[]> Pointer(this VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT[] i) => new ManagedPtr<VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint advancedBlendMaxColorAttachments;
			[FieldOffset(20)]public uint advancedBlendIndependentBlend;
			[FieldOffset(24)]public uint advancedBlendNonPremultipliedSrcColor;
			[FieldOffset(28)]public uint advancedBlendNonPremultipliedDstColor;
			[FieldOffset(32)]public uint advancedBlendCorrelatedOverlap;
			[FieldOffset(36)]public uint advancedBlendAllOperations;
		}

        public static ManagedPtr<VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT> Pointer(this VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT[]> Pointer(this VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT[] i) => new ManagedPtr<VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineColorBlendAdvancedStateCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint srcPremultiplied;
			[FieldOffset(20)]public uint dstPremultiplied;
			[FieldOffset(24)]public VkBlendOverlapEXT blendOverlap;
		}

        public static ManagedPtr<VkPipelineColorBlendAdvancedStateCreateInfoEXT> Pointer(this VkPipelineColorBlendAdvancedStateCreateInfoEXT i) => new ManagedPtr<VkPipelineColorBlendAdvancedStateCreateInfoEXT>(i);
        public static ManagedPtr<VkPipelineColorBlendAdvancedStateCreateInfoEXT[]> Pointer(this VkPipelineColorBlendAdvancedStateCreateInfoEXT[] i) => new ManagedPtr<VkPipelineColorBlendAdvancedStateCreateInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineCoverageToColorStateCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint coverageToColorEnable;
			[FieldOffset(24)]public uint coverageToColorLocation;
		}

        public static ManagedPtr<VkPipelineCoverageToColorStateCreateInfoNV> Pointer(this VkPipelineCoverageToColorStateCreateInfoNV i) => new ManagedPtr<VkPipelineCoverageToColorStateCreateInfoNV>(i);
        public static ManagedPtr<VkPipelineCoverageToColorStateCreateInfoNV[]> Pointer(this VkPipelineCoverageToColorStateCreateInfoNV[] i) => new ManagedPtr<VkPipelineCoverageToColorStateCreateInfoNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineCoverageModulationStateCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public VkCoverageModulationModeNV coverageModulationMode;
			[FieldOffset(24)]public uint coverageModulationTableEnable;
			[FieldOffset(28)]public uint coverageModulationTableCount;
			[FieldOffset(32)]public float* pCoverageModulationTable;
		}

        public static ManagedPtr<VkPipelineCoverageModulationStateCreateInfoNV> Pointer(this VkPipelineCoverageModulationStateCreateInfoNV i) => new ManagedPtr<VkPipelineCoverageModulationStateCreateInfoNV>(i);
        public static ManagedPtr<VkPipelineCoverageModulationStateCreateInfoNV[]> Pointer(this VkPipelineCoverageModulationStateCreateInfoNV[] i) => new ManagedPtr<VkPipelineCoverageModulationStateCreateInfoNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShaderSMBuiltinsPropertiesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint shaderSMCount;
			[FieldOffset(20)]public uint shaderWarpsPerSM;
		}

        public static ManagedPtr<VkPhysicalDeviceShaderSMBuiltinsPropertiesNV> Pointer(this VkPhysicalDeviceShaderSMBuiltinsPropertiesNV i) => new ManagedPtr<VkPhysicalDeviceShaderSMBuiltinsPropertiesNV>(i);
        public static ManagedPtr<VkPhysicalDeviceShaderSMBuiltinsPropertiesNV[]> Pointer(this VkPhysicalDeviceShaderSMBuiltinsPropertiesNV[] i) => new ManagedPtr<VkPhysicalDeviceShaderSMBuiltinsPropertiesNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShaderSMBuiltinsFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint shaderSMBuiltins;
		}

        public static ManagedPtr<VkPhysicalDeviceShaderSMBuiltinsFeaturesNV> Pointer(this VkPhysicalDeviceShaderSMBuiltinsFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceShaderSMBuiltinsFeaturesNV>(i);
        public static ManagedPtr<VkPhysicalDeviceShaderSMBuiltinsFeaturesNV[]> Pointer(this VkPhysicalDeviceShaderSMBuiltinsFeaturesNV[] i) => new ManagedPtr<VkPhysicalDeviceShaderSMBuiltinsFeaturesNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDrmFormatModifierPropertiesEXT {
			[FieldOffset(0)]public ulong drmFormatModifier;
			[FieldOffset(8)]public uint drmFormatModifierPlaneCount;
			[FieldOffset(12)]public uint drmFormatModifierTilingFeatures;
		}

        public static ManagedPtr<VkDrmFormatModifierPropertiesEXT> Pointer(this VkDrmFormatModifierPropertiesEXT i) => new ManagedPtr<VkDrmFormatModifierPropertiesEXT>(i);
        public static ManagedPtr<VkDrmFormatModifierPropertiesEXT[]> Pointer(this VkDrmFormatModifierPropertiesEXT[] i) => new ManagedPtr<VkDrmFormatModifierPropertiesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDrmFormatModifierPropertiesListEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint drmFormatModifierCount;
			[FieldOffset(24)]public IntPtr pDrmFormatModifierProperties;
		}

        public static ManagedPtr<VkDrmFormatModifierPropertiesListEXT> Pointer(this VkDrmFormatModifierPropertiesListEXT i) => new ManagedPtr<VkDrmFormatModifierPropertiesListEXT>(i);
        public static ManagedPtr<VkDrmFormatModifierPropertiesListEXT[]> Pointer(this VkDrmFormatModifierPropertiesListEXT[] i) => new ManagedPtr<VkDrmFormatModifierPropertiesListEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong drmFormatModifier;
			[FieldOffset(24)]public VkSharingMode sharingMode;
			[FieldOffset(28)]public uint queueFamilyIndexCount;
			[FieldOffset(32)]public uint* pQueueFamilyIndices;
		}

        public static ManagedPtr<VkPhysicalDeviceImageDrmFormatModifierInfoEXT> Pointer(this VkPhysicalDeviceImageDrmFormatModifierInfoEXT i) => new ManagedPtr<VkPhysicalDeviceImageDrmFormatModifierInfoEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceImageDrmFormatModifierInfoEXT[]> Pointer(this VkPhysicalDeviceImageDrmFormatModifierInfoEXT[] i) => new ManagedPtr<VkPhysicalDeviceImageDrmFormatModifierInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageDrmFormatModifierListCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint drmFormatModifierCount;
			[FieldOffset(24)]public ulong* pDrmFormatModifiers;
		}

        public static ManagedPtr<VkImageDrmFormatModifierListCreateInfoEXT> Pointer(this VkImageDrmFormatModifierListCreateInfoEXT i) => new ManagedPtr<VkImageDrmFormatModifierListCreateInfoEXT>(i);
        public static ManagedPtr<VkImageDrmFormatModifierListCreateInfoEXT[]> Pointer(this VkImageDrmFormatModifierListCreateInfoEXT[] i) => new ManagedPtr<VkImageDrmFormatModifierListCreateInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageDrmFormatModifierExplicitCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong drmFormatModifier;
			[FieldOffset(24)]public uint drmFormatModifierPlaneCount;
			[FieldOffset(32)]public IntPtr pPlaneLayouts;
		}

        public static ManagedPtr<VkImageDrmFormatModifierExplicitCreateInfoEXT> Pointer(this VkImageDrmFormatModifierExplicitCreateInfoEXT i) => new ManagedPtr<VkImageDrmFormatModifierExplicitCreateInfoEXT>(i);
        public static ManagedPtr<VkImageDrmFormatModifierExplicitCreateInfoEXT[]> Pointer(this VkImageDrmFormatModifierExplicitCreateInfoEXT[] i) => new ManagedPtr<VkImageDrmFormatModifierExplicitCreateInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageDrmFormatModifierPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong drmFormatModifier;
		}

        public static ManagedPtr<VkImageDrmFormatModifierPropertiesEXT> Pointer(this VkImageDrmFormatModifierPropertiesEXT i) => new ManagedPtr<VkImageDrmFormatModifierPropertiesEXT>(i);
        public static ManagedPtr<VkImageDrmFormatModifierPropertiesEXT[]> Pointer(this VkImageDrmFormatModifierPropertiesEXT[] i) => new ManagedPtr<VkImageDrmFormatModifierPropertiesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkValidationCacheCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(24)]public ulong initialDataSize;
			[FieldOffset(32)]public IntPtr pInitialData;
		}

        public static ManagedPtr<VkValidationCacheCreateInfoEXT> Pointer(this VkValidationCacheCreateInfoEXT i) => new ManagedPtr<VkValidationCacheCreateInfoEXT>(i);
        public static ManagedPtr<VkValidationCacheCreateInfoEXT[]> Pointer(this VkValidationCacheCreateInfoEXT[] i) => new ManagedPtr<VkValidationCacheCreateInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkShaderModuleValidationCacheCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr validationCache;
		}

        public static ManagedPtr<VkShaderModuleValidationCacheCreateInfoEXT> Pointer(this VkShaderModuleValidationCacheCreateInfoEXT i) => new ManagedPtr<VkShaderModuleValidationCacheCreateInfoEXT>(i);
        public static ManagedPtr<VkShaderModuleValidationCacheCreateInfoEXT[]> Pointer(this VkShaderModuleValidationCacheCreateInfoEXT[] i) => new ManagedPtr<VkShaderModuleValidationCacheCreateInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkShadingRatePaletteNV {
			[FieldOffset(0)]public uint shadingRatePaletteEntryCount;
			[FieldOffset(8)]public VkShadingRatePaletteEntryNV* pShadingRatePaletteEntries;
		}

        public static ManagedPtr<VkShadingRatePaletteNV> Pointer(this VkShadingRatePaletteNV i) => new ManagedPtr<VkShadingRatePaletteNV>(i);
        public static ManagedPtr<VkShadingRatePaletteNV[]> Pointer(this VkShadingRatePaletteNV[] i) => new ManagedPtr<VkShadingRatePaletteNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineViewportShadingRateImageStateCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint shadingRateImageEnable;
			[FieldOffset(20)]public uint viewportCount;
			[FieldOffset(24)]public IntPtr pShadingRatePalettes;
		}

        public static ManagedPtr<VkPipelineViewportShadingRateImageStateCreateInfoNV> Pointer(this VkPipelineViewportShadingRateImageStateCreateInfoNV i) => new ManagedPtr<VkPipelineViewportShadingRateImageStateCreateInfoNV>(i);
        public static ManagedPtr<VkPipelineViewportShadingRateImageStateCreateInfoNV[]> Pointer(this VkPipelineViewportShadingRateImageStateCreateInfoNV[] i) => new ManagedPtr<VkPipelineViewportShadingRateImageStateCreateInfoNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShadingRateImageFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint shadingRateImage;
			[FieldOffset(20)]public uint shadingRateCoarseSampleOrder;
		}

        public static ManagedPtr<VkPhysicalDeviceShadingRateImageFeaturesNV> Pointer(this VkPhysicalDeviceShadingRateImageFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceShadingRateImageFeaturesNV>(i);
        public static ManagedPtr<VkPhysicalDeviceShadingRateImageFeaturesNV[]> Pointer(this VkPhysicalDeviceShadingRateImageFeaturesNV[] i) => new ManagedPtr<VkPhysicalDeviceShadingRateImageFeaturesNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShadingRateImagePropertiesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExtent2D shadingRateTexelSize;
			[FieldOffset(24)]public uint shadingRatePaletteSize;
			[FieldOffset(28)]public uint shadingRateMaxCoarseSamples;
		}

        public static ManagedPtr<VkPhysicalDeviceShadingRateImagePropertiesNV> Pointer(this VkPhysicalDeviceShadingRateImagePropertiesNV i) => new ManagedPtr<VkPhysicalDeviceShadingRateImagePropertiesNV>(i);
        public static ManagedPtr<VkPhysicalDeviceShadingRateImagePropertiesNV[]> Pointer(this VkPhysicalDeviceShadingRateImagePropertiesNV[] i) => new ManagedPtr<VkPhysicalDeviceShadingRateImagePropertiesNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkCoarseSampleLocationNV {
			[FieldOffset(0)]public uint pixelX;
			[FieldOffset(4)]public uint pixelY;
			[FieldOffset(8)]public uint sample;
		}

        public static ManagedPtr<VkCoarseSampleLocationNV> Pointer(this VkCoarseSampleLocationNV i) => new ManagedPtr<VkCoarseSampleLocationNV>(i);
        public static ManagedPtr<VkCoarseSampleLocationNV[]> Pointer(this VkCoarseSampleLocationNV[] i) => new ManagedPtr<VkCoarseSampleLocationNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkCoarseSampleOrderCustomNV {
			[FieldOffset(0)]public VkShadingRatePaletteEntryNV shadingRate;
			[FieldOffset(4)]public uint sampleCount;
			[FieldOffset(8)]public uint sampleLocationCount;
			[FieldOffset(16)]public IntPtr pSampleLocations;
		}

        public static ManagedPtr<VkCoarseSampleOrderCustomNV> Pointer(this VkCoarseSampleOrderCustomNV i) => new ManagedPtr<VkCoarseSampleOrderCustomNV>(i);
        public static ManagedPtr<VkCoarseSampleOrderCustomNV[]> Pointer(this VkCoarseSampleOrderCustomNV[] i) => new ManagedPtr<VkCoarseSampleOrderCustomNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkCoarseSampleOrderTypeNV sampleOrderType;
			[FieldOffset(20)]public uint customSampleOrderCount;
			[FieldOffset(24)]public IntPtr pCustomSampleOrders;
		}

        public static ManagedPtr<VkPipelineViewportCoarseSampleOrderStateCreateInfoNV> Pointer(this VkPipelineViewportCoarseSampleOrderStateCreateInfoNV i) => new ManagedPtr<VkPipelineViewportCoarseSampleOrderStateCreateInfoNV>(i);
        public static ManagedPtr<VkPipelineViewportCoarseSampleOrderStateCreateInfoNV[]> Pointer(this VkPipelineViewportCoarseSampleOrderStateCreateInfoNV[] i) => new ManagedPtr<VkPipelineViewportCoarseSampleOrderStateCreateInfoNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRayTracingShaderGroupCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkRayTracingShaderGroupTypeNV type;
			[FieldOffset(20)]public uint generalShader;
			[FieldOffset(24)]public uint closestHitShader;
			[FieldOffset(28)]public uint anyHitShader;
			[FieldOffset(32)]public uint intersectionShader;
		}

        public static ManagedPtr<VkRayTracingShaderGroupCreateInfoNV> Pointer(this VkRayTracingShaderGroupCreateInfoNV i) => new ManagedPtr<VkRayTracingShaderGroupCreateInfoNV>(i);
        public static ManagedPtr<VkRayTracingShaderGroupCreateInfoNV[]> Pointer(this VkRayTracingShaderGroupCreateInfoNV[] i) => new ManagedPtr<VkRayTracingShaderGroupCreateInfoNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRayTracingPipelineCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint stageCount;
			[FieldOffset(24)]public IntPtr pStages;
			[FieldOffset(32)]public uint groupCount;
			[FieldOffset(40)]public IntPtr pGroups;
			[FieldOffset(48)]public uint maxRecursionDepth;
			[FieldOffset(56)]public IntPtr layout;
			[FieldOffset(64)]public IntPtr basePipelineHandle;
			[FieldOffset(72)]public int basePipelineIndex;
		}

        public static ManagedPtr<VkRayTracingPipelineCreateInfoNV> Pointer(this VkRayTracingPipelineCreateInfoNV i) => new ManagedPtr<VkRayTracingPipelineCreateInfoNV>(i);
        public static ManagedPtr<VkRayTracingPipelineCreateInfoNV[]> Pointer(this VkRayTracingPipelineCreateInfoNV[] i) => new ManagedPtr<VkRayTracingPipelineCreateInfoNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkGeometryTrianglesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr vertexData;
			[FieldOffset(24)]public ulong vertexOffset;
			[FieldOffset(32)]public uint vertexCount;
			[FieldOffset(40)]public ulong vertexStride;
			[FieldOffset(48)]public VkFormat vertexFormat;
			[FieldOffset(56)]public IntPtr indexData;
			[FieldOffset(64)]public ulong indexOffset;
			[FieldOffset(72)]public uint indexCount;
			[FieldOffset(76)]public VkIndexType indexType;
			[FieldOffset(80)]public IntPtr transformData;
			[FieldOffset(88)]public ulong transformOffset;
		}

        public static ManagedPtr<VkGeometryTrianglesNV> Pointer(this VkGeometryTrianglesNV i) => new ManagedPtr<VkGeometryTrianglesNV>(i);
        public static ManagedPtr<VkGeometryTrianglesNV[]> Pointer(this VkGeometryTrianglesNV[] i) => new ManagedPtr<VkGeometryTrianglesNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkGeometryAABBNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr aabbData;
			[FieldOffset(24)]public uint numAABBs;
			[FieldOffset(28)]public uint stride;
			[FieldOffset(32)]public ulong offset;
		}

        public static ManagedPtr<VkGeometryAABBNV> Pointer(this VkGeometryAABBNV i) => new ManagedPtr<VkGeometryAABBNV>(i);
        public static ManagedPtr<VkGeometryAABBNV[]> Pointer(this VkGeometryAABBNV[] i) => new ManagedPtr<VkGeometryAABBNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkGeometryDataNV {
			[FieldOffset(0)]public VkGeometryTrianglesNV triangles;
			[FieldOffset(120)]public VkGeometryAABBNV aabbs;
		}

        public static ManagedPtr<VkGeometryDataNV> Pointer(this VkGeometryDataNV i) => new ManagedPtr<VkGeometryDataNV>(i);
        public static ManagedPtr<VkGeometryDataNV[]> Pointer(this VkGeometryDataNV[] i) => new ManagedPtr<VkGeometryDataNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkGeometryNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkGeometryTypeNV geometryType;
			[FieldOffset(160)]public VkGeometryDataNV geometry;
			[FieldOffset(320)]public uint flags;
		}

        public static ManagedPtr<VkGeometryNV> Pointer(this VkGeometryNV i) => new ManagedPtr<VkGeometryNV>(i);
        public static ManagedPtr<VkGeometryNV[]> Pointer(this VkGeometryNV[] i) => new ManagedPtr<VkGeometryNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAccelerationStructureInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkAccelerationStructureTypeNV type;
			[FieldOffset(20)]public uint flags;
			[FieldOffset(24)]public uint instanceCount;
			[FieldOffset(28)]public uint geometryCount;
			[FieldOffset(32)]public IntPtr pGeometries;
		}

        public static ManagedPtr<VkAccelerationStructureInfoNV> Pointer(this VkAccelerationStructureInfoNV i) => new ManagedPtr<VkAccelerationStructureInfoNV>(i);
        public static ManagedPtr<VkAccelerationStructureInfoNV[]> Pointer(this VkAccelerationStructureInfoNV[] i) => new ManagedPtr<VkAccelerationStructureInfoNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAccelerationStructureCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong compactedSize;
			[FieldOffset(40)]public VkAccelerationStructureInfoNV info;
		}

        public static ManagedPtr<VkAccelerationStructureCreateInfoNV> Pointer(this VkAccelerationStructureCreateInfoNV i) => new ManagedPtr<VkAccelerationStructureCreateInfoNV>(i);
        public static ManagedPtr<VkAccelerationStructureCreateInfoNV[]> Pointer(this VkAccelerationStructureCreateInfoNV[] i) => new ManagedPtr<VkAccelerationStructureCreateInfoNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBindAccelerationStructureMemoryInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr accelerationStructure;
			[FieldOffset(24)]public IntPtr memory;
			[FieldOffset(32)]public ulong memoryOffset;
			[FieldOffset(40)]public uint deviceIndexCount;
			[FieldOffset(48)]public uint* pDeviceIndices;
		}

        public static ManagedPtr<VkBindAccelerationStructureMemoryInfoNV> Pointer(this VkBindAccelerationStructureMemoryInfoNV i) => new ManagedPtr<VkBindAccelerationStructureMemoryInfoNV>(i);
        public static ManagedPtr<VkBindAccelerationStructureMemoryInfoNV[]> Pointer(this VkBindAccelerationStructureMemoryInfoNV[] i) => new ManagedPtr<VkBindAccelerationStructureMemoryInfoNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkWriteDescriptorSetAccelerationStructureNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint accelerationStructureCount;
			[FieldOffset(24)]public IntPtr* pAccelerationStructures;
		}

        public static ManagedPtr<VkWriteDescriptorSetAccelerationStructureNV> Pointer(this VkWriteDescriptorSetAccelerationStructureNV i) => new ManagedPtr<VkWriteDescriptorSetAccelerationStructureNV>(i);
        public static ManagedPtr<VkWriteDescriptorSetAccelerationStructureNV[]> Pointer(this VkWriteDescriptorSetAccelerationStructureNV[] i) => new ManagedPtr<VkWriteDescriptorSetAccelerationStructureNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAccelerationStructureMemoryRequirementsInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkAccelerationStructureMemoryRequirementsTypeNV type;
			[FieldOffset(24)]public IntPtr accelerationStructure;
		}

        public static ManagedPtr<VkAccelerationStructureMemoryRequirementsInfoNV> Pointer(this VkAccelerationStructureMemoryRequirementsInfoNV i) => new ManagedPtr<VkAccelerationStructureMemoryRequirementsInfoNV>(i);
        public static ManagedPtr<VkAccelerationStructureMemoryRequirementsInfoNV[]> Pointer(this VkAccelerationStructureMemoryRequirementsInfoNV[] i) => new ManagedPtr<VkAccelerationStructureMemoryRequirementsInfoNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceRayTracingPropertiesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint shaderGroupHandleSize;
			[FieldOffset(20)]public uint maxRecursionDepth;
			[FieldOffset(24)]public uint maxShaderGroupStride;
			[FieldOffset(28)]public uint shaderGroupBaseAlignment;
			[FieldOffset(32)]public ulong maxGeometryCount;
			[FieldOffset(40)]public ulong maxInstanceCount;
			[FieldOffset(48)]public ulong maxTriangleCount;
			[FieldOffset(56)]public uint maxDescriptorSetAccelerationStructures;
		}

        public static ManagedPtr<VkPhysicalDeviceRayTracingPropertiesNV> Pointer(this VkPhysicalDeviceRayTracingPropertiesNV i) => new ManagedPtr<VkPhysicalDeviceRayTracingPropertiesNV>(i);
        public static ManagedPtr<VkPhysicalDeviceRayTracingPropertiesNV[]> Pointer(this VkPhysicalDeviceRayTracingPropertiesNV[] i) => new ManagedPtr<VkPhysicalDeviceRayTracingPropertiesNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint representativeFragmentTest;
		}

        public static ManagedPtr<VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV> Pointer(this VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV>(i);
        public static ManagedPtr<VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV[]> Pointer(this VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV[] i) => new ManagedPtr<VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint representativeFragmentTestEnable;
		}

        public static ManagedPtr<VkPipelineRepresentativeFragmentTestStateCreateInfoNV> Pointer(this VkPipelineRepresentativeFragmentTestStateCreateInfoNV i) => new ManagedPtr<VkPipelineRepresentativeFragmentTestStateCreateInfoNV>(i);
        public static ManagedPtr<VkPipelineRepresentativeFragmentTestStateCreateInfoNV[]> Pointer(this VkPipelineRepresentativeFragmentTestStateCreateInfoNV[] i) => new ManagedPtr<VkPipelineRepresentativeFragmentTestStateCreateInfoNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceImageViewImageFormatInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkImageViewType imageViewType;
		}

        public static ManagedPtr<VkPhysicalDeviceImageViewImageFormatInfoEXT> Pointer(this VkPhysicalDeviceImageViewImageFormatInfoEXT i) => new ManagedPtr<VkPhysicalDeviceImageViewImageFormatInfoEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceImageViewImageFormatInfoEXT[]> Pointer(this VkPhysicalDeviceImageViewImageFormatInfoEXT[] i) => new ManagedPtr<VkPhysicalDeviceImageViewImageFormatInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkFilterCubicImageViewImageFormatPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint filterCubic;
			[FieldOffset(20)]public uint filterCubicMinmax;
		}

        public static ManagedPtr<VkFilterCubicImageViewImageFormatPropertiesEXT> Pointer(this VkFilterCubicImageViewImageFormatPropertiesEXT i) => new ManagedPtr<VkFilterCubicImageViewImageFormatPropertiesEXT>(i);
        public static ManagedPtr<VkFilterCubicImageViewImageFormatPropertiesEXT[]> Pointer(this VkFilterCubicImageViewImageFormatPropertiesEXT[] i) => new ManagedPtr<VkFilterCubicImageViewImageFormatPropertiesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceQueueGlobalPriorityCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkQueueGlobalPriorityEXT globalPriority;
		}

        public static ManagedPtr<VkDeviceQueueGlobalPriorityCreateInfoEXT> Pointer(this VkDeviceQueueGlobalPriorityCreateInfoEXT i) => new ManagedPtr<VkDeviceQueueGlobalPriorityCreateInfoEXT>(i);
        public static ManagedPtr<VkDeviceQueueGlobalPriorityCreateInfoEXT[]> Pointer(this VkDeviceQueueGlobalPriorityCreateInfoEXT[] i) => new ManagedPtr<VkDeviceQueueGlobalPriorityCreateInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImportMemoryHostPointerInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalMemoryHandleTypeFlagBits handleType;
			[FieldOffset(24)]public IntPtr pHostPointer;
		}

        public static ManagedPtr<VkImportMemoryHostPointerInfoEXT> Pointer(this VkImportMemoryHostPointerInfoEXT i) => new ManagedPtr<VkImportMemoryHostPointerInfoEXT>(i);
        public static ManagedPtr<VkImportMemoryHostPointerInfoEXT[]> Pointer(this VkImportMemoryHostPointerInfoEXT[] i) => new ManagedPtr<VkImportMemoryHostPointerInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryHostPointerPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint memoryTypeBits;
		}

        public static ManagedPtr<VkMemoryHostPointerPropertiesEXT> Pointer(this VkMemoryHostPointerPropertiesEXT i) => new ManagedPtr<VkMemoryHostPointerPropertiesEXT>(i);
        public static ManagedPtr<VkMemoryHostPointerPropertiesEXT[]> Pointer(this VkMemoryHostPointerPropertiesEXT[] i) => new ManagedPtr<VkMemoryHostPointerPropertiesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong minImportedHostPointerAlignment;
		}

        public static ManagedPtr<VkPhysicalDeviceExternalMemoryHostPropertiesEXT> Pointer(this VkPhysicalDeviceExternalMemoryHostPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceExternalMemoryHostPropertiesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceExternalMemoryHostPropertiesEXT[]> Pointer(this VkPhysicalDeviceExternalMemoryHostPropertiesEXT[] i) => new ManagedPtr<VkPhysicalDeviceExternalMemoryHostPropertiesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineCompilerControlCreateInfoAMD {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint compilerControlFlags;
		}

        public static ManagedPtr<VkPipelineCompilerControlCreateInfoAMD> Pointer(this VkPipelineCompilerControlCreateInfoAMD i) => new ManagedPtr<VkPipelineCompilerControlCreateInfoAMD>(i);
        public static ManagedPtr<VkPipelineCompilerControlCreateInfoAMD[]> Pointer(this VkPipelineCompilerControlCreateInfoAMD[] i) => new ManagedPtr<VkPipelineCompilerControlCreateInfoAMD[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkCalibratedTimestampInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkTimeDomainEXT timeDomain;
		}

        public static ManagedPtr<VkCalibratedTimestampInfoEXT> Pointer(this VkCalibratedTimestampInfoEXT i) => new ManagedPtr<VkCalibratedTimestampInfoEXT>(i);
        public static ManagedPtr<VkCalibratedTimestampInfoEXT[]> Pointer(this VkCalibratedTimestampInfoEXT[] i) => new ManagedPtr<VkCalibratedTimestampInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShaderCorePropertiesAMD {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint shaderEngineCount;
			[FieldOffset(20)]public uint shaderArraysPerEngineCount;
			[FieldOffset(24)]public uint computeUnitsPerShaderArray;
			[FieldOffset(28)]public uint simdPerComputeUnit;
			[FieldOffset(32)]public uint wavefrontsPerSimd;
			[FieldOffset(36)]public uint wavefrontSize;
			[FieldOffset(40)]public uint sgprsPerSimd;
			[FieldOffset(44)]public uint minSgprAllocation;
			[FieldOffset(48)]public uint maxSgprAllocation;
			[FieldOffset(52)]public uint sgprAllocationGranularity;
			[FieldOffset(56)]public uint vgprsPerSimd;
			[FieldOffset(60)]public uint minVgprAllocation;
			[FieldOffset(64)]public uint maxVgprAllocation;
			[FieldOffset(68)]public uint vgprAllocationGranularity;
		}

        public static ManagedPtr<VkPhysicalDeviceShaderCorePropertiesAMD> Pointer(this VkPhysicalDeviceShaderCorePropertiesAMD i) => new ManagedPtr<VkPhysicalDeviceShaderCorePropertiesAMD>(i);
        public static ManagedPtr<VkPhysicalDeviceShaderCorePropertiesAMD[]> Pointer(this VkPhysicalDeviceShaderCorePropertiesAMD[] i) => new ManagedPtr<VkPhysicalDeviceShaderCorePropertiesAMD[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceMemoryOverallocationCreateInfoAMD {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkMemoryOverallocationBehaviorAMD overallocationBehavior;
		}

        public static ManagedPtr<VkDeviceMemoryOverallocationCreateInfoAMD> Pointer(this VkDeviceMemoryOverallocationCreateInfoAMD i) => new ManagedPtr<VkDeviceMemoryOverallocationCreateInfoAMD>(i);
        public static ManagedPtr<VkDeviceMemoryOverallocationCreateInfoAMD[]> Pointer(this VkDeviceMemoryOverallocationCreateInfoAMD[] i) => new ManagedPtr<VkDeviceMemoryOverallocationCreateInfoAMD[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint maxVertexAttribDivisor;
		}

        public static ManagedPtr<VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT> Pointer(this VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT[]> Pointer(this VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT[] i) => new ManagedPtr<VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkVertexInputBindingDivisorDescriptionEXT {
			[FieldOffset(0)]public uint binding;
			[FieldOffset(4)]public uint divisor;
		}

        public static ManagedPtr<VkVertexInputBindingDivisorDescriptionEXT> Pointer(this VkVertexInputBindingDivisorDescriptionEXT i) => new ManagedPtr<VkVertexInputBindingDivisorDescriptionEXT>(i);
        public static ManagedPtr<VkVertexInputBindingDivisorDescriptionEXT[]> Pointer(this VkVertexInputBindingDivisorDescriptionEXT[] i) => new ManagedPtr<VkVertexInputBindingDivisorDescriptionEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineVertexInputDivisorStateCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint vertexBindingDivisorCount;
			[FieldOffset(24)]public IntPtr pVertexBindingDivisors;
		}

        public static ManagedPtr<VkPipelineVertexInputDivisorStateCreateInfoEXT> Pointer(this VkPipelineVertexInputDivisorStateCreateInfoEXT i) => new ManagedPtr<VkPipelineVertexInputDivisorStateCreateInfoEXT>(i);
        public static ManagedPtr<VkPipelineVertexInputDivisorStateCreateInfoEXT[]> Pointer(this VkPipelineVertexInputDivisorStateCreateInfoEXT[] i) => new ManagedPtr<VkPipelineVertexInputDivisorStateCreateInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint vertexAttributeInstanceRateDivisor;
			[FieldOffset(20)]public uint vertexAttributeInstanceRateZeroDivisor;
		}

        public static ManagedPtr<VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT> Pointer(this VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT[]> Pointer(this VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT[] i) => new ManagedPtr<VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineCreationFeedbackEXT {
			[FieldOffset(0)]public uint flags;
			[FieldOffset(8)]public ulong duration;
		}

        public static ManagedPtr<VkPipelineCreationFeedbackEXT> Pointer(this VkPipelineCreationFeedbackEXT i) => new ManagedPtr<VkPipelineCreationFeedbackEXT>(i);
        public static ManagedPtr<VkPipelineCreationFeedbackEXT[]> Pointer(this VkPipelineCreationFeedbackEXT[] i) => new ManagedPtr<VkPipelineCreationFeedbackEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineCreationFeedbackCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr pPipelineCreationFeedback;
			[FieldOffset(24)]public uint pipelineStageCreationFeedbackCount;
			[FieldOffset(32)]public IntPtr pPipelineStageCreationFeedbacks;
		}

        public static ManagedPtr<VkPipelineCreationFeedbackCreateInfoEXT> Pointer(this VkPipelineCreationFeedbackCreateInfoEXT i) => new ManagedPtr<VkPipelineCreationFeedbackCreateInfoEXT>(i);
        public static ManagedPtr<VkPipelineCreationFeedbackCreateInfoEXT[]> Pointer(this VkPipelineCreationFeedbackCreateInfoEXT[] i) => new ManagedPtr<VkPipelineCreationFeedbackCreateInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceComputeShaderDerivativesFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint computeDerivativeGroupQuads;
			[FieldOffset(20)]public uint computeDerivativeGroupLinear;
		}

        public static ManagedPtr<VkPhysicalDeviceComputeShaderDerivativesFeaturesNV> Pointer(this VkPhysicalDeviceComputeShaderDerivativesFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceComputeShaderDerivativesFeaturesNV>(i);
        public static ManagedPtr<VkPhysicalDeviceComputeShaderDerivativesFeaturesNV[]> Pointer(this VkPhysicalDeviceComputeShaderDerivativesFeaturesNV[] i) => new ManagedPtr<VkPhysicalDeviceComputeShaderDerivativesFeaturesNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceMeshShaderFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint taskShader;
			[FieldOffset(20)]public uint meshShader;
		}

        public static ManagedPtr<VkPhysicalDeviceMeshShaderFeaturesNV> Pointer(this VkPhysicalDeviceMeshShaderFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceMeshShaderFeaturesNV>(i);
        public static ManagedPtr<VkPhysicalDeviceMeshShaderFeaturesNV[]> Pointer(this VkPhysicalDeviceMeshShaderFeaturesNV[] i) => new ManagedPtr<VkPhysicalDeviceMeshShaderFeaturesNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceMeshShaderPropertiesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint maxDrawMeshTasksCount;
			[FieldOffset(20)]public uint maxTaskWorkGroupInvocations;
			[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray, SizeConst=3)] public uint[] maxTaskWorkGroupSize;
			[FieldOffset(36)]public uint maxTaskTotalMemorySize;
			[FieldOffset(40)]public uint maxTaskOutputCount;
			[FieldOffset(44)]public uint maxMeshWorkGroupInvocations;
			[FieldOffset(48)][MarshalAs(UnmanagedType.ByValArray, SizeConst=3)] public uint[] maxMeshWorkGroupSize;
			[FieldOffset(60)]public uint maxMeshTotalMemorySize;
			[FieldOffset(64)]public uint maxMeshOutputVertices;
			[FieldOffset(68)]public uint maxMeshOutputPrimitives;
			[FieldOffset(72)]public uint maxMeshMultiviewViewCount;
			[FieldOffset(76)]public uint meshOutputPerVertexGranularity;
			[FieldOffset(80)]public uint meshOutputPerPrimitiveGranularity;
		}

        public static ManagedPtr<VkPhysicalDeviceMeshShaderPropertiesNV> Pointer(this VkPhysicalDeviceMeshShaderPropertiesNV i) => new ManagedPtr<VkPhysicalDeviceMeshShaderPropertiesNV>(i);
        public static ManagedPtr<VkPhysicalDeviceMeshShaderPropertiesNV[]> Pointer(this VkPhysicalDeviceMeshShaderPropertiesNV[] i) => new ManagedPtr<VkPhysicalDeviceMeshShaderPropertiesNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDrawMeshTasksIndirectCommandNV {
			[FieldOffset(0)]public uint taskCount;
			[FieldOffset(4)]public uint firstTask;
		}

        public static ManagedPtr<VkDrawMeshTasksIndirectCommandNV> Pointer(this VkDrawMeshTasksIndirectCommandNV i) => new ManagedPtr<VkDrawMeshTasksIndirectCommandNV>(i);
        public static ManagedPtr<VkDrawMeshTasksIndirectCommandNV[]> Pointer(this VkDrawMeshTasksIndirectCommandNV[] i) => new ManagedPtr<VkDrawMeshTasksIndirectCommandNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint fragmentShaderBarycentric;
		}

        public static ManagedPtr<VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV> Pointer(this VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV>(i);
        public static ManagedPtr<VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV[]> Pointer(this VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV[] i) => new ManagedPtr<VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShaderImageFootprintFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint imageFootprint;
		}

        public static ManagedPtr<VkPhysicalDeviceShaderImageFootprintFeaturesNV> Pointer(this VkPhysicalDeviceShaderImageFootprintFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceShaderImageFootprintFeaturesNV>(i);
        public static ManagedPtr<VkPhysicalDeviceShaderImageFootprintFeaturesNV[]> Pointer(this VkPhysicalDeviceShaderImageFootprintFeaturesNV[] i) => new ManagedPtr<VkPhysicalDeviceShaderImageFootprintFeaturesNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineViewportExclusiveScissorStateCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint exclusiveScissorCount;
			[FieldOffset(24)]public IntPtr pExclusiveScissors;
		}

        public static ManagedPtr<VkPipelineViewportExclusiveScissorStateCreateInfoNV> Pointer(this VkPipelineViewportExclusiveScissorStateCreateInfoNV i) => new ManagedPtr<VkPipelineViewportExclusiveScissorStateCreateInfoNV>(i);
        public static ManagedPtr<VkPipelineViewportExclusiveScissorStateCreateInfoNV[]> Pointer(this VkPipelineViewportExclusiveScissorStateCreateInfoNV[] i) => new ManagedPtr<VkPipelineViewportExclusiveScissorStateCreateInfoNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceExclusiveScissorFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint exclusiveScissor;
		}

        public static ManagedPtr<VkPhysicalDeviceExclusiveScissorFeaturesNV> Pointer(this VkPhysicalDeviceExclusiveScissorFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceExclusiveScissorFeaturesNV>(i);
        public static ManagedPtr<VkPhysicalDeviceExclusiveScissorFeaturesNV[]> Pointer(this VkPhysicalDeviceExclusiveScissorFeaturesNV[] i) => new ManagedPtr<VkPhysicalDeviceExclusiveScissorFeaturesNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkQueueFamilyCheckpointPropertiesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint checkpointExecutionStageMask;
		}

        public static ManagedPtr<VkQueueFamilyCheckpointPropertiesNV> Pointer(this VkQueueFamilyCheckpointPropertiesNV i) => new ManagedPtr<VkQueueFamilyCheckpointPropertiesNV>(i);
        public static ManagedPtr<VkQueueFamilyCheckpointPropertiesNV[]> Pointer(this VkQueueFamilyCheckpointPropertiesNV[] i) => new ManagedPtr<VkQueueFamilyCheckpointPropertiesNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkCheckpointDataNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPipelineStageFlagBits stage;
			[FieldOffset(24)]public IntPtr pCheckpointMarker;
		}

        public static ManagedPtr<VkCheckpointDataNV> Pointer(this VkCheckpointDataNV i) => new ManagedPtr<VkCheckpointDataNV>(i);
        public static ManagedPtr<VkCheckpointDataNV[]> Pointer(this VkCheckpointDataNV[] i) => new ManagedPtr<VkCheckpointDataNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint shaderIntegerFunctions2;
		}

        public static ManagedPtr<VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL> Pointer(this VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL i) => new ManagedPtr<VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL>(i);
        public static ManagedPtr<VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL[]> Pointer(this VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL[] i) => new ManagedPtr<VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPerformanceValueINTEL {
			[FieldOffset(0)]public VkPerformanceValueTypeINTEL type;
			[FieldOffset(8)]public VkPerformanceValueDataINTEL data;
		}

        public static ManagedPtr<VkPerformanceValueINTEL> Pointer(this VkPerformanceValueINTEL i) => new ManagedPtr<VkPerformanceValueINTEL>(i);
        public static ManagedPtr<VkPerformanceValueINTEL[]> Pointer(this VkPerformanceValueINTEL[] i) => new ManagedPtr<VkPerformanceValueINTEL[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkInitializePerformanceApiInfoINTEL {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr pUserData;
		}

        public static ManagedPtr<VkInitializePerformanceApiInfoINTEL> Pointer(this VkInitializePerformanceApiInfoINTEL i) => new ManagedPtr<VkInitializePerformanceApiInfoINTEL>(i);
        public static ManagedPtr<VkInitializePerformanceApiInfoINTEL[]> Pointer(this VkInitializePerformanceApiInfoINTEL[] i) => new ManagedPtr<VkInitializePerformanceApiInfoINTEL[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkQueryPoolCreateInfoINTEL {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkQueryPoolSamplingModeINTEL performanceCountersSampling;
		}

        public static ManagedPtr<VkQueryPoolCreateInfoINTEL> Pointer(this VkQueryPoolCreateInfoINTEL i) => new ManagedPtr<VkQueryPoolCreateInfoINTEL>(i);
        public static ManagedPtr<VkQueryPoolCreateInfoINTEL[]> Pointer(this VkQueryPoolCreateInfoINTEL[] i) => new ManagedPtr<VkQueryPoolCreateInfoINTEL[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPerformanceMarkerInfoINTEL {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong marker;
		}

        public static ManagedPtr<VkPerformanceMarkerInfoINTEL> Pointer(this VkPerformanceMarkerInfoINTEL i) => new ManagedPtr<VkPerformanceMarkerInfoINTEL>(i);
        public static ManagedPtr<VkPerformanceMarkerInfoINTEL[]> Pointer(this VkPerformanceMarkerInfoINTEL[] i) => new ManagedPtr<VkPerformanceMarkerInfoINTEL[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPerformanceStreamMarkerInfoINTEL {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint marker;
		}

        public static ManagedPtr<VkPerformanceStreamMarkerInfoINTEL> Pointer(this VkPerformanceStreamMarkerInfoINTEL i) => new ManagedPtr<VkPerformanceStreamMarkerInfoINTEL>(i);
        public static ManagedPtr<VkPerformanceStreamMarkerInfoINTEL[]> Pointer(this VkPerformanceStreamMarkerInfoINTEL[] i) => new ManagedPtr<VkPerformanceStreamMarkerInfoINTEL[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPerformanceOverrideInfoINTEL {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPerformanceOverrideTypeINTEL type;
			[FieldOffset(20)]public uint enable;
			[FieldOffset(24)]public ulong parameter;
		}

        public static ManagedPtr<VkPerformanceOverrideInfoINTEL> Pointer(this VkPerformanceOverrideInfoINTEL i) => new ManagedPtr<VkPerformanceOverrideInfoINTEL>(i);
        public static ManagedPtr<VkPerformanceOverrideInfoINTEL[]> Pointer(this VkPerformanceOverrideInfoINTEL[] i) => new ManagedPtr<VkPerformanceOverrideInfoINTEL[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPerformanceConfigurationAcquireInfoINTEL {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPerformanceConfigurationTypeINTEL type;
		}

        public static ManagedPtr<VkPerformanceConfigurationAcquireInfoINTEL> Pointer(this VkPerformanceConfigurationAcquireInfoINTEL i) => new ManagedPtr<VkPerformanceConfigurationAcquireInfoINTEL>(i);
        public static ManagedPtr<VkPerformanceConfigurationAcquireInfoINTEL[]> Pointer(this VkPerformanceConfigurationAcquireInfoINTEL[] i) => new ManagedPtr<VkPerformanceConfigurationAcquireInfoINTEL[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDevicePCIBusInfoPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint pciDomain;
			[FieldOffset(20)]public uint pciBus;
			[FieldOffset(24)]public uint pciDevice;
			[FieldOffset(28)]public uint pciFunction;
		}

        public static ManagedPtr<VkPhysicalDevicePCIBusInfoPropertiesEXT> Pointer(this VkPhysicalDevicePCIBusInfoPropertiesEXT i) => new ManagedPtr<VkPhysicalDevicePCIBusInfoPropertiesEXT>(i);
        public static ManagedPtr<VkPhysicalDevicePCIBusInfoPropertiesEXT[]> Pointer(this VkPhysicalDevicePCIBusInfoPropertiesEXT[] i) => new ManagedPtr<VkPhysicalDevicePCIBusInfoPropertiesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayNativeHdrSurfaceCapabilitiesAMD {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint localDimmingSupport;
		}

        public static ManagedPtr<VkDisplayNativeHdrSurfaceCapabilitiesAMD> Pointer(this VkDisplayNativeHdrSurfaceCapabilitiesAMD i) => new ManagedPtr<VkDisplayNativeHdrSurfaceCapabilitiesAMD>(i);
        public static ManagedPtr<VkDisplayNativeHdrSurfaceCapabilitiesAMD[]> Pointer(this VkDisplayNativeHdrSurfaceCapabilitiesAMD[] i) => new ManagedPtr<VkDisplayNativeHdrSurfaceCapabilitiesAMD[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSwapchainDisplayNativeHdrCreateInfoAMD {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint localDimmingEnable;
		}

        public static ManagedPtr<VkSwapchainDisplayNativeHdrCreateInfoAMD> Pointer(this VkSwapchainDisplayNativeHdrCreateInfoAMD i) => new ManagedPtr<VkSwapchainDisplayNativeHdrCreateInfoAMD>(i);
        public static ManagedPtr<VkSwapchainDisplayNativeHdrCreateInfoAMD[]> Pointer(this VkSwapchainDisplayNativeHdrCreateInfoAMD[] i) => new ManagedPtr<VkSwapchainDisplayNativeHdrCreateInfoAMD[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint fragmentDensityMap;
			[FieldOffset(20)]public uint fragmentDensityMapDynamic;
			[FieldOffset(24)]public uint fragmentDensityMapNonSubsampledImages;
		}

        public static ManagedPtr<VkPhysicalDeviceFragmentDensityMapFeaturesEXT> Pointer(this VkPhysicalDeviceFragmentDensityMapFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceFragmentDensityMapFeaturesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceFragmentDensityMapFeaturesEXT[]> Pointer(this VkPhysicalDeviceFragmentDensityMapFeaturesEXT[] i) => new ManagedPtr<VkPhysicalDeviceFragmentDensityMapFeaturesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExtent2D minFragmentDensityTexelSize;
			[FieldOffset(24)]public VkExtent2D maxFragmentDensityTexelSize;
			[FieldOffset(32)]public uint fragmentDensityInvocations;
		}

        public static ManagedPtr<VkPhysicalDeviceFragmentDensityMapPropertiesEXT> Pointer(this VkPhysicalDeviceFragmentDensityMapPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceFragmentDensityMapPropertiesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceFragmentDensityMapPropertiesEXT[]> Pointer(this VkPhysicalDeviceFragmentDensityMapPropertiesEXT[] i) => new ManagedPtr<VkPhysicalDeviceFragmentDensityMapPropertiesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRenderPassFragmentDensityMapCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkAttachmentReference fragmentDensityMapAttachment;
		}

        public static ManagedPtr<VkRenderPassFragmentDensityMapCreateInfoEXT> Pointer(this VkRenderPassFragmentDensityMapCreateInfoEXT i) => new ManagedPtr<VkRenderPassFragmentDensityMapCreateInfoEXT>(i);
        public static ManagedPtr<VkRenderPassFragmentDensityMapCreateInfoEXT[]> Pointer(this VkRenderPassFragmentDensityMapCreateInfoEXT[] i) => new ManagedPtr<VkRenderPassFragmentDensityMapCreateInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceSubgroupSizeControlFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint subgroupSizeControl;
			[FieldOffset(20)]public uint computeFullSubgroups;
		}

        public static ManagedPtr<VkPhysicalDeviceSubgroupSizeControlFeaturesEXT> Pointer(this VkPhysicalDeviceSubgroupSizeControlFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceSubgroupSizeControlFeaturesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceSubgroupSizeControlFeaturesEXT[]> Pointer(this VkPhysicalDeviceSubgroupSizeControlFeaturesEXT[] i) => new ManagedPtr<VkPhysicalDeviceSubgroupSizeControlFeaturesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceSubgroupSizeControlPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint minSubgroupSize;
			[FieldOffset(20)]public uint maxSubgroupSize;
			[FieldOffset(24)]public uint maxComputeWorkgroupSubgroups;
			[FieldOffset(28)]public uint requiredSubgroupSizeStages;
		}

        public static ManagedPtr<VkPhysicalDeviceSubgroupSizeControlPropertiesEXT> Pointer(this VkPhysicalDeviceSubgroupSizeControlPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceSubgroupSizeControlPropertiesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceSubgroupSizeControlPropertiesEXT[]> Pointer(this VkPhysicalDeviceSubgroupSizeControlPropertiesEXT[] i) => new ManagedPtr<VkPhysicalDeviceSubgroupSizeControlPropertiesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint requiredSubgroupSize;
		}

        public static ManagedPtr<VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT> Pointer(this VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT i) => new ManagedPtr<VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT>(i);
        public static ManagedPtr<VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT[]> Pointer(this VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT[] i) => new ManagedPtr<VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShaderCoreProperties2AMD {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint shaderCoreFeatures;
			[FieldOffset(20)]public uint activeComputeUnitCount;
		}

        public static ManagedPtr<VkPhysicalDeviceShaderCoreProperties2AMD> Pointer(this VkPhysicalDeviceShaderCoreProperties2AMD i) => new ManagedPtr<VkPhysicalDeviceShaderCoreProperties2AMD>(i);
        public static ManagedPtr<VkPhysicalDeviceShaderCoreProperties2AMD[]> Pointer(this VkPhysicalDeviceShaderCoreProperties2AMD[] i) => new ManagedPtr<VkPhysicalDeviceShaderCoreProperties2AMD[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceCoherentMemoryFeaturesAMD {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint deviceCoherentMemory;
		}

        public static ManagedPtr<VkPhysicalDeviceCoherentMemoryFeaturesAMD> Pointer(this VkPhysicalDeviceCoherentMemoryFeaturesAMD i) => new ManagedPtr<VkPhysicalDeviceCoherentMemoryFeaturesAMD>(i);
        public static ManagedPtr<VkPhysicalDeviceCoherentMemoryFeaturesAMD[]> Pointer(this VkPhysicalDeviceCoherentMemoryFeaturesAMD[] i) => new ManagedPtr<VkPhysicalDeviceCoherentMemoryFeaturesAMD[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceMemoryBudgetPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)][MarshalAs(UnmanagedType.ByValArray, SizeConst=16)] public ulong[] heapBudget;
			[FieldOffset(144)][MarshalAs(UnmanagedType.ByValArray, SizeConst=16)] public ulong[] heapUsage;
		}

        public static ManagedPtr<VkPhysicalDeviceMemoryBudgetPropertiesEXT> Pointer(this VkPhysicalDeviceMemoryBudgetPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceMemoryBudgetPropertiesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceMemoryBudgetPropertiesEXT[]> Pointer(this VkPhysicalDeviceMemoryBudgetPropertiesEXT[] i) => new ManagedPtr<VkPhysicalDeviceMemoryBudgetPropertiesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceMemoryPriorityFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint memoryPriority;
		}

        public static ManagedPtr<VkPhysicalDeviceMemoryPriorityFeaturesEXT> Pointer(this VkPhysicalDeviceMemoryPriorityFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceMemoryPriorityFeaturesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceMemoryPriorityFeaturesEXT[]> Pointer(this VkPhysicalDeviceMemoryPriorityFeaturesEXT[] i) => new ManagedPtr<VkPhysicalDeviceMemoryPriorityFeaturesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryPriorityAllocateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public float priority;
		}

        public static ManagedPtr<VkMemoryPriorityAllocateInfoEXT> Pointer(this VkMemoryPriorityAllocateInfoEXT i) => new ManagedPtr<VkMemoryPriorityAllocateInfoEXT>(i);
        public static ManagedPtr<VkMemoryPriorityAllocateInfoEXT[]> Pointer(this VkMemoryPriorityAllocateInfoEXT[] i) => new ManagedPtr<VkMemoryPriorityAllocateInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint dedicatedAllocationImageAliasing;
		}

        public static ManagedPtr<VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV> Pointer(this VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV>(i);
        public static ManagedPtr<VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV[]> Pointer(this VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV[] i) => new ManagedPtr<VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint bufferDeviceAddress;
			[FieldOffset(20)]public uint bufferDeviceAddressCaptureReplay;
			[FieldOffset(24)]public uint bufferDeviceAddressMultiDevice;
		}

        public static ManagedPtr<VkPhysicalDeviceBufferDeviceAddressFeaturesEXT> Pointer(this VkPhysicalDeviceBufferDeviceAddressFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceBufferDeviceAddressFeaturesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceBufferDeviceAddressFeaturesEXT[]> Pointer(this VkPhysicalDeviceBufferDeviceAddressFeaturesEXT[] i) => new ManagedPtr<VkPhysicalDeviceBufferDeviceAddressFeaturesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBufferDeviceAddressCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong deviceAddress;
		}

        public static ManagedPtr<VkBufferDeviceAddressCreateInfoEXT> Pointer(this VkBufferDeviceAddressCreateInfoEXT i) => new ManagedPtr<VkBufferDeviceAddressCreateInfoEXT>(i);
        public static ManagedPtr<VkBufferDeviceAddressCreateInfoEXT[]> Pointer(this VkBufferDeviceAddressCreateInfoEXT[] i) => new ManagedPtr<VkBufferDeviceAddressCreateInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceToolPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] name;
			[FieldOffset(272)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] version;
			[FieldOffset(528)]public uint purposes;
			[FieldOffset(532)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] description;
			[FieldOffset(788)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] layer;
		}

        public static ManagedPtr<VkPhysicalDeviceToolPropertiesEXT> Pointer(this VkPhysicalDeviceToolPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceToolPropertiesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceToolPropertiesEXT[]> Pointer(this VkPhysicalDeviceToolPropertiesEXT[] i) => new ManagedPtr<VkPhysicalDeviceToolPropertiesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkValidationFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint enabledValidationFeatureCount;
			[FieldOffset(24)]public VkValidationFeatureEnableEXT* pEnabledValidationFeatures;
			[FieldOffset(32)]public uint disabledValidationFeatureCount;
			[FieldOffset(40)]public VkValidationFeatureDisableEXT* pDisabledValidationFeatures;
		}

        public static ManagedPtr<VkValidationFeaturesEXT> Pointer(this VkValidationFeaturesEXT i) => new ManagedPtr<VkValidationFeaturesEXT>(i);
        public static ManagedPtr<VkValidationFeaturesEXT[]> Pointer(this VkValidationFeaturesEXT[] i) => new ManagedPtr<VkValidationFeaturesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkCooperativeMatrixPropertiesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint MSize;
			[FieldOffset(20)]public uint NSize;
			[FieldOffset(24)]public uint KSize;
			[FieldOffset(28)]public VkComponentTypeNV AType;
			[FieldOffset(32)]public VkComponentTypeNV BType;
			[FieldOffset(36)]public VkComponentTypeNV CType;
			[FieldOffset(40)]public VkComponentTypeNV DType;
			[FieldOffset(44)]public VkScopeNV scope;
		}

        public static ManagedPtr<VkCooperativeMatrixPropertiesNV> Pointer(this VkCooperativeMatrixPropertiesNV i) => new ManagedPtr<VkCooperativeMatrixPropertiesNV>(i);
        public static ManagedPtr<VkCooperativeMatrixPropertiesNV[]> Pointer(this VkCooperativeMatrixPropertiesNV[] i) => new ManagedPtr<VkCooperativeMatrixPropertiesNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceCooperativeMatrixFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint cooperativeMatrix;
			[FieldOffset(20)]public uint cooperativeMatrixRobustBufferAccess;
		}

        public static ManagedPtr<VkPhysicalDeviceCooperativeMatrixFeaturesNV> Pointer(this VkPhysicalDeviceCooperativeMatrixFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceCooperativeMatrixFeaturesNV>(i);
        public static ManagedPtr<VkPhysicalDeviceCooperativeMatrixFeaturesNV[]> Pointer(this VkPhysicalDeviceCooperativeMatrixFeaturesNV[] i) => new ManagedPtr<VkPhysicalDeviceCooperativeMatrixFeaturesNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceCooperativeMatrixPropertiesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint cooperativeMatrixSupportedStages;
		}

        public static ManagedPtr<VkPhysicalDeviceCooperativeMatrixPropertiesNV> Pointer(this VkPhysicalDeviceCooperativeMatrixPropertiesNV i) => new ManagedPtr<VkPhysicalDeviceCooperativeMatrixPropertiesNV>(i);
        public static ManagedPtr<VkPhysicalDeviceCooperativeMatrixPropertiesNV[]> Pointer(this VkPhysicalDeviceCooperativeMatrixPropertiesNV[] i) => new ManagedPtr<VkPhysicalDeviceCooperativeMatrixPropertiesNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceCoverageReductionModeFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint coverageReductionMode;
		}

        public static ManagedPtr<VkPhysicalDeviceCoverageReductionModeFeaturesNV> Pointer(this VkPhysicalDeviceCoverageReductionModeFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceCoverageReductionModeFeaturesNV>(i);
        public static ManagedPtr<VkPhysicalDeviceCoverageReductionModeFeaturesNV[]> Pointer(this VkPhysicalDeviceCoverageReductionModeFeaturesNV[] i) => new ManagedPtr<VkPhysicalDeviceCoverageReductionModeFeaturesNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineCoverageReductionStateCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public VkCoverageReductionModeNV coverageReductionMode;
		}

        public static ManagedPtr<VkPipelineCoverageReductionStateCreateInfoNV> Pointer(this VkPipelineCoverageReductionStateCreateInfoNV i) => new ManagedPtr<VkPipelineCoverageReductionStateCreateInfoNV>(i);
        public static ManagedPtr<VkPipelineCoverageReductionStateCreateInfoNV[]> Pointer(this VkPipelineCoverageReductionStateCreateInfoNV[] i) => new ManagedPtr<VkPipelineCoverageReductionStateCreateInfoNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkFramebufferMixedSamplesCombinationNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkCoverageReductionModeNV coverageReductionMode;
			[FieldOffset(20)]public VkSampleCountFlagBits rasterizationSamples;
			[FieldOffset(24)]public uint depthStencilSamples;
			[FieldOffset(28)]public uint colorSamples;
		}

        public static ManagedPtr<VkFramebufferMixedSamplesCombinationNV> Pointer(this VkFramebufferMixedSamplesCombinationNV i) => new ManagedPtr<VkFramebufferMixedSamplesCombinationNV>(i);
        public static ManagedPtr<VkFramebufferMixedSamplesCombinationNV[]> Pointer(this VkFramebufferMixedSamplesCombinationNV[] i) => new ManagedPtr<VkFramebufferMixedSamplesCombinationNV[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint fragmentShaderSampleInterlock;
			[FieldOffset(20)]public uint fragmentShaderPixelInterlock;
			[FieldOffset(24)]public uint fragmentShaderShadingRateInterlock;
		}

        public static ManagedPtr<VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT> Pointer(this VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT[]> Pointer(this VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT[] i) => new ManagedPtr<VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint ycbcrImageArrays;
		}

        public static ManagedPtr<VkPhysicalDeviceYcbcrImageArraysFeaturesEXT> Pointer(this VkPhysicalDeviceYcbcrImageArraysFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceYcbcrImageArraysFeaturesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceYcbcrImageArraysFeaturesEXT[]> Pointer(this VkPhysicalDeviceYcbcrImageArraysFeaturesEXT[] i) => new ManagedPtr<VkPhysicalDeviceYcbcrImageArraysFeaturesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkHeadlessSurfaceCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
		}

        public static ManagedPtr<VkHeadlessSurfaceCreateInfoEXT> Pointer(this VkHeadlessSurfaceCreateInfoEXT i) => new ManagedPtr<VkHeadlessSurfaceCreateInfoEXT>(i);
        public static ManagedPtr<VkHeadlessSurfaceCreateInfoEXT[]> Pointer(this VkHeadlessSurfaceCreateInfoEXT[] i) => new ManagedPtr<VkHeadlessSurfaceCreateInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceLineRasterizationFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint rectangularLines;
			[FieldOffset(20)]public uint bresenhamLines;
			[FieldOffset(24)]public uint smoothLines;
			[FieldOffset(28)]public uint stippledRectangularLines;
			[FieldOffset(32)]public uint stippledBresenhamLines;
			[FieldOffset(36)]public uint stippledSmoothLines;
		}

        public static ManagedPtr<VkPhysicalDeviceLineRasterizationFeaturesEXT> Pointer(this VkPhysicalDeviceLineRasterizationFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceLineRasterizationFeaturesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceLineRasterizationFeaturesEXT[]> Pointer(this VkPhysicalDeviceLineRasterizationFeaturesEXT[] i) => new ManagedPtr<VkPhysicalDeviceLineRasterizationFeaturesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceLineRasterizationPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint lineSubPixelPrecisionBits;
		}

        public static ManagedPtr<VkPhysicalDeviceLineRasterizationPropertiesEXT> Pointer(this VkPhysicalDeviceLineRasterizationPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceLineRasterizationPropertiesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceLineRasterizationPropertiesEXT[]> Pointer(this VkPhysicalDeviceLineRasterizationPropertiesEXT[] i) => new ManagedPtr<VkPhysicalDeviceLineRasterizationPropertiesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineRasterizationLineStateCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkLineRasterizationModeEXT lineRasterizationMode;
			[FieldOffset(20)]public uint stippledLineEnable;
			[FieldOffset(24)]public uint lineStippleFactor;
			[FieldOffset(28)]public ushort lineStipplePattern;
		}

        public static ManagedPtr<VkPipelineRasterizationLineStateCreateInfoEXT> Pointer(this VkPipelineRasterizationLineStateCreateInfoEXT i) => new ManagedPtr<VkPipelineRasterizationLineStateCreateInfoEXT>(i);
        public static ManagedPtr<VkPipelineRasterizationLineStateCreateInfoEXT[]> Pointer(this VkPipelineRasterizationLineStateCreateInfoEXT[] i) => new ManagedPtr<VkPipelineRasterizationLineStateCreateInfoEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceIndexTypeUint8FeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint indexTypeUint8;
		}

        public static ManagedPtr<VkPhysicalDeviceIndexTypeUint8FeaturesEXT> Pointer(this VkPhysicalDeviceIndexTypeUint8FeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceIndexTypeUint8FeaturesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceIndexTypeUint8FeaturesEXT[]> Pointer(this VkPhysicalDeviceIndexTypeUint8FeaturesEXT[] i) => new ManagedPtr<VkPhysicalDeviceIndexTypeUint8FeaturesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint shaderDemoteToHelperInvocation;
		}

        public static ManagedPtr<VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT> Pointer(this VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT[]> Pointer(this VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT[] i) => new ManagedPtr<VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint texelBufferAlignment;
		}

        public static ManagedPtr<VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT> Pointer(this VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT[]> Pointer(this VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT[] i) => new ManagedPtr<VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT[]>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong storageTexelBufferOffsetAlignmentBytes;
			[FieldOffset(24)]public uint storageTexelBufferOffsetSingleTexelAlignment;
			[FieldOffset(32)]public ulong uniformTexelBufferOffsetAlignmentBytes;
			[FieldOffset(40)]public uint uniformTexelBufferOffsetSingleTexelAlignment;
		}

        public static ManagedPtr<VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT> Pointer(this VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT>(i);
        public static ManagedPtr<VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT[]> Pointer(this VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT[] i) => new ManagedPtr<VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT[]>(i);
	}
}
