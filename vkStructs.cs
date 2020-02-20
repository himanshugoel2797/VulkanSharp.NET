using System;
using System.Runtime.InteropServices;
namespace VulkanSharp.Raw {
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
	public unsafe struct VkWin32SurfaceCreateInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(24)]public IntPtr hinstance;
		[FieldOffset(32)]public IntPtr hwnd;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
	public unsafe struct VkImportMemoryWin32HandleInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkExternalMemoryHandleTypeFlagBits handleType;
		[FieldOffset(24)]public IntPtr handle;
		[FieldOffset(32)]public string name;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
	public unsafe struct VkExportMemoryWin32HandleInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr* pAttributes;
		[FieldOffset(24)]public uint dwAccess;
		[FieldOffset(32)]public string name;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
	public unsafe struct VkMemoryWin32HandlePropertiesKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint memoryTypeBits;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
	public unsafe struct VkMemoryGetWin32HandleInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr memory;
		[FieldOffset(24)]public VkExternalMemoryHandleTypeFlagBits handleType;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
	public unsafe struct VkExportSemaphoreWin32HandleInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr* pAttributes;
		[FieldOffset(24)]public uint dwAccess;
		[FieldOffset(32)]public string name;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkD3D12FenceSubmitInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint waitSemaphoreValuesCount;
		[FieldOffset(24)]public ulong* pWaitSemaphoreValues;
		[FieldOffset(32)]public uint signalSemaphoreValuesCount;
		[FieldOffset(40)]public ulong* pSignalSemaphoreValues;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
	public unsafe struct VkSemaphoreGetWin32HandleInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr semaphore;
		[FieldOffset(24)]public VkExternalSemaphoreHandleTypeFlagBits handleType;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
	public unsafe struct VkExportFenceWin32HandleInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr* pAttributes;
		[FieldOffset(24)]public uint dwAccess;
		[FieldOffset(32)]public string name;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
	public unsafe struct VkFenceGetWin32HandleInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr fence;
		[FieldOffset(24)]public VkExternalFenceHandleTypeFlagBits handleType;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
	public unsafe struct VkImportMemoryWin32HandleInfoNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint handleType;
		[FieldOffset(24)]public IntPtr handle;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
	public unsafe struct VkExportMemoryWin32HandleInfoNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr* pAttributes;
		[FieldOffset(24)]public uint dwAccess;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSurfaceFullScreenExclusiveInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkFullScreenExclusiveEXT fullScreenExclusive;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSurfaceCapabilitiesFullScreenExclusiveEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint fullScreenExclusiveSupported;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
	public unsafe struct VkSurfaceFullScreenExclusiveWin32InfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr hmonitor;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkWaylandSurfaceCreateInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(24)]public IntPtr display;
		[FieldOffset(32)]public IntPtr surface;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkXlibSurfaceCreateInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(24)]public IntPtr dpy;
		[FieldOffset(32)]public IntPtr window;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkInstanceCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkApplicationInfo[] pApplicationInfo;
		[FieldOffset(32)]public uint enabledLayerCount;
		[FieldOffset(40)][MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.LPStr)]public string[] ppEnabledLayerNames;
		[FieldOffset(48)]public uint enabledExtensionCount;
		[FieldOffset(56)][MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.LPStr)]public string[] ppEnabledExtensionNames;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkAllocationCallbacks {
		[FieldOffset(0)]public IntPtr pUserData;
		[FieldOffset(8)]public IntPtr pfnAllocation;
		[FieldOffset(16)]public IntPtr pfnReallocation;
		[FieldOffset(24)]public IntPtr pfnFree;
		[FieldOffset(32)]public IntPtr pfnInternalAllocation;
		[FieldOffset(40)]public IntPtr pfnInternalFree;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkFormatProperties {
		[FieldOffset(0)]public uint linearTilingFeatures;
		[FieldOffset(4)]public uint optimalTilingFeatures;
		[FieldOffset(8)]public uint bufferFeatures;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkExtent3D {
		[FieldOffset(0)]public uint width;
		[FieldOffset(4)]public uint height;
		[FieldOffset(8)]public uint depth;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImageFormatProperties {
		[FieldOffset(0)]public VkExtent3D maxExtent;
		[FieldOffset(12)]public uint maxMipLevels;
		[FieldOffset(16)]public uint maxArrayLayers;
		[FieldOffset(20)]public uint sampleCounts;
		[FieldOffset(24)]public ulong maxResourceSize;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceSparseProperties {
		[FieldOffset(0)]public uint residencyStandard2DBlockShape;
		[FieldOffset(4)]public uint residencyStandard2DMultisampleBlockShape;
		[FieldOffset(8)]public uint residencyStandard3DBlockShape;
		[FieldOffset(12)]public uint residencyAlignedMipSize;
		[FieldOffset(16)]public uint residencyNonResidentStrict;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkQueueFamilyProperties {
		[FieldOffset(0)]public uint queueFlags;
		[FieldOffset(4)]public uint queueCount;
		[FieldOffset(8)]public uint timestampValidBits;
		[FieldOffset(12)]public VkExtent3D minImageTransferGranularity;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkMemoryType {
		[FieldOffset(0)]public uint propertyFlags;
		[FieldOffset(4)]public uint heapIndex;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkMemoryHeap {
		[FieldOffset(0)]public ulong size;
		[FieldOffset(8)]public uint flags;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceMemoryProperties {
		[FieldOffset(0)]public uint memoryTypeCount;
		[FieldOffset(8)][MarshalAs(UnmanagedType.ByValArray, SizeConst=32)] public VkMemoryType[] memoryTypes;
		[FieldOffset(264)]public uint memoryHeapCount;
		[FieldOffset(276)][MarshalAs(UnmanagedType.ByValArray, SizeConst=16)] public VkMemoryHeap[] memoryHeaps;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDeviceQueueCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint queueFamilyIndex;
		[FieldOffset(24)]public uint queueCount;
		[FieldOffset(32)]public float* pQueuePriorities;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDeviceCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint queueCreateInfoCount;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkDeviceQueueCreateInfo[] pQueueCreateInfos;
		[FieldOffset(32)]public uint enabledLayerCount;
		[FieldOffset(40)][MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.LPStr)]public string[] ppEnabledLayerNames;
		[FieldOffset(48)]public uint enabledExtensionCount;
		[FieldOffset(56)][MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.LPStr)]public string[] ppEnabledExtensionNames;
		[FieldOffset(64)][MarshalAs(UnmanagedType.ByValArray)]public VkPhysicalDeviceFeatures[] pEnabledFeatures;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkExtensionProperties {
		[FieldOffset(0)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] extensionName;
		[FieldOffset(256)]public uint specVersion;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkLayerProperties {
		[FieldOffset(0)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] layerName;
		[FieldOffset(256)]public uint specVersion;
		[FieldOffset(260)]public uint implementationVersion;
		[FieldOffset(264)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] description;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkMemoryAllocateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public ulong allocationSize;
		[FieldOffset(24)]public uint memoryTypeIndex;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkMappedMemoryRange {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr memory;
		[FieldOffset(24)]public ulong offset;
		[FieldOffset(32)]public ulong size;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkMemoryRequirements {
		[FieldOffset(0)]public ulong size;
		[FieldOffset(8)]public ulong alignment;
		[FieldOffset(16)]public uint memoryTypeBits;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSparseImageFormatProperties {
		[FieldOffset(0)]public uint aspectMask;
		[FieldOffset(12)]public VkExtent3D imageGranularity;
		[FieldOffset(24)]public uint flags;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSparseImageMemoryRequirements {
		[FieldOffset(0)]public VkSparseImageFormatProperties formatProperties;
		[FieldOffset(28)]public uint imageMipTailFirstLod;
		[FieldOffset(32)]public ulong imageMipTailSize;
		[FieldOffset(40)]public ulong imageMipTailOffset;
		[FieldOffset(48)]public ulong imageMipTailStride;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSparseMemoryBind {
		[FieldOffset(0)]public ulong resourceOffset;
		[FieldOffset(8)]public ulong size;
		[FieldOffset(16)]public IntPtr memory;
		[FieldOffset(24)]public ulong memoryOffset;
		[FieldOffset(32)]public uint flags;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSparseBufferMemoryBindInfo {
		[FieldOffset(0)]public IntPtr buffer;
		[FieldOffset(8)]public uint bindCount;
		[FieldOffset(16)][MarshalAs(UnmanagedType.ByValArray)]public VkSparseMemoryBind[] pBinds;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSparseImageOpaqueMemoryBindInfo {
		[FieldOffset(0)]public IntPtr image;
		[FieldOffset(8)]public uint bindCount;
		[FieldOffset(16)][MarshalAs(UnmanagedType.ByValArray)]public VkSparseMemoryBind[] pBinds;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImageSubresource {
		[FieldOffset(0)]public uint aspectMask;
		[FieldOffset(4)]public uint mipLevel;
		[FieldOffset(8)]public uint arrayLayer;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkOffset3D {
		[FieldOffset(0)]public int x;
		[FieldOffset(4)]public int y;
		[FieldOffset(8)]public int z;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSparseImageMemoryBind {
		[FieldOffset(0)]public VkImageSubresource subresource;
		[FieldOffset(12)]public VkOffset3D offset;
		[FieldOffset(24)]public VkExtent3D extent;
		[FieldOffset(40)]public IntPtr memory;
		[FieldOffset(48)]public ulong memoryOffset;
		[FieldOffset(56)]public uint flags;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSparseImageMemoryBindInfo {
		[FieldOffset(0)]public IntPtr image;
		[FieldOffset(8)]public uint bindCount;
		[FieldOffset(16)][MarshalAs(UnmanagedType.ByValArray)]public VkSparseImageMemoryBind[] pBinds;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkBindSparseInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint waitSemaphoreCount;
		[FieldOffset(24)]public IntPtr* pWaitSemaphores;
		[FieldOffset(32)]public uint bufferBindCount;
		[FieldOffset(40)][MarshalAs(UnmanagedType.ByValArray)]public VkSparseBufferMemoryBindInfo[] pBufferBinds;
		[FieldOffset(48)]public uint imageOpaqueBindCount;
		[FieldOffset(56)][MarshalAs(UnmanagedType.ByValArray)]public VkSparseImageOpaqueMemoryBindInfo[] pImageOpaqueBinds;
		[FieldOffset(64)]public uint imageBindCount;
		[FieldOffset(72)][MarshalAs(UnmanagedType.ByValArray)]public VkSparseImageMemoryBindInfo[] pImageBinds;
		[FieldOffset(80)]public uint signalSemaphoreCount;
		[FieldOffset(88)]public IntPtr* pSignalSemaphores;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkFenceCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSemaphoreCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkEventCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkQueryPoolCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public VkQueryType queryType;
		[FieldOffset(24)]public uint queryCount;
		[FieldOffset(28)]public uint pipelineStatistics;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSubresourceLayout {
		[FieldOffset(0)]public ulong offset;
		[FieldOffset(8)]public ulong size;
		[FieldOffset(16)]public ulong rowPitch;
		[FieldOffset(24)]public ulong arrayPitch;
		[FieldOffset(32)]public ulong depthPitch;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkComponentMapping {
		[FieldOffset(0)]public VkComponentSwizzle r;
		[FieldOffset(4)]public VkComponentSwizzle g;
		[FieldOffset(8)]public VkComponentSwizzle b;
		[FieldOffset(12)]public VkComponentSwizzle a;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImageSubresourceRange {
		[FieldOffset(0)]public uint aspectMask;
		[FieldOffset(4)]public uint baseMipLevel;
		[FieldOffset(8)]public uint levelCount;
		[FieldOffset(12)]public uint baseArrayLayer;
		[FieldOffset(16)]public uint layerCount;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkShaderModuleCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(24)]public ulong codeSize;
		[FieldOffset(32)]public uint* pCode;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineCacheCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(24)]public ulong initialDataSize;
		[FieldOffset(32)]public IntPtr pInitialData;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSpecializationMapEntry {
		[FieldOffset(0)]public uint constantID;
		[FieldOffset(4)]public uint offset;
		[FieldOffset(8)]public ulong size;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSpecializationInfo {
		[FieldOffset(0)]public uint mapEntryCount;
		[FieldOffset(8)][MarshalAs(UnmanagedType.ByValArray)]public VkSpecializationMapEntry[] pMapEntries;
		[FieldOffset(16)]public ulong dataSize;
		[FieldOffset(24)]public IntPtr pData;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineShaderStageCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public VkShaderStageFlagBits stage;
		[FieldOffset(24)]public IntPtr module;
		[FieldOffset(32)]public string pName;
		[FieldOffset(40)][MarshalAs(UnmanagedType.ByValArray)]public VkSpecializationInfo[] pSpecializationInfo;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkVertexInputBindingDescription {
		[FieldOffset(0)]public uint binding;
		[FieldOffset(4)]public uint stride;
		[FieldOffset(8)]public VkVertexInputRate inputRate;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkVertexInputAttributeDescription {
		[FieldOffset(0)]public uint location;
		[FieldOffset(4)]public uint binding;
		[FieldOffset(8)]public VkFormat format;
		[FieldOffset(12)]public uint offset;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineVertexInputStateCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint vertexBindingDescriptionCount;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkVertexInputBindingDescription[] pVertexBindingDescriptions;
		[FieldOffset(32)]public uint vertexAttributeDescriptionCount;
		[FieldOffset(40)][MarshalAs(UnmanagedType.ByValArray)]public VkVertexInputAttributeDescription[] pVertexAttributeDescriptions;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineInputAssemblyStateCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public VkPrimitiveTopology topology;
		[FieldOffset(24)]public uint primitiveRestartEnable;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineTessellationStateCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint patchControlPoints;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkViewport {
		[FieldOffset(0)]public float x;
		[FieldOffset(4)]public float y;
		[FieldOffset(8)]public float width;
		[FieldOffset(12)]public float height;
		[FieldOffset(16)]public float minDepth;
		[FieldOffset(20)]public float maxDepth;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkOffset2D {
		[FieldOffset(0)]public int x;
		[FieldOffset(4)]public int y;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkExtent2D {
		[FieldOffset(0)]public uint width;
		[FieldOffset(4)]public uint height;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkRect2D {
		[FieldOffset(0)]public VkOffset2D offset;
		[FieldOffset(8)]public VkExtent2D extent;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineViewportStateCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint viewportCount;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkViewport[] pViewports;
		[FieldOffset(32)]public uint scissorCount;
		[FieldOffset(40)][MarshalAs(UnmanagedType.ByValArray)]public VkRect2D[] pScissors;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineColorBlendStateCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint logicOpEnable;
		[FieldOffset(24)]public VkLogicOp logicOp;
		[FieldOffset(28)]public uint attachmentCount;
		[FieldOffset(32)][MarshalAs(UnmanagedType.ByValArray)]public VkPipelineColorBlendAttachmentState[] pAttachments;
		[FieldOffset(40)][MarshalAs(UnmanagedType.ByValArray, SizeConst=4)] public float[] blendConstants;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineDynamicStateCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint dynamicStateCount;
		[FieldOffset(24)]public VkDynamicState* pDynamicStates;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkGraphicsPipelineCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint stageCount;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkPipelineShaderStageCreateInfo[] pStages;
		[FieldOffset(32)][MarshalAs(UnmanagedType.ByValArray)]public VkPipelineVertexInputStateCreateInfo[] pVertexInputState;
		[FieldOffset(40)][MarshalAs(UnmanagedType.ByValArray)]public VkPipelineInputAssemblyStateCreateInfo[] pInputAssemblyState;
		[FieldOffset(48)][MarshalAs(UnmanagedType.ByValArray)]public VkPipelineTessellationStateCreateInfo[] pTessellationState;
		[FieldOffset(56)][MarshalAs(UnmanagedType.ByValArray)]public VkPipelineViewportStateCreateInfo[] pViewportState;
		[FieldOffset(64)][MarshalAs(UnmanagedType.ByValArray)]public VkPipelineRasterizationStateCreateInfo[] pRasterizationState;
		[FieldOffset(72)][MarshalAs(UnmanagedType.ByValArray)]public VkPipelineMultisampleStateCreateInfo[] pMultisampleState;
		[FieldOffset(80)][MarshalAs(UnmanagedType.ByValArray)]public VkPipelineDepthStencilStateCreateInfo[] pDepthStencilState;
		[FieldOffset(88)][MarshalAs(UnmanagedType.ByValArray)]public VkPipelineColorBlendStateCreateInfo[] pColorBlendState;
		[FieldOffset(96)][MarshalAs(UnmanagedType.ByValArray)]public VkPipelineDynamicStateCreateInfo[] pDynamicState;
		[FieldOffset(104)]public IntPtr layout;
		[FieldOffset(112)]public IntPtr renderPass;
		[FieldOffset(120)]public uint subpass;
		[FieldOffset(128)]public IntPtr basePipelineHandle;
		[FieldOffset(136)]public int basePipelineIndex;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPushConstantRange {
		[FieldOffset(0)]public uint stageFlags;
		[FieldOffset(4)]public uint offset;
		[FieldOffset(8)]public uint size;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineLayoutCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint setLayoutCount;
		[FieldOffset(24)]public IntPtr* pSetLayouts;
		[FieldOffset(32)]public uint pushConstantRangeCount;
		[FieldOffset(40)][MarshalAs(UnmanagedType.ByValArray)]public VkPushConstantRange[] pPushConstantRanges;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDescriptorSetLayoutBinding {
		[FieldOffset(0)]public uint binding;
		[FieldOffset(4)]public VkDescriptorType descriptorType;
		[FieldOffset(8)]public uint descriptorCount;
		[FieldOffset(12)]public uint stageFlags;
		[FieldOffset(16)]public IntPtr* pImmutableSamplers;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDescriptorSetLayoutCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint bindingCount;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkDescriptorSetLayoutBinding[] pBindings;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDescriptorPoolSize {
		[FieldOffset(0)]public VkDescriptorType type;
		[FieldOffset(4)]public uint descriptorCount;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDescriptorPoolCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint maxSets;
		[FieldOffset(24)]public uint poolSizeCount;
		[FieldOffset(32)][MarshalAs(UnmanagedType.ByValArray)]public VkDescriptorPoolSize[] pPoolSizes;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDescriptorSetAllocateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr descriptorPool;
		[FieldOffset(24)]public uint descriptorSetCount;
		[FieldOffset(32)]public IntPtr* pSetLayouts;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDescriptorImageInfo {
		[FieldOffset(0)]public IntPtr sampler;
		[FieldOffset(8)]public IntPtr imageView;
		[FieldOffset(16)]public VkImageLayout imageLayout;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDescriptorBufferInfo {
		[FieldOffset(0)]public IntPtr buffer;
		[FieldOffset(8)]public ulong offset;
		[FieldOffset(16)]public ulong range;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkWriteDescriptorSet {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr dstSet;
		[FieldOffset(24)]public uint dstBinding;
		[FieldOffset(28)]public uint dstArrayElement;
		[FieldOffset(32)]public uint descriptorCount;
		[FieldOffset(36)]public VkDescriptorType descriptorType;
		[FieldOffset(40)][MarshalAs(UnmanagedType.ByValArray)]public VkDescriptorImageInfo[] pImageInfo;
		[FieldOffset(48)][MarshalAs(UnmanagedType.ByValArray)]public VkDescriptorBufferInfo[] pBufferInfo;
		[FieldOffset(56)]public IntPtr* pTexelBufferView;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkAttachmentReference {
		[FieldOffset(0)]public uint attachment;
		[FieldOffset(4)]public VkImageLayout layout;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSubpassDescription {
		[FieldOffset(0)]public uint flags;
		[FieldOffset(4)]public VkPipelineBindPoint pipelineBindPoint;
		[FieldOffset(8)]public uint inputAttachmentCount;
		[FieldOffset(16)][MarshalAs(UnmanagedType.ByValArray)]public VkAttachmentReference[] pInputAttachments;
		[FieldOffset(24)]public uint colorAttachmentCount;
		[FieldOffset(32)][MarshalAs(UnmanagedType.ByValArray)]public VkAttachmentReference[] pColorAttachments;
		[FieldOffset(40)][MarshalAs(UnmanagedType.ByValArray)]public VkAttachmentReference[] pResolveAttachments;
		[FieldOffset(48)][MarshalAs(UnmanagedType.ByValArray)]public VkAttachmentReference[] pDepthStencilAttachment;
		[FieldOffset(56)]public uint preserveAttachmentCount;
		[FieldOffset(64)]public uint* pPreserveAttachments;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkRenderPassCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint attachmentCount;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkAttachmentDescription[] pAttachments;
		[FieldOffset(32)]public uint subpassCount;
		[FieldOffset(40)][MarshalAs(UnmanagedType.ByValArray)]public VkSubpassDescription[] pSubpasses;
		[FieldOffset(48)]public uint dependencyCount;
		[FieldOffset(56)][MarshalAs(UnmanagedType.ByValArray)]public VkSubpassDependency[] pDependencies;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkCommandPoolCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint queueFamilyIndex;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkCommandBufferAllocateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr commandPool;
		[FieldOffset(24)]public VkCommandBufferLevel level;
		[FieldOffset(28)]public uint commandBufferCount;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkCommandBufferBeginInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkCommandBufferInheritanceInfo[] pInheritanceInfo;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkBufferCopy {
		[FieldOffset(0)]public ulong srcOffset;
		[FieldOffset(8)]public ulong dstOffset;
		[FieldOffset(16)]public ulong size;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImageSubresourceLayers {
		[FieldOffset(0)]public uint aspectMask;
		[FieldOffset(4)]public uint mipLevel;
		[FieldOffset(8)]public uint baseArrayLayer;
		[FieldOffset(12)]public uint layerCount;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImageCopy {
		[FieldOffset(0)]public VkImageSubresourceLayers srcSubresource;
		[FieldOffset(24)]public VkOffset3D srcOffset;
		[FieldOffset(48)]public VkImageSubresourceLayers dstSubresource;
		[FieldOffset(72)]public VkOffset3D dstOffset;
		[FieldOffset(84)]public VkExtent3D extent;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImageBlit {
		[FieldOffset(0)]public VkImageSubresourceLayers srcSubresource;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray, SizeConst=2)] public VkOffset3D[] srcOffsets;
		[FieldOffset(48)]public VkImageSubresourceLayers dstSubresource;
		[FieldOffset(72)][MarshalAs(UnmanagedType.ByValArray, SizeConst=2)] public VkOffset3D[] dstOffsets;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkBufferImageCopy {
		[FieldOffset(0)]public ulong bufferOffset;
		[FieldOffset(8)]public uint bufferRowLength;
		[FieldOffset(12)]public uint bufferImageHeight;
		[FieldOffset(16)]public VkImageSubresourceLayers imageSubresource;
		[FieldOffset(36)]public VkOffset3D imageOffset;
		[FieldOffset(48)]public VkExtent3D imageExtent;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkClearDepthStencilValue {
		[FieldOffset(0)]public float depth;
		[FieldOffset(4)]public uint stencil;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkClearAttachment {
		[FieldOffset(0)]public uint aspectMask;
		[FieldOffset(4)]public uint colorAttachment;
		[FieldOffset(8)]public VkClearValue clearValue;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkClearRect {
		[FieldOffset(0)]public VkRect2D rect;
		[FieldOffset(16)]public uint baseArrayLayer;
		[FieldOffset(20)]public uint layerCount;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImageResolve {
		[FieldOffset(0)]public VkImageSubresourceLayers srcSubresource;
		[FieldOffset(24)]public VkOffset3D srcOffset;
		[FieldOffset(48)]public VkImageSubresourceLayers dstSubresource;
		[FieldOffset(72)]public VkOffset3D dstOffset;
		[FieldOffset(84)]public VkExtent3D extent;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkMemoryBarrier {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint srcAccessMask;
		[FieldOffset(20)]public uint dstAccessMask;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkRenderPassBeginInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr renderPass;
		[FieldOffset(24)]public IntPtr framebuffer;
		[FieldOffset(32)]public VkRect2D renderArea;
		[FieldOffset(48)]public uint clearValueCount;
		[FieldOffset(56)][MarshalAs(UnmanagedType.ByValArray)]public VkClearValue[] pClearValues;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDispatchIndirectCommand {
		[FieldOffset(0)]public uint x;
		[FieldOffset(4)]public uint y;
		[FieldOffset(8)]public uint z;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDrawIndexedIndirectCommand {
		[FieldOffset(0)]public uint indexCount;
		[FieldOffset(4)]public uint instanceCount;
		[FieldOffset(8)]public uint firstIndex;
		[FieldOffset(12)]public int vertexOffset;
		[FieldOffset(16)]public uint firstInstance;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDrawIndirectCommand {
		[FieldOffset(0)]public uint vertexCount;
		[FieldOffset(4)]public uint instanceCount;
		[FieldOffset(8)]public uint firstVertex;
		[FieldOffset(12)]public uint firstInstance;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkBaseOutStructure {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkBaseInStructure {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceSubgroupProperties {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint subgroupSize;
		[FieldOffset(20)]public uint supportedStages;
		[FieldOffset(24)]public uint supportedOperations;
		[FieldOffset(28)]public uint quadOperationsInAllStages;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkBindBufferMemoryInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr buffer;
		[FieldOffset(24)]public IntPtr memory;
		[FieldOffset(32)]public ulong memoryOffset;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkBindImageMemoryInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr image;
		[FieldOffset(24)]public IntPtr memory;
		[FieldOffset(32)]public ulong memoryOffset;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDevice16BitStorageFeatures {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint storageBuffer16BitAccess;
		[FieldOffset(20)]public uint uniformAndStorageBuffer16BitAccess;
		[FieldOffset(24)]public uint storagePushConstant16;
		[FieldOffset(28)]public uint storageInputOutput16;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkMemoryDedicatedRequirements {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint prefersDedicatedAllocation;
		[FieldOffset(20)]public uint requiresDedicatedAllocation;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkMemoryDedicatedAllocateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr image;
		[FieldOffset(24)]public IntPtr buffer;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkMemoryAllocateFlagsInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint deviceMask;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDeviceGroupRenderPassBeginInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint deviceMask;
		[FieldOffset(20)]public uint deviceRenderAreaCount;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkRect2D[] pDeviceRenderAreas;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDeviceGroupCommandBufferBeginInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint deviceMask;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDeviceGroupBindSparseInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint resourceDeviceIndex;
		[FieldOffset(20)]public uint memoryDeviceIndex;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkBindBufferMemoryDeviceGroupInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint deviceIndexCount;
		[FieldOffset(24)]public uint* pDeviceIndices;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkBindImageMemoryDeviceGroupInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint deviceIndexCount;
		[FieldOffset(24)]public uint* pDeviceIndices;
		[FieldOffset(32)]public uint splitInstanceBindRegionCount;
		[FieldOffset(40)][MarshalAs(UnmanagedType.ByValArray)]public VkRect2D[] pSplitInstanceBindRegions;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceGroupProperties {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint physicalDeviceCount;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray, SizeConst=32)] public IntPtr[] physicalDevices;
		[FieldOffset(280)]public uint subsetAllocation;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDeviceGroupDeviceCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint physicalDeviceCount;
		[FieldOffset(24)]public IntPtr* pPhysicalDevices;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkBufferMemoryRequirementsInfo2 {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr buffer;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImageMemoryRequirementsInfo2 {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr image;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImageSparseMemoryRequirementsInfo2 {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr image;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkMemoryRequirements2 {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(20)]public VkMemoryRequirements memoryRequirements;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSparseImageMemoryRequirements2 {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(56)]public VkSparseImageMemoryRequirements memoryRequirements;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceFeatures2 {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(220)]public VkPhysicalDeviceFeatures features;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceProperties2 {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(1040)]public VkPhysicalDeviceProperties properties;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkFormatProperties2 {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(24)]public VkFormatProperties formatProperties;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImageFormatProperties2 {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(32)]public VkImageFormatProperties imageFormatProperties;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkQueueFamilyProperties2 {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(24)]public VkQueueFamilyProperties queueFamilyProperties;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceMemoryProperties2 {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(468)]public VkPhysicalDeviceMemoryProperties memoryProperties;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSparseImageFormatProperties2 {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(28)]public VkSparseImageFormatProperties properties;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDevicePointClippingProperties {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkPointClippingBehavior pointClippingBehavior;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkInputAttachmentAspectReference {
		[FieldOffset(0)]public uint subpass;
		[FieldOffset(4)]public uint inputAttachmentIndex;
		[FieldOffset(8)]public uint aspectMask;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkRenderPassInputAttachmentAspectCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint aspectReferenceCount;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkInputAttachmentAspectReference[] pAspectReferences;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImageViewUsageCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint usage;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineTessellationDomainOriginStateCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkTessellationDomainOrigin domainOrigin;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceMultiviewFeatures {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint multiview;
		[FieldOffset(20)]public uint multiviewGeometryShader;
		[FieldOffset(24)]public uint multiviewTessellationShader;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceMultiviewProperties {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint maxMultiviewViewCount;
		[FieldOffset(20)]public uint maxMultiviewInstanceIndex;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceVariablePointersFeatures {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint variablePointersStorageBuffer;
		[FieldOffset(20)]public uint variablePointers;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceProtectedMemoryFeatures {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint protectedMemory;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceProtectedMemoryProperties {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint protectedNoFault;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDeviceQueueInfo2 {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint queueFamilyIndex;
		[FieldOffset(24)]public uint queueIndex;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkProtectedSubmitInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint protectedSubmit;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSamplerYcbcrConversionInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr conversion;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkBindImagePlaneMemoryInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkImageAspectFlagBits planeAspect;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImagePlaneMemoryRequirementsInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkImageAspectFlagBits planeAspect;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceSamplerYcbcrConversionFeatures {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint samplerYcbcrConversion;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSamplerYcbcrConversionImageFormatProperties {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint combinedImageSamplerDescriptorCount;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDescriptorUpdateTemplateEntry {
		[FieldOffset(0)]public uint dstBinding;
		[FieldOffset(4)]public uint dstArrayElement;
		[FieldOffset(8)]public uint descriptorCount;
		[FieldOffset(12)]public VkDescriptorType descriptorType;
		[FieldOffset(16)]public ulong offset;
		[FieldOffset(24)]public ulong stride;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDescriptorUpdateTemplateCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint descriptorUpdateEntryCount;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkDescriptorUpdateTemplateEntry[] pDescriptorUpdateEntries;
		[FieldOffset(32)]public VkDescriptorUpdateTemplateType templateType;
		[FieldOffset(40)]public IntPtr descriptorSetLayout;
		[FieldOffset(48)]public VkPipelineBindPoint pipelineBindPoint;
		[FieldOffset(56)]public IntPtr pipelineLayout;
		[FieldOffset(64)]public uint set;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkExternalMemoryProperties {
		[FieldOffset(0)]public uint externalMemoryFeatures;
		[FieldOffset(4)]public uint exportFromImportedHandleTypes;
		[FieldOffset(8)]public uint compatibleHandleTypes;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceExternalImageFormatInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkExternalMemoryHandleTypeFlagBits handleType;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkExternalImageFormatProperties {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(24)]public VkExternalMemoryProperties externalMemoryProperties;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceExternalBufferInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint usage;
		[FieldOffset(24)]public VkExternalMemoryHandleTypeFlagBits handleType;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkExternalBufferProperties {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(24)]public VkExternalMemoryProperties externalMemoryProperties;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkExternalMemoryImageCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint handleTypes;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkExternalMemoryBufferCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint handleTypes;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkExportMemoryAllocateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint handleTypes;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceExternalFenceInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkExternalFenceHandleTypeFlagBits handleType;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkExternalFenceProperties {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint exportFromImportedHandleTypes;
		[FieldOffset(20)]public uint compatibleHandleTypes;
		[FieldOffset(24)]public uint externalFenceFeatures;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkExportFenceCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint handleTypes;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkExportSemaphoreCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint handleTypes;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceExternalSemaphoreInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkExternalSemaphoreHandleTypeFlagBits handleType;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkExternalSemaphoreProperties {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint exportFromImportedHandleTypes;
		[FieldOffset(20)]public uint compatibleHandleTypes;
		[FieldOffset(24)]public uint externalSemaphoreFeatures;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceMaintenance3Properties {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint maxPerSetDescriptors;
		[FieldOffset(24)]public ulong maxMemoryAllocationSize;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDescriptorSetLayoutSupport {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint supported;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceShaderDrawParametersFeatures {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint shaderDrawParameters;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkConformanceVersion {
		[FieldOffset(0)]public byte major;
		[FieldOffset(1)]public byte minor;
		[FieldOffset(2)]public byte subminor;
		[FieldOffset(3)]public byte patch;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImageFormatListCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint viewFormatCount;
		[FieldOffset(24)]public VkFormat* pViewFormats;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkAttachmentReference2 {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint attachment;
		[FieldOffset(20)]public VkImageLayout layout;
		[FieldOffset(24)]public uint aspectMask;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSubpassDescription2 {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public VkPipelineBindPoint pipelineBindPoint;
		[FieldOffset(24)]public uint viewMask;
		[FieldOffset(28)]public uint inputAttachmentCount;
		[FieldOffset(32)][MarshalAs(UnmanagedType.ByValArray)]public VkAttachmentReference2[] pInputAttachments;
		[FieldOffset(40)]public uint colorAttachmentCount;
		[FieldOffset(48)][MarshalAs(UnmanagedType.ByValArray)]public VkAttachmentReference2[] pColorAttachments;
		[FieldOffset(56)][MarshalAs(UnmanagedType.ByValArray)]public VkAttachmentReference2[] pResolveAttachments;
		[FieldOffset(64)][MarshalAs(UnmanagedType.ByValArray)]public VkAttachmentReference2[] pDepthStencilAttachment;
		[FieldOffset(72)]public uint preserveAttachmentCount;
		[FieldOffset(80)]public uint* pPreserveAttachments;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkRenderPassCreateInfo2 {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint attachmentCount;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkAttachmentDescription2[] pAttachments;
		[FieldOffset(32)]public uint subpassCount;
		[FieldOffset(40)][MarshalAs(UnmanagedType.ByValArray)]public VkSubpassDescription2[] pSubpasses;
		[FieldOffset(48)]public uint dependencyCount;
		[FieldOffset(56)][MarshalAs(UnmanagedType.ByValArray)]public VkSubpassDependency2[] pDependencies;
		[FieldOffset(64)]public uint correlatedViewMaskCount;
		[FieldOffset(72)]public uint* pCorrelatedViewMasks;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSubpassBeginInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkSubpassContents contents;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSubpassEndInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDevice8BitStorageFeatures {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint storageBuffer8BitAccess;
		[FieldOffset(20)]public uint uniformAndStorageBuffer8BitAccess;
		[FieldOffset(24)]public uint storagePushConstant8;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceDriverProperties {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkDriverId driverID;
		[FieldOffset(20)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] driverName;
		[FieldOffset(276)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] driverInfo;
		[FieldOffset(532)]public VkConformanceVersion conformanceVersion;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceShaderAtomicInt64Features {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint shaderBufferInt64Atomics;
		[FieldOffset(20)]public uint shaderSharedInt64Atomics;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceShaderFloat16Int8Features {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint shaderFloat16;
		[FieldOffset(20)]public uint shaderInt8;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDescriptorSetLayoutBindingFlagsCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint bindingCount;
		[FieldOffset(24)]public uint* pBindingFlags;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint descriptorSetCount;
		[FieldOffset(24)]public uint* pDescriptorCounts;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDescriptorSetVariableDescriptorCountLayoutSupport {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint maxVariableDescriptorCount;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSubpassDescriptionDepthStencilResolve {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkResolveModeFlagBits depthResolveMode;
		[FieldOffset(20)]public VkResolveModeFlagBits stencilResolveMode;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkAttachmentReference2[] pDepthStencilResolveAttachment;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceDepthStencilResolveProperties {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint supportedDepthResolveModes;
		[FieldOffset(20)]public uint supportedStencilResolveModes;
		[FieldOffset(24)]public uint independentResolveNone;
		[FieldOffset(28)]public uint independentResolve;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceScalarBlockLayoutFeatures {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint scalarBlockLayout;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImageStencilUsageCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint stencilUsage;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSamplerReductionModeCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkSamplerReductionMode reductionMode;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceSamplerFilterMinmaxProperties {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint filterMinmaxSingleComponentFormats;
		[FieldOffset(20)]public uint filterMinmaxImageComponentMapping;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceVulkanMemoryModelFeatures {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint vulkanMemoryModel;
		[FieldOffset(20)]public uint vulkanMemoryModelDeviceScope;
		[FieldOffset(24)]public uint vulkanMemoryModelAvailabilityVisibilityChains;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceImagelessFramebufferFeatures {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint imagelessFramebuffer;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkFramebufferAttachmentsCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint attachmentImageInfoCount;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkFramebufferAttachmentImageInfo[] pAttachmentImageInfos;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkRenderPassAttachmentBeginInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint attachmentCount;
		[FieldOffset(24)]public IntPtr* pAttachments;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceUniformBufferStandardLayoutFeatures {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint uniformBufferStandardLayout;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint shaderSubgroupExtendedTypes;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint separateDepthStencilLayouts;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkAttachmentReferenceStencilLayout {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkImageLayout stencilLayout;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkAttachmentDescriptionStencilLayout {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkImageLayout stencilInitialLayout;
		[FieldOffset(20)]public VkImageLayout stencilFinalLayout;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceHostQueryResetFeatures {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint hostQueryReset;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceTimelineSemaphoreFeatures {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint timelineSemaphore;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceTimelineSemaphoreProperties {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public ulong maxTimelineSemaphoreValueDifference;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSemaphoreTypeCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkSemaphoreType semaphoreType;
		[FieldOffset(24)]public ulong initialValue;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkTimelineSemaphoreSubmitInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint waitSemaphoreValueCount;
		[FieldOffset(24)]public ulong* pWaitSemaphoreValues;
		[FieldOffset(32)]public uint signalSemaphoreValueCount;
		[FieldOffset(40)]public ulong* pSignalSemaphoreValues;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSemaphoreWaitInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint semaphoreCount;
		[FieldOffset(24)]public IntPtr* pSemaphores;
		[FieldOffset(32)]public ulong* pValues;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSemaphoreSignalInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr semaphore;
		[FieldOffset(24)]public ulong value;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeatures {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint bufferDeviceAddress;
		[FieldOffset(20)]public uint bufferDeviceAddressCaptureReplay;
		[FieldOffset(24)]public uint bufferDeviceAddressMultiDevice;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkBufferDeviceAddressInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr buffer;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkBufferOpaqueCaptureAddressCreateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public ulong opaqueCaptureAddress;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkMemoryOpaqueCaptureAddressAllocateInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public ulong opaqueCaptureAddress;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDeviceMemoryOpaqueCaptureAddressInfo {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr memory;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSurfaceFormatKHR {
		[FieldOffset(0)]public VkFormat format;
		[FieldOffset(4)]public VkColorSpaceKHR colorSpace;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImageSwapchainCreateInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr swapchain;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkBindImageMemorySwapchainInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr swapchain;
		[FieldOffset(24)]public uint imageIndex;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDeviceGroupPresentCapabilitiesKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)][MarshalAs(UnmanagedType.ByValArray, SizeConst=32)] public uint[] presentMask;
		[FieldOffset(144)]public uint modes;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDeviceGroupPresentInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint swapchainCount;
		[FieldOffset(24)]public uint* pDeviceMasks;
		[FieldOffset(32)]public VkDeviceGroupPresentModeFlagBitsKHR mode;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDeviceGroupSwapchainCreateInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint modes;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDisplayModeParametersKHR {
		[FieldOffset(0)]public VkExtent2D visibleRegion;
		[FieldOffset(8)]public uint refreshRate;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDisplayModePropertiesKHR {
		[FieldOffset(0)]public IntPtr displayMode;
		[FieldOffset(12)]public VkDisplayModeParametersKHR parameters;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDisplayModeCreateInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(24)]public VkDisplayModeParametersKHR parameters;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDisplayPlanePropertiesKHR {
		[FieldOffset(0)]public IntPtr currentDisplay;
		[FieldOffset(8)]public uint currentStackIndex;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDisplayPresentInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkRect2D srcRect;
		[FieldOffset(32)]public VkRect2D dstRect;
		[FieldOffset(48)]public uint persistent;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImportMemoryFdInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkExternalMemoryHandleTypeFlagBits handleType;
		[FieldOffset(20)]public int fd;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkMemoryFdPropertiesKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint memoryTypeBits;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkMemoryGetFdInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr memory;
		[FieldOffset(24)]public VkExternalMemoryHandleTypeFlagBits handleType;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImportSemaphoreFdInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr semaphore;
		[FieldOffset(24)]public uint flags;
		[FieldOffset(28)]public VkExternalSemaphoreHandleTypeFlagBits handleType;
		[FieldOffset(32)]public int fd;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSemaphoreGetFdInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr semaphore;
		[FieldOffset(24)]public VkExternalSemaphoreHandleTypeFlagBits handleType;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDevicePushDescriptorPropertiesKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint maxPushDescriptors;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkRectLayerKHR {
		[FieldOffset(0)]public VkOffset2D offset;
		[FieldOffset(8)]public VkExtent2D extent;
		[FieldOffset(16)]public uint layer;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPresentRegionKHR {
		[FieldOffset(0)]public uint rectangleCount;
		[FieldOffset(8)][MarshalAs(UnmanagedType.ByValArray)]public VkRectLayerKHR[] pRectangles;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPresentRegionsKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint swapchainCount;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkPresentRegionKHR[] pRegions;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSharedPresentSurfaceCapabilitiesKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint sharedPresentSupportedUsageFlags;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImportFenceFdInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr fence;
		[FieldOffset(24)]public uint flags;
		[FieldOffset(28)]public VkExternalFenceHandleTypeFlagBits handleType;
		[FieldOffset(32)]public int fd;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkFenceGetFdInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr fence;
		[FieldOffset(24)]public VkExternalFenceHandleTypeFlagBits handleType;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDevicePerformanceQueryFeaturesKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint performanceCounterQueryPools;
		[FieldOffset(20)]public uint performanceCounterMultipleQueryPools;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDevicePerformanceQueryPropertiesKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint allowCommandBufferQueryCopies;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPerformanceCounterKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkPerformanceCounterUnitKHR unit;
		[FieldOffset(20)]public VkPerformanceCounterScopeKHR scope;
		[FieldOffset(24)]public VkPerformanceCounterStorageKHR storage;
		[FieldOffset(28)]public fixed byte uuid[16];
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPerformanceCounterDescriptionKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] name;
		[FieldOffset(276)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] category;
		[FieldOffset(532)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] description;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkQueryPoolPerformanceCreateInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint queueFamilyIndex;
		[FieldOffset(20)]public uint counterIndexCount;
		[FieldOffset(24)]public uint* pCounterIndices;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkAcquireProfilingLockInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(24)]public ulong timeout;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPerformanceQuerySubmitInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint counterPassIndex;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceSurfaceInfo2KHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr surface;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSurfaceCapabilities2KHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(52)]public VkSurfaceCapabilitiesKHR surfaceCapabilities;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSurfaceFormat2KHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkSurfaceFormatKHR surfaceFormat;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDisplayProperties2KHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(44)]public VkDisplayPropertiesKHR displayProperties;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDisplayPlaneProperties2KHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(24)]public VkDisplayPlanePropertiesKHR displayPlaneProperties;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDisplayModeProperties2KHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(24)]public VkDisplayModePropertiesKHR displayModeProperties;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDisplayPlaneInfo2KHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr mode;
		[FieldOffset(24)]public uint planeIndex;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDisplayPlaneCapabilities2KHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(72)]public VkDisplayPlaneCapabilitiesKHR capabilities;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceShaderClockFeaturesKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint shaderSubgroupClock;
		[FieldOffset(20)]public uint shaderDeviceClock;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSurfaceProtectedCapabilitiesKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint supportsProtected;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint pipelineExecutableInfo;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr pipeline;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineExecutablePropertiesKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint stages;
		[FieldOffset(20)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] name;
		[FieldOffset(276)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] description;
		[FieldOffset(532)]public uint subgroupSize;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineExecutableInfoKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr pipeline;
		[FieldOffset(24)]public uint executableIndex;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineExecutableStatisticKHR {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] name;
		[FieldOffset(272)][MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] public char[] description;
		[FieldOffset(528)]public VkPipelineExecutableStatisticFormatKHR format;
		[FieldOffset(536)]public VkPipelineExecutableStatisticValueKHR value;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDebugReportCallbackCreateInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(24)]public IntPtr pfnCallback;
		[FieldOffset(32)]public IntPtr pUserData;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineRasterizationStateRasterizationOrderAMD {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkRasterizationOrderAMD rasterizationOrder;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDebugMarkerObjectNameInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkDebugReportObjectTypeEXT objectType;
		[FieldOffset(24)]public ulong @object;
		[FieldOffset(32)]public string pObjectName;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDebugMarkerMarkerInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public string pMarkerName;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray, SizeConst=4)] public float[] color;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDedicatedAllocationImageCreateInfoNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint dedicatedAllocation;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDedicatedAllocationBufferCreateInfoNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint dedicatedAllocation;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDedicatedAllocationMemoryAllocateInfoNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr image;
		[FieldOffset(24)]public IntPtr buffer;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceTransformFeedbackFeaturesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint transformFeedback;
		[FieldOffset(20)]public uint geometryStreams;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineRasterizationStateStreamCreateInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint rasterizationStream;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImageViewHandleInfoNVX {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr imageView;
		[FieldOffset(24)]public VkDescriptorType descriptorType;
		[FieldOffset(32)]public IntPtr sampler;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkTextureLODGatherFormatPropertiesAMD {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint supportsTextureGatherLODBiasAMD;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkShaderResourceUsageAMD {
		[FieldOffset(0)]public uint numUsedVgprs;
		[FieldOffset(4)]public uint numUsedSgprs;
		[FieldOffset(8)]public uint ldsSizePerLocalWorkGroup;
		[FieldOffset(16)]public ulong ldsUsageSizeInBytes;
		[FieldOffset(24)]public ulong scratchMemUsageInBytes;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceCornerSampledImageFeaturesNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint cornerSampledImage;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkExternalImageFormatPropertiesNV {
		[FieldOffset(0)]public VkImageFormatProperties imageFormatProperties;
		[FieldOffset(32)]public uint externalMemoryFeatures;
		[FieldOffset(36)]public uint exportFromImportedHandleTypes;
		[FieldOffset(40)]public uint compatibleHandleTypes;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkExternalMemoryImageCreateInfoNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint handleTypes;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkExportMemoryAllocateInfoNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint handleTypes;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkValidationFlagsEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint disabledValidationCheckCount;
		[FieldOffset(24)]public VkValidationCheckEXT* pDisabledValidationChecks;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint textureCompressionASTC_HDR;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImageViewASTCDecodeModeEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkFormat decodeMode;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceASTCDecodeFeaturesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint decodeModeSharedExponent;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkConditionalRenderingBeginInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr buffer;
		[FieldOffset(24)]public ulong offset;
		[FieldOffset(32)]public uint flags;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceConditionalRenderingFeaturesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint conditionalRendering;
		[FieldOffset(20)]public uint inheritedConditionalRendering;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkCommandBufferInheritanceConditionalRenderingInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint conditionalRenderingEnable;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDeviceGeneratedCommandsFeaturesNVX {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint computeBindingPointSupport;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkIndirectCommandsTokenNVX {
		[FieldOffset(0)]public VkIndirectCommandsTokenTypeNVX tokenType;
		[FieldOffset(8)]public IntPtr buffer;
		[FieldOffset(16)]public ulong offset;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkIndirectCommandsLayoutTokenNVX {
		[FieldOffset(0)]public VkIndirectCommandsTokenTypeNVX tokenType;
		[FieldOffset(4)]public uint bindingUnit;
		[FieldOffset(8)]public uint dynamicCount;
		[FieldOffset(12)]public uint divisor;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkIndirectCommandsLayoutCreateInfoNVX {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkPipelineBindPoint pipelineBindPoint;
		[FieldOffset(20)]public uint flags;
		[FieldOffset(24)]public uint tokenCount;
		[FieldOffset(32)][MarshalAs(UnmanagedType.ByValArray)]public VkIndirectCommandsLayoutTokenNVX[] pTokens;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkCmdProcessCommandsInfoNVX {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr objectTable;
		[FieldOffset(24)]public IntPtr indirectCommandsLayout;
		[FieldOffset(32)]public uint indirectCommandsTokenCount;
		[FieldOffset(40)][MarshalAs(UnmanagedType.ByValArray)]public VkIndirectCommandsTokenNVX[] pIndirectCommandsTokens;
		[FieldOffset(48)]public uint maxSequencesCount;
		[FieldOffset(56)]public IntPtr targetCommandBuffer;
		[FieldOffset(64)]public IntPtr sequencesCountBuffer;
		[FieldOffset(72)]public ulong sequencesCountOffset;
		[FieldOffset(80)]public IntPtr sequencesIndexBuffer;
		[FieldOffset(88)]public ulong sequencesIndexOffset;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkCmdReserveSpaceForCommandsInfoNVX {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr objectTable;
		[FieldOffset(24)]public IntPtr indirectCommandsLayout;
		[FieldOffset(32)]public uint maxSequencesCount;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkObjectTableEntryNVX {
		[FieldOffset(0)]public VkObjectEntryTypeNVX type;
		[FieldOffset(4)]public uint flags;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkObjectTablePipelineEntryNVX {
		[FieldOffset(0)]public VkObjectEntryTypeNVX type;
		[FieldOffset(4)]public uint flags;
		[FieldOffset(8)]public IntPtr pipeline;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkObjectTableDescriptorSetEntryNVX {
		[FieldOffset(0)]public VkObjectEntryTypeNVX type;
		[FieldOffset(4)]public uint flags;
		[FieldOffset(8)]public IntPtr pipelineLayout;
		[FieldOffset(16)]public IntPtr descriptorSet;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkObjectTableVertexBufferEntryNVX {
		[FieldOffset(0)]public VkObjectEntryTypeNVX type;
		[FieldOffset(4)]public uint flags;
		[FieldOffset(8)]public IntPtr buffer;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkObjectTableIndexBufferEntryNVX {
		[FieldOffset(0)]public VkObjectEntryTypeNVX type;
		[FieldOffset(4)]public uint flags;
		[FieldOffset(8)]public IntPtr buffer;
		[FieldOffset(16)]public VkIndexType indexType;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkObjectTablePushConstantEntryNVX {
		[FieldOffset(0)]public VkObjectEntryTypeNVX type;
		[FieldOffset(4)]public uint flags;
		[FieldOffset(8)]public IntPtr pipelineLayout;
		[FieldOffset(16)]public uint stageFlags;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkViewportWScalingNV {
		[FieldOffset(0)]public float xcoeff;
		[FieldOffset(4)]public float ycoeff;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineViewportWScalingStateCreateInfoNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint viewportWScalingEnable;
		[FieldOffset(20)]public uint viewportCount;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkViewportWScalingNV[] pViewportWScalings;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDisplayPowerInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkDisplayPowerStateEXT powerState;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDeviceEventInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkDeviceEventTypeEXT deviceEvent;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDisplayEventInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkDisplayEventTypeEXT displayEvent;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSwapchainCounterCreateInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint surfaceCounters;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkRefreshCycleDurationGOOGLE {
		[FieldOffset(0)]public ulong refreshDuration;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPastPresentationTimingGOOGLE {
		[FieldOffset(0)]public uint presentID;
		[FieldOffset(8)]public ulong desiredPresentTime;
		[FieldOffset(16)]public ulong actualPresentTime;
		[FieldOffset(24)]public ulong earliestPresentTime;
		[FieldOffset(32)]public ulong presentMargin;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPresentTimeGOOGLE {
		[FieldOffset(0)]public uint presentID;
		[FieldOffset(8)]public ulong desiredPresentTime;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPresentTimesInfoGOOGLE {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint swapchainCount;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkPresentTimeGOOGLE[] pTimes;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint perViewPositionAllComponents;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkViewportSwizzleNV {
		[FieldOffset(0)]public VkViewportCoordinateSwizzleNV x;
		[FieldOffset(4)]public VkViewportCoordinateSwizzleNV y;
		[FieldOffset(8)]public VkViewportCoordinateSwizzleNV z;
		[FieldOffset(12)]public VkViewportCoordinateSwizzleNV w;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineViewportSwizzleStateCreateInfoNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint viewportCount;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkViewportSwizzleNV[] pViewportSwizzles;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceDiscardRectanglePropertiesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint maxDiscardRectangles;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineDiscardRectangleStateCreateInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public VkDiscardRectangleModeEXT discardRectangleMode;
		[FieldOffset(24)]public uint discardRectangleCount;
		[FieldOffset(32)][MarshalAs(UnmanagedType.ByValArray)]public VkRect2D[] pDiscardRectangles;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineRasterizationConservativeStateCreateInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public VkConservativeRasterizationModeEXT conservativeRasterizationMode;
		[FieldOffset(24)]public float extraPrimitiveOverestimationSize;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceDepthClipEnableFeaturesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint depthClipEnable;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineRasterizationDepthClipStateCreateInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint depthClipEnable;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkXYColorEXT {
		[FieldOffset(0)]public float x;
		[FieldOffset(4)]public float y;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDebugUtilsObjectNameInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkObjectType objectType;
		[FieldOffset(24)]public ulong objectHandle;
		[FieldOffset(32)]public string pObjectName;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDebugUtilsLabelEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public string pLabelName;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray, SizeConst=4)] public float[] color;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDebugUtilsMessengerCallbackDataEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(24)]public string pMessageIdName;
		[FieldOffset(32)]public int messageIdNumber;
		[FieldOffset(40)]public string pMessage;
		[FieldOffset(48)]public uint queueLabelCount;
		[FieldOffset(56)][MarshalAs(UnmanagedType.ByValArray)]public VkDebugUtilsLabelEXT[] pQueueLabels;
		[FieldOffset(64)]public uint cmdBufLabelCount;
		[FieldOffset(72)][MarshalAs(UnmanagedType.ByValArray)]public VkDebugUtilsLabelEXT[] pCmdBufLabels;
		[FieldOffset(80)]public uint objectCount;
		[FieldOffset(88)][MarshalAs(UnmanagedType.ByValArray)]public VkDebugUtilsObjectNameInfoEXT[] pObjects;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceInlineUniformBlockFeaturesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint inlineUniformBlock;
		[FieldOffset(20)]public uint descriptorBindingInlineUniformBlockUpdateAfterBind;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkWriteDescriptorSetInlineUniformBlockEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint dataSize;
		[FieldOffset(24)]public IntPtr pData;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDescriptorPoolInlineUniformBlockCreateInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint maxInlineUniformBlockBindings;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSampleLocationEXT {
		[FieldOffset(0)]public float x;
		[FieldOffset(4)]public float y;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSampleLocationsInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkSampleCountFlagBits sampleLocationsPerPixel;
		[FieldOffset(24)]public VkExtent2D sampleLocationGridSize;
		[FieldOffset(32)]public uint sampleLocationsCount;
		[FieldOffset(40)][MarshalAs(UnmanagedType.ByValArray)]public VkSampleLocationEXT[] pSampleLocations;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkAttachmentSampleLocationsEXT {
		[FieldOffset(0)]public uint attachmentIndex;
		[FieldOffset(48)]public VkSampleLocationsInfoEXT sampleLocationsInfo;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSubpassSampleLocationsEXT {
		[FieldOffset(0)]public uint subpassIndex;
		[FieldOffset(48)]public VkSampleLocationsInfoEXT sampleLocationsInfo;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkRenderPassSampleLocationsBeginInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint attachmentInitialSampleLocationsCount;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkAttachmentSampleLocationsEXT[] pAttachmentInitialSampleLocations;
		[FieldOffset(32)]public uint postSubpassSampleLocationsCount;
		[FieldOffset(40)][MarshalAs(UnmanagedType.ByValArray)]public VkSubpassSampleLocationsEXT[] pPostSubpassSampleLocations;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineSampleLocationsStateCreateInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint sampleLocationsEnable;
		[FieldOffset(48)]public VkSampleLocationsInfoEXT sampleLocationsInfo;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkMultisamplePropertiesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkExtent2D maxSampleLocationGridSize;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint advancedBlendCoherentOperations;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineColorBlendAdvancedStateCreateInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint srcPremultiplied;
		[FieldOffset(20)]public uint dstPremultiplied;
		[FieldOffset(24)]public VkBlendOverlapEXT blendOverlap;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineCoverageToColorStateCreateInfoNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint coverageToColorEnable;
		[FieldOffset(24)]public uint coverageToColorLocation;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceShaderSMBuiltinsPropertiesNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint shaderSMCount;
		[FieldOffset(20)]public uint shaderWarpsPerSM;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceShaderSMBuiltinsFeaturesNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint shaderSMBuiltins;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDrmFormatModifierPropertiesEXT {
		[FieldOffset(0)]public ulong drmFormatModifier;
		[FieldOffset(8)]public uint drmFormatModifierPlaneCount;
		[FieldOffset(12)]public uint drmFormatModifierTilingFeatures;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDrmFormatModifierPropertiesListEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint drmFormatModifierCount;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkDrmFormatModifierPropertiesEXT[] pDrmFormatModifierProperties;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public ulong drmFormatModifier;
		[FieldOffset(24)]public VkSharingMode sharingMode;
		[FieldOffset(28)]public uint queueFamilyIndexCount;
		[FieldOffset(32)]public uint* pQueueFamilyIndices;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImageDrmFormatModifierListCreateInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint drmFormatModifierCount;
		[FieldOffset(24)]public ulong* pDrmFormatModifiers;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImageDrmFormatModifierExplicitCreateInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public ulong drmFormatModifier;
		[FieldOffset(24)]public uint drmFormatModifierPlaneCount;
		[FieldOffset(32)][MarshalAs(UnmanagedType.ByValArray)]public VkSubresourceLayout[] pPlaneLayouts;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImageDrmFormatModifierPropertiesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public ulong drmFormatModifier;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkValidationCacheCreateInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(24)]public ulong initialDataSize;
		[FieldOffset(32)]public IntPtr pInitialData;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkShaderModuleValidationCacheCreateInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr validationCache;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkShadingRatePaletteNV {
		[FieldOffset(0)]public uint shadingRatePaletteEntryCount;
		[FieldOffset(8)]public VkShadingRatePaletteEntryNV* pShadingRatePaletteEntries;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineViewportShadingRateImageStateCreateInfoNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint shadingRateImageEnable;
		[FieldOffset(20)]public uint viewportCount;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkShadingRatePaletteNV[] pShadingRatePalettes;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceShadingRateImageFeaturesNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint shadingRateImage;
		[FieldOffset(20)]public uint shadingRateCoarseSampleOrder;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceShadingRateImagePropertiesNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkExtent2D shadingRateTexelSize;
		[FieldOffset(24)]public uint shadingRatePaletteSize;
		[FieldOffset(28)]public uint shadingRateMaxCoarseSamples;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkCoarseSampleLocationNV {
		[FieldOffset(0)]public uint pixelX;
		[FieldOffset(4)]public uint pixelY;
		[FieldOffset(8)]public uint sample;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkCoarseSampleOrderCustomNV {
		[FieldOffset(0)]public VkShadingRatePaletteEntryNV shadingRate;
		[FieldOffset(4)]public uint sampleCount;
		[FieldOffset(8)]public uint sampleLocationCount;
		[FieldOffset(16)][MarshalAs(UnmanagedType.ByValArray)]public VkCoarseSampleLocationNV[] pSampleLocations;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkCoarseSampleOrderTypeNV sampleOrderType;
		[FieldOffset(20)]public uint customSampleOrderCount;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkCoarseSampleOrderCustomNV[] pCustomSampleOrders;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkRayTracingPipelineCreateInfoNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public uint stageCount;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkPipelineShaderStageCreateInfo[] pStages;
		[FieldOffset(32)]public uint groupCount;
		[FieldOffset(40)][MarshalAs(UnmanagedType.ByValArray)]public VkRayTracingShaderGroupCreateInfoNV[] pGroups;
		[FieldOffset(48)]public uint maxRecursionDepth;
		[FieldOffset(56)]public IntPtr layout;
		[FieldOffset(64)]public IntPtr basePipelineHandle;
		[FieldOffset(72)]public int basePipelineIndex;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkGeometryAABBNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr aabbData;
		[FieldOffset(24)]public uint numAABBs;
		[FieldOffset(28)]public uint stride;
		[FieldOffset(32)]public ulong offset;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkGeometryDataNV {
		[FieldOffset(0)]public VkGeometryTrianglesNV triangles;
		[FieldOffset(120)]public VkGeometryAABBNV aabbs;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkGeometryNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkGeometryTypeNV geometryType;
		[FieldOffset(160)]public VkGeometryDataNV geometry;
		[FieldOffset(320)]public uint flags;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkAccelerationStructureInfoNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkAccelerationStructureTypeNV type;
		[FieldOffset(20)]public uint flags;
		[FieldOffset(24)]public uint instanceCount;
		[FieldOffset(28)]public uint geometryCount;
		[FieldOffset(32)][MarshalAs(UnmanagedType.ByValArray)]public VkGeometryNV[] pGeometries;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkAccelerationStructureCreateInfoNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public ulong compactedSize;
		[FieldOffset(40)]public VkAccelerationStructureInfoNV info;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkWriteDescriptorSetAccelerationStructureNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint accelerationStructureCount;
		[FieldOffset(24)]public IntPtr* pAccelerationStructures;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkAccelerationStructureMemoryRequirementsInfoNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkAccelerationStructureMemoryRequirementsTypeNV type;
		[FieldOffset(24)]public IntPtr accelerationStructure;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint representativeFragmentTest;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint representativeFragmentTestEnable;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceImageViewImageFormatInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkImageViewType imageViewType;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkFilterCubicImageViewImageFormatPropertiesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint filterCubic;
		[FieldOffset(20)]public uint filterCubicMinmax;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDeviceQueueGlobalPriorityCreateInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkQueueGlobalPriorityEXT globalPriority;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkImportMemoryHostPointerInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkExternalMemoryHandleTypeFlagBits handleType;
		[FieldOffset(24)]public IntPtr pHostPointer;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkMemoryHostPointerPropertiesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint memoryTypeBits;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public ulong minImportedHostPointerAlignment;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineCompilerControlCreateInfoAMD {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint compilerControlFlags;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkCalibratedTimestampInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkTimeDomainEXT timeDomain;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDeviceMemoryOverallocationCreateInfoAMD {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkMemoryOverallocationBehaviorAMD overallocationBehavior;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint maxVertexAttribDivisor;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkVertexInputBindingDivisorDescriptionEXT {
		[FieldOffset(0)]public uint binding;
		[FieldOffset(4)]public uint divisor;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineVertexInputDivisorStateCreateInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint vertexBindingDivisorCount;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkVertexInputBindingDivisorDescriptionEXT[] pVertexBindingDivisors;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint vertexAttributeInstanceRateDivisor;
		[FieldOffset(20)]public uint vertexAttributeInstanceRateZeroDivisor;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineCreationFeedbackEXT {
		[FieldOffset(0)]public uint flags;
		[FieldOffset(8)]public ulong duration;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineCreationFeedbackCreateInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)][MarshalAs(UnmanagedType.ByValArray)]public VkPipelineCreationFeedbackEXT[] pPipelineCreationFeedback;
		[FieldOffset(24)]public uint pipelineStageCreationFeedbackCount;
		[FieldOffset(32)][MarshalAs(UnmanagedType.ByValArray)]public VkPipelineCreationFeedbackEXT[] pPipelineStageCreationFeedbacks;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceComputeShaderDerivativesFeaturesNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint computeDerivativeGroupQuads;
		[FieldOffset(20)]public uint computeDerivativeGroupLinear;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceMeshShaderFeaturesNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint taskShader;
		[FieldOffset(20)]public uint meshShader;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDrawMeshTasksIndirectCommandNV {
		[FieldOffset(0)]public uint taskCount;
		[FieldOffset(4)]public uint firstTask;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint fragmentShaderBarycentric;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceShaderImageFootprintFeaturesNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint imageFootprint;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineViewportExclusiveScissorStateCreateInfoNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint exclusiveScissorCount;
		[FieldOffset(24)][MarshalAs(UnmanagedType.ByValArray)]public VkRect2D[] pExclusiveScissors;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceExclusiveScissorFeaturesNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint exclusiveScissor;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkQueueFamilyCheckpointPropertiesNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint checkpointExecutionStageMask;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkCheckpointDataNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkPipelineStageFlagBits stage;
		[FieldOffset(24)]public IntPtr pCheckpointMarker;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint shaderIntegerFunctions2;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPerformanceValueINTEL {
		[FieldOffset(0)]public VkPerformanceValueTypeINTEL type;
		[FieldOffset(8)]public VkPerformanceValueDataINTEL data;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkInitializePerformanceApiInfoINTEL {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public IntPtr pUserData;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkQueryPoolCreateInfoINTEL {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkQueryPoolSamplingModeINTEL performanceCountersSampling;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPerformanceMarkerInfoINTEL {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public ulong marker;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPerformanceStreamMarkerInfoINTEL {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint marker;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPerformanceOverrideInfoINTEL {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkPerformanceOverrideTypeINTEL type;
		[FieldOffset(20)]public uint enable;
		[FieldOffset(24)]public ulong parameter;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPerformanceConfigurationAcquireInfoINTEL {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkPerformanceConfigurationTypeINTEL type;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDevicePCIBusInfoPropertiesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint pciDomain;
		[FieldOffset(20)]public uint pciBus;
		[FieldOffset(24)]public uint pciDevice;
		[FieldOffset(28)]public uint pciFunction;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkDisplayNativeHdrSurfaceCapabilitiesAMD {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint localDimmingSupport;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkSwapchainDisplayNativeHdrCreateInfoAMD {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint localDimmingEnable;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint fragmentDensityMap;
		[FieldOffset(20)]public uint fragmentDensityMapDynamic;
		[FieldOffset(24)]public uint fragmentDensityMapNonSubsampledImages;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkExtent2D minFragmentDensityTexelSize;
		[FieldOffset(24)]public VkExtent2D maxFragmentDensityTexelSize;
		[FieldOffset(32)]public uint fragmentDensityInvocations;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkRenderPassFragmentDensityMapCreateInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkAttachmentReference fragmentDensityMapAttachment;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceSubgroupSizeControlFeaturesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint subgroupSizeControl;
		[FieldOffset(20)]public uint computeFullSubgroups;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceSubgroupSizeControlPropertiesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint minSubgroupSize;
		[FieldOffset(20)]public uint maxSubgroupSize;
		[FieldOffset(24)]public uint maxComputeWorkgroupSubgroups;
		[FieldOffset(28)]public uint requiredSubgroupSizeStages;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint requiredSubgroupSize;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceShaderCoreProperties2AMD {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint shaderCoreFeatures;
		[FieldOffset(20)]public uint activeComputeUnitCount;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceCoherentMemoryFeaturesAMD {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint deviceCoherentMemory;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceMemoryBudgetPropertiesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)][MarshalAs(UnmanagedType.ByValArray, SizeConst=16)] public ulong[] heapBudget;
		[FieldOffset(144)][MarshalAs(UnmanagedType.ByValArray, SizeConst=16)] public ulong[] heapUsage;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceMemoryPriorityFeaturesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint memoryPriority;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkMemoryPriorityAllocateInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public float priority;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint dedicatedAllocationImageAliasing;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint bufferDeviceAddress;
		[FieldOffset(20)]public uint bufferDeviceAddressCaptureReplay;
		[FieldOffset(24)]public uint bufferDeviceAddressMultiDevice;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkBufferDeviceAddressCreateInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public ulong deviceAddress;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkValidationFeaturesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint enabledValidationFeatureCount;
		[FieldOffset(24)]public VkValidationFeatureEnableEXT* pEnabledValidationFeatures;
		[FieldOffset(32)]public uint disabledValidationFeatureCount;
		[FieldOffset(40)]public VkValidationFeatureDisableEXT* pDisabledValidationFeatures;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceCooperativeMatrixFeaturesNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint cooperativeMatrix;
		[FieldOffset(20)]public uint cooperativeMatrixRobustBufferAccess;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceCooperativeMatrixPropertiesNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint cooperativeMatrixSupportedStages;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceCoverageReductionModeFeaturesNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint coverageReductionMode;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineCoverageReductionStateCreateInfoNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
		[FieldOffset(20)]public VkCoverageReductionModeNV coverageReductionMode;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkFramebufferMixedSamplesCombinationNV {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkCoverageReductionModeNV coverageReductionMode;
		[FieldOffset(20)]public VkSampleCountFlagBits rasterizationSamples;
		[FieldOffset(24)]public uint depthStencilSamples;
		[FieldOffset(28)]public uint colorSamples;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint fragmentShaderSampleInterlock;
		[FieldOffset(20)]public uint fragmentShaderPixelInterlock;
		[FieldOffset(24)]public uint fragmentShaderShadingRateInterlock;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint ycbcrImageArrays;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkHeadlessSurfaceCreateInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint flags;
	}
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
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceLineRasterizationPropertiesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint lineSubPixelPrecisionBits;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPipelineRasterizationLineStateCreateInfoEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public VkLineRasterizationModeEXT lineRasterizationMode;
		[FieldOffset(20)]public uint stippledLineEnable;
		[FieldOffset(24)]public uint lineStippleFactor;
		[FieldOffset(28)]public ushort lineStipplePattern;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceIndexTypeUint8FeaturesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint indexTypeUint8;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint shaderDemoteToHelperInvocation;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public uint texelBufferAlignment;
	}
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public unsafe struct VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT {
		[FieldOffset(0)]public VkStructureType sType;
		[FieldOffset(8)]public IntPtr pNext;
		[FieldOffset(16)]public ulong storageTexelBufferOffsetAlignmentBytes;
		[FieldOffset(24)]public uint storageTexelBufferOffsetSingleTexelAlignment;
		[FieldOffset(32)]public ulong uniformTexelBufferOffsetAlignmentBytes;
		[FieldOffset(40)]public uint uniformTexelBufferOffsetSingleTexelAlignment;
	}
}
