﻿// generated from <Windows SDK Path>\shared\ks.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __struct_ks_371__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public __struct_ks_371__union_0__struct_0 __field_0 { get => InteropRuntime.Get<__struct_ks_371__union_0__struct_0>(__bits, 0, 16); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.Set<__struct_ks_371__union_0__struct_0>(value, __bits, 0, 16); } }
        public ushort SCRToken { get => InteropRuntime.GetUInt16(__bits, 0, 16); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 0, 16); } }
    }
}
