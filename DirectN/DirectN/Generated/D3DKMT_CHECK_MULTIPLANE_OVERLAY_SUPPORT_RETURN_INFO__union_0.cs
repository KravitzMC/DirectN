﻿// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DKMT_CHECK_MULTIPLANE_OVERLAY_SUPPORT_RETURN_INFO__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3DKMT_CHECK_MULTIPLANE_OVERLAY_SUPPORT_RETURN_INFO__union_0__struct_0 __field_0 { get => InteropRuntime.Get<D3DKMT_CHECK_MULTIPLANE_OVERLAY_SUPPORT_RETURN_INFO__union_0__struct_0>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<D3DKMT_CHECK_MULTIPLANE_OVERLAY_SUPPORT_RETURN_INFO__union_0__struct_0>(value, __bits, 0, 32); } }
        public uint Value { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
    }
}
