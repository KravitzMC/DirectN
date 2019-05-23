﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dwrite_1.h(752,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_PANOSE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public byte[] values { get => InteropRuntime.GetArray<byte>(__bits, 0, 80); set => InteropRuntime.SetArray<byte>(value, __bits, 0, 80); }
        public byte familyKind { get => InteropRuntime.GetByte(__bits, 0, 8); set => InteropRuntime.SetByte(value, __bits, 0, 8); }
        public DWRITE_PANOSE__struct_0 text { get => InteropRuntime.Get<DWRITE_PANOSE__struct_0>(__bits, 0, 80); set => InteropRuntime.Set<DWRITE_PANOSE__struct_0>(value, __bits, 0, 80); }
        public DWRITE_PANOSE__struct_1 script { get => InteropRuntime.Get<DWRITE_PANOSE__struct_1>(__bits, 0, 80); set => InteropRuntime.Set<DWRITE_PANOSE__struct_1>(value, __bits, 0, 80); }
        public DWRITE_PANOSE__struct_2 decorative { get => InteropRuntime.Get<DWRITE_PANOSE__struct_2>(__bits, 0, 80); set => InteropRuntime.Set<DWRITE_PANOSE__struct_2>(value, __bits, 0, 80); }
        public DWRITE_PANOSE__struct_3 symbol { get => InteropRuntime.Get<DWRITE_PANOSE__struct_3>(__bits, 0, 80); set => InteropRuntime.Set<DWRITE_PANOSE__struct_3>(value, __bits, 0, 80); }
    }
}