using System;
using System.Runtime.InteropServices;
namespace RadeonRaysSharp.Raw {
	public unsafe static partial class RadeonRays {
		public static RRError rrCreateContext(uint api_version, RRApi api, IntPtr* context) { throw new NotImplementedException(); }
		public static RRError rrDestroyContext(IntPtr context) { throw new NotImplementedException(); }
		public static RRError rrCmdBuildGeometry(IntPtr context, RRBuildOperation build_operation, ManagedPtrArray<RRGeometryBuildInput> build_input, ManagedPtrArray<RRBuildOptions> build_options, IntPtr temporary_buffer, IntPtr geometry_buffer, IntPtr command_stream) { throw new NotImplementedException(); }
		public static RRError rrCmdBuildGeometry(IntPtr context, RRBuildOperation build_operation, IntPtr build_input, IntPtr build_options, IntPtr temporary_buffer, IntPtr geometry_buffer, IntPtr command_stream) { throw new NotImplementedException(); }
		public static RRError rrGetGeometryBuildMemoryRequirements(IntPtr context, ManagedPtrArray<RRGeometryBuildInput> build_input, ManagedPtrArray<RRBuildOptions> build_options, ManagedPtrArray<RRMemoryRequirements> memory_requirements) { throw new NotImplementedException(); }
		public static RRError rrGetGeometryBuildMemoryRequirements(IntPtr context, IntPtr build_input, IntPtr build_options, IntPtr memory_requirements) { throw new NotImplementedException(); }
		public static RRError rrCmdBuildScene(IntPtr context, ManagedPtrArray<RRSceneBuildInput> build_input, ManagedPtrArray<RRBuildOptions> build_options, IntPtr temporary_buffer, IntPtr scene_buffer, IntPtr command_stream) { throw new NotImplementedException(); }
		public static RRError rrCmdBuildScene(IntPtr context, IntPtr build_input, IntPtr build_options, IntPtr temporary_buffer, IntPtr scene_buffer, IntPtr command_stream) { throw new NotImplementedException(); }
		public static RRError rrGetSceneBuildMemoryRequirements(IntPtr context, ManagedPtrArray<RRSceneBuildInput> build_input, ManagedPtrArray<RRBuildOptions> build_options, ManagedPtrArray<RRMemoryRequirements> memory_requirements) { throw new NotImplementedException(); }
		public static RRError rrGetSceneBuildMemoryRequirements(IntPtr context, IntPtr build_input, IntPtr build_options, IntPtr memory_requirements) { throw new NotImplementedException(); }
		public static RRError rrCmdIntersect(IntPtr context, IntPtr scene_buffer, RRIntersectQuery query, IntPtr rays, uint ray_count, IntPtr indirect_ray_count, RRIntersectQueryOutput query_output, IntPtr hits, IntPtr scratch, IntPtr command_stream) { throw new NotImplementedException(); }
		public static RRError rrGetTraceMemoryRequirements(IntPtr context, uint ray_count, ulong* scratch_size) { throw new NotImplementedException(); }
		public static RRError rrAllocateCommandStream(IntPtr context, IntPtr* command_stream) { throw new NotImplementedException(); }
		public static RRError rrReleaseCommandStream(IntPtr context, IntPtr command_stream) { throw new NotImplementedException(); }
		public static RRError rrSumbitCommandStream(IntPtr context, IntPtr command_stream, IntPtr wait_event, IntPtr* out_event) { throw new NotImplementedException(); }
		public static RRError rrReleaseEvent(IntPtr context, IntPtr @event) { throw new NotImplementedException(); }
		public static RRError rrWaitEvent(IntPtr context, IntPtr @event) { throw new NotImplementedException(); }
		public static RRError rrReleaseDevicePtr(IntPtr context, IntPtr ptr) { throw new NotImplementedException(); }
		public static RRError rrGetDevicePtrFromVkBuffer(IntPtr context, IntPtr resource, ulong offset, IntPtr* device_ptr) { throw new NotImplementedException(); }
		public static RRError rrCreateContextVk(uint api_version, IntPtr device, IntPtr physical_device, IntPtr command_queue, uint queue_family_index, IntPtr* context) { throw new NotImplementedException(); }
		public static RRError rrGetCommandStreamFromVkCommandBuffer(IntPtr context, IntPtr command_buffer, IntPtr* command_stream) { throw new NotImplementedException(); }
		public static RRError rrReleaseExternalCommandStream(IntPtr context, IntPtr command_stream) { throw new NotImplementedException(); }
		public static RRError rrAllocateDeviceBuffer(IntPtr context, ulong size, IntPtr* device_ptr) { throw new NotImplementedException(); }
		public static RRError rrMapDevicePtr(IntPtr context, IntPtr device_ptr, void** mapping_ptr) { throw new NotImplementedException(); }
		public static RRError rrUnmapDevicePtr(IntPtr context, IntPtr device_ptr, void** mapping_ptr) { throw new NotImplementedException(); }
		internal static IntPtr rrCreateContext_hndl;
		internal static IntPtr rrDestroyContext_hndl;
		internal static IntPtr rrCmdBuildGeometry_hndl;
		internal static IntPtr rrGetGeometryBuildMemoryRequirements_hndl;
		internal static IntPtr rrCmdBuildScene_hndl;
		internal static IntPtr rrGetSceneBuildMemoryRequirements_hndl;
		internal static IntPtr rrCmdIntersect_hndl;
		internal static IntPtr rrGetTraceMemoryRequirements_hndl;
		internal static IntPtr rrAllocateCommandStream_hndl;
		internal static IntPtr rrReleaseCommandStream_hndl;
		internal static IntPtr rrSumbitCommandStream_hndl;
		internal static IntPtr rrReleaseEvent_hndl;
		internal static IntPtr rrWaitEvent_hndl;
		internal static IntPtr rrReleaseDevicePtr_hndl;
		internal static IntPtr rrGetDevicePtrFromVkBuffer_hndl;
		internal static IntPtr rrCreateContextVk_hndl;
		internal static IntPtr rrGetCommandStreamFromVkCommandBuffer_hndl;
		internal static IntPtr rrReleaseExternalCommandStream_hndl;
		internal static IntPtr rrAllocateDeviceBuffer_hndl;
		internal static IntPtr rrMapDevicePtr_hndl;
		internal static IntPtr rrUnmapDevicePtr_hndl;
		private static void InitPtrs() {
			NativeLibrary.TryGetExport(libHndl, "rrCreateContext", out rrCreateContext_hndl);
			NativeLibrary.TryGetExport(libHndl, "rrDestroyContext", out rrDestroyContext_hndl);
			NativeLibrary.TryGetExport(libHndl, "rrCmdBuildGeometry", out rrCmdBuildGeometry_hndl);
			NativeLibrary.TryGetExport(libHndl, "rrGetGeometryBuildMemoryRequirements", out rrGetGeometryBuildMemoryRequirements_hndl);
			NativeLibrary.TryGetExport(libHndl, "rrCmdBuildScene", out rrCmdBuildScene_hndl);
			NativeLibrary.TryGetExport(libHndl, "rrGetSceneBuildMemoryRequirements", out rrGetSceneBuildMemoryRequirements_hndl);
			NativeLibrary.TryGetExport(libHndl, "rrCmdIntersect", out rrCmdIntersect_hndl);
			NativeLibrary.TryGetExport(libHndl, "rrGetTraceMemoryRequirements", out rrGetTraceMemoryRequirements_hndl);
			NativeLibrary.TryGetExport(libHndl, "rrAllocateCommandStream", out rrAllocateCommandStream_hndl);
			NativeLibrary.TryGetExport(libHndl, "rrReleaseCommandStream", out rrReleaseCommandStream_hndl);
			NativeLibrary.TryGetExport(libHndl, "rrSumbitCommandStream", out rrSumbitCommandStream_hndl);
			NativeLibrary.TryGetExport(libHndl, "rrReleaseEvent", out rrReleaseEvent_hndl);
			NativeLibrary.TryGetExport(libHndl, "rrWaitEvent", out rrWaitEvent_hndl);
			NativeLibrary.TryGetExport(libHndl, "rrReleaseDevicePtr", out rrReleaseDevicePtr_hndl);
			NativeLibrary.TryGetExport(libHndl, "rrGetDevicePtrFromVkBuffer", out rrGetDevicePtrFromVkBuffer_hndl);
			NativeLibrary.TryGetExport(libHndl, "rrCreateContextVk", out rrCreateContextVk_hndl);
			NativeLibrary.TryGetExport(libHndl, "rrGetCommandStreamFromVkCommandBuffer", out rrGetCommandStreamFromVkCommandBuffer_hndl);
			NativeLibrary.TryGetExport(libHndl, "rrReleaseExternalCommandStream", out rrReleaseExternalCommandStream_hndl);
			NativeLibrary.TryGetExport(libHndl, "rrAllocateDeviceBuffer", out rrAllocateDeviceBuffer_hndl);
			NativeLibrary.TryGetExport(libHndl, "rrMapDevicePtr", out rrMapDevicePtr_hndl);
			NativeLibrary.TryGetExport(libHndl, "rrUnmapDevicePtr", out rrUnmapDevicePtr_hndl);
		}
	}
}
