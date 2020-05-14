using System;
using System.Runtime.InteropServices;
namespace RadeonRaysSharp.Raw {
	public unsafe static partial class RadeonRays {
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct RRRay {
			[FieldOffset(0)]public fixed float origin[3];
			public const int origin_len = 3;
			[FieldOffset(12)]public float min_t;
			[FieldOffset(16)]public fixed float direction[3];
			public const int direction_len = 3;
			[FieldOffset(28)]public float max_t;
		}

        public static ManagedPtr<RRRay> Pointer(this RRRay i) => new ManagedPtr<RRRay>(i);
        public static ManagedPtrArray<RRRay> Pointer(this RRRay[] i) => new ManagedPtrArray<RRRay>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct RRHit {
			[FieldOffset(0)]public fixed float uv[2];
			public const int uv_len = 2;
			[FieldOffset(8)]public uint inst_id;
			[FieldOffset(12)]public uint prim_id;
		}

        public static ManagedPtr<RRHit> Pointer(this RRHit i) => new ManagedPtr<RRHit>(i);
        public static ManagedPtrArray<RRHit> Pointer(this RRHit[] i) => new ManagedPtrArray<RRHit>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct RRBuildOptions {
			[FieldOffset(0)]public uint build_flags;
			[FieldOffset(8)]public IntPtr backend_specific_info;
		}

        public static ManagedPtr<RRBuildOptions> Pointer(this RRBuildOptions i) => new ManagedPtr<RRBuildOptions>(i);
        public static ManagedPtrArray<RRBuildOptions> Pointer(this RRBuildOptions[] i) => new ManagedPtrArray<RRBuildOptions>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct RRTriangleMeshPrimitive {
			[FieldOffset(0)]public IntPtr vertices;
			[FieldOffset(8)]public uint vertex_count;
			[FieldOffset(12)]public uint vertex_stride;
			[FieldOffset(16)]public IntPtr triangle_indices;
			[FieldOffset(24)]public uint triangle_count;
			[FieldOffset(28)]public RRIndexType index_type;
		}

        public static ManagedPtr<RRTriangleMeshPrimitive> Pointer(this RRTriangleMeshPrimitive i) => new ManagedPtr<RRTriangleMeshPrimitive>(i);
        public static ManagedPtrArray<RRTriangleMeshPrimitive> Pointer(this RRTriangleMeshPrimitive[] i) => new ManagedPtrArray<RRTriangleMeshPrimitive>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct RRAABBListPrimitive {
			[FieldOffset(0)]public IntPtr aabbs;
			[FieldOffset(8)]public uint aabb_count;
			[FieldOffset(12)]public uint aabb_stride;
		}

        public static ManagedPtr<RRAABBListPrimitive> Pointer(this RRAABBListPrimitive i) => new ManagedPtr<RRAABBListPrimitive>(i);
        public static ManagedPtrArray<RRAABBListPrimitive> Pointer(this RRAABBListPrimitive[] i) => new ManagedPtrArray<RRAABBListPrimitive>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct RRGeometryBuildInput {
			[FieldOffset(0)]public RRPrimitiveType primitive_type;
			[FieldOffset(4)]public uint primitive_count;
			[FieldOffset(8)]public IntPtr primitives;
		}

        public static ManagedPtr<RRGeometryBuildInput> Pointer(this RRGeometryBuildInput i) => new ManagedPtr<RRGeometryBuildInput>(i);
        public static ManagedPtrArray<RRGeometryBuildInput> Pointer(this RRGeometryBuildInput[] i) => new ManagedPtrArray<RRGeometryBuildInput>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct RRInstance {
			[FieldOffset(0)]public IntPtr geometry;
			[FieldOffset(8)]public fixed float transform[3];
			public const int transform_len = 3;
		}

        public static ManagedPtr<RRInstance> Pointer(this RRInstance i) => new ManagedPtr<RRInstance>(i);
        public static ManagedPtrArray<RRInstance> Pointer(this RRInstance[] i) => new ManagedPtrArray<RRInstance>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct RRSceneBuildInput {
			[FieldOffset(0)]public IntPtr instances;
			[FieldOffset(8)]public uint instance_count;
		}

        public static ManagedPtr<RRSceneBuildInput> Pointer(this RRSceneBuildInput i) => new ManagedPtr<RRSceneBuildInput>(i);
        public static ManagedPtrArray<RRSceneBuildInput> Pointer(this RRSceneBuildInput[] i) => new ManagedPtrArray<RRSceneBuildInput>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct RRMemoryRequirements {
			[FieldOffset(0)]public ulong temporary_build_buffer_size;
			[FieldOffset(8)]public ulong temporary_update_buffer_size;
			[FieldOffset(16)]public ulong result_buffer_size;
		}

        public static ManagedPtr<RRMemoryRequirements> Pointer(this RRMemoryRequirements i) => new ManagedPtr<RRMemoryRequirements>(i);
        public static ManagedPtrArray<RRMemoryRequirements> Pointer(this RRMemoryRequirements[] i) => new ManagedPtrArray<RRMemoryRequirements>(i);
	}
}
