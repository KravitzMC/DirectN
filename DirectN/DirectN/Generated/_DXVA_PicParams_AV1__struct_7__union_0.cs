﻿// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_AV1__struct_7__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXVA_PicParams_AV1__struct_7__union_0__struct_0 __field_0 { get => InteropRuntime.Get<_DXVA_PicParams_AV1__struct_7__union_0__struct_0>(__bits, 0, 16); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.Set<_DXVA_PicParams_AV1__struct_7__union_0__struct_0>(value, __bits, 0, 16); } }
        public ushort ControlFlags { get => InteropRuntime.GetUInt16(__bits, 0, 16); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 0, 16); } }
    }
}
