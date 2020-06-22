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
        public static ManagedPtrArray<VkWin32SurfaceCreateInfoKHR> Pointer(this VkWin32SurfaceCreateInfoKHR[] i) => new ManagedPtrArray<VkWin32SurfaceCreateInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkImportMemoryWin32HandleInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalMemoryHandleTypeFlags handleType;
			[FieldOffset(24)]public IntPtr handle;
			[FieldOffset(32)]public string name;
		}

        public static ManagedPtr<VkImportMemoryWin32HandleInfoKHR> Pointer(this VkImportMemoryWin32HandleInfoKHR i) => new ManagedPtr<VkImportMemoryWin32HandleInfoKHR>(i);
        public static ManagedPtrArray<VkImportMemoryWin32HandleInfoKHR> Pointer(this VkImportMemoryWin32HandleInfoKHR[] i) => new ManagedPtrArray<VkImportMemoryWin32HandleInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkExportMemoryWin32HandleInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr* pAttributes;
			[FieldOffset(24)]public uint dwAccess;
			[FieldOffset(32)]public string name;
		}

        public static ManagedPtr<VkExportMemoryWin32HandleInfoKHR> Pointer(this VkExportMemoryWin32HandleInfoKHR i) => new ManagedPtr<VkExportMemoryWin32HandleInfoKHR>(i);
        public static ManagedPtrArray<VkExportMemoryWin32HandleInfoKHR> Pointer(this VkExportMemoryWin32HandleInfoKHR[] i) => new ManagedPtrArray<VkExportMemoryWin32HandleInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkMemoryWin32HandlePropertiesKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint memoryTypeBits;
		}

        public static ManagedPtr<VkMemoryWin32HandlePropertiesKHR> Pointer(this VkMemoryWin32HandlePropertiesKHR i) => new ManagedPtr<VkMemoryWin32HandlePropertiesKHR>(i);
        public static ManagedPtrArray<VkMemoryWin32HandlePropertiesKHR> Pointer(this VkMemoryWin32HandlePropertiesKHR[] i) => new ManagedPtrArray<VkMemoryWin32HandlePropertiesKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkMemoryGetWin32HandleInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr memory;
			[FieldOffset(24)]public VkExternalMemoryHandleTypeFlags handleType;
		}

        public static ManagedPtr<VkMemoryGetWin32HandleInfoKHR> Pointer(this VkMemoryGetWin32HandleInfoKHR i) => new ManagedPtr<VkMemoryGetWin32HandleInfoKHR>(i);
        public static ManagedPtrArray<VkMemoryGetWin32HandleInfoKHR> Pointer(this VkMemoryGetWin32HandleInfoKHR[] i) => new ManagedPtrArray<VkMemoryGetWin32HandleInfoKHR>(i);
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
        public static ManagedPtrArray<VkWin32KeyedMutexAcquireReleaseInfoKHR> Pointer(this VkWin32KeyedMutexAcquireReleaseInfoKHR[] i) => new ManagedPtrArray<VkWin32KeyedMutexAcquireReleaseInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkImportSemaphoreWin32HandleInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr semaphore;
			[FieldOffset(24)]public VkSemaphoreImportFlags flags;
			[FieldOffset(28)]public VkExternalSemaphoreHandleTypeFlags handleType;
			[FieldOffset(32)]public IntPtr handle;
			[FieldOffset(40)]public string name;
		}

        public static ManagedPtr<VkImportSemaphoreWin32HandleInfoKHR> Pointer(this VkImportSemaphoreWin32HandleInfoKHR i) => new ManagedPtr<VkImportSemaphoreWin32HandleInfoKHR>(i);
        public static ManagedPtrArray<VkImportSemaphoreWin32HandleInfoKHR> Pointer(this VkImportSemaphoreWin32HandleInfoKHR[] i) => new ManagedPtrArray<VkImportSemaphoreWin32HandleInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkExportSemaphoreWin32HandleInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr* pAttributes;
			[FieldOffset(24)]public uint dwAccess;
			[FieldOffset(32)]public string name;
		}

        public static ManagedPtr<VkExportSemaphoreWin32HandleInfoKHR> Pointer(this VkExportSemaphoreWin32HandleInfoKHR i) => new ManagedPtr<VkExportSemaphoreWin32HandleInfoKHR>(i);
        public static ManagedPtrArray<VkExportSemaphoreWin32HandleInfoKHR> Pointer(this VkExportSemaphoreWin32HandleInfoKHR[] i) => new ManagedPtrArray<VkExportSemaphoreWin32HandleInfoKHR>(i);
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
        public static ManagedPtrArray<VkD3D12FenceSubmitInfoKHR> Pointer(this VkD3D12FenceSubmitInfoKHR[] i) => new ManagedPtrArray<VkD3D12FenceSubmitInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkSemaphoreGetWin32HandleInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr semaphore;
			[FieldOffset(24)]public VkExternalSemaphoreHandleTypeFlags handleType;
		}

        public static ManagedPtr<VkSemaphoreGetWin32HandleInfoKHR> Pointer(this VkSemaphoreGetWin32HandleInfoKHR i) => new ManagedPtr<VkSemaphoreGetWin32HandleInfoKHR>(i);
        public static ManagedPtrArray<VkSemaphoreGetWin32HandleInfoKHR> Pointer(this VkSemaphoreGetWin32HandleInfoKHR[] i) => new ManagedPtrArray<VkSemaphoreGetWin32HandleInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkImportFenceWin32HandleInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr fence;
			[FieldOffset(24)]public VkFenceImportFlags flags;
			[FieldOffset(28)]public VkExternalFenceHandleTypeFlags handleType;
			[FieldOffset(32)]public IntPtr handle;
			[FieldOffset(40)]public string name;
		}

        public static ManagedPtr<VkImportFenceWin32HandleInfoKHR> Pointer(this VkImportFenceWin32HandleInfoKHR i) => new ManagedPtr<VkImportFenceWin32HandleInfoKHR>(i);
        public static ManagedPtrArray<VkImportFenceWin32HandleInfoKHR> Pointer(this VkImportFenceWin32HandleInfoKHR[] i) => new ManagedPtrArray<VkImportFenceWin32HandleInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkExportFenceWin32HandleInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr* pAttributes;
			[FieldOffset(24)]public uint dwAccess;
			[FieldOffset(32)]public string name;
		}

        public static ManagedPtr<VkExportFenceWin32HandleInfoKHR> Pointer(this VkExportFenceWin32HandleInfoKHR i) => new ManagedPtr<VkExportFenceWin32HandleInfoKHR>(i);
        public static ManagedPtrArray<VkExportFenceWin32HandleInfoKHR> Pointer(this VkExportFenceWin32HandleInfoKHR[] i) => new ManagedPtrArray<VkExportFenceWin32HandleInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkFenceGetWin32HandleInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr fence;
			[FieldOffset(24)]public VkExternalFenceHandleTypeFlags handleType;
		}

        public static ManagedPtr<VkFenceGetWin32HandleInfoKHR> Pointer(this VkFenceGetWin32HandleInfoKHR i) => new ManagedPtr<VkFenceGetWin32HandleInfoKHR>(i);
        public static ManagedPtrArray<VkFenceGetWin32HandleInfoKHR> Pointer(this VkFenceGetWin32HandleInfoKHR[] i) => new ManagedPtrArray<VkFenceGetWin32HandleInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkImportMemoryWin32HandleInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalMemoryHandleTypeFlagsNV handleType;
			[FieldOffset(24)]public IntPtr handle;
		}

        public static ManagedPtr<VkImportMemoryWin32HandleInfoNV> Pointer(this VkImportMemoryWin32HandleInfoNV i) => new ManagedPtr<VkImportMemoryWin32HandleInfoNV>(i);
        public static ManagedPtrArray<VkImportMemoryWin32HandleInfoNV> Pointer(this VkImportMemoryWin32HandleInfoNV[] i) => new ManagedPtrArray<VkImportMemoryWin32HandleInfoNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkExportMemoryWin32HandleInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr* pAttributes;
			[FieldOffset(24)]public uint dwAccess;
		}

        public static ManagedPtr<VkExportMemoryWin32HandleInfoNV> Pointer(this VkExportMemoryWin32HandleInfoNV i) => new ManagedPtr<VkExportMemoryWin32HandleInfoNV>(i);
        public static ManagedPtrArray<VkExportMemoryWin32HandleInfoNV> Pointer(this VkExportMemoryWin32HandleInfoNV[] i) => new ManagedPtrArray<VkExportMemoryWin32HandleInfoNV>(i);
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
        public static ManagedPtrArray<VkWin32KeyedMutexAcquireReleaseInfoNV> Pointer(this VkWin32KeyedMutexAcquireReleaseInfoNV[] i) => new ManagedPtrArray<VkWin32KeyedMutexAcquireReleaseInfoNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSurfaceFullScreenExclusiveInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkFullScreenExclusiveEXT fullScreenExclusive;
		}

        public static ManagedPtr<VkSurfaceFullScreenExclusiveInfoEXT> Pointer(this VkSurfaceFullScreenExclusiveInfoEXT i) => new ManagedPtr<VkSurfaceFullScreenExclusiveInfoEXT>(i);
        public static ManagedPtrArray<VkSurfaceFullScreenExclusiveInfoEXT> Pointer(this VkSurfaceFullScreenExclusiveInfoEXT[] i) => new ManagedPtrArray<VkSurfaceFullScreenExclusiveInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSurfaceCapabilitiesFullScreenExclusiveEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool fullScreenExclusiveSupported;
		}

        public static ManagedPtr<VkSurfaceCapabilitiesFullScreenExclusiveEXT> Pointer(this VkSurfaceCapabilitiesFullScreenExclusiveEXT i) => new ManagedPtr<VkSurfaceCapabilitiesFullScreenExclusiveEXT>(i);
        public static ManagedPtrArray<VkSurfaceCapabilitiesFullScreenExclusiveEXT> Pointer(this VkSurfaceCapabilitiesFullScreenExclusiveEXT[] i) => new ManagedPtrArray<VkSurfaceCapabilitiesFullScreenExclusiveEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public unsafe struct VkSurfaceFullScreenExclusiveWin32InfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr hmonitor;
		}

        public static ManagedPtr<VkSurfaceFullScreenExclusiveWin32InfoEXT> Pointer(this VkSurfaceFullScreenExclusiveWin32InfoEXT i) => new ManagedPtr<VkSurfaceFullScreenExclusiveWin32InfoEXT>(i);
        public static ManagedPtrArray<VkSurfaceFullScreenExclusiveWin32InfoEXT> Pointer(this VkSurfaceFullScreenExclusiveWin32InfoEXT[] i) => new ManagedPtrArray<VkSurfaceFullScreenExclusiveWin32InfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkWaylandSurfaceCreateInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(24)]public IntPtr display;
			[FieldOffset(32)]public IntPtr surface;
		}

        public static ManagedPtr<VkWaylandSurfaceCreateInfoKHR> Pointer(this VkWaylandSurfaceCreateInfoKHR i) => new ManagedPtr<VkWaylandSurfaceCreateInfoKHR>(i);
        public static ManagedPtrArray<VkWaylandSurfaceCreateInfoKHR> Pointer(this VkWaylandSurfaceCreateInfoKHR[] i) => new ManagedPtrArray<VkWaylandSurfaceCreateInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkXlibSurfaceCreateInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(24)]public IntPtr dpy;
			[FieldOffset(32)]public IntPtr window;
		}

        public static ManagedPtr<VkXlibSurfaceCreateInfoKHR> Pointer(this VkXlibSurfaceCreateInfoKHR i) => new ManagedPtr<VkXlibSurfaceCreateInfoKHR>(i);
        public static ManagedPtrArray<VkXlibSurfaceCreateInfoKHR> Pointer(this VkXlibSurfaceCreateInfoKHR[] i) => new ManagedPtrArray<VkXlibSurfaceCreateInfoKHR>(i);
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
        public static ManagedPtrArray<VkApplicationInfo> Pointer(this VkApplicationInfo[] i) => new ManagedPtrArray<VkApplicationInfo>(i);
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
        public static ManagedPtrArray<VkInstanceCreateInfo> Pointer(this VkInstanceCreateInfo[] i) => new ManagedPtrArray<VkInstanceCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAllocationCallbacks {
			[FieldOffset(0)]public IntPtr pUserData;
			[FieldOffset(8)][MarshalAs(UnmanagedType.FunctionPtr)]public PFN_vkAllocationFunction pfnAllocation;
			[FieldOffset(16)][MarshalAs(UnmanagedType.FunctionPtr)]public PFN_vkReallocationFunction pfnReallocation;
			[FieldOffset(24)][MarshalAs(UnmanagedType.FunctionPtr)]public PFN_vkFreeFunction pfnFree;
			[FieldOffset(32)][MarshalAs(UnmanagedType.FunctionPtr)]public PFN_vkInternalAllocationNotification pfnInternalAllocation;
			[FieldOffset(40)][MarshalAs(UnmanagedType.FunctionPtr)]public PFN_vkInternalFreeNotification pfnInternalFree;
		}

        public static ManagedPtr<VkAllocationCallbacks> Pointer(this VkAllocationCallbacks i) => new ManagedPtr<VkAllocationCallbacks>(i);
        public static ManagedPtrArray<VkAllocationCallbacks> Pointer(this VkAllocationCallbacks[] i) => new ManagedPtrArray<VkAllocationCallbacks>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceFeatures {
			[FieldOffset(0)]public bool robustBufferAccess;
			[FieldOffset(4)]public bool fullDrawIndexUint32;
			[FieldOffset(8)]public bool imageCubeArray;
			[FieldOffset(12)]public bool independentBlend;
			[FieldOffset(16)]public bool geometryShader;
			[FieldOffset(20)]public bool tessellationShader;
			[FieldOffset(24)]public bool sampleRateShading;
			[FieldOffset(28)]public bool dualSrcBlend;
			[FieldOffset(32)]public bool logicOp;
			[FieldOffset(36)]public bool multiDrawIndirect;
			[FieldOffset(40)]public bool drawIndirectFirstInstance;
			[FieldOffset(44)]public bool depthClamp;
			[FieldOffset(48)]public bool depthBiasClamp;
			[FieldOffset(52)]public bool fillModeNonSolid;
			[FieldOffset(56)]public bool depthBounds;
			[FieldOffset(60)]public bool wideLines;
			[FieldOffset(64)]public bool largePoints;
			[FieldOffset(68)]public bool alphaToOne;
			[FieldOffset(72)]public bool multiViewport;
			[FieldOffset(76)]public bool samplerAnisotropy;
			[FieldOffset(80)]public bool textureCompressionETC2;
			[FieldOffset(84)]public bool textureCompressionASTC_LDR;
			[FieldOffset(88)]public bool textureCompressionBC;
			[FieldOffset(92)]public bool occlusionQueryPrecise;
			[FieldOffset(96)]public bool pipelineStatisticsQuery;
			[FieldOffset(100)]public bool vertexPipelineStoresAndAtomics;
			[FieldOffset(104)]public bool fragmentStoresAndAtomics;
			[FieldOffset(108)]public bool shaderTessellationAndGeometryPointSize;
			[FieldOffset(112)]public bool shaderImageGatherExtended;
			[FieldOffset(116)]public bool shaderStorageImageExtendedFormats;
			[FieldOffset(120)]public bool shaderStorageImageMultisample;
			[FieldOffset(124)]public bool shaderStorageImageReadWithoutFormat;
			[FieldOffset(128)]public bool shaderStorageImageWriteWithoutFormat;
			[FieldOffset(132)]public bool shaderUniformBufferArrayDynamicIndexing;
			[FieldOffset(136)]public bool shaderSampledImageArrayDynamicIndexing;
			[FieldOffset(140)]public bool shaderStorageBufferArrayDynamicIndexing;
			[FieldOffset(144)]public bool shaderStorageImageArrayDynamicIndexing;
			[FieldOffset(148)]public bool shaderClipDistance;
			[FieldOffset(152)]public bool shaderCullDistance;
			[FieldOffset(156)]public bool shaderFloat64;
			[FieldOffset(160)]public bool shaderInt64;
			[FieldOffset(164)]public bool shaderInt16;
			[FieldOffset(168)]public bool shaderResourceResidency;
			[FieldOffset(172)]public bool shaderResourceMinLod;
			[FieldOffset(176)]public bool sparseBinding;
			[FieldOffset(180)]public bool sparseResidencyBuffer;
			[FieldOffset(184)]public bool sparseResidencyImage2D;
			[FieldOffset(188)]public bool sparseResidencyImage3D;
			[FieldOffset(192)]public bool sparseResidency2Samples;
			[FieldOffset(196)]public bool sparseResidency4Samples;
			[FieldOffset(200)]public bool sparseResidency8Samples;
			[FieldOffset(204)]public bool sparseResidency16Samples;
			[FieldOffset(208)]public bool sparseResidencyAliased;
			[FieldOffset(212)]public bool variableMultisampleRate;
			[FieldOffset(216)]public bool inheritedQueries;
		}

        public static ManagedPtr<VkPhysicalDeviceFeatures> Pointer(this VkPhysicalDeviceFeatures i) => new ManagedPtr<VkPhysicalDeviceFeatures>(i);
        public static ManagedPtrArray<VkPhysicalDeviceFeatures> Pointer(this VkPhysicalDeviceFeatures[] i) => new ManagedPtrArray<VkPhysicalDeviceFeatures>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkFormatProperties {
			[FieldOffset(0)]public VkFormatFeatureFlags linearTilingFeatures;
			[FieldOffset(4)]public VkFormatFeatureFlags optimalTilingFeatures;
			[FieldOffset(8)]public VkFormatFeatureFlags bufferFeatures;
		}

        public static ManagedPtr<VkFormatProperties> Pointer(this VkFormatProperties i) => new ManagedPtr<VkFormatProperties>(i);
        public static ManagedPtrArray<VkFormatProperties> Pointer(this VkFormatProperties[] i) => new ManagedPtrArray<VkFormatProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExtent3D {
			[FieldOffset(0)]public uint width;
			[FieldOffset(4)]public uint height;
			[FieldOffset(8)]public uint depth;
		}

        public static ManagedPtr<VkExtent3D> Pointer(this VkExtent3D i) => new ManagedPtr<VkExtent3D>(i);
        public static ManagedPtrArray<VkExtent3D> Pointer(this VkExtent3D[] i) => new ManagedPtrArray<VkExtent3D>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageFormatProperties {
			[FieldOffset(0)]public VkExtent3D maxExtent;
			[FieldOffset(12)]public uint maxMipLevels;
			[FieldOffset(16)]public uint maxArrayLayers;
			[FieldOffset(20)]public VkSampleCountFlags sampleCounts;
			[FieldOffset(24)]public ulong maxResourceSize;
		}

        public static ManagedPtr<VkImageFormatProperties> Pointer(this VkImageFormatProperties i) => new ManagedPtr<VkImageFormatProperties>(i);
        public static ManagedPtrArray<VkImageFormatProperties> Pointer(this VkImageFormatProperties[] i) => new ManagedPtrArray<VkImageFormatProperties>(i);
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
			[FieldOffset(220)]public fixed uint maxComputeWorkGroupCount[3];
			public const int maxComputeWorkGroupCount_len = 3;
			[FieldOffset(232)]public uint maxComputeWorkGroupInvocations;
			[FieldOffset(236)]public fixed uint maxComputeWorkGroupSize[3];
			public const int maxComputeWorkGroupSize_len = 3;
			[FieldOffset(248)]public uint subPixelPrecisionBits;
			[FieldOffset(252)]public uint subTexelPrecisionBits;
			[FieldOffset(256)]public uint mipmapPrecisionBits;
			[FieldOffset(260)]public uint maxDrawIndexedIndexValue;
			[FieldOffset(264)]public uint maxDrawIndirectCount;
			[FieldOffset(268)]public float maxSamplerLodBias;
			[FieldOffset(272)]public float maxSamplerAnisotropy;
			[FieldOffset(276)]public uint maxViewports;
			[FieldOffset(280)]public fixed uint maxViewportDimensions[2];
			public const int maxViewportDimensions_len = 2;
			[FieldOffset(288)]public fixed float viewportBoundsRange[2];
			public const int viewportBoundsRange_len = 2;
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
			[FieldOffset(376)]public VkSampleCountFlags framebufferColorSampleCounts;
			[FieldOffset(380)]public VkSampleCountFlags framebufferDepthSampleCounts;
			[FieldOffset(384)]public VkSampleCountFlags framebufferStencilSampleCounts;
			[FieldOffset(388)]public VkSampleCountFlags framebufferNoAttachmentsSampleCounts;
			[FieldOffset(392)]public uint maxColorAttachments;
			[FieldOffset(396)]public VkSampleCountFlags sampledImageColorSampleCounts;
			[FieldOffset(400)]public VkSampleCountFlags sampledImageIntegerSampleCounts;
			[FieldOffset(404)]public VkSampleCountFlags sampledImageDepthSampleCounts;
			[FieldOffset(408)]public VkSampleCountFlags sampledImageStencilSampleCounts;
			[FieldOffset(412)]public VkSampleCountFlags storageImageSampleCounts;
			[FieldOffset(416)]public uint maxSampleMaskWords;
			[FieldOffset(420)]public bool timestampComputeAndGraphics;
			[FieldOffset(424)]public float timestampPeriod;
			[FieldOffset(428)]public uint maxClipDistances;
			[FieldOffset(432)]public uint maxCullDistances;
			[FieldOffset(436)]public uint maxCombinedClipAndCullDistances;
			[FieldOffset(440)]public uint discreteQueuePriorities;
			[FieldOffset(444)]public fixed float pointSizeRange[2];
			public const int pointSizeRange_len = 2;
			[FieldOffset(452)]public fixed float lineWidthRange[2];
			public const int lineWidthRange_len = 2;
			[FieldOffset(460)]public float pointSizeGranularity;
			[FieldOffset(464)]public float lineWidthGranularity;
			[FieldOffset(468)]public bool strictLines;
			[FieldOffset(472)]public bool standardSampleLocations;
			[FieldOffset(480)]public ulong optimalBufferCopyOffsetAlignment;
			[FieldOffset(488)]public ulong optimalBufferCopyRowPitchAlignment;
			[FieldOffset(496)]public ulong nonCoherentAtomSize;
		}

        public static ManagedPtr<VkPhysicalDeviceLimits> Pointer(this VkPhysicalDeviceLimits i) => new ManagedPtr<VkPhysicalDeviceLimits>(i);
        public static ManagedPtrArray<VkPhysicalDeviceLimits> Pointer(this VkPhysicalDeviceLimits[] i) => new ManagedPtrArray<VkPhysicalDeviceLimits>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceSparseProperties {
			[FieldOffset(0)]public bool residencyStandard2DBlockShape;
			[FieldOffset(4)]public bool residencyStandard2DMultisampleBlockShape;
			[FieldOffset(8)]public bool residencyStandard3DBlockShape;
			[FieldOffset(12)]public bool residencyAlignedMipSize;
			[FieldOffset(16)]public bool residencyNonResidentStrict;
		}

        public static ManagedPtr<VkPhysicalDeviceSparseProperties> Pointer(this VkPhysicalDeviceSparseProperties i) => new ManagedPtr<VkPhysicalDeviceSparseProperties>(i);
        public static ManagedPtrArray<VkPhysicalDeviceSparseProperties> Pointer(this VkPhysicalDeviceSparseProperties[] i) => new ManagedPtrArray<VkPhysicalDeviceSparseProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceProperties {
			[FieldOffset(0)]public uint apiVersion;
			[FieldOffset(4)]public uint driverVersion;
			[FieldOffset(8)]public uint vendorID;
			[FieldOffset(12)]public uint deviceID;
			[FieldOffset(16)]public VkPhysicalDeviceType deviceType;
			[FieldOffset(20)]public fixed byte deviceName[256];
			public const int deviceName_len = 256;
			[FieldOffset(276)]public fixed byte pipelineCacheUUID[16];
			public const int pipelineCacheUUID_len = 16;
			[FieldOffset(296)]public VkPhysicalDeviceLimits limits;
			[FieldOffset(800)]public VkPhysicalDeviceSparseProperties sparseProperties;
		}

        public static ManagedPtr<VkPhysicalDeviceProperties> Pointer(this VkPhysicalDeviceProperties i) => new ManagedPtr<VkPhysicalDeviceProperties>(i);
        public static ManagedPtrArray<VkPhysicalDeviceProperties> Pointer(this VkPhysicalDeviceProperties[] i) => new ManagedPtrArray<VkPhysicalDeviceProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkQueueFamilyProperties {
			[FieldOffset(0)]public VkQueueFlags queueFlags;
			[FieldOffset(4)]public uint queueCount;
			[FieldOffset(8)]public uint timestampValidBits;
			[FieldOffset(12)]public VkExtent3D minImageTransferGranularity;
		}

        public static ManagedPtr<VkQueueFamilyProperties> Pointer(this VkQueueFamilyProperties i) => new ManagedPtr<VkQueueFamilyProperties>(i);
        public static ManagedPtrArray<VkQueueFamilyProperties> Pointer(this VkQueueFamilyProperties[] i) => new ManagedPtrArray<VkQueueFamilyProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryType {
			[FieldOffset(0)]public VkMemoryPropertyFlags propertyFlags;
			[FieldOffset(4)]public uint heapIndex;
		}

        public static ManagedPtr<VkMemoryType> Pointer(this VkMemoryType i) => new ManagedPtr<VkMemoryType>(i);
        public static ManagedPtrArray<VkMemoryType> Pointer(this VkMemoryType[] i) => new ManagedPtrArray<VkMemoryType>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryHeap {
			[FieldOffset(0)]public ulong size;
			[FieldOffset(8)]public VkMemoryHeapFlags flags;
		}

        public static ManagedPtr<VkMemoryHeap> Pointer(this VkMemoryHeap i) => new ManagedPtr<VkMemoryHeap>(i);
        public static ManagedPtrArray<VkMemoryHeap> Pointer(this VkMemoryHeap[] i) => new ManagedPtrArray<VkMemoryHeap>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceMemoryProperties {
			[FieldOffset(0)]public uint memoryTypeCount;
			[FieldOffset(4)][MarshalAs(UnmanagedType.ByValArray, SizeConst=32)] public VkMemoryType[] memoryTypes;
			public const int memoryTypes_len = 32;
			[FieldOffset(260)]public uint memoryHeapCount;
			[FieldOffset(264)][MarshalAs(UnmanagedType.ByValArray, SizeConst=16)] public VkMemoryHeap[] memoryHeaps;
			public const int memoryHeaps_len = 16;
		}

        public static ManagedPtr<VkPhysicalDeviceMemoryProperties> Pointer(this VkPhysicalDeviceMemoryProperties i) => new ManagedPtr<VkPhysicalDeviceMemoryProperties>(i);
        public static ManagedPtrArray<VkPhysicalDeviceMemoryProperties> Pointer(this VkPhysicalDeviceMemoryProperties[] i) => new ManagedPtrArray<VkPhysicalDeviceMemoryProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceQueueCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDeviceQueueCreateFlags flags;
			[FieldOffset(20)]public uint queueFamilyIndex;
			[FieldOffset(24)]public uint queueCount;
			[FieldOffset(32)]public float* pQueuePriorities;
		}

        public static ManagedPtr<VkDeviceQueueCreateInfo> Pointer(this VkDeviceQueueCreateInfo i) => new ManagedPtr<VkDeviceQueueCreateInfo>(i);
        public static ManagedPtrArray<VkDeviceQueueCreateInfo> Pointer(this VkDeviceQueueCreateInfo[] i) => new ManagedPtrArray<VkDeviceQueueCreateInfo>(i);
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
        public static ManagedPtrArray<VkDeviceCreateInfo> Pointer(this VkDeviceCreateInfo[] i) => new ManagedPtrArray<VkDeviceCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExtensionProperties {
			[FieldOffset(0)]public fixed byte extensionName[256];
			public const int extensionName_len = 256;
			[FieldOffset(256)]public uint specVersion;
		}

        public static ManagedPtr<VkExtensionProperties> Pointer(this VkExtensionProperties i) => new ManagedPtr<VkExtensionProperties>(i);
        public static ManagedPtrArray<VkExtensionProperties> Pointer(this VkExtensionProperties[] i) => new ManagedPtrArray<VkExtensionProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkLayerProperties {
			[FieldOffset(0)]public fixed byte layerName[256];
			public const int layerName_len = 256;
			[FieldOffset(256)]public uint specVersion;
			[FieldOffset(260)]public uint implementationVersion;
			[FieldOffset(264)]public fixed byte description[256];
			public const int description_len = 256;
		}

        public static ManagedPtr<VkLayerProperties> Pointer(this VkLayerProperties i) => new ManagedPtr<VkLayerProperties>(i);
        public static ManagedPtrArray<VkLayerProperties> Pointer(this VkLayerProperties[] i) => new ManagedPtrArray<VkLayerProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSubmitInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint waitSemaphoreCount;
			[FieldOffset(24)]public IntPtr* pWaitSemaphores;
			[FieldOffset(32)]public VkPipelineStageFlags* pWaitDstStageMask;
			[FieldOffset(40)]public uint commandBufferCount;
			[FieldOffset(48)]public IntPtr* pCommandBuffers;
			[FieldOffset(56)]public uint signalSemaphoreCount;
			[FieldOffset(64)]public IntPtr* pSignalSemaphores;
		}

        public static ManagedPtr<VkSubmitInfo> Pointer(this VkSubmitInfo i) => new ManagedPtr<VkSubmitInfo>(i);
        public static ManagedPtrArray<VkSubmitInfo> Pointer(this VkSubmitInfo[] i) => new ManagedPtrArray<VkSubmitInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryAllocateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong allocationSize;
			[FieldOffset(24)]public uint memoryTypeIndex;
		}

        public static ManagedPtr<VkMemoryAllocateInfo> Pointer(this VkMemoryAllocateInfo i) => new ManagedPtr<VkMemoryAllocateInfo>(i);
        public static ManagedPtrArray<VkMemoryAllocateInfo> Pointer(this VkMemoryAllocateInfo[] i) => new ManagedPtrArray<VkMemoryAllocateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMappedMemoryRange {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr memory;
			[FieldOffset(24)]public ulong offset;
			[FieldOffset(32)]public ulong size;
		}

        public static ManagedPtr<VkMappedMemoryRange> Pointer(this VkMappedMemoryRange i) => new ManagedPtr<VkMappedMemoryRange>(i);
        public static ManagedPtrArray<VkMappedMemoryRange> Pointer(this VkMappedMemoryRange[] i) => new ManagedPtrArray<VkMappedMemoryRange>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryRequirements {
			[FieldOffset(0)]public ulong size;
			[FieldOffset(8)]public ulong alignment;
			[FieldOffset(16)]public uint memoryTypeBits;
		}

        public static ManagedPtr<VkMemoryRequirements> Pointer(this VkMemoryRequirements i) => new ManagedPtr<VkMemoryRequirements>(i);
        public static ManagedPtrArray<VkMemoryRequirements> Pointer(this VkMemoryRequirements[] i) => new ManagedPtrArray<VkMemoryRequirements>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSparseImageFormatProperties {
			[FieldOffset(0)]public VkImageAspectFlags aspectMask;
			[FieldOffset(4)]public VkExtent3D imageGranularity;
			[FieldOffset(16)]public VkSparseImageFormatFlags flags;
		}

        public static ManagedPtr<VkSparseImageFormatProperties> Pointer(this VkSparseImageFormatProperties i) => new ManagedPtr<VkSparseImageFormatProperties>(i);
        public static ManagedPtrArray<VkSparseImageFormatProperties> Pointer(this VkSparseImageFormatProperties[] i) => new ManagedPtrArray<VkSparseImageFormatProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSparseImageMemoryRequirements {
			[FieldOffset(0)]public VkSparseImageFormatProperties formatProperties;
			[FieldOffset(20)]public uint imageMipTailFirstLod;
			[FieldOffset(24)]public ulong imageMipTailSize;
			[FieldOffset(32)]public ulong imageMipTailOffset;
			[FieldOffset(40)]public ulong imageMipTailStride;
		}

        public static ManagedPtr<VkSparseImageMemoryRequirements> Pointer(this VkSparseImageMemoryRequirements i) => new ManagedPtr<VkSparseImageMemoryRequirements>(i);
        public static ManagedPtrArray<VkSparseImageMemoryRequirements> Pointer(this VkSparseImageMemoryRequirements[] i) => new ManagedPtrArray<VkSparseImageMemoryRequirements>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSparseMemoryBind {
			[FieldOffset(0)]public ulong resourceOffset;
			[FieldOffset(8)]public ulong size;
			[FieldOffset(16)]public IntPtr memory;
			[FieldOffset(24)]public ulong memoryOffset;
			[FieldOffset(32)]public VkSparseMemoryBindFlags flags;
		}

        public static ManagedPtr<VkSparseMemoryBind> Pointer(this VkSparseMemoryBind i) => new ManagedPtr<VkSparseMemoryBind>(i);
        public static ManagedPtrArray<VkSparseMemoryBind> Pointer(this VkSparseMemoryBind[] i) => new ManagedPtrArray<VkSparseMemoryBind>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSparseBufferMemoryBindInfo {
			[FieldOffset(0)]public IntPtr buffer;
			[FieldOffset(8)]public uint bindCount;
			[FieldOffset(16)]public IntPtr pBinds;
		}

        public static ManagedPtr<VkSparseBufferMemoryBindInfo> Pointer(this VkSparseBufferMemoryBindInfo i) => new ManagedPtr<VkSparseBufferMemoryBindInfo>(i);
        public static ManagedPtrArray<VkSparseBufferMemoryBindInfo> Pointer(this VkSparseBufferMemoryBindInfo[] i) => new ManagedPtrArray<VkSparseBufferMemoryBindInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSparseImageOpaqueMemoryBindInfo {
			[FieldOffset(0)]public IntPtr image;
			[FieldOffset(8)]public uint bindCount;
			[FieldOffset(16)]public IntPtr pBinds;
		}

        public static ManagedPtr<VkSparseImageOpaqueMemoryBindInfo> Pointer(this VkSparseImageOpaqueMemoryBindInfo i) => new ManagedPtr<VkSparseImageOpaqueMemoryBindInfo>(i);
        public static ManagedPtrArray<VkSparseImageOpaqueMemoryBindInfo> Pointer(this VkSparseImageOpaqueMemoryBindInfo[] i) => new ManagedPtrArray<VkSparseImageOpaqueMemoryBindInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageSubresource {
			[FieldOffset(0)]public VkImageAspectFlags aspectMask;
			[FieldOffset(4)]public uint mipLevel;
			[FieldOffset(8)]public uint arrayLayer;
		}

        public static ManagedPtr<VkImageSubresource> Pointer(this VkImageSubresource i) => new ManagedPtr<VkImageSubresource>(i);
        public static ManagedPtrArray<VkImageSubresource> Pointer(this VkImageSubresource[] i) => new ManagedPtrArray<VkImageSubresource>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkOffset3D {
			[FieldOffset(0)]public int x;
			[FieldOffset(4)]public int y;
			[FieldOffset(8)]public int z;
		}

        public static ManagedPtr<VkOffset3D> Pointer(this VkOffset3D i) => new ManagedPtr<VkOffset3D>(i);
        public static ManagedPtrArray<VkOffset3D> Pointer(this VkOffset3D[] i) => new ManagedPtrArray<VkOffset3D>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSparseImageMemoryBind {
			[FieldOffset(0)]public VkImageSubresource subresource;
			[FieldOffset(12)]public VkOffset3D offset;
			[FieldOffset(24)]public VkExtent3D extent;
			[FieldOffset(40)]public IntPtr memory;
			[FieldOffset(48)]public ulong memoryOffset;
			[FieldOffset(56)]public VkSparseMemoryBindFlags flags;
		}

        public static ManagedPtr<VkSparseImageMemoryBind> Pointer(this VkSparseImageMemoryBind i) => new ManagedPtr<VkSparseImageMemoryBind>(i);
        public static ManagedPtrArray<VkSparseImageMemoryBind> Pointer(this VkSparseImageMemoryBind[] i) => new ManagedPtrArray<VkSparseImageMemoryBind>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSparseImageMemoryBindInfo {
			[FieldOffset(0)]public IntPtr image;
			[FieldOffset(8)]public uint bindCount;
			[FieldOffset(16)]public IntPtr pBinds;
		}

        public static ManagedPtr<VkSparseImageMemoryBindInfo> Pointer(this VkSparseImageMemoryBindInfo i) => new ManagedPtr<VkSparseImageMemoryBindInfo>(i);
        public static ManagedPtrArray<VkSparseImageMemoryBindInfo> Pointer(this VkSparseImageMemoryBindInfo[] i) => new ManagedPtrArray<VkSparseImageMemoryBindInfo>(i);
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
        public static ManagedPtrArray<VkBindSparseInfo> Pointer(this VkBindSparseInfo[] i) => new ManagedPtrArray<VkBindSparseInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkFenceCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkFenceCreateFlags flags;
		}

        public static ManagedPtr<VkFenceCreateInfo> Pointer(this VkFenceCreateInfo i) => new ManagedPtr<VkFenceCreateInfo>(i);
        public static ManagedPtrArray<VkFenceCreateInfo> Pointer(this VkFenceCreateInfo[] i) => new ManagedPtrArray<VkFenceCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSemaphoreCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
		}

        public static ManagedPtr<VkSemaphoreCreateInfo> Pointer(this VkSemaphoreCreateInfo i) => new ManagedPtr<VkSemaphoreCreateInfo>(i);
        public static ManagedPtrArray<VkSemaphoreCreateInfo> Pointer(this VkSemaphoreCreateInfo[] i) => new ManagedPtrArray<VkSemaphoreCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkEventCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
		}

        public static ManagedPtr<VkEventCreateInfo> Pointer(this VkEventCreateInfo i) => new ManagedPtr<VkEventCreateInfo>(i);
        public static ManagedPtrArray<VkEventCreateInfo> Pointer(this VkEventCreateInfo[] i) => new ManagedPtrArray<VkEventCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkQueryPoolCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public VkQueryType queryType;
			[FieldOffset(24)]public uint queryCount;
			[FieldOffset(28)]public VkQueryPipelineStatisticFlags pipelineStatistics;
		}

        public static ManagedPtr<VkQueryPoolCreateInfo> Pointer(this VkQueryPoolCreateInfo i) => new ManagedPtr<VkQueryPoolCreateInfo>(i);
        public static ManagedPtrArray<VkQueryPoolCreateInfo> Pointer(this VkQueryPoolCreateInfo[] i) => new ManagedPtrArray<VkQueryPoolCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBufferCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkBufferCreateFlags flags;
			[FieldOffset(24)]public ulong size;
			[FieldOffset(32)]public VkBufferUsageFlags usage;
			[FieldOffset(36)]public VkSharingMode sharingMode;
			[FieldOffset(40)]public uint queueFamilyIndexCount;
			[FieldOffset(48)]public uint* pQueueFamilyIndices;
		}

        public static ManagedPtr<VkBufferCreateInfo> Pointer(this VkBufferCreateInfo i) => new ManagedPtr<VkBufferCreateInfo>(i);
        public static ManagedPtrArray<VkBufferCreateInfo> Pointer(this VkBufferCreateInfo[] i) => new ManagedPtrArray<VkBufferCreateInfo>(i);
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
        public static ManagedPtrArray<VkBufferViewCreateInfo> Pointer(this VkBufferViewCreateInfo[] i) => new ManagedPtrArray<VkBufferViewCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkImageCreateFlags flags;
			[FieldOffset(20)]public VkImageType imageType;
			[FieldOffset(24)]public VkFormat format;
			[FieldOffset(28)]public VkExtent3D extent;
			[FieldOffset(40)]public uint mipLevels;
			[FieldOffset(44)]public uint arrayLayers;
			[FieldOffset(48)]public VkSampleCountFlags samples;
			[FieldOffset(52)]public VkImageTiling tiling;
			[FieldOffset(56)]public VkImageUsageFlags usage;
			[FieldOffset(60)]public VkSharingMode sharingMode;
			[FieldOffset(64)]public uint queueFamilyIndexCount;
			[FieldOffset(72)]public uint* pQueueFamilyIndices;
			[FieldOffset(80)]public VkImageLayout initialLayout;
		}

        public static ManagedPtr<VkImageCreateInfo> Pointer(this VkImageCreateInfo i) => new ManagedPtr<VkImageCreateInfo>(i);
        public static ManagedPtrArray<VkImageCreateInfo> Pointer(this VkImageCreateInfo[] i) => new ManagedPtrArray<VkImageCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSubresourceLayout {
			[FieldOffset(0)]public ulong offset;
			[FieldOffset(8)]public ulong size;
			[FieldOffset(16)]public ulong rowPitch;
			[FieldOffset(24)]public ulong arrayPitch;
			[FieldOffset(32)]public ulong depthPitch;
		}

        public static ManagedPtr<VkSubresourceLayout> Pointer(this VkSubresourceLayout i) => new ManagedPtr<VkSubresourceLayout>(i);
        public static ManagedPtrArray<VkSubresourceLayout> Pointer(this VkSubresourceLayout[] i) => new ManagedPtrArray<VkSubresourceLayout>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkComponentMapping {
			[FieldOffset(0)]public VkComponentSwizzle r;
			[FieldOffset(4)]public VkComponentSwizzle g;
			[FieldOffset(8)]public VkComponentSwizzle b;
			[FieldOffset(12)]public VkComponentSwizzle a;
		}

        public static ManagedPtr<VkComponentMapping> Pointer(this VkComponentMapping i) => new ManagedPtr<VkComponentMapping>(i);
        public static ManagedPtrArray<VkComponentMapping> Pointer(this VkComponentMapping[] i) => new ManagedPtrArray<VkComponentMapping>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageSubresourceRange {
			[FieldOffset(0)]public VkImageAspectFlags aspectMask;
			[FieldOffset(4)]public uint baseMipLevel;
			[FieldOffset(8)]public uint levelCount;
			[FieldOffset(12)]public uint baseArrayLayer;
			[FieldOffset(16)]public uint layerCount;
		}

        public static ManagedPtr<VkImageSubresourceRange> Pointer(this VkImageSubresourceRange i) => new ManagedPtr<VkImageSubresourceRange>(i);
        public static ManagedPtrArray<VkImageSubresourceRange> Pointer(this VkImageSubresourceRange[] i) => new ManagedPtrArray<VkImageSubresourceRange>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageViewCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkImageViewCreateFlags flags;
			[FieldOffset(24)]public IntPtr image;
			[FieldOffset(32)]public VkImageViewType viewType;
			[FieldOffset(36)]public VkFormat format;
			[FieldOffset(40)]public VkComponentMapping components;
			[FieldOffset(56)]public VkImageSubresourceRange subresourceRange;
		}

        public static ManagedPtr<VkImageViewCreateInfo> Pointer(this VkImageViewCreateInfo i) => new ManagedPtr<VkImageViewCreateInfo>(i);
        public static ManagedPtrArray<VkImageViewCreateInfo> Pointer(this VkImageViewCreateInfo[] i) => new ManagedPtrArray<VkImageViewCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkShaderModuleCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkShaderModuleCreateFlags flags;
			[FieldOffset(24)]public ulong codeSize;
			[FieldOffset(32)]public uint* pCode;
		}

        public static ManagedPtr<VkShaderModuleCreateInfo> Pointer(this VkShaderModuleCreateInfo i) => new ManagedPtr<VkShaderModuleCreateInfo>(i);
        public static ManagedPtrArray<VkShaderModuleCreateInfo> Pointer(this VkShaderModuleCreateInfo[] i) => new ManagedPtrArray<VkShaderModuleCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineCacheCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPipelineCacheCreateFlags flags;
			[FieldOffset(24)]public ulong initialDataSize;
			[FieldOffset(32)]public IntPtr pInitialData;
		}

        public static ManagedPtr<VkPipelineCacheCreateInfo> Pointer(this VkPipelineCacheCreateInfo i) => new ManagedPtr<VkPipelineCacheCreateInfo>(i);
        public static ManagedPtrArray<VkPipelineCacheCreateInfo> Pointer(this VkPipelineCacheCreateInfo[] i) => new ManagedPtrArray<VkPipelineCacheCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSpecializationMapEntry {
			[FieldOffset(0)]public uint constantID;
			[FieldOffset(4)]public uint offset;
			[FieldOffset(8)]public ulong size;
		}

        public static ManagedPtr<VkSpecializationMapEntry> Pointer(this VkSpecializationMapEntry i) => new ManagedPtr<VkSpecializationMapEntry>(i);
        public static ManagedPtrArray<VkSpecializationMapEntry> Pointer(this VkSpecializationMapEntry[] i) => new ManagedPtrArray<VkSpecializationMapEntry>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSpecializationInfo {
			[FieldOffset(0)]public uint mapEntryCount;
			[FieldOffset(8)]public IntPtr pMapEntries;
			[FieldOffset(16)]public ulong dataSize;
			[FieldOffset(24)]public IntPtr pData;
		}

        public static ManagedPtr<VkSpecializationInfo> Pointer(this VkSpecializationInfo i) => new ManagedPtr<VkSpecializationInfo>(i);
        public static ManagedPtrArray<VkSpecializationInfo> Pointer(this VkSpecializationInfo[] i) => new ManagedPtrArray<VkSpecializationInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineShaderStageCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPipelineShaderStageCreateFlags flags;
			[FieldOffset(20)]public VkShaderStageFlags stage;
			[FieldOffset(24)]public IntPtr module;
			[FieldOffset(32)]public string pName;
			[FieldOffset(40)]public IntPtr pSpecializationInfo;
		}

        public static ManagedPtr<VkPipelineShaderStageCreateInfo> Pointer(this VkPipelineShaderStageCreateInfo i) => new ManagedPtr<VkPipelineShaderStageCreateInfo>(i);
        public static ManagedPtrArray<VkPipelineShaderStageCreateInfo> Pointer(this VkPipelineShaderStageCreateInfo[] i) => new ManagedPtrArray<VkPipelineShaderStageCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkVertexInputBindingDescription {
			[FieldOffset(0)]public uint binding;
			[FieldOffset(4)]public uint stride;
			[FieldOffset(8)]public VkVertexInputRate inputRate;
		}

        public static ManagedPtr<VkVertexInputBindingDescription> Pointer(this VkVertexInputBindingDescription i) => new ManagedPtr<VkVertexInputBindingDescription>(i);
        public static ManagedPtrArray<VkVertexInputBindingDescription> Pointer(this VkVertexInputBindingDescription[] i) => new ManagedPtrArray<VkVertexInputBindingDescription>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkVertexInputAttributeDescription {
			[FieldOffset(0)]public uint location;
			[FieldOffset(4)]public uint binding;
			[FieldOffset(8)]public VkFormat format;
			[FieldOffset(12)]public uint offset;
		}

        public static ManagedPtr<VkVertexInputAttributeDescription> Pointer(this VkVertexInputAttributeDescription i) => new ManagedPtr<VkVertexInputAttributeDescription>(i);
        public static ManagedPtrArray<VkVertexInputAttributeDescription> Pointer(this VkVertexInputAttributeDescription[] i) => new ManagedPtrArray<VkVertexInputAttributeDescription>(i);
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
        public static ManagedPtrArray<VkPipelineVertexInputStateCreateInfo> Pointer(this VkPipelineVertexInputStateCreateInfo[] i) => new ManagedPtrArray<VkPipelineVertexInputStateCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineInputAssemblyStateCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public VkPrimitiveTopology topology;
			[FieldOffset(24)]public bool primitiveRestartEnable;
		}

        public static ManagedPtr<VkPipelineInputAssemblyStateCreateInfo> Pointer(this VkPipelineInputAssemblyStateCreateInfo i) => new ManagedPtr<VkPipelineInputAssemblyStateCreateInfo>(i);
        public static ManagedPtrArray<VkPipelineInputAssemblyStateCreateInfo> Pointer(this VkPipelineInputAssemblyStateCreateInfo[] i) => new ManagedPtrArray<VkPipelineInputAssemblyStateCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineTessellationStateCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint patchControlPoints;
		}

        public static ManagedPtr<VkPipelineTessellationStateCreateInfo> Pointer(this VkPipelineTessellationStateCreateInfo i) => new ManagedPtr<VkPipelineTessellationStateCreateInfo>(i);
        public static ManagedPtrArray<VkPipelineTessellationStateCreateInfo> Pointer(this VkPipelineTessellationStateCreateInfo[] i) => new ManagedPtrArray<VkPipelineTessellationStateCreateInfo>(i);
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
        public static ManagedPtrArray<VkViewport> Pointer(this VkViewport[] i) => new ManagedPtrArray<VkViewport>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkOffset2D {
			[FieldOffset(0)]public int x;
			[FieldOffset(4)]public int y;
		}

        public static ManagedPtr<VkOffset2D> Pointer(this VkOffset2D i) => new ManagedPtr<VkOffset2D>(i);
        public static ManagedPtrArray<VkOffset2D> Pointer(this VkOffset2D[] i) => new ManagedPtrArray<VkOffset2D>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExtent2D {
			[FieldOffset(0)]public uint width;
			[FieldOffset(4)]public uint height;
		}

        public static ManagedPtr<VkExtent2D> Pointer(this VkExtent2D i) => new ManagedPtr<VkExtent2D>(i);
        public static ManagedPtrArray<VkExtent2D> Pointer(this VkExtent2D[] i) => new ManagedPtrArray<VkExtent2D>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRect2D {
			[FieldOffset(0)]public VkOffset2D offset;
			[FieldOffset(8)]public VkExtent2D extent;
		}

        public static ManagedPtr<VkRect2D> Pointer(this VkRect2D i) => new ManagedPtr<VkRect2D>(i);
        public static ManagedPtrArray<VkRect2D> Pointer(this VkRect2D[] i) => new ManagedPtrArray<VkRect2D>(i);
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
        public static ManagedPtrArray<VkPipelineViewportStateCreateInfo> Pointer(this VkPipelineViewportStateCreateInfo[] i) => new ManagedPtrArray<VkPipelineViewportStateCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineRasterizationStateCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public bool depthClampEnable;
			[FieldOffset(24)]public bool rasterizerDiscardEnable;
			[FieldOffset(28)]public VkPolygonMode polygonMode;
			[FieldOffset(32)]public VkCullModeFlags cullMode;
			[FieldOffset(36)]public VkFrontFace frontFace;
			[FieldOffset(40)]public bool depthBiasEnable;
			[FieldOffset(44)]public float depthBiasConstantFactor;
			[FieldOffset(48)]public float depthBiasClamp;
			[FieldOffset(52)]public float depthBiasSlopeFactor;
			[FieldOffset(56)]public float lineWidth;
		}

        public static ManagedPtr<VkPipelineRasterizationStateCreateInfo> Pointer(this VkPipelineRasterizationStateCreateInfo i) => new ManagedPtr<VkPipelineRasterizationStateCreateInfo>(i);
        public static ManagedPtrArray<VkPipelineRasterizationStateCreateInfo> Pointer(this VkPipelineRasterizationStateCreateInfo[] i) => new ManagedPtrArray<VkPipelineRasterizationStateCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineMultisampleStateCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public VkSampleCountFlags rasterizationSamples;
			[FieldOffset(24)]public bool sampleShadingEnable;
			[FieldOffset(28)]public float minSampleShading;
			[FieldOffset(32)]public uint* pSampleMask;
			[FieldOffset(40)]public bool alphaToCoverageEnable;
			[FieldOffset(44)]public bool alphaToOneEnable;
		}

        public static ManagedPtr<VkPipelineMultisampleStateCreateInfo> Pointer(this VkPipelineMultisampleStateCreateInfo i) => new ManagedPtr<VkPipelineMultisampleStateCreateInfo>(i);
        public static ManagedPtrArray<VkPipelineMultisampleStateCreateInfo> Pointer(this VkPipelineMultisampleStateCreateInfo[] i) => new ManagedPtrArray<VkPipelineMultisampleStateCreateInfo>(i);
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
        public static ManagedPtrArray<VkStencilOpState> Pointer(this VkStencilOpState[] i) => new ManagedPtrArray<VkStencilOpState>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineDepthStencilStateCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public bool depthTestEnable;
			[FieldOffset(24)]public bool depthWriteEnable;
			[FieldOffset(28)]public VkCompareOp depthCompareOp;
			[FieldOffset(32)]public bool depthBoundsTestEnable;
			[FieldOffset(36)]public bool stencilTestEnable;
			[FieldOffset(40)]public VkStencilOpState front;
			[FieldOffset(68)]public VkStencilOpState back;
			[FieldOffset(96)]public float minDepthBounds;
			[FieldOffset(100)]public float maxDepthBounds;
		}

        public static ManagedPtr<VkPipelineDepthStencilStateCreateInfo> Pointer(this VkPipelineDepthStencilStateCreateInfo i) => new ManagedPtr<VkPipelineDepthStencilStateCreateInfo>(i);
        public static ManagedPtrArray<VkPipelineDepthStencilStateCreateInfo> Pointer(this VkPipelineDepthStencilStateCreateInfo[] i) => new ManagedPtrArray<VkPipelineDepthStencilStateCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineColorBlendAttachmentState {
			[FieldOffset(0)]public bool blendEnable;
			[FieldOffset(4)]public VkBlendFactor srcColorBlendFactor;
			[FieldOffset(8)]public VkBlendFactor dstColorBlendFactor;
			[FieldOffset(12)]public VkBlendOp colorBlendOp;
			[FieldOffset(16)]public VkBlendFactor srcAlphaBlendFactor;
			[FieldOffset(20)]public VkBlendFactor dstAlphaBlendFactor;
			[FieldOffset(24)]public VkBlendOp alphaBlendOp;
			[FieldOffset(28)]public VkColorComponentFlags colorWriteMask;
		}

        public static ManagedPtr<VkPipelineColorBlendAttachmentState> Pointer(this VkPipelineColorBlendAttachmentState i) => new ManagedPtr<VkPipelineColorBlendAttachmentState>(i);
        public static ManagedPtrArray<VkPipelineColorBlendAttachmentState> Pointer(this VkPipelineColorBlendAttachmentState[] i) => new ManagedPtrArray<VkPipelineColorBlendAttachmentState>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineColorBlendStateCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public bool logicOpEnable;
			[FieldOffset(24)]public VkLogicOp logicOp;
			[FieldOffset(28)]public uint attachmentCount;
			[FieldOffset(32)]public IntPtr pAttachments;
			[FieldOffset(40)]public fixed float blendConstants[4];
			public const int blendConstants_len = 4;
		}

        public static ManagedPtr<VkPipelineColorBlendStateCreateInfo> Pointer(this VkPipelineColorBlendStateCreateInfo i) => new ManagedPtr<VkPipelineColorBlendStateCreateInfo>(i);
        public static ManagedPtrArray<VkPipelineColorBlendStateCreateInfo> Pointer(this VkPipelineColorBlendStateCreateInfo[] i) => new ManagedPtrArray<VkPipelineColorBlendStateCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineDynamicStateCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint dynamicStateCount;
			[FieldOffset(24)]public VkDynamicState* pDynamicStates;
		}

        public static ManagedPtr<VkPipelineDynamicStateCreateInfo> Pointer(this VkPipelineDynamicStateCreateInfo i) => new ManagedPtr<VkPipelineDynamicStateCreateInfo>(i);
        public static ManagedPtrArray<VkPipelineDynamicStateCreateInfo> Pointer(this VkPipelineDynamicStateCreateInfo[] i) => new ManagedPtrArray<VkPipelineDynamicStateCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkGraphicsPipelineCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPipelineCreateFlags flags;
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
        public static ManagedPtrArray<VkGraphicsPipelineCreateInfo> Pointer(this VkGraphicsPipelineCreateInfo[] i) => new ManagedPtrArray<VkGraphicsPipelineCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkComputePipelineCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPipelineCreateFlags flags;
			[FieldOffset(24)]public VkPipelineShaderStageCreateInfo stage;
			[FieldOffset(72)]public IntPtr layout;
			[FieldOffset(80)]public IntPtr basePipelineHandle;
			[FieldOffset(88)]public int basePipelineIndex;
		}

        public static ManagedPtr<VkComputePipelineCreateInfo> Pointer(this VkComputePipelineCreateInfo i) => new ManagedPtr<VkComputePipelineCreateInfo>(i);
        public static ManagedPtrArray<VkComputePipelineCreateInfo> Pointer(this VkComputePipelineCreateInfo[] i) => new ManagedPtrArray<VkComputePipelineCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPushConstantRange {
			[FieldOffset(0)]public VkShaderStageFlags stageFlags;
			[FieldOffset(4)]public uint offset;
			[FieldOffset(8)]public uint size;
		}

        public static ManagedPtr<VkPushConstantRange> Pointer(this VkPushConstantRange i) => new ManagedPtr<VkPushConstantRange>(i);
        public static ManagedPtrArray<VkPushConstantRange> Pointer(this VkPushConstantRange[] i) => new ManagedPtrArray<VkPushConstantRange>(i);
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
        public static ManagedPtrArray<VkPipelineLayoutCreateInfo> Pointer(this VkPipelineLayoutCreateInfo[] i) => new ManagedPtrArray<VkPipelineLayoutCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSamplerCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkSamplerCreateFlags flags;
			[FieldOffset(20)]public VkFilter magFilter;
			[FieldOffset(24)]public VkFilter minFilter;
			[FieldOffset(28)]public VkSamplerMipmapMode mipmapMode;
			[FieldOffset(32)]public VkSamplerAddressMode addressModeU;
			[FieldOffset(36)]public VkSamplerAddressMode addressModeV;
			[FieldOffset(40)]public VkSamplerAddressMode addressModeW;
			[FieldOffset(44)]public float mipLodBias;
			[FieldOffset(48)]public bool anisotropyEnable;
			[FieldOffset(52)]public float maxAnisotropy;
			[FieldOffset(56)]public bool compareEnable;
			[FieldOffset(60)]public VkCompareOp compareOp;
			[FieldOffset(64)]public float minLod;
			[FieldOffset(68)]public float maxLod;
			[FieldOffset(72)]public VkBorderColor borderColor;
			[FieldOffset(76)]public bool unnormalizedCoordinates;
		}

        public static ManagedPtr<VkSamplerCreateInfo> Pointer(this VkSamplerCreateInfo i) => new ManagedPtr<VkSamplerCreateInfo>(i);
        public static ManagedPtrArray<VkSamplerCreateInfo> Pointer(this VkSamplerCreateInfo[] i) => new ManagedPtrArray<VkSamplerCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorSetLayoutBinding {
			[FieldOffset(0)]public uint binding;
			[FieldOffset(4)]public VkDescriptorType descriptorType;
			[FieldOffset(8)]public uint descriptorCount;
			[FieldOffset(12)]public VkShaderStageFlags stageFlags;
			[FieldOffset(16)]public IntPtr* pImmutableSamplers;
		}

        public static ManagedPtr<VkDescriptorSetLayoutBinding> Pointer(this VkDescriptorSetLayoutBinding i) => new ManagedPtr<VkDescriptorSetLayoutBinding>(i);
        public static ManagedPtrArray<VkDescriptorSetLayoutBinding> Pointer(this VkDescriptorSetLayoutBinding[] i) => new ManagedPtrArray<VkDescriptorSetLayoutBinding>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorSetLayoutCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDescriptorSetLayoutCreateFlags flags;
			[FieldOffset(20)]public uint bindingCount;
			[FieldOffset(24)]public IntPtr pBindings;
		}

        public static ManagedPtr<VkDescriptorSetLayoutCreateInfo> Pointer(this VkDescriptorSetLayoutCreateInfo i) => new ManagedPtr<VkDescriptorSetLayoutCreateInfo>(i);
        public static ManagedPtrArray<VkDescriptorSetLayoutCreateInfo> Pointer(this VkDescriptorSetLayoutCreateInfo[] i) => new ManagedPtrArray<VkDescriptorSetLayoutCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorPoolSize {
			[FieldOffset(0)]public VkDescriptorType type;
			[FieldOffset(4)]public uint descriptorCount;
		}

        public static ManagedPtr<VkDescriptorPoolSize> Pointer(this VkDescriptorPoolSize i) => new ManagedPtr<VkDescriptorPoolSize>(i);
        public static ManagedPtrArray<VkDescriptorPoolSize> Pointer(this VkDescriptorPoolSize[] i) => new ManagedPtrArray<VkDescriptorPoolSize>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorPoolCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDescriptorPoolCreateFlags flags;
			[FieldOffset(20)]public uint maxSets;
			[FieldOffset(24)]public uint poolSizeCount;
			[FieldOffset(32)]public IntPtr pPoolSizes;
		}

        public static ManagedPtr<VkDescriptorPoolCreateInfo> Pointer(this VkDescriptorPoolCreateInfo i) => new ManagedPtr<VkDescriptorPoolCreateInfo>(i);
        public static ManagedPtrArray<VkDescriptorPoolCreateInfo> Pointer(this VkDescriptorPoolCreateInfo[] i) => new ManagedPtrArray<VkDescriptorPoolCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorSetAllocateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr descriptorPool;
			[FieldOffset(24)]public uint descriptorSetCount;
			[FieldOffset(32)]public IntPtr* pSetLayouts;
		}

        public static ManagedPtr<VkDescriptorSetAllocateInfo> Pointer(this VkDescriptorSetAllocateInfo i) => new ManagedPtr<VkDescriptorSetAllocateInfo>(i);
        public static ManagedPtrArray<VkDescriptorSetAllocateInfo> Pointer(this VkDescriptorSetAllocateInfo[] i) => new ManagedPtrArray<VkDescriptorSetAllocateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorImageInfo {
			[FieldOffset(0)]public IntPtr sampler;
			[FieldOffset(8)]public IntPtr imageView;
			[FieldOffset(16)]public VkImageLayout imageLayout;
		}

        public static ManagedPtr<VkDescriptorImageInfo> Pointer(this VkDescriptorImageInfo i) => new ManagedPtr<VkDescriptorImageInfo>(i);
        public static ManagedPtrArray<VkDescriptorImageInfo> Pointer(this VkDescriptorImageInfo[] i) => new ManagedPtrArray<VkDescriptorImageInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorBufferInfo {
			[FieldOffset(0)]public IntPtr buffer;
			[FieldOffset(8)]public ulong offset;
			[FieldOffset(16)]public ulong range;
		}

        public static ManagedPtr<VkDescriptorBufferInfo> Pointer(this VkDescriptorBufferInfo i) => new ManagedPtr<VkDescriptorBufferInfo>(i);
        public static ManagedPtrArray<VkDescriptorBufferInfo> Pointer(this VkDescriptorBufferInfo[] i) => new ManagedPtrArray<VkDescriptorBufferInfo>(i);
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
        public static ManagedPtrArray<VkWriteDescriptorSet> Pointer(this VkWriteDescriptorSet[] i) => new ManagedPtrArray<VkWriteDescriptorSet>(i);
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
        public static ManagedPtrArray<VkCopyDescriptorSet> Pointer(this VkCopyDescriptorSet[] i) => new ManagedPtrArray<VkCopyDescriptorSet>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkFramebufferCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkFramebufferCreateFlags flags;
			[FieldOffset(24)]public IntPtr renderPass;
			[FieldOffset(32)]public uint attachmentCount;
			[FieldOffset(40)]public IntPtr* pAttachments;
			[FieldOffset(48)]public uint width;
			[FieldOffset(52)]public uint height;
			[FieldOffset(56)]public uint layers;
		}

        public static ManagedPtr<VkFramebufferCreateInfo> Pointer(this VkFramebufferCreateInfo i) => new ManagedPtr<VkFramebufferCreateInfo>(i);
        public static ManagedPtrArray<VkFramebufferCreateInfo> Pointer(this VkFramebufferCreateInfo[] i) => new ManagedPtrArray<VkFramebufferCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAttachmentDescription {
			[FieldOffset(0)]public VkAttachmentDescriptionFlags flags;
			[FieldOffset(4)]public VkFormat format;
			[FieldOffset(8)]public VkSampleCountFlags samples;
			[FieldOffset(12)]public VkAttachmentLoadOp loadOp;
			[FieldOffset(16)]public VkAttachmentStoreOp storeOp;
			[FieldOffset(20)]public VkAttachmentLoadOp stencilLoadOp;
			[FieldOffset(24)]public VkAttachmentStoreOp stencilStoreOp;
			[FieldOffset(28)]public VkImageLayout initialLayout;
			[FieldOffset(32)]public VkImageLayout finalLayout;
		}

        public static ManagedPtr<VkAttachmentDescription> Pointer(this VkAttachmentDescription i) => new ManagedPtr<VkAttachmentDescription>(i);
        public static ManagedPtrArray<VkAttachmentDescription> Pointer(this VkAttachmentDescription[] i) => new ManagedPtrArray<VkAttachmentDescription>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAttachmentReference {
			[FieldOffset(0)]public uint attachment;
			[FieldOffset(4)]public VkImageLayout layout;
		}

        public static ManagedPtr<VkAttachmentReference> Pointer(this VkAttachmentReference i) => new ManagedPtr<VkAttachmentReference>(i);
        public static ManagedPtrArray<VkAttachmentReference> Pointer(this VkAttachmentReference[] i) => new ManagedPtrArray<VkAttachmentReference>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSubpassDescription {
			[FieldOffset(0)]public VkSubpassDescriptionFlags flags;
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
        public static ManagedPtrArray<VkSubpassDescription> Pointer(this VkSubpassDescription[] i) => new ManagedPtrArray<VkSubpassDescription>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSubpassDependency {
			[FieldOffset(0)]public uint srcSubpass;
			[FieldOffset(4)]public uint dstSubpass;
			[FieldOffset(8)]public VkPipelineStageFlags srcStageMask;
			[FieldOffset(12)]public VkPipelineStageFlags dstStageMask;
			[FieldOffset(16)]public VkAccessFlags srcAccessMask;
			[FieldOffset(20)]public VkAccessFlags dstAccessMask;
			[FieldOffset(24)]public VkDependencyFlags dependencyFlags;
		}

        public static ManagedPtr<VkSubpassDependency> Pointer(this VkSubpassDependency i) => new ManagedPtr<VkSubpassDependency>(i);
        public static ManagedPtrArray<VkSubpassDependency> Pointer(this VkSubpassDependency[] i) => new ManagedPtrArray<VkSubpassDependency>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRenderPassCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkRenderPassCreateFlags flags;
			[FieldOffset(20)]public uint attachmentCount;
			[FieldOffset(24)]public IntPtr pAttachments;
			[FieldOffset(32)]public uint subpassCount;
			[FieldOffset(40)]public IntPtr pSubpasses;
			[FieldOffset(48)]public uint dependencyCount;
			[FieldOffset(56)]public IntPtr pDependencies;
		}

        public static ManagedPtr<VkRenderPassCreateInfo> Pointer(this VkRenderPassCreateInfo i) => new ManagedPtr<VkRenderPassCreateInfo>(i);
        public static ManagedPtrArray<VkRenderPassCreateInfo> Pointer(this VkRenderPassCreateInfo[] i) => new ManagedPtrArray<VkRenderPassCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkCommandPoolCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkCommandPoolCreateFlags flags;
			[FieldOffset(20)]public uint queueFamilyIndex;
		}

        public static ManagedPtr<VkCommandPoolCreateInfo> Pointer(this VkCommandPoolCreateInfo i) => new ManagedPtr<VkCommandPoolCreateInfo>(i);
        public static ManagedPtrArray<VkCommandPoolCreateInfo> Pointer(this VkCommandPoolCreateInfo[] i) => new ManagedPtrArray<VkCommandPoolCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkCommandBufferAllocateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr commandPool;
			[FieldOffset(24)]public VkCommandBufferLevel level;
			[FieldOffset(28)]public uint commandBufferCount;
		}

        public static ManagedPtr<VkCommandBufferAllocateInfo> Pointer(this VkCommandBufferAllocateInfo i) => new ManagedPtr<VkCommandBufferAllocateInfo>(i);
        public static ManagedPtrArray<VkCommandBufferAllocateInfo> Pointer(this VkCommandBufferAllocateInfo[] i) => new ManagedPtrArray<VkCommandBufferAllocateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkCommandBufferInheritanceInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr renderPass;
			[FieldOffset(24)]public uint subpass;
			[FieldOffset(32)]public IntPtr framebuffer;
			[FieldOffset(40)]public bool occlusionQueryEnable;
			[FieldOffset(44)]public VkQueryControlFlags queryFlags;
			[FieldOffset(48)]public VkQueryPipelineStatisticFlags pipelineStatistics;
		}

        public static ManagedPtr<VkCommandBufferInheritanceInfo> Pointer(this VkCommandBufferInheritanceInfo i) => new ManagedPtr<VkCommandBufferInheritanceInfo>(i);
        public static ManagedPtrArray<VkCommandBufferInheritanceInfo> Pointer(this VkCommandBufferInheritanceInfo[] i) => new ManagedPtrArray<VkCommandBufferInheritanceInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkCommandBufferBeginInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkCommandBufferUsageFlags flags;
			[FieldOffset(24)]public IntPtr pInheritanceInfo;
		}

        public static ManagedPtr<VkCommandBufferBeginInfo> Pointer(this VkCommandBufferBeginInfo i) => new ManagedPtr<VkCommandBufferBeginInfo>(i);
        public static ManagedPtrArray<VkCommandBufferBeginInfo> Pointer(this VkCommandBufferBeginInfo[] i) => new ManagedPtrArray<VkCommandBufferBeginInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBufferCopy {
			[FieldOffset(0)]public ulong srcOffset;
			[FieldOffset(8)]public ulong dstOffset;
			[FieldOffset(16)]public ulong size;
		}

        public static ManagedPtr<VkBufferCopy> Pointer(this VkBufferCopy i) => new ManagedPtr<VkBufferCopy>(i);
        public static ManagedPtrArray<VkBufferCopy> Pointer(this VkBufferCopy[] i) => new ManagedPtrArray<VkBufferCopy>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageSubresourceLayers {
			[FieldOffset(0)]public VkImageAspectFlags aspectMask;
			[FieldOffset(4)]public uint mipLevel;
			[FieldOffset(8)]public uint baseArrayLayer;
			[FieldOffset(12)]public uint layerCount;
		}

        public static ManagedPtr<VkImageSubresourceLayers> Pointer(this VkImageSubresourceLayers i) => new ManagedPtr<VkImageSubresourceLayers>(i);
        public static ManagedPtrArray<VkImageSubresourceLayers> Pointer(this VkImageSubresourceLayers[] i) => new ManagedPtrArray<VkImageSubresourceLayers>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageCopy {
			[FieldOffset(0)]public VkImageSubresourceLayers srcSubresource;
			[FieldOffset(16)]public VkOffset3D srcOffset;
			[FieldOffset(28)]public VkImageSubresourceLayers dstSubresource;
			[FieldOffset(44)]public VkOffset3D dstOffset;
			[FieldOffset(56)]public VkExtent3D extent;
		}

        public static ManagedPtr<VkImageCopy> Pointer(this VkImageCopy i) => new ManagedPtr<VkImageCopy>(i);
        public static ManagedPtrArray<VkImageCopy> Pointer(this VkImageCopy[] i) => new ManagedPtrArray<VkImageCopy>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageBlit {
			[FieldOffset(0)]public VkImageSubresourceLayers srcSubresource;
			[FieldOffset(16)][MarshalAs(UnmanagedType.ByValArray, SizeConst=2)] public VkOffset3D[] srcOffsets;
			public const int srcOffsets_len = 2;
			[FieldOffset(40)]public VkImageSubresourceLayers dstSubresource;
			[FieldOffset(56)][MarshalAs(UnmanagedType.ByValArray, SizeConst=2)] public VkOffset3D[] dstOffsets;
			public const int dstOffsets_len = 2;
		}

        public static ManagedPtr<VkImageBlit> Pointer(this VkImageBlit i) => new ManagedPtr<VkImageBlit>(i);
        public static ManagedPtrArray<VkImageBlit> Pointer(this VkImageBlit[] i) => new ManagedPtrArray<VkImageBlit>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBufferImageCopy {
			[FieldOffset(0)]public ulong bufferOffset;
			[FieldOffset(8)]public uint bufferRowLength;
			[FieldOffset(12)]public uint bufferImageHeight;
			[FieldOffset(16)]public VkImageSubresourceLayers imageSubresource;
			[FieldOffset(32)]public VkOffset3D imageOffset;
			[FieldOffset(44)]public VkExtent3D imageExtent;
		}

        public static ManagedPtr<VkBufferImageCopy> Pointer(this VkBufferImageCopy i) => new ManagedPtr<VkBufferImageCopy>(i);
        public static ManagedPtrArray<VkBufferImageCopy> Pointer(this VkBufferImageCopy[] i) => new ManagedPtrArray<VkBufferImageCopy>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkClearDepthStencilValue {
			[FieldOffset(0)]public float depth;
			[FieldOffset(4)]public uint stencil;
		}

        public static ManagedPtr<VkClearDepthStencilValue> Pointer(this VkClearDepthStencilValue i) => new ManagedPtr<VkClearDepthStencilValue>(i);
        public static ManagedPtrArray<VkClearDepthStencilValue> Pointer(this VkClearDepthStencilValue[] i) => new ManagedPtrArray<VkClearDepthStencilValue>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkClearAttachment {
			[FieldOffset(0)]public VkImageAspectFlags aspectMask;
			[FieldOffset(4)]public uint colorAttachment;
			[FieldOffset(8)]public VkClearValue clearValue;
		}

        public static ManagedPtr<VkClearAttachment> Pointer(this VkClearAttachment i) => new ManagedPtr<VkClearAttachment>(i);
        public static ManagedPtrArray<VkClearAttachment> Pointer(this VkClearAttachment[] i) => new ManagedPtrArray<VkClearAttachment>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkClearRect {
			[FieldOffset(0)]public VkRect2D rect;
			[FieldOffset(16)]public uint baseArrayLayer;
			[FieldOffset(20)]public uint layerCount;
		}

        public static ManagedPtr<VkClearRect> Pointer(this VkClearRect i) => new ManagedPtr<VkClearRect>(i);
        public static ManagedPtrArray<VkClearRect> Pointer(this VkClearRect[] i) => new ManagedPtrArray<VkClearRect>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageResolve {
			[FieldOffset(0)]public VkImageSubresourceLayers srcSubresource;
			[FieldOffset(16)]public VkOffset3D srcOffset;
			[FieldOffset(28)]public VkImageSubresourceLayers dstSubresource;
			[FieldOffset(44)]public VkOffset3D dstOffset;
			[FieldOffset(56)]public VkExtent3D extent;
		}

        public static ManagedPtr<VkImageResolve> Pointer(this VkImageResolve i) => new ManagedPtr<VkImageResolve>(i);
        public static ManagedPtrArray<VkImageResolve> Pointer(this VkImageResolve[] i) => new ManagedPtrArray<VkImageResolve>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryBarrier {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkAccessFlags srcAccessMask;
			[FieldOffset(20)]public VkAccessFlags dstAccessMask;
		}

        public static ManagedPtr<VkMemoryBarrier> Pointer(this VkMemoryBarrier i) => new ManagedPtr<VkMemoryBarrier>(i);
        public static ManagedPtrArray<VkMemoryBarrier> Pointer(this VkMemoryBarrier[] i) => new ManagedPtrArray<VkMemoryBarrier>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBufferMemoryBarrier {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkAccessFlags srcAccessMask;
			[FieldOffset(20)]public VkAccessFlags dstAccessMask;
			[FieldOffset(24)]public uint srcQueueFamilyIndex;
			[FieldOffset(28)]public uint dstQueueFamilyIndex;
			[FieldOffset(32)]public IntPtr buffer;
			[FieldOffset(40)]public ulong offset;
			[FieldOffset(48)]public ulong size;
		}

        public static ManagedPtr<VkBufferMemoryBarrier> Pointer(this VkBufferMemoryBarrier i) => new ManagedPtr<VkBufferMemoryBarrier>(i);
        public static ManagedPtrArray<VkBufferMemoryBarrier> Pointer(this VkBufferMemoryBarrier[] i) => new ManagedPtrArray<VkBufferMemoryBarrier>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageMemoryBarrier {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkAccessFlags srcAccessMask;
			[FieldOffset(20)]public VkAccessFlags dstAccessMask;
			[FieldOffset(24)]public VkImageLayout oldLayout;
			[FieldOffset(28)]public VkImageLayout newLayout;
			[FieldOffset(32)]public uint srcQueueFamilyIndex;
			[FieldOffset(36)]public uint dstQueueFamilyIndex;
			[FieldOffset(40)]public IntPtr image;
			[FieldOffset(48)]public VkImageSubresourceRange subresourceRange;
		}

        public static ManagedPtr<VkImageMemoryBarrier> Pointer(this VkImageMemoryBarrier i) => new ManagedPtr<VkImageMemoryBarrier>(i);
        public static ManagedPtrArray<VkImageMemoryBarrier> Pointer(this VkImageMemoryBarrier[] i) => new ManagedPtrArray<VkImageMemoryBarrier>(i);
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
        public static ManagedPtrArray<VkRenderPassBeginInfo> Pointer(this VkRenderPassBeginInfo[] i) => new ManagedPtrArray<VkRenderPassBeginInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDispatchIndirectCommand {
			[FieldOffset(0)]public uint x;
			[FieldOffset(4)]public uint y;
			[FieldOffset(8)]public uint z;
		}

        public static ManagedPtr<VkDispatchIndirectCommand> Pointer(this VkDispatchIndirectCommand i) => new ManagedPtr<VkDispatchIndirectCommand>(i);
        public static ManagedPtrArray<VkDispatchIndirectCommand> Pointer(this VkDispatchIndirectCommand[] i) => new ManagedPtrArray<VkDispatchIndirectCommand>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDrawIndexedIndirectCommand {
			[FieldOffset(0)]public uint indexCount;
			[FieldOffset(4)]public uint instanceCount;
			[FieldOffset(8)]public uint firstIndex;
			[FieldOffset(12)]public int vertexOffset;
			[FieldOffset(16)]public uint firstInstance;
		}

        public static ManagedPtr<VkDrawIndexedIndirectCommand> Pointer(this VkDrawIndexedIndirectCommand i) => new ManagedPtr<VkDrawIndexedIndirectCommand>(i);
        public static ManagedPtrArray<VkDrawIndexedIndirectCommand> Pointer(this VkDrawIndexedIndirectCommand[] i) => new ManagedPtrArray<VkDrawIndexedIndirectCommand>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDrawIndirectCommand {
			[FieldOffset(0)]public uint vertexCount;
			[FieldOffset(4)]public uint instanceCount;
			[FieldOffset(8)]public uint firstVertex;
			[FieldOffset(12)]public uint firstInstance;
		}

        public static ManagedPtr<VkDrawIndirectCommand> Pointer(this VkDrawIndirectCommand i) => new ManagedPtr<VkDrawIndirectCommand>(i);
        public static ManagedPtrArray<VkDrawIndirectCommand> Pointer(this VkDrawIndirectCommand[] i) => new ManagedPtrArray<VkDrawIndirectCommand>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBaseOutStructure {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
		}

        public static ManagedPtr<VkBaseOutStructure> Pointer(this VkBaseOutStructure i) => new ManagedPtr<VkBaseOutStructure>(i);
        public static ManagedPtrArray<VkBaseOutStructure> Pointer(this VkBaseOutStructure[] i) => new ManagedPtrArray<VkBaseOutStructure>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBaseInStructure {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
		}

        public static ManagedPtr<VkBaseInStructure> Pointer(this VkBaseInStructure i) => new ManagedPtr<VkBaseInStructure>(i);
        public static ManagedPtrArray<VkBaseInStructure> Pointer(this VkBaseInStructure[] i) => new ManagedPtrArray<VkBaseInStructure>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceSubgroupProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint subgroupSize;
			[FieldOffset(20)]public VkShaderStageFlags supportedStages;
			[FieldOffset(24)]public VkSubgroupFeatureFlags supportedOperations;
			[FieldOffset(28)]public bool quadOperationsInAllStages;
		}

        public static ManagedPtr<VkPhysicalDeviceSubgroupProperties> Pointer(this VkPhysicalDeviceSubgroupProperties i) => new ManagedPtr<VkPhysicalDeviceSubgroupProperties>(i);
        public static ManagedPtrArray<VkPhysicalDeviceSubgroupProperties> Pointer(this VkPhysicalDeviceSubgroupProperties[] i) => new ManagedPtrArray<VkPhysicalDeviceSubgroupProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBindBufferMemoryInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr buffer;
			[FieldOffset(24)]public IntPtr memory;
			[FieldOffset(32)]public ulong memoryOffset;
		}

        public static ManagedPtr<VkBindBufferMemoryInfo> Pointer(this VkBindBufferMemoryInfo i) => new ManagedPtr<VkBindBufferMemoryInfo>(i);
        public static ManagedPtrArray<VkBindBufferMemoryInfo> Pointer(this VkBindBufferMemoryInfo[] i) => new ManagedPtrArray<VkBindBufferMemoryInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBindImageMemoryInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr image;
			[FieldOffset(24)]public IntPtr memory;
			[FieldOffset(32)]public ulong memoryOffset;
		}

        public static ManagedPtr<VkBindImageMemoryInfo> Pointer(this VkBindImageMemoryInfo i) => new ManagedPtr<VkBindImageMemoryInfo>(i);
        public static ManagedPtrArray<VkBindImageMemoryInfo> Pointer(this VkBindImageMemoryInfo[] i) => new ManagedPtrArray<VkBindImageMemoryInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDevice16BitStorageFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool storageBuffer16BitAccess;
			[FieldOffset(20)]public bool uniformAndStorageBuffer16BitAccess;
			[FieldOffset(24)]public bool storagePushConstant16;
			[FieldOffset(28)]public bool storageInputOutput16;
		}

        public static ManagedPtr<VkPhysicalDevice16BitStorageFeatures> Pointer(this VkPhysicalDevice16BitStorageFeatures i) => new ManagedPtr<VkPhysicalDevice16BitStorageFeatures>(i);
        public static ManagedPtrArray<VkPhysicalDevice16BitStorageFeatures> Pointer(this VkPhysicalDevice16BitStorageFeatures[] i) => new ManagedPtrArray<VkPhysicalDevice16BitStorageFeatures>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryDedicatedRequirements {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool prefersDedicatedAllocation;
			[FieldOffset(20)]public bool requiresDedicatedAllocation;
		}

        public static ManagedPtr<VkMemoryDedicatedRequirements> Pointer(this VkMemoryDedicatedRequirements i) => new ManagedPtr<VkMemoryDedicatedRequirements>(i);
        public static ManagedPtrArray<VkMemoryDedicatedRequirements> Pointer(this VkMemoryDedicatedRequirements[] i) => new ManagedPtrArray<VkMemoryDedicatedRequirements>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryDedicatedAllocateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr image;
			[FieldOffset(24)]public IntPtr buffer;
		}

        public static ManagedPtr<VkMemoryDedicatedAllocateInfo> Pointer(this VkMemoryDedicatedAllocateInfo i) => new ManagedPtr<VkMemoryDedicatedAllocateInfo>(i);
        public static ManagedPtrArray<VkMemoryDedicatedAllocateInfo> Pointer(this VkMemoryDedicatedAllocateInfo[] i) => new ManagedPtrArray<VkMemoryDedicatedAllocateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryAllocateFlagsInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkMemoryAllocateFlags flags;
			[FieldOffset(20)]public uint deviceMask;
		}

        public static ManagedPtr<VkMemoryAllocateFlagsInfo> Pointer(this VkMemoryAllocateFlagsInfo i) => new ManagedPtr<VkMemoryAllocateFlagsInfo>(i);
        public static ManagedPtrArray<VkMemoryAllocateFlagsInfo> Pointer(this VkMemoryAllocateFlagsInfo[] i) => new ManagedPtrArray<VkMemoryAllocateFlagsInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceGroupRenderPassBeginInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint deviceMask;
			[FieldOffset(20)]public uint deviceRenderAreaCount;
			[FieldOffset(24)]public IntPtr pDeviceRenderAreas;
		}

        public static ManagedPtr<VkDeviceGroupRenderPassBeginInfo> Pointer(this VkDeviceGroupRenderPassBeginInfo i) => new ManagedPtr<VkDeviceGroupRenderPassBeginInfo>(i);
        public static ManagedPtrArray<VkDeviceGroupRenderPassBeginInfo> Pointer(this VkDeviceGroupRenderPassBeginInfo[] i) => new ManagedPtrArray<VkDeviceGroupRenderPassBeginInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceGroupCommandBufferBeginInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint deviceMask;
		}

        public static ManagedPtr<VkDeviceGroupCommandBufferBeginInfo> Pointer(this VkDeviceGroupCommandBufferBeginInfo i) => new ManagedPtr<VkDeviceGroupCommandBufferBeginInfo>(i);
        public static ManagedPtrArray<VkDeviceGroupCommandBufferBeginInfo> Pointer(this VkDeviceGroupCommandBufferBeginInfo[] i) => new ManagedPtrArray<VkDeviceGroupCommandBufferBeginInfo>(i);
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
        public static ManagedPtrArray<VkDeviceGroupSubmitInfo> Pointer(this VkDeviceGroupSubmitInfo[] i) => new ManagedPtrArray<VkDeviceGroupSubmitInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceGroupBindSparseInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint resourceDeviceIndex;
			[FieldOffset(20)]public uint memoryDeviceIndex;
		}

        public static ManagedPtr<VkDeviceGroupBindSparseInfo> Pointer(this VkDeviceGroupBindSparseInfo i) => new ManagedPtr<VkDeviceGroupBindSparseInfo>(i);
        public static ManagedPtrArray<VkDeviceGroupBindSparseInfo> Pointer(this VkDeviceGroupBindSparseInfo[] i) => new ManagedPtrArray<VkDeviceGroupBindSparseInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBindBufferMemoryDeviceGroupInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint deviceIndexCount;
			[FieldOffset(24)]public uint* pDeviceIndices;
		}

        public static ManagedPtr<VkBindBufferMemoryDeviceGroupInfo> Pointer(this VkBindBufferMemoryDeviceGroupInfo i) => new ManagedPtr<VkBindBufferMemoryDeviceGroupInfo>(i);
        public static ManagedPtrArray<VkBindBufferMemoryDeviceGroupInfo> Pointer(this VkBindBufferMemoryDeviceGroupInfo[] i) => new ManagedPtrArray<VkBindBufferMemoryDeviceGroupInfo>(i);
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
        public static ManagedPtrArray<VkBindImageMemoryDeviceGroupInfo> Pointer(this VkBindImageMemoryDeviceGroupInfo[] i) => new ManagedPtrArray<VkBindImageMemoryDeviceGroupInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceGroupProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint physicalDeviceCount;
			[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray, SizeConst=32)] public IntPtr[] physicalDevices;
			public const int physicalDevices_len = 32;
			[FieldOffset(280)]public bool subsetAllocation;
		}

        public static ManagedPtr<VkPhysicalDeviceGroupProperties> Pointer(this VkPhysicalDeviceGroupProperties i) => new ManagedPtr<VkPhysicalDeviceGroupProperties>(i);
        public static ManagedPtrArray<VkPhysicalDeviceGroupProperties> Pointer(this VkPhysicalDeviceGroupProperties[] i) => new ManagedPtrArray<VkPhysicalDeviceGroupProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceGroupDeviceCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint physicalDeviceCount;
			[FieldOffset(24)]public IntPtr* pPhysicalDevices;
		}

        public static ManagedPtr<VkDeviceGroupDeviceCreateInfo> Pointer(this VkDeviceGroupDeviceCreateInfo i) => new ManagedPtr<VkDeviceGroupDeviceCreateInfo>(i);
        public static ManagedPtrArray<VkDeviceGroupDeviceCreateInfo> Pointer(this VkDeviceGroupDeviceCreateInfo[] i) => new ManagedPtrArray<VkDeviceGroupDeviceCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBufferMemoryRequirementsInfo2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr buffer;
		}

        public static ManagedPtr<VkBufferMemoryRequirementsInfo2> Pointer(this VkBufferMemoryRequirementsInfo2 i) => new ManagedPtr<VkBufferMemoryRequirementsInfo2>(i);
        public static ManagedPtrArray<VkBufferMemoryRequirementsInfo2> Pointer(this VkBufferMemoryRequirementsInfo2[] i) => new ManagedPtrArray<VkBufferMemoryRequirementsInfo2>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageMemoryRequirementsInfo2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr image;
		}

        public static ManagedPtr<VkImageMemoryRequirementsInfo2> Pointer(this VkImageMemoryRequirementsInfo2 i) => new ManagedPtr<VkImageMemoryRequirementsInfo2>(i);
        public static ManagedPtrArray<VkImageMemoryRequirementsInfo2> Pointer(this VkImageMemoryRequirementsInfo2[] i) => new ManagedPtrArray<VkImageMemoryRequirementsInfo2>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageSparseMemoryRequirementsInfo2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr image;
		}

        public static ManagedPtr<VkImageSparseMemoryRequirementsInfo2> Pointer(this VkImageSparseMemoryRequirementsInfo2 i) => new ManagedPtr<VkImageSparseMemoryRequirementsInfo2>(i);
        public static ManagedPtrArray<VkImageSparseMemoryRequirementsInfo2> Pointer(this VkImageSparseMemoryRequirementsInfo2[] i) => new ManagedPtrArray<VkImageSparseMemoryRequirementsInfo2>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryRequirements2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkMemoryRequirements memoryRequirements;
		}

        public static ManagedPtr<VkMemoryRequirements2> Pointer(this VkMemoryRequirements2 i) => new ManagedPtr<VkMemoryRequirements2>(i);
        public static ManagedPtrArray<VkMemoryRequirements2> Pointer(this VkMemoryRequirements2[] i) => new ManagedPtrArray<VkMemoryRequirements2>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSparseImageMemoryRequirements2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkSparseImageMemoryRequirements memoryRequirements;
		}

        public static ManagedPtr<VkSparseImageMemoryRequirements2> Pointer(this VkSparseImageMemoryRequirements2 i) => new ManagedPtr<VkSparseImageMemoryRequirements2>(i);
        public static ManagedPtrArray<VkSparseImageMemoryRequirements2> Pointer(this VkSparseImageMemoryRequirements2[] i) => new ManagedPtrArray<VkSparseImageMemoryRequirements2>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceFeatures2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPhysicalDeviceFeatures features;
		}

        public static ManagedPtr<VkPhysicalDeviceFeatures2> Pointer(this VkPhysicalDeviceFeatures2 i) => new ManagedPtr<VkPhysicalDeviceFeatures2>(i);
        public static ManagedPtrArray<VkPhysicalDeviceFeatures2> Pointer(this VkPhysicalDeviceFeatures2[] i) => new ManagedPtrArray<VkPhysicalDeviceFeatures2>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceProperties2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPhysicalDeviceProperties properties;
		}

        public static ManagedPtr<VkPhysicalDeviceProperties2> Pointer(this VkPhysicalDeviceProperties2 i) => new ManagedPtr<VkPhysicalDeviceProperties2>(i);
        public static ManagedPtrArray<VkPhysicalDeviceProperties2> Pointer(this VkPhysicalDeviceProperties2[] i) => new ManagedPtrArray<VkPhysicalDeviceProperties2>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkFormatProperties2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkFormatProperties formatProperties;
		}

        public static ManagedPtr<VkFormatProperties2> Pointer(this VkFormatProperties2 i) => new ManagedPtr<VkFormatProperties2>(i);
        public static ManagedPtrArray<VkFormatProperties2> Pointer(this VkFormatProperties2[] i) => new ManagedPtrArray<VkFormatProperties2>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageFormatProperties2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkImageFormatProperties imageFormatProperties;
		}

        public static ManagedPtr<VkImageFormatProperties2> Pointer(this VkImageFormatProperties2 i) => new ManagedPtr<VkImageFormatProperties2>(i);
        public static ManagedPtrArray<VkImageFormatProperties2> Pointer(this VkImageFormatProperties2[] i) => new ManagedPtrArray<VkImageFormatProperties2>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceImageFormatInfo2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkFormat format;
			[FieldOffset(20)]public VkImageType type;
			[FieldOffset(24)]public VkImageTiling tiling;
			[FieldOffset(28)]public VkImageUsageFlags usage;
			[FieldOffset(32)]public VkImageCreateFlags flags;
		}

        public static ManagedPtr<VkPhysicalDeviceImageFormatInfo2> Pointer(this VkPhysicalDeviceImageFormatInfo2 i) => new ManagedPtr<VkPhysicalDeviceImageFormatInfo2>(i);
        public static ManagedPtrArray<VkPhysicalDeviceImageFormatInfo2> Pointer(this VkPhysicalDeviceImageFormatInfo2[] i) => new ManagedPtrArray<VkPhysicalDeviceImageFormatInfo2>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkQueueFamilyProperties2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkQueueFamilyProperties queueFamilyProperties;
		}

        public static ManagedPtr<VkQueueFamilyProperties2> Pointer(this VkQueueFamilyProperties2 i) => new ManagedPtr<VkQueueFamilyProperties2>(i);
        public static ManagedPtrArray<VkQueueFamilyProperties2> Pointer(this VkQueueFamilyProperties2[] i) => new ManagedPtrArray<VkQueueFamilyProperties2>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceMemoryProperties2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPhysicalDeviceMemoryProperties memoryProperties;
		}

        public static ManagedPtr<VkPhysicalDeviceMemoryProperties2> Pointer(this VkPhysicalDeviceMemoryProperties2 i) => new ManagedPtr<VkPhysicalDeviceMemoryProperties2>(i);
        public static ManagedPtrArray<VkPhysicalDeviceMemoryProperties2> Pointer(this VkPhysicalDeviceMemoryProperties2[] i) => new ManagedPtrArray<VkPhysicalDeviceMemoryProperties2>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSparseImageFormatProperties2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkSparseImageFormatProperties properties;
		}

        public static ManagedPtr<VkSparseImageFormatProperties2> Pointer(this VkSparseImageFormatProperties2 i) => new ManagedPtr<VkSparseImageFormatProperties2>(i);
        public static ManagedPtrArray<VkSparseImageFormatProperties2> Pointer(this VkSparseImageFormatProperties2[] i) => new ManagedPtrArray<VkSparseImageFormatProperties2>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceSparseImageFormatInfo2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkFormat format;
			[FieldOffset(20)]public VkImageType type;
			[FieldOffset(24)]public VkSampleCountFlags samples;
			[FieldOffset(28)]public VkImageUsageFlags usage;
			[FieldOffset(32)]public VkImageTiling tiling;
		}

        public static ManagedPtr<VkPhysicalDeviceSparseImageFormatInfo2> Pointer(this VkPhysicalDeviceSparseImageFormatInfo2 i) => new ManagedPtr<VkPhysicalDeviceSparseImageFormatInfo2>(i);
        public static ManagedPtrArray<VkPhysicalDeviceSparseImageFormatInfo2> Pointer(this VkPhysicalDeviceSparseImageFormatInfo2[] i) => new ManagedPtrArray<VkPhysicalDeviceSparseImageFormatInfo2>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDevicePointClippingProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPointClippingBehavior pointClippingBehavior;
		}

        public static ManagedPtr<VkPhysicalDevicePointClippingProperties> Pointer(this VkPhysicalDevicePointClippingProperties i) => new ManagedPtr<VkPhysicalDevicePointClippingProperties>(i);
        public static ManagedPtrArray<VkPhysicalDevicePointClippingProperties> Pointer(this VkPhysicalDevicePointClippingProperties[] i) => new ManagedPtrArray<VkPhysicalDevicePointClippingProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkInputAttachmentAspectReference {
			[FieldOffset(0)]public uint subpass;
			[FieldOffset(4)]public uint inputAttachmentIndex;
			[FieldOffset(8)]public VkImageAspectFlags aspectMask;
		}

        public static ManagedPtr<VkInputAttachmentAspectReference> Pointer(this VkInputAttachmentAspectReference i) => new ManagedPtr<VkInputAttachmentAspectReference>(i);
        public static ManagedPtrArray<VkInputAttachmentAspectReference> Pointer(this VkInputAttachmentAspectReference[] i) => new ManagedPtrArray<VkInputAttachmentAspectReference>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRenderPassInputAttachmentAspectCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint aspectReferenceCount;
			[FieldOffset(24)]public IntPtr pAspectReferences;
		}

        public static ManagedPtr<VkRenderPassInputAttachmentAspectCreateInfo> Pointer(this VkRenderPassInputAttachmentAspectCreateInfo i) => new ManagedPtr<VkRenderPassInputAttachmentAspectCreateInfo>(i);
        public static ManagedPtrArray<VkRenderPassInputAttachmentAspectCreateInfo> Pointer(this VkRenderPassInputAttachmentAspectCreateInfo[] i) => new ManagedPtrArray<VkRenderPassInputAttachmentAspectCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageViewUsageCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkImageUsageFlags usage;
		}

        public static ManagedPtr<VkImageViewUsageCreateInfo> Pointer(this VkImageViewUsageCreateInfo i) => new ManagedPtr<VkImageViewUsageCreateInfo>(i);
        public static ManagedPtrArray<VkImageViewUsageCreateInfo> Pointer(this VkImageViewUsageCreateInfo[] i) => new ManagedPtrArray<VkImageViewUsageCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineTessellationDomainOriginStateCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkTessellationDomainOrigin domainOrigin;
		}

        public static ManagedPtr<VkPipelineTessellationDomainOriginStateCreateInfo> Pointer(this VkPipelineTessellationDomainOriginStateCreateInfo i) => new ManagedPtr<VkPipelineTessellationDomainOriginStateCreateInfo>(i);
        public static ManagedPtrArray<VkPipelineTessellationDomainOriginStateCreateInfo> Pointer(this VkPipelineTessellationDomainOriginStateCreateInfo[] i) => new ManagedPtrArray<VkPipelineTessellationDomainOriginStateCreateInfo>(i);
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
        public static ManagedPtrArray<VkRenderPassMultiviewCreateInfo> Pointer(this VkRenderPassMultiviewCreateInfo[] i) => new ManagedPtrArray<VkRenderPassMultiviewCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceMultiviewFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool multiview;
			[FieldOffset(20)]public bool multiviewGeometryShader;
			[FieldOffset(24)]public bool multiviewTessellationShader;
		}

        public static ManagedPtr<VkPhysicalDeviceMultiviewFeatures> Pointer(this VkPhysicalDeviceMultiviewFeatures i) => new ManagedPtr<VkPhysicalDeviceMultiviewFeatures>(i);
        public static ManagedPtrArray<VkPhysicalDeviceMultiviewFeatures> Pointer(this VkPhysicalDeviceMultiviewFeatures[] i) => new ManagedPtrArray<VkPhysicalDeviceMultiviewFeatures>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceMultiviewProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint maxMultiviewViewCount;
			[FieldOffset(20)]public uint maxMultiviewInstanceIndex;
		}

        public static ManagedPtr<VkPhysicalDeviceMultiviewProperties> Pointer(this VkPhysicalDeviceMultiviewProperties i) => new ManagedPtr<VkPhysicalDeviceMultiviewProperties>(i);
        public static ManagedPtrArray<VkPhysicalDeviceMultiviewProperties> Pointer(this VkPhysicalDeviceMultiviewProperties[] i) => new ManagedPtrArray<VkPhysicalDeviceMultiviewProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceVariablePointersFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool variablePointersStorageBuffer;
			[FieldOffset(20)]public bool variablePointers;
		}

        public static ManagedPtr<VkPhysicalDeviceVariablePointersFeatures> Pointer(this VkPhysicalDeviceVariablePointersFeatures i) => new ManagedPtr<VkPhysicalDeviceVariablePointersFeatures>(i);
        public static ManagedPtrArray<VkPhysicalDeviceVariablePointersFeatures> Pointer(this VkPhysicalDeviceVariablePointersFeatures[] i) => new ManagedPtrArray<VkPhysicalDeviceVariablePointersFeatures>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceProtectedMemoryFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool protectedMemory;
		}

        public static ManagedPtr<VkPhysicalDeviceProtectedMemoryFeatures> Pointer(this VkPhysicalDeviceProtectedMemoryFeatures i) => new ManagedPtr<VkPhysicalDeviceProtectedMemoryFeatures>(i);
        public static ManagedPtrArray<VkPhysicalDeviceProtectedMemoryFeatures> Pointer(this VkPhysicalDeviceProtectedMemoryFeatures[] i) => new ManagedPtrArray<VkPhysicalDeviceProtectedMemoryFeatures>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceProtectedMemoryProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool protectedNoFault;
		}

        public static ManagedPtr<VkPhysicalDeviceProtectedMemoryProperties> Pointer(this VkPhysicalDeviceProtectedMemoryProperties i) => new ManagedPtr<VkPhysicalDeviceProtectedMemoryProperties>(i);
        public static ManagedPtrArray<VkPhysicalDeviceProtectedMemoryProperties> Pointer(this VkPhysicalDeviceProtectedMemoryProperties[] i) => new ManagedPtrArray<VkPhysicalDeviceProtectedMemoryProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceQueueInfo2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDeviceQueueCreateFlags flags;
			[FieldOffset(20)]public uint queueFamilyIndex;
			[FieldOffset(24)]public uint queueIndex;
		}

        public static ManagedPtr<VkDeviceQueueInfo2> Pointer(this VkDeviceQueueInfo2 i) => new ManagedPtr<VkDeviceQueueInfo2>(i);
        public static ManagedPtrArray<VkDeviceQueueInfo2> Pointer(this VkDeviceQueueInfo2[] i) => new ManagedPtrArray<VkDeviceQueueInfo2>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkProtectedSubmitInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool protectedSubmit;
		}

        public static ManagedPtr<VkProtectedSubmitInfo> Pointer(this VkProtectedSubmitInfo i) => new ManagedPtr<VkProtectedSubmitInfo>(i);
        public static ManagedPtrArray<VkProtectedSubmitInfo> Pointer(this VkProtectedSubmitInfo[] i) => new ManagedPtrArray<VkProtectedSubmitInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSamplerYcbcrConversionCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkFormat format;
			[FieldOffset(20)]public VkSamplerYcbcrModelConversion ycbcrModel;
			[FieldOffset(24)]public VkSamplerYcbcrRange ycbcrRange;
			[FieldOffset(28)]public VkComponentMapping components;
			[FieldOffset(44)]public VkChromaLocation xChromaOffset;
			[FieldOffset(48)]public VkChromaLocation yChromaOffset;
			[FieldOffset(52)]public VkFilter chromaFilter;
			[FieldOffset(56)]public bool forceExplicitReconstruction;
		}

        public static ManagedPtr<VkSamplerYcbcrConversionCreateInfo> Pointer(this VkSamplerYcbcrConversionCreateInfo i) => new ManagedPtr<VkSamplerYcbcrConversionCreateInfo>(i);
        public static ManagedPtrArray<VkSamplerYcbcrConversionCreateInfo> Pointer(this VkSamplerYcbcrConversionCreateInfo[] i) => new ManagedPtrArray<VkSamplerYcbcrConversionCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSamplerYcbcrConversionInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr conversion;
		}

        public static ManagedPtr<VkSamplerYcbcrConversionInfo> Pointer(this VkSamplerYcbcrConversionInfo i) => new ManagedPtr<VkSamplerYcbcrConversionInfo>(i);
        public static ManagedPtrArray<VkSamplerYcbcrConversionInfo> Pointer(this VkSamplerYcbcrConversionInfo[] i) => new ManagedPtrArray<VkSamplerYcbcrConversionInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBindImagePlaneMemoryInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkImageAspectFlags planeAspect;
		}

        public static ManagedPtr<VkBindImagePlaneMemoryInfo> Pointer(this VkBindImagePlaneMemoryInfo i) => new ManagedPtr<VkBindImagePlaneMemoryInfo>(i);
        public static ManagedPtrArray<VkBindImagePlaneMemoryInfo> Pointer(this VkBindImagePlaneMemoryInfo[] i) => new ManagedPtrArray<VkBindImagePlaneMemoryInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImagePlaneMemoryRequirementsInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkImageAspectFlags planeAspect;
		}

        public static ManagedPtr<VkImagePlaneMemoryRequirementsInfo> Pointer(this VkImagePlaneMemoryRequirementsInfo i) => new ManagedPtr<VkImagePlaneMemoryRequirementsInfo>(i);
        public static ManagedPtrArray<VkImagePlaneMemoryRequirementsInfo> Pointer(this VkImagePlaneMemoryRequirementsInfo[] i) => new ManagedPtrArray<VkImagePlaneMemoryRequirementsInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceSamplerYcbcrConversionFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool samplerYcbcrConversion;
		}

        public static ManagedPtr<VkPhysicalDeviceSamplerYcbcrConversionFeatures> Pointer(this VkPhysicalDeviceSamplerYcbcrConversionFeatures i) => new ManagedPtr<VkPhysicalDeviceSamplerYcbcrConversionFeatures>(i);
        public static ManagedPtrArray<VkPhysicalDeviceSamplerYcbcrConversionFeatures> Pointer(this VkPhysicalDeviceSamplerYcbcrConversionFeatures[] i) => new ManagedPtrArray<VkPhysicalDeviceSamplerYcbcrConversionFeatures>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSamplerYcbcrConversionImageFormatProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint combinedImageSamplerDescriptorCount;
		}

        public static ManagedPtr<VkSamplerYcbcrConversionImageFormatProperties> Pointer(this VkSamplerYcbcrConversionImageFormatProperties i) => new ManagedPtr<VkSamplerYcbcrConversionImageFormatProperties>(i);
        public static ManagedPtrArray<VkSamplerYcbcrConversionImageFormatProperties> Pointer(this VkSamplerYcbcrConversionImageFormatProperties[] i) => new ManagedPtrArray<VkSamplerYcbcrConversionImageFormatProperties>(i);
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
        public static ManagedPtrArray<VkDescriptorUpdateTemplateEntry> Pointer(this VkDescriptorUpdateTemplateEntry[] i) => new ManagedPtrArray<VkDescriptorUpdateTemplateEntry>(i);
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
        public static ManagedPtrArray<VkDescriptorUpdateTemplateCreateInfo> Pointer(this VkDescriptorUpdateTemplateCreateInfo[] i) => new ManagedPtrArray<VkDescriptorUpdateTemplateCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExternalMemoryProperties {
			[FieldOffset(0)]public VkExternalMemoryFeatureFlags externalMemoryFeatures;
			[FieldOffset(4)]public VkExternalMemoryHandleTypeFlags exportFromImportedHandleTypes;
			[FieldOffset(8)]public VkExternalMemoryHandleTypeFlags compatibleHandleTypes;
		}

        public static ManagedPtr<VkExternalMemoryProperties> Pointer(this VkExternalMemoryProperties i) => new ManagedPtr<VkExternalMemoryProperties>(i);
        public static ManagedPtrArray<VkExternalMemoryProperties> Pointer(this VkExternalMemoryProperties[] i) => new ManagedPtrArray<VkExternalMemoryProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceExternalImageFormatInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalMemoryHandleTypeFlags handleType;
		}

        public static ManagedPtr<VkPhysicalDeviceExternalImageFormatInfo> Pointer(this VkPhysicalDeviceExternalImageFormatInfo i) => new ManagedPtr<VkPhysicalDeviceExternalImageFormatInfo>(i);
        public static ManagedPtrArray<VkPhysicalDeviceExternalImageFormatInfo> Pointer(this VkPhysicalDeviceExternalImageFormatInfo[] i) => new ManagedPtrArray<VkPhysicalDeviceExternalImageFormatInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExternalImageFormatProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalMemoryProperties externalMemoryProperties;
		}

        public static ManagedPtr<VkExternalImageFormatProperties> Pointer(this VkExternalImageFormatProperties i) => new ManagedPtr<VkExternalImageFormatProperties>(i);
        public static ManagedPtrArray<VkExternalImageFormatProperties> Pointer(this VkExternalImageFormatProperties[] i) => new ManagedPtrArray<VkExternalImageFormatProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceExternalBufferInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkBufferCreateFlags flags;
			[FieldOffset(20)]public VkBufferUsageFlags usage;
			[FieldOffset(24)]public VkExternalMemoryHandleTypeFlags handleType;
		}

        public static ManagedPtr<VkPhysicalDeviceExternalBufferInfo> Pointer(this VkPhysicalDeviceExternalBufferInfo i) => new ManagedPtr<VkPhysicalDeviceExternalBufferInfo>(i);
        public static ManagedPtrArray<VkPhysicalDeviceExternalBufferInfo> Pointer(this VkPhysicalDeviceExternalBufferInfo[] i) => new ManagedPtrArray<VkPhysicalDeviceExternalBufferInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExternalBufferProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalMemoryProperties externalMemoryProperties;
		}

        public static ManagedPtr<VkExternalBufferProperties> Pointer(this VkExternalBufferProperties i) => new ManagedPtr<VkExternalBufferProperties>(i);
        public static ManagedPtrArray<VkExternalBufferProperties> Pointer(this VkExternalBufferProperties[] i) => new ManagedPtrArray<VkExternalBufferProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceIDProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public fixed byte deviceUUID[16];
			public const int deviceUUID_len = 16;
			[FieldOffset(32)]public fixed byte driverUUID[16];
			public const int driverUUID_len = 16;
			[FieldOffset(48)]public fixed byte deviceLUID[8];
			public const int deviceLUID_len = 8;
			[FieldOffset(56)]public uint deviceNodeMask;
			[FieldOffset(60)]public bool deviceLUIDValid;
		}

        public static ManagedPtr<VkPhysicalDeviceIDProperties> Pointer(this VkPhysicalDeviceIDProperties i) => new ManagedPtr<VkPhysicalDeviceIDProperties>(i);
        public static ManagedPtrArray<VkPhysicalDeviceIDProperties> Pointer(this VkPhysicalDeviceIDProperties[] i) => new ManagedPtrArray<VkPhysicalDeviceIDProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExternalMemoryImageCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalMemoryHandleTypeFlags handleTypes;
		}

        public static ManagedPtr<VkExternalMemoryImageCreateInfo> Pointer(this VkExternalMemoryImageCreateInfo i) => new ManagedPtr<VkExternalMemoryImageCreateInfo>(i);
        public static ManagedPtrArray<VkExternalMemoryImageCreateInfo> Pointer(this VkExternalMemoryImageCreateInfo[] i) => new ManagedPtrArray<VkExternalMemoryImageCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExternalMemoryBufferCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalMemoryHandleTypeFlags handleTypes;
		}

        public static ManagedPtr<VkExternalMemoryBufferCreateInfo> Pointer(this VkExternalMemoryBufferCreateInfo i) => new ManagedPtr<VkExternalMemoryBufferCreateInfo>(i);
        public static ManagedPtrArray<VkExternalMemoryBufferCreateInfo> Pointer(this VkExternalMemoryBufferCreateInfo[] i) => new ManagedPtrArray<VkExternalMemoryBufferCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExportMemoryAllocateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalMemoryHandleTypeFlags handleTypes;
		}

        public static ManagedPtr<VkExportMemoryAllocateInfo> Pointer(this VkExportMemoryAllocateInfo i) => new ManagedPtr<VkExportMemoryAllocateInfo>(i);
        public static ManagedPtrArray<VkExportMemoryAllocateInfo> Pointer(this VkExportMemoryAllocateInfo[] i) => new ManagedPtrArray<VkExportMemoryAllocateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceExternalFenceInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalFenceHandleTypeFlags handleType;
		}

        public static ManagedPtr<VkPhysicalDeviceExternalFenceInfo> Pointer(this VkPhysicalDeviceExternalFenceInfo i) => new ManagedPtr<VkPhysicalDeviceExternalFenceInfo>(i);
        public static ManagedPtrArray<VkPhysicalDeviceExternalFenceInfo> Pointer(this VkPhysicalDeviceExternalFenceInfo[] i) => new ManagedPtrArray<VkPhysicalDeviceExternalFenceInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExternalFenceProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalFenceHandleTypeFlags exportFromImportedHandleTypes;
			[FieldOffset(20)]public VkExternalFenceHandleTypeFlags compatibleHandleTypes;
			[FieldOffset(24)]public VkExternalFenceFeatureFlags externalFenceFeatures;
		}

        public static ManagedPtr<VkExternalFenceProperties> Pointer(this VkExternalFenceProperties i) => new ManagedPtr<VkExternalFenceProperties>(i);
        public static ManagedPtrArray<VkExternalFenceProperties> Pointer(this VkExternalFenceProperties[] i) => new ManagedPtrArray<VkExternalFenceProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExportFenceCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalFenceHandleTypeFlags handleTypes;
		}

        public static ManagedPtr<VkExportFenceCreateInfo> Pointer(this VkExportFenceCreateInfo i) => new ManagedPtr<VkExportFenceCreateInfo>(i);
        public static ManagedPtrArray<VkExportFenceCreateInfo> Pointer(this VkExportFenceCreateInfo[] i) => new ManagedPtrArray<VkExportFenceCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExportSemaphoreCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalSemaphoreHandleTypeFlags handleTypes;
		}

        public static ManagedPtr<VkExportSemaphoreCreateInfo> Pointer(this VkExportSemaphoreCreateInfo i) => new ManagedPtr<VkExportSemaphoreCreateInfo>(i);
        public static ManagedPtrArray<VkExportSemaphoreCreateInfo> Pointer(this VkExportSemaphoreCreateInfo[] i) => new ManagedPtrArray<VkExportSemaphoreCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceExternalSemaphoreInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalSemaphoreHandleTypeFlags handleType;
		}

        public static ManagedPtr<VkPhysicalDeviceExternalSemaphoreInfo> Pointer(this VkPhysicalDeviceExternalSemaphoreInfo i) => new ManagedPtr<VkPhysicalDeviceExternalSemaphoreInfo>(i);
        public static ManagedPtrArray<VkPhysicalDeviceExternalSemaphoreInfo> Pointer(this VkPhysicalDeviceExternalSemaphoreInfo[] i) => new ManagedPtrArray<VkPhysicalDeviceExternalSemaphoreInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExternalSemaphoreProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalSemaphoreHandleTypeFlags exportFromImportedHandleTypes;
			[FieldOffset(20)]public VkExternalSemaphoreHandleTypeFlags compatibleHandleTypes;
			[FieldOffset(24)]public VkExternalSemaphoreFeatureFlags externalSemaphoreFeatures;
		}

        public static ManagedPtr<VkExternalSemaphoreProperties> Pointer(this VkExternalSemaphoreProperties i) => new ManagedPtr<VkExternalSemaphoreProperties>(i);
        public static ManagedPtrArray<VkExternalSemaphoreProperties> Pointer(this VkExternalSemaphoreProperties[] i) => new ManagedPtrArray<VkExternalSemaphoreProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceMaintenance3Properties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint maxPerSetDescriptors;
			[FieldOffset(24)]public ulong maxMemoryAllocationSize;
		}

        public static ManagedPtr<VkPhysicalDeviceMaintenance3Properties> Pointer(this VkPhysicalDeviceMaintenance3Properties i) => new ManagedPtr<VkPhysicalDeviceMaintenance3Properties>(i);
        public static ManagedPtrArray<VkPhysicalDeviceMaintenance3Properties> Pointer(this VkPhysicalDeviceMaintenance3Properties[] i) => new ManagedPtrArray<VkPhysicalDeviceMaintenance3Properties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorSetLayoutSupport {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool supported;
		}

        public static ManagedPtr<VkDescriptorSetLayoutSupport> Pointer(this VkDescriptorSetLayoutSupport i) => new ManagedPtr<VkDescriptorSetLayoutSupport>(i);
        public static ManagedPtrArray<VkDescriptorSetLayoutSupport> Pointer(this VkDescriptorSetLayoutSupport[] i) => new ManagedPtrArray<VkDescriptorSetLayoutSupport>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShaderDrawParametersFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool shaderDrawParameters;
		}

        public static ManagedPtr<VkPhysicalDeviceShaderDrawParametersFeatures> Pointer(this VkPhysicalDeviceShaderDrawParametersFeatures i) => new ManagedPtr<VkPhysicalDeviceShaderDrawParametersFeatures>(i);
        public static ManagedPtrArray<VkPhysicalDeviceShaderDrawParametersFeatures> Pointer(this VkPhysicalDeviceShaderDrawParametersFeatures[] i) => new ManagedPtrArray<VkPhysicalDeviceShaderDrawParametersFeatures>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceVulkan11Features {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool storageBuffer16BitAccess;
			[FieldOffset(20)]public bool uniformAndStorageBuffer16BitAccess;
			[FieldOffset(24)]public bool storagePushConstant16;
			[FieldOffset(28)]public bool storageInputOutput16;
			[FieldOffset(32)]public bool multiview;
			[FieldOffset(36)]public bool multiviewGeometryShader;
			[FieldOffset(40)]public bool multiviewTessellationShader;
			[FieldOffset(44)]public bool variablePointersStorageBuffer;
			[FieldOffset(48)]public bool variablePointers;
			[FieldOffset(52)]public bool protectedMemory;
			[FieldOffset(56)]public bool samplerYcbcrConversion;
			[FieldOffset(60)]public bool shaderDrawParameters;
		}

        public static ManagedPtr<VkPhysicalDeviceVulkan11Features> Pointer(this VkPhysicalDeviceVulkan11Features i) => new ManagedPtr<VkPhysicalDeviceVulkan11Features>(i);
        public static ManagedPtrArray<VkPhysicalDeviceVulkan11Features> Pointer(this VkPhysicalDeviceVulkan11Features[] i) => new ManagedPtrArray<VkPhysicalDeviceVulkan11Features>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceVulkan11Properties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public fixed byte deviceUUID[16];
			public const int deviceUUID_len = 16;
			[FieldOffset(32)]public fixed byte driverUUID[16];
			public const int driverUUID_len = 16;
			[FieldOffset(48)]public fixed byte deviceLUID[8];
			public const int deviceLUID_len = 8;
			[FieldOffset(56)]public uint deviceNodeMask;
			[FieldOffset(60)]public bool deviceLUIDValid;
			[FieldOffset(64)]public uint subgroupSize;
			[FieldOffset(68)]public VkShaderStageFlags subgroupSupportedStages;
			[FieldOffset(72)]public VkSubgroupFeatureFlags subgroupSupportedOperations;
			[FieldOffset(76)]public bool subgroupQuadOperationsInAllStages;
			[FieldOffset(80)]public VkPointClippingBehavior pointClippingBehavior;
			[FieldOffset(84)]public uint maxMultiviewViewCount;
			[FieldOffset(88)]public uint maxMultiviewInstanceIndex;
			[FieldOffset(92)]public bool protectedNoFault;
			[FieldOffset(96)]public uint maxPerSetDescriptors;
			[FieldOffset(104)]public ulong maxMemoryAllocationSize;
		}

        public static ManagedPtr<VkPhysicalDeviceVulkan11Properties> Pointer(this VkPhysicalDeviceVulkan11Properties i) => new ManagedPtr<VkPhysicalDeviceVulkan11Properties>(i);
        public static ManagedPtrArray<VkPhysicalDeviceVulkan11Properties> Pointer(this VkPhysicalDeviceVulkan11Properties[] i) => new ManagedPtrArray<VkPhysicalDeviceVulkan11Properties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceVulkan12Features {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool samplerMirrorClampToEdge;
			[FieldOffset(20)]public bool drawIndirectCount;
			[FieldOffset(24)]public bool storageBuffer8BitAccess;
			[FieldOffset(28)]public bool uniformAndStorageBuffer8BitAccess;
			[FieldOffset(32)]public bool storagePushConstant8;
			[FieldOffset(36)]public bool shaderBufferInt64Atomics;
			[FieldOffset(40)]public bool shaderSharedInt64Atomics;
			[FieldOffset(44)]public bool shaderFloat16;
			[FieldOffset(48)]public bool shaderInt8;
			[FieldOffset(52)]public bool descriptorIndexing;
			[FieldOffset(56)]public bool shaderInputAttachmentArrayDynamicIndexing;
			[FieldOffset(60)]public bool shaderUniformTexelBufferArrayDynamicIndexing;
			[FieldOffset(64)]public bool shaderStorageTexelBufferArrayDynamicIndexing;
			[FieldOffset(68)]public bool shaderUniformBufferArrayNonUniformIndexing;
			[FieldOffset(72)]public bool shaderSampledImageArrayNonUniformIndexing;
			[FieldOffset(76)]public bool shaderStorageBufferArrayNonUniformIndexing;
			[FieldOffset(80)]public bool shaderStorageImageArrayNonUniformIndexing;
			[FieldOffset(84)]public bool shaderInputAttachmentArrayNonUniformIndexing;
			[FieldOffset(88)]public bool shaderUniformTexelBufferArrayNonUniformIndexing;
			[FieldOffset(92)]public bool shaderStorageTexelBufferArrayNonUniformIndexing;
			[FieldOffset(96)]public bool descriptorBindingUniformBufferUpdateAfterBind;
			[FieldOffset(100)]public bool descriptorBindingSampledImageUpdateAfterBind;
			[FieldOffset(104)]public bool descriptorBindingStorageImageUpdateAfterBind;
			[FieldOffset(108)]public bool descriptorBindingStorageBufferUpdateAfterBind;
			[FieldOffset(112)]public bool descriptorBindingUniformTexelBufferUpdateAfterBind;
			[FieldOffset(116)]public bool descriptorBindingStorageTexelBufferUpdateAfterBind;
			[FieldOffset(120)]public bool descriptorBindingUpdateUnusedWhilePending;
			[FieldOffset(124)]public bool descriptorBindingPartiallyBound;
			[FieldOffset(128)]public bool descriptorBindingVariableDescriptorCount;
			[FieldOffset(132)]public bool runtimeDescriptorArray;
			[FieldOffset(136)]public bool samplerFilterMinmax;
			[FieldOffset(140)]public bool scalarBlockLayout;
			[FieldOffset(144)]public bool imagelessFramebuffer;
			[FieldOffset(148)]public bool uniformBufferStandardLayout;
			[FieldOffset(152)]public bool shaderSubgroupExtendedTypes;
			[FieldOffset(156)]public bool separateDepthStencilLayouts;
			[FieldOffset(160)]public bool hostQueryReset;
			[FieldOffset(164)]public bool timelineSemaphore;
			[FieldOffset(168)]public bool bufferDeviceAddress;
			[FieldOffset(172)]public bool bufferDeviceAddressCaptureReplay;
			[FieldOffset(176)]public bool bufferDeviceAddressMultiDevice;
			[FieldOffset(180)]public bool vulkanMemoryModel;
			[FieldOffset(184)]public bool vulkanMemoryModelDeviceScope;
			[FieldOffset(188)]public bool vulkanMemoryModelAvailabilityVisibilityChains;
			[FieldOffset(192)]public bool shaderOutputViewportIndex;
			[FieldOffset(196)]public bool shaderOutputLayer;
			[FieldOffset(200)]public bool subgroupBroadcastDynamicId;
		}

        public static ManagedPtr<VkPhysicalDeviceVulkan12Features> Pointer(this VkPhysicalDeviceVulkan12Features i) => new ManagedPtr<VkPhysicalDeviceVulkan12Features>(i);
        public static ManagedPtrArray<VkPhysicalDeviceVulkan12Features> Pointer(this VkPhysicalDeviceVulkan12Features[] i) => new ManagedPtrArray<VkPhysicalDeviceVulkan12Features>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkConformanceVersion {
			[FieldOffset(0)]public byte major;
			[FieldOffset(1)]public byte minor;
			[FieldOffset(2)]public byte subminor;
			[FieldOffset(3)]public byte patch;
		}

        public static ManagedPtr<VkConformanceVersion> Pointer(this VkConformanceVersion i) => new ManagedPtr<VkConformanceVersion>(i);
        public static ManagedPtrArray<VkConformanceVersion> Pointer(this VkConformanceVersion[] i) => new ManagedPtrArray<VkConformanceVersion>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceVulkan12Properties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDriverId driverID;
			[FieldOffset(20)]public fixed byte driverName[256];
			public const int driverName_len = 256;
			[FieldOffset(276)]public fixed byte driverInfo[256];
			public const int driverInfo_len = 256;
			[FieldOffset(532)]public VkConformanceVersion conformanceVersion;
			[FieldOffset(536)]public VkShaderFloatControlsIndependence denormBehaviorIndependence;
			[FieldOffset(540)]public VkShaderFloatControlsIndependence roundingModeIndependence;
			[FieldOffset(544)]public bool shaderSignedZeroInfNanPreserveFloat16;
			[FieldOffset(548)]public bool shaderSignedZeroInfNanPreserveFloat32;
			[FieldOffset(552)]public bool shaderSignedZeroInfNanPreserveFloat64;
			[FieldOffset(556)]public bool shaderDenormPreserveFloat16;
			[FieldOffset(560)]public bool shaderDenormPreserveFloat32;
			[FieldOffset(564)]public bool shaderDenormPreserveFloat64;
			[FieldOffset(568)]public bool shaderDenormFlushToZeroFloat16;
			[FieldOffset(572)]public bool shaderDenormFlushToZeroFloat32;
			[FieldOffset(576)]public bool shaderDenormFlushToZeroFloat64;
			[FieldOffset(580)]public bool shaderRoundingModeRTEFloat16;
			[FieldOffset(584)]public bool shaderRoundingModeRTEFloat32;
			[FieldOffset(588)]public bool shaderRoundingModeRTEFloat64;
			[FieldOffset(592)]public bool shaderRoundingModeRTZFloat16;
			[FieldOffset(596)]public bool shaderRoundingModeRTZFloat32;
			[FieldOffset(600)]public bool shaderRoundingModeRTZFloat64;
			[FieldOffset(604)]public uint maxUpdateAfterBindDescriptorsInAllPools;
			[FieldOffset(608)]public bool shaderUniformBufferArrayNonUniformIndexingNative;
			[FieldOffset(612)]public bool shaderSampledImageArrayNonUniformIndexingNative;
			[FieldOffset(616)]public bool shaderStorageBufferArrayNonUniformIndexingNative;
			[FieldOffset(620)]public bool shaderStorageImageArrayNonUniformIndexingNative;
			[FieldOffset(624)]public bool shaderInputAttachmentArrayNonUniformIndexingNative;
			[FieldOffset(628)]public bool robustBufferAccessUpdateAfterBind;
			[FieldOffset(632)]public bool quadDivergentImplicitLod;
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
			[FieldOffset(696)]public VkResolveModeFlags supportedDepthResolveModes;
			[FieldOffset(700)]public VkResolveModeFlags supportedStencilResolveModes;
			[FieldOffset(704)]public bool independentResolveNone;
			[FieldOffset(708)]public bool independentResolve;
			[FieldOffset(712)]public bool filterMinmaxSingleComponentFormats;
			[FieldOffset(716)]public bool filterMinmaxImageComponentMapping;
			[FieldOffset(720)]public ulong maxTimelineSemaphoreValueDifference;
			[FieldOffset(728)]public VkSampleCountFlags framebufferIntegerColorSampleCounts;
		}

        public static ManagedPtr<VkPhysicalDeviceVulkan12Properties> Pointer(this VkPhysicalDeviceVulkan12Properties i) => new ManagedPtr<VkPhysicalDeviceVulkan12Properties>(i);
        public static ManagedPtrArray<VkPhysicalDeviceVulkan12Properties> Pointer(this VkPhysicalDeviceVulkan12Properties[] i) => new ManagedPtrArray<VkPhysicalDeviceVulkan12Properties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageFormatListCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint viewFormatCount;
			[FieldOffset(24)]public VkFormat* pViewFormats;
		}

        public static ManagedPtr<VkImageFormatListCreateInfo> Pointer(this VkImageFormatListCreateInfo i) => new ManagedPtr<VkImageFormatListCreateInfo>(i);
        public static ManagedPtrArray<VkImageFormatListCreateInfo> Pointer(this VkImageFormatListCreateInfo[] i) => new ManagedPtrArray<VkImageFormatListCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAttachmentDescription2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkAttachmentDescriptionFlags flags;
			[FieldOffset(20)]public VkFormat format;
			[FieldOffset(24)]public VkSampleCountFlags samples;
			[FieldOffset(28)]public VkAttachmentLoadOp loadOp;
			[FieldOffset(32)]public VkAttachmentStoreOp storeOp;
			[FieldOffset(36)]public VkAttachmentLoadOp stencilLoadOp;
			[FieldOffset(40)]public VkAttachmentStoreOp stencilStoreOp;
			[FieldOffset(44)]public VkImageLayout initialLayout;
			[FieldOffset(48)]public VkImageLayout finalLayout;
		}

        public static ManagedPtr<VkAttachmentDescription2> Pointer(this VkAttachmentDescription2 i) => new ManagedPtr<VkAttachmentDescription2>(i);
        public static ManagedPtrArray<VkAttachmentDescription2> Pointer(this VkAttachmentDescription2[] i) => new ManagedPtrArray<VkAttachmentDescription2>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAttachmentReference2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint attachment;
			[FieldOffset(20)]public VkImageLayout layout;
			[FieldOffset(24)]public VkImageAspectFlags aspectMask;
		}

        public static ManagedPtr<VkAttachmentReference2> Pointer(this VkAttachmentReference2 i) => new ManagedPtr<VkAttachmentReference2>(i);
        public static ManagedPtrArray<VkAttachmentReference2> Pointer(this VkAttachmentReference2[] i) => new ManagedPtrArray<VkAttachmentReference2>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSubpassDescription2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkSubpassDescriptionFlags flags;
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
        public static ManagedPtrArray<VkSubpassDescription2> Pointer(this VkSubpassDescription2[] i) => new ManagedPtrArray<VkSubpassDescription2>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSubpassDependency2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint srcSubpass;
			[FieldOffset(20)]public uint dstSubpass;
			[FieldOffset(24)]public VkPipelineStageFlags srcStageMask;
			[FieldOffset(28)]public VkPipelineStageFlags dstStageMask;
			[FieldOffset(32)]public VkAccessFlags srcAccessMask;
			[FieldOffset(36)]public VkAccessFlags dstAccessMask;
			[FieldOffset(40)]public VkDependencyFlags dependencyFlags;
			[FieldOffset(44)]public int viewOffset;
		}

        public static ManagedPtr<VkSubpassDependency2> Pointer(this VkSubpassDependency2 i) => new ManagedPtr<VkSubpassDependency2>(i);
        public static ManagedPtrArray<VkSubpassDependency2> Pointer(this VkSubpassDependency2[] i) => new ManagedPtrArray<VkSubpassDependency2>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRenderPassCreateInfo2 {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkRenderPassCreateFlags flags;
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
        public static ManagedPtrArray<VkRenderPassCreateInfo2> Pointer(this VkRenderPassCreateInfo2[] i) => new ManagedPtrArray<VkRenderPassCreateInfo2>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSubpassBeginInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkSubpassContents contents;
		}

        public static ManagedPtr<VkSubpassBeginInfo> Pointer(this VkSubpassBeginInfo i) => new ManagedPtr<VkSubpassBeginInfo>(i);
        public static ManagedPtrArray<VkSubpassBeginInfo> Pointer(this VkSubpassBeginInfo[] i) => new ManagedPtrArray<VkSubpassBeginInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSubpassEndInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
		}

        public static ManagedPtr<VkSubpassEndInfo> Pointer(this VkSubpassEndInfo i) => new ManagedPtr<VkSubpassEndInfo>(i);
        public static ManagedPtrArray<VkSubpassEndInfo> Pointer(this VkSubpassEndInfo[] i) => new ManagedPtrArray<VkSubpassEndInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDevice8BitStorageFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool storageBuffer8BitAccess;
			[FieldOffset(20)]public bool uniformAndStorageBuffer8BitAccess;
			[FieldOffset(24)]public bool storagePushConstant8;
		}

        public static ManagedPtr<VkPhysicalDevice8BitStorageFeatures> Pointer(this VkPhysicalDevice8BitStorageFeatures i) => new ManagedPtr<VkPhysicalDevice8BitStorageFeatures>(i);
        public static ManagedPtrArray<VkPhysicalDevice8BitStorageFeatures> Pointer(this VkPhysicalDevice8BitStorageFeatures[] i) => new ManagedPtrArray<VkPhysicalDevice8BitStorageFeatures>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceDriverProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDriverId driverID;
			[FieldOffset(20)]public fixed byte driverName[256];
			public const int driverName_len = 256;
			[FieldOffset(276)]public fixed byte driverInfo[256];
			public const int driverInfo_len = 256;
			[FieldOffset(532)]public VkConformanceVersion conformanceVersion;
		}

        public static ManagedPtr<VkPhysicalDeviceDriverProperties> Pointer(this VkPhysicalDeviceDriverProperties i) => new ManagedPtr<VkPhysicalDeviceDriverProperties>(i);
        public static ManagedPtrArray<VkPhysicalDeviceDriverProperties> Pointer(this VkPhysicalDeviceDriverProperties[] i) => new ManagedPtrArray<VkPhysicalDeviceDriverProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShaderAtomicInt64Features {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool shaderBufferInt64Atomics;
			[FieldOffset(20)]public bool shaderSharedInt64Atomics;
		}

        public static ManagedPtr<VkPhysicalDeviceShaderAtomicInt64Features> Pointer(this VkPhysicalDeviceShaderAtomicInt64Features i) => new ManagedPtr<VkPhysicalDeviceShaderAtomicInt64Features>(i);
        public static ManagedPtrArray<VkPhysicalDeviceShaderAtomicInt64Features> Pointer(this VkPhysicalDeviceShaderAtomicInt64Features[] i) => new ManagedPtrArray<VkPhysicalDeviceShaderAtomicInt64Features>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShaderFloat16Int8Features {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool shaderFloat16;
			[FieldOffset(20)]public bool shaderInt8;
		}

        public static ManagedPtr<VkPhysicalDeviceShaderFloat16Int8Features> Pointer(this VkPhysicalDeviceShaderFloat16Int8Features i) => new ManagedPtr<VkPhysicalDeviceShaderFloat16Int8Features>(i);
        public static ManagedPtrArray<VkPhysicalDeviceShaderFloat16Int8Features> Pointer(this VkPhysicalDeviceShaderFloat16Int8Features[] i) => new ManagedPtrArray<VkPhysicalDeviceShaderFloat16Int8Features>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceFloatControlsProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkShaderFloatControlsIndependence denormBehaviorIndependence;
			[FieldOffset(20)]public VkShaderFloatControlsIndependence roundingModeIndependence;
			[FieldOffset(24)]public bool shaderSignedZeroInfNanPreserveFloat16;
			[FieldOffset(28)]public bool shaderSignedZeroInfNanPreserveFloat32;
			[FieldOffset(32)]public bool shaderSignedZeroInfNanPreserveFloat64;
			[FieldOffset(36)]public bool shaderDenormPreserveFloat16;
			[FieldOffset(40)]public bool shaderDenormPreserveFloat32;
			[FieldOffset(44)]public bool shaderDenormPreserveFloat64;
			[FieldOffset(48)]public bool shaderDenormFlushToZeroFloat16;
			[FieldOffset(52)]public bool shaderDenormFlushToZeroFloat32;
			[FieldOffset(56)]public bool shaderDenormFlushToZeroFloat64;
			[FieldOffset(60)]public bool shaderRoundingModeRTEFloat16;
			[FieldOffset(64)]public bool shaderRoundingModeRTEFloat32;
			[FieldOffset(68)]public bool shaderRoundingModeRTEFloat64;
			[FieldOffset(72)]public bool shaderRoundingModeRTZFloat16;
			[FieldOffset(76)]public bool shaderRoundingModeRTZFloat32;
			[FieldOffset(80)]public bool shaderRoundingModeRTZFloat64;
		}

        public static ManagedPtr<VkPhysicalDeviceFloatControlsProperties> Pointer(this VkPhysicalDeviceFloatControlsProperties i) => new ManagedPtr<VkPhysicalDeviceFloatControlsProperties>(i);
        public static ManagedPtrArray<VkPhysicalDeviceFloatControlsProperties> Pointer(this VkPhysicalDeviceFloatControlsProperties[] i) => new ManagedPtrArray<VkPhysicalDeviceFloatControlsProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorSetLayoutBindingFlagsCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint bindingCount;
			[FieldOffset(24)]public VkDescriptorBindingFlags* pBindingFlags;
		}

        public static ManagedPtr<VkDescriptorSetLayoutBindingFlagsCreateInfo> Pointer(this VkDescriptorSetLayoutBindingFlagsCreateInfo i) => new ManagedPtr<VkDescriptorSetLayoutBindingFlagsCreateInfo>(i);
        public static ManagedPtrArray<VkDescriptorSetLayoutBindingFlagsCreateInfo> Pointer(this VkDescriptorSetLayoutBindingFlagsCreateInfo[] i) => new ManagedPtrArray<VkDescriptorSetLayoutBindingFlagsCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceDescriptorIndexingFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool shaderInputAttachmentArrayDynamicIndexing;
			[FieldOffset(20)]public bool shaderUniformTexelBufferArrayDynamicIndexing;
			[FieldOffset(24)]public bool shaderStorageTexelBufferArrayDynamicIndexing;
			[FieldOffset(28)]public bool shaderUniformBufferArrayNonUniformIndexing;
			[FieldOffset(32)]public bool shaderSampledImageArrayNonUniformIndexing;
			[FieldOffset(36)]public bool shaderStorageBufferArrayNonUniformIndexing;
			[FieldOffset(40)]public bool shaderStorageImageArrayNonUniformIndexing;
			[FieldOffset(44)]public bool shaderInputAttachmentArrayNonUniformIndexing;
			[FieldOffset(48)]public bool shaderUniformTexelBufferArrayNonUniformIndexing;
			[FieldOffset(52)]public bool shaderStorageTexelBufferArrayNonUniformIndexing;
			[FieldOffset(56)]public bool descriptorBindingUniformBufferUpdateAfterBind;
			[FieldOffset(60)]public bool descriptorBindingSampledImageUpdateAfterBind;
			[FieldOffset(64)]public bool descriptorBindingStorageImageUpdateAfterBind;
			[FieldOffset(68)]public bool descriptorBindingStorageBufferUpdateAfterBind;
			[FieldOffset(72)]public bool descriptorBindingUniformTexelBufferUpdateAfterBind;
			[FieldOffset(76)]public bool descriptorBindingStorageTexelBufferUpdateAfterBind;
			[FieldOffset(80)]public bool descriptorBindingUpdateUnusedWhilePending;
			[FieldOffset(84)]public bool descriptorBindingPartiallyBound;
			[FieldOffset(88)]public bool descriptorBindingVariableDescriptorCount;
			[FieldOffset(92)]public bool runtimeDescriptorArray;
		}

        public static ManagedPtr<VkPhysicalDeviceDescriptorIndexingFeatures> Pointer(this VkPhysicalDeviceDescriptorIndexingFeatures i) => new ManagedPtr<VkPhysicalDeviceDescriptorIndexingFeatures>(i);
        public static ManagedPtrArray<VkPhysicalDeviceDescriptorIndexingFeatures> Pointer(this VkPhysicalDeviceDescriptorIndexingFeatures[] i) => new ManagedPtrArray<VkPhysicalDeviceDescriptorIndexingFeatures>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceDescriptorIndexingProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint maxUpdateAfterBindDescriptorsInAllPools;
			[FieldOffset(20)]public bool shaderUniformBufferArrayNonUniformIndexingNative;
			[FieldOffset(24)]public bool shaderSampledImageArrayNonUniformIndexingNative;
			[FieldOffset(28)]public bool shaderStorageBufferArrayNonUniformIndexingNative;
			[FieldOffset(32)]public bool shaderStorageImageArrayNonUniformIndexingNative;
			[FieldOffset(36)]public bool shaderInputAttachmentArrayNonUniformIndexingNative;
			[FieldOffset(40)]public bool robustBufferAccessUpdateAfterBind;
			[FieldOffset(44)]public bool quadDivergentImplicitLod;
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
        public static ManagedPtrArray<VkPhysicalDeviceDescriptorIndexingProperties> Pointer(this VkPhysicalDeviceDescriptorIndexingProperties[] i) => new ManagedPtrArray<VkPhysicalDeviceDescriptorIndexingProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint descriptorSetCount;
			[FieldOffset(24)]public uint* pDescriptorCounts;
		}

        public static ManagedPtr<VkDescriptorSetVariableDescriptorCountAllocateInfo> Pointer(this VkDescriptorSetVariableDescriptorCountAllocateInfo i) => new ManagedPtr<VkDescriptorSetVariableDescriptorCountAllocateInfo>(i);
        public static ManagedPtrArray<VkDescriptorSetVariableDescriptorCountAllocateInfo> Pointer(this VkDescriptorSetVariableDescriptorCountAllocateInfo[] i) => new ManagedPtrArray<VkDescriptorSetVariableDescriptorCountAllocateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorSetVariableDescriptorCountLayoutSupport {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint maxVariableDescriptorCount;
		}

        public static ManagedPtr<VkDescriptorSetVariableDescriptorCountLayoutSupport> Pointer(this VkDescriptorSetVariableDescriptorCountLayoutSupport i) => new ManagedPtr<VkDescriptorSetVariableDescriptorCountLayoutSupport>(i);
        public static ManagedPtrArray<VkDescriptorSetVariableDescriptorCountLayoutSupport> Pointer(this VkDescriptorSetVariableDescriptorCountLayoutSupport[] i) => new ManagedPtrArray<VkDescriptorSetVariableDescriptorCountLayoutSupport>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSubpassDescriptionDepthStencilResolve {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkResolveModeFlags depthResolveMode;
			[FieldOffset(20)]public VkResolveModeFlags stencilResolveMode;
			[FieldOffset(24)]public IntPtr pDepthStencilResolveAttachment;
		}

        public static ManagedPtr<VkSubpassDescriptionDepthStencilResolve> Pointer(this VkSubpassDescriptionDepthStencilResolve i) => new ManagedPtr<VkSubpassDescriptionDepthStencilResolve>(i);
        public static ManagedPtrArray<VkSubpassDescriptionDepthStencilResolve> Pointer(this VkSubpassDescriptionDepthStencilResolve[] i) => new ManagedPtrArray<VkSubpassDescriptionDepthStencilResolve>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceDepthStencilResolveProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkResolveModeFlags supportedDepthResolveModes;
			[FieldOffset(20)]public VkResolveModeFlags supportedStencilResolveModes;
			[FieldOffset(24)]public bool independentResolveNone;
			[FieldOffset(28)]public bool independentResolve;
		}

        public static ManagedPtr<VkPhysicalDeviceDepthStencilResolveProperties> Pointer(this VkPhysicalDeviceDepthStencilResolveProperties i) => new ManagedPtr<VkPhysicalDeviceDepthStencilResolveProperties>(i);
        public static ManagedPtrArray<VkPhysicalDeviceDepthStencilResolveProperties> Pointer(this VkPhysicalDeviceDepthStencilResolveProperties[] i) => new ManagedPtrArray<VkPhysicalDeviceDepthStencilResolveProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceScalarBlockLayoutFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool scalarBlockLayout;
		}

        public static ManagedPtr<VkPhysicalDeviceScalarBlockLayoutFeatures> Pointer(this VkPhysicalDeviceScalarBlockLayoutFeatures i) => new ManagedPtr<VkPhysicalDeviceScalarBlockLayoutFeatures>(i);
        public static ManagedPtrArray<VkPhysicalDeviceScalarBlockLayoutFeatures> Pointer(this VkPhysicalDeviceScalarBlockLayoutFeatures[] i) => new ManagedPtrArray<VkPhysicalDeviceScalarBlockLayoutFeatures>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageStencilUsageCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkImageUsageFlags stencilUsage;
		}

        public static ManagedPtr<VkImageStencilUsageCreateInfo> Pointer(this VkImageStencilUsageCreateInfo i) => new ManagedPtr<VkImageStencilUsageCreateInfo>(i);
        public static ManagedPtrArray<VkImageStencilUsageCreateInfo> Pointer(this VkImageStencilUsageCreateInfo[] i) => new ManagedPtrArray<VkImageStencilUsageCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSamplerReductionModeCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkSamplerReductionMode reductionMode;
		}

        public static ManagedPtr<VkSamplerReductionModeCreateInfo> Pointer(this VkSamplerReductionModeCreateInfo i) => new ManagedPtr<VkSamplerReductionModeCreateInfo>(i);
        public static ManagedPtrArray<VkSamplerReductionModeCreateInfo> Pointer(this VkSamplerReductionModeCreateInfo[] i) => new ManagedPtrArray<VkSamplerReductionModeCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceSamplerFilterMinmaxProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool filterMinmaxSingleComponentFormats;
			[FieldOffset(20)]public bool filterMinmaxImageComponentMapping;
		}

        public static ManagedPtr<VkPhysicalDeviceSamplerFilterMinmaxProperties> Pointer(this VkPhysicalDeviceSamplerFilterMinmaxProperties i) => new ManagedPtr<VkPhysicalDeviceSamplerFilterMinmaxProperties>(i);
        public static ManagedPtrArray<VkPhysicalDeviceSamplerFilterMinmaxProperties> Pointer(this VkPhysicalDeviceSamplerFilterMinmaxProperties[] i) => new ManagedPtrArray<VkPhysicalDeviceSamplerFilterMinmaxProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceVulkanMemoryModelFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool vulkanMemoryModel;
			[FieldOffset(20)]public bool vulkanMemoryModelDeviceScope;
			[FieldOffset(24)]public bool vulkanMemoryModelAvailabilityVisibilityChains;
		}

        public static ManagedPtr<VkPhysicalDeviceVulkanMemoryModelFeatures> Pointer(this VkPhysicalDeviceVulkanMemoryModelFeatures i) => new ManagedPtr<VkPhysicalDeviceVulkanMemoryModelFeatures>(i);
        public static ManagedPtrArray<VkPhysicalDeviceVulkanMemoryModelFeatures> Pointer(this VkPhysicalDeviceVulkanMemoryModelFeatures[] i) => new ManagedPtrArray<VkPhysicalDeviceVulkanMemoryModelFeatures>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceImagelessFramebufferFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool imagelessFramebuffer;
		}

        public static ManagedPtr<VkPhysicalDeviceImagelessFramebufferFeatures> Pointer(this VkPhysicalDeviceImagelessFramebufferFeatures i) => new ManagedPtr<VkPhysicalDeviceImagelessFramebufferFeatures>(i);
        public static ManagedPtrArray<VkPhysicalDeviceImagelessFramebufferFeatures> Pointer(this VkPhysicalDeviceImagelessFramebufferFeatures[] i) => new ManagedPtrArray<VkPhysicalDeviceImagelessFramebufferFeatures>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkFramebufferAttachmentImageInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkImageCreateFlags flags;
			[FieldOffset(20)]public VkImageUsageFlags usage;
			[FieldOffset(24)]public uint width;
			[FieldOffset(28)]public uint height;
			[FieldOffset(32)]public uint layerCount;
			[FieldOffset(36)]public uint viewFormatCount;
			[FieldOffset(40)]public VkFormat* pViewFormats;
		}

        public static ManagedPtr<VkFramebufferAttachmentImageInfo> Pointer(this VkFramebufferAttachmentImageInfo i) => new ManagedPtr<VkFramebufferAttachmentImageInfo>(i);
        public static ManagedPtrArray<VkFramebufferAttachmentImageInfo> Pointer(this VkFramebufferAttachmentImageInfo[] i) => new ManagedPtrArray<VkFramebufferAttachmentImageInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkFramebufferAttachmentsCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint attachmentImageInfoCount;
			[FieldOffset(24)]public IntPtr pAttachmentImageInfos;
		}

        public static ManagedPtr<VkFramebufferAttachmentsCreateInfo> Pointer(this VkFramebufferAttachmentsCreateInfo i) => new ManagedPtr<VkFramebufferAttachmentsCreateInfo>(i);
        public static ManagedPtrArray<VkFramebufferAttachmentsCreateInfo> Pointer(this VkFramebufferAttachmentsCreateInfo[] i) => new ManagedPtrArray<VkFramebufferAttachmentsCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRenderPassAttachmentBeginInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint attachmentCount;
			[FieldOffset(24)]public IntPtr* pAttachments;
		}

        public static ManagedPtr<VkRenderPassAttachmentBeginInfo> Pointer(this VkRenderPassAttachmentBeginInfo i) => new ManagedPtr<VkRenderPassAttachmentBeginInfo>(i);
        public static ManagedPtrArray<VkRenderPassAttachmentBeginInfo> Pointer(this VkRenderPassAttachmentBeginInfo[] i) => new ManagedPtrArray<VkRenderPassAttachmentBeginInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceUniformBufferStandardLayoutFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool uniformBufferStandardLayout;
		}

        public static ManagedPtr<VkPhysicalDeviceUniformBufferStandardLayoutFeatures> Pointer(this VkPhysicalDeviceUniformBufferStandardLayoutFeatures i) => new ManagedPtr<VkPhysicalDeviceUniformBufferStandardLayoutFeatures>(i);
        public static ManagedPtrArray<VkPhysicalDeviceUniformBufferStandardLayoutFeatures> Pointer(this VkPhysicalDeviceUniformBufferStandardLayoutFeatures[] i) => new ManagedPtrArray<VkPhysicalDeviceUniformBufferStandardLayoutFeatures>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool shaderSubgroupExtendedTypes;
		}

        public static ManagedPtr<VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures> Pointer(this VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures i) => new ManagedPtr<VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures>(i);
        public static ManagedPtrArray<VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures> Pointer(this VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures[] i) => new ManagedPtrArray<VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool separateDepthStencilLayouts;
		}

        public static ManagedPtr<VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures> Pointer(this VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures i) => new ManagedPtr<VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures>(i);
        public static ManagedPtrArray<VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures> Pointer(this VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures[] i) => new ManagedPtrArray<VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAttachmentReferenceStencilLayout {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkImageLayout stencilLayout;
		}

        public static ManagedPtr<VkAttachmentReferenceStencilLayout> Pointer(this VkAttachmentReferenceStencilLayout i) => new ManagedPtr<VkAttachmentReferenceStencilLayout>(i);
        public static ManagedPtrArray<VkAttachmentReferenceStencilLayout> Pointer(this VkAttachmentReferenceStencilLayout[] i) => new ManagedPtrArray<VkAttachmentReferenceStencilLayout>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAttachmentDescriptionStencilLayout {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkImageLayout stencilInitialLayout;
			[FieldOffset(20)]public VkImageLayout stencilFinalLayout;
		}

        public static ManagedPtr<VkAttachmentDescriptionStencilLayout> Pointer(this VkAttachmentDescriptionStencilLayout i) => new ManagedPtr<VkAttachmentDescriptionStencilLayout>(i);
        public static ManagedPtrArray<VkAttachmentDescriptionStencilLayout> Pointer(this VkAttachmentDescriptionStencilLayout[] i) => new ManagedPtrArray<VkAttachmentDescriptionStencilLayout>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceHostQueryResetFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool hostQueryReset;
		}

        public static ManagedPtr<VkPhysicalDeviceHostQueryResetFeatures> Pointer(this VkPhysicalDeviceHostQueryResetFeatures i) => new ManagedPtr<VkPhysicalDeviceHostQueryResetFeatures>(i);
        public static ManagedPtrArray<VkPhysicalDeviceHostQueryResetFeatures> Pointer(this VkPhysicalDeviceHostQueryResetFeatures[] i) => new ManagedPtrArray<VkPhysicalDeviceHostQueryResetFeatures>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceTimelineSemaphoreFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool timelineSemaphore;
		}

        public static ManagedPtr<VkPhysicalDeviceTimelineSemaphoreFeatures> Pointer(this VkPhysicalDeviceTimelineSemaphoreFeatures i) => new ManagedPtr<VkPhysicalDeviceTimelineSemaphoreFeatures>(i);
        public static ManagedPtrArray<VkPhysicalDeviceTimelineSemaphoreFeatures> Pointer(this VkPhysicalDeviceTimelineSemaphoreFeatures[] i) => new ManagedPtrArray<VkPhysicalDeviceTimelineSemaphoreFeatures>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceTimelineSemaphoreProperties {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong maxTimelineSemaphoreValueDifference;
		}

        public static ManagedPtr<VkPhysicalDeviceTimelineSemaphoreProperties> Pointer(this VkPhysicalDeviceTimelineSemaphoreProperties i) => new ManagedPtr<VkPhysicalDeviceTimelineSemaphoreProperties>(i);
        public static ManagedPtrArray<VkPhysicalDeviceTimelineSemaphoreProperties> Pointer(this VkPhysicalDeviceTimelineSemaphoreProperties[] i) => new ManagedPtrArray<VkPhysicalDeviceTimelineSemaphoreProperties>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSemaphoreTypeCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkSemaphoreType semaphoreType;
			[FieldOffset(24)]public ulong initialValue;
		}

        public static ManagedPtr<VkSemaphoreTypeCreateInfo> Pointer(this VkSemaphoreTypeCreateInfo i) => new ManagedPtr<VkSemaphoreTypeCreateInfo>(i);
        public static ManagedPtrArray<VkSemaphoreTypeCreateInfo> Pointer(this VkSemaphoreTypeCreateInfo[] i) => new ManagedPtrArray<VkSemaphoreTypeCreateInfo>(i);
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
        public static ManagedPtrArray<VkTimelineSemaphoreSubmitInfo> Pointer(this VkTimelineSemaphoreSubmitInfo[] i) => new ManagedPtrArray<VkTimelineSemaphoreSubmitInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSemaphoreWaitInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkSemaphoreWaitFlags flags;
			[FieldOffset(20)]public uint semaphoreCount;
			[FieldOffset(24)]public IntPtr* pSemaphores;
			[FieldOffset(32)]public ulong* pValues;
		}

        public static ManagedPtr<VkSemaphoreWaitInfo> Pointer(this VkSemaphoreWaitInfo i) => new ManagedPtr<VkSemaphoreWaitInfo>(i);
        public static ManagedPtrArray<VkSemaphoreWaitInfo> Pointer(this VkSemaphoreWaitInfo[] i) => new ManagedPtrArray<VkSemaphoreWaitInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSemaphoreSignalInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr semaphore;
			[FieldOffset(24)]public ulong value;
		}

        public static ManagedPtr<VkSemaphoreSignalInfo> Pointer(this VkSemaphoreSignalInfo i) => new ManagedPtr<VkSemaphoreSignalInfo>(i);
        public static ManagedPtrArray<VkSemaphoreSignalInfo> Pointer(this VkSemaphoreSignalInfo[] i) => new ManagedPtrArray<VkSemaphoreSignalInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeatures {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool bufferDeviceAddress;
			[FieldOffset(20)]public bool bufferDeviceAddressCaptureReplay;
			[FieldOffset(24)]public bool bufferDeviceAddressMultiDevice;
		}

        public static ManagedPtr<VkPhysicalDeviceBufferDeviceAddressFeatures> Pointer(this VkPhysicalDeviceBufferDeviceAddressFeatures i) => new ManagedPtr<VkPhysicalDeviceBufferDeviceAddressFeatures>(i);
        public static ManagedPtrArray<VkPhysicalDeviceBufferDeviceAddressFeatures> Pointer(this VkPhysicalDeviceBufferDeviceAddressFeatures[] i) => new ManagedPtrArray<VkPhysicalDeviceBufferDeviceAddressFeatures>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBufferDeviceAddressInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr buffer;
		}

        public static ManagedPtr<VkBufferDeviceAddressInfo> Pointer(this VkBufferDeviceAddressInfo i) => new ManagedPtr<VkBufferDeviceAddressInfo>(i);
        public static ManagedPtrArray<VkBufferDeviceAddressInfo> Pointer(this VkBufferDeviceAddressInfo[] i) => new ManagedPtrArray<VkBufferDeviceAddressInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBufferOpaqueCaptureAddressCreateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong opaqueCaptureAddress;
		}

        public static ManagedPtr<VkBufferOpaqueCaptureAddressCreateInfo> Pointer(this VkBufferOpaqueCaptureAddressCreateInfo i) => new ManagedPtr<VkBufferOpaqueCaptureAddressCreateInfo>(i);
        public static ManagedPtrArray<VkBufferOpaqueCaptureAddressCreateInfo> Pointer(this VkBufferOpaqueCaptureAddressCreateInfo[] i) => new ManagedPtrArray<VkBufferOpaqueCaptureAddressCreateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryOpaqueCaptureAddressAllocateInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong opaqueCaptureAddress;
		}

        public static ManagedPtr<VkMemoryOpaqueCaptureAddressAllocateInfo> Pointer(this VkMemoryOpaqueCaptureAddressAllocateInfo i) => new ManagedPtr<VkMemoryOpaqueCaptureAddressAllocateInfo>(i);
        public static ManagedPtrArray<VkMemoryOpaqueCaptureAddressAllocateInfo> Pointer(this VkMemoryOpaqueCaptureAddressAllocateInfo[] i) => new ManagedPtrArray<VkMemoryOpaqueCaptureAddressAllocateInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceMemoryOpaqueCaptureAddressInfo {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr memory;
		}

        public static ManagedPtr<VkDeviceMemoryOpaqueCaptureAddressInfo> Pointer(this VkDeviceMemoryOpaqueCaptureAddressInfo i) => new ManagedPtr<VkDeviceMemoryOpaqueCaptureAddressInfo>(i);
        public static ManagedPtrArray<VkDeviceMemoryOpaqueCaptureAddressInfo> Pointer(this VkDeviceMemoryOpaqueCaptureAddressInfo[] i) => new ManagedPtrArray<VkDeviceMemoryOpaqueCaptureAddressInfo>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSurfaceCapabilitiesKHR {
			[FieldOffset(0)]public uint minImageCount;
			[FieldOffset(4)]public uint maxImageCount;
			[FieldOffset(8)]public VkExtent2D currentExtent;
			[FieldOffset(16)]public VkExtent2D minImageExtent;
			[FieldOffset(24)]public VkExtent2D maxImageExtent;
			[FieldOffset(32)]public uint maxImageArrayLayers;
			[FieldOffset(36)]public VkSurfaceTransformFlagsKHR supportedTransforms;
			[FieldOffset(40)]public VkSurfaceTransformFlagsKHR currentTransform;
			[FieldOffset(44)]public VkCompositeAlphaFlagsKHR supportedCompositeAlpha;
			[FieldOffset(48)]public VkImageUsageFlags supportedUsageFlags;
		}

        public static ManagedPtr<VkSurfaceCapabilitiesKHR> Pointer(this VkSurfaceCapabilitiesKHR i) => new ManagedPtr<VkSurfaceCapabilitiesKHR>(i);
        public static ManagedPtrArray<VkSurfaceCapabilitiesKHR> Pointer(this VkSurfaceCapabilitiesKHR[] i) => new ManagedPtrArray<VkSurfaceCapabilitiesKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSurfaceFormatKHR {
			[FieldOffset(0)]public VkFormat format;
			[FieldOffset(4)]public VkColorSpaceKHR colorSpace;
		}

        public static ManagedPtr<VkSurfaceFormatKHR> Pointer(this VkSurfaceFormatKHR i) => new ManagedPtr<VkSurfaceFormatKHR>(i);
        public static ManagedPtrArray<VkSurfaceFormatKHR> Pointer(this VkSurfaceFormatKHR[] i) => new ManagedPtrArray<VkSurfaceFormatKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSwapchainCreateInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkSwapchainCreateFlagsKHR flags;
			[FieldOffset(24)]public IntPtr surface;
			[FieldOffset(32)]public uint minImageCount;
			[FieldOffset(36)]public VkFormat imageFormat;
			[FieldOffset(40)]public VkColorSpaceKHR imageColorSpace;
			[FieldOffset(44)]public VkExtent2D imageExtent;
			[FieldOffset(52)]public uint imageArrayLayers;
			[FieldOffset(56)]public VkImageUsageFlags imageUsage;
			[FieldOffset(60)]public VkSharingMode imageSharingMode;
			[FieldOffset(64)]public uint queueFamilyIndexCount;
			[FieldOffset(72)]public uint* pQueueFamilyIndices;
			[FieldOffset(80)]public VkSurfaceTransformFlagsKHR preTransform;
			[FieldOffset(84)]public VkCompositeAlphaFlagsKHR compositeAlpha;
			[FieldOffset(88)]public VkPresentModeKHR presentMode;
			[FieldOffset(92)]public bool clipped;
			[FieldOffset(96)]public IntPtr oldSwapchain;
		}

        public static ManagedPtr<VkSwapchainCreateInfoKHR> Pointer(this VkSwapchainCreateInfoKHR i) => new ManagedPtr<VkSwapchainCreateInfoKHR>(i);
        public static ManagedPtrArray<VkSwapchainCreateInfoKHR> Pointer(this VkSwapchainCreateInfoKHR[] i) => new ManagedPtrArray<VkSwapchainCreateInfoKHR>(i);
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
        public static ManagedPtrArray<VkPresentInfoKHR> Pointer(this VkPresentInfoKHR[] i) => new ManagedPtrArray<VkPresentInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageSwapchainCreateInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr swapchain;
		}

        public static ManagedPtr<VkImageSwapchainCreateInfoKHR> Pointer(this VkImageSwapchainCreateInfoKHR i) => new ManagedPtr<VkImageSwapchainCreateInfoKHR>(i);
        public static ManagedPtrArray<VkImageSwapchainCreateInfoKHR> Pointer(this VkImageSwapchainCreateInfoKHR[] i) => new ManagedPtrArray<VkImageSwapchainCreateInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBindImageMemorySwapchainInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr swapchain;
			[FieldOffset(24)]public uint imageIndex;
		}

        public static ManagedPtr<VkBindImageMemorySwapchainInfoKHR> Pointer(this VkBindImageMemorySwapchainInfoKHR i) => new ManagedPtr<VkBindImageMemorySwapchainInfoKHR>(i);
        public static ManagedPtrArray<VkBindImageMemorySwapchainInfoKHR> Pointer(this VkBindImageMemorySwapchainInfoKHR[] i) => new ManagedPtrArray<VkBindImageMemorySwapchainInfoKHR>(i);
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
        public static ManagedPtrArray<VkAcquireNextImageInfoKHR> Pointer(this VkAcquireNextImageInfoKHR[] i) => new ManagedPtrArray<VkAcquireNextImageInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceGroupPresentCapabilitiesKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public fixed uint presentMask[32];
			public const int presentMask_len = 32;
			[FieldOffset(144)]public VkDeviceGroupPresentModeFlagsKHR modes;
		}

        public static ManagedPtr<VkDeviceGroupPresentCapabilitiesKHR> Pointer(this VkDeviceGroupPresentCapabilitiesKHR i) => new ManagedPtr<VkDeviceGroupPresentCapabilitiesKHR>(i);
        public static ManagedPtrArray<VkDeviceGroupPresentCapabilitiesKHR> Pointer(this VkDeviceGroupPresentCapabilitiesKHR[] i) => new ManagedPtrArray<VkDeviceGroupPresentCapabilitiesKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceGroupPresentInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint swapchainCount;
			[FieldOffset(24)]public uint* pDeviceMasks;
			[FieldOffset(32)]public VkDeviceGroupPresentModeFlagsKHR mode;
		}

        public static ManagedPtr<VkDeviceGroupPresentInfoKHR> Pointer(this VkDeviceGroupPresentInfoKHR i) => new ManagedPtr<VkDeviceGroupPresentInfoKHR>(i);
        public static ManagedPtrArray<VkDeviceGroupPresentInfoKHR> Pointer(this VkDeviceGroupPresentInfoKHR[] i) => new ManagedPtrArray<VkDeviceGroupPresentInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceGroupSwapchainCreateInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDeviceGroupPresentModeFlagsKHR modes;
		}

        public static ManagedPtr<VkDeviceGroupSwapchainCreateInfoKHR> Pointer(this VkDeviceGroupSwapchainCreateInfoKHR i) => new ManagedPtr<VkDeviceGroupSwapchainCreateInfoKHR>(i);
        public static ManagedPtrArray<VkDeviceGroupSwapchainCreateInfoKHR> Pointer(this VkDeviceGroupSwapchainCreateInfoKHR[] i) => new ManagedPtrArray<VkDeviceGroupSwapchainCreateInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayPropertiesKHR {
			[FieldOffset(0)]public IntPtr display;
			[FieldOffset(8)]public string displayName;
			[FieldOffset(16)]public VkExtent2D physicalDimensions;
			[FieldOffset(24)]public VkExtent2D physicalResolution;
			[FieldOffset(32)]public VkSurfaceTransformFlagsKHR supportedTransforms;
			[FieldOffset(36)]public bool planeReorderPossible;
			[FieldOffset(40)]public bool persistentContent;
		}

        public static ManagedPtr<VkDisplayPropertiesKHR> Pointer(this VkDisplayPropertiesKHR i) => new ManagedPtr<VkDisplayPropertiesKHR>(i);
        public static ManagedPtrArray<VkDisplayPropertiesKHR> Pointer(this VkDisplayPropertiesKHR[] i) => new ManagedPtrArray<VkDisplayPropertiesKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayModeParametersKHR {
			[FieldOffset(0)]public VkExtent2D visibleRegion;
			[FieldOffset(8)]public uint refreshRate;
		}

        public static ManagedPtr<VkDisplayModeParametersKHR> Pointer(this VkDisplayModeParametersKHR i) => new ManagedPtr<VkDisplayModeParametersKHR>(i);
        public static ManagedPtrArray<VkDisplayModeParametersKHR> Pointer(this VkDisplayModeParametersKHR[] i) => new ManagedPtrArray<VkDisplayModeParametersKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayModePropertiesKHR {
			[FieldOffset(0)]public IntPtr displayMode;
			[FieldOffset(8)]public VkDisplayModeParametersKHR parameters;
		}

        public static ManagedPtr<VkDisplayModePropertiesKHR> Pointer(this VkDisplayModePropertiesKHR i) => new ManagedPtr<VkDisplayModePropertiesKHR>(i);
        public static ManagedPtrArray<VkDisplayModePropertiesKHR> Pointer(this VkDisplayModePropertiesKHR[] i) => new ManagedPtrArray<VkDisplayModePropertiesKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayModeCreateInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public VkDisplayModeParametersKHR parameters;
		}

        public static ManagedPtr<VkDisplayModeCreateInfoKHR> Pointer(this VkDisplayModeCreateInfoKHR i) => new ManagedPtr<VkDisplayModeCreateInfoKHR>(i);
        public static ManagedPtrArray<VkDisplayModeCreateInfoKHR> Pointer(this VkDisplayModeCreateInfoKHR[] i) => new ManagedPtrArray<VkDisplayModeCreateInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayPlaneCapabilitiesKHR {
			[FieldOffset(0)]public VkDisplayPlaneAlphaFlagsKHR supportedAlpha;
			[FieldOffset(4)]public VkOffset2D minSrcPosition;
			[FieldOffset(12)]public VkOffset2D maxSrcPosition;
			[FieldOffset(20)]public VkExtent2D minSrcExtent;
			[FieldOffset(28)]public VkExtent2D maxSrcExtent;
			[FieldOffset(36)]public VkOffset2D minDstPosition;
			[FieldOffset(44)]public VkOffset2D maxDstPosition;
			[FieldOffset(52)]public VkExtent2D minDstExtent;
			[FieldOffset(60)]public VkExtent2D maxDstExtent;
		}

        public static ManagedPtr<VkDisplayPlaneCapabilitiesKHR> Pointer(this VkDisplayPlaneCapabilitiesKHR i) => new ManagedPtr<VkDisplayPlaneCapabilitiesKHR>(i);
        public static ManagedPtrArray<VkDisplayPlaneCapabilitiesKHR> Pointer(this VkDisplayPlaneCapabilitiesKHR[] i) => new ManagedPtrArray<VkDisplayPlaneCapabilitiesKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayPlanePropertiesKHR {
			[FieldOffset(0)]public IntPtr currentDisplay;
			[FieldOffset(8)]public uint currentStackIndex;
		}

        public static ManagedPtr<VkDisplayPlanePropertiesKHR> Pointer(this VkDisplayPlanePropertiesKHR i) => new ManagedPtr<VkDisplayPlanePropertiesKHR>(i);
        public static ManagedPtrArray<VkDisplayPlanePropertiesKHR> Pointer(this VkDisplayPlanePropertiesKHR[] i) => new ManagedPtrArray<VkDisplayPlanePropertiesKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplaySurfaceCreateInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(24)]public IntPtr displayMode;
			[FieldOffset(32)]public uint planeIndex;
			[FieldOffset(36)]public uint planeStackIndex;
			[FieldOffset(40)]public VkSurfaceTransformFlagsKHR transform;
			[FieldOffset(44)]public float globalAlpha;
			[FieldOffset(48)]public VkDisplayPlaneAlphaFlagsKHR alphaMode;
			[FieldOffset(52)]public VkExtent2D imageExtent;
		}

        public static ManagedPtr<VkDisplaySurfaceCreateInfoKHR> Pointer(this VkDisplaySurfaceCreateInfoKHR i) => new ManagedPtr<VkDisplaySurfaceCreateInfoKHR>(i);
        public static ManagedPtrArray<VkDisplaySurfaceCreateInfoKHR> Pointer(this VkDisplaySurfaceCreateInfoKHR[] i) => new ManagedPtrArray<VkDisplaySurfaceCreateInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayPresentInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkRect2D srcRect;
			[FieldOffset(32)]public VkRect2D dstRect;
			[FieldOffset(48)]public bool persistent;
		}

        public static ManagedPtr<VkDisplayPresentInfoKHR> Pointer(this VkDisplayPresentInfoKHR i) => new ManagedPtr<VkDisplayPresentInfoKHR>(i);
        public static ManagedPtrArray<VkDisplayPresentInfoKHR> Pointer(this VkDisplayPresentInfoKHR[] i) => new ManagedPtrArray<VkDisplayPresentInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImportMemoryFdInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalMemoryHandleTypeFlags handleType;
			[FieldOffset(20)]public int fd;
		}

        public static ManagedPtr<VkImportMemoryFdInfoKHR> Pointer(this VkImportMemoryFdInfoKHR i) => new ManagedPtr<VkImportMemoryFdInfoKHR>(i);
        public static ManagedPtrArray<VkImportMemoryFdInfoKHR> Pointer(this VkImportMemoryFdInfoKHR[] i) => new ManagedPtrArray<VkImportMemoryFdInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryFdPropertiesKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint memoryTypeBits;
		}

        public static ManagedPtr<VkMemoryFdPropertiesKHR> Pointer(this VkMemoryFdPropertiesKHR i) => new ManagedPtr<VkMemoryFdPropertiesKHR>(i);
        public static ManagedPtrArray<VkMemoryFdPropertiesKHR> Pointer(this VkMemoryFdPropertiesKHR[] i) => new ManagedPtrArray<VkMemoryFdPropertiesKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryGetFdInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr memory;
			[FieldOffset(24)]public VkExternalMemoryHandleTypeFlags handleType;
		}

        public static ManagedPtr<VkMemoryGetFdInfoKHR> Pointer(this VkMemoryGetFdInfoKHR i) => new ManagedPtr<VkMemoryGetFdInfoKHR>(i);
        public static ManagedPtrArray<VkMemoryGetFdInfoKHR> Pointer(this VkMemoryGetFdInfoKHR[] i) => new ManagedPtrArray<VkMemoryGetFdInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImportSemaphoreFdInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr semaphore;
			[FieldOffset(24)]public VkSemaphoreImportFlags flags;
			[FieldOffset(28)]public VkExternalSemaphoreHandleTypeFlags handleType;
			[FieldOffset(32)]public int fd;
		}

        public static ManagedPtr<VkImportSemaphoreFdInfoKHR> Pointer(this VkImportSemaphoreFdInfoKHR i) => new ManagedPtr<VkImportSemaphoreFdInfoKHR>(i);
        public static ManagedPtrArray<VkImportSemaphoreFdInfoKHR> Pointer(this VkImportSemaphoreFdInfoKHR[] i) => new ManagedPtrArray<VkImportSemaphoreFdInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSemaphoreGetFdInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr semaphore;
			[FieldOffset(24)]public VkExternalSemaphoreHandleTypeFlags handleType;
		}

        public static ManagedPtr<VkSemaphoreGetFdInfoKHR> Pointer(this VkSemaphoreGetFdInfoKHR i) => new ManagedPtr<VkSemaphoreGetFdInfoKHR>(i);
        public static ManagedPtrArray<VkSemaphoreGetFdInfoKHR> Pointer(this VkSemaphoreGetFdInfoKHR[] i) => new ManagedPtrArray<VkSemaphoreGetFdInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDevicePushDescriptorPropertiesKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint maxPushDescriptors;
		}

        public static ManagedPtr<VkPhysicalDevicePushDescriptorPropertiesKHR> Pointer(this VkPhysicalDevicePushDescriptorPropertiesKHR i) => new ManagedPtr<VkPhysicalDevicePushDescriptorPropertiesKHR>(i);
        public static ManagedPtrArray<VkPhysicalDevicePushDescriptorPropertiesKHR> Pointer(this VkPhysicalDevicePushDescriptorPropertiesKHR[] i) => new ManagedPtrArray<VkPhysicalDevicePushDescriptorPropertiesKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRectLayerKHR {
			[FieldOffset(0)]public VkOffset2D offset;
			[FieldOffset(8)]public VkExtent2D extent;
			[FieldOffset(16)]public uint layer;
		}

        public static ManagedPtr<VkRectLayerKHR> Pointer(this VkRectLayerKHR i) => new ManagedPtr<VkRectLayerKHR>(i);
        public static ManagedPtrArray<VkRectLayerKHR> Pointer(this VkRectLayerKHR[] i) => new ManagedPtrArray<VkRectLayerKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPresentRegionKHR {
			[FieldOffset(0)]public uint rectangleCount;
			[FieldOffset(8)]public IntPtr pRectangles;
		}

        public static ManagedPtr<VkPresentRegionKHR> Pointer(this VkPresentRegionKHR i) => new ManagedPtr<VkPresentRegionKHR>(i);
        public static ManagedPtrArray<VkPresentRegionKHR> Pointer(this VkPresentRegionKHR[] i) => new ManagedPtrArray<VkPresentRegionKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPresentRegionsKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint swapchainCount;
			[FieldOffset(24)]public IntPtr pRegions;
		}

        public static ManagedPtr<VkPresentRegionsKHR> Pointer(this VkPresentRegionsKHR i) => new ManagedPtr<VkPresentRegionsKHR>(i);
        public static ManagedPtrArray<VkPresentRegionsKHR> Pointer(this VkPresentRegionsKHR[] i) => new ManagedPtrArray<VkPresentRegionsKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSharedPresentSurfaceCapabilitiesKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkImageUsageFlags sharedPresentSupportedUsageFlags;
		}

        public static ManagedPtr<VkSharedPresentSurfaceCapabilitiesKHR> Pointer(this VkSharedPresentSurfaceCapabilitiesKHR i) => new ManagedPtr<VkSharedPresentSurfaceCapabilitiesKHR>(i);
        public static ManagedPtrArray<VkSharedPresentSurfaceCapabilitiesKHR> Pointer(this VkSharedPresentSurfaceCapabilitiesKHR[] i) => new ManagedPtrArray<VkSharedPresentSurfaceCapabilitiesKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImportFenceFdInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr fence;
			[FieldOffset(24)]public VkFenceImportFlags flags;
			[FieldOffset(28)]public VkExternalFenceHandleTypeFlags handleType;
			[FieldOffset(32)]public int fd;
		}

        public static ManagedPtr<VkImportFenceFdInfoKHR> Pointer(this VkImportFenceFdInfoKHR i) => new ManagedPtr<VkImportFenceFdInfoKHR>(i);
        public static ManagedPtrArray<VkImportFenceFdInfoKHR> Pointer(this VkImportFenceFdInfoKHR[] i) => new ManagedPtrArray<VkImportFenceFdInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkFenceGetFdInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr fence;
			[FieldOffset(24)]public VkExternalFenceHandleTypeFlags handleType;
		}

        public static ManagedPtr<VkFenceGetFdInfoKHR> Pointer(this VkFenceGetFdInfoKHR i) => new ManagedPtr<VkFenceGetFdInfoKHR>(i);
        public static ManagedPtrArray<VkFenceGetFdInfoKHR> Pointer(this VkFenceGetFdInfoKHR[] i) => new ManagedPtrArray<VkFenceGetFdInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDevicePerformanceQueryFeaturesKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool performanceCounterQueryPools;
			[FieldOffset(20)]public bool performanceCounterMultipleQueryPools;
		}

        public static ManagedPtr<VkPhysicalDevicePerformanceQueryFeaturesKHR> Pointer(this VkPhysicalDevicePerformanceQueryFeaturesKHR i) => new ManagedPtr<VkPhysicalDevicePerformanceQueryFeaturesKHR>(i);
        public static ManagedPtrArray<VkPhysicalDevicePerformanceQueryFeaturesKHR> Pointer(this VkPhysicalDevicePerformanceQueryFeaturesKHR[] i) => new ManagedPtrArray<VkPhysicalDevicePerformanceQueryFeaturesKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDevicePerformanceQueryPropertiesKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool allowCommandBufferQueryCopies;
		}

        public static ManagedPtr<VkPhysicalDevicePerformanceQueryPropertiesKHR> Pointer(this VkPhysicalDevicePerformanceQueryPropertiesKHR i) => new ManagedPtr<VkPhysicalDevicePerformanceQueryPropertiesKHR>(i);
        public static ManagedPtrArray<VkPhysicalDevicePerformanceQueryPropertiesKHR> Pointer(this VkPhysicalDevicePerformanceQueryPropertiesKHR[] i) => new ManagedPtrArray<VkPhysicalDevicePerformanceQueryPropertiesKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPerformanceCounterKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPerformanceCounterUnitKHR unit;
			[FieldOffset(20)]public VkPerformanceCounterScopeKHR scope;
			[FieldOffset(24)]public VkPerformanceCounterStorageKHR storage;
			[FieldOffset(28)]public fixed byte uuid[16];
			public const int uuid_len = 16;
		}

        public static ManagedPtr<VkPerformanceCounterKHR> Pointer(this VkPerformanceCounterKHR i) => new ManagedPtr<VkPerformanceCounterKHR>(i);
        public static ManagedPtrArray<VkPerformanceCounterKHR> Pointer(this VkPerformanceCounterKHR[] i) => new ManagedPtrArray<VkPerformanceCounterKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPerformanceCounterDescriptionKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPerformanceCounterDescriptionFlagsKHR flags;
			[FieldOffset(20)]public fixed byte name[256];
			public const int name_len = 256;
			[FieldOffset(276)]public fixed byte category[256];
			public const int category_len = 256;
			[FieldOffset(532)]public fixed byte description[256];
			public const int description_len = 256;
		}

        public static ManagedPtr<VkPerformanceCounterDescriptionKHR> Pointer(this VkPerformanceCounterDescriptionKHR i) => new ManagedPtr<VkPerformanceCounterDescriptionKHR>(i);
        public static ManagedPtrArray<VkPerformanceCounterDescriptionKHR> Pointer(this VkPerformanceCounterDescriptionKHR[] i) => new ManagedPtrArray<VkPerformanceCounterDescriptionKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkQueryPoolPerformanceCreateInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint queueFamilyIndex;
			[FieldOffset(20)]public uint counterIndexCount;
			[FieldOffset(24)]public uint* pCounterIndices;
		}

        public static ManagedPtr<VkQueryPoolPerformanceCreateInfoKHR> Pointer(this VkQueryPoolPerformanceCreateInfoKHR i) => new ManagedPtr<VkQueryPoolPerformanceCreateInfoKHR>(i);
        public static ManagedPtrArray<VkQueryPoolPerformanceCreateInfoKHR> Pointer(this VkQueryPoolPerformanceCreateInfoKHR[] i) => new ManagedPtrArray<VkQueryPoolPerformanceCreateInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAcquireProfilingLockInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkAcquireProfilingLockFlagsKHR flags;
			[FieldOffset(24)]public ulong timeout;
		}

        public static ManagedPtr<VkAcquireProfilingLockInfoKHR> Pointer(this VkAcquireProfilingLockInfoKHR i) => new ManagedPtr<VkAcquireProfilingLockInfoKHR>(i);
        public static ManagedPtrArray<VkAcquireProfilingLockInfoKHR> Pointer(this VkAcquireProfilingLockInfoKHR[] i) => new ManagedPtrArray<VkAcquireProfilingLockInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPerformanceQuerySubmitInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint counterPassIndex;
		}

        public static ManagedPtr<VkPerformanceQuerySubmitInfoKHR> Pointer(this VkPerformanceQuerySubmitInfoKHR i) => new ManagedPtr<VkPerformanceQuerySubmitInfoKHR>(i);
        public static ManagedPtrArray<VkPerformanceQuerySubmitInfoKHR> Pointer(this VkPerformanceQuerySubmitInfoKHR[] i) => new ManagedPtrArray<VkPerformanceQuerySubmitInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceSurfaceInfo2KHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr surface;
		}

        public static ManagedPtr<VkPhysicalDeviceSurfaceInfo2KHR> Pointer(this VkPhysicalDeviceSurfaceInfo2KHR i) => new ManagedPtr<VkPhysicalDeviceSurfaceInfo2KHR>(i);
        public static ManagedPtrArray<VkPhysicalDeviceSurfaceInfo2KHR> Pointer(this VkPhysicalDeviceSurfaceInfo2KHR[] i) => new ManagedPtrArray<VkPhysicalDeviceSurfaceInfo2KHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSurfaceCapabilities2KHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkSurfaceCapabilitiesKHR surfaceCapabilities;
		}

        public static ManagedPtr<VkSurfaceCapabilities2KHR> Pointer(this VkSurfaceCapabilities2KHR i) => new ManagedPtr<VkSurfaceCapabilities2KHR>(i);
        public static ManagedPtrArray<VkSurfaceCapabilities2KHR> Pointer(this VkSurfaceCapabilities2KHR[] i) => new ManagedPtrArray<VkSurfaceCapabilities2KHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSurfaceFormat2KHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkSurfaceFormatKHR surfaceFormat;
		}

        public static ManagedPtr<VkSurfaceFormat2KHR> Pointer(this VkSurfaceFormat2KHR i) => new ManagedPtr<VkSurfaceFormat2KHR>(i);
        public static ManagedPtrArray<VkSurfaceFormat2KHR> Pointer(this VkSurfaceFormat2KHR[] i) => new ManagedPtrArray<VkSurfaceFormat2KHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayProperties2KHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDisplayPropertiesKHR displayProperties;
		}

        public static ManagedPtr<VkDisplayProperties2KHR> Pointer(this VkDisplayProperties2KHR i) => new ManagedPtr<VkDisplayProperties2KHR>(i);
        public static ManagedPtrArray<VkDisplayProperties2KHR> Pointer(this VkDisplayProperties2KHR[] i) => new ManagedPtrArray<VkDisplayProperties2KHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayPlaneProperties2KHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDisplayPlanePropertiesKHR displayPlaneProperties;
		}

        public static ManagedPtr<VkDisplayPlaneProperties2KHR> Pointer(this VkDisplayPlaneProperties2KHR i) => new ManagedPtr<VkDisplayPlaneProperties2KHR>(i);
        public static ManagedPtrArray<VkDisplayPlaneProperties2KHR> Pointer(this VkDisplayPlaneProperties2KHR[] i) => new ManagedPtrArray<VkDisplayPlaneProperties2KHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayModeProperties2KHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDisplayModePropertiesKHR displayModeProperties;
		}

        public static ManagedPtr<VkDisplayModeProperties2KHR> Pointer(this VkDisplayModeProperties2KHR i) => new ManagedPtr<VkDisplayModeProperties2KHR>(i);
        public static ManagedPtrArray<VkDisplayModeProperties2KHR> Pointer(this VkDisplayModeProperties2KHR[] i) => new ManagedPtrArray<VkDisplayModeProperties2KHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayPlaneInfo2KHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr mode;
			[FieldOffset(24)]public uint planeIndex;
		}

        public static ManagedPtr<VkDisplayPlaneInfo2KHR> Pointer(this VkDisplayPlaneInfo2KHR i) => new ManagedPtr<VkDisplayPlaneInfo2KHR>(i);
        public static ManagedPtrArray<VkDisplayPlaneInfo2KHR> Pointer(this VkDisplayPlaneInfo2KHR[] i) => new ManagedPtrArray<VkDisplayPlaneInfo2KHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayPlaneCapabilities2KHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDisplayPlaneCapabilitiesKHR capabilities;
		}

        public static ManagedPtr<VkDisplayPlaneCapabilities2KHR> Pointer(this VkDisplayPlaneCapabilities2KHR i) => new ManagedPtr<VkDisplayPlaneCapabilities2KHR>(i);
        public static ManagedPtrArray<VkDisplayPlaneCapabilities2KHR> Pointer(this VkDisplayPlaneCapabilities2KHR[] i) => new ManagedPtrArray<VkDisplayPlaneCapabilities2KHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShaderClockFeaturesKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool shaderSubgroupClock;
			[FieldOffset(20)]public bool shaderDeviceClock;
		}

        public static ManagedPtr<VkPhysicalDeviceShaderClockFeaturesKHR> Pointer(this VkPhysicalDeviceShaderClockFeaturesKHR i) => new ManagedPtr<VkPhysicalDeviceShaderClockFeaturesKHR>(i);
        public static ManagedPtrArray<VkPhysicalDeviceShaderClockFeaturesKHR> Pointer(this VkPhysicalDeviceShaderClockFeaturesKHR[] i) => new ManagedPtrArray<VkPhysicalDeviceShaderClockFeaturesKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSurfaceProtectedCapabilitiesKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool supportsProtected;
		}

        public static ManagedPtr<VkSurfaceProtectedCapabilitiesKHR> Pointer(this VkSurfaceProtectedCapabilitiesKHR i) => new ManagedPtr<VkSurfaceProtectedCapabilitiesKHR>(i);
        public static ManagedPtrArray<VkSurfaceProtectedCapabilitiesKHR> Pointer(this VkSurfaceProtectedCapabilitiesKHR[] i) => new ManagedPtrArray<VkSurfaceProtectedCapabilitiesKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool pipelineExecutableInfo;
		}

        public static ManagedPtr<VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR> Pointer(this VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR i) => new ManagedPtr<VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR>(i);
        public static ManagedPtrArray<VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR> Pointer(this VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR[] i) => new ManagedPtrArray<VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr pipeline;
		}

        public static ManagedPtr<VkPipelineInfoKHR> Pointer(this VkPipelineInfoKHR i) => new ManagedPtr<VkPipelineInfoKHR>(i);
        public static ManagedPtrArray<VkPipelineInfoKHR> Pointer(this VkPipelineInfoKHR[] i) => new ManagedPtrArray<VkPipelineInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineExecutablePropertiesKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkShaderStageFlags stages;
			[FieldOffset(20)]public fixed byte name[256];
			public const int name_len = 256;
			[FieldOffset(276)]public fixed byte description[256];
			public const int description_len = 256;
			[FieldOffset(532)]public uint subgroupSize;
		}

        public static ManagedPtr<VkPipelineExecutablePropertiesKHR> Pointer(this VkPipelineExecutablePropertiesKHR i) => new ManagedPtr<VkPipelineExecutablePropertiesKHR>(i);
        public static ManagedPtrArray<VkPipelineExecutablePropertiesKHR> Pointer(this VkPipelineExecutablePropertiesKHR[] i) => new ManagedPtrArray<VkPipelineExecutablePropertiesKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineExecutableInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr pipeline;
			[FieldOffset(24)]public uint executableIndex;
		}

        public static ManagedPtr<VkPipelineExecutableInfoKHR> Pointer(this VkPipelineExecutableInfoKHR i) => new ManagedPtr<VkPipelineExecutableInfoKHR>(i);
        public static ManagedPtrArray<VkPipelineExecutableInfoKHR> Pointer(this VkPipelineExecutableInfoKHR[] i) => new ManagedPtrArray<VkPipelineExecutableInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineExecutableStatisticKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public fixed byte name[256];
			public const int name_len = 256;
			[FieldOffset(272)]public fixed byte description[256];
			public const int description_len = 256;
			[FieldOffset(528)]public VkPipelineExecutableStatisticFormatKHR format;
			[FieldOffset(536)]public VkPipelineExecutableStatisticValueKHR value;
		}

        public static ManagedPtr<VkPipelineExecutableStatisticKHR> Pointer(this VkPipelineExecutableStatisticKHR i) => new ManagedPtr<VkPipelineExecutableStatisticKHR>(i);
        public static ManagedPtrArray<VkPipelineExecutableStatisticKHR> Pointer(this VkPipelineExecutableStatisticKHR[] i) => new ManagedPtrArray<VkPipelineExecutableStatisticKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineExecutableInternalRepresentationKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public fixed byte name[256];
			public const int name_len = 256;
			[FieldOffset(272)]public fixed byte description[256];
			public const int description_len = 256;
			[FieldOffset(528)]public bool isText;
			[FieldOffset(536)]public ulong dataSize;
			[FieldOffset(544)]public IntPtr pData;
		}

        public static ManagedPtr<VkPipelineExecutableInternalRepresentationKHR> Pointer(this VkPipelineExecutableInternalRepresentationKHR i) => new ManagedPtr<VkPipelineExecutableInternalRepresentationKHR>(i);
        public static ManagedPtrArray<VkPipelineExecutableInternalRepresentationKHR> Pointer(this VkPipelineExecutableInternalRepresentationKHR[] i) => new ManagedPtrArray<VkPipelineExecutableInternalRepresentationKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDebugReportCallbackCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDebugReportFlagsEXT flags;
			[FieldOffset(24)][MarshalAs(UnmanagedType.FunctionPtr)]public PFN_vkDebugReportCallbackEXT pfnCallback;
			[FieldOffset(32)]public IntPtr pUserData;
		}

        public static ManagedPtr<VkDebugReportCallbackCreateInfoEXT> Pointer(this VkDebugReportCallbackCreateInfoEXT i) => new ManagedPtr<VkDebugReportCallbackCreateInfoEXT>(i);
        public static ManagedPtrArray<VkDebugReportCallbackCreateInfoEXT> Pointer(this VkDebugReportCallbackCreateInfoEXT[] i) => new ManagedPtrArray<VkDebugReportCallbackCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineRasterizationStateRasterizationOrderAMD {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkRasterizationOrderAMD rasterizationOrder;
		}

        public static ManagedPtr<VkPipelineRasterizationStateRasterizationOrderAMD> Pointer(this VkPipelineRasterizationStateRasterizationOrderAMD i) => new ManagedPtr<VkPipelineRasterizationStateRasterizationOrderAMD>(i);
        public static ManagedPtrArray<VkPipelineRasterizationStateRasterizationOrderAMD> Pointer(this VkPipelineRasterizationStateRasterizationOrderAMD[] i) => new ManagedPtrArray<VkPipelineRasterizationStateRasterizationOrderAMD>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDebugMarkerObjectNameInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDebugReportObjectTypeEXT objectType;
			[FieldOffset(24)]public ulong @object;
			[FieldOffset(32)]public string pObjectName;
		}

        public static ManagedPtr<VkDebugMarkerObjectNameInfoEXT> Pointer(this VkDebugMarkerObjectNameInfoEXT i) => new ManagedPtr<VkDebugMarkerObjectNameInfoEXT>(i);
        public static ManagedPtrArray<VkDebugMarkerObjectNameInfoEXT> Pointer(this VkDebugMarkerObjectNameInfoEXT[] i) => new ManagedPtrArray<VkDebugMarkerObjectNameInfoEXT>(i);
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
        public static ManagedPtrArray<VkDebugMarkerObjectTagInfoEXT> Pointer(this VkDebugMarkerObjectTagInfoEXT[] i) => new ManagedPtrArray<VkDebugMarkerObjectTagInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDebugMarkerMarkerInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public string pMarkerName;
			[FieldOffset(24)]public fixed float color[4];
			public const int color_len = 4;
		}

        public static ManagedPtr<VkDebugMarkerMarkerInfoEXT> Pointer(this VkDebugMarkerMarkerInfoEXT i) => new ManagedPtr<VkDebugMarkerMarkerInfoEXT>(i);
        public static ManagedPtrArray<VkDebugMarkerMarkerInfoEXT> Pointer(this VkDebugMarkerMarkerInfoEXT[] i) => new ManagedPtrArray<VkDebugMarkerMarkerInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDedicatedAllocationImageCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool dedicatedAllocation;
		}

        public static ManagedPtr<VkDedicatedAllocationImageCreateInfoNV> Pointer(this VkDedicatedAllocationImageCreateInfoNV i) => new ManagedPtr<VkDedicatedAllocationImageCreateInfoNV>(i);
        public static ManagedPtrArray<VkDedicatedAllocationImageCreateInfoNV> Pointer(this VkDedicatedAllocationImageCreateInfoNV[] i) => new ManagedPtrArray<VkDedicatedAllocationImageCreateInfoNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDedicatedAllocationBufferCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool dedicatedAllocation;
		}

        public static ManagedPtr<VkDedicatedAllocationBufferCreateInfoNV> Pointer(this VkDedicatedAllocationBufferCreateInfoNV i) => new ManagedPtr<VkDedicatedAllocationBufferCreateInfoNV>(i);
        public static ManagedPtrArray<VkDedicatedAllocationBufferCreateInfoNV> Pointer(this VkDedicatedAllocationBufferCreateInfoNV[] i) => new ManagedPtrArray<VkDedicatedAllocationBufferCreateInfoNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDedicatedAllocationMemoryAllocateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr image;
			[FieldOffset(24)]public IntPtr buffer;
		}

        public static ManagedPtr<VkDedicatedAllocationMemoryAllocateInfoNV> Pointer(this VkDedicatedAllocationMemoryAllocateInfoNV i) => new ManagedPtr<VkDedicatedAllocationMemoryAllocateInfoNV>(i);
        public static ManagedPtrArray<VkDedicatedAllocationMemoryAllocateInfoNV> Pointer(this VkDedicatedAllocationMemoryAllocateInfoNV[] i) => new ManagedPtrArray<VkDedicatedAllocationMemoryAllocateInfoNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceTransformFeedbackFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool transformFeedback;
			[FieldOffset(20)]public bool geometryStreams;
		}

        public static ManagedPtr<VkPhysicalDeviceTransformFeedbackFeaturesEXT> Pointer(this VkPhysicalDeviceTransformFeedbackFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceTransformFeedbackFeaturesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceTransformFeedbackFeaturesEXT> Pointer(this VkPhysicalDeviceTransformFeedbackFeaturesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceTransformFeedbackFeaturesEXT>(i);
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
			[FieldOffset(44)]public bool transformFeedbackQueries;
			[FieldOffset(48)]public bool transformFeedbackStreamsLinesTriangles;
			[FieldOffset(52)]public bool transformFeedbackRasterizationStreamSelect;
			[FieldOffset(56)]public bool transformFeedbackDraw;
		}

        public static ManagedPtr<VkPhysicalDeviceTransformFeedbackPropertiesEXT> Pointer(this VkPhysicalDeviceTransformFeedbackPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceTransformFeedbackPropertiesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceTransformFeedbackPropertiesEXT> Pointer(this VkPhysicalDeviceTransformFeedbackPropertiesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceTransformFeedbackPropertiesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineRasterizationStateStreamCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint rasterizationStream;
		}

        public static ManagedPtr<VkPipelineRasterizationStateStreamCreateInfoEXT> Pointer(this VkPipelineRasterizationStateStreamCreateInfoEXT i) => new ManagedPtr<VkPipelineRasterizationStateStreamCreateInfoEXT>(i);
        public static ManagedPtrArray<VkPipelineRasterizationStateStreamCreateInfoEXT> Pointer(this VkPipelineRasterizationStateStreamCreateInfoEXT[] i) => new ManagedPtrArray<VkPipelineRasterizationStateStreamCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageViewHandleInfoNVX {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr imageView;
			[FieldOffset(24)]public VkDescriptorType descriptorType;
			[FieldOffset(32)]public IntPtr sampler;
		}

        public static ManagedPtr<VkImageViewHandleInfoNVX> Pointer(this VkImageViewHandleInfoNVX i) => new ManagedPtr<VkImageViewHandleInfoNVX>(i);
        public static ManagedPtrArray<VkImageViewHandleInfoNVX> Pointer(this VkImageViewHandleInfoNVX[] i) => new ManagedPtrArray<VkImageViewHandleInfoNVX>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageViewAddressPropertiesNVX {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong deviceAddress;
			[FieldOffset(24)]public ulong size;
		}

        public static ManagedPtr<VkImageViewAddressPropertiesNVX> Pointer(this VkImageViewAddressPropertiesNVX i) => new ManagedPtr<VkImageViewAddressPropertiesNVX>(i);
        public static ManagedPtrArray<VkImageViewAddressPropertiesNVX> Pointer(this VkImageViewAddressPropertiesNVX[] i) => new ManagedPtrArray<VkImageViewAddressPropertiesNVX>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkTextureLODGatherFormatPropertiesAMD {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool supportsTextureGatherLODBiasAMD;
		}

        public static ManagedPtr<VkTextureLODGatherFormatPropertiesAMD> Pointer(this VkTextureLODGatherFormatPropertiesAMD i) => new ManagedPtr<VkTextureLODGatherFormatPropertiesAMD>(i);
        public static ManagedPtrArray<VkTextureLODGatherFormatPropertiesAMD> Pointer(this VkTextureLODGatherFormatPropertiesAMD[] i) => new ManagedPtrArray<VkTextureLODGatherFormatPropertiesAMD>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkShaderResourceUsageAMD {
			[FieldOffset(0)]public uint numUsedVgprs;
			[FieldOffset(4)]public uint numUsedSgprs;
			[FieldOffset(8)]public uint ldsSizePerLocalWorkGroup;
			[FieldOffset(16)]public ulong ldsUsageSizeInBytes;
			[FieldOffset(24)]public ulong scratchMemUsageInBytes;
		}

        public static ManagedPtr<VkShaderResourceUsageAMD> Pointer(this VkShaderResourceUsageAMD i) => new ManagedPtr<VkShaderResourceUsageAMD>(i);
        public static ManagedPtrArray<VkShaderResourceUsageAMD> Pointer(this VkShaderResourceUsageAMD[] i) => new ManagedPtrArray<VkShaderResourceUsageAMD>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkShaderStatisticsInfoAMD {
			[FieldOffset(0)]public VkShaderStageFlags shaderStageMask;
			[FieldOffset(8)]public VkShaderResourceUsageAMD resourceUsage;
			[FieldOffset(40)]public uint numPhysicalVgprs;
			[FieldOffset(44)]public uint numPhysicalSgprs;
			[FieldOffset(48)]public uint numAvailableVgprs;
			[FieldOffset(52)]public uint numAvailableSgprs;
			[FieldOffset(56)]public fixed uint computeWorkGroupSize[3];
			public const int computeWorkGroupSize_len = 3;
		}

        public static ManagedPtr<VkShaderStatisticsInfoAMD> Pointer(this VkShaderStatisticsInfoAMD i) => new ManagedPtr<VkShaderStatisticsInfoAMD>(i);
        public static ManagedPtrArray<VkShaderStatisticsInfoAMD> Pointer(this VkShaderStatisticsInfoAMD[] i) => new ManagedPtrArray<VkShaderStatisticsInfoAMD>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceCornerSampledImageFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool cornerSampledImage;
		}

        public static ManagedPtr<VkPhysicalDeviceCornerSampledImageFeaturesNV> Pointer(this VkPhysicalDeviceCornerSampledImageFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceCornerSampledImageFeaturesNV>(i);
        public static ManagedPtrArray<VkPhysicalDeviceCornerSampledImageFeaturesNV> Pointer(this VkPhysicalDeviceCornerSampledImageFeaturesNV[] i) => new ManagedPtrArray<VkPhysicalDeviceCornerSampledImageFeaturesNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExternalImageFormatPropertiesNV {
			[FieldOffset(0)]public VkImageFormatProperties imageFormatProperties;
			[FieldOffset(32)]public VkExternalMemoryFeatureFlagsNV externalMemoryFeatures;
			[FieldOffset(36)]public VkExternalMemoryHandleTypeFlagsNV exportFromImportedHandleTypes;
			[FieldOffset(40)]public VkExternalMemoryHandleTypeFlagsNV compatibleHandleTypes;
		}

        public static ManagedPtr<VkExternalImageFormatPropertiesNV> Pointer(this VkExternalImageFormatPropertiesNV i) => new ManagedPtr<VkExternalImageFormatPropertiesNV>(i);
        public static ManagedPtrArray<VkExternalImageFormatPropertiesNV> Pointer(this VkExternalImageFormatPropertiesNV[] i) => new ManagedPtrArray<VkExternalImageFormatPropertiesNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExternalMemoryImageCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalMemoryHandleTypeFlagsNV handleTypes;
		}

        public static ManagedPtr<VkExternalMemoryImageCreateInfoNV> Pointer(this VkExternalMemoryImageCreateInfoNV i) => new ManagedPtr<VkExternalMemoryImageCreateInfoNV>(i);
        public static ManagedPtrArray<VkExternalMemoryImageCreateInfoNV> Pointer(this VkExternalMemoryImageCreateInfoNV[] i) => new ManagedPtrArray<VkExternalMemoryImageCreateInfoNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkExportMemoryAllocateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalMemoryHandleTypeFlagsNV handleTypes;
		}

        public static ManagedPtr<VkExportMemoryAllocateInfoNV> Pointer(this VkExportMemoryAllocateInfoNV i) => new ManagedPtr<VkExportMemoryAllocateInfoNV>(i);
        public static ManagedPtrArray<VkExportMemoryAllocateInfoNV> Pointer(this VkExportMemoryAllocateInfoNV[] i) => new ManagedPtrArray<VkExportMemoryAllocateInfoNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkValidationFlagsEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint disabledValidationCheckCount;
			[FieldOffset(24)]public VkValidationCheckEXT* pDisabledValidationChecks;
		}

        public static ManagedPtr<VkValidationFlagsEXT> Pointer(this VkValidationFlagsEXT i) => new ManagedPtr<VkValidationFlagsEXT>(i);
        public static ManagedPtrArray<VkValidationFlagsEXT> Pointer(this VkValidationFlagsEXT[] i) => new ManagedPtrArray<VkValidationFlagsEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool textureCompressionASTC_HDR;
		}

        public static ManagedPtr<VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT> Pointer(this VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT> Pointer(this VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageViewASTCDecodeModeEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkFormat decodeMode;
		}

        public static ManagedPtr<VkImageViewASTCDecodeModeEXT> Pointer(this VkImageViewASTCDecodeModeEXT i) => new ManagedPtr<VkImageViewASTCDecodeModeEXT>(i);
        public static ManagedPtrArray<VkImageViewASTCDecodeModeEXT> Pointer(this VkImageViewASTCDecodeModeEXT[] i) => new ManagedPtrArray<VkImageViewASTCDecodeModeEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceASTCDecodeFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool decodeModeSharedExponent;
		}

        public static ManagedPtr<VkPhysicalDeviceASTCDecodeFeaturesEXT> Pointer(this VkPhysicalDeviceASTCDecodeFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceASTCDecodeFeaturesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceASTCDecodeFeaturesEXT> Pointer(this VkPhysicalDeviceASTCDecodeFeaturesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceASTCDecodeFeaturesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkConditionalRenderingBeginInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr buffer;
			[FieldOffset(24)]public ulong offset;
			[FieldOffset(32)]public VkConditionalRenderingFlagsEXT flags;
		}

        public static ManagedPtr<VkConditionalRenderingBeginInfoEXT> Pointer(this VkConditionalRenderingBeginInfoEXT i) => new ManagedPtr<VkConditionalRenderingBeginInfoEXT>(i);
        public static ManagedPtrArray<VkConditionalRenderingBeginInfoEXT> Pointer(this VkConditionalRenderingBeginInfoEXT[] i) => new ManagedPtrArray<VkConditionalRenderingBeginInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceConditionalRenderingFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool conditionalRendering;
			[FieldOffset(20)]public bool inheritedConditionalRendering;
		}

        public static ManagedPtr<VkPhysicalDeviceConditionalRenderingFeaturesEXT> Pointer(this VkPhysicalDeviceConditionalRenderingFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceConditionalRenderingFeaturesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceConditionalRenderingFeaturesEXT> Pointer(this VkPhysicalDeviceConditionalRenderingFeaturesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceConditionalRenderingFeaturesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkCommandBufferInheritanceConditionalRenderingInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool conditionalRenderingEnable;
		}

        public static ManagedPtr<VkCommandBufferInheritanceConditionalRenderingInfoEXT> Pointer(this VkCommandBufferInheritanceConditionalRenderingInfoEXT i) => new ManagedPtr<VkCommandBufferInheritanceConditionalRenderingInfoEXT>(i);
        public static ManagedPtrArray<VkCommandBufferInheritanceConditionalRenderingInfoEXT> Pointer(this VkCommandBufferInheritanceConditionalRenderingInfoEXT[] i) => new ManagedPtrArray<VkCommandBufferInheritanceConditionalRenderingInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkViewportWScalingNV {
			[FieldOffset(0)]public float xcoeff;
			[FieldOffset(4)]public float ycoeff;
		}

        public static ManagedPtr<VkViewportWScalingNV> Pointer(this VkViewportWScalingNV i) => new ManagedPtr<VkViewportWScalingNV>(i);
        public static ManagedPtrArray<VkViewportWScalingNV> Pointer(this VkViewportWScalingNV[] i) => new ManagedPtrArray<VkViewportWScalingNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineViewportWScalingStateCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool viewportWScalingEnable;
			[FieldOffset(20)]public uint viewportCount;
			[FieldOffset(24)]public IntPtr pViewportWScalings;
		}

        public static ManagedPtr<VkPipelineViewportWScalingStateCreateInfoNV> Pointer(this VkPipelineViewportWScalingStateCreateInfoNV i) => new ManagedPtr<VkPipelineViewportWScalingStateCreateInfoNV>(i);
        public static ManagedPtrArray<VkPipelineViewportWScalingStateCreateInfoNV> Pointer(this VkPipelineViewportWScalingStateCreateInfoNV[] i) => new ManagedPtrArray<VkPipelineViewportWScalingStateCreateInfoNV>(i);
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
			[FieldOffset(52)]public VkSurfaceTransformFlagsKHR supportedTransforms;
			[FieldOffset(56)]public VkSurfaceTransformFlagsKHR currentTransform;
			[FieldOffset(60)]public VkCompositeAlphaFlagsKHR supportedCompositeAlpha;
			[FieldOffset(64)]public VkImageUsageFlags supportedUsageFlags;
			[FieldOffset(68)]public VkSurfaceCounterFlagsEXT supportedSurfaceCounters;
		}

        public static ManagedPtr<VkSurfaceCapabilities2EXT> Pointer(this VkSurfaceCapabilities2EXT i) => new ManagedPtr<VkSurfaceCapabilities2EXT>(i);
        public static ManagedPtrArray<VkSurfaceCapabilities2EXT> Pointer(this VkSurfaceCapabilities2EXT[] i) => new ManagedPtrArray<VkSurfaceCapabilities2EXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayPowerInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDisplayPowerStateEXT powerState;
		}

        public static ManagedPtr<VkDisplayPowerInfoEXT> Pointer(this VkDisplayPowerInfoEXT i) => new ManagedPtr<VkDisplayPowerInfoEXT>(i);
        public static ManagedPtrArray<VkDisplayPowerInfoEXT> Pointer(this VkDisplayPowerInfoEXT[] i) => new ManagedPtrArray<VkDisplayPowerInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceEventInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDeviceEventTypeEXT deviceEvent;
		}

        public static ManagedPtr<VkDeviceEventInfoEXT> Pointer(this VkDeviceEventInfoEXT i) => new ManagedPtr<VkDeviceEventInfoEXT>(i);
        public static ManagedPtrArray<VkDeviceEventInfoEXT> Pointer(this VkDeviceEventInfoEXT[] i) => new ManagedPtrArray<VkDeviceEventInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayEventInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDisplayEventTypeEXT displayEvent;
		}

        public static ManagedPtr<VkDisplayEventInfoEXT> Pointer(this VkDisplayEventInfoEXT i) => new ManagedPtr<VkDisplayEventInfoEXT>(i);
        public static ManagedPtrArray<VkDisplayEventInfoEXT> Pointer(this VkDisplayEventInfoEXT[] i) => new ManagedPtrArray<VkDisplayEventInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSwapchainCounterCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkSurfaceCounterFlagsEXT surfaceCounters;
		}

        public static ManagedPtr<VkSwapchainCounterCreateInfoEXT> Pointer(this VkSwapchainCounterCreateInfoEXT i) => new ManagedPtr<VkSwapchainCounterCreateInfoEXT>(i);
        public static ManagedPtrArray<VkSwapchainCounterCreateInfoEXT> Pointer(this VkSwapchainCounterCreateInfoEXT[] i) => new ManagedPtrArray<VkSwapchainCounterCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRefreshCycleDurationGOOGLE {
			[FieldOffset(0)]public ulong refreshDuration;
		}

        public static ManagedPtr<VkRefreshCycleDurationGOOGLE> Pointer(this VkRefreshCycleDurationGOOGLE i) => new ManagedPtr<VkRefreshCycleDurationGOOGLE>(i);
        public static ManagedPtrArray<VkRefreshCycleDurationGOOGLE> Pointer(this VkRefreshCycleDurationGOOGLE[] i) => new ManagedPtrArray<VkRefreshCycleDurationGOOGLE>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPastPresentationTimingGOOGLE {
			[FieldOffset(0)]public uint presentID;
			[FieldOffset(8)]public ulong desiredPresentTime;
			[FieldOffset(16)]public ulong actualPresentTime;
			[FieldOffset(24)]public ulong earliestPresentTime;
			[FieldOffset(32)]public ulong presentMargin;
		}

        public static ManagedPtr<VkPastPresentationTimingGOOGLE> Pointer(this VkPastPresentationTimingGOOGLE i) => new ManagedPtr<VkPastPresentationTimingGOOGLE>(i);
        public static ManagedPtrArray<VkPastPresentationTimingGOOGLE> Pointer(this VkPastPresentationTimingGOOGLE[] i) => new ManagedPtrArray<VkPastPresentationTimingGOOGLE>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPresentTimeGOOGLE {
			[FieldOffset(0)]public uint presentID;
			[FieldOffset(8)]public ulong desiredPresentTime;
		}

        public static ManagedPtr<VkPresentTimeGOOGLE> Pointer(this VkPresentTimeGOOGLE i) => new ManagedPtr<VkPresentTimeGOOGLE>(i);
        public static ManagedPtrArray<VkPresentTimeGOOGLE> Pointer(this VkPresentTimeGOOGLE[] i) => new ManagedPtrArray<VkPresentTimeGOOGLE>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPresentTimesInfoGOOGLE {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint swapchainCount;
			[FieldOffset(24)]public IntPtr pTimes;
		}

        public static ManagedPtr<VkPresentTimesInfoGOOGLE> Pointer(this VkPresentTimesInfoGOOGLE i) => new ManagedPtr<VkPresentTimesInfoGOOGLE>(i);
        public static ManagedPtrArray<VkPresentTimesInfoGOOGLE> Pointer(this VkPresentTimesInfoGOOGLE[] i) => new ManagedPtrArray<VkPresentTimesInfoGOOGLE>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool perViewPositionAllComponents;
		}

        public static ManagedPtr<VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX> Pointer(this VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX i) => new ManagedPtr<VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX>(i);
        public static ManagedPtrArray<VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX> Pointer(this VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX[] i) => new ManagedPtrArray<VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkViewportSwizzleNV {
			[FieldOffset(0)]public VkViewportCoordinateSwizzleNV x;
			[FieldOffset(4)]public VkViewportCoordinateSwizzleNV y;
			[FieldOffset(8)]public VkViewportCoordinateSwizzleNV z;
			[FieldOffset(12)]public VkViewportCoordinateSwizzleNV w;
		}

        public static ManagedPtr<VkViewportSwizzleNV> Pointer(this VkViewportSwizzleNV i) => new ManagedPtr<VkViewportSwizzleNV>(i);
        public static ManagedPtrArray<VkViewportSwizzleNV> Pointer(this VkViewportSwizzleNV[] i) => new ManagedPtrArray<VkViewportSwizzleNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineViewportSwizzleStateCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public uint viewportCount;
			[FieldOffset(24)]public IntPtr pViewportSwizzles;
		}

        public static ManagedPtr<VkPipelineViewportSwizzleStateCreateInfoNV> Pointer(this VkPipelineViewportSwizzleStateCreateInfoNV i) => new ManagedPtr<VkPipelineViewportSwizzleStateCreateInfoNV>(i);
        public static ManagedPtrArray<VkPipelineViewportSwizzleStateCreateInfoNV> Pointer(this VkPipelineViewportSwizzleStateCreateInfoNV[] i) => new ManagedPtrArray<VkPipelineViewportSwizzleStateCreateInfoNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceDiscardRectanglePropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint maxDiscardRectangles;
		}

        public static ManagedPtr<VkPhysicalDeviceDiscardRectanglePropertiesEXT> Pointer(this VkPhysicalDeviceDiscardRectanglePropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceDiscardRectanglePropertiesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceDiscardRectanglePropertiesEXT> Pointer(this VkPhysicalDeviceDiscardRectanglePropertiesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceDiscardRectanglePropertiesEXT>(i);
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
        public static ManagedPtrArray<VkPipelineDiscardRectangleStateCreateInfoEXT> Pointer(this VkPipelineDiscardRectangleStateCreateInfoEXT[] i) => new ManagedPtrArray<VkPipelineDiscardRectangleStateCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public float primitiveOverestimationSize;
			[FieldOffset(20)]public float maxExtraPrimitiveOverestimationSize;
			[FieldOffset(24)]public float extraPrimitiveOverestimationSizeGranularity;
			[FieldOffset(28)]public bool primitiveUnderestimation;
			[FieldOffset(32)]public bool conservativePointAndLineRasterization;
			[FieldOffset(36)]public bool degenerateTrianglesRasterized;
			[FieldOffset(40)]public bool degenerateLinesRasterized;
			[FieldOffset(44)]public bool fullyCoveredFragmentShaderInputVariable;
			[FieldOffset(48)]public bool conservativeRasterizationPostDepthCoverage;
		}

        public static ManagedPtr<VkPhysicalDeviceConservativeRasterizationPropertiesEXT> Pointer(this VkPhysicalDeviceConservativeRasterizationPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceConservativeRasterizationPropertiesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceConservativeRasterizationPropertiesEXT> Pointer(this VkPhysicalDeviceConservativeRasterizationPropertiesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceConservativeRasterizationPropertiesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineRasterizationConservativeStateCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public VkConservativeRasterizationModeEXT conservativeRasterizationMode;
			[FieldOffset(24)]public float extraPrimitiveOverestimationSize;
		}

        public static ManagedPtr<VkPipelineRasterizationConservativeStateCreateInfoEXT> Pointer(this VkPipelineRasterizationConservativeStateCreateInfoEXT i) => new ManagedPtr<VkPipelineRasterizationConservativeStateCreateInfoEXT>(i);
        public static ManagedPtrArray<VkPipelineRasterizationConservativeStateCreateInfoEXT> Pointer(this VkPipelineRasterizationConservativeStateCreateInfoEXT[] i) => new ManagedPtrArray<VkPipelineRasterizationConservativeStateCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceDepthClipEnableFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool depthClipEnable;
		}

        public static ManagedPtr<VkPhysicalDeviceDepthClipEnableFeaturesEXT> Pointer(this VkPhysicalDeviceDepthClipEnableFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceDepthClipEnableFeaturesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceDepthClipEnableFeaturesEXT> Pointer(this VkPhysicalDeviceDepthClipEnableFeaturesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceDepthClipEnableFeaturesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineRasterizationDepthClipStateCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public bool depthClipEnable;
		}

        public static ManagedPtr<VkPipelineRasterizationDepthClipStateCreateInfoEXT> Pointer(this VkPipelineRasterizationDepthClipStateCreateInfoEXT i) => new ManagedPtr<VkPipelineRasterizationDepthClipStateCreateInfoEXT>(i);
        public static ManagedPtrArray<VkPipelineRasterizationDepthClipStateCreateInfoEXT> Pointer(this VkPipelineRasterizationDepthClipStateCreateInfoEXT[] i) => new ManagedPtrArray<VkPipelineRasterizationDepthClipStateCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkXYColorEXT {
			[FieldOffset(0)]public float x;
			[FieldOffset(4)]public float y;
		}

        public static ManagedPtr<VkXYColorEXT> Pointer(this VkXYColorEXT i) => new ManagedPtr<VkXYColorEXT>(i);
        public static ManagedPtrArray<VkXYColorEXT> Pointer(this VkXYColorEXT[] i) => new ManagedPtrArray<VkXYColorEXT>(i);
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
        public static ManagedPtrArray<VkHdrMetadataEXT> Pointer(this VkHdrMetadataEXT[] i) => new ManagedPtrArray<VkHdrMetadataEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDebugUtilsLabelEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public string pLabelName;
			[FieldOffset(24)]public fixed float color[4];
			public const int color_len = 4;
		}

        public static ManagedPtr<VkDebugUtilsLabelEXT> Pointer(this VkDebugUtilsLabelEXT i) => new ManagedPtr<VkDebugUtilsLabelEXT>(i);
        public static ManagedPtrArray<VkDebugUtilsLabelEXT> Pointer(this VkDebugUtilsLabelEXT[] i) => new ManagedPtrArray<VkDebugUtilsLabelEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDebugUtilsObjectNameInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkObjectType objectType;
			[FieldOffset(24)]public ulong objectHandle;
			[FieldOffset(32)]public string pObjectName;
		}

        public static ManagedPtr<VkDebugUtilsObjectNameInfoEXT> Pointer(this VkDebugUtilsObjectNameInfoEXT i) => new ManagedPtr<VkDebugUtilsObjectNameInfoEXT>(i);
        public static ManagedPtrArray<VkDebugUtilsObjectNameInfoEXT> Pointer(this VkDebugUtilsObjectNameInfoEXT[] i) => new ManagedPtrArray<VkDebugUtilsObjectNameInfoEXT>(i);
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
        public static ManagedPtrArray<VkDebugUtilsMessengerCallbackDataEXT> Pointer(this VkDebugUtilsMessengerCallbackDataEXT[] i) => new ManagedPtrArray<VkDebugUtilsMessengerCallbackDataEXT>(i);
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
        public static ManagedPtrArray<VkDebugUtilsObjectTagInfoEXT> Pointer(this VkDebugUtilsObjectTagInfoEXT[] i) => new ManagedPtrArray<VkDebugUtilsObjectTagInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDebugUtilsMessengerCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public VkDebugUtilsMessageSeverityFlagsEXT messageSeverity;
			[FieldOffset(24)]public VkDebugUtilsMessageTypeFlagsEXT messageType;
			[FieldOffset(32)][MarshalAs(UnmanagedType.FunctionPtr)]public PFN_vkDebugUtilsMessengerCallbackEXT pfnUserCallback;
			[FieldOffset(40)]public IntPtr pUserData;
		}

        public static ManagedPtr<VkDebugUtilsMessengerCreateInfoEXT> Pointer(this VkDebugUtilsMessengerCreateInfoEXT i) => new ManagedPtr<VkDebugUtilsMessengerCreateInfoEXT>(i);
        public static ManagedPtrArray<VkDebugUtilsMessengerCreateInfoEXT> Pointer(this VkDebugUtilsMessengerCreateInfoEXT[] i) => new ManagedPtrArray<VkDebugUtilsMessengerCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceInlineUniformBlockFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool inlineUniformBlock;
			[FieldOffset(20)]public bool descriptorBindingInlineUniformBlockUpdateAfterBind;
		}

        public static ManagedPtr<VkPhysicalDeviceInlineUniformBlockFeaturesEXT> Pointer(this VkPhysicalDeviceInlineUniformBlockFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceInlineUniformBlockFeaturesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceInlineUniformBlockFeaturesEXT> Pointer(this VkPhysicalDeviceInlineUniformBlockFeaturesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceInlineUniformBlockFeaturesEXT>(i);
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
        public static ManagedPtrArray<VkPhysicalDeviceInlineUniformBlockPropertiesEXT> Pointer(this VkPhysicalDeviceInlineUniformBlockPropertiesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceInlineUniformBlockPropertiesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkWriteDescriptorSetInlineUniformBlockEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint dataSize;
			[FieldOffset(24)]public IntPtr pData;
		}

        public static ManagedPtr<VkWriteDescriptorSetInlineUniformBlockEXT> Pointer(this VkWriteDescriptorSetInlineUniformBlockEXT i) => new ManagedPtr<VkWriteDescriptorSetInlineUniformBlockEXT>(i);
        public static ManagedPtrArray<VkWriteDescriptorSetInlineUniformBlockEXT> Pointer(this VkWriteDescriptorSetInlineUniformBlockEXT[] i) => new ManagedPtrArray<VkWriteDescriptorSetInlineUniformBlockEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDescriptorPoolInlineUniformBlockCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint maxInlineUniformBlockBindings;
		}

        public static ManagedPtr<VkDescriptorPoolInlineUniformBlockCreateInfoEXT> Pointer(this VkDescriptorPoolInlineUniformBlockCreateInfoEXT i) => new ManagedPtr<VkDescriptorPoolInlineUniformBlockCreateInfoEXT>(i);
        public static ManagedPtrArray<VkDescriptorPoolInlineUniformBlockCreateInfoEXT> Pointer(this VkDescriptorPoolInlineUniformBlockCreateInfoEXT[] i) => new ManagedPtrArray<VkDescriptorPoolInlineUniformBlockCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSampleLocationEXT {
			[FieldOffset(0)]public float x;
			[FieldOffset(4)]public float y;
		}

        public static ManagedPtr<VkSampleLocationEXT> Pointer(this VkSampleLocationEXT i) => new ManagedPtr<VkSampleLocationEXT>(i);
        public static ManagedPtrArray<VkSampleLocationEXT> Pointer(this VkSampleLocationEXT[] i) => new ManagedPtrArray<VkSampleLocationEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSampleLocationsInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkSampleCountFlags sampleLocationsPerPixel;
			[FieldOffset(20)]public VkExtent2D sampleLocationGridSize;
			[FieldOffset(28)]public uint sampleLocationsCount;
			[FieldOffset(32)]public IntPtr pSampleLocations;
		}

        public static ManagedPtr<VkSampleLocationsInfoEXT> Pointer(this VkSampleLocationsInfoEXT i) => new ManagedPtr<VkSampleLocationsInfoEXT>(i);
        public static ManagedPtrArray<VkSampleLocationsInfoEXT> Pointer(this VkSampleLocationsInfoEXT[] i) => new ManagedPtrArray<VkSampleLocationsInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAttachmentSampleLocationsEXT {
			[FieldOffset(0)]public uint attachmentIndex;
			[FieldOffset(8)]public VkSampleLocationsInfoEXT sampleLocationsInfo;
		}

        public static ManagedPtr<VkAttachmentSampleLocationsEXT> Pointer(this VkAttachmentSampleLocationsEXT i) => new ManagedPtr<VkAttachmentSampleLocationsEXT>(i);
        public static ManagedPtrArray<VkAttachmentSampleLocationsEXT> Pointer(this VkAttachmentSampleLocationsEXT[] i) => new ManagedPtrArray<VkAttachmentSampleLocationsEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSubpassSampleLocationsEXT {
			[FieldOffset(0)]public uint subpassIndex;
			[FieldOffset(8)]public VkSampleLocationsInfoEXT sampleLocationsInfo;
		}

        public static ManagedPtr<VkSubpassSampleLocationsEXT> Pointer(this VkSubpassSampleLocationsEXT i) => new ManagedPtr<VkSubpassSampleLocationsEXT>(i);
        public static ManagedPtrArray<VkSubpassSampleLocationsEXT> Pointer(this VkSubpassSampleLocationsEXT[] i) => new ManagedPtrArray<VkSubpassSampleLocationsEXT>(i);
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
        public static ManagedPtrArray<VkRenderPassSampleLocationsBeginInfoEXT> Pointer(this VkRenderPassSampleLocationsBeginInfoEXT[] i) => new ManagedPtrArray<VkRenderPassSampleLocationsBeginInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineSampleLocationsStateCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool sampleLocationsEnable;
			[FieldOffset(24)]public VkSampleLocationsInfoEXT sampleLocationsInfo;
		}

        public static ManagedPtr<VkPipelineSampleLocationsStateCreateInfoEXT> Pointer(this VkPipelineSampleLocationsStateCreateInfoEXT i) => new ManagedPtr<VkPipelineSampleLocationsStateCreateInfoEXT>(i);
        public static ManagedPtrArray<VkPipelineSampleLocationsStateCreateInfoEXT> Pointer(this VkPipelineSampleLocationsStateCreateInfoEXT[] i) => new ManagedPtrArray<VkPipelineSampleLocationsStateCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceSampleLocationsPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkSampleCountFlags sampleLocationSampleCounts;
			[FieldOffset(20)]public VkExtent2D maxSampleLocationGridSize;
			[FieldOffset(28)]public fixed float sampleLocationCoordinateRange[2];
			public const int sampleLocationCoordinateRange_len = 2;
			[FieldOffset(36)]public uint sampleLocationSubPixelBits;
			[FieldOffset(40)]public bool variableSampleLocations;
		}

        public static ManagedPtr<VkPhysicalDeviceSampleLocationsPropertiesEXT> Pointer(this VkPhysicalDeviceSampleLocationsPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceSampleLocationsPropertiesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceSampleLocationsPropertiesEXT> Pointer(this VkPhysicalDeviceSampleLocationsPropertiesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceSampleLocationsPropertiesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMultisamplePropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExtent2D maxSampleLocationGridSize;
		}

        public static ManagedPtr<VkMultisamplePropertiesEXT> Pointer(this VkMultisamplePropertiesEXT i) => new ManagedPtr<VkMultisamplePropertiesEXT>(i);
        public static ManagedPtrArray<VkMultisamplePropertiesEXT> Pointer(this VkMultisamplePropertiesEXT[] i) => new ManagedPtrArray<VkMultisamplePropertiesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool advancedBlendCoherentOperations;
		}

        public static ManagedPtr<VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT> Pointer(this VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT> Pointer(this VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint advancedBlendMaxColorAttachments;
			[FieldOffset(20)]public bool advancedBlendIndependentBlend;
			[FieldOffset(24)]public bool advancedBlendNonPremultipliedSrcColor;
			[FieldOffset(28)]public bool advancedBlendNonPremultipliedDstColor;
			[FieldOffset(32)]public bool advancedBlendCorrelatedOverlap;
			[FieldOffset(36)]public bool advancedBlendAllOperations;
		}

        public static ManagedPtr<VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT> Pointer(this VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT> Pointer(this VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineColorBlendAdvancedStateCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool srcPremultiplied;
			[FieldOffset(20)]public bool dstPremultiplied;
			[FieldOffset(24)]public VkBlendOverlapEXT blendOverlap;
		}

        public static ManagedPtr<VkPipelineColorBlendAdvancedStateCreateInfoEXT> Pointer(this VkPipelineColorBlendAdvancedStateCreateInfoEXT i) => new ManagedPtr<VkPipelineColorBlendAdvancedStateCreateInfoEXT>(i);
        public static ManagedPtrArray<VkPipelineColorBlendAdvancedStateCreateInfoEXT> Pointer(this VkPipelineColorBlendAdvancedStateCreateInfoEXT[] i) => new ManagedPtrArray<VkPipelineColorBlendAdvancedStateCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineCoverageToColorStateCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public bool coverageToColorEnable;
			[FieldOffset(24)]public uint coverageToColorLocation;
		}

        public static ManagedPtr<VkPipelineCoverageToColorStateCreateInfoNV> Pointer(this VkPipelineCoverageToColorStateCreateInfoNV i) => new ManagedPtr<VkPipelineCoverageToColorStateCreateInfoNV>(i);
        public static ManagedPtrArray<VkPipelineCoverageToColorStateCreateInfoNV> Pointer(this VkPipelineCoverageToColorStateCreateInfoNV[] i) => new ManagedPtrArray<VkPipelineCoverageToColorStateCreateInfoNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineCoverageModulationStateCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public VkCoverageModulationModeNV coverageModulationMode;
			[FieldOffset(24)]public bool coverageModulationTableEnable;
			[FieldOffset(28)]public uint coverageModulationTableCount;
			[FieldOffset(32)]public float* pCoverageModulationTable;
		}

        public static ManagedPtr<VkPipelineCoverageModulationStateCreateInfoNV> Pointer(this VkPipelineCoverageModulationStateCreateInfoNV i) => new ManagedPtr<VkPipelineCoverageModulationStateCreateInfoNV>(i);
        public static ManagedPtrArray<VkPipelineCoverageModulationStateCreateInfoNV> Pointer(this VkPipelineCoverageModulationStateCreateInfoNV[] i) => new ManagedPtrArray<VkPipelineCoverageModulationStateCreateInfoNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShaderSMBuiltinsPropertiesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint shaderSMCount;
			[FieldOffset(20)]public uint shaderWarpsPerSM;
		}

        public static ManagedPtr<VkPhysicalDeviceShaderSMBuiltinsPropertiesNV> Pointer(this VkPhysicalDeviceShaderSMBuiltinsPropertiesNV i) => new ManagedPtr<VkPhysicalDeviceShaderSMBuiltinsPropertiesNV>(i);
        public static ManagedPtrArray<VkPhysicalDeviceShaderSMBuiltinsPropertiesNV> Pointer(this VkPhysicalDeviceShaderSMBuiltinsPropertiesNV[] i) => new ManagedPtrArray<VkPhysicalDeviceShaderSMBuiltinsPropertiesNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShaderSMBuiltinsFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool shaderSMBuiltins;
		}

        public static ManagedPtr<VkPhysicalDeviceShaderSMBuiltinsFeaturesNV> Pointer(this VkPhysicalDeviceShaderSMBuiltinsFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceShaderSMBuiltinsFeaturesNV>(i);
        public static ManagedPtrArray<VkPhysicalDeviceShaderSMBuiltinsFeaturesNV> Pointer(this VkPhysicalDeviceShaderSMBuiltinsFeaturesNV[] i) => new ManagedPtrArray<VkPhysicalDeviceShaderSMBuiltinsFeaturesNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDrmFormatModifierPropertiesEXT {
			[FieldOffset(0)]public ulong drmFormatModifier;
			[FieldOffset(8)]public uint drmFormatModifierPlaneCount;
			[FieldOffset(12)]public VkFormatFeatureFlags drmFormatModifierTilingFeatures;
		}

        public static ManagedPtr<VkDrmFormatModifierPropertiesEXT> Pointer(this VkDrmFormatModifierPropertiesEXT i) => new ManagedPtr<VkDrmFormatModifierPropertiesEXT>(i);
        public static ManagedPtrArray<VkDrmFormatModifierPropertiesEXT> Pointer(this VkDrmFormatModifierPropertiesEXT[] i) => new ManagedPtrArray<VkDrmFormatModifierPropertiesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDrmFormatModifierPropertiesListEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint drmFormatModifierCount;
			[FieldOffset(24)]public IntPtr pDrmFormatModifierProperties;
		}

        public static ManagedPtr<VkDrmFormatModifierPropertiesListEXT> Pointer(this VkDrmFormatModifierPropertiesListEXT i) => new ManagedPtr<VkDrmFormatModifierPropertiesListEXT>(i);
        public static ManagedPtrArray<VkDrmFormatModifierPropertiesListEXT> Pointer(this VkDrmFormatModifierPropertiesListEXT[] i) => new ManagedPtrArray<VkDrmFormatModifierPropertiesListEXT>(i);
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
        public static ManagedPtrArray<VkPhysicalDeviceImageDrmFormatModifierInfoEXT> Pointer(this VkPhysicalDeviceImageDrmFormatModifierInfoEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceImageDrmFormatModifierInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageDrmFormatModifierListCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint drmFormatModifierCount;
			[FieldOffset(24)]public ulong* pDrmFormatModifiers;
		}

        public static ManagedPtr<VkImageDrmFormatModifierListCreateInfoEXT> Pointer(this VkImageDrmFormatModifierListCreateInfoEXT i) => new ManagedPtr<VkImageDrmFormatModifierListCreateInfoEXT>(i);
        public static ManagedPtrArray<VkImageDrmFormatModifierListCreateInfoEXT> Pointer(this VkImageDrmFormatModifierListCreateInfoEXT[] i) => new ManagedPtrArray<VkImageDrmFormatModifierListCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageDrmFormatModifierExplicitCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong drmFormatModifier;
			[FieldOffset(24)]public uint drmFormatModifierPlaneCount;
			[FieldOffset(32)]public IntPtr pPlaneLayouts;
		}

        public static ManagedPtr<VkImageDrmFormatModifierExplicitCreateInfoEXT> Pointer(this VkImageDrmFormatModifierExplicitCreateInfoEXT i) => new ManagedPtr<VkImageDrmFormatModifierExplicitCreateInfoEXT>(i);
        public static ManagedPtrArray<VkImageDrmFormatModifierExplicitCreateInfoEXT> Pointer(this VkImageDrmFormatModifierExplicitCreateInfoEXT[] i) => new ManagedPtrArray<VkImageDrmFormatModifierExplicitCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImageDrmFormatModifierPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong drmFormatModifier;
		}

        public static ManagedPtr<VkImageDrmFormatModifierPropertiesEXT> Pointer(this VkImageDrmFormatModifierPropertiesEXT i) => new ManagedPtr<VkImageDrmFormatModifierPropertiesEXT>(i);
        public static ManagedPtrArray<VkImageDrmFormatModifierPropertiesEXT> Pointer(this VkImageDrmFormatModifierPropertiesEXT[] i) => new ManagedPtrArray<VkImageDrmFormatModifierPropertiesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkValidationCacheCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(24)]public ulong initialDataSize;
			[FieldOffset(32)]public IntPtr pInitialData;
		}

        public static ManagedPtr<VkValidationCacheCreateInfoEXT> Pointer(this VkValidationCacheCreateInfoEXT i) => new ManagedPtr<VkValidationCacheCreateInfoEXT>(i);
        public static ManagedPtrArray<VkValidationCacheCreateInfoEXT> Pointer(this VkValidationCacheCreateInfoEXT[] i) => new ManagedPtrArray<VkValidationCacheCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkShaderModuleValidationCacheCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr validationCache;
		}

        public static ManagedPtr<VkShaderModuleValidationCacheCreateInfoEXT> Pointer(this VkShaderModuleValidationCacheCreateInfoEXT i) => new ManagedPtr<VkShaderModuleValidationCacheCreateInfoEXT>(i);
        public static ManagedPtrArray<VkShaderModuleValidationCacheCreateInfoEXT> Pointer(this VkShaderModuleValidationCacheCreateInfoEXT[] i) => new ManagedPtrArray<VkShaderModuleValidationCacheCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkShadingRatePaletteNV {
			[FieldOffset(0)]public uint shadingRatePaletteEntryCount;
			[FieldOffset(8)]public VkShadingRatePaletteEntryNV* pShadingRatePaletteEntries;
		}

        public static ManagedPtr<VkShadingRatePaletteNV> Pointer(this VkShadingRatePaletteNV i) => new ManagedPtr<VkShadingRatePaletteNV>(i);
        public static ManagedPtrArray<VkShadingRatePaletteNV> Pointer(this VkShadingRatePaletteNV[] i) => new ManagedPtrArray<VkShadingRatePaletteNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineViewportShadingRateImageStateCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool shadingRateImageEnable;
			[FieldOffset(20)]public uint viewportCount;
			[FieldOffset(24)]public IntPtr pShadingRatePalettes;
		}

        public static ManagedPtr<VkPipelineViewportShadingRateImageStateCreateInfoNV> Pointer(this VkPipelineViewportShadingRateImageStateCreateInfoNV i) => new ManagedPtr<VkPipelineViewportShadingRateImageStateCreateInfoNV>(i);
        public static ManagedPtrArray<VkPipelineViewportShadingRateImageStateCreateInfoNV> Pointer(this VkPipelineViewportShadingRateImageStateCreateInfoNV[] i) => new ManagedPtrArray<VkPipelineViewportShadingRateImageStateCreateInfoNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShadingRateImageFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool shadingRateImage;
			[FieldOffset(20)]public bool shadingRateCoarseSampleOrder;
		}

        public static ManagedPtr<VkPhysicalDeviceShadingRateImageFeaturesNV> Pointer(this VkPhysicalDeviceShadingRateImageFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceShadingRateImageFeaturesNV>(i);
        public static ManagedPtrArray<VkPhysicalDeviceShadingRateImageFeaturesNV> Pointer(this VkPhysicalDeviceShadingRateImageFeaturesNV[] i) => new ManagedPtrArray<VkPhysicalDeviceShadingRateImageFeaturesNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShadingRateImagePropertiesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExtent2D shadingRateTexelSize;
			[FieldOffset(24)]public uint shadingRatePaletteSize;
			[FieldOffset(28)]public uint shadingRateMaxCoarseSamples;
		}

        public static ManagedPtr<VkPhysicalDeviceShadingRateImagePropertiesNV> Pointer(this VkPhysicalDeviceShadingRateImagePropertiesNV i) => new ManagedPtr<VkPhysicalDeviceShadingRateImagePropertiesNV>(i);
        public static ManagedPtrArray<VkPhysicalDeviceShadingRateImagePropertiesNV> Pointer(this VkPhysicalDeviceShadingRateImagePropertiesNV[] i) => new ManagedPtrArray<VkPhysicalDeviceShadingRateImagePropertiesNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkCoarseSampleLocationNV {
			[FieldOffset(0)]public uint pixelX;
			[FieldOffset(4)]public uint pixelY;
			[FieldOffset(8)]public uint sample;
		}

        public static ManagedPtr<VkCoarseSampleLocationNV> Pointer(this VkCoarseSampleLocationNV i) => new ManagedPtr<VkCoarseSampleLocationNV>(i);
        public static ManagedPtrArray<VkCoarseSampleLocationNV> Pointer(this VkCoarseSampleLocationNV[] i) => new ManagedPtrArray<VkCoarseSampleLocationNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkCoarseSampleOrderCustomNV {
			[FieldOffset(0)]public VkShadingRatePaletteEntryNV shadingRate;
			[FieldOffset(4)]public uint sampleCount;
			[FieldOffset(8)]public uint sampleLocationCount;
			[FieldOffset(16)]public IntPtr pSampleLocations;
		}

        public static ManagedPtr<VkCoarseSampleOrderCustomNV> Pointer(this VkCoarseSampleOrderCustomNV i) => new ManagedPtr<VkCoarseSampleOrderCustomNV>(i);
        public static ManagedPtrArray<VkCoarseSampleOrderCustomNV> Pointer(this VkCoarseSampleOrderCustomNV[] i) => new ManagedPtrArray<VkCoarseSampleOrderCustomNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkCoarseSampleOrderTypeNV sampleOrderType;
			[FieldOffset(20)]public uint customSampleOrderCount;
			[FieldOffset(24)]public IntPtr pCustomSampleOrders;
		}

        public static ManagedPtr<VkPipelineViewportCoarseSampleOrderStateCreateInfoNV> Pointer(this VkPipelineViewportCoarseSampleOrderStateCreateInfoNV i) => new ManagedPtr<VkPipelineViewportCoarseSampleOrderStateCreateInfoNV>(i);
        public static ManagedPtrArray<VkPipelineViewportCoarseSampleOrderStateCreateInfoNV> Pointer(this VkPipelineViewportCoarseSampleOrderStateCreateInfoNV[] i) => new ManagedPtrArray<VkPipelineViewportCoarseSampleOrderStateCreateInfoNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRayTracingShaderGroupCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkRayTracingShaderGroupTypeKHR type;
			[FieldOffset(20)]public uint generalShader;
			[FieldOffset(24)]public uint closestHitShader;
			[FieldOffset(28)]public uint anyHitShader;
			[FieldOffset(32)]public uint intersectionShader;
		}

        public static ManagedPtr<VkRayTracingShaderGroupCreateInfoNV> Pointer(this VkRayTracingShaderGroupCreateInfoNV i) => new ManagedPtr<VkRayTracingShaderGroupCreateInfoNV>(i);
        public static ManagedPtrArray<VkRayTracingShaderGroupCreateInfoNV> Pointer(this VkRayTracingShaderGroupCreateInfoNV[] i) => new ManagedPtrArray<VkRayTracingShaderGroupCreateInfoNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRayTracingPipelineCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPipelineCreateFlags flags;
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
        public static ManagedPtrArray<VkRayTracingPipelineCreateInfoNV> Pointer(this VkRayTracingPipelineCreateInfoNV[] i) => new ManagedPtrArray<VkRayTracingPipelineCreateInfoNV>(i);
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
        public static ManagedPtrArray<VkGeometryTrianglesNV> Pointer(this VkGeometryTrianglesNV[] i) => new ManagedPtrArray<VkGeometryTrianglesNV>(i);
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
        public static ManagedPtrArray<VkGeometryAABBNV> Pointer(this VkGeometryAABBNV[] i) => new ManagedPtrArray<VkGeometryAABBNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkGeometryDataNV {
			[FieldOffset(0)]public VkGeometryTrianglesNV triangles;
			[FieldOffset(96)]public VkGeometryAABBNV aabbs;
		}

        public static ManagedPtr<VkGeometryDataNV> Pointer(this VkGeometryDataNV i) => new ManagedPtr<VkGeometryDataNV>(i);
        public static ManagedPtrArray<VkGeometryDataNV> Pointer(this VkGeometryDataNV[] i) => new ManagedPtrArray<VkGeometryDataNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkGeometryNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkGeometryTypeKHR geometryType;
			[FieldOffset(24)]public VkGeometryDataNV geometry;
			[FieldOffset(160)]public VkGeometryFlagsKHR flags;
		}

        public static ManagedPtr<VkGeometryNV> Pointer(this VkGeometryNV i) => new ManagedPtr<VkGeometryNV>(i);
        public static ManagedPtrArray<VkGeometryNV> Pointer(this VkGeometryNV[] i) => new ManagedPtrArray<VkGeometryNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAccelerationStructureInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkAccelerationStructureTypeKHR type;
			[FieldOffset(20)]public uint flags;
			[FieldOffset(24)]public uint instanceCount;
			[FieldOffset(28)]public uint geometryCount;
			[FieldOffset(32)]public IntPtr pGeometries;
		}

        public static ManagedPtr<VkAccelerationStructureInfoNV> Pointer(this VkAccelerationStructureInfoNV i) => new ManagedPtr<VkAccelerationStructureInfoNV>(i);
        public static ManagedPtrArray<VkAccelerationStructureInfoNV> Pointer(this VkAccelerationStructureInfoNV[] i) => new ManagedPtrArray<VkAccelerationStructureInfoNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAccelerationStructureCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong compactedSize;
			[FieldOffset(24)]public VkAccelerationStructureInfoNV info;
		}

        public static ManagedPtr<VkAccelerationStructureCreateInfoNV> Pointer(this VkAccelerationStructureCreateInfoNV i) => new ManagedPtr<VkAccelerationStructureCreateInfoNV>(i);
        public static ManagedPtrArray<VkAccelerationStructureCreateInfoNV> Pointer(this VkAccelerationStructureCreateInfoNV[] i) => new ManagedPtrArray<VkAccelerationStructureCreateInfoNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBindAccelerationStructureMemoryInfoKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr accelerationStructure;
			[FieldOffset(24)]public IntPtr memory;
			[FieldOffset(32)]public ulong memoryOffset;
			[FieldOffset(40)]public uint deviceIndexCount;
			[FieldOffset(48)]public uint* pDeviceIndices;
		}

        public static ManagedPtr<VkBindAccelerationStructureMemoryInfoKHR> Pointer(this VkBindAccelerationStructureMemoryInfoKHR i) => new ManagedPtr<VkBindAccelerationStructureMemoryInfoKHR>(i);
        public static ManagedPtrArray<VkBindAccelerationStructureMemoryInfoKHR> Pointer(this VkBindAccelerationStructureMemoryInfoKHR[] i) => new ManagedPtrArray<VkBindAccelerationStructureMemoryInfoKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkWriteDescriptorSetAccelerationStructureKHR {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint accelerationStructureCount;
			[FieldOffset(24)]public IntPtr* pAccelerationStructures;
		}

        public static ManagedPtr<VkWriteDescriptorSetAccelerationStructureKHR> Pointer(this VkWriteDescriptorSetAccelerationStructureKHR i) => new ManagedPtr<VkWriteDescriptorSetAccelerationStructureKHR>(i);
        public static ManagedPtrArray<VkWriteDescriptorSetAccelerationStructureKHR> Pointer(this VkWriteDescriptorSetAccelerationStructureKHR[] i) => new ManagedPtrArray<VkWriteDescriptorSetAccelerationStructureKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAccelerationStructureMemoryRequirementsInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkAccelerationStructureMemoryRequirementsTypeKHR type;
			[FieldOffset(24)]public IntPtr accelerationStructure;
		}

        public static ManagedPtr<VkAccelerationStructureMemoryRequirementsInfoNV> Pointer(this VkAccelerationStructureMemoryRequirementsInfoNV i) => new ManagedPtr<VkAccelerationStructureMemoryRequirementsInfoNV>(i);
        public static ManagedPtrArray<VkAccelerationStructureMemoryRequirementsInfoNV> Pointer(this VkAccelerationStructureMemoryRequirementsInfoNV[] i) => new ManagedPtrArray<VkAccelerationStructureMemoryRequirementsInfoNV>(i);
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
        public static ManagedPtrArray<VkPhysicalDeviceRayTracingPropertiesNV> Pointer(this VkPhysicalDeviceRayTracingPropertiesNV[] i) => new ManagedPtrArray<VkPhysicalDeviceRayTracingPropertiesNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkTransformMatrixKHR {
			[FieldOffset(0)]public fixed float matrix[3];
			public const int matrix_len = 3;
		}

        public static ManagedPtr<VkTransformMatrixKHR> Pointer(this VkTransformMatrixKHR i) => new ManagedPtr<VkTransformMatrixKHR>(i);
        public static ManagedPtrArray<VkTransformMatrixKHR> Pointer(this VkTransformMatrixKHR[] i) => new ManagedPtrArray<VkTransformMatrixKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAabbPositionsKHR {
			[FieldOffset(0)]public float minX;
			[FieldOffset(4)]public float minY;
			[FieldOffset(8)]public float minZ;
			[FieldOffset(12)]public float maxX;
			[FieldOffset(16)]public float maxY;
			[FieldOffset(20)]public float maxZ;
		}

        public static ManagedPtr<VkAabbPositionsKHR> Pointer(this VkAabbPositionsKHR i) => new ManagedPtr<VkAabbPositionsKHR>(i);
        public static ManagedPtrArray<VkAabbPositionsKHR> Pointer(this VkAabbPositionsKHR[] i) => new ManagedPtrArray<VkAabbPositionsKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkAccelerationStructureInstanceKHR {
			[FieldOffset(0)]public VkTransformMatrixKHR transform;
			[FieldOffset(12)]public uint instanceCustomIndex;
			[FieldOffset(16)]public uint mask;
			[FieldOffset(20)]public uint instanceShaderBindingTableRecordOffset;
			[FieldOffset(24)]public VkGeometryInstanceFlagsKHR flags;
			[FieldOffset(32)]public ulong accelerationStructureReference;
		}

        public static ManagedPtr<VkAccelerationStructureInstanceKHR> Pointer(this VkAccelerationStructureInstanceKHR i) => new ManagedPtr<VkAccelerationStructureInstanceKHR>(i);
        public static ManagedPtrArray<VkAccelerationStructureInstanceKHR> Pointer(this VkAccelerationStructureInstanceKHR[] i) => new ManagedPtrArray<VkAccelerationStructureInstanceKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool representativeFragmentTest;
		}

        public static ManagedPtr<VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV> Pointer(this VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV>(i);
        public static ManagedPtrArray<VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV> Pointer(this VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV[] i) => new ManagedPtrArray<VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool representativeFragmentTestEnable;
		}

        public static ManagedPtr<VkPipelineRepresentativeFragmentTestStateCreateInfoNV> Pointer(this VkPipelineRepresentativeFragmentTestStateCreateInfoNV i) => new ManagedPtr<VkPipelineRepresentativeFragmentTestStateCreateInfoNV>(i);
        public static ManagedPtrArray<VkPipelineRepresentativeFragmentTestStateCreateInfoNV> Pointer(this VkPipelineRepresentativeFragmentTestStateCreateInfoNV[] i) => new ManagedPtrArray<VkPipelineRepresentativeFragmentTestStateCreateInfoNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceImageViewImageFormatInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkImageViewType imageViewType;
		}

        public static ManagedPtr<VkPhysicalDeviceImageViewImageFormatInfoEXT> Pointer(this VkPhysicalDeviceImageViewImageFormatInfoEXT i) => new ManagedPtr<VkPhysicalDeviceImageViewImageFormatInfoEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceImageViewImageFormatInfoEXT> Pointer(this VkPhysicalDeviceImageViewImageFormatInfoEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceImageViewImageFormatInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkFilterCubicImageViewImageFormatPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool filterCubic;
			[FieldOffset(20)]public bool filterCubicMinmax;
		}

        public static ManagedPtr<VkFilterCubicImageViewImageFormatPropertiesEXT> Pointer(this VkFilterCubicImageViewImageFormatPropertiesEXT i) => new ManagedPtr<VkFilterCubicImageViewImageFormatPropertiesEXT>(i);
        public static ManagedPtrArray<VkFilterCubicImageViewImageFormatPropertiesEXT> Pointer(this VkFilterCubicImageViewImageFormatPropertiesEXT[] i) => new ManagedPtrArray<VkFilterCubicImageViewImageFormatPropertiesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceQueueGlobalPriorityCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkQueueGlobalPriorityEXT globalPriority;
		}

        public static ManagedPtr<VkDeviceQueueGlobalPriorityCreateInfoEXT> Pointer(this VkDeviceQueueGlobalPriorityCreateInfoEXT i) => new ManagedPtr<VkDeviceQueueGlobalPriorityCreateInfoEXT>(i);
        public static ManagedPtrArray<VkDeviceQueueGlobalPriorityCreateInfoEXT> Pointer(this VkDeviceQueueGlobalPriorityCreateInfoEXT[] i) => new ManagedPtrArray<VkDeviceQueueGlobalPriorityCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkImportMemoryHostPointerInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExternalMemoryHandleTypeFlags handleType;
			[FieldOffset(24)]public IntPtr pHostPointer;
		}

        public static ManagedPtr<VkImportMemoryHostPointerInfoEXT> Pointer(this VkImportMemoryHostPointerInfoEXT i) => new ManagedPtr<VkImportMemoryHostPointerInfoEXT>(i);
        public static ManagedPtrArray<VkImportMemoryHostPointerInfoEXT> Pointer(this VkImportMemoryHostPointerInfoEXT[] i) => new ManagedPtrArray<VkImportMemoryHostPointerInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryHostPointerPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint memoryTypeBits;
		}

        public static ManagedPtr<VkMemoryHostPointerPropertiesEXT> Pointer(this VkMemoryHostPointerPropertiesEXT i) => new ManagedPtr<VkMemoryHostPointerPropertiesEXT>(i);
        public static ManagedPtrArray<VkMemoryHostPointerPropertiesEXT> Pointer(this VkMemoryHostPointerPropertiesEXT[] i) => new ManagedPtrArray<VkMemoryHostPointerPropertiesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong minImportedHostPointerAlignment;
		}

        public static ManagedPtr<VkPhysicalDeviceExternalMemoryHostPropertiesEXT> Pointer(this VkPhysicalDeviceExternalMemoryHostPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceExternalMemoryHostPropertiesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceExternalMemoryHostPropertiesEXT> Pointer(this VkPhysicalDeviceExternalMemoryHostPropertiesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceExternalMemoryHostPropertiesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineCompilerControlCreateInfoAMD {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPipelineCompilerControlFlagsAMD compilerControlFlags;
		}

        public static ManagedPtr<VkPipelineCompilerControlCreateInfoAMD> Pointer(this VkPipelineCompilerControlCreateInfoAMD i) => new ManagedPtr<VkPipelineCompilerControlCreateInfoAMD>(i);
        public static ManagedPtrArray<VkPipelineCompilerControlCreateInfoAMD> Pointer(this VkPipelineCompilerControlCreateInfoAMD[] i) => new ManagedPtrArray<VkPipelineCompilerControlCreateInfoAMD>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkCalibratedTimestampInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkTimeDomainEXT timeDomain;
		}

        public static ManagedPtr<VkCalibratedTimestampInfoEXT> Pointer(this VkCalibratedTimestampInfoEXT i) => new ManagedPtr<VkCalibratedTimestampInfoEXT>(i);
        public static ManagedPtrArray<VkCalibratedTimestampInfoEXT> Pointer(this VkCalibratedTimestampInfoEXT[] i) => new ManagedPtrArray<VkCalibratedTimestampInfoEXT>(i);
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
        public static ManagedPtrArray<VkPhysicalDeviceShaderCorePropertiesAMD> Pointer(this VkPhysicalDeviceShaderCorePropertiesAMD[] i) => new ManagedPtrArray<VkPhysicalDeviceShaderCorePropertiesAMD>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceMemoryOverallocationCreateInfoAMD {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkMemoryOverallocationBehaviorAMD overallocationBehavior;
		}

        public static ManagedPtr<VkDeviceMemoryOverallocationCreateInfoAMD> Pointer(this VkDeviceMemoryOverallocationCreateInfoAMD i) => new ManagedPtr<VkDeviceMemoryOverallocationCreateInfoAMD>(i);
        public static ManagedPtrArray<VkDeviceMemoryOverallocationCreateInfoAMD> Pointer(this VkDeviceMemoryOverallocationCreateInfoAMD[] i) => new ManagedPtrArray<VkDeviceMemoryOverallocationCreateInfoAMD>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint maxVertexAttribDivisor;
		}

        public static ManagedPtr<VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT> Pointer(this VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT> Pointer(this VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkVertexInputBindingDivisorDescriptionEXT {
			[FieldOffset(0)]public uint binding;
			[FieldOffset(4)]public uint divisor;
		}

        public static ManagedPtr<VkVertexInputBindingDivisorDescriptionEXT> Pointer(this VkVertexInputBindingDivisorDescriptionEXT i) => new ManagedPtr<VkVertexInputBindingDivisorDescriptionEXT>(i);
        public static ManagedPtrArray<VkVertexInputBindingDivisorDescriptionEXT> Pointer(this VkVertexInputBindingDivisorDescriptionEXT[] i) => new ManagedPtrArray<VkVertexInputBindingDivisorDescriptionEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineVertexInputDivisorStateCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint vertexBindingDivisorCount;
			[FieldOffset(24)]public IntPtr pVertexBindingDivisors;
		}

        public static ManagedPtr<VkPipelineVertexInputDivisorStateCreateInfoEXT> Pointer(this VkPipelineVertexInputDivisorStateCreateInfoEXT i) => new ManagedPtr<VkPipelineVertexInputDivisorStateCreateInfoEXT>(i);
        public static ManagedPtrArray<VkPipelineVertexInputDivisorStateCreateInfoEXT> Pointer(this VkPipelineVertexInputDivisorStateCreateInfoEXT[] i) => new ManagedPtrArray<VkPipelineVertexInputDivisorStateCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool vertexAttributeInstanceRateDivisor;
			[FieldOffset(20)]public bool vertexAttributeInstanceRateZeroDivisor;
		}

        public static ManagedPtr<VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT> Pointer(this VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT> Pointer(this VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineCreationFeedbackEXT {
			[FieldOffset(0)]public VkPipelineCreationFeedbackFlagsEXT flags;
			[FieldOffset(8)]public ulong duration;
		}

        public static ManagedPtr<VkPipelineCreationFeedbackEXT> Pointer(this VkPipelineCreationFeedbackEXT i) => new ManagedPtr<VkPipelineCreationFeedbackEXT>(i);
        public static ManagedPtrArray<VkPipelineCreationFeedbackEXT> Pointer(this VkPipelineCreationFeedbackEXT[] i) => new ManagedPtrArray<VkPipelineCreationFeedbackEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineCreationFeedbackCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr pPipelineCreationFeedback;
			[FieldOffset(24)]public uint pipelineStageCreationFeedbackCount;
			[FieldOffset(32)]public IntPtr pPipelineStageCreationFeedbacks;
		}

        public static ManagedPtr<VkPipelineCreationFeedbackCreateInfoEXT> Pointer(this VkPipelineCreationFeedbackCreateInfoEXT i) => new ManagedPtr<VkPipelineCreationFeedbackCreateInfoEXT>(i);
        public static ManagedPtrArray<VkPipelineCreationFeedbackCreateInfoEXT> Pointer(this VkPipelineCreationFeedbackCreateInfoEXT[] i) => new ManagedPtrArray<VkPipelineCreationFeedbackCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceComputeShaderDerivativesFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool computeDerivativeGroupQuads;
			[FieldOffset(20)]public bool computeDerivativeGroupLinear;
		}

        public static ManagedPtr<VkPhysicalDeviceComputeShaderDerivativesFeaturesNV> Pointer(this VkPhysicalDeviceComputeShaderDerivativesFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceComputeShaderDerivativesFeaturesNV>(i);
        public static ManagedPtrArray<VkPhysicalDeviceComputeShaderDerivativesFeaturesNV> Pointer(this VkPhysicalDeviceComputeShaderDerivativesFeaturesNV[] i) => new ManagedPtrArray<VkPhysicalDeviceComputeShaderDerivativesFeaturesNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceMeshShaderFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool taskShader;
			[FieldOffset(20)]public bool meshShader;
		}

        public static ManagedPtr<VkPhysicalDeviceMeshShaderFeaturesNV> Pointer(this VkPhysicalDeviceMeshShaderFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceMeshShaderFeaturesNV>(i);
        public static ManagedPtrArray<VkPhysicalDeviceMeshShaderFeaturesNV> Pointer(this VkPhysicalDeviceMeshShaderFeaturesNV[] i) => new ManagedPtrArray<VkPhysicalDeviceMeshShaderFeaturesNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceMeshShaderPropertiesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint maxDrawMeshTasksCount;
			[FieldOffset(20)]public uint maxTaskWorkGroupInvocations;
			[FieldOffset(24)]public fixed uint maxTaskWorkGroupSize[3];
			public const int maxTaskWorkGroupSize_len = 3;
			[FieldOffset(36)]public uint maxTaskTotalMemorySize;
			[FieldOffset(40)]public uint maxTaskOutputCount;
			[FieldOffset(44)]public uint maxMeshWorkGroupInvocations;
			[FieldOffset(48)]public fixed uint maxMeshWorkGroupSize[3];
			public const int maxMeshWorkGroupSize_len = 3;
			[FieldOffset(60)]public uint maxMeshTotalMemorySize;
			[FieldOffset(64)]public uint maxMeshOutputVertices;
			[FieldOffset(68)]public uint maxMeshOutputPrimitives;
			[FieldOffset(72)]public uint maxMeshMultiviewViewCount;
			[FieldOffset(76)]public uint meshOutputPerVertexGranularity;
			[FieldOffset(80)]public uint meshOutputPerPrimitiveGranularity;
		}

        public static ManagedPtr<VkPhysicalDeviceMeshShaderPropertiesNV> Pointer(this VkPhysicalDeviceMeshShaderPropertiesNV i) => new ManagedPtr<VkPhysicalDeviceMeshShaderPropertiesNV>(i);
        public static ManagedPtrArray<VkPhysicalDeviceMeshShaderPropertiesNV> Pointer(this VkPhysicalDeviceMeshShaderPropertiesNV[] i) => new ManagedPtrArray<VkPhysicalDeviceMeshShaderPropertiesNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDrawMeshTasksIndirectCommandNV {
			[FieldOffset(0)]public uint taskCount;
			[FieldOffset(4)]public uint firstTask;
		}

        public static ManagedPtr<VkDrawMeshTasksIndirectCommandNV> Pointer(this VkDrawMeshTasksIndirectCommandNV i) => new ManagedPtr<VkDrawMeshTasksIndirectCommandNV>(i);
        public static ManagedPtrArray<VkDrawMeshTasksIndirectCommandNV> Pointer(this VkDrawMeshTasksIndirectCommandNV[] i) => new ManagedPtrArray<VkDrawMeshTasksIndirectCommandNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool fragmentShaderBarycentric;
		}

        public static ManagedPtr<VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV> Pointer(this VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV>(i);
        public static ManagedPtrArray<VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV> Pointer(this VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV[] i) => new ManagedPtrArray<VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShaderImageFootprintFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool imageFootprint;
		}

        public static ManagedPtr<VkPhysicalDeviceShaderImageFootprintFeaturesNV> Pointer(this VkPhysicalDeviceShaderImageFootprintFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceShaderImageFootprintFeaturesNV>(i);
        public static ManagedPtrArray<VkPhysicalDeviceShaderImageFootprintFeaturesNV> Pointer(this VkPhysicalDeviceShaderImageFootprintFeaturesNV[] i) => new ManagedPtrArray<VkPhysicalDeviceShaderImageFootprintFeaturesNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineViewportExclusiveScissorStateCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint exclusiveScissorCount;
			[FieldOffset(24)]public IntPtr pExclusiveScissors;
		}

        public static ManagedPtr<VkPipelineViewportExclusiveScissorStateCreateInfoNV> Pointer(this VkPipelineViewportExclusiveScissorStateCreateInfoNV i) => new ManagedPtr<VkPipelineViewportExclusiveScissorStateCreateInfoNV>(i);
        public static ManagedPtrArray<VkPipelineViewportExclusiveScissorStateCreateInfoNV> Pointer(this VkPipelineViewportExclusiveScissorStateCreateInfoNV[] i) => new ManagedPtrArray<VkPipelineViewportExclusiveScissorStateCreateInfoNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceExclusiveScissorFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool exclusiveScissor;
		}

        public static ManagedPtr<VkPhysicalDeviceExclusiveScissorFeaturesNV> Pointer(this VkPhysicalDeviceExclusiveScissorFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceExclusiveScissorFeaturesNV>(i);
        public static ManagedPtrArray<VkPhysicalDeviceExclusiveScissorFeaturesNV> Pointer(this VkPhysicalDeviceExclusiveScissorFeaturesNV[] i) => new ManagedPtrArray<VkPhysicalDeviceExclusiveScissorFeaturesNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkQueueFamilyCheckpointPropertiesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPipelineStageFlags checkpointExecutionStageMask;
		}

        public static ManagedPtr<VkQueueFamilyCheckpointPropertiesNV> Pointer(this VkQueueFamilyCheckpointPropertiesNV i) => new ManagedPtr<VkQueueFamilyCheckpointPropertiesNV>(i);
        public static ManagedPtrArray<VkQueueFamilyCheckpointPropertiesNV> Pointer(this VkQueueFamilyCheckpointPropertiesNV[] i) => new ManagedPtrArray<VkQueueFamilyCheckpointPropertiesNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkCheckpointDataNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPipelineStageFlags stage;
			[FieldOffset(24)]public IntPtr pCheckpointMarker;
		}

        public static ManagedPtr<VkCheckpointDataNV> Pointer(this VkCheckpointDataNV i) => new ManagedPtr<VkCheckpointDataNV>(i);
        public static ManagedPtrArray<VkCheckpointDataNV> Pointer(this VkCheckpointDataNV[] i) => new ManagedPtrArray<VkCheckpointDataNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool shaderIntegerFunctions2;
		}

        public static ManagedPtr<VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL> Pointer(this VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL i) => new ManagedPtr<VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL>(i);
        public static ManagedPtrArray<VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL> Pointer(this VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL[] i) => new ManagedPtrArray<VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPerformanceValueINTEL {
			[FieldOffset(0)]public VkPerformanceValueTypeINTEL type;
			[FieldOffset(8)]public VkPerformanceValueDataINTEL data;
		}

        public static ManagedPtr<VkPerformanceValueINTEL> Pointer(this VkPerformanceValueINTEL i) => new ManagedPtr<VkPerformanceValueINTEL>(i);
        public static ManagedPtrArray<VkPerformanceValueINTEL> Pointer(this VkPerformanceValueINTEL[] i) => new ManagedPtrArray<VkPerformanceValueINTEL>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkInitializePerformanceApiInfoINTEL {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public IntPtr pUserData;
		}

        public static ManagedPtr<VkInitializePerformanceApiInfoINTEL> Pointer(this VkInitializePerformanceApiInfoINTEL i) => new ManagedPtr<VkInitializePerformanceApiInfoINTEL>(i);
        public static ManagedPtrArray<VkInitializePerformanceApiInfoINTEL> Pointer(this VkInitializePerformanceApiInfoINTEL[] i) => new ManagedPtrArray<VkInitializePerformanceApiInfoINTEL>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkQueryPoolPerformanceQueryCreateInfoINTEL {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkQueryPoolSamplingModeINTEL performanceCountersSampling;
		}

        public static ManagedPtr<VkQueryPoolPerformanceQueryCreateInfoINTEL> Pointer(this VkQueryPoolPerformanceQueryCreateInfoINTEL i) => new ManagedPtr<VkQueryPoolPerformanceQueryCreateInfoINTEL>(i);
        public static ManagedPtrArray<VkQueryPoolPerformanceQueryCreateInfoINTEL> Pointer(this VkQueryPoolPerformanceQueryCreateInfoINTEL[] i) => new ManagedPtrArray<VkQueryPoolPerformanceQueryCreateInfoINTEL>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPerformanceMarkerInfoINTEL {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong marker;
		}

        public static ManagedPtr<VkPerformanceMarkerInfoINTEL> Pointer(this VkPerformanceMarkerInfoINTEL i) => new ManagedPtr<VkPerformanceMarkerInfoINTEL>(i);
        public static ManagedPtrArray<VkPerformanceMarkerInfoINTEL> Pointer(this VkPerformanceMarkerInfoINTEL[] i) => new ManagedPtrArray<VkPerformanceMarkerInfoINTEL>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPerformanceStreamMarkerInfoINTEL {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint marker;
		}

        public static ManagedPtr<VkPerformanceStreamMarkerInfoINTEL> Pointer(this VkPerformanceStreamMarkerInfoINTEL i) => new ManagedPtr<VkPerformanceStreamMarkerInfoINTEL>(i);
        public static ManagedPtrArray<VkPerformanceStreamMarkerInfoINTEL> Pointer(this VkPerformanceStreamMarkerInfoINTEL[] i) => new ManagedPtrArray<VkPerformanceStreamMarkerInfoINTEL>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPerformanceOverrideInfoINTEL {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPerformanceOverrideTypeINTEL type;
			[FieldOffset(20)]public bool enable;
			[FieldOffset(24)]public ulong parameter;
		}

        public static ManagedPtr<VkPerformanceOverrideInfoINTEL> Pointer(this VkPerformanceOverrideInfoINTEL i) => new ManagedPtr<VkPerformanceOverrideInfoINTEL>(i);
        public static ManagedPtrArray<VkPerformanceOverrideInfoINTEL> Pointer(this VkPerformanceOverrideInfoINTEL[] i) => new ManagedPtrArray<VkPerformanceOverrideInfoINTEL>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPerformanceConfigurationAcquireInfoINTEL {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPerformanceConfigurationTypeINTEL type;
		}

        public static ManagedPtr<VkPerformanceConfigurationAcquireInfoINTEL> Pointer(this VkPerformanceConfigurationAcquireInfoINTEL i) => new ManagedPtr<VkPerformanceConfigurationAcquireInfoINTEL>(i);
        public static ManagedPtrArray<VkPerformanceConfigurationAcquireInfoINTEL> Pointer(this VkPerformanceConfigurationAcquireInfoINTEL[] i) => new ManagedPtrArray<VkPerformanceConfigurationAcquireInfoINTEL>(i);
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
        public static ManagedPtrArray<VkPhysicalDevicePCIBusInfoPropertiesEXT> Pointer(this VkPhysicalDevicePCIBusInfoPropertiesEXT[] i) => new ManagedPtrArray<VkPhysicalDevicePCIBusInfoPropertiesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDisplayNativeHdrSurfaceCapabilitiesAMD {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool localDimmingSupport;
		}

        public static ManagedPtr<VkDisplayNativeHdrSurfaceCapabilitiesAMD> Pointer(this VkDisplayNativeHdrSurfaceCapabilitiesAMD i) => new ManagedPtr<VkDisplayNativeHdrSurfaceCapabilitiesAMD>(i);
        public static ManagedPtrArray<VkDisplayNativeHdrSurfaceCapabilitiesAMD> Pointer(this VkDisplayNativeHdrSurfaceCapabilitiesAMD[] i) => new ManagedPtrArray<VkDisplayNativeHdrSurfaceCapabilitiesAMD>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSwapchainDisplayNativeHdrCreateInfoAMD {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool localDimmingEnable;
		}

        public static ManagedPtr<VkSwapchainDisplayNativeHdrCreateInfoAMD> Pointer(this VkSwapchainDisplayNativeHdrCreateInfoAMD i) => new ManagedPtr<VkSwapchainDisplayNativeHdrCreateInfoAMD>(i);
        public static ManagedPtrArray<VkSwapchainDisplayNativeHdrCreateInfoAMD> Pointer(this VkSwapchainDisplayNativeHdrCreateInfoAMD[] i) => new ManagedPtrArray<VkSwapchainDisplayNativeHdrCreateInfoAMD>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool fragmentDensityMap;
			[FieldOffset(20)]public bool fragmentDensityMapDynamic;
			[FieldOffset(24)]public bool fragmentDensityMapNonSubsampledImages;
		}

        public static ManagedPtr<VkPhysicalDeviceFragmentDensityMapFeaturesEXT> Pointer(this VkPhysicalDeviceFragmentDensityMapFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceFragmentDensityMapFeaturesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceFragmentDensityMapFeaturesEXT> Pointer(this VkPhysicalDeviceFragmentDensityMapFeaturesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceFragmentDensityMapFeaturesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkExtent2D minFragmentDensityTexelSize;
			[FieldOffset(24)]public VkExtent2D maxFragmentDensityTexelSize;
			[FieldOffset(32)]public bool fragmentDensityInvocations;
		}

        public static ManagedPtr<VkPhysicalDeviceFragmentDensityMapPropertiesEXT> Pointer(this VkPhysicalDeviceFragmentDensityMapPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceFragmentDensityMapPropertiesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceFragmentDensityMapPropertiesEXT> Pointer(this VkPhysicalDeviceFragmentDensityMapPropertiesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceFragmentDensityMapPropertiesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRenderPassFragmentDensityMapCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkAttachmentReference fragmentDensityMapAttachment;
		}

        public static ManagedPtr<VkRenderPassFragmentDensityMapCreateInfoEXT> Pointer(this VkRenderPassFragmentDensityMapCreateInfoEXT i) => new ManagedPtr<VkRenderPassFragmentDensityMapCreateInfoEXT>(i);
        public static ManagedPtrArray<VkRenderPassFragmentDensityMapCreateInfoEXT> Pointer(this VkRenderPassFragmentDensityMapCreateInfoEXT[] i) => new ManagedPtrArray<VkRenderPassFragmentDensityMapCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceSubgroupSizeControlFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool subgroupSizeControl;
			[FieldOffset(20)]public bool computeFullSubgroups;
		}

        public static ManagedPtr<VkPhysicalDeviceSubgroupSizeControlFeaturesEXT> Pointer(this VkPhysicalDeviceSubgroupSizeControlFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceSubgroupSizeControlFeaturesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceSubgroupSizeControlFeaturesEXT> Pointer(this VkPhysicalDeviceSubgroupSizeControlFeaturesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceSubgroupSizeControlFeaturesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceSubgroupSizeControlPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint minSubgroupSize;
			[FieldOffset(20)]public uint maxSubgroupSize;
			[FieldOffset(24)]public uint maxComputeWorkgroupSubgroups;
			[FieldOffset(28)]public VkShaderStageFlags requiredSubgroupSizeStages;
		}

        public static ManagedPtr<VkPhysicalDeviceSubgroupSizeControlPropertiesEXT> Pointer(this VkPhysicalDeviceSubgroupSizeControlPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceSubgroupSizeControlPropertiesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceSubgroupSizeControlPropertiesEXT> Pointer(this VkPhysicalDeviceSubgroupSizeControlPropertiesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceSubgroupSizeControlPropertiesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint requiredSubgroupSize;
		}

        public static ManagedPtr<VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT> Pointer(this VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT i) => new ManagedPtr<VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT>(i);
        public static ManagedPtrArray<VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT> Pointer(this VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT[] i) => new ManagedPtrArray<VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShaderCoreProperties2AMD {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkShaderCorePropertiesFlagsAMD shaderCoreFeatures;
			[FieldOffset(20)]public uint activeComputeUnitCount;
		}

        public static ManagedPtr<VkPhysicalDeviceShaderCoreProperties2AMD> Pointer(this VkPhysicalDeviceShaderCoreProperties2AMD i) => new ManagedPtr<VkPhysicalDeviceShaderCoreProperties2AMD>(i);
        public static ManagedPtrArray<VkPhysicalDeviceShaderCoreProperties2AMD> Pointer(this VkPhysicalDeviceShaderCoreProperties2AMD[] i) => new ManagedPtrArray<VkPhysicalDeviceShaderCoreProperties2AMD>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceCoherentMemoryFeaturesAMD {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool deviceCoherentMemory;
		}

        public static ManagedPtr<VkPhysicalDeviceCoherentMemoryFeaturesAMD> Pointer(this VkPhysicalDeviceCoherentMemoryFeaturesAMD i) => new ManagedPtr<VkPhysicalDeviceCoherentMemoryFeaturesAMD>(i);
        public static ManagedPtrArray<VkPhysicalDeviceCoherentMemoryFeaturesAMD> Pointer(this VkPhysicalDeviceCoherentMemoryFeaturesAMD[] i) => new ManagedPtrArray<VkPhysicalDeviceCoherentMemoryFeaturesAMD>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceMemoryBudgetPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)][MarshalAs(UnmanagedType.ByValArray, SizeConst=16)] public ulong[] heapBudget;
			public const int heapBudget_len = 16;
			[FieldOffset(144)][MarshalAs(UnmanagedType.ByValArray, SizeConst=16)] public ulong[] heapUsage;
			public const int heapUsage_len = 16;
		}

        public static ManagedPtr<VkPhysicalDeviceMemoryBudgetPropertiesEXT> Pointer(this VkPhysicalDeviceMemoryBudgetPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceMemoryBudgetPropertiesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceMemoryBudgetPropertiesEXT> Pointer(this VkPhysicalDeviceMemoryBudgetPropertiesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceMemoryBudgetPropertiesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceMemoryPriorityFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool memoryPriority;
		}

        public static ManagedPtr<VkPhysicalDeviceMemoryPriorityFeaturesEXT> Pointer(this VkPhysicalDeviceMemoryPriorityFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceMemoryPriorityFeaturesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceMemoryPriorityFeaturesEXT> Pointer(this VkPhysicalDeviceMemoryPriorityFeaturesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceMemoryPriorityFeaturesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkMemoryPriorityAllocateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public float priority;
		}

        public static ManagedPtr<VkMemoryPriorityAllocateInfoEXT> Pointer(this VkMemoryPriorityAllocateInfoEXT i) => new ManagedPtr<VkMemoryPriorityAllocateInfoEXT>(i);
        public static ManagedPtrArray<VkMemoryPriorityAllocateInfoEXT> Pointer(this VkMemoryPriorityAllocateInfoEXT[] i) => new ManagedPtrArray<VkMemoryPriorityAllocateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool dedicatedAllocationImageAliasing;
		}

        public static ManagedPtr<VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV> Pointer(this VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV>(i);
        public static ManagedPtrArray<VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV> Pointer(this VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV[] i) => new ManagedPtrArray<VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool bufferDeviceAddress;
			[FieldOffset(20)]public bool bufferDeviceAddressCaptureReplay;
			[FieldOffset(24)]public bool bufferDeviceAddressMultiDevice;
		}

        public static ManagedPtr<VkPhysicalDeviceBufferDeviceAddressFeaturesEXT> Pointer(this VkPhysicalDeviceBufferDeviceAddressFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceBufferDeviceAddressFeaturesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceBufferDeviceAddressFeaturesEXT> Pointer(this VkPhysicalDeviceBufferDeviceAddressFeaturesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceBufferDeviceAddressFeaturesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBufferDeviceAddressCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong deviceAddress;
		}

        public static ManagedPtr<VkBufferDeviceAddressCreateInfoEXT> Pointer(this VkBufferDeviceAddressCreateInfoEXT i) => new ManagedPtr<VkBufferDeviceAddressCreateInfoEXT>(i);
        public static ManagedPtrArray<VkBufferDeviceAddressCreateInfoEXT> Pointer(this VkBufferDeviceAddressCreateInfoEXT[] i) => new ManagedPtrArray<VkBufferDeviceAddressCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceToolPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public fixed byte name[256];
			public const int name_len = 256;
			[FieldOffset(272)]public fixed byte version[256];
			public const int version_len = 256;
			[FieldOffset(528)]public VkToolPurposeFlagsEXT purposes;
			[FieldOffset(532)]public fixed byte description[256];
			public const int description_len = 256;
			[FieldOffset(788)]public fixed byte layer[256];
			public const int layer_len = 256;
		}

        public static ManagedPtr<VkPhysicalDeviceToolPropertiesEXT> Pointer(this VkPhysicalDeviceToolPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceToolPropertiesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceToolPropertiesEXT> Pointer(this VkPhysicalDeviceToolPropertiesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceToolPropertiesEXT>(i);
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
        public static ManagedPtrArray<VkValidationFeaturesEXT> Pointer(this VkValidationFeaturesEXT[] i) => new ManagedPtrArray<VkValidationFeaturesEXT>(i);
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
        public static ManagedPtrArray<VkCooperativeMatrixPropertiesNV> Pointer(this VkCooperativeMatrixPropertiesNV[] i) => new ManagedPtrArray<VkCooperativeMatrixPropertiesNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceCooperativeMatrixFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool cooperativeMatrix;
			[FieldOffset(20)]public bool cooperativeMatrixRobustBufferAccess;
		}

        public static ManagedPtr<VkPhysicalDeviceCooperativeMatrixFeaturesNV> Pointer(this VkPhysicalDeviceCooperativeMatrixFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceCooperativeMatrixFeaturesNV>(i);
        public static ManagedPtrArray<VkPhysicalDeviceCooperativeMatrixFeaturesNV> Pointer(this VkPhysicalDeviceCooperativeMatrixFeaturesNV[] i) => new ManagedPtrArray<VkPhysicalDeviceCooperativeMatrixFeaturesNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceCooperativeMatrixPropertiesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkShaderStageFlags cooperativeMatrixSupportedStages;
		}

        public static ManagedPtr<VkPhysicalDeviceCooperativeMatrixPropertiesNV> Pointer(this VkPhysicalDeviceCooperativeMatrixPropertiesNV i) => new ManagedPtr<VkPhysicalDeviceCooperativeMatrixPropertiesNV>(i);
        public static ManagedPtrArray<VkPhysicalDeviceCooperativeMatrixPropertiesNV> Pointer(this VkPhysicalDeviceCooperativeMatrixPropertiesNV[] i) => new ManagedPtrArray<VkPhysicalDeviceCooperativeMatrixPropertiesNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceCoverageReductionModeFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool coverageReductionMode;
		}

        public static ManagedPtr<VkPhysicalDeviceCoverageReductionModeFeaturesNV> Pointer(this VkPhysicalDeviceCoverageReductionModeFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceCoverageReductionModeFeaturesNV>(i);
        public static ManagedPtrArray<VkPhysicalDeviceCoverageReductionModeFeaturesNV> Pointer(this VkPhysicalDeviceCoverageReductionModeFeaturesNV[] i) => new ManagedPtrArray<VkPhysicalDeviceCoverageReductionModeFeaturesNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineCoverageReductionStateCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
			[FieldOffset(20)]public VkCoverageReductionModeNV coverageReductionMode;
		}

        public static ManagedPtr<VkPipelineCoverageReductionStateCreateInfoNV> Pointer(this VkPipelineCoverageReductionStateCreateInfoNV i) => new ManagedPtr<VkPipelineCoverageReductionStateCreateInfoNV>(i);
        public static ManagedPtrArray<VkPipelineCoverageReductionStateCreateInfoNV> Pointer(this VkPipelineCoverageReductionStateCreateInfoNV[] i) => new ManagedPtrArray<VkPipelineCoverageReductionStateCreateInfoNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkFramebufferMixedSamplesCombinationNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkCoverageReductionModeNV coverageReductionMode;
			[FieldOffset(20)]public VkSampleCountFlags rasterizationSamples;
			[FieldOffset(24)]public VkSampleCountFlags depthStencilSamples;
			[FieldOffset(28)]public VkSampleCountFlags colorSamples;
		}

        public static ManagedPtr<VkFramebufferMixedSamplesCombinationNV> Pointer(this VkFramebufferMixedSamplesCombinationNV i) => new ManagedPtr<VkFramebufferMixedSamplesCombinationNV>(i);
        public static ManagedPtrArray<VkFramebufferMixedSamplesCombinationNV> Pointer(this VkFramebufferMixedSamplesCombinationNV[] i) => new ManagedPtrArray<VkFramebufferMixedSamplesCombinationNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool fragmentShaderSampleInterlock;
			[FieldOffset(20)]public bool fragmentShaderPixelInterlock;
			[FieldOffset(24)]public bool fragmentShaderShadingRateInterlock;
		}

        public static ManagedPtr<VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT> Pointer(this VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT> Pointer(this VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool ycbcrImageArrays;
		}

        public static ManagedPtr<VkPhysicalDeviceYcbcrImageArraysFeaturesEXT> Pointer(this VkPhysicalDeviceYcbcrImageArraysFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceYcbcrImageArraysFeaturesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceYcbcrImageArraysFeaturesEXT> Pointer(this VkPhysicalDeviceYcbcrImageArraysFeaturesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceYcbcrImageArraysFeaturesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkHeadlessSurfaceCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint flags;
		}

        public static ManagedPtr<VkHeadlessSurfaceCreateInfoEXT> Pointer(this VkHeadlessSurfaceCreateInfoEXT i) => new ManagedPtr<VkHeadlessSurfaceCreateInfoEXT>(i);
        public static ManagedPtrArray<VkHeadlessSurfaceCreateInfoEXT> Pointer(this VkHeadlessSurfaceCreateInfoEXT[] i) => new ManagedPtrArray<VkHeadlessSurfaceCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceLineRasterizationFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool rectangularLines;
			[FieldOffset(20)]public bool bresenhamLines;
			[FieldOffset(24)]public bool smoothLines;
			[FieldOffset(28)]public bool stippledRectangularLines;
			[FieldOffset(32)]public bool stippledBresenhamLines;
			[FieldOffset(36)]public bool stippledSmoothLines;
		}

        public static ManagedPtr<VkPhysicalDeviceLineRasterizationFeaturesEXT> Pointer(this VkPhysicalDeviceLineRasterizationFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceLineRasterizationFeaturesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceLineRasterizationFeaturesEXT> Pointer(this VkPhysicalDeviceLineRasterizationFeaturesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceLineRasterizationFeaturesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceLineRasterizationPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint lineSubPixelPrecisionBits;
		}

        public static ManagedPtr<VkPhysicalDeviceLineRasterizationPropertiesEXT> Pointer(this VkPhysicalDeviceLineRasterizationPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceLineRasterizationPropertiesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceLineRasterizationPropertiesEXT> Pointer(this VkPhysicalDeviceLineRasterizationPropertiesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceLineRasterizationPropertiesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineRasterizationLineStateCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkLineRasterizationModeEXT lineRasterizationMode;
			[FieldOffset(20)]public bool stippledLineEnable;
			[FieldOffset(24)]public uint lineStippleFactor;
			[FieldOffset(28)]public ushort lineStipplePattern;
		}

        public static ManagedPtr<VkPipelineRasterizationLineStateCreateInfoEXT> Pointer(this VkPipelineRasterizationLineStateCreateInfoEXT i) => new ManagedPtr<VkPipelineRasterizationLineStateCreateInfoEXT>(i);
        public static ManagedPtrArray<VkPipelineRasterizationLineStateCreateInfoEXT> Pointer(this VkPipelineRasterizationLineStateCreateInfoEXT[] i) => new ManagedPtrArray<VkPipelineRasterizationLineStateCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceIndexTypeUint8FeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool indexTypeUint8;
		}

        public static ManagedPtr<VkPhysicalDeviceIndexTypeUint8FeaturesEXT> Pointer(this VkPhysicalDeviceIndexTypeUint8FeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceIndexTypeUint8FeaturesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceIndexTypeUint8FeaturesEXT> Pointer(this VkPhysicalDeviceIndexTypeUint8FeaturesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceIndexTypeUint8FeaturesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool shaderDemoteToHelperInvocation;
		}

        public static ManagedPtr<VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT> Pointer(this VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT> Pointer(this VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint maxGraphicsShaderGroupCount;
			[FieldOffset(20)]public uint maxIndirectSequenceCount;
			[FieldOffset(24)]public uint maxIndirectCommandsTokenCount;
			[FieldOffset(28)]public uint maxIndirectCommandsStreamCount;
			[FieldOffset(32)]public uint maxIndirectCommandsTokenOffset;
			[FieldOffset(36)]public uint maxIndirectCommandsStreamStride;
			[FieldOffset(40)]public uint minSequencesCountBufferOffsetAlignment;
			[FieldOffset(44)]public uint minSequencesIndexBufferOffsetAlignment;
			[FieldOffset(48)]public uint minIndirectCommandsBufferOffsetAlignment;
		}

        public static ManagedPtr<VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV> Pointer(this VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV i) => new ManagedPtr<VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV>(i);
        public static ManagedPtrArray<VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV> Pointer(this VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV[] i) => new ManagedPtrArray<VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool deviceGeneratedCommands;
		}

        public static ManagedPtr<VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV> Pointer(this VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV>(i);
        public static ManagedPtrArray<VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV> Pointer(this VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV[] i) => new ManagedPtrArray<VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkGraphicsShaderGroupCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint stageCount;
			[FieldOffset(24)]public IntPtr pStages;
			[FieldOffset(32)]public IntPtr pVertexInputState;
			[FieldOffset(40)]public IntPtr pTessellationState;
		}

        public static ManagedPtr<VkGraphicsShaderGroupCreateInfoNV> Pointer(this VkGraphicsShaderGroupCreateInfoNV i) => new ManagedPtr<VkGraphicsShaderGroupCreateInfoNV>(i);
        public static ManagedPtrArray<VkGraphicsShaderGroupCreateInfoNV> Pointer(this VkGraphicsShaderGroupCreateInfoNV[] i) => new ManagedPtrArray<VkGraphicsShaderGroupCreateInfoNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkGraphicsPipelineShaderGroupsCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint groupCount;
			[FieldOffset(24)]public IntPtr pGroups;
			[FieldOffset(32)]public uint pipelineCount;
			[FieldOffset(40)]public IntPtr* pPipelines;
		}

        public static ManagedPtr<VkGraphicsPipelineShaderGroupsCreateInfoNV> Pointer(this VkGraphicsPipelineShaderGroupsCreateInfoNV i) => new ManagedPtr<VkGraphicsPipelineShaderGroupsCreateInfoNV>(i);
        public static ManagedPtrArray<VkGraphicsPipelineShaderGroupsCreateInfoNV> Pointer(this VkGraphicsPipelineShaderGroupsCreateInfoNV[] i) => new ManagedPtrArray<VkGraphicsPipelineShaderGroupsCreateInfoNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBindShaderGroupIndirectCommandNV {
			[FieldOffset(0)]public uint groupIndex;
		}

        public static ManagedPtr<VkBindShaderGroupIndirectCommandNV> Pointer(this VkBindShaderGroupIndirectCommandNV i) => new ManagedPtr<VkBindShaderGroupIndirectCommandNV>(i);
        public static ManagedPtrArray<VkBindShaderGroupIndirectCommandNV> Pointer(this VkBindShaderGroupIndirectCommandNV[] i) => new ManagedPtrArray<VkBindShaderGroupIndirectCommandNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBindIndexBufferIndirectCommandNV {
			[FieldOffset(0)]public ulong bufferAddress;
			[FieldOffset(8)]public uint size;
			[FieldOffset(12)]public VkIndexType indexType;
		}

        public static ManagedPtr<VkBindIndexBufferIndirectCommandNV> Pointer(this VkBindIndexBufferIndirectCommandNV i) => new ManagedPtr<VkBindIndexBufferIndirectCommandNV>(i);
        public static ManagedPtrArray<VkBindIndexBufferIndirectCommandNV> Pointer(this VkBindIndexBufferIndirectCommandNV[] i) => new ManagedPtrArray<VkBindIndexBufferIndirectCommandNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkBindVertexBufferIndirectCommandNV {
			[FieldOffset(0)]public ulong bufferAddress;
			[FieldOffset(8)]public uint size;
			[FieldOffset(12)]public uint stride;
		}

        public static ManagedPtr<VkBindVertexBufferIndirectCommandNV> Pointer(this VkBindVertexBufferIndirectCommandNV i) => new ManagedPtr<VkBindVertexBufferIndirectCommandNV>(i);
        public static ManagedPtrArray<VkBindVertexBufferIndirectCommandNV> Pointer(this VkBindVertexBufferIndirectCommandNV[] i) => new ManagedPtrArray<VkBindVertexBufferIndirectCommandNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSetStateFlagsIndirectCommandNV {
			[FieldOffset(0)]public uint data;
		}

        public static ManagedPtr<VkSetStateFlagsIndirectCommandNV> Pointer(this VkSetStateFlagsIndirectCommandNV i) => new ManagedPtr<VkSetStateFlagsIndirectCommandNV>(i);
        public static ManagedPtrArray<VkSetStateFlagsIndirectCommandNV> Pointer(this VkSetStateFlagsIndirectCommandNV[] i) => new ManagedPtrArray<VkSetStateFlagsIndirectCommandNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkIndirectCommandsStreamNV {
			[FieldOffset(0)]public IntPtr buffer;
			[FieldOffset(8)]public ulong offset;
		}

        public static ManagedPtr<VkIndirectCommandsStreamNV> Pointer(this VkIndirectCommandsStreamNV i) => new ManagedPtr<VkIndirectCommandsStreamNV>(i);
        public static ManagedPtrArray<VkIndirectCommandsStreamNV> Pointer(this VkIndirectCommandsStreamNV[] i) => new ManagedPtrArray<VkIndirectCommandsStreamNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkIndirectCommandsLayoutTokenNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkIndirectCommandsTokenTypeNV tokenType;
			[FieldOffset(20)]public uint stream;
			[FieldOffset(24)]public uint offset;
			[FieldOffset(28)]public uint vertexBindingUnit;
			[FieldOffset(32)]public bool vertexDynamicStride;
			[FieldOffset(40)]public IntPtr pushconstantPipelineLayout;
			[FieldOffset(48)]public VkShaderStageFlags pushconstantShaderStageFlags;
			[FieldOffset(52)]public uint pushconstantOffset;
			[FieldOffset(56)]public uint pushconstantSize;
			[FieldOffset(60)]public VkIndirectStateFlagsNV indirectStateFlags;
			[FieldOffset(64)]public uint indexTypeCount;
			[FieldOffset(72)]public VkIndexType* pIndexTypes;
			[FieldOffset(80)]public uint* pIndexTypeValues;
		}

        public static ManagedPtr<VkIndirectCommandsLayoutTokenNV> Pointer(this VkIndirectCommandsLayoutTokenNV i) => new ManagedPtr<VkIndirectCommandsLayoutTokenNV>(i);
        public static ManagedPtrArray<VkIndirectCommandsLayoutTokenNV> Pointer(this VkIndirectCommandsLayoutTokenNV[] i) => new ManagedPtrArray<VkIndirectCommandsLayoutTokenNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkIndirectCommandsLayoutCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkIndirectCommandsLayoutUsageFlagsNV flags;
			[FieldOffset(20)]public VkPipelineBindPoint pipelineBindPoint;
			[FieldOffset(24)]public uint tokenCount;
			[FieldOffset(32)]public IntPtr pTokens;
			[FieldOffset(40)]public uint streamCount;
			[FieldOffset(48)]public uint* pStreamStrides;
		}

        public static ManagedPtr<VkIndirectCommandsLayoutCreateInfoNV> Pointer(this VkIndirectCommandsLayoutCreateInfoNV i) => new ManagedPtr<VkIndirectCommandsLayoutCreateInfoNV>(i);
        public static ManagedPtrArray<VkIndirectCommandsLayoutCreateInfoNV> Pointer(this VkIndirectCommandsLayoutCreateInfoNV[] i) => new ManagedPtrArray<VkIndirectCommandsLayoutCreateInfoNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkGeneratedCommandsInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPipelineBindPoint pipelineBindPoint;
			[FieldOffset(24)]public IntPtr pipeline;
			[FieldOffset(32)]public IntPtr indirectCommandsLayout;
			[FieldOffset(40)]public uint streamCount;
			[FieldOffset(48)]public IntPtr pStreams;
			[FieldOffset(56)]public uint sequencesCount;
			[FieldOffset(64)]public IntPtr preprocessBuffer;
			[FieldOffset(72)]public ulong preprocessOffset;
			[FieldOffset(80)]public ulong preprocessSize;
			[FieldOffset(88)]public IntPtr sequencesCountBuffer;
			[FieldOffset(96)]public ulong sequencesCountOffset;
			[FieldOffset(104)]public IntPtr sequencesIndexBuffer;
			[FieldOffset(112)]public ulong sequencesIndexOffset;
		}

        public static ManagedPtr<VkGeneratedCommandsInfoNV> Pointer(this VkGeneratedCommandsInfoNV i) => new ManagedPtr<VkGeneratedCommandsInfoNV>(i);
        public static ManagedPtrArray<VkGeneratedCommandsInfoNV> Pointer(this VkGeneratedCommandsInfoNV[] i) => new ManagedPtrArray<VkGeneratedCommandsInfoNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkGeneratedCommandsMemoryRequirementsInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPipelineBindPoint pipelineBindPoint;
			[FieldOffset(24)]public IntPtr pipeline;
			[FieldOffset(32)]public IntPtr indirectCommandsLayout;
			[FieldOffset(40)]public uint maxSequencesCount;
		}

        public static ManagedPtr<VkGeneratedCommandsMemoryRequirementsInfoNV> Pointer(this VkGeneratedCommandsMemoryRequirementsInfoNV i) => new ManagedPtr<VkGeneratedCommandsMemoryRequirementsInfoNV>(i);
        public static ManagedPtrArray<VkGeneratedCommandsMemoryRequirementsInfoNV> Pointer(this VkGeneratedCommandsMemoryRequirementsInfoNV[] i) => new ManagedPtrArray<VkGeneratedCommandsMemoryRequirementsInfoNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool texelBufferAlignment;
		}

        public static ManagedPtr<VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT> Pointer(this VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT> Pointer(this VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong storageTexelBufferOffsetAlignmentBytes;
			[FieldOffset(24)]public bool storageTexelBufferOffsetSingleTexelAlignment;
			[FieldOffset(32)]public ulong uniformTexelBufferOffsetAlignmentBytes;
			[FieldOffset(40)]public bool uniformTexelBufferOffsetSingleTexelAlignment;
		}

        public static ManagedPtr<VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT> Pointer(this VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT> Pointer(this VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkRenderPassTransformBeginInfoQCOM {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkSurfaceTransformFlagsKHR transform;
		}

        public static ManagedPtr<VkRenderPassTransformBeginInfoQCOM> Pointer(this VkRenderPassTransformBeginInfoQCOM i) => new ManagedPtr<VkRenderPassTransformBeginInfoQCOM>(i);
        public static ManagedPtrArray<VkRenderPassTransformBeginInfoQCOM> Pointer(this VkRenderPassTransformBeginInfoQCOM[] i) => new ManagedPtrArray<VkRenderPassTransformBeginInfoQCOM>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkSurfaceTransformFlagsKHR transform;
			[FieldOffset(20)]public VkRect2D renderArea;
		}

        public static ManagedPtr<VkCommandBufferInheritanceRenderPassTransformInfoQCOM> Pointer(this VkCommandBufferInheritanceRenderPassTransformInfoQCOM i) => new ManagedPtr<VkCommandBufferInheritanceRenderPassTransformInfoQCOM>(i);
        public static ManagedPtrArray<VkCommandBufferInheritanceRenderPassTransformInfoQCOM> Pointer(this VkCommandBufferInheritanceRenderPassTransformInfoQCOM[] i) => new ManagedPtrArray<VkCommandBufferInheritanceRenderPassTransformInfoQCOM>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceRobustness2FeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool robustBufferAccess2;
			[FieldOffset(20)]public bool robustImageAccess2;
			[FieldOffset(24)]public bool nullDescriptor;
		}

        public static ManagedPtr<VkPhysicalDeviceRobustness2FeaturesEXT> Pointer(this VkPhysicalDeviceRobustness2FeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceRobustness2FeaturesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceRobustness2FeaturesEXT> Pointer(this VkPhysicalDeviceRobustness2FeaturesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceRobustness2FeaturesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceRobustness2PropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public ulong robustStorageBufferAccessSizeAlignment;
			[FieldOffset(24)]public ulong robustUniformBufferAccessSizeAlignment;
		}

        public static ManagedPtr<VkPhysicalDeviceRobustness2PropertiesEXT> Pointer(this VkPhysicalDeviceRobustness2PropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceRobustness2PropertiesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceRobustness2PropertiesEXT> Pointer(this VkPhysicalDeviceRobustness2PropertiesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceRobustness2PropertiesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkSamplerCustomBorderColorCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkClearColorValue customBorderColor;
			[FieldOffset(20)]public VkFormat format;
		}

        public static ManagedPtr<VkSamplerCustomBorderColorCreateInfoEXT> Pointer(this VkSamplerCustomBorderColorCreateInfoEXT i) => new ManagedPtr<VkSamplerCustomBorderColorCreateInfoEXT>(i);
        public static ManagedPtrArray<VkSamplerCustomBorderColorCreateInfoEXT> Pointer(this VkSamplerCustomBorderColorCreateInfoEXT[] i) => new ManagedPtrArray<VkSamplerCustomBorderColorCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceCustomBorderColorPropertiesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint maxCustomBorderColorSamplers;
		}

        public static ManagedPtr<VkPhysicalDeviceCustomBorderColorPropertiesEXT> Pointer(this VkPhysicalDeviceCustomBorderColorPropertiesEXT i) => new ManagedPtr<VkPhysicalDeviceCustomBorderColorPropertiesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceCustomBorderColorPropertiesEXT> Pointer(this VkPhysicalDeviceCustomBorderColorPropertiesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceCustomBorderColorPropertiesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceCustomBorderColorFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool customBorderColors;
			[FieldOffset(20)]public bool customBorderColorWithoutFormat;
		}

        public static ManagedPtr<VkPhysicalDeviceCustomBorderColorFeaturesEXT> Pointer(this VkPhysicalDeviceCustomBorderColorFeaturesEXT i) => new ManagedPtr<VkPhysicalDeviceCustomBorderColorFeaturesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDeviceCustomBorderColorFeaturesEXT> Pointer(this VkPhysicalDeviceCustomBorderColorFeaturesEXT[] i) => new ManagedPtrArray<VkPhysicalDeviceCustomBorderColorFeaturesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDevicePrivateDataFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool privateData;
		}

        public static ManagedPtr<VkPhysicalDevicePrivateDataFeaturesEXT> Pointer(this VkPhysicalDevicePrivateDataFeaturesEXT i) => new ManagedPtr<VkPhysicalDevicePrivateDataFeaturesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDevicePrivateDataFeaturesEXT> Pointer(this VkPhysicalDevicePrivateDataFeaturesEXT[] i) => new ManagedPtrArray<VkPhysicalDevicePrivateDataFeaturesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDevicePrivateDataCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public uint privateDataSlotRequestCount;
		}

        public static ManagedPtr<VkDevicePrivateDataCreateInfoEXT> Pointer(this VkDevicePrivateDataCreateInfoEXT i) => new ManagedPtr<VkDevicePrivateDataCreateInfoEXT>(i);
        public static ManagedPtrArray<VkDevicePrivateDataCreateInfoEXT> Pointer(this VkDevicePrivateDataCreateInfoEXT[] i) => new ManagedPtrArray<VkDevicePrivateDataCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPrivateDataSlotCreateInfoEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkPrivateDataSlotCreateFlagsEXT flags;
		}

        public static ManagedPtr<VkPrivateDataSlotCreateInfoEXT> Pointer(this VkPrivateDataSlotCreateInfoEXT i) => new ManagedPtr<VkPrivateDataSlotCreateInfoEXT>(i);
        public static ManagedPtrArray<VkPrivateDataSlotCreateInfoEXT> Pointer(this VkPrivateDataSlotCreateInfoEXT[] i) => new ManagedPtrArray<VkPrivateDataSlotCreateInfoEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDevicePipelineCreationCacheControlFeaturesEXT {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool pipelineCreationCacheControl;
		}

        public static ManagedPtr<VkPhysicalDevicePipelineCreationCacheControlFeaturesEXT> Pointer(this VkPhysicalDevicePipelineCreationCacheControlFeaturesEXT i) => new ManagedPtr<VkPhysicalDevicePipelineCreationCacheControlFeaturesEXT>(i);
        public static ManagedPtrArray<VkPhysicalDevicePipelineCreationCacheControlFeaturesEXT> Pointer(this VkPhysicalDevicePipelineCreationCacheControlFeaturesEXT[] i) => new ManagedPtrArray<VkPhysicalDevicePipelineCreationCacheControlFeaturesEXT>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPhysicalDeviceDiagnosticsConfigFeaturesNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public bool diagnosticsConfig;
		}

        public static ManagedPtr<VkPhysicalDeviceDiagnosticsConfigFeaturesNV> Pointer(this VkPhysicalDeviceDiagnosticsConfigFeaturesNV i) => new ManagedPtr<VkPhysicalDeviceDiagnosticsConfigFeaturesNV>(i);
        public static ManagedPtrArray<VkPhysicalDeviceDiagnosticsConfigFeaturesNV> Pointer(this VkPhysicalDeviceDiagnosticsConfigFeaturesNV[] i) => new ManagedPtrArray<VkPhysicalDeviceDiagnosticsConfigFeaturesNV>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkDeviceDiagnosticsConfigCreateInfoNV {
			[FieldOffset(0)]public VkStructureType sType;
			[FieldOffset(8)]public IntPtr pNext;
			[FieldOffset(16)]public VkDeviceDiagnosticsConfigFlagsNV flags;
		}

        public static ManagedPtr<VkDeviceDiagnosticsConfigCreateInfoNV> Pointer(this VkDeviceDiagnosticsConfigCreateInfoNV i) => new ManagedPtr<VkDeviceDiagnosticsConfigCreateInfoNV>(i);
        public static ManagedPtrArray<VkDeviceDiagnosticsConfigCreateInfoNV> Pointer(this VkDeviceDiagnosticsConfigCreateInfoNV[] i) => new ManagedPtrArray<VkDeviceDiagnosticsConfigCreateInfoNV>(i);
	}
}
