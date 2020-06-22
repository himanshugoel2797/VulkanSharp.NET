using System;
using System.Runtime.InteropServices;
namespace VulkanSharp.Raw {
	public unsafe static partial class Vk {
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateWin32SurfaceKHR(IntPtr instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pSurface);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool PFN_vkGetPhysicalDeviceWin32PresentationSupportKHR(IntPtr physicalDevice, uint queueFamilyIndex);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetMemoryWin32HandleKHR(IntPtr device, IntPtr pGetWin32HandleInfo, IntPtr* pHandle);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetMemoryWin32HandlePropertiesKHR(IntPtr device, VkExternalMemoryHandleTypeFlags handleType, IntPtr handle, IntPtr pMemoryWin32HandleProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkImportSemaphoreWin32HandleKHR(IntPtr device, IntPtr pImportSemaphoreWin32HandleInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetSemaphoreWin32HandleKHR(IntPtr device, IntPtr pGetWin32HandleInfo, IntPtr* pHandle);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkImportFenceWin32HandleKHR(IntPtr device, IntPtr pImportFenceWin32HandleInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetFenceWin32HandleKHR(IntPtr device, IntPtr pGetWin32HandleInfo, IntPtr* pHandle);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetMemoryWin32HandleNV(IntPtr device, IntPtr memory, VkExternalMemoryHandleTypeFlagsNV handleType, IntPtr* pHandle);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPhysicalDeviceSurfacePresentModes2EXT(IntPtr physicalDevice, IntPtr pSurfaceInfo, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkAcquireFullScreenExclusiveModeEXT(IntPtr device, IntPtr swapchain);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkReleaseFullScreenExclusiveModeEXT(IntPtr device, IntPtr swapchain);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetDeviceGroupSurfacePresentModes2EXT(IntPtr device, IntPtr pSurfaceInfo, VkDeviceGroupPresentModeFlagsKHR* pModes);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateWaylandSurfaceKHR(IntPtr instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pSurface);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool PFN_vkGetPhysicalDeviceWaylandPresentationSupportKHR(IntPtr physicalDevice, uint queueFamilyIndex, IntPtr display);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateXlibSurfaceKHR(IntPtr instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pSurface);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool PFN_vkGetPhysicalDeviceXlibPresentationSupportKHR(IntPtr physicalDevice, uint queueFamilyIndex, IntPtr dpy, IntPtr visualID);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr PFN_vkAllocationFunction(IntPtr pUserData, ulong size, ulong alignment, VkSystemAllocationScope allocationScope);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr PFN_vkReallocationFunction(IntPtr pUserData, IntPtr pOriginal, ulong size, ulong alignment, VkSystemAllocationScope allocationScope);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkFreeFunction(IntPtr pUserData, IntPtr pMemory);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkInternalAllocationNotification(IntPtr pUserData, ulong size, VkInternalAllocationType allocationType, VkSystemAllocationScope allocationScope);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkInternalFreeNotification(IntPtr pUserData, ulong size, VkInternalAllocationType allocationType, VkSystemAllocationScope allocationScope);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateInstance(IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pInstance);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyInstance(IntPtr instance, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkEnumeratePhysicalDevices(IntPtr instance, uint* pPhysicalDeviceCount, IntPtr* pPhysicalDevices);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceFeatures(IntPtr physicalDevice, IntPtr pFeatures);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceFormatProperties(IntPtr physicalDevice, VkFormat format, IntPtr pFormatProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPhysicalDeviceImageFormatProperties(IntPtr physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, IntPtr pImageFormatProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceProperties(IntPtr physicalDevice, IntPtr pProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceQueueFamilyProperties(IntPtr physicalDevice, uint* pQueueFamilyPropertyCount, IntPtr pQueueFamilyProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceMemoryProperties(IntPtr physicalDevice, IntPtr pMemoryProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateDevice(IntPtr physicalDevice, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pDevice);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyDevice(IntPtr device, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkEnumerateInstanceExtensionProperties(string pLayerName, uint* pPropertyCount, IntPtr pProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkEnumerateDeviceExtensionProperties(IntPtr physicalDevice, string pLayerName, uint* pPropertyCount, IntPtr pProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkEnumerateInstanceLayerProperties(uint* pPropertyCount, IntPtr pProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkEnumerateDeviceLayerProperties(IntPtr physicalDevice, uint* pPropertyCount, IntPtr pProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetDeviceQueue(IntPtr device, uint queueFamilyIndex, uint queueIndex, IntPtr* pQueue);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkQueueSubmit(IntPtr queue, uint submitCount, IntPtr pSubmits, IntPtr fence);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkQueueWaitIdle(IntPtr queue);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkDeviceWaitIdle(IntPtr device);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkAllocateMemory(IntPtr device, IntPtr pAllocateInfo, IntPtr pAllocator, IntPtr* pMemory);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkFreeMemory(IntPtr device, IntPtr memory, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkMapMemory(IntPtr device, IntPtr memory, ulong offset, ulong size, uint flags, void** ppData);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkUnmapMemory(IntPtr device, IntPtr memory);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkFlushMappedMemoryRanges(IntPtr device, uint memoryRangeCount, IntPtr pMemoryRanges);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkInvalidateMappedMemoryRanges(IntPtr device, uint memoryRangeCount, IntPtr pMemoryRanges);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetDeviceMemoryCommitment(IntPtr device, IntPtr memory, ulong* pCommittedMemoryInBytes);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkBindBufferMemory(IntPtr device, IntPtr buffer, IntPtr memory, ulong memoryOffset);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkBindImageMemory(IntPtr device, IntPtr image, IntPtr memory, ulong memoryOffset);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetBufferMemoryRequirements(IntPtr device, IntPtr buffer, IntPtr pMemoryRequirements);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetImageMemoryRequirements(IntPtr device, IntPtr image, IntPtr pMemoryRequirements);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetImageSparseMemoryRequirements(IntPtr device, IntPtr image, uint* pSparseMemoryRequirementCount, IntPtr pSparseMemoryRequirements);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceSparseImageFormatProperties(IntPtr physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, uint* pPropertyCount, IntPtr pProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkQueueBindSparse(IntPtr queue, uint bindInfoCount, IntPtr pBindInfo, IntPtr fence);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateFence(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pFence);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyFence(IntPtr device, IntPtr fence, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkResetFences(IntPtr device, uint fenceCount, IntPtr* pFences);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetFenceStatus(IntPtr device, IntPtr fence);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkWaitForFences(IntPtr device, uint fenceCount, IntPtr* pFences, bool waitAll, ulong timeout);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateSemaphore(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pSemaphore);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroySemaphore(IntPtr device, IntPtr semaphore, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateEvent(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pEvent);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyEvent(IntPtr device, IntPtr @event, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetEventStatus(IntPtr device, IntPtr @event);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkSetEvent(IntPtr device, IntPtr @event);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkResetEvent(IntPtr device, IntPtr @event);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateQueryPool(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pQueryPool);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyQueryPool(IntPtr device, IntPtr queryPool, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetQueryPoolResults(IntPtr device, IntPtr queryPool, uint firstQuery, uint queryCount, ulong dataSize, IntPtr pData, ulong stride, VkQueryResultFlags flags);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateBuffer(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pBuffer);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyBuffer(IntPtr device, IntPtr buffer, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateBufferView(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pView);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyBufferView(IntPtr device, IntPtr bufferView, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateImage(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pImage);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyImage(IntPtr device, IntPtr image, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetImageSubresourceLayout(IntPtr device, IntPtr image, IntPtr pSubresource, IntPtr pLayout);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateImageView(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pView);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyImageView(IntPtr device, IntPtr imageView, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateShaderModule(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pShaderModule);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyShaderModule(IntPtr device, IntPtr shaderModule, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreatePipelineCache(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pPipelineCache);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyPipelineCache(IntPtr device, IntPtr pipelineCache, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPipelineCacheData(IntPtr device, IntPtr pipelineCache, ulong* pDataSize, IntPtr pData);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkMergePipelineCaches(IntPtr device, IntPtr dstCache, uint srcCacheCount, IntPtr* pSrcCaches);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateGraphicsPipelines(IntPtr device, IntPtr pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr* pPipelines);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateComputePipelines(IntPtr device, IntPtr pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr* pPipelines);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyPipeline(IntPtr device, IntPtr pipeline, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreatePipelineLayout(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pPipelineLayout);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyPipelineLayout(IntPtr device, IntPtr pipelineLayout, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateSampler(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pSampler);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroySampler(IntPtr device, IntPtr sampler, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateDescriptorSetLayout(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pSetLayout);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyDescriptorSetLayout(IntPtr device, IntPtr descriptorSetLayout, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateDescriptorPool(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pDescriptorPool);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyDescriptorPool(IntPtr device, IntPtr descriptorPool, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkResetDescriptorPool(IntPtr device, IntPtr descriptorPool, uint flags);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkAllocateDescriptorSets(IntPtr device, IntPtr pAllocateInfo, IntPtr* pDescriptorSets);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkFreeDescriptorSets(IntPtr device, IntPtr descriptorPool, uint descriptorSetCount, IntPtr* pDescriptorSets);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkUpdateDescriptorSets(IntPtr device, uint descriptorWriteCount, IntPtr pDescriptorWrites, uint descriptorCopyCount, IntPtr pDescriptorCopies);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateFramebuffer(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pFramebuffer);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyFramebuffer(IntPtr device, IntPtr framebuffer, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateRenderPass(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pRenderPass);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyRenderPass(IntPtr device, IntPtr renderPass, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetRenderAreaGranularity(IntPtr device, IntPtr renderPass, IntPtr pGranularity);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateCommandPool(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pCommandPool);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyCommandPool(IntPtr device, IntPtr commandPool, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkResetCommandPool(IntPtr device, IntPtr commandPool, VkCommandPoolResetFlags flags);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkAllocateCommandBuffers(IntPtr device, IntPtr pAllocateInfo, IntPtr* pCommandBuffers);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkFreeCommandBuffers(IntPtr device, IntPtr commandPool, uint commandBufferCount, IntPtr* pCommandBuffers);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkBeginCommandBuffer(IntPtr commandBuffer, IntPtr pBeginInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkEndCommandBuffer(IntPtr commandBuffer);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkResetCommandBuffer(IntPtr commandBuffer, VkCommandBufferResetFlags flags);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdBindPipeline(IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, IntPtr pipeline);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdSetViewport(IntPtr commandBuffer, uint firstViewport, uint viewportCount, IntPtr pViewports);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdSetScissor(IntPtr commandBuffer, uint firstScissor, uint scissorCount, IntPtr pScissors);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdSetLineWidth(IntPtr commandBuffer, float lineWidth);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdSetDepthBias(IntPtr commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdSetBlendConstants(IntPtr commandBuffer, [MarshalAs(UnmanagedType.LPArray, SizeConst=4)] float[] blendConstants);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdSetDepthBounds(IntPtr commandBuffer, float minDepthBounds, float maxDepthBounds);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdSetStencilCompareMask(IntPtr commandBuffer, VkStencilFaceFlags faceMask, uint compareMask);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdSetStencilWriteMask(IntPtr commandBuffer, VkStencilFaceFlags faceMask, uint writeMask);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdSetStencilReference(IntPtr commandBuffer, VkStencilFaceFlags faceMask, uint reference);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdBindDescriptorSets(IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, IntPtr layout, uint firstSet, uint descriptorSetCount, IntPtr* pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdBindIndexBuffer(IntPtr commandBuffer, IntPtr buffer, ulong offset, VkIndexType indexType);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdBindVertexBuffers(IntPtr commandBuffer, uint firstBinding, uint bindingCount, IntPtr* pBuffers, ulong* pOffsets);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdDraw(IntPtr commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdDrawIndexed(IntPtr commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdDrawIndirect(IntPtr commandBuffer, IntPtr buffer, ulong offset, uint drawCount, uint stride);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdDrawIndexedIndirect(IntPtr commandBuffer, IntPtr buffer, ulong offset, uint drawCount, uint stride);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdDispatch(IntPtr commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdDispatchIndirect(IntPtr commandBuffer, IntPtr buffer, ulong offset);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdCopyBuffer(IntPtr commandBuffer, IntPtr srcBuffer, IntPtr dstBuffer, uint regionCount, IntPtr pRegions);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdCopyImage(IntPtr commandBuffer, IntPtr srcImage, VkImageLayout srcImageLayout, IntPtr dstImage, VkImageLayout dstImageLayout, uint regionCount, IntPtr pRegions);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdBlitImage(IntPtr commandBuffer, IntPtr srcImage, VkImageLayout srcImageLayout, IntPtr dstImage, VkImageLayout dstImageLayout, uint regionCount, IntPtr pRegions, VkFilter filter);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdCopyBufferToImage(IntPtr commandBuffer, IntPtr srcBuffer, IntPtr dstImage, VkImageLayout dstImageLayout, uint regionCount, IntPtr pRegions);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdCopyImageToBuffer(IntPtr commandBuffer, IntPtr srcImage, VkImageLayout srcImageLayout, IntPtr dstBuffer, uint regionCount, IntPtr pRegions);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdUpdateBuffer(IntPtr commandBuffer, IntPtr dstBuffer, ulong dstOffset, ulong dataSize, IntPtr pData);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdFillBuffer(IntPtr commandBuffer, IntPtr dstBuffer, ulong dstOffset, ulong size, uint data);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdClearColorImage(IntPtr commandBuffer, IntPtr image, VkImageLayout imageLayout, IntPtr pColor, uint rangeCount, IntPtr pRanges);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdClearDepthStencilImage(IntPtr commandBuffer, IntPtr image, VkImageLayout imageLayout, IntPtr pDepthStencil, uint rangeCount, IntPtr pRanges);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdClearAttachments(IntPtr commandBuffer, uint attachmentCount, IntPtr pAttachments, uint rectCount, IntPtr pRects);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdResolveImage(IntPtr commandBuffer, IntPtr srcImage, VkImageLayout srcImageLayout, IntPtr dstImage, VkImageLayout dstImageLayout, uint regionCount, IntPtr pRegions);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdSetEvent(IntPtr commandBuffer, IntPtr @event, VkPipelineStageFlags stageMask);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdResetEvent(IntPtr commandBuffer, IntPtr @event, VkPipelineStageFlags stageMask);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdWaitEvents(IntPtr commandBuffer, uint eventCount, IntPtr* pEvents, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, uint memoryBarrierCount, IntPtr pMemoryBarriers, uint bufferMemoryBarrierCount, IntPtr pBufferMemoryBarriers, uint imageMemoryBarrierCount, IntPtr pImageMemoryBarriers);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdPipelineBarrier(IntPtr commandBuffer, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, VkDependencyFlags dependencyFlags, uint memoryBarrierCount, IntPtr pMemoryBarriers, uint bufferMemoryBarrierCount, IntPtr pBufferMemoryBarriers, uint imageMemoryBarrierCount, IntPtr pImageMemoryBarriers);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdBeginQuery(IntPtr commandBuffer, IntPtr queryPool, uint query, VkQueryControlFlags flags);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdEndQuery(IntPtr commandBuffer, IntPtr queryPool, uint query);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdResetQueryPool(IntPtr commandBuffer, IntPtr queryPool, uint firstQuery, uint queryCount);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdWriteTimestamp(IntPtr commandBuffer, VkPipelineStageFlags pipelineStage, IntPtr queryPool, uint query);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdCopyQueryPoolResults(IntPtr commandBuffer, IntPtr queryPool, uint firstQuery, uint queryCount, IntPtr dstBuffer, ulong dstOffset, ulong stride, VkQueryResultFlags flags);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdPushConstants(IntPtr commandBuffer, IntPtr layout, VkShaderStageFlags stageFlags, uint offset, uint size, IntPtr pValues);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdBeginRenderPass(IntPtr commandBuffer, IntPtr pRenderPassBegin, VkSubpassContents contents);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdNextSubpass(IntPtr commandBuffer, VkSubpassContents contents);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdEndRenderPass(IntPtr commandBuffer);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdExecuteCommands(IntPtr commandBuffer, uint commandBufferCount, IntPtr* pCommandBuffers);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkEnumerateInstanceVersion(uint* pApiVersion);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkBindBufferMemory2(IntPtr device, uint bindInfoCount, IntPtr pBindInfos);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkBindImageMemory2(IntPtr device, uint bindInfoCount, IntPtr pBindInfos);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetDeviceGroupPeerMemoryFeatures(IntPtr device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, VkPeerMemoryFeatureFlags* pPeerMemoryFeatures);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdSetDeviceMask(IntPtr commandBuffer, uint deviceMask);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdDispatchBase(IntPtr commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkEnumeratePhysicalDeviceGroups(IntPtr instance, uint* pPhysicalDeviceGroupCount, IntPtr pPhysicalDeviceGroupProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetImageMemoryRequirements2(IntPtr device, IntPtr pInfo, IntPtr pMemoryRequirements);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetBufferMemoryRequirements2(IntPtr device, IntPtr pInfo, IntPtr pMemoryRequirements);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetImageSparseMemoryRequirements2(IntPtr device, IntPtr pInfo, uint* pSparseMemoryRequirementCount, IntPtr pSparseMemoryRequirements);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceFeatures2(IntPtr physicalDevice, IntPtr pFeatures);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceProperties2(IntPtr physicalDevice, IntPtr pProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceFormatProperties2(IntPtr physicalDevice, VkFormat format, IntPtr pFormatProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPhysicalDeviceImageFormatProperties2(IntPtr physicalDevice, IntPtr pImageFormatInfo, IntPtr pImageFormatProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceQueueFamilyProperties2(IntPtr physicalDevice, uint* pQueueFamilyPropertyCount, IntPtr pQueueFamilyProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceMemoryProperties2(IntPtr physicalDevice, IntPtr pMemoryProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceSparseImageFormatProperties2(IntPtr physicalDevice, IntPtr pFormatInfo, uint* pPropertyCount, IntPtr pProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkTrimCommandPool(IntPtr device, IntPtr commandPool, uint flags);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetDeviceQueue2(IntPtr device, IntPtr pQueueInfo, IntPtr* pQueue);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateSamplerYcbcrConversion(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pYcbcrConversion);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroySamplerYcbcrConversion(IntPtr device, IntPtr ycbcrConversion, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateDescriptorUpdateTemplate(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pDescriptorUpdateTemplate);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyDescriptorUpdateTemplate(IntPtr device, IntPtr descriptorUpdateTemplate, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkUpdateDescriptorSetWithTemplate(IntPtr device, IntPtr descriptorSet, IntPtr descriptorUpdateTemplate, IntPtr pData);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceExternalBufferProperties(IntPtr physicalDevice, IntPtr pExternalBufferInfo, IntPtr pExternalBufferProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceExternalFenceProperties(IntPtr physicalDevice, IntPtr pExternalFenceInfo, IntPtr pExternalFenceProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceExternalSemaphoreProperties(IntPtr physicalDevice, IntPtr pExternalSemaphoreInfo, IntPtr pExternalSemaphoreProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetDescriptorSetLayoutSupport(IntPtr device, IntPtr pCreateInfo, IntPtr pSupport);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdDrawIndirectCount(IntPtr commandBuffer, IntPtr buffer, ulong offset, IntPtr countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdDrawIndexedIndirectCount(IntPtr commandBuffer, IntPtr buffer, ulong offset, IntPtr countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateRenderPass2(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pRenderPass);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdBeginRenderPass2(IntPtr commandBuffer, IntPtr pRenderPassBegin, IntPtr pSubpassBeginInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdNextSubpass2(IntPtr commandBuffer, IntPtr pSubpassBeginInfo, IntPtr pSubpassEndInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdEndRenderPass2(IntPtr commandBuffer, IntPtr pSubpassEndInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkResetQueryPool(IntPtr device, IntPtr queryPool, uint firstQuery, uint queryCount);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetSemaphoreCounterValue(IntPtr device, IntPtr semaphore, ulong* pValue);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkWaitSemaphores(IntPtr device, IntPtr pWaitInfo, ulong timeout);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkSignalSemaphore(IntPtr device, IntPtr pSignalInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate ulong PFN_vkGetBufferDeviceAddress(IntPtr device, IntPtr pInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate ulong PFN_vkGetBufferOpaqueCaptureAddress(IntPtr device, IntPtr pInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate ulong PFN_vkGetDeviceMemoryOpaqueCaptureAddress(IntPtr device, IntPtr pInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroySurfaceKHR(IntPtr instance, IntPtr surface, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPhysicalDeviceSurfaceSupportKHR(IntPtr physicalDevice, uint queueFamilyIndex, IntPtr surface, bool* pSupported);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPhysicalDeviceSurfaceCapabilitiesKHR(IntPtr physicalDevice, IntPtr surface, IntPtr pSurfaceCapabilities);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPhysicalDeviceSurfaceFormatsKHR(IntPtr physicalDevice, IntPtr surface, uint* pSurfaceFormatCount, IntPtr pSurfaceFormats);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPhysicalDeviceSurfacePresentModesKHR(IntPtr physicalDevice, IntPtr surface, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateSwapchainKHR(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pSwapchain);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroySwapchainKHR(IntPtr device, IntPtr swapchain, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetSwapchainImagesKHR(IntPtr device, IntPtr swapchain, uint* pSwapchainImageCount, IntPtr* pSwapchainImages);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkAcquireNextImageKHR(IntPtr device, IntPtr swapchain, ulong timeout, IntPtr semaphore, IntPtr fence, uint* pImageIndex);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkQueuePresentKHR(IntPtr queue, IntPtr pPresentInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetDeviceGroupPresentCapabilitiesKHR(IntPtr device, IntPtr pDeviceGroupPresentCapabilities);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetDeviceGroupSurfacePresentModesKHR(IntPtr device, IntPtr surface, VkDeviceGroupPresentModeFlagsKHR* pModes);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPhysicalDevicePresentRectanglesKHR(IntPtr physicalDevice, IntPtr surface, uint* pRectCount, IntPtr pRects);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkAcquireNextImage2KHR(IntPtr device, IntPtr pAcquireInfo, uint* pImageIndex);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPhysicalDeviceDisplayPropertiesKHR(IntPtr physicalDevice, uint* pPropertyCount, IntPtr pProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPhysicalDeviceDisplayPlanePropertiesKHR(IntPtr physicalDevice, uint* pPropertyCount, IntPtr pProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetDisplayPlaneSupportedDisplaysKHR(IntPtr physicalDevice, uint planeIndex, uint* pDisplayCount, IntPtr* pDisplays);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetDisplayModePropertiesKHR(IntPtr physicalDevice, IntPtr display, uint* pPropertyCount, IntPtr pProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateDisplayModeKHR(IntPtr physicalDevice, IntPtr display, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pMode);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetDisplayPlaneCapabilitiesKHR(IntPtr physicalDevice, IntPtr mode, uint planeIndex, IntPtr pCapabilities);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateDisplayPlaneSurfaceKHR(IntPtr instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pSurface);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateSharedSwapchainsKHR(IntPtr device, uint swapchainCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr* pSwapchains);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceFeatures2KHR(IntPtr physicalDevice, IntPtr pFeatures);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceProperties2KHR(IntPtr physicalDevice, IntPtr pProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceFormatProperties2KHR(IntPtr physicalDevice, VkFormat format, IntPtr pFormatProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPhysicalDeviceImageFormatProperties2KHR(IntPtr physicalDevice, IntPtr pImageFormatInfo, IntPtr pImageFormatProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceQueueFamilyProperties2KHR(IntPtr physicalDevice, uint* pQueueFamilyPropertyCount, IntPtr pQueueFamilyProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceMemoryProperties2KHR(IntPtr physicalDevice, IntPtr pMemoryProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceSparseImageFormatProperties2KHR(IntPtr physicalDevice, IntPtr pFormatInfo, uint* pPropertyCount, IntPtr pProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetDeviceGroupPeerMemoryFeaturesKHR(IntPtr device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, VkPeerMemoryFeatureFlags* pPeerMemoryFeatures);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdSetDeviceMaskKHR(IntPtr commandBuffer, uint deviceMask);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdDispatchBaseKHR(IntPtr commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkTrimCommandPoolKHR(IntPtr device, IntPtr commandPool, uint flags);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkEnumeratePhysicalDeviceGroupsKHR(IntPtr instance, uint* pPhysicalDeviceGroupCount, IntPtr pPhysicalDeviceGroupProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceExternalBufferPropertiesKHR(IntPtr physicalDevice, IntPtr pExternalBufferInfo, IntPtr pExternalBufferProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetMemoryFdKHR(IntPtr device, IntPtr pGetFdInfo, int* pFd);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetMemoryFdPropertiesKHR(IntPtr device, VkExternalMemoryHandleTypeFlags handleType, int fd, IntPtr pMemoryFdProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceExternalSemaphorePropertiesKHR(IntPtr physicalDevice, IntPtr pExternalSemaphoreInfo, IntPtr pExternalSemaphoreProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkImportSemaphoreFdKHR(IntPtr device, IntPtr pImportSemaphoreFdInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetSemaphoreFdKHR(IntPtr device, IntPtr pGetFdInfo, int* pFd);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdPushDescriptorSetKHR(IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, IntPtr layout, uint set, uint descriptorWriteCount, IntPtr pDescriptorWrites);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdPushDescriptorSetWithTemplateKHR(IntPtr commandBuffer, IntPtr descriptorUpdateTemplate, IntPtr layout, uint set, IntPtr pData);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateDescriptorUpdateTemplateKHR(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pDescriptorUpdateTemplate);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyDescriptorUpdateTemplateKHR(IntPtr device, IntPtr descriptorUpdateTemplate, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkUpdateDescriptorSetWithTemplateKHR(IntPtr device, IntPtr descriptorSet, IntPtr descriptorUpdateTemplate, IntPtr pData);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateRenderPass2KHR(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pRenderPass);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdBeginRenderPass2KHR(IntPtr commandBuffer, IntPtr pRenderPassBegin, IntPtr pSubpassBeginInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdNextSubpass2KHR(IntPtr commandBuffer, IntPtr pSubpassBeginInfo, IntPtr pSubpassEndInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdEndRenderPass2KHR(IntPtr commandBuffer, IntPtr pSubpassEndInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetSwapchainStatusKHR(IntPtr device, IntPtr swapchain);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceExternalFencePropertiesKHR(IntPtr physicalDevice, IntPtr pExternalFenceInfo, IntPtr pExternalFenceProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkImportFenceFdKHR(IntPtr device, IntPtr pImportFenceFdInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetFenceFdKHR(IntPtr device, IntPtr pGetFdInfo, int* pFd);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(IntPtr physicalDevice, uint queueFamilyIndex, uint* pCounterCount, IntPtr pCounters, IntPtr pCounterDescriptions);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(IntPtr physicalDevice, IntPtr pPerformanceQueryCreateInfo, uint* pNumPasses);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkAcquireProfilingLockKHR(IntPtr device, IntPtr pInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkReleaseProfilingLockKHR(IntPtr device);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPhysicalDeviceSurfaceCapabilities2KHR(IntPtr physicalDevice, IntPtr pSurfaceInfo, IntPtr pSurfaceCapabilities);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPhysicalDeviceSurfaceFormats2KHR(IntPtr physicalDevice, IntPtr pSurfaceInfo, uint* pSurfaceFormatCount, IntPtr pSurfaceFormats);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPhysicalDeviceDisplayProperties2KHR(IntPtr physicalDevice, uint* pPropertyCount, IntPtr pProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPhysicalDeviceDisplayPlaneProperties2KHR(IntPtr physicalDevice, uint* pPropertyCount, IntPtr pProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetDisplayModeProperties2KHR(IntPtr physicalDevice, IntPtr display, uint* pPropertyCount, IntPtr pProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetDisplayPlaneCapabilities2KHR(IntPtr physicalDevice, IntPtr pDisplayPlaneInfo, IntPtr pCapabilities);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetImageMemoryRequirements2KHR(IntPtr device, IntPtr pInfo, IntPtr pMemoryRequirements);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetBufferMemoryRequirements2KHR(IntPtr device, IntPtr pInfo, IntPtr pMemoryRequirements);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetImageSparseMemoryRequirements2KHR(IntPtr device, IntPtr pInfo, uint* pSparseMemoryRequirementCount, IntPtr pSparseMemoryRequirements);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateSamplerYcbcrConversionKHR(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pYcbcrConversion);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroySamplerYcbcrConversionKHR(IntPtr device, IntPtr ycbcrConversion, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkBindBufferMemory2KHR(IntPtr device, uint bindInfoCount, IntPtr pBindInfos);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkBindImageMemory2KHR(IntPtr device, uint bindInfoCount, IntPtr pBindInfos);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetDescriptorSetLayoutSupportKHR(IntPtr device, IntPtr pCreateInfo, IntPtr pSupport);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdDrawIndirectCountKHR(IntPtr commandBuffer, IntPtr buffer, ulong offset, IntPtr countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdDrawIndexedIndirectCountKHR(IntPtr commandBuffer, IntPtr buffer, ulong offset, IntPtr countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetSemaphoreCounterValueKHR(IntPtr device, IntPtr semaphore, ulong* pValue);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkWaitSemaphoresKHR(IntPtr device, IntPtr pWaitInfo, ulong timeout);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkSignalSemaphoreKHR(IntPtr device, IntPtr pSignalInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate ulong PFN_vkGetBufferDeviceAddressKHR(IntPtr device, IntPtr pInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate ulong PFN_vkGetBufferOpaqueCaptureAddressKHR(IntPtr device, IntPtr pInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate ulong PFN_vkGetDeviceMemoryOpaqueCaptureAddressKHR(IntPtr device, IntPtr pInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPipelineExecutablePropertiesKHR(IntPtr device, IntPtr pPipelineInfo, uint* pExecutableCount, IntPtr pProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPipelineExecutableStatisticsKHR(IntPtr device, IntPtr pExecutableInfo, uint* pStatisticCount, IntPtr pStatistics);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPipelineExecutableInternalRepresentationsKHR(IntPtr device, IntPtr pExecutableInfo, uint* pInternalRepresentationCount, IntPtr pInternalRepresentations);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool PFN_vkDebugReportCallbackEXT(VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, ulong location, int messageCode, string pLayerPrefix, string pMessage, IntPtr pUserData);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateDebugReportCallbackEXT(IntPtr instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pCallback);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyDebugReportCallbackEXT(IntPtr instance, IntPtr callback, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDebugReportMessageEXT(IntPtr instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, ulong location, int messageCode, string pLayerPrefix, string pMessage);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkDebugMarkerSetObjectTagEXT(IntPtr device, IntPtr pTagInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkDebugMarkerSetObjectNameEXT(IntPtr device, IntPtr pNameInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdDebugMarkerBeginEXT(IntPtr commandBuffer, IntPtr pMarkerInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdDebugMarkerEndEXT(IntPtr commandBuffer);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdDebugMarkerInsertEXT(IntPtr commandBuffer, IntPtr pMarkerInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdBindTransformFeedbackBuffersEXT(IntPtr commandBuffer, uint firstBinding, uint bindingCount, IntPtr* pBuffers, ulong* pOffsets, ulong* pSizes);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdBeginTransformFeedbackEXT(IntPtr commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr* pCounterBuffers, ulong* pCounterBufferOffsets);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdEndTransformFeedbackEXT(IntPtr commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr* pCounterBuffers, ulong* pCounterBufferOffsets);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdBeginQueryIndexedEXT(IntPtr commandBuffer, IntPtr queryPool, uint query, VkQueryControlFlags flags, uint index);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdEndQueryIndexedEXT(IntPtr commandBuffer, IntPtr queryPool, uint query, uint index);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdDrawIndirectByteCountEXT(IntPtr commandBuffer, uint instanceCount, uint firstInstance, IntPtr counterBuffer, ulong counterBufferOffset, uint counterOffset, uint vertexStride);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate uint PFN_vkGetImageViewHandleNVX(IntPtr device, IntPtr pInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetImageViewAddressNVX(IntPtr device, IntPtr imageView, IntPtr pProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdDrawIndirectCountAMD(IntPtr commandBuffer, IntPtr buffer, ulong offset, IntPtr countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdDrawIndexedIndirectCountAMD(IntPtr commandBuffer, IntPtr buffer, ulong offset, IntPtr countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetShaderInfoAMD(IntPtr device, IntPtr pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, ulong* pInfoSize, IntPtr pInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPhysicalDeviceExternalImageFormatPropertiesNV(IntPtr physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, IntPtr pExternalImageFormatProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdBeginConditionalRenderingEXT(IntPtr commandBuffer, IntPtr pConditionalRenderingBegin);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdEndConditionalRenderingEXT(IntPtr commandBuffer);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdSetViewportWScalingNV(IntPtr commandBuffer, uint firstViewport, uint viewportCount, IntPtr pViewportWScalings);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkReleaseDisplayEXT(IntPtr physicalDevice, IntPtr display);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPhysicalDeviceSurfaceCapabilities2EXT(IntPtr physicalDevice, IntPtr surface, IntPtr pSurfaceCapabilities);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkDisplayPowerControlEXT(IntPtr device, IntPtr display, IntPtr pDisplayPowerInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkRegisterDeviceEventEXT(IntPtr device, IntPtr pDeviceEventInfo, IntPtr pAllocator, IntPtr* pFence);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkRegisterDisplayEventEXT(IntPtr device, IntPtr display, IntPtr pDisplayEventInfo, IntPtr pAllocator, IntPtr* pFence);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetSwapchainCounterEXT(IntPtr device, IntPtr swapchain, VkSurfaceCounterFlagsEXT counter, ulong* pCounterValue);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetRefreshCycleDurationGOOGLE(IntPtr device, IntPtr swapchain, IntPtr pDisplayTimingProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPastPresentationTimingGOOGLE(IntPtr device, IntPtr swapchain, uint* pPresentationTimingCount, IntPtr pPresentationTimings);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdSetDiscardRectangleEXT(IntPtr commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, IntPtr pDiscardRectangles);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkSetHdrMetadataEXT(IntPtr device, uint swapchainCount, IntPtr* pSwapchains, IntPtr pMetadata);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool PFN_vkDebugUtilsMessengerCallbackEXT(VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, IntPtr pCallbackData, IntPtr pUserData);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkSetDebugUtilsObjectNameEXT(IntPtr device, IntPtr pNameInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkSetDebugUtilsObjectTagEXT(IntPtr device, IntPtr pTagInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkQueueBeginDebugUtilsLabelEXT(IntPtr queue, IntPtr pLabelInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkQueueEndDebugUtilsLabelEXT(IntPtr queue);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkQueueInsertDebugUtilsLabelEXT(IntPtr queue, IntPtr pLabelInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdBeginDebugUtilsLabelEXT(IntPtr commandBuffer, IntPtr pLabelInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdEndDebugUtilsLabelEXT(IntPtr commandBuffer);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdInsertDebugUtilsLabelEXT(IntPtr commandBuffer, IntPtr pLabelInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateDebugUtilsMessengerEXT(IntPtr instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pMessenger);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyDebugUtilsMessengerEXT(IntPtr instance, IntPtr messenger, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkSubmitDebugUtilsMessageEXT(IntPtr instance, VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, IntPtr pCallbackData);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdSetSampleLocationsEXT(IntPtr commandBuffer, IntPtr pSampleLocationsInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPhysicalDeviceMultisamplePropertiesEXT(IntPtr physicalDevice, VkSampleCountFlags samples, IntPtr pMultisampleProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetImageDrmFormatModifierPropertiesEXT(IntPtr device, IntPtr image, IntPtr pProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateValidationCacheEXT(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pValidationCache);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyValidationCacheEXT(IntPtr device, IntPtr validationCache, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkMergeValidationCachesEXT(IntPtr device, IntPtr dstCache, uint srcCacheCount, IntPtr* pSrcCaches);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetValidationCacheDataEXT(IntPtr device, IntPtr validationCache, ulong* pDataSize, IntPtr pData);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdBindShadingRateImageNV(IntPtr commandBuffer, IntPtr imageView, VkImageLayout imageLayout);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdSetViewportShadingRatePaletteNV(IntPtr commandBuffer, uint firstViewport, uint viewportCount, IntPtr pShadingRatePalettes);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdSetCoarseSampleOrderNV(IntPtr commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, IntPtr pCustomSampleOrders);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateAccelerationStructureNV(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pAccelerationStructure);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyAccelerationStructureKHR(IntPtr device, IntPtr accelerationStructure, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyAccelerationStructureNV(IntPtr device, IntPtr accelerationStructure, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetAccelerationStructureMemoryRequirementsNV(IntPtr device, IntPtr pInfo, IntPtr pMemoryRequirements);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkBindAccelerationStructureMemoryKHR(IntPtr device, uint bindInfoCount, IntPtr pBindInfos);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkBindAccelerationStructureMemoryNV(IntPtr device, uint bindInfoCount, IntPtr pBindInfos);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdBuildAccelerationStructureNV(IntPtr commandBuffer, IntPtr pInfo, IntPtr instanceData, ulong instanceOffset, bool update, IntPtr dst, IntPtr src, IntPtr scratch, ulong scratchOffset);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdCopyAccelerationStructureNV(IntPtr commandBuffer, IntPtr dst, IntPtr src, VkCopyAccelerationStructureModeKHR mode);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdTraceRaysNV(IntPtr commandBuffer, IntPtr raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, IntPtr missShaderBindingTableBuffer, ulong missShaderBindingOffset, ulong missShaderBindingStride, IntPtr hitShaderBindingTableBuffer, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, IntPtr callableShaderBindingTableBuffer, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateRayTracingPipelinesNV(IntPtr device, IntPtr pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr* pPipelines);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetRayTracingShaderGroupHandlesKHR(IntPtr device, IntPtr pipeline, uint firstGroup, uint groupCount, ulong dataSize, IntPtr pData);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetRayTracingShaderGroupHandlesNV(IntPtr device, IntPtr pipeline, uint firstGroup, uint groupCount, ulong dataSize, IntPtr pData);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetAccelerationStructureHandleNV(IntPtr device, IntPtr accelerationStructure, ulong dataSize, IntPtr pData);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdWriteAccelerationStructuresPropertiesKHR(IntPtr commandBuffer, uint accelerationStructureCount, IntPtr* pAccelerationStructures, VkQueryType queryType, IntPtr queryPool, uint firstQuery);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdWriteAccelerationStructuresPropertiesNV(IntPtr commandBuffer, uint accelerationStructureCount, IntPtr* pAccelerationStructures, VkQueryType queryType, IntPtr queryPool, uint firstQuery);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCompileDeferredNV(IntPtr device, IntPtr pipeline, uint shader);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetMemoryHostPointerPropertiesEXT(IntPtr device, VkExternalMemoryHandleTypeFlags handleType, IntPtr pHostPointer, IntPtr pMemoryHostPointerProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdWriteBufferMarkerAMD(IntPtr commandBuffer, VkPipelineStageFlags pipelineStage, IntPtr dstBuffer, ulong dstOffset, uint marker);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(IntPtr physicalDevice, uint* pTimeDomainCount, VkTimeDomainEXT* pTimeDomains);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetCalibratedTimestampsEXT(IntPtr device, uint timestampCount, IntPtr pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdDrawMeshTasksNV(IntPtr commandBuffer, uint taskCount, uint firstTask);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdDrawMeshTasksIndirectNV(IntPtr commandBuffer, IntPtr buffer, ulong offset, uint drawCount, uint stride);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdDrawMeshTasksIndirectCountNV(IntPtr commandBuffer, IntPtr buffer, ulong offset, IntPtr countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdSetExclusiveScissorNV(IntPtr commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, IntPtr pExclusiveScissors);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdSetCheckpointNV(IntPtr commandBuffer, IntPtr pCheckpointMarker);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetQueueCheckpointDataNV(IntPtr queue, uint* pCheckpointDataCount, IntPtr pCheckpointData);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkInitializePerformanceApiINTEL(IntPtr device, IntPtr pInitializeInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkUninitializePerformanceApiINTEL(IntPtr device);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCmdSetPerformanceMarkerINTEL(IntPtr commandBuffer, IntPtr pMarkerInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCmdSetPerformanceStreamMarkerINTEL(IntPtr commandBuffer, IntPtr pMarkerInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCmdSetPerformanceOverrideINTEL(IntPtr commandBuffer, IntPtr pOverrideInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkAcquirePerformanceConfigurationINTEL(IntPtr device, IntPtr pAcquireInfo, IntPtr* pConfiguration);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkReleasePerformanceConfigurationINTEL(IntPtr device, IntPtr configuration);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkQueueSetPerformanceConfigurationINTEL(IntPtr queue, IntPtr configuration);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPerformanceParameterINTEL(IntPtr device, VkPerformanceParameterTypeINTEL parameter, IntPtr pValue);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkSetLocalDimmingAMD(IntPtr device, IntPtr swapChain, bool localDimmingEnable);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate ulong PFN_vkGetBufferDeviceAddressEXT(IntPtr device, IntPtr pInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPhysicalDeviceToolPropertiesEXT(IntPtr physicalDevice, uint* pToolCount, IntPtr pToolProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(IntPtr physicalDevice, uint* pPropertyCount, IntPtr pProperties);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(IntPtr physicalDevice, uint* pCombinationCount, IntPtr pCombinations);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateHeadlessSurfaceEXT(IntPtr instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pSurface);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdSetLineStippleEXT(IntPtr commandBuffer, uint lineStippleFactor, ushort lineStipplePattern);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkResetQueryPoolEXT(IntPtr device, IntPtr queryPool, uint firstQuery, uint queryCount);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetGeneratedCommandsMemoryRequirementsNV(IntPtr device, IntPtr pInfo, IntPtr pMemoryRequirements);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdPreprocessGeneratedCommandsNV(IntPtr commandBuffer, IntPtr pGeneratedCommandsInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdExecuteGeneratedCommandsNV(IntPtr commandBuffer, bool isPreprocessed, IntPtr pGeneratedCommandsInfo);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkCmdBindPipelineShaderGroupNV(IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, IntPtr pipeline, uint groupIndex);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreateIndirectCommandsLayoutNV(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pIndirectCommandsLayout);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyIndirectCommandsLayoutNV(IntPtr device, IntPtr indirectCommandsLayout, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkCreatePrivateDataSlotEXT(IntPtr device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr* pPrivateDataSlot);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkDestroyPrivateDataSlotEXT(IntPtr device, IntPtr privateDataSlot, IntPtr pAllocator);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate VkResult PFN_vkSetPrivateDataEXT(IntPtr device, VkObjectType objectType, ulong objectHandle, IntPtr privateDataSlot, ulong data);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void PFN_vkGetPrivateDataEXT(IntPtr device, VkObjectType objectType, ulong objectHandle, IntPtr privateDataSlot, ulong* pData);
	}
}
