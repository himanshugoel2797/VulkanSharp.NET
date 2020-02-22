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
        private uint cnt;

        public T[] Value
        {
            get
            {
                var tmp = new T[cnt];
                for (int i = 0; i < cnt; i++)
                    tmp[i] = this[i];
                return tmp;
            }
        }

        public ManagedPtrArray(T[] val)
        {
            cnt = (uint)val.Length;
            var unitSz = Marshal.SizeOf<T>();
            Pointer = Marshal.AllocHGlobal(unitSz * val.Length);
            for (int i = 0; i < val.Length; i++)
                Marshal.StructureToPtr(val[i], Pointer + i * unitSz, false);
        }

        public ManagedPtrArray(int cnt)
        {
            this.cnt = (uint)cnt;
            Pointer = Marshal.AllocHGlobal(Marshal.SizeOf<T>() * cnt);
        }

        public ManagedPtrArray(uint cnt)
        {
            this.cnt = cnt;
            Pointer = Marshal.AllocHGlobal(Marshal.SizeOf<T>() * (int)cnt);
        }

        public T this[int i]
        {
            get
            {
                if (i >= cnt) throw new IndexOutOfRangeException();
                return Marshal.PtrToStructure<T>(Pointer + i * Marshal.SizeOf<T>());
            }
        }

        public static implicit operator IntPtr(ManagedPtrArray<T> p) => p.Pointer;

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
