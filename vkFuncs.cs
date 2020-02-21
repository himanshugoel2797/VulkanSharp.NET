using System;
using System.Runtime.InteropServices;
namespace VulkanSharp.Raw {
	public unsafe static partial class Vk {
		public static VkResult vkCreateWin32SurfaceKHR(IntPtr instance, [MarshalAs(UnmanagedType.LPArray)]VkWin32SurfaceCreateInfoKHR[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pSurface) { throw new NotImplementedException(); }
		public static uint vkGetPhysicalDeviceWin32PresentationSupportKHR(IntPtr physicalDevice, uint queueFamilyIndex) { throw new NotImplementedException(); }
		public static VkResult vkGetMemoryWin32HandleKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkMemoryGetWin32HandleInfoKHR[] pGetWin32HandleInfo, IntPtr* pHandle) { throw new NotImplementedException(); }
		public static VkResult vkGetMemoryWin32HandlePropertiesKHR(IntPtr device, VkExternalMemoryHandleTypeFlagBits handleType, IntPtr handle, [MarshalAs(UnmanagedType.LPArray)]VkMemoryWin32HandlePropertiesKHR[] pMemoryWin32HandleProperties) { throw new NotImplementedException(); }
		public static VkResult vkImportSemaphoreWin32HandleKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkImportSemaphoreWin32HandleInfoKHR[] pImportSemaphoreWin32HandleInfo) { throw new NotImplementedException(); }
		public static VkResult vkGetSemaphoreWin32HandleKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkSemaphoreGetWin32HandleInfoKHR[] pGetWin32HandleInfo, IntPtr* pHandle) { throw new NotImplementedException(); }
		public static VkResult vkImportFenceWin32HandleKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkImportFenceWin32HandleInfoKHR[] pImportFenceWin32HandleInfo) { throw new NotImplementedException(); }
		public static VkResult vkGetFenceWin32HandleKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkFenceGetWin32HandleInfoKHR[] pGetWin32HandleInfo, IntPtr* pHandle) { throw new NotImplementedException(); }
		public static VkResult vkGetMemoryWin32HandleNV(IntPtr device, IntPtr memory, uint handleType, IntPtr* pHandle) { throw new NotImplementedException(); }
		public static VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceSurfaceInfo2KHR[] pSurfaceInfo, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes) { throw new NotImplementedException(); }
		public static VkResult vkAcquireFullScreenExclusiveModeEXT(IntPtr device, IntPtr swapchain) { throw new NotImplementedException(); }
		public static VkResult vkReleaseFullScreenExclusiveModeEXT(IntPtr device, IntPtr swapchain) { throw new NotImplementedException(); }
		public static VkResult vkGetDeviceGroupSurfacePresentModes2EXT(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceSurfaceInfo2KHR[] pSurfaceInfo, uint* pModes) { throw new NotImplementedException(); }
		public static VkResult vkCreateWaylandSurfaceKHR(IntPtr instance, [MarshalAs(UnmanagedType.LPArray)]VkWaylandSurfaceCreateInfoKHR[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pSurface) { throw new NotImplementedException(); }
		public static uint vkGetPhysicalDeviceWaylandPresentationSupportKHR(IntPtr physicalDevice, uint queueFamilyIndex, IntPtr display) { throw new NotImplementedException(); }
		public static VkResult vkCreateXlibSurfaceKHR(IntPtr instance, [MarshalAs(UnmanagedType.LPArray)]VkXlibSurfaceCreateInfoKHR[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pSurface) { throw new NotImplementedException(); }
		public static uint vkGetPhysicalDeviceXlibPresentationSupportKHR(IntPtr physicalDevice, uint queueFamilyIndex, IntPtr dpy, IntPtr visualID) { throw new NotImplementedException(); }
		public static VkResult vkCreateInstance([MarshalAs(UnmanagedType.LPArray)]VkInstanceCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pInstance) { throw new NotImplementedException(); }
		public static void vkDestroyInstance(IntPtr instance, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkEnumeratePhysicalDevices(IntPtr instance, uint* pPhysicalDeviceCount, IntPtr* pPhysicalDevices) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceFeatures(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceFeatures[] pFeatures) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceFormatProperties(IntPtr physicalDevice, VkFormat format, [MarshalAs(UnmanagedType.LPArray)]VkFormatProperties[] pFormatProperties) { throw new NotImplementedException(); }
		public static VkResult vkGetPhysicalDeviceImageFormatProperties(IntPtr physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, uint usage, uint flags, [MarshalAs(UnmanagedType.LPArray)]VkImageFormatProperties[] pImageFormatProperties) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceProperties(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceProperties[] pProperties) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceQueueFamilyProperties(IntPtr physicalDevice, uint* pQueueFamilyPropertyCount, [MarshalAs(UnmanagedType.LPArray)]VkQueueFamilyProperties[] pQueueFamilyProperties) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceMemoryProperties(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceMemoryProperties[] pMemoryProperties) { throw new NotImplementedException(); }
		public static IntPtr vkGetInstanceProcAddr(IntPtr instance, string pName) { throw new NotImplementedException(); }
		public static IntPtr vkGetDeviceProcAddr(IntPtr device, string pName) { throw new NotImplementedException(); }
		public static VkResult vkCreateDevice(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkDeviceCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pDevice) { throw new NotImplementedException(); }
		public static void vkDestroyDevice(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkEnumerateInstanceExtensionProperties(string pLayerName, uint* pPropertyCount, [MarshalAs(UnmanagedType.LPArray)]VkExtensionProperties[] pProperties) { throw new NotImplementedException(); }
		public static VkResult vkEnumerateDeviceExtensionProperties(IntPtr physicalDevice, string pLayerName, uint* pPropertyCount, [MarshalAs(UnmanagedType.LPArray)]VkExtensionProperties[] pProperties) { throw new NotImplementedException(); }
		public static VkResult vkEnumerateInstanceLayerProperties(uint* pPropertyCount, [MarshalAs(UnmanagedType.LPArray)]VkLayerProperties[] pProperties) { throw new NotImplementedException(); }
		public static VkResult vkEnumerateDeviceLayerProperties(IntPtr physicalDevice, uint* pPropertyCount, [MarshalAs(UnmanagedType.LPArray)]VkLayerProperties[] pProperties) { throw new NotImplementedException(); }
		public static void vkGetDeviceQueue(IntPtr device, uint queueFamilyIndex, uint queueIndex, IntPtr* pQueue) { throw new NotImplementedException(); }
		public static VkResult vkQueueSubmit(IntPtr queue, uint submitCount, [MarshalAs(UnmanagedType.LPArray)]VkSubmitInfo[] pSubmits, IntPtr fence) { throw new NotImplementedException(); }
		public static VkResult vkQueueWaitIdle(IntPtr queue) { throw new NotImplementedException(); }
		public static VkResult vkDeviceWaitIdle(IntPtr device) { throw new NotImplementedException(); }
		public static VkResult vkAllocateMemory(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkMemoryAllocateInfo[] pAllocateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pMemory) { throw new NotImplementedException(); }
		public static void vkFreeMemory(IntPtr device, IntPtr memory, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkMapMemory(IntPtr device, IntPtr memory, ulong offset, ulong size, uint flags, void** ppData) { throw new NotImplementedException(); }
		public static void vkUnmapMemory(IntPtr device, IntPtr memory) { throw new NotImplementedException(); }
		public static VkResult vkFlushMappedMemoryRanges(IntPtr device, uint memoryRangeCount, [MarshalAs(UnmanagedType.LPArray)]VkMappedMemoryRange[] pMemoryRanges) { throw new NotImplementedException(); }
		public static VkResult vkInvalidateMappedMemoryRanges(IntPtr device, uint memoryRangeCount, [MarshalAs(UnmanagedType.LPArray)]VkMappedMemoryRange[] pMemoryRanges) { throw new NotImplementedException(); }
		public static void vkGetDeviceMemoryCommitment(IntPtr device, IntPtr memory, ulong* pCommittedMemoryInBytes) { throw new NotImplementedException(); }
		public static VkResult vkBindBufferMemory(IntPtr device, IntPtr buffer, IntPtr memory, ulong memoryOffset) { throw new NotImplementedException(); }
		public static VkResult vkBindImageMemory(IntPtr device, IntPtr image, IntPtr memory, ulong memoryOffset) { throw new NotImplementedException(); }
		public static void vkGetBufferMemoryRequirements(IntPtr device, IntPtr buffer, [MarshalAs(UnmanagedType.LPArray)]VkMemoryRequirements[] pMemoryRequirements) { throw new NotImplementedException(); }
		public static void vkGetImageMemoryRequirements(IntPtr device, IntPtr image, [MarshalAs(UnmanagedType.LPArray)]VkMemoryRequirements[] pMemoryRequirements) { throw new NotImplementedException(); }
		public static void vkGetImageSparseMemoryRequirements(IntPtr device, IntPtr image, uint* pSparseMemoryRequirementCount, [MarshalAs(UnmanagedType.LPArray)]VkSparseImageMemoryRequirements[] pSparseMemoryRequirements) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceSparseImageFormatProperties(IntPtr physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, uint usage, VkImageTiling tiling, uint* pPropertyCount, [MarshalAs(UnmanagedType.LPArray)]VkSparseImageFormatProperties[] pProperties) { throw new NotImplementedException(); }
		public static VkResult vkQueueBindSparse(IntPtr queue, uint bindInfoCount, [MarshalAs(UnmanagedType.LPArray)]VkBindSparseInfo[] pBindInfo, IntPtr fence) { throw new NotImplementedException(); }
		public static VkResult vkCreateFence(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkFenceCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pFence) { throw new NotImplementedException(); }
		public static void vkDestroyFence(IntPtr device, IntPtr fence, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkResetFences(IntPtr device, uint fenceCount, IntPtr* pFences) { throw new NotImplementedException(); }
		public static VkResult vkGetFenceStatus(IntPtr device, IntPtr fence) { throw new NotImplementedException(); }
		public static VkResult vkWaitForFences(IntPtr device, uint fenceCount, IntPtr* pFences, uint waitAll, ulong timeout) { throw new NotImplementedException(); }
		public static VkResult vkCreateSemaphore(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkSemaphoreCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pSemaphore) { throw new NotImplementedException(); }
		public static void vkDestroySemaphore(IntPtr device, IntPtr semaphore, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkCreateEvent(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkEventCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pEvent) { throw new NotImplementedException(); }
		public static void vkDestroyEvent(IntPtr device, IntPtr @event, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkGetEventStatus(IntPtr device, IntPtr @event) { throw new NotImplementedException(); }
		public static VkResult vkSetEvent(IntPtr device, IntPtr @event) { throw new NotImplementedException(); }
		public static VkResult vkResetEvent(IntPtr device, IntPtr @event) { throw new NotImplementedException(); }
		public static VkResult vkCreateQueryPool(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkQueryPoolCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pQueryPool) { throw new NotImplementedException(); }
		public static void vkDestroyQueryPool(IntPtr device, IntPtr queryPool, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkGetQueryPoolResults(IntPtr device, IntPtr queryPool, uint firstQuery, uint queryCount, ulong dataSize, IntPtr pData, ulong stride, uint flags) { throw new NotImplementedException(); }
		public static VkResult vkCreateBuffer(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkBufferCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pBuffer) { throw new NotImplementedException(); }
		public static void vkDestroyBuffer(IntPtr device, IntPtr buffer, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkCreateBufferView(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkBufferViewCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pView) { throw new NotImplementedException(); }
		public static void vkDestroyBufferView(IntPtr device, IntPtr bufferView, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkCreateImage(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkImageCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pImage) { throw new NotImplementedException(); }
		public static void vkDestroyImage(IntPtr device, IntPtr image, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static void vkGetImageSubresourceLayout(IntPtr device, IntPtr image, [MarshalAs(UnmanagedType.LPArray)]VkImageSubresource[] pSubresource, [MarshalAs(UnmanagedType.LPArray)]VkSubresourceLayout[] pLayout) { throw new NotImplementedException(); }
		public static VkResult vkCreateImageView(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkImageViewCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pView) { throw new NotImplementedException(); }
		public static void vkDestroyImageView(IntPtr device, IntPtr imageView, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkCreateShaderModule(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkShaderModuleCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pShaderModule) { throw new NotImplementedException(); }
		public static void vkDestroyShaderModule(IntPtr device, IntPtr shaderModule, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkCreatePipelineCache(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkPipelineCacheCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pPipelineCache) { throw new NotImplementedException(); }
		public static void vkDestroyPipelineCache(IntPtr device, IntPtr pipelineCache, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkGetPipelineCacheData(IntPtr device, IntPtr pipelineCache, ulong* pDataSize, IntPtr pData) { throw new NotImplementedException(); }
		public static VkResult vkMergePipelineCaches(IntPtr device, IntPtr dstCache, uint srcCacheCount, IntPtr* pSrcCaches) { throw new NotImplementedException(); }
		public static VkResult vkCreateGraphicsPipelines(IntPtr device, IntPtr pipelineCache, uint createInfoCount, [MarshalAs(UnmanagedType.LPArray)]VkGraphicsPipelineCreateInfo[] pCreateInfos, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pPipelines) { throw new NotImplementedException(); }
		public static VkResult vkCreateComputePipelines(IntPtr device, IntPtr pipelineCache, uint createInfoCount, [MarshalAs(UnmanagedType.LPArray)]VkComputePipelineCreateInfo[] pCreateInfos, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pPipelines) { throw new NotImplementedException(); }
		public static void vkDestroyPipeline(IntPtr device, IntPtr pipeline, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkCreatePipelineLayout(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkPipelineLayoutCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pPipelineLayout) { throw new NotImplementedException(); }
		public static void vkDestroyPipelineLayout(IntPtr device, IntPtr pipelineLayout, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkCreateSampler(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkSamplerCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pSampler) { throw new NotImplementedException(); }
		public static void vkDestroySampler(IntPtr device, IntPtr sampler, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkCreateDescriptorSetLayout(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkDescriptorSetLayoutCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pSetLayout) { throw new NotImplementedException(); }
		public static void vkDestroyDescriptorSetLayout(IntPtr device, IntPtr descriptorSetLayout, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkCreateDescriptorPool(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkDescriptorPoolCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pDescriptorPool) { throw new NotImplementedException(); }
		public static void vkDestroyDescriptorPool(IntPtr device, IntPtr descriptorPool, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkResetDescriptorPool(IntPtr device, IntPtr descriptorPool, uint flags) { throw new NotImplementedException(); }
		public static VkResult vkAllocateDescriptorSets(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkDescriptorSetAllocateInfo[] pAllocateInfo, IntPtr* pDescriptorSets) { throw new NotImplementedException(); }
		public static VkResult vkFreeDescriptorSets(IntPtr device, IntPtr descriptorPool, uint descriptorSetCount, IntPtr* pDescriptorSets) { throw new NotImplementedException(); }
		public static void vkUpdateDescriptorSets(IntPtr device, uint descriptorWriteCount, [MarshalAs(UnmanagedType.LPArray)]VkWriteDescriptorSet[] pDescriptorWrites, uint descriptorCopyCount, [MarshalAs(UnmanagedType.LPArray)]VkCopyDescriptorSet[] pDescriptorCopies) { throw new NotImplementedException(); }
		public static VkResult vkCreateFramebuffer(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkFramebufferCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pFramebuffer) { throw new NotImplementedException(); }
		public static void vkDestroyFramebuffer(IntPtr device, IntPtr framebuffer, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkCreateRenderPass(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkRenderPassCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pRenderPass) { throw new NotImplementedException(); }
		public static void vkDestroyRenderPass(IntPtr device, IntPtr renderPass, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static void vkGetRenderAreaGranularity(IntPtr device, IntPtr renderPass, [MarshalAs(UnmanagedType.LPArray)]VkExtent2D[] pGranularity) { throw new NotImplementedException(); }
		public static VkResult vkCreateCommandPool(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkCommandPoolCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pCommandPool) { throw new NotImplementedException(); }
		public static void vkDestroyCommandPool(IntPtr device, IntPtr commandPool, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkResetCommandPool(IntPtr device, IntPtr commandPool, uint flags) { throw new NotImplementedException(); }
		public static VkResult vkAllocateCommandBuffers(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkCommandBufferAllocateInfo[] pAllocateInfo, IntPtr* pCommandBuffers) { throw new NotImplementedException(); }
		public static void vkFreeCommandBuffers(IntPtr device, IntPtr commandPool, uint commandBufferCount, IntPtr* pCommandBuffers) { throw new NotImplementedException(); }
		public static VkResult vkBeginCommandBuffer(IntPtr commandBuffer, [MarshalAs(UnmanagedType.LPArray)]VkCommandBufferBeginInfo[] pBeginInfo) { throw new NotImplementedException(); }
		public static VkResult vkEndCommandBuffer(IntPtr commandBuffer) { throw new NotImplementedException(); }
		public static VkResult vkResetCommandBuffer(IntPtr commandBuffer, uint flags) { throw new NotImplementedException(); }
		public static void vkCmdBindPipeline(IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, IntPtr pipeline) { throw new NotImplementedException(); }
		public static void vkCmdSetViewport(IntPtr commandBuffer, uint firstViewport, uint viewportCount, [MarshalAs(UnmanagedType.LPArray)]VkViewport[] pViewports) { throw new NotImplementedException(); }
		public static void vkCmdSetScissor(IntPtr commandBuffer, uint firstScissor, uint scissorCount, [MarshalAs(UnmanagedType.LPArray)]VkRect2D[] pScissors) { throw new NotImplementedException(); }
		public static void vkCmdSetLineWidth(IntPtr commandBuffer, float lineWidth) { throw new NotImplementedException(); }
		public static void vkCmdSetDepthBias(IntPtr commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor) { throw new NotImplementedException(); }
		public static void vkCmdSetBlendConstants(IntPtr commandBuffer, [MarshalAs(UnmanagedType.LPArray, SizeConst=4)] float[] blendConstants) { throw new NotImplementedException(); }
		public static void vkCmdSetDepthBounds(IntPtr commandBuffer, float minDepthBounds, float maxDepthBounds) { throw new NotImplementedException(); }
		public static void vkCmdSetStencilCompareMask(IntPtr commandBuffer, uint faceMask, uint compareMask) { throw new NotImplementedException(); }
		public static void vkCmdSetStencilWriteMask(IntPtr commandBuffer, uint faceMask, uint writeMask) { throw new NotImplementedException(); }
		public static void vkCmdSetStencilReference(IntPtr commandBuffer, uint faceMask, uint reference) { throw new NotImplementedException(); }
		public static void vkCmdBindDescriptorSets(IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, IntPtr layout, uint firstSet, uint descriptorSetCount, IntPtr* pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets) { throw new NotImplementedException(); }
		public static void vkCmdBindIndexBuffer(IntPtr commandBuffer, IntPtr buffer, ulong offset, VkIndexType indexType) { throw new NotImplementedException(); }
		public static void vkCmdBindVertexBuffers(IntPtr commandBuffer, uint firstBinding, uint bindingCount, IntPtr* pBuffers, ulong* pOffsets) { throw new NotImplementedException(); }
		public static void vkCmdDraw(IntPtr commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance) { throw new NotImplementedException(); }
		public static void vkCmdDrawIndexed(IntPtr commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance) { throw new NotImplementedException(); }
		public static void vkCmdDrawIndirect(IntPtr commandBuffer, IntPtr buffer, ulong offset, uint drawCount, uint stride) { throw new NotImplementedException(); }
		public static void vkCmdDrawIndexedIndirect(IntPtr commandBuffer, IntPtr buffer, ulong offset, uint drawCount, uint stride) { throw new NotImplementedException(); }
		public static void vkCmdDispatch(IntPtr commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ) { throw new NotImplementedException(); }
		public static void vkCmdDispatchIndirect(IntPtr commandBuffer, IntPtr buffer, ulong offset) { throw new NotImplementedException(); }
		public static void vkCmdCopyBuffer(IntPtr commandBuffer, IntPtr srcBuffer, IntPtr dstBuffer, uint regionCount, [MarshalAs(UnmanagedType.LPArray)]VkBufferCopy[] pRegions) { throw new NotImplementedException(); }
		public static void vkCmdCopyImage(IntPtr commandBuffer, IntPtr srcImage, VkImageLayout srcImageLayout, IntPtr dstImage, VkImageLayout dstImageLayout, uint regionCount, [MarshalAs(UnmanagedType.LPArray)]VkImageCopy[] pRegions) { throw new NotImplementedException(); }
		public static void vkCmdBlitImage(IntPtr commandBuffer, IntPtr srcImage, VkImageLayout srcImageLayout, IntPtr dstImage, VkImageLayout dstImageLayout, uint regionCount, [MarshalAs(UnmanagedType.LPArray)]VkImageBlit[] pRegions, VkFilter filter) { throw new NotImplementedException(); }
		public static void vkCmdCopyBufferToImage(IntPtr commandBuffer, IntPtr srcBuffer, IntPtr dstImage, VkImageLayout dstImageLayout, uint regionCount, [MarshalAs(UnmanagedType.LPArray)]VkBufferImageCopy[] pRegions) { throw new NotImplementedException(); }
		public static void vkCmdCopyImageToBuffer(IntPtr commandBuffer, IntPtr srcImage, VkImageLayout srcImageLayout, IntPtr dstBuffer, uint regionCount, [MarshalAs(UnmanagedType.LPArray)]VkBufferImageCopy[] pRegions) { throw new NotImplementedException(); }
		public static void vkCmdUpdateBuffer(IntPtr commandBuffer, IntPtr dstBuffer, ulong dstOffset, ulong dataSize, IntPtr pData) { throw new NotImplementedException(); }
		public static void vkCmdFillBuffer(IntPtr commandBuffer, IntPtr dstBuffer, ulong dstOffset, ulong size, uint data) { throw new NotImplementedException(); }
		public static void vkCmdClearColorImage(IntPtr commandBuffer, IntPtr image, VkImageLayout imageLayout, [MarshalAs(UnmanagedType.LPArray)]VkClearColorValue[] pColor, uint rangeCount, [MarshalAs(UnmanagedType.LPArray)]VkImageSubresourceRange[] pRanges) { throw new NotImplementedException(); }
		public static void vkCmdClearDepthStencilImage(IntPtr commandBuffer, IntPtr image, VkImageLayout imageLayout, [MarshalAs(UnmanagedType.LPArray)]VkClearDepthStencilValue[] pDepthStencil, uint rangeCount, [MarshalAs(UnmanagedType.LPArray)]VkImageSubresourceRange[] pRanges) { throw new NotImplementedException(); }
		public static void vkCmdClearAttachments(IntPtr commandBuffer, uint attachmentCount, [MarshalAs(UnmanagedType.LPArray)]VkClearAttachment[] pAttachments, uint rectCount, [MarshalAs(UnmanagedType.LPArray)]VkClearRect[] pRects) { throw new NotImplementedException(); }
		public static void vkCmdResolveImage(IntPtr commandBuffer, IntPtr srcImage, VkImageLayout srcImageLayout, IntPtr dstImage, VkImageLayout dstImageLayout, uint regionCount, [MarshalAs(UnmanagedType.LPArray)]VkImageResolve[] pRegions) { throw new NotImplementedException(); }
		public static void vkCmdSetEvent(IntPtr commandBuffer, IntPtr @event, uint stageMask) { throw new NotImplementedException(); }
		public static void vkCmdResetEvent(IntPtr commandBuffer, IntPtr @event, uint stageMask) { throw new NotImplementedException(); }
		public static void vkCmdWaitEvents(IntPtr commandBuffer, uint eventCount, IntPtr* pEvents, uint srcStageMask, uint dstStageMask, uint memoryBarrierCount, [MarshalAs(UnmanagedType.LPArray)]VkMemoryBarrier[] pMemoryBarriers, uint bufferMemoryBarrierCount, [MarshalAs(UnmanagedType.LPArray)]VkBufferMemoryBarrier[] pBufferMemoryBarriers, uint imageMemoryBarrierCount, [MarshalAs(UnmanagedType.LPArray)]VkImageMemoryBarrier[] pImageMemoryBarriers) { throw new NotImplementedException(); }
		public static void vkCmdPipelineBarrier(IntPtr commandBuffer, uint srcStageMask, uint dstStageMask, uint dependencyFlags, uint memoryBarrierCount, [MarshalAs(UnmanagedType.LPArray)]VkMemoryBarrier[] pMemoryBarriers, uint bufferMemoryBarrierCount, [MarshalAs(UnmanagedType.LPArray)]VkBufferMemoryBarrier[] pBufferMemoryBarriers, uint imageMemoryBarrierCount, [MarshalAs(UnmanagedType.LPArray)]VkImageMemoryBarrier[] pImageMemoryBarriers) { throw new NotImplementedException(); }
		public static void vkCmdBeginQuery(IntPtr commandBuffer, IntPtr queryPool, uint query, uint flags) { throw new NotImplementedException(); }
		public static void vkCmdEndQuery(IntPtr commandBuffer, IntPtr queryPool, uint query) { throw new NotImplementedException(); }
		public static void vkCmdResetQueryPool(IntPtr commandBuffer, IntPtr queryPool, uint firstQuery, uint queryCount) { throw new NotImplementedException(); }
		public static void vkCmdWriteTimestamp(IntPtr commandBuffer, VkPipelineStageFlagBits pipelineStage, IntPtr queryPool, uint query) { throw new NotImplementedException(); }
		public static void vkCmdCopyQueryPoolResults(IntPtr commandBuffer, IntPtr queryPool, uint firstQuery, uint queryCount, IntPtr dstBuffer, ulong dstOffset, ulong stride, uint flags) { throw new NotImplementedException(); }
		public static void vkCmdPushConstants(IntPtr commandBuffer, IntPtr layout, uint stageFlags, uint offset, uint size, IntPtr pValues) { throw new NotImplementedException(); }
		public static void vkCmdBeginRenderPass(IntPtr commandBuffer, [MarshalAs(UnmanagedType.LPArray)]VkRenderPassBeginInfo[] pRenderPassBegin, VkSubpassContents contents) { throw new NotImplementedException(); }
		public static void vkCmdNextSubpass(IntPtr commandBuffer, VkSubpassContents contents) { throw new NotImplementedException(); }
		public static void vkCmdEndRenderPass(IntPtr commandBuffer) { throw new NotImplementedException(); }
		public static void vkCmdExecuteCommands(IntPtr commandBuffer, uint commandBufferCount, IntPtr* pCommandBuffers) { throw new NotImplementedException(); }
		public static VkResult vkEnumerateInstanceVersion(uint* pApiVersion) { throw new NotImplementedException(); }
		public static VkResult vkBindBufferMemory2(IntPtr device, uint bindInfoCount, [MarshalAs(UnmanagedType.LPArray)]VkBindBufferMemoryInfo[] pBindInfos) { throw new NotImplementedException(); }
		public static VkResult vkBindImageMemory2(IntPtr device, uint bindInfoCount, [MarshalAs(UnmanagedType.LPArray)]VkBindImageMemoryInfo[] pBindInfos) { throw new NotImplementedException(); }
		public static void vkGetDeviceGroupPeerMemoryFeatures(IntPtr device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, uint* pPeerMemoryFeatures) { throw new NotImplementedException(); }
		public static void vkCmdSetDeviceMask(IntPtr commandBuffer, uint deviceMask) { throw new NotImplementedException(); }
		public static void vkCmdDispatchBase(IntPtr commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ) { throw new NotImplementedException(); }
		public static VkResult vkEnumeratePhysicalDeviceGroups(IntPtr instance, uint* pPhysicalDeviceGroupCount, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceGroupProperties[] pPhysicalDeviceGroupProperties) { throw new NotImplementedException(); }
		public static void vkGetImageMemoryRequirements2(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkImageMemoryRequirementsInfo2[] pInfo, [MarshalAs(UnmanagedType.LPArray)]VkMemoryRequirements2[] pMemoryRequirements) { throw new NotImplementedException(); }
		public static void vkGetBufferMemoryRequirements2(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkBufferMemoryRequirementsInfo2[] pInfo, [MarshalAs(UnmanagedType.LPArray)]VkMemoryRequirements2[] pMemoryRequirements) { throw new NotImplementedException(); }
		public static void vkGetImageSparseMemoryRequirements2(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkImageSparseMemoryRequirementsInfo2[] pInfo, uint* pSparseMemoryRequirementCount, [MarshalAs(UnmanagedType.LPArray)]VkSparseImageMemoryRequirements2[] pSparseMemoryRequirements) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceFeatures2(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceFeatures2[] pFeatures) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceProperties2(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceProperties2[] pProperties) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceFormatProperties2(IntPtr physicalDevice, VkFormat format, [MarshalAs(UnmanagedType.LPArray)]VkFormatProperties2[] pFormatProperties) { throw new NotImplementedException(); }
		public static VkResult vkGetPhysicalDeviceImageFormatProperties2(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceImageFormatInfo2[] pImageFormatInfo, [MarshalAs(UnmanagedType.LPArray)]VkImageFormatProperties2[] pImageFormatProperties) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceQueueFamilyProperties2(IntPtr physicalDevice, uint* pQueueFamilyPropertyCount, [MarshalAs(UnmanagedType.LPArray)]VkQueueFamilyProperties2[] pQueueFamilyProperties) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceMemoryProperties2(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceMemoryProperties2[] pMemoryProperties) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceSparseImageFormatProperties2(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceSparseImageFormatInfo2[] pFormatInfo, uint* pPropertyCount, [MarshalAs(UnmanagedType.LPArray)]VkSparseImageFormatProperties2[] pProperties) { throw new NotImplementedException(); }
		public static void vkTrimCommandPool(IntPtr device, IntPtr commandPool, uint flags) { throw new NotImplementedException(); }
		public static void vkGetDeviceQueue2(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkDeviceQueueInfo2[] pQueueInfo, IntPtr* pQueue) { throw new NotImplementedException(); }
		public static VkResult vkCreateSamplerYcbcrConversion(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkSamplerYcbcrConversionCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pYcbcrConversion) { throw new NotImplementedException(); }
		public static void vkDestroySamplerYcbcrConversion(IntPtr device, IntPtr ycbcrConversion, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkCreateDescriptorUpdateTemplate(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkDescriptorUpdateTemplateCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pDescriptorUpdateTemplate) { throw new NotImplementedException(); }
		public static void vkDestroyDescriptorUpdateTemplate(IntPtr device, IntPtr descriptorUpdateTemplate, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static void vkUpdateDescriptorSetWithTemplate(IntPtr device, IntPtr descriptorSet, IntPtr descriptorUpdateTemplate, IntPtr pData) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceExternalBufferProperties(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceExternalBufferInfo[] pExternalBufferInfo, [MarshalAs(UnmanagedType.LPArray)]VkExternalBufferProperties[] pExternalBufferProperties) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceExternalFenceProperties(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceExternalFenceInfo[] pExternalFenceInfo, [MarshalAs(UnmanagedType.LPArray)]VkExternalFenceProperties[] pExternalFenceProperties) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceExternalSemaphoreProperties(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceExternalSemaphoreInfo[] pExternalSemaphoreInfo, [MarshalAs(UnmanagedType.LPArray)]VkExternalSemaphoreProperties[] pExternalSemaphoreProperties) { throw new NotImplementedException(); }
		public static void vkGetDescriptorSetLayoutSupport(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkDescriptorSetLayoutCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkDescriptorSetLayoutSupport[] pSupport) { throw new NotImplementedException(); }
		public static void vkCmdDrawIndirectCount(IntPtr commandBuffer, IntPtr buffer, ulong offset, IntPtr countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride) { throw new NotImplementedException(); }
		public static void vkCmdDrawIndexedIndirectCount(IntPtr commandBuffer, IntPtr buffer, ulong offset, IntPtr countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride) { throw new NotImplementedException(); }
		public static VkResult vkCreateRenderPass2(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkRenderPassCreateInfo2[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pRenderPass) { throw new NotImplementedException(); }
		public static void vkCmdBeginRenderPass2(IntPtr commandBuffer, [MarshalAs(UnmanagedType.LPArray)]VkRenderPassBeginInfo[] pRenderPassBegin, [MarshalAs(UnmanagedType.LPArray)]VkSubpassBeginInfo[] pSubpassBeginInfo) { throw new NotImplementedException(); }
		public static void vkCmdNextSubpass2(IntPtr commandBuffer, [MarshalAs(UnmanagedType.LPArray)]VkSubpassBeginInfo[] pSubpassBeginInfo, [MarshalAs(UnmanagedType.LPArray)]VkSubpassEndInfo[] pSubpassEndInfo) { throw new NotImplementedException(); }
		public static void vkCmdEndRenderPass2(IntPtr commandBuffer, [MarshalAs(UnmanagedType.LPArray)]VkSubpassEndInfo[] pSubpassEndInfo) { throw new NotImplementedException(); }
		public static void vkResetQueryPool(IntPtr device, IntPtr queryPool, uint firstQuery, uint queryCount) { throw new NotImplementedException(); }
		public static VkResult vkGetSemaphoreCounterValue(IntPtr device, IntPtr semaphore, ulong* pValue) { throw new NotImplementedException(); }
		public static VkResult vkWaitSemaphores(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkSemaphoreWaitInfo[] pWaitInfo, ulong timeout) { throw new NotImplementedException(); }
		public static VkResult vkSignalSemaphore(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkSemaphoreSignalInfo[] pSignalInfo) { throw new NotImplementedException(); }
		public static ulong vkGetBufferDeviceAddress(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkBufferDeviceAddressInfo[] pInfo) { throw new NotImplementedException(); }
		public static ulong vkGetBufferOpaqueCaptureAddress(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkBufferDeviceAddressInfo[] pInfo) { throw new NotImplementedException(); }
		public static ulong vkGetDeviceMemoryOpaqueCaptureAddress(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkDeviceMemoryOpaqueCaptureAddressInfo[] pInfo) { throw new NotImplementedException(); }
		public static void vkDestroySurfaceKHR(IntPtr instance, IntPtr surface, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkGetPhysicalDeviceSurfaceSupportKHR(IntPtr physicalDevice, uint queueFamilyIndex, IntPtr surface, uint* pSupported) { throw new NotImplementedException(); }
		public static VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR(IntPtr physicalDevice, IntPtr surface, [MarshalAs(UnmanagedType.LPArray)]VkSurfaceCapabilitiesKHR[] pSurfaceCapabilities) { throw new NotImplementedException(); }
		public static VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(IntPtr physicalDevice, IntPtr surface, uint* pSurfaceFormatCount, [MarshalAs(UnmanagedType.LPArray)]VkSurfaceFormatKHR[] pSurfaceFormats) { throw new NotImplementedException(); }
		public static VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(IntPtr physicalDevice, IntPtr surface, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes) { throw new NotImplementedException(); }
		public static VkResult vkCreateSwapchainKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkSwapchainCreateInfoKHR[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pSwapchain) { throw new NotImplementedException(); }
		public static void vkDestroySwapchainKHR(IntPtr device, IntPtr swapchain, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkGetSwapchainImagesKHR(IntPtr device, IntPtr swapchain, uint* pSwapchainImageCount, IntPtr* pSwapchainImages) { throw new NotImplementedException(); }
		public static VkResult vkAcquireNextImageKHR(IntPtr device, IntPtr swapchain, ulong timeout, IntPtr semaphore, IntPtr fence, uint* pImageIndex) { throw new NotImplementedException(); }
		public static VkResult vkQueuePresentKHR(IntPtr queue, [MarshalAs(UnmanagedType.LPArray)]VkPresentInfoKHR[] pPresentInfo) { throw new NotImplementedException(); }
		public static VkResult vkGetDeviceGroupPresentCapabilitiesKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkDeviceGroupPresentCapabilitiesKHR[] pDeviceGroupPresentCapabilities) { throw new NotImplementedException(); }
		public static VkResult vkGetDeviceGroupSurfacePresentModesKHR(IntPtr device, IntPtr surface, uint* pModes) { throw new NotImplementedException(); }
		public static VkResult vkGetPhysicalDevicePresentRectanglesKHR(IntPtr physicalDevice, IntPtr surface, uint* pRectCount, [MarshalAs(UnmanagedType.LPArray)]VkRect2D[] pRects) { throw new NotImplementedException(); }
		public static VkResult vkAcquireNextImage2KHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkAcquireNextImageInfoKHR[] pAcquireInfo, uint* pImageIndex) { throw new NotImplementedException(); }
		public static VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(IntPtr physicalDevice, uint* pPropertyCount, [MarshalAs(UnmanagedType.LPArray)]VkDisplayPropertiesKHR[] pProperties) { throw new NotImplementedException(); }
		public static VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(IntPtr physicalDevice, uint* pPropertyCount, [MarshalAs(UnmanagedType.LPArray)]VkDisplayPlanePropertiesKHR[] pProperties) { throw new NotImplementedException(); }
		public static VkResult vkGetDisplayPlaneSupportedDisplaysKHR(IntPtr physicalDevice, uint planeIndex, uint* pDisplayCount, IntPtr* pDisplays) { throw new NotImplementedException(); }
		public static VkResult vkGetDisplayModePropertiesKHR(IntPtr physicalDevice, IntPtr display, uint* pPropertyCount, [MarshalAs(UnmanagedType.LPArray)]VkDisplayModePropertiesKHR[] pProperties) { throw new NotImplementedException(); }
		public static VkResult vkCreateDisplayModeKHR(IntPtr physicalDevice, IntPtr display, [MarshalAs(UnmanagedType.LPArray)]VkDisplayModeCreateInfoKHR[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pMode) { throw new NotImplementedException(); }
		public static VkResult vkGetDisplayPlaneCapabilitiesKHR(IntPtr physicalDevice, IntPtr mode, uint planeIndex, [MarshalAs(UnmanagedType.LPArray)]VkDisplayPlaneCapabilitiesKHR[] pCapabilities) { throw new NotImplementedException(); }
		public static VkResult vkCreateDisplayPlaneSurfaceKHR(IntPtr instance, [MarshalAs(UnmanagedType.LPArray)]VkDisplaySurfaceCreateInfoKHR[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pSurface) { throw new NotImplementedException(); }
		public static VkResult vkCreateSharedSwapchainsKHR(IntPtr device, uint swapchainCount, [MarshalAs(UnmanagedType.LPArray)]VkSwapchainCreateInfoKHR[] pCreateInfos, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pSwapchains) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceFeatures2KHR(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceFeatures2[] pFeatures) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceProperties2KHR(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceProperties2[] pProperties) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceFormatProperties2KHR(IntPtr physicalDevice, VkFormat format, [MarshalAs(UnmanagedType.LPArray)]VkFormatProperties2[] pFormatProperties) { throw new NotImplementedException(); }
		public static VkResult vkGetPhysicalDeviceImageFormatProperties2KHR(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceImageFormatInfo2[] pImageFormatInfo, [MarshalAs(UnmanagedType.LPArray)]VkImageFormatProperties2[] pImageFormatProperties) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceQueueFamilyProperties2KHR(IntPtr physicalDevice, uint* pQueueFamilyPropertyCount, [MarshalAs(UnmanagedType.LPArray)]VkQueueFamilyProperties2[] pQueueFamilyProperties) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceMemoryProperties2KHR(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceMemoryProperties2[] pMemoryProperties) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceSparseImageFormatProperties2KHR(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceSparseImageFormatInfo2[] pFormatInfo, uint* pPropertyCount, [MarshalAs(UnmanagedType.LPArray)]VkSparseImageFormatProperties2[] pProperties) { throw new NotImplementedException(); }
		public static void vkGetDeviceGroupPeerMemoryFeaturesKHR(IntPtr device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, uint* pPeerMemoryFeatures) { throw new NotImplementedException(); }
		public static void vkCmdSetDeviceMaskKHR(IntPtr commandBuffer, uint deviceMask) { throw new NotImplementedException(); }
		public static void vkCmdDispatchBaseKHR(IntPtr commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ) { throw new NotImplementedException(); }
		public static void vkTrimCommandPoolKHR(IntPtr device, IntPtr commandPool, uint flags) { throw new NotImplementedException(); }
		public static VkResult vkEnumeratePhysicalDeviceGroupsKHR(IntPtr instance, uint* pPhysicalDeviceGroupCount, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceGroupProperties[] pPhysicalDeviceGroupProperties) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceExternalBufferPropertiesKHR(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceExternalBufferInfo[] pExternalBufferInfo, [MarshalAs(UnmanagedType.LPArray)]VkExternalBufferProperties[] pExternalBufferProperties) { throw new NotImplementedException(); }
		public static VkResult vkGetMemoryFdKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkMemoryGetFdInfoKHR[] pGetFdInfo, int* pFd) { throw new NotImplementedException(); }
		public static VkResult vkGetMemoryFdPropertiesKHR(IntPtr device, VkExternalMemoryHandleTypeFlagBits handleType, int fd, [MarshalAs(UnmanagedType.LPArray)]VkMemoryFdPropertiesKHR[] pMemoryFdProperties) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceExternalSemaphorePropertiesKHR(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceExternalSemaphoreInfo[] pExternalSemaphoreInfo, [MarshalAs(UnmanagedType.LPArray)]VkExternalSemaphoreProperties[] pExternalSemaphoreProperties) { throw new NotImplementedException(); }
		public static VkResult vkImportSemaphoreFdKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkImportSemaphoreFdInfoKHR[] pImportSemaphoreFdInfo) { throw new NotImplementedException(); }
		public static VkResult vkGetSemaphoreFdKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkSemaphoreGetFdInfoKHR[] pGetFdInfo, int* pFd) { throw new NotImplementedException(); }
		public static void vkCmdPushDescriptorSetKHR(IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, IntPtr layout, uint set, uint descriptorWriteCount, [MarshalAs(UnmanagedType.LPArray)]VkWriteDescriptorSet[] pDescriptorWrites) { throw new NotImplementedException(); }
		public static void vkCmdPushDescriptorSetWithTemplateKHR(IntPtr commandBuffer, IntPtr descriptorUpdateTemplate, IntPtr layout, uint set, IntPtr pData) { throw new NotImplementedException(); }
		public static VkResult vkCreateDescriptorUpdateTemplateKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkDescriptorUpdateTemplateCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pDescriptorUpdateTemplate) { throw new NotImplementedException(); }
		public static void vkDestroyDescriptorUpdateTemplateKHR(IntPtr device, IntPtr descriptorUpdateTemplate, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static void vkUpdateDescriptorSetWithTemplateKHR(IntPtr device, IntPtr descriptorSet, IntPtr descriptorUpdateTemplate, IntPtr pData) { throw new NotImplementedException(); }
		public static VkResult vkCreateRenderPass2KHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkRenderPassCreateInfo2[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pRenderPass) { throw new NotImplementedException(); }
		public static void vkCmdBeginRenderPass2KHR(IntPtr commandBuffer, [MarshalAs(UnmanagedType.LPArray)]VkRenderPassBeginInfo[] pRenderPassBegin, [MarshalAs(UnmanagedType.LPArray)]VkSubpassBeginInfo[] pSubpassBeginInfo) { throw new NotImplementedException(); }
		public static void vkCmdNextSubpass2KHR(IntPtr commandBuffer, [MarshalAs(UnmanagedType.LPArray)]VkSubpassBeginInfo[] pSubpassBeginInfo, [MarshalAs(UnmanagedType.LPArray)]VkSubpassEndInfo[] pSubpassEndInfo) { throw new NotImplementedException(); }
		public static void vkCmdEndRenderPass2KHR(IntPtr commandBuffer, [MarshalAs(UnmanagedType.LPArray)]VkSubpassEndInfo[] pSubpassEndInfo) { throw new NotImplementedException(); }
		public static VkResult vkGetSwapchainStatusKHR(IntPtr device, IntPtr swapchain) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceExternalFencePropertiesKHR(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceExternalFenceInfo[] pExternalFenceInfo, [MarshalAs(UnmanagedType.LPArray)]VkExternalFenceProperties[] pExternalFenceProperties) { throw new NotImplementedException(); }
		public static VkResult vkImportFenceFdKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkImportFenceFdInfoKHR[] pImportFenceFdInfo) { throw new NotImplementedException(); }
		public static VkResult vkGetFenceFdKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkFenceGetFdInfoKHR[] pGetFdInfo, int* pFd) { throw new NotImplementedException(); }
		public static VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(IntPtr physicalDevice, uint queueFamilyIndex, uint* pCounterCount, [MarshalAs(UnmanagedType.LPArray)]VkPerformanceCounterKHR[] pCounters, [MarshalAs(UnmanagedType.LPArray)]VkPerformanceCounterDescriptionKHR[] pCounterDescriptions) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkQueryPoolPerformanceCreateInfoKHR[] pPerformanceQueryCreateInfo, uint* pNumPasses) { throw new NotImplementedException(); }
		public static VkResult vkAcquireProfilingLockKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkAcquireProfilingLockInfoKHR[] pInfo) { throw new NotImplementedException(); }
		public static void vkReleaseProfilingLockKHR(IntPtr device) { throw new NotImplementedException(); }
		public static VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceSurfaceInfo2KHR[] pSurfaceInfo, [MarshalAs(UnmanagedType.LPArray)]VkSurfaceCapabilities2KHR[] pSurfaceCapabilities) { throw new NotImplementedException(); }
		public static VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceSurfaceInfo2KHR[] pSurfaceInfo, uint* pSurfaceFormatCount, [MarshalAs(UnmanagedType.LPArray)]VkSurfaceFormat2KHR[] pSurfaceFormats) { throw new NotImplementedException(); }
		public static VkResult vkGetPhysicalDeviceDisplayProperties2KHR(IntPtr physicalDevice, uint* pPropertyCount, [MarshalAs(UnmanagedType.LPArray)]VkDisplayProperties2KHR[] pProperties) { throw new NotImplementedException(); }
		public static VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(IntPtr physicalDevice, uint* pPropertyCount, [MarshalAs(UnmanagedType.LPArray)]VkDisplayPlaneProperties2KHR[] pProperties) { throw new NotImplementedException(); }
		public static VkResult vkGetDisplayModeProperties2KHR(IntPtr physicalDevice, IntPtr display, uint* pPropertyCount, [MarshalAs(UnmanagedType.LPArray)]VkDisplayModeProperties2KHR[] pProperties) { throw new NotImplementedException(); }
		public static VkResult vkGetDisplayPlaneCapabilities2KHR(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkDisplayPlaneInfo2KHR[] pDisplayPlaneInfo, [MarshalAs(UnmanagedType.LPArray)]VkDisplayPlaneCapabilities2KHR[] pCapabilities) { throw new NotImplementedException(); }
		public static void vkGetImageMemoryRequirements2KHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkImageMemoryRequirementsInfo2[] pInfo, [MarshalAs(UnmanagedType.LPArray)]VkMemoryRequirements2[] pMemoryRequirements) { throw new NotImplementedException(); }
		public static void vkGetBufferMemoryRequirements2KHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkBufferMemoryRequirementsInfo2[] pInfo, [MarshalAs(UnmanagedType.LPArray)]VkMemoryRequirements2[] pMemoryRequirements) { throw new NotImplementedException(); }
		public static void vkGetImageSparseMemoryRequirements2KHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkImageSparseMemoryRequirementsInfo2[] pInfo, uint* pSparseMemoryRequirementCount, [MarshalAs(UnmanagedType.LPArray)]VkSparseImageMemoryRequirements2[] pSparseMemoryRequirements) { throw new NotImplementedException(); }
		public static VkResult vkCreateSamplerYcbcrConversionKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkSamplerYcbcrConversionCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pYcbcrConversion) { throw new NotImplementedException(); }
		public static void vkDestroySamplerYcbcrConversionKHR(IntPtr device, IntPtr ycbcrConversion, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkBindBufferMemory2KHR(IntPtr device, uint bindInfoCount, [MarshalAs(UnmanagedType.LPArray)]VkBindBufferMemoryInfo[] pBindInfos) { throw new NotImplementedException(); }
		public static VkResult vkBindImageMemory2KHR(IntPtr device, uint bindInfoCount, [MarshalAs(UnmanagedType.LPArray)]VkBindImageMemoryInfo[] pBindInfos) { throw new NotImplementedException(); }
		public static void vkGetDescriptorSetLayoutSupportKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkDescriptorSetLayoutCreateInfo[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkDescriptorSetLayoutSupport[] pSupport) { throw new NotImplementedException(); }
		public static void vkCmdDrawIndirectCountKHR(IntPtr commandBuffer, IntPtr buffer, ulong offset, IntPtr countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride) { throw new NotImplementedException(); }
		public static void vkCmdDrawIndexedIndirectCountKHR(IntPtr commandBuffer, IntPtr buffer, ulong offset, IntPtr countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride) { throw new NotImplementedException(); }
		public static VkResult vkGetSemaphoreCounterValueKHR(IntPtr device, IntPtr semaphore, ulong* pValue) { throw new NotImplementedException(); }
		public static VkResult vkWaitSemaphoresKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkSemaphoreWaitInfo[] pWaitInfo, ulong timeout) { throw new NotImplementedException(); }
		public static VkResult vkSignalSemaphoreKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkSemaphoreSignalInfo[] pSignalInfo) { throw new NotImplementedException(); }
		public static ulong vkGetBufferDeviceAddressKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkBufferDeviceAddressInfo[] pInfo) { throw new NotImplementedException(); }
		public static ulong vkGetBufferOpaqueCaptureAddressKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkBufferDeviceAddressInfo[] pInfo) { throw new NotImplementedException(); }
		public static ulong vkGetDeviceMemoryOpaqueCaptureAddressKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkDeviceMemoryOpaqueCaptureAddressInfo[] pInfo) { throw new NotImplementedException(); }
		public static VkResult vkGetPipelineExecutablePropertiesKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkPipelineInfoKHR[] pPipelineInfo, uint* pExecutableCount, [MarshalAs(UnmanagedType.LPArray)]VkPipelineExecutablePropertiesKHR[] pProperties) { throw new NotImplementedException(); }
		public static VkResult vkGetPipelineExecutableStatisticsKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkPipelineExecutableInfoKHR[] pExecutableInfo, uint* pStatisticCount, [MarshalAs(UnmanagedType.LPArray)]VkPipelineExecutableStatisticKHR[] pStatistics) { throw new NotImplementedException(); }
		public static VkResult vkGetPipelineExecutableInternalRepresentationsKHR(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkPipelineExecutableInfoKHR[] pExecutableInfo, uint* pInternalRepresentationCount, [MarshalAs(UnmanagedType.LPArray)]VkPipelineExecutableInternalRepresentationKHR[] pInternalRepresentations) { throw new NotImplementedException(); }
		public static VkResult vkCreateDebugReportCallbackEXT(IntPtr instance, [MarshalAs(UnmanagedType.LPArray)]VkDebugReportCallbackCreateInfoEXT[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pCallback) { throw new NotImplementedException(); }
		public static void vkDestroyDebugReportCallbackEXT(IntPtr instance, IntPtr callback, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static void vkDebugReportMessageEXT(IntPtr instance, uint flags, VkDebugReportObjectTypeEXT objectType, ulong @object, ulong location, int messageCode, string pLayerPrefix, string pMessage) { throw new NotImplementedException(); }
		public static VkResult vkDebugMarkerSetObjectTagEXT(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkDebugMarkerObjectTagInfoEXT[] pTagInfo) { throw new NotImplementedException(); }
		public static VkResult vkDebugMarkerSetObjectNameEXT(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkDebugMarkerObjectNameInfoEXT[] pNameInfo) { throw new NotImplementedException(); }
		public static void vkCmdDebugMarkerBeginEXT(IntPtr commandBuffer, [MarshalAs(UnmanagedType.LPArray)]VkDebugMarkerMarkerInfoEXT[] pMarkerInfo) { throw new NotImplementedException(); }
		public static void vkCmdDebugMarkerEndEXT(IntPtr commandBuffer) { throw new NotImplementedException(); }
		public static void vkCmdDebugMarkerInsertEXT(IntPtr commandBuffer, [MarshalAs(UnmanagedType.LPArray)]VkDebugMarkerMarkerInfoEXT[] pMarkerInfo) { throw new NotImplementedException(); }
		public static void vkCmdBindTransformFeedbackBuffersEXT(IntPtr commandBuffer, uint firstBinding, uint bindingCount, IntPtr* pBuffers, ulong* pOffsets, ulong* pSizes) { throw new NotImplementedException(); }
		public static void vkCmdBeginTransformFeedbackEXT(IntPtr commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr* pCounterBuffers, ulong* pCounterBufferOffsets) { throw new NotImplementedException(); }
		public static void vkCmdEndTransformFeedbackEXT(IntPtr commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr* pCounterBuffers, ulong* pCounterBufferOffsets) { throw new NotImplementedException(); }
		public static void vkCmdBeginQueryIndexedEXT(IntPtr commandBuffer, IntPtr queryPool, uint query, uint flags, uint index) { throw new NotImplementedException(); }
		public static void vkCmdEndQueryIndexedEXT(IntPtr commandBuffer, IntPtr queryPool, uint query, uint index) { throw new NotImplementedException(); }
		public static void vkCmdDrawIndirectByteCountEXT(IntPtr commandBuffer, uint instanceCount, uint firstInstance, IntPtr counterBuffer, ulong counterBufferOffset, uint counterOffset, uint vertexStride) { throw new NotImplementedException(); }
		public static uint vkGetImageViewHandleNVX(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkImageViewHandleInfoNVX[] pInfo) { throw new NotImplementedException(); }
		public static void vkCmdDrawIndirectCountAMD(IntPtr commandBuffer, IntPtr buffer, ulong offset, IntPtr countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride) { throw new NotImplementedException(); }
		public static void vkCmdDrawIndexedIndirectCountAMD(IntPtr commandBuffer, IntPtr buffer, ulong offset, IntPtr countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride) { throw new NotImplementedException(); }
		public static VkResult vkGetShaderInfoAMD(IntPtr device, IntPtr pipeline, VkShaderStageFlagBits shaderStage, VkShaderInfoTypeAMD infoType, ulong* pInfoSize, IntPtr pInfo) { throw new NotImplementedException(); }
		public static VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNV(IntPtr physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, uint usage, uint flags, uint externalHandleType, [MarshalAs(UnmanagedType.LPArray)]VkExternalImageFormatPropertiesNV[] pExternalImageFormatProperties) { throw new NotImplementedException(); }
		public static void vkCmdBeginConditionalRenderingEXT(IntPtr commandBuffer, [MarshalAs(UnmanagedType.LPArray)]VkConditionalRenderingBeginInfoEXT[] pConditionalRenderingBegin) { throw new NotImplementedException(); }
		public static void vkCmdEndConditionalRenderingEXT(IntPtr commandBuffer) { throw new NotImplementedException(); }
		public static void vkCmdProcessCommandsNVX(IntPtr commandBuffer, [MarshalAs(UnmanagedType.LPArray)]VkCmdProcessCommandsInfoNVX[] pProcessCommandsInfo) { throw new NotImplementedException(); }
		public static void vkCmdReserveSpaceForCommandsNVX(IntPtr commandBuffer, [MarshalAs(UnmanagedType.LPArray)]VkCmdReserveSpaceForCommandsInfoNVX[] pReserveSpaceInfo) { throw new NotImplementedException(); }
		public static VkResult vkCreateIndirectCommandsLayoutNVX(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkIndirectCommandsLayoutCreateInfoNVX[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pIndirectCommandsLayout) { throw new NotImplementedException(); }
		public static void vkDestroyIndirectCommandsLayoutNVX(IntPtr device, IntPtr indirectCommandsLayout, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkCreateObjectTableNVX(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkObjectTableCreateInfoNVX[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pObjectTable) { throw new NotImplementedException(); }
		public static void vkDestroyObjectTableNVX(IntPtr device, IntPtr objectTable, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkRegisterObjectsNVX(IntPtr device, IntPtr objectTable, uint objectCount, VkObjectTableEntryNVX** ppObjectTableEntries, uint* pObjectIndices) { throw new NotImplementedException(); }
		public static VkResult vkUnregisterObjectsNVX(IntPtr device, IntPtr objectTable, uint objectCount, VkObjectEntryTypeNVX* pObjectEntryTypes, uint* pObjectIndices) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX(IntPtr physicalDevice, [MarshalAs(UnmanagedType.LPArray)]VkDeviceGeneratedCommandsFeaturesNVX[] pFeatures, [MarshalAs(UnmanagedType.LPArray)]VkDeviceGeneratedCommandsLimitsNVX[] pLimits) { throw new NotImplementedException(); }
		public static void vkCmdSetViewportWScalingNV(IntPtr commandBuffer, uint firstViewport, uint viewportCount, [MarshalAs(UnmanagedType.LPArray)]VkViewportWScalingNV[] pViewportWScalings) { throw new NotImplementedException(); }
		public static VkResult vkReleaseDisplayEXT(IntPtr physicalDevice, IntPtr display) { throw new NotImplementedException(); }
		public static VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXT(IntPtr physicalDevice, IntPtr surface, [MarshalAs(UnmanagedType.LPArray)]VkSurfaceCapabilities2EXT[] pSurfaceCapabilities) { throw new NotImplementedException(); }
		public static VkResult vkDisplayPowerControlEXT(IntPtr device, IntPtr display, [MarshalAs(UnmanagedType.LPArray)]VkDisplayPowerInfoEXT[] pDisplayPowerInfo) { throw new NotImplementedException(); }
		public static VkResult vkRegisterDeviceEventEXT(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkDeviceEventInfoEXT[] pDeviceEventInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pFence) { throw new NotImplementedException(); }
		public static VkResult vkRegisterDisplayEventEXT(IntPtr device, IntPtr display, [MarshalAs(UnmanagedType.LPArray)]VkDisplayEventInfoEXT[] pDisplayEventInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pFence) { throw new NotImplementedException(); }
		public static VkResult vkGetSwapchainCounterEXT(IntPtr device, IntPtr swapchain, VkSurfaceCounterFlagBitsEXT counter, ulong* pCounterValue) { throw new NotImplementedException(); }
		public static VkResult vkGetRefreshCycleDurationGOOGLE(IntPtr device, IntPtr swapchain, [MarshalAs(UnmanagedType.LPArray)]VkRefreshCycleDurationGOOGLE[] pDisplayTimingProperties) { throw new NotImplementedException(); }
		public static VkResult vkGetPastPresentationTimingGOOGLE(IntPtr device, IntPtr swapchain, uint* pPresentationTimingCount, [MarshalAs(UnmanagedType.LPArray)]VkPastPresentationTimingGOOGLE[] pPresentationTimings) { throw new NotImplementedException(); }
		public static void vkCmdSetDiscardRectangleEXT(IntPtr commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, [MarshalAs(UnmanagedType.LPArray)]VkRect2D[] pDiscardRectangles) { throw new NotImplementedException(); }
		public static void vkSetHdrMetadataEXT(IntPtr device, uint swapchainCount, IntPtr* pSwapchains, [MarshalAs(UnmanagedType.LPArray)]VkHdrMetadataEXT[] pMetadata) { throw new NotImplementedException(); }
		public static VkResult vkSetDebugUtilsObjectNameEXT(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkDebugUtilsObjectNameInfoEXT[] pNameInfo) { throw new NotImplementedException(); }
		public static VkResult vkSetDebugUtilsObjectTagEXT(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkDebugUtilsObjectTagInfoEXT[] pTagInfo) { throw new NotImplementedException(); }
		public static void vkQueueBeginDebugUtilsLabelEXT(IntPtr queue, [MarshalAs(UnmanagedType.LPArray)]VkDebugUtilsLabelEXT[] pLabelInfo) { throw new NotImplementedException(); }
		public static void vkQueueEndDebugUtilsLabelEXT(IntPtr queue) { throw new NotImplementedException(); }
		public static void vkQueueInsertDebugUtilsLabelEXT(IntPtr queue, [MarshalAs(UnmanagedType.LPArray)]VkDebugUtilsLabelEXT[] pLabelInfo) { throw new NotImplementedException(); }
		public static void vkCmdBeginDebugUtilsLabelEXT(IntPtr commandBuffer, [MarshalAs(UnmanagedType.LPArray)]VkDebugUtilsLabelEXT[] pLabelInfo) { throw new NotImplementedException(); }
		public static void vkCmdEndDebugUtilsLabelEXT(IntPtr commandBuffer) { throw new NotImplementedException(); }
		public static void vkCmdInsertDebugUtilsLabelEXT(IntPtr commandBuffer, [MarshalAs(UnmanagedType.LPArray)]VkDebugUtilsLabelEXT[] pLabelInfo) { throw new NotImplementedException(); }
		public static VkResult vkCreateDebugUtilsMessengerEXT(IntPtr instance, [MarshalAs(UnmanagedType.LPArray)]VkDebugUtilsMessengerCreateInfoEXT[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pMessenger) { throw new NotImplementedException(); }
		public static void vkDestroyDebugUtilsMessengerEXT(IntPtr instance, IntPtr messenger, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static void vkSubmitDebugUtilsMessageEXT(IntPtr instance, VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, uint messageTypes, [MarshalAs(UnmanagedType.LPArray)]VkDebugUtilsMessengerCallbackDataEXT[] pCallbackData) { throw new NotImplementedException(); }
		public static void vkCmdSetSampleLocationsEXT(IntPtr commandBuffer, [MarshalAs(UnmanagedType.LPArray)]VkSampleLocationsInfoEXT[] pSampleLocationsInfo) { throw new NotImplementedException(); }
		public static void vkGetPhysicalDeviceMultisamplePropertiesEXT(IntPtr physicalDevice, VkSampleCountFlagBits samples, [MarshalAs(UnmanagedType.LPArray)]VkMultisamplePropertiesEXT[] pMultisampleProperties) { throw new NotImplementedException(); }
		public static VkResult vkGetImageDrmFormatModifierPropertiesEXT(IntPtr device, IntPtr image, [MarshalAs(UnmanagedType.LPArray)]VkImageDrmFormatModifierPropertiesEXT[] pProperties) { throw new NotImplementedException(); }
		public static VkResult vkCreateValidationCacheEXT(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkValidationCacheCreateInfoEXT[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pValidationCache) { throw new NotImplementedException(); }
		public static void vkDestroyValidationCacheEXT(IntPtr device, IntPtr validationCache, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static VkResult vkMergeValidationCachesEXT(IntPtr device, IntPtr dstCache, uint srcCacheCount, IntPtr* pSrcCaches) { throw new NotImplementedException(); }
		public static VkResult vkGetValidationCacheDataEXT(IntPtr device, IntPtr validationCache, ulong* pDataSize, IntPtr pData) { throw new NotImplementedException(); }
		public static void vkCmdBindShadingRateImageNV(IntPtr commandBuffer, IntPtr imageView, VkImageLayout imageLayout) { throw new NotImplementedException(); }
		public static void vkCmdSetViewportShadingRatePaletteNV(IntPtr commandBuffer, uint firstViewport, uint viewportCount, [MarshalAs(UnmanagedType.LPArray)]VkShadingRatePaletteNV[] pShadingRatePalettes) { throw new NotImplementedException(); }
		public static void vkCmdSetCoarseSampleOrderNV(IntPtr commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, [MarshalAs(UnmanagedType.LPArray)]VkCoarseSampleOrderCustomNV[] pCustomSampleOrders) { throw new NotImplementedException(); }
		public static VkResult vkCreateAccelerationStructureNV(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkAccelerationStructureCreateInfoNV[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pAccelerationStructure) { throw new NotImplementedException(); }
		public static void vkDestroyAccelerationStructureNV(IntPtr device, IntPtr accelerationStructure, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator) { throw new NotImplementedException(); }
		public static void vkGetAccelerationStructureMemoryRequirementsNV(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkAccelerationStructureMemoryRequirementsInfoNV[] pInfo, [MarshalAs(UnmanagedType.LPArray)]VkMemoryRequirements2[] pMemoryRequirements) { throw new NotImplementedException(); }
		public static VkResult vkBindAccelerationStructureMemoryNV(IntPtr device, uint bindInfoCount, [MarshalAs(UnmanagedType.LPArray)]VkBindAccelerationStructureMemoryInfoNV[] pBindInfos) { throw new NotImplementedException(); }
		public static void vkCmdBuildAccelerationStructureNV(IntPtr commandBuffer, [MarshalAs(UnmanagedType.LPArray)]VkAccelerationStructureInfoNV[] pInfo, IntPtr instanceData, ulong instanceOffset, uint update, IntPtr dst, IntPtr src, IntPtr scratch, ulong scratchOffset) { throw new NotImplementedException(); }
		public static void vkCmdCopyAccelerationStructureNV(IntPtr commandBuffer, IntPtr dst, IntPtr src, VkCopyAccelerationStructureModeNV mode) { throw new NotImplementedException(); }
		public static void vkCmdTraceRaysNV(IntPtr commandBuffer, IntPtr raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, IntPtr missShaderBindingTableBuffer, ulong missShaderBindingOffset, ulong missShaderBindingStride, IntPtr hitShaderBindingTableBuffer, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, IntPtr callableShaderBindingTableBuffer, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth) { throw new NotImplementedException(); }
		public static VkResult vkCreateRayTracingPipelinesNV(IntPtr device, IntPtr pipelineCache, uint createInfoCount, [MarshalAs(UnmanagedType.LPArray)]VkRayTracingPipelineCreateInfoNV[] pCreateInfos, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pPipelines) { throw new NotImplementedException(); }
		public static VkResult vkGetRayTracingShaderGroupHandlesNV(IntPtr device, IntPtr pipeline, uint firstGroup, uint groupCount, ulong dataSize, IntPtr pData) { throw new NotImplementedException(); }
		public static VkResult vkGetAccelerationStructureHandleNV(IntPtr device, IntPtr accelerationStructure, ulong dataSize, IntPtr pData) { throw new NotImplementedException(); }
		public static void vkCmdWriteAccelerationStructuresPropertiesNV(IntPtr commandBuffer, uint accelerationStructureCount, IntPtr* pAccelerationStructures, VkQueryType queryType, IntPtr queryPool, uint firstQuery) { throw new NotImplementedException(); }
		public static VkResult vkCompileDeferredNV(IntPtr device, IntPtr pipeline, uint shader) { throw new NotImplementedException(); }
		public static VkResult vkGetMemoryHostPointerPropertiesEXT(IntPtr device, VkExternalMemoryHandleTypeFlagBits handleType, IntPtr pHostPointer, [MarshalAs(UnmanagedType.LPArray)]VkMemoryHostPointerPropertiesEXT[] pMemoryHostPointerProperties) { throw new NotImplementedException(); }
		public static void vkCmdWriteBufferMarkerAMD(IntPtr commandBuffer, VkPipelineStageFlagBits pipelineStage, IntPtr dstBuffer, ulong dstOffset, uint marker) { throw new NotImplementedException(); }
		public static VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(IntPtr physicalDevice, uint* pTimeDomainCount, VkTimeDomainEXT* pTimeDomains) { throw new NotImplementedException(); }
		public static VkResult vkGetCalibratedTimestampsEXT(IntPtr device, uint timestampCount, [MarshalAs(UnmanagedType.LPArray)]VkCalibratedTimestampInfoEXT[] pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation) { throw new NotImplementedException(); }
		public static void vkCmdDrawMeshTasksNV(IntPtr commandBuffer, uint taskCount, uint firstTask) { throw new NotImplementedException(); }
		public static void vkCmdDrawMeshTasksIndirectNV(IntPtr commandBuffer, IntPtr buffer, ulong offset, uint drawCount, uint stride) { throw new NotImplementedException(); }
		public static void vkCmdDrawMeshTasksIndirectCountNV(IntPtr commandBuffer, IntPtr buffer, ulong offset, IntPtr countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride) { throw new NotImplementedException(); }
		public static void vkCmdSetExclusiveScissorNV(IntPtr commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, [MarshalAs(UnmanagedType.LPArray)]VkRect2D[] pExclusiveScissors) { throw new NotImplementedException(); }
		public static void vkCmdSetCheckpointNV(IntPtr commandBuffer, IntPtr pCheckpointMarker) { throw new NotImplementedException(); }
		public static void vkGetQueueCheckpointDataNV(IntPtr queue, uint* pCheckpointDataCount, [MarshalAs(UnmanagedType.LPArray)]VkCheckpointDataNV[] pCheckpointData) { throw new NotImplementedException(); }
		public static VkResult vkInitializePerformanceApiINTEL(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkInitializePerformanceApiInfoINTEL[] pInitializeInfo) { throw new NotImplementedException(); }
		public static void vkUninitializePerformanceApiINTEL(IntPtr device) { throw new NotImplementedException(); }
		public static VkResult vkCmdSetPerformanceMarkerINTEL(IntPtr commandBuffer, [MarshalAs(UnmanagedType.LPArray)]VkPerformanceMarkerInfoINTEL[] pMarkerInfo) { throw new NotImplementedException(); }
		public static VkResult vkCmdSetPerformanceStreamMarkerINTEL(IntPtr commandBuffer, [MarshalAs(UnmanagedType.LPArray)]VkPerformanceStreamMarkerInfoINTEL[] pMarkerInfo) { throw new NotImplementedException(); }
		public static VkResult vkCmdSetPerformanceOverrideINTEL(IntPtr commandBuffer, [MarshalAs(UnmanagedType.LPArray)]VkPerformanceOverrideInfoINTEL[] pOverrideInfo) { throw new NotImplementedException(); }
		public static VkResult vkAcquirePerformanceConfigurationINTEL(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkPerformanceConfigurationAcquireInfoINTEL[] pAcquireInfo, IntPtr* pConfiguration) { throw new NotImplementedException(); }
		public static VkResult vkReleasePerformanceConfigurationINTEL(IntPtr device, IntPtr configuration) { throw new NotImplementedException(); }
		public static VkResult vkQueueSetPerformanceConfigurationINTEL(IntPtr queue, IntPtr configuration) { throw new NotImplementedException(); }
		public static VkResult vkGetPerformanceParameterINTEL(IntPtr device, VkPerformanceParameterTypeINTEL parameter, [MarshalAs(UnmanagedType.LPArray)]VkPerformanceValueINTEL[] pValue) { throw new NotImplementedException(); }
		public static void vkSetLocalDimmingAMD(IntPtr device, IntPtr swapChain, uint localDimmingEnable) { throw new NotImplementedException(); }
		public static ulong vkGetBufferDeviceAddressEXT(IntPtr device, [MarshalAs(UnmanagedType.LPArray)]VkBufferDeviceAddressInfo[] pInfo) { throw new NotImplementedException(); }
		public static VkResult vkGetPhysicalDeviceToolPropertiesEXT(IntPtr physicalDevice, uint* pToolCount, [MarshalAs(UnmanagedType.LPArray)]VkPhysicalDeviceToolPropertiesEXT[] pToolProperties) { throw new NotImplementedException(); }
		public static VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(IntPtr physicalDevice, uint* pPropertyCount, [MarshalAs(UnmanagedType.LPArray)]VkCooperativeMatrixPropertiesNV[] pProperties) { throw new NotImplementedException(); }
		public static VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(IntPtr physicalDevice, uint* pCombinationCount, [MarshalAs(UnmanagedType.LPArray)]VkFramebufferMixedSamplesCombinationNV[] pCombinations) { throw new NotImplementedException(); }
		public static VkResult vkCreateHeadlessSurfaceEXT(IntPtr instance, [MarshalAs(UnmanagedType.LPArray)]VkHeadlessSurfaceCreateInfoEXT[] pCreateInfo, [MarshalAs(UnmanagedType.LPArray)]VkAllocationCallbacks[] pAllocator, IntPtr* pSurface) { throw new NotImplementedException(); }
		public static void vkCmdSetLineStippleEXT(IntPtr commandBuffer, uint lineStippleFactor, ushort lineStipplePattern) { throw new NotImplementedException(); }
		public static void vkResetQueryPoolEXT(IntPtr device, IntPtr queryPool, uint firstQuery, uint queryCount) { throw new NotImplementedException(); }
		internal static IntPtr vkCreateWin32SurfaceKHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceWin32PresentationSupportKHR_hndl;
		internal static IntPtr vkGetMemoryWin32HandleKHR_hndl;
		internal static IntPtr vkGetMemoryWin32HandlePropertiesKHR_hndl;
		internal static IntPtr vkImportSemaphoreWin32HandleKHR_hndl;
		internal static IntPtr vkGetSemaphoreWin32HandleKHR_hndl;
		internal static IntPtr vkImportFenceWin32HandleKHR_hndl;
		internal static IntPtr vkGetFenceWin32HandleKHR_hndl;
		internal static IntPtr vkGetMemoryWin32HandleNV_hndl;
		internal static IntPtr vkGetPhysicalDeviceSurfacePresentModes2EXT_hndl;
		internal static IntPtr vkAcquireFullScreenExclusiveModeEXT_hndl;
		internal static IntPtr vkReleaseFullScreenExclusiveModeEXT_hndl;
		internal static IntPtr vkGetDeviceGroupSurfacePresentModes2EXT_hndl;
		internal static IntPtr vkCreateWaylandSurfaceKHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceWaylandPresentationSupportKHR_hndl;
		internal static IntPtr vkCreateXlibSurfaceKHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceXlibPresentationSupportKHR_hndl;
		internal static IntPtr vkCreateInstance_hndl;
		internal static IntPtr vkDestroyInstance_hndl;
		internal static IntPtr vkEnumeratePhysicalDevices_hndl;
		internal static IntPtr vkGetPhysicalDeviceFeatures_hndl;
		internal static IntPtr vkGetPhysicalDeviceFormatProperties_hndl;
		internal static IntPtr vkGetPhysicalDeviceImageFormatProperties_hndl;
		internal static IntPtr vkGetPhysicalDeviceProperties_hndl;
		internal static IntPtr vkGetPhysicalDeviceQueueFamilyProperties_hndl;
		internal static IntPtr vkGetPhysicalDeviceMemoryProperties_hndl;
		internal static IntPtr vkGetInstanceProcAddr_hndl;
		internal static IntPtr vkGetDeviceProcAddr_hndl;
		internal static IntPtr vkCreateDevice_hndl;
		internal static IntPtr vkDestroyDevice_hndl;
		internal static IntPtr vkEnumerateInstanceExtensionProperties_hndl;
		internal static IntPtr vkEnumerateDeviceExtensionProperties_hndl;
		internal static IntPtr vkEnumerateInstanceLayerProperties_hndl;
		internal static IntPtr vkEnumerateDeviceLayerProperties_hndl;
		internal static IntPtr vkGetDeviceQueue_hndl;
		internal static IntPtr vkQueueSubmit_hndl;
		internal static IntPtr vkQueueWaitIdle_hndl;
		internal static IntPtr vkDeviceWaitIdle_hndl;
		internal static IntPtr vkAllocateMemory_hndl;
		internal static IntPtr vkFreeMemory_hndl;
		internal static IntPtr vkMapMemory_hndl;
		internal static IntPtr vkUnmapMemory_hndl;
		internal static IntPtr vkFlushMappedMemoryRanges_hndl;
		internal static IntPtr vkInvalidateMappedMemoryRanges_hndl;
		internal static IntPtr vkGetDeviceMemoryCommitment_hndl;
		internal static IntPtr vkBindBufferMemory_hndl;
		internal static IntPtr vkBindImageMemory_hndl;
		internal static IntPtr vkGetBufferMemoryRequirements_hndl;
		internal static IntPtr vkGetImageMemoryRequirements_hndl;
		internal static IntPtr vkGetImageSparseMemoryRequirements_hndl;
		internal static IntPtr vkGetPhysicalDeviceSparseImageFormatProperties_hndl;
		internal static IntPtr vkQueueBindSparse_hndl;
		internal static IntPtr vkCreateFence_hndl;
		internal static IntPtr vkDestroyFence_hndl;
		internal static IntPtr vkResetFences_hndl;
		internal static IntPtr vkGetFenceStatus_hndl;
		internal static IntPtr vkWaitForFences_hndl;
		internal static IntPtr vkCreateSemaphore_hndl;
		internal static IntPtr vkDestroySemaphore_hndl;
		internal static IntPtr vkCreateEvent_hndl;
		internal static IntPtr vkDestroyEvent_hndl;
		internal static IntPtr vkGetEventStatus_hndl;
		internal static IntPtr vkSetEvent_hndl;
		internal static IntPtr vkResetEvent_hndl;
		internal static IntPtr vkCreateQueryPool_hndl;
		internal static IntPtr vkDestroyQueryPool_hndl;
		internal static IntPtr vkGetQueryPoolResults_hndl;
		internal static IntPtr vkCreateBuffer_hndl;
		internal static IntPtr vkDestroyBuffer_hndl;
		internal static IntPtr vkCreateBufferView_hndl;
		internal static IntPtr vkDestroyBufferView_hndl;
		internal static IntPtr vkCreateImage_hndl;
		internal static IntPtr vkDestroyImage_hndl;
		internal static IntPtr vkGetImageSubresourceLayout_hndl;
		internal static IntPtr vkCreateImageView_hndl;
		internal static IntPtr vkDestroyImageView_hndl;
		internal static IntPtr vkCreateShaderModule_hndl;
		internal static IntPtr vkDestroyShaderModule_hndl;
		internal static IntPtr vkCreatePipelineCache_hndl;
		internal static IntPtr vkDestroyPipelineCache_hndl;
		internal static IntPtr vkGetPipelineCacheData_hndl;
		internal static IntPtr vkMergePipelineCaches_hndl;
		internal static IntPtr vkCreateGraphicsPipelines_hndl;
		internal static IntPtr vkCreateComputePipelines_hndl;
		internal static IntPtr vkDestroyPipeline_hndl;
		internal static IntPtr vkCreatePipelineLayout_hndl;
		internal static IntPtr vkDestroyPipelineLayout_hndl;
		internal static IntPtr vkCreateSampler_hndl;
		internal static IntPtr vkDestroySampler_hndl;
		internal static IntPtr vkCreateDescriptorSetLayout_hndl;
		internal static IntPtr vkDestroyDescriptorSetLayout_hndl;
		internal static IntPtr vkCreateDescriptorPool_hndl;
		internal static IntPtr vkDestroyDescriptorPool_hndl;
		internal static IntPtr vkResetDescriptorPool_hndl;
		internal static IntPtr vkAllocateDescriptorSets_hndl;
		internal static IntPtr vkFreeDescriptorSets_hndl;
		internal static IntPtr vkUpdateDescriptorSets_hndl;
		internal static IntPtr vkCreateFramebuffer_hndl;
		internal static IntPtr vkDestroyFramebuffer_hndl;
		internal static IntPtr vkCreateRenderPass_hndl;
		internal static IntPtr vkDestroyRenderPass_hndl;
		internal static IntPtr vkGetRenderAreaGranularity_hndl;
		internal static IntPtr vkCreateCommandPool_hndl;
		internal static IntPtr vkDestroyCommandPool_hndl;
		internal static IntPtr vkResetCommandPool_hndl;
		internal static IntPtr vkAllocateCommandBuffers_hndl;
		internal static IntPtr vkFreeCommandBuffers_hndl;
		internal static IntPtr vkBeginCommandBuffer_hndl;
		internal static IntPtr vkEndCommandBuffer_hndl;
		internal static IntPtr vkResetCommandBuffer_hndl;
		internal static IntPtr vkCmdBindPipeline_hndl;
		internal static IntPtr vkCmdSetViewport_hndl;
		internal static IntPtr vkCmdSetScissor_hndl;
		internal static IntPtr vkCmdSetLineWidth_hndl;
		internal static IntPtr vkCmdSetDepthBias_hndl;
		internal static IntPtr vkCmdSetBlendConstants_hndl;
		internal static IntPtr vkCmdSetDepthBounds_hndl;
		internal static IntPtr vkCmdSetStencilCompareMask_hndl;
		internal static IntPtr vkCmdSetStencilWriteMask_hndl;
		internal static IntPtr vkCmdSetStencilReference_hndl;
		internal static IntPtr vkCmdBindDescriptorSets_hndl;
		internal static IntPtr vkCmdBindIndexBuffer_hndl;
		internal static IntPtr vkCmdBindVertexBuffers_hndl;
		internal static IntPtr vkCmdDraw_hndl;
		internal static IntPtr vkCmdDrawIndexed_hndl;
		internal static IntPtr vkCmdDrawIndirect_hndl;
		internal static IntPtr vkCmdDrawIndexedIndirect_hndl;
		internal static IntPtr vkCmdDispatch_hndl;
		internal static IntPtr vkCmdDispatchIndirect_hndl;
		internal static IntPtr vkCmdCopyBuffer_hndl;
		internal static IntPtr vkCmdCopyImage_hndl;
		internal static IntPtr vkCmdBlitImage_hndl;
		internal static IntPtr vkCmdCopyBufferToImage_hndl;
		internal static IntPtr vkCmdCopyImageToBuffer_hndl;
		internal static IntPtr vkCmdUpdateBuffer_hndl;
		internal static IntPtr vkCmdFillBuffer_hndl;
		internal static IntPtr vkCmdClearColorImage_hndl;
		internal static IntPtr vkCmdClearDepthStencilImage_hndl;
		internal static IntPtr vkCmdClearAttachments_hndl;
		internal static IntPtr vkCmdResolveImage_hndl;
		internal static IntPtr vkCmdSetEvent_hndl;
		internal static IntPtr vkCmdResetEvent_hndl;
		internal static IntPtr vkCmdWaitEvents_hndl;
		internal static IntPtr vkCmdPipelineBarrier_hndl;
		internal static IntPtr vkCmdBeginQuery_hndl;
		internal static IntPtr vkCmdEndQuery_hndl;
		internal static IntPtr vkCmdResetQueryPool_hndl;
		internal static IntPtr vkCmdWriteTimestamp_hndl;
		internal static IntPtr vkCmdCopyQueryPoolResults_hndl;
		internal static IntPtr vkCmdPushConstants_hndl;
		internal static IntPtr vkCmdBeginRenderPass_hndl;
		internal static IntPtr vkCmdNextSubpass_hndl;
		internal static IntPtr vkCmdEndRenderPass_hndl;
		internal static IntPtr vkCmdExecuteCommands_hndl;
		internal static IntPtr vkEnumerateInstanceVersion_hndl;
		internal static IntPtr vkBindBufferMemory2_hndl;
		internal static IntPtr vkBindImageMemory2_hndl;
		internal static IntPtr vkGetDeviceGroupPeerMemoryFeatures_hndl;
		internal static IntPtr vkCmdSetDeviceMask_hndl;
		internal static IntPtr vkCmdDispatchBase_hndl;
		internal static IntPtr vkEnumeratePhysicalDeviceGroups_hndl;
		internal static IntPtr vkGetImageMemoryRequirements2_hndl;
		internal static IntPtr vkGetBufferMemoryRequirements2_hndl;
		internal static IntPtr vkGetImageSparseMemoryRequirements2_hndl;
		internal static IntPtr vkGetPhysicalDeviceFeatures2_hndl;
		internal static IntPtr vkGetPhysicalDeviceProperties2_hndl;
		internal static IntPtr vkGetPhysicalDeviceFormatProperties2_hndl;
		internal static IntPtr vkGetPhysicalDeviceImageFormatProperties2_hndl;
		internal static IntPtr vkGetPhysicalDeviceQueueFamilyProperties2_hndl;
		internal static IntPtr vkGetPhysicalDeviceMemoryProperties2_hndl;
		internal static IntPtr vkGetPhysicalDeviceSparseImageFormatProperties2_hndl;
		internal static IntPtr vkTrimCommandPool_hndl;
		internal static IntPtr vkGetDeviceQueue2_hndl;
		internal static IntPtr vkCreateSamplerYcbcrConversion_hndl;
		internal static IntPtr vkDestroySamplerYcbcrConversion_hndl;
		internal static IntPtr vkCreateDescriptorUpdateTemplate_hndl;
		internal static IntPtr vkDestroyDescriptorUpdateTemplate_hndl;
		internal static IntPtr vkUpdateDescriptorSetWithTemplate_hndl;
		internal static IntPtr vkGetPhysicalDeviceExternalBufferProperties_hndl;
		internal static IntPtr vkGetPhysicalDeviceExternalFenceProperties_hndl;
		internal static IntPtr vkGetPhysicalDeviceExternalSemaphoreProperties_hndl;
		internal static IntPtr vkGetDescriptorSetLayoutSupport_hndl;
		internal static IntPtr vkCmdDrawIndirectCount_hndl;
		internal static IntPtr vkCmdDrawIndexedIndirectCount_hndl;
		internal static IntPtr vkCreateRenderPass2_hndl;
		internal static IntPtr vkCmdBeginRenderPass2_hndl;
		internal static IntPtr vkCmdNextSubpass2_hndl;
		internal static IntPtr vkCmdEndRenderPass2_hndl;
		internal static IntPtr vkResetQueryPool_hndl;
		internal static IntPtr vkGetSemaphoreCounterValue_hndl;
		internal static IntPtr vkWaitSemaphores_hndl;
		internal static IntPtr vkSignalSemaphore_hndl;
		internal static IntPtr vkGetBufferDeviceAddress_hndl;
		internal static IntPtr vkGetBufferOpaqueCaptureAddress_hndl;
		internal static IntPtr vkGetDeviceMemoryOpaqueCaptureAddress_hndl;
		internal static IntPtr vkDestroySurfaceKHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceSurfaceSupportKHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceSurfaceCapabilitiesKHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceSurfaceFormatsKHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceSurfacePresentModesKHR_hndl;
		internal static IntPtr vkCreateSwapchainKHR_hndl;
		internal static IntPtr vkDestroySwapchainKHR_hndl;
		internal static IntPtr vkGetSwapchainImagesKHR_hndl;
		internal static IntPtr vkAcquireNextImageKHR_hndl;
		internal static IntPtr vkQueuePresentKHR_hndl;
		internal static IntPtr vkGetDeviceGroupPresentCapabilitiesKHR_hndl;
		internal static IntPtr vkGetDeviceGroupSurfacePresentModesKHR_hndl;
		internal static IntPtr vkGetPhysicalDevicePresentRectanglesKHR_hndl;
		internal static IntPtr vkAcquireNextImage2KHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceDisplayPropertiesKHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceDisplayPlanePropertiesKHR_hndl;
		internal static IntPtr vkGetDisplayPlaneSupportedDisplaysKHR_hndl;
		internal static IntPtr vkGetDisplayModePropertiesKHR_hndl;
		internal static IntPtr vkCreateDisplayModeKHR_hndl;
		internal static IntPtr vkGetDisplayPlaneCapabilitiesKHR_hndl;
		internal static IntPtr vkCreateDisplayPlaneSurfaceKHR_hndl;
		internal static IntPtr vkCreateSharedSwapchainsKHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceFeatures2KHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceProperties2KHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceFormatProperties2KHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceImageFormatProperties2KHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceQueueFamilyProperties2KHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceMemoryProperties2KHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceSparseImageFormatProperties2KHR_hndl;
		internal static IntPtr vkGetDeviceGroupPeerMemoryFeaturesKHR_hndl;
		internal static IntPtr vkCmdSetDeviceMaskKHR_hndl;
		internal static IntPtr vkCmdDispatchBaseKHR_hndl;
		internal static IntPtr vkTrimCommandPoolKHR_hndl;
		internal static IntPtr vkEnumeratePhysicalDeviceGroupsKHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceExternalBufferPropertiesKHR_hndl;
		internal static IntPtr vkGetMemoryFdKHR_hndl;
		internal static IntPtr vkGetMemoryFdPropertiesKHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceExternalSemaphorePropertiesKHR_hndl;
		internal static IntPtr vkImportSemaphoreFdKHR_hndl;
		internal static IntPtr vkGetSemaphoreFdKHR_hndl;
		internal static IntPtr vkCmdPushDescriptorSetKHR_hndl;
		internal static IntPtr vkCmdPushDescriptorSetWithTemplateKHR_hndl;
		internal static IntPtr vkCreateDescriptorUpdateTemplateKHR_hndl;
		internal static IntPtr vkDestroyDescriptorUpdateTemplateKHR_hndl;
		internal static IntPtr vkUpdateDescriptorSetWithTemplateKHR_hndl;
		internal static IntPtr vkCreateRenderPass2KHR_hndl;
		internal static IntPtr vkCmdBeginRenderPass2KHR_hndl;
		internal static IntPtr vkCmdNextSubpass2KHR_hndl;
		internal static IntPtr vkCmdEndRenderPass2KHR_hndl;
		internal static IntPtr vkGetSwapchainStatusKHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceExternalFencePropertiesKHR_hndl;
		internal static IntPtr vkImportFenceFdKHR_hndl;
		internal static IntPtr vkGetFenceFdKHR_hndl;
		internal static IntPtr vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_hndl;
		internal static IntPtr vkAcquireProfilingLockKHR_hndl;
		internal static IntPtr vkReleaseProfilingLockKHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceSurfaceCapabilities2KHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceSurfaceFormats2KHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceDisplayProperties2KHR_hndl;
		internal static IntPtr vkGetPhysicalDeviceDisplayPlaneProperties2KHR_hndl;
		internal static IntPtr vkGetDisplayModeProperties2KHR_hndl;
		internal static IntPtr vkGetDisplayPlaneCapabilities2KHR_hndl;
		internal static IntPtr vkGetImageMemoryRequirements2KHR_hndl;
		internal static IntPtr vkGetBufferMemoryRequirements2KHR_hndl;
		internal static IntPtr vkGetImageSparseMemoryRequirements2KHR_hndl;
		internal static IntPtr vkCreateSamplerYcbcrConversionKHR_hndl;
		internal static IntPtr vkDestroySamplerYcbcrConversionKHR_hndl;
		internal static IntPtr vkBindBufferMemory2KHR_hndl;
		internal static IntPtr vkBindImageMemory2KHR_hndl;
		internal static IntPtr vkGetDescriptorSetLayoutSupportKHR_hndl;
		internal static IntPtr vkCmdDrawIndirectCountKHR_hndl;
		internal static IntPtr vkCmdDrawIndexedIndirectCountKHR_hndl;
		internal static IntPtr vkGetSemaphoreCounterValueKHR_hndl;
		internal static IntPtr vkWaitSemaphoresKHR_hndl;
		internal static IntPtr vkSignalSemaphoreKHR_hndl;
		internal static IntPtr vkGetBufferDeviceAddressKHR_hndl;
		internal static IntPtr vkGetBufferOpaqueCaptureAddressKHR_hndl;
		internal static IntPtr vkGetDeviceMemoryOpaqueCaptureAddressKHR_hndl;
		internal static IntPtr vkGetPipelineExecutablePropertiesKHR_hndl;
		internal static IntPtr vkGetPipelineExecutableStatisticsKHR_hndl;
		internal static IntPtr vkGetPipelineExecutableInternalRepresentationsKHR_hndl;
		internal static IntPtr vkCreateDebugReportCallbackEXT_hndl;
		internal static IntPtr vkDestroyDebugReportCallbackEXT_hndl;
		internal static IntPtr vkDebugReportMessageEXT_hndl;
		internal static IntPtr vkDebugMarkerSetObjectTagEXT_hndl;
		internal static IntPtr vkDebugMarkerSetObjectNameEXT_hndl;
		internal static IntPtr vkCmdDebugMarkerBeginEXT_hndl;
		internal static IntPtr vkCmdDebugMarkerEndEXT_hndl;
		internal static IntPtr vkCmdDebugMarkerInsertEXT_hndl;
		internal static IntPtr vkCmdBindTransformFeedbackBuffersEXT_hndl;
		internal static IntPtr vkCmdBeginTransformFeedbackEXT_hndl;
		internal static IntPtr vkCmdEndTransformFeedbackEXT_hndl;
		internal static IntPtr vkCmdBeginQueryIndexedEXT_hndl;
		internal static IntPtr vkCmdEndQueryIndexedEXT_hndl;
		internal static IntPtr vkCmdDrawIndirectByteCountEXT_hndl;
		internal static IntPtr vkGetImageViewHandleNVX_hndl;
		internal static IntPtr vkCmdDrawIndirectCountAMD_hndl;
		internal static IntPtr vkCmdDrawIndexedIndirectCountAMD_hndl;
		internal static IntPtr vkGetShaderInfoAMD_hndl;
		internal static IntPtr vkGetPhysicalDeviceExternalImageFormatPropertiesNV_hndl;
		internal static IntPtr vkCmdBeginConditionalRenderingEXT_hndl;
		internal static IntPtr vkCmdEndConditionalRenderingEXT_hndl;
		internal static IntPtr vkCmdProcessCommandsNVX_hndl;
		internal static IntPtr vkCmdReserveSpaceForCommandsNVX_hndl;
		internal static IntPtr vkCreateIndirectCommandsLayoutNVX_hndl;
		internal static IntPtr vkDestroyIndirectCommandsLayoutNVX_hndl;
		internal static IntPtr vkCreateObjectTableNVX_hndl;
		internal static IntPtr vkDestroyObjectTableNVX_hndl;
		internal static IntPtr vkRegisterObjectsNVX_hndl;
		internal static IntPtr vkUnregisterObjectsNVX_hndl;
		internal static IntPtr vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX_hndl;
		internal static IntPtr vkCmdSetViewportWScalingNV_hndl;
		internal static IntPtr vkReleaseDisplayEXT_hndl;
		internal static IntPtr vkGetPhysicalDeviceSurfaceCapabilities2EXT_hndl;
		internal static IntPtr vkDisplayPowerControlEXT_hndl;
		internal static IntPtr vkRegisterDeviceEventEXT_hndl;
		internal static IntPtr vkRegisterDisplayEventEXT_hndl;
		internal static IntPtr vkGetSwapchainCounterEXT_hndl;
		internal static IntPtr vkGetRefreshCycleDurationGOOGLE_hndl;
		internal static IntPtr vkGetPastPresentationTimingGOOGLE_hndl;
		internal static IntPtr vkCmdSetDiscardRectangleEXT_hndl;
		internal static IntPtr vkSetHdrMetadataEXT_hndl;
		internal static IntPtr vkSetDebugUtilsObjectNameEXT_hndl;
		internal static IntPtr vkSetDebugUtilsObjectTagEXT_hndl;
		internal static IntPtr vkQueueBeginDebugUtilsLabelEXT_hndl;
		internal static IntPtr vkQueueEndDebugUtilsLabelEXT_hndl;
		internal static IntPtr vkQueueInsertDebugUtilsLabelEXT_hndl;
		internal static IntPtr vkCmdBeginDebugUtilsLabelEXT_hndl;
		internal static IntPtr vkCmdEndDebugUtilsLabelEXT_hndl;
		internal static IntPtr vkCmdInsertDebugUtilsLabelEXT_hndl;
		internal static IntPtr vkCreateDebugUtilsMessengerEXT_hndl;
		internal static IntPtr vkDestroyDebugUtilsMessengerEXT_hndl;
		internal static IntPtr vkSubmitDebugUtilsMessageEXT_hndl;
		internal static IntPtr vkCmdSetSampleLocationsEXT_hndl;
		internal static IntPtr vkGetPhysicalDeviceMultisamplePropertiesEXT_hndl;
		internal static IntPtr vkGetImageDrmFormatModifierPropertiesEXT_hndl;
		internal static IntPtr vkCreateValidationCacheEXT_hndl;
		internal static IntPtr vkDestroyValidationCacheEXT_hndl;
		internal static IntPtr vkMergeValidationCachesEXT_hndl;
		internal static IntPtr vkGetValidationCacheDataEXT_hndl;
		internal static IntPtr vkCmdBindShadingRateImageNV_hndl;
		internal static IntPtr vkCmdSetViewportShadingRatePaletteNV_hndl;
		internal static IntPtr vkCmdSetCoarseSampleOrderNV_hndl;
		internal static IntPtr vkCreateAccelerationStructureNV_hndl;
		internal static IntPtr vkDestroyAccelerationStructureNV_hndl;
		internal static IntPtr vkGetAccelerationStructureMemoryRequirementsNV_hndl;
		internal static IntPtr vkBindAccelerationStructureMemoryNV_hndl;
		internal static IntPtr vkCmdBuildAccelerationStructureNV_hndl;
		internal static IntPtr vkCmdCopyAccelerationStructureNV_hndl;
		internal static IntPtr vkCmdTraceRaysNV_hndl;
		internal static IntPtr vkCreateRayTracingPipelinesNV_hndl;
		internal static IntPtr vkGetRayTracingShaderGroupHandlesNV_hndl;
		internal static IntPtr vkGetAccelerationStructureHandleNV_hndl;
		internal static IntPtr vkCmdWriteAccelerationStructuresPropertiesNV_hndl;
		internal static IntPtr vkCompileDeferredNV_hndl;
		internal static IntPtr vkGetMemoryHostPointerPropertiesEXT_hndl;
		internal static IntPtr vkCmdWriteBufferMarkerAMD_hndl;
		internal static IntPtr vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_hndl;
		internal static IntPtr vkGetCalibratedTimestampsEXT_hndl;
		internal static IntPtr vkCmdDrawMeshTasksNV_hndl;
		internal static IntPtr vkCmdDrawMeshTasksIndirectNV_hndl;
		internal static IntPtr vkCmdDrawMeshTasksIndirectCountNV_hndl;
		internal static IntPtr vkCmdSetExclusiveScissorNV_hndl;
		internal static IntPtr vkCmdSetCheckpointNV_hndl;
		internal static IntPtr vkGetQueueCheckpointDataNV_hndl;
		internal static IntPtr vkInitializePerformanceApiINTEL_hndl;
		internal static IntPtr vkUninitializePerformanceApiINTEL_hndl;
		internal static IntPtr vkCmdSetPerformanceMarkerINTEL_hndl;
		internal static IntPtr vkCmdSetPerformanceStreamMarkerINTEL_hndl;
		internal static IntPtr vkCmdSetPerformanceOverrideINTEL_hndl;
		internal static IntPtr vkAcquirePerformanceConfigurationINTEL_hndl;
		internal static IntPtr vkReleasePerformanceConfigurationINTEL_hndl;
		internal static IntPtr vkQueueSetPerformanceConfigurationINTEL_hndl;
		internal static IntPtr vkGetPerformanceParameterINTEL_hndl;
		internal static IntPtr vkSetLocalDimmingAMD_hndl;
		internal static IntPtr vkGetBufferDeviceAddressEXT_hndl;
		internal static IntPtr vkGetPhysicalDeviceToolPropertiesEXT_hndl;
		internal static IntPtr vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_hndl;
		internal static IntPtr vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_hndl;
		internal static IntPtr vkCreateHeadlessSurfaceEXT_hndl;
		internal static IntPtr vkCmdSetLineStippleEXT_hndl;
		internal static IntPtr vkResetQueryPoolEXT_hndl;
		private static void InitPtrs() {
			NativeLibrary.TryGetExport(libHndl, "vkCreateWin32SurfaceKHR", out vkCreateWin32SurfaceKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceWin32PresentationSupportKHR", out vkGetPhysicalDeviceWin32PresentationSupportKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetMemoryWin32HandleKHR", out vkGetMemoryWin32HandleKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetMemoryWin32HandlePropertiesKHR", out vkGetMemoryWin32HandlePropertiesKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkImportSemaphoreWin32HandleKHR", out vkImportSemaphoreWin32HandleKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetSemaphoreWin32HandleKHR", out vkGetSemaphoreWin32HandleKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkImportFenceWin32HandleKHR", out vkImportFenceWin32HandleKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetFenceWin32HandleKHR", out vkGetFenceWin32HandleKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetMemoryWin32HandleNV", out vkGetMemoryWin32HandleNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceSurfacePresentModes2EXT", out vkGetPhysicalDeviceSurfacePresentModes2EXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkAcquireFullScreenExclusiveModeEXT", out vkAcquireFullScreenExclusiveModeEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkReleaseFullScreenExclusiveModeEXT", out vkReleaseFullScreenExclusiveModeEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetDeviceGroupSurfacePresentModes2EXT", out vkGetDeviceGroupSurfacePresentModes2EXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateWaylandSurfaceKHR", out vkCreateWaylandSurfaceKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceWaylandPresentationSupportKHR", out vkGetPhysicalDeviceWaylandPresentationSupportKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateXlibSurfaceKHR", out vkCreateXlibSurfaceKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceXlibPresentationSupportKHR", out vkGetPhysicalDeviceXlibPresentationSupportKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateInstance", out vkCreateInstance_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyInstance", out vkDestroyInstance_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkEnumeratePhysicalDevices", out vkEnumeratePhysicalDevices_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceFeatures", out vkGetPhysicalDeviceFeatures_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceFormatProperties", out vkGetPhysicalDeviceFormatProperties_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceImageFormatProperties", out vkGetPhysicalDeviceImageFormatProperties_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceProperties", out vkGetPhysicalDeviceProperties_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceQueueFamilyProperties", out vkGetPhysicalDeviceQueueFamilyProperties_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceMemoryProperties", out vkGetPhysicalDeviceMemoryProperties_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetInstanceProcAddr", out vkGetInstanceProcAddr_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetDeviceProcAddr", out vkGetDeviceProcAddr_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateDevice", out vkCreateDevice_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyDevice", out vkDestroyDevice_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkEnumerateInstanceExtensionProperties", out vkEnumerateInstanceExtensionProperties_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkEnumerateDeviceExtensionProperties", out vkEnumerateDeviceExtensionProperties_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkEnumerateInstanceLayerProperties", out vkEnumerateInstanceLayerProperties_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkEnumerateDeviceLayerProperties", out vkEnumerateDeviceLayerProperties_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetDeviceQueue", out vkGetDeviceQueue_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkQueueSubmit", out vkQueueSubmit_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkQueueWaitIdle", out vkQueueWaitIdle_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDeviceWaitIdle", out vkDeviceWaitIdle_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkAllocateMemory", out vkAllocateMemory_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkFreeMemory", out vkFreeMemory_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkMapMemory", out vkMapMemory_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkUnmapMemory", out vkUnmapMemory_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkFlushMappedMemoryRanges", out vkFlushMappedMemoryRanges_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkInvalidateMappedMemoryRanges", out vkInvalidateMappedMemoryRanges_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetDeviceMemoryCommitment", out vkGetDeviceMemoryCommitment_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkBindBufferMemory", out vkBindBufferMemory_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkBindImageMemory", out vkBindImageMemory_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetBufferMemoryRequirements", out vkGetBufferMemoryRequirements_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetImageMemoryRequirements", out vkGetImageMemoryRequirements_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetImageSparseMemoryRequirements", out vkGetImageSparseMemoryRequirements_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceSparseImageFormatProperties", out vkGetPhysicalDeviceSparseImageFormatProperties_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkQueueBindSparse", out vkQueueBindSparse_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateFence", out vkCreateFence_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyFence", out vkDestroyFence_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkResetFences", out vkResetFences_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetFenceStatus", out vkGetFenceStatus_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkWaitForFences", out vkWaitForFences_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateSemaphore", out vkCreateSemaphore_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroySemaphore", out vkDestroySemaphore_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateEvent", out vkCreateEvent_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyEvent", out vkDestroyEvent_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetEventStatus", out vkGetEventStatus_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkSetEvent", out vkSetEvent_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkResetEvent", out vkResetEvent_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateQueryPool", out vkCreateQueryPool_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyQueryPool", out vkDestroyQueryPool_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetQueryPoolResults", out vkGetQueryPoolResults_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateBuffer", out vkCreateBuffer_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyBuffer", out vkDestroyBuffer_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateBufferView", out vkCreateBufferView_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyBufferView", out vkDestroyBufferView_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateImage", out vkCreateImage_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyImage", out vkDestroyImage_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetImageSubresourceLayout", out vkGetImageSubresourceLayout_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateImageView", out vkCreateImageView_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyImageView", out vkDestroyImageView_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateShaderModule", out vkCreateShaderModule_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyShaderModule", out vkDestroyShaderModule_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreatePipelineCache", out vkCreatePipelineCache_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyPipelineCache", out vkDestroyPipelineCache_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPipelineCacheData", out vkGetPipelineCacheData_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkMergePipelineCaches", out vkMergePipelineCaches_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateGraphicsPipelines", out vkCreateGraphicsPipelines_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateComputePipelines", out vkCreateComputePipelines_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyPipeline", out vkDestroyPipeline_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreatePipelineLayout", out vkCreatePipelineLayout_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyPipelineLayout", out vkDestroyPipelineLayout_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateSampler", out vkCreateSampler_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroySampler", out vkDestroySampler_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateDescriptorSetLayout", out vkCreateDescriptorSetLayout_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyDescriptorSetLayout", out vkDestroyDescriptorSetLayout_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateDescriptorPool", out vkCreateDescriptorPool_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyDescriptorPool", out vkDestroyDescriptorPool_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkResetDescriptorPool", out vkResetDescriptorPool_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkAllocateDescriptorSets", out vkAllocateDescriptorSets_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkFreeDescriptorSets", out vkFreeDescriptorSets_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkUpdateDescriptorSets", out vkUpdateDescriptorSets_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateFramebuffer", out vkCreateFramebuffer_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyFramebuffer", out vkDestroyFramebuffer_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateRenderPass", out vkCreateRenderPass_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyRenderPass", out vkDestroyRenderPass_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetRenderAreaGranularity", out vkGetRenderAreaGranularity_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateCommandPool", out vkCreateCommandPool_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyCommandPool", out vkDestroyCommandPool_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkResetCommandPool", out vkResetCommandPool_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkAllocateCommandBuffers", out vkAllocateCommandBuffers_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkFreeCommandBuffers", out vkFreeCommandBuffers_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkBeginCommandBuffer", out vkBeginCommandBuffer_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkEndCommandBuffer", out vkEndCommandBuffer_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkResetCommandBuffer", out vkResetCommandBuffer_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdBindPipeline", out vkCmdBindPipeline_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdSetViewport", out vkCmdSetViewport_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdSetScissor", out vkCmdSetScissor_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdSetLineWidth", out vkCmdSetLineWidth_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdSetDepthBias", out vkCmdSetDepthBias_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdSetBlendConstants", out vkCmdSetBlendConstants_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdSetDepthBounds", out vkCmdSetDepthBounds_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdSetStencilCompareMask", out vkCmdSetStencilCompareMask_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdSetStencilWriteMask", out vkCmdSetStencilWriteMask_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdSetStencilReference", out vkCmdSetStencilReference_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdBindDescriptorSets", out vkCmdBindDescriptorSets_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdBindIndexBuffer", out vkCmdBindIndexBuffer_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdBindVertexBuffers", out vkCmdBindVertexBuffers_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdDraw", out vkCmdDraw_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdDrawIndexed", out vkCmdDrawIndexed_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdDrawIndirect", out vkCmdDrawIndirect_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdDrawIndexedIndirect", out vkCmdDrawIndexedIndirect_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdDispatch", out vkCmdDispatch_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdDispatchIndirect", out vkCmdDispatchIndirect_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdCopyBuffer", out vkCmdCopyBuffer_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdCopyImage", out vkCmdCopyImage_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdBlitImage", out vkCmdBlitImage_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdCopyBufferToImage", out vkCmdCopyBufferToImage_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdCopyImageToBuffer", out vkCmdCopyImageToBuffer_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdUpdateBuffer", out vkCmdUpdateBuffer_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdFillBuffer", out vkCmdFillBuffer_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdClearColorImage", out vkCmdClearColorImage_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdClearDepthStencilImage", out vkCmdClearDepthStencilImage_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdClearAttachments", out vkCmdClearAttachments_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdResolveImage", out vkCmdResolveImage_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdSetEvent", out vkCmdSetEvent_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdResetEvent", out vkCmdResetEvent_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdWaitEvents", out vkCmdWaitEvents_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdPipelineBarrier", out vkCmdPipelineBarrier_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdBeginQuery", out vkCmdBeginQuery_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdEndQuery", out vkCmdEndQuery_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdResetQueryPool", out vkCmdResetQueryPool_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdWriteTimestamp", out vkCmdWriteTimestamp_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdCopyQueryPoolResults", out vkCmdCopyQueryPoolResults_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdPushConstants", out vkCmdPushConstants_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdBeginRenderPass", out vkCmdBeginRenderPass_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdNextSubpass", out vkCmdNextSubpass_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdEndRenderPass", out vkCmdEndRenderPass_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdExecuteCommands", out vkCmdExecuteCommands_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkEnumerateInstanceVersion", out vkEnumerateInstanceVersion_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkBindBufferMemory2", out vkBindBufferMemory2_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkBindImageMemory2", out vkBindImageMemory2_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetDeviceGroupPeerMemoryFeatures", out vkGetDeviceGroupPeerMemoryFeatures_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdSetDeviceMask", out vkCmdSetDeviceMask_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdDispatchBase", out vkCmdDispatchBase_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkEnumeratePhysicalDeviceGroups", out vkEnumeratePhysicalDeviceGroups_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetImageMemoryRequirements2", out vkGetImageMemoryRequirements2_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetBufferMemoryRequirements2", out vkGetBufferMemoryRequirements2_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetImageSparseMemoryRequirements2", out vkGetImageSparseMemoryRequirements2_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceFeatures2", out vkGetPhysicalDeviceFeatures2_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceProperties2", out vkGetPhysicalDeviceProperties2_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceFormatProperties2", out vkGetPhysicalDeviceFormatProperties2_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceImageFormatProperties2", out vkGetPhysicalDeviceImageFormatProperties2_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceQueueFamilyProperties2", out vkGetPhysicalDeviceQueueFamilyProperties2_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceMemoryProperties2", out vkGetPhysicalDeviceMemoryProperties2_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceSparseImageFormatProperties2", out vkGetPhysicalDeviceSparseImageFormatProperties2_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkTrimCommandPool", out vkTrimCommandPool_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetDeviceQueue2", out vkGetDeviceQueue2_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateSamplerYcbcrConversion", out vkCreateSamplerYcbcrConversion_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroySamplerYcbcrConversion", out vkDestroySamplerYcbcrConversion_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateDescriptorUpdateTemplate", out vkCreateDescriptorUpdateTemplate_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyDescriptorUpdateTemplate", out vkDestroyDescriptorUpdateTemplate_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkUpdateDescriptorSetWithTemplate", out vkUpdateDescriptorSetWithTemplate_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceExternalBufferProperties", out vkGetPhysicalDeviceExternalBufferProperties_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceExternalFenceProperties", out vkGetPhysicalDeviceExternalFenceProperties_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceExternalSemaphoreProperties", out vkGetPhysicalDeviceExternalSemaphoreProperties_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetDescriptorSetLayoutSupport", out vkGetDescriptorSetLayoutSupport_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdDrawIndirectCount", out vkCmdDrawIndirectCount_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdDrawIndexedIndirectCount", out vkCmdDrawIndexedIndirectCount_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateRenderPass2", out vkCreateRenderPass2_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdBeginRenderPass2", out vkCmdBeginRenderPass2_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdNextSubpass2", out vkCmdNextSubpass2_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdEndRenderPass2", out vkCmdEndRenderPass2_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkResetQueryPool", out vkResetQueryPool_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetSemaphoreCounterValue", out vkGetSemaphoreCounterValue_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkWaitSemaphores", out vkWaitSemaphores_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkSignalSemaphore", out vkSignalSemaphore_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetBufferDeviceAddress", out vkGetBufferDeviceAddress_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetBufferOpaqueCaptureAddress", out vkGetBufferOpaqueCaptureAddress_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetDeviceMemoryOpaqueCaptureAddress", out vkGetDeviceMemoryOpaqueCaptureAddress_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroySurfaceKHR", out vkDestroySurfaceKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceSurfaceSupportKHR", out vkGetPhysicalDeviceSurfaceSupportKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceSurfaceCapabilitiesKHR", out vkGetPhysicalDeviceSurfaceCapabilitiesKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceSurfaceFormatsKHR", out vkGetPhysicalDeviceSurfaceFormatsKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceSurfacePresentModesKHR", out vkGetPhysicalDeviceSurfacePresentModesKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateSwapchainKHR", out vkCreateSwapchainKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroySwapchainKHR", out vkDestroySwapchainKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetSwapchainImagesKHR", out vkGetSwapchainImagesKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkAcquireNextImageKHR", out vkAcquireNextImageKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkQueuePresentKHR", out vkQueuePresentKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetDeviceGroupPresentCapabilitiesKHR", out vkGetDeviceGroupPresentCapabilitiesKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetDeviceGroupSurfacePresentModesKHR", out vkGetDeviceGroupSurfacePresentModesKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDevicePresentRectanglesKHR", out vkGetPhysicalDevicePresentRectanglesKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkAcquireNextImage2KHR", out vkAcquireNextImage2KHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceDisplayPropertiesKHR", out vkGetPhysicalDeviceDisplayPropertiesKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceDisplayPlanePropertiesKHR", out vkGetPhysicalDeviceDisplayPlanePropertiesKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetDisplayPlaneSupportedDisplaysKHR", out vkGetDisplayPlaneSupportedDisplaysKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetDisplayModePropertiesKHR", out vkGetDisplayModePropertiesKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateDisplayModeKHR", out vkCreateDisplayModeKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetDisplayPlaneCapabilitiesKHR", out vkGetDisplayPlaneCapabilitiesKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateDisplayPlaneSurfaceKHR", out vkCreateDisplayPlaneSurfaceKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateSharedSwapchainsKHR", out vkCreateSharedSwapchainsKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceFeatures2KHR", out vkGetPhysicalDeviceFeatures2KHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceProperties2KHR", out vkGetPhysicalDeviceProperties2KHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceFormatProperties2KHR", out vkGetPhysicalDeviceFormatProperties2KHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceImageFormatProperties2KHR", out vkGetPhysicalDeviceImageFormatProperties2KHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceQueueFamilyProperties2KHR", out vkGetPhysicalDeviceQueueFamilyProperties2KHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceMemoryProperties2KHR", out vkGetPhysicalDeviceMemoryProperties2KHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceSparseImageFormatProperties2KHR", out vkGetPhysicalDeviceSparseImageFormatProperties2KHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetDeviceGroupPeerMemoryFeaturesKHR", out vkGetDeviceGroupPeerMemoryFeaturesKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdSetDeviceMaskKHR", out vkCmdSetDeviceMaskKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdDispatchBaseKHR", out vkCmdDispatchBaseKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkTrimCommandPoolKHR", out vkTrimCommandPoolKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkEnumeratePhysicalDeviceGroupsKHR", out vkEnumeratePhysicalDeviceGroupsKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceExternalBufferPropertiesKHR", out vkGetPhysicalDeviceExternalBufferPropertiesKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetMemoryFdKHR", out vkGetMemoryFdKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetMemoryFdPropertiesKHR", out vkGetMemoryFdPropertiesKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceExternalSemaphorePropertiesKHR", out vkGetPhysicalDeviceExternalSemaphorePropertiesKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkImportSemaphoreFdKHR", out vkImportSemaphoreFdKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetSemaphoreFdKHR", out vkGetSemaphoreFdKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdPushDescriptorSetKHR", out vkCmdPushDescriptorSetKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdPushDescriptorSetWithTemplateKHR", out vkCmdPushDescriptorSetWithTemplateKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateDescriptorUpdateTemplateKHR", out vkCreateDescriptorUpdateTemplateKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyDescriptorUpdateTemplateKHR", out vkDestroyDescriptorUpdateTemplateKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkUpdateDescriptorSetWithTemplateKHR", out vkUpdateDescriptorSetWithTemplateKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateRenderPass2KHR", out vkCreateRenderPass2KHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdBeginRenderPass2KHR", out vkCmdBeginRenderPass2KHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdNextSubpass2KHR", out vkCmdNextSubpass2KHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdEndRenderPass2KHR", out vkCmdEndRenderPass2KHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetSwapchainStatusKHR", out vkGetSwapchainStatusKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceExternalFencePropertiesKHR", out vkGetPhysicalDeviceExternalFencePropertiesKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkImportFenceFdKHR", out vkImportFenceFdKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetFenceFdKHR", out vkGetFenceFdKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR", out vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR", out vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkAcquireProfilingLockKHR", out vkAcquireProfilingLockKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkReleaseProfilingLockKHR", out vkReleaseProfilingLockKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceSurfaceCapabilities2KHR", out vkGetPhysicalDeviceSurfaceCapabilities2KHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceSurfaceFormats2KHR", out vkGetPhysicalDeviceSurfaceFormats2KHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceDisplayProperties2KHR", out vkGetPhysicalDeviceDisplayProperties2KHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceDisplayPlaneProperties2KHR", out vkGetPhysicalDeviceDisplayPlaneProperties2KHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetDisplayModeProperties2KHR", out vkGetDisplayModeProperties2KHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetDisplayPlaneCapabilities2KHR", out vkGetDisplayPlaneCapabilities2KHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetImageMemoryRequirements2KHR", out vkGetImageMemoryRequirements2KHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetBufferMemoryRequirements2KHR", out vkGetBufferMemoryRequirements2KHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetImageSparseMemoryRequirements2KHR", out vkGetImageSparseMemoryRequirements2KHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateSamplerYcbcrConversionKHR", out vkCreateSamplerYcbcrConversionKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroySamplerYcbcrConversionKHR", out vkDestroySamplerYcbcrConversionKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkBindBufferMemory2KHR", out vkBindBufferMemory2KHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkBindImageMemory2KHR", out vkBindImageMemory2KHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetDescriptorSetLayoutSupportKHR", out vkGetDescriptorSetLayoutSupportKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdDrawIndirectCountKHR", out vkCmdDrawIndirectCountKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdDrawIndexedIndirectCountKHR", out vkCmdDrawIndexedIndirectCountKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetSemaphoreCounterValueKHR", out vkGetSemaphoreCounterValueKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkWaitSemaphoresKHR", out vkWaitSemaphoresKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkSignalSemaphoreKHR", out vkSignalSemaphoreKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetBufferDeviceAddressKHR", out vkGetBufferDeviceAddressKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetBufferOpaqueCaptureAddressKHR", out vkGetBufferOpaqueCaptureAddressKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetDeviceMemoryOpaqueCaptureAddressKHR", out vkGetDeviceMemoryOpaqueCaptureAddressKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPipelineExecutablePropertiesKHR", out vkGetPipelineExecutablePropertiesKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPipelineExecutableStatisticsKHR", out vkGetPipelineExecutableStatisticsKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPipelineExecutableInternalRepresentationsKHR", out vkGetPipelineExecutableInternalRepresentationsKHR_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateDebugReportCallbackEXT", out vkCreateDebugReportCallbackEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyDebugReportCallbackEXT", out vkDestroyDebugReportCallbackEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDebugReportMessageEXT", out vkDebugReportMessageEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDebugMarkerSetObjectTagEXT", out vkDebugMarkerSetObjectTagEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDebugMarkerSetObjectNameEXT", out vkDebugMarkerSetObjectNameEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdDebugMarkerBeginEXT", out vkCmdDebugMarkerBeginEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdDebugMarkerEndEXT", out vkCmdDebugMarkerEndEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdDebugMarkerInsertEXT", out vkCmdDebugMarkerInsertEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdBindTransformFeedbackBuffersEXT", out vkCmdBindTransformFeedbackBuffersEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdBeginTransformFeedbackEXT", out vkCmdBeginTransformFeedbackEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdEndTransformFeedbackEXT", out vkCmdEndTransformFeedbackEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdBeginQueryIndexedEXT", out vkCmdBeginQueryIndexedEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdEndQueryIndexedEXT", out vkCmdEndQueryIndexedEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdDrawIndirectByteCountEXT", out vkCmdDrawIndirectByteCountEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetImageViewHandleNVX", out vkGetImageViewHandleNVX_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdDrawIndirectCountAMD", out vkCmdDrawIndirectCountAMD_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdDrawIndexedIndirectCountAMD", out vkCmdDrawIndexedIndirectCountAMD_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetShaderInfoAMD", out vkGetShaderInfoAMD_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceExternalImageFormatPropertiesNV", out vkGetPhysicalDeviceExternalImageFormatPropertiesNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdBeginConditionalRenderingEXT", out vkCmdBeginConditionalRenderingEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdEndConditionalRenderingEXT", out vkCmdEndConditionalRenderingEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdProcessCommandsNVX", out vkCmdProcessCommandsNVX_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdReserveSpaceForCommandsNVX", out vkCmdReserveSpaceForCommandsNVX_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateIndirectCommandsLayoutNVX", out vkCreateIndirectCommandsLayoutNVX_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyIndirectCommandsLayoutNVX", out vkDestroyIndirectCommandsLayoutNVX_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateObjectTableNVX", out vkCreateObjectTableNVX_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyObjectTableNVX", out vkDestroyObjectTableNVX_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkRegisterObjectsNVX", out vkRegisterObjectsNVX_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkUnregisterObjectsNVX", out vkUnregisterObjectsNVX_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX", out vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdSetViewportWScalingNV", out vkCmdSetViewportWScalingNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkReleaseDisplayEXT", out vkReleaseDisplayEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceSurfaceCapabilities2EXT", out vkGetPhysicalDeviceSurfaceCapabilities2EXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDisplayPowerControlEXT", out vkDisplayPowerControlEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkRegisterDeviceEventEXT", out vkRegisterDeviceEventEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkRegisterDisplayEventEXT", out vkRegisterDisplayEventEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetSwapchainCounterEXT", out vkGetSwapchainCounterEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetRefreshCycleDurationGOOGLE", out vkGetRefreshCycleDurationGOOGLE_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPastPresentationTimingGOOGLE", out vkGetPastPresentationTimingGOOGLE_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdSetDiscardRectangleEXT", out vkCmdSetDiscardRectangleEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkSetHdrMetadataEXT", out vkSetHdrMetadataEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkSetDebugUtilsObjectNameEXT", out vkSetDebugUtilsObjectNameEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkSetDebugUtilsObjectTagEXT", out vkSetDebugUtilsObjectTagEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkQueueBeginDebugUtilsLabelEXT", out vkQueueBeginDebugUtilsLabelEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkQueueEndDebugUtilsLabelEXT", out vkQueueEndDebugUtilsLabelEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkQueueInsertDebugUtilsLabelEXT", out vkQueueInsertDebugUtilsLabelEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdBeginDebugUtilsLabelEXT", out vkCmdBeginDebugUtilsLabelEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdEndDebugUtilsLabelEXT", out vkCmdEndDebugUtilsLabelEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdInsertDebugUtilsLabelEXT", out vkCmdInsertDebugUtilsLabelEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateDebugUtilsMessengerEXT", out vkCreateDebugUtilsMessengerEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyDebugUtilsMessengerEXT", out vkDestroyDebugUtilsMessengerEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkSubmitDebugUtilsMessageEXT", out vkSubmitDebugUtilsMessageEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdSetSampleLocationsEXT", out vkCmdSetSampleLocationsEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceMultisamplePropertiesEXT", out vkGetPhysicalDeviceMultisamplePropertiesEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetImageDrmFormatModifierPropertiesEXT", out vkGetImageDrmFormatModifierPropertiesEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateValidationCacheEXT", out vkCreateValidationCacheEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyValidationCacheEXT", out vkDestroyValidationCacheEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkMergeValidationCachesEXT", out vkMergeValidationCachesEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetValidationCacheDataEXT", out vkGetValidationCacheDataEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdBindShadingRateImageNV", out vkCmdBindShadingRateImageNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdSetViewportShadingRatePaletteNV", out vkCmdSetViewportShadingRatePaletteNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdSetCoarseSampleOrderNV", out vkCmdSetCoarseSampleOrderNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateAccelerationStructureNV", out vkCreateAccelerationStructureNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkDestroyAccelerationStructureNV", out vkDestroyAccelerationStructureNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetAccelerationStructureMemoryRequirementsNV", out vkGetAccelerationStructureMemoryRequirementsNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkBindAccelerationStructureMemoryNV", out vkBindAccelerationStructureMemoryNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdBuildAccelerationStructureNV", out vkCmdBuildAccelerationStructureNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdCopyAccelerationStructureNV", out vkCmdCopyAccelerationStructureNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdTraceRaysNV", out vkCmdTraceRaysNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateRayTracingPipelinesNV", out vkCreateRayTracingPipelinesNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetRayTracingShaderGroupHandlesNV", out vkGetRayTracingShaderGroupHandlesNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetAccelerationStructureHandleNV", out vkGetAccelerationStructureHandleNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdWriteAccelerationStructuresPropertiesNV", out vkCmdWriteAccelerationStructuresPropertiesNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCompileDeferredNV", out vkCompileDeferredNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetMemoryHostPointerPropertiesEXT", out vkGetMemoryHostPointerPropertiesEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdWriteBufferMarkerAMD", out vkCmdWriteBufferMarkerAMD_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT", out vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetCalibratedTimestampsEXT", out vkGetCalibratedTimestampsEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdDrawMeshTasksNV", out vkCmdDrawMeshTasksNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdDrawMeshTasksIndirectNV", out vkCmdDrawMeshTasksIndirectNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdDrawMeshTasksIndirectCountNV", out vkCmdDrawMeshTasksIndirectCountNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdSetExclusiveScissorNV", out vkCmdSetExclusiveScissorNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdSetCheckpointNV", out vkCmdSetCheckpointNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetQueueCheckpointDataNV", out vkGetQueueCheckpointDataNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkInitializePerformanceApiINTEL", out vkInitializePerformanceApiINTEL_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkUninitializePerformanceApiINTEL", out vkUninitializePerformanceApiINTEL_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdSetPerformanceMarkerINTEL", out vkCmdSetPerformanceMarkerINTEL_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdSetPerformanceStreamMarkerINTEL", out vkCmdSetPerformanceStreamMarkerINTEL_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdSetPerformanceOverrideINTEL", out vkCmdSetPerformanceOverrideINTEL_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkAcquirePerformanceConfigurationINTEL", out vkAcquirePerformanceConfigurationINTEL_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkReleasePerformanceConfigurationINTEL", out vkReleasePerformanceConfigurationINTEL_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkQueueSetPerformanceConfigurationINTEL", out vkQueueSetPerformanceConfigurationINTEL_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPerformanceParameterINTEL", out vkGetPerformanceParameterINTEL_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkSetLocalDimmingAMD", out vkSetLocalDimmingAMD_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetBufferDeviceAddressEXT", out vkGetBufferDeviceAddressEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceToolPropertiesEXT", out vkGetPhysicalDeviceToolPropertiesEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceCooperativeMatrixPropertiesNV", out vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV", out vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCreateHeadlessSurfaceEXT", out vkCreateHeadlessSurfaceEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkCmdSetLineStippleEXT", out vkCmdSetLineStippleEXT_hndl);
			NativeLibrary.TryGetExport(libHndl, "vkResetQueryPoolEXT", out vkResetQueryPoolEXT_hndl);
		}
	}
}
