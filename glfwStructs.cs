using System;
using System.Runtime.InteropServices;
namespace VulkanSharp.Raw {
	public unsafe static partial class Glfw {
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct GLFWvidmode {
			[FieldOffset(0)]public int width;
			[FieldOffset(4)]public int height;
			[FieldOffset(8)]public int redBits;
			[FieldOffset(12)]public int greenBits;
			[FieldOffset(16)]public int blueBits;
			[FieldOffset(20)]public int refreshRate;
		}
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct GLFWgammaramp {
			[FieldOffset(0)]public ushort* red;
			[FieldOffset(8)]public ushort* green;
			[FieldOffset(16)]public ushort* blue;
			[FieldOffset(24)]public uint size;
		}
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct GLFWimage {
			[FieldOffset(0)]public int width;
			[FieldOffset(4)]public int height;
			[FieldOffset(8)]public byte* pixels;
		}
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
		public unsafe struct GLFWgamepadstate {
			[FieldOffset(0)]public fixed byte buttons[15];
			[FieldOffset(16)][MarshalAs(UnmanagedType.ByValArray, SizeConst=6)] public float[] axes;
		}
	}
}
