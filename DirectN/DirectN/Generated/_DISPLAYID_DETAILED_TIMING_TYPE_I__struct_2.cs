﻿// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DISPLAYID_DETAILED_TIMING_TYPE_I__struct_2
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ushort VerticalFrontPorch { get => InteropRuntime.GetUInt16(__bits, 0, 15); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 0, 15); } }
        public ushort VerticalSyncPolarity { get => InteropRuntime.GetUInt16(__bits, 15, 1); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 15, 1); } }
    }
}
