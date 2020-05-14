using System;
using System.Runtime.InteropServices;
namespace VulkanSharp.Raw {
	public unsafe static partial class Vk {
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkClearColorValue {
			[FieldOffset(0)]public fixed float float32[4];
			[FieldOffset(0)]public fixed int int32[4];
			[FieldOffset(0)]public fixed uint uint32[4];
		}

        public static ManagedPtr<VkClearColorValue> Pointer(this VkClearColorValue i) => new ManagedPtr<VkClearColorValue>(i);
        public static ManagedPtrArray<VkClearColorValue> Pointer(this VkClearColorValue[] i) => new ManagedPtrArray<VkClearColorValue>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkClearValue {
			[FieldOffset(0)]public VkClearColorValue color;
			[FieldOffset(0)]public VkClearDepthStencilValue depthStencil;
		}

        public static ManagedPtr<VkClearValue> Pointer(this VkClearValue i) => new ManagedPtr<VkClearValue>(i);
        public static ManagedPtrArray<VkClearValue> Pointer(this VkClearValue[] i) => new ManagedPtrArray<VkClearValue>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPerformanceCounterResultKHR {
			[FieldOffset(0)]public int int32;
			[FieldOffset(0)]public long int64;
			[FieldOffset(0)]public uint uint32;
			[FieldOffset(0)]public ulong uint64;
			[FieldOffset(0)]public float float32;
			[FieldOffset(0)]public double float64;
		}

        public static ManagedPtr<VkPerformanceCounterResultKHR> Pointer(this VkPerformanceCounterResultKHR i) => new ManagedPtr<VkPerformanceCounterResultKHR>(i);
        public static ManagedPtrArray<VkPerformanceCounterResultKHR> Pointer(this VkPerformanceCounterResultKHR[] i) => new ManagedPtrArray<VkPerformanceCounterResultKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineExecutableStatisticValueKHR {
			[FieldOffset(0)]public bool b32;
			[FieldOffset(0)]public long i64;
			[FieldOffset(0)]public ulong u64;
			[FieldOffset(0)]public double f64;
		}

        public static ManagedPtr<VkPipelineExecutableStatisticValueKHR> Pointer(this VkPipelineExecutableStatisticValueKHR i) => new ManagedPtr<VkPipelineExecutableStatisticValueKHR>(i);
        public static ManagedPtrArray<VkPipelineExecutableStatisticValueKHR> Pointer(this VkPipelineExecutableStatisticValueKHR[] i) => new ManagedPtrArray<VkPipelineExecutableStatisticValueKHR>(i);
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPerformanceValueDataINTEL {
			[FieldOffset(0)]public uint value32;
			[FieldOffset(0)]public ulong value64;
			[FieldOffset(0)]public float valueFloat;
			[FieldOffset(0)]public bool valueBool;
			[FieldOffset(0)]public string valueString;
		}

        public static ManagedPtr<VkPerformanceValueDataINTEL> Pointer(this VkPerformanceValueDataINTEL i) => new ManagedPtr<VkPerformanceValueDataINTEL>(i);
        public static ManagedPtrArray<VkPerformanceValueDataINTEL> Pointer(this VkPerformanceValueDataINTEL[] i) => new ManagedPtrArray<VkPerformanceValueDataINTEL>(i);
	}
}
