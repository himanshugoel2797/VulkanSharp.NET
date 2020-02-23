using System;
using System.Runtime.InteropServices;

namespace VulkanSharp.Raw
{
    public sealed class ManagedPtr<T> : IDisposable
    {
        public IntPtr Pointer { get; }
        public T Value { get => Marshal.PtrToStructure<T>(Pointer); }

        public ManagedPtr(T val)
        {
            Pointer = Marshal.AllocHGlobal(Marshal.SizeOf(val));
            Marshal.StructureToPtr(val, Pointer, false);
        }

        public ManagedPtr()
        {
            Pointer = Marshal.AllocHGlobal(Marshal.SizeOf<T>());
        }

        public static implicit operator IntPtr(ManagedPtr<T> p) => p.Pointer;
        public static implicit operator ManagedPtrArray<T>(ManagedPtr<T> p) => new ManagedPtrArray<T>(p);

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.
                Marshal.DestroyStructure<T>(Pointer);
                Marshal.FreeHGlobal(Pointer);

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~ManagedPtr()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
        #endregion
    }

    public sealed class ManagedPtrArray<T> : IDisposable
    {
        public IntPtr Pointer { get; }
        public uint Length { get; }

        public T[] Value
        {
            get
            {
                var tmp = new T[Length];
                for (int i = 0; i < Length; i++)
                    tmp[i] = this[i];
                return tmp;
            }
        }

        public ManagedPtrArray(T[] val)
        {
            Length = (uint)val.Length;
            var unitSz = Marshal.SizeOf<T>();
            Pointer = Marshal.AllocHGlobal(unitSz * val.Length);
            for (int i = 0; i < val.Length; i++)
                Marshal.StructureToPtr(val[i], Pointer + i * unitSz, false);
        }

        public ManagedPtrArray(int cnt)
        {
            if (cnt != 0)
            {
                this.Length = (uint)cnt;
                Pointer = Marshal.AllocHGlobal(Marshal.SizeOf<T>() * cnt);
            }
            else
                throw new ArgumentException("cnt must be greater than 0");
        }

        public ManagedPtrArray(uint cnt)
        {
            if (cnt != 0)
            {
                this.Length = (uint)cnt;
                Pointer = Marshal.AllocHGlobal(Marshal.SizeOf<T>() * (int)cnt);
            }
            else
                throw new ArgumentException("cnt must be greater than 0");
        }

        public ManagedPtrArray(ManagedPtr<T> o)
        {
            this.Length = 1;
            disposedValue = true;   //only free in the parent object
            Pointer = o.Pointer;
        }

        private ManagedPtrArray(IntPtr p)
        {
            disposedValue = true;   //Don't autofree a custom pointer
            Pointer = p;
        }

        public T this[int i]
        {
            get
            {
                if (i >= Length) throw new IndexOutOfRangeException();
                return Marshal.PtrToStructure<T>(Pointer + i * Marshal.SizeOf<T>());
            }
        }

        public static implicit operator IntPtr(ManagedPtrArray<T> p) => p == null ? IntPtr.Zero : p.Pointer;

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.
                Marshal.DestroyStructure<T>(Pointer);
                Marshal.FreeHGlobal(Pointer);

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~ManagedPtrArray()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
        #endregion
    }

    public unsafe static partial class Vk
    {
        static IntPtr libHndl;
        static Vk()
        {
            //Load assembly based on platform
            bool isLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);

            string libname = "vulkan-1.dll";
            if (isLinux) libname = "libvulkan.so.1";

            libHndl = NativeLibrary.Load(libname);
            InitPtrs();
        }
    }
}
