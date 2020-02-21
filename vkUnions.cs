using System;
using System.Runtime.InteropServices;
namespace VulkanSharp.Raw {
	public unsafe static partial class VkFuncs {
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkClearColorValue {
			[FieldOffset(0)][MarshalAs(UnmanagedType.ByValArray, SizeConst=0)] public float[] float32;
			[FieldOffset(0)]public fixed int int32[4];
			[FieldOffset(0)][MarshalAs(UnmanagedType.ByValArray, SizeConst=0)] public uint[] uint32;
		}
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkClearValue {
			[FieldOffset(0)]public VkClearColorValue color;
			[FieldOffset(0)]public VkClearDepthStencilValue depthStencil;
		}
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPerformanceCounterResultKHR {
			[FieldOffset(0)]public int int32;
			[FieldOffset(0)]public long int64;
			[FieldOffset(0)]public uint uint32;
			[FieldOffset(0)]public ulong uint64;
			[FieldOffset(0)]public float float32;
			[FieldOffset(0)]public double float64;
		}
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPipelineExecutableStatisticValueKHR {
			[FieldOffset(0)]public uint b32;
			[FieldOffset(0)]public long i64;
			[FieldOffset(0)]public ulong u64;
			[FieldOffset(0)]public double f64;
		}
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct VkPerformanceValueDataINTEL {
			[FieldOffset(0)]public uint value32;
			[FieldOffset(0)]public ulong value64;
			[FieldOffset(0)]public float valueFloat;
			[FieldOffset(0)]public uint valueBool;
			[FieldOffset(0)]public string valueString;
		}
	}
}
