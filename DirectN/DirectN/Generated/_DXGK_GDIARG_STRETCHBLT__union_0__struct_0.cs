﻿// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_GDIARG_STRETCHBLT__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint Mode { get => InteropRuntime.GetUInt32(__bits, 0, 16); set { if (__bits == null) __bits = new byte[3]; InteropRuntime.SetUInt32(value, __bits, 0, 16); } }
        public uint MirrorX { get => InteropRuntime.GetUInt32(__bits, 16, 1); set { if (__bits == null) __bits = new byte[3]; InteropRuntime.SetUInt32(value, __bits, 16, 1); } }
        public uint MirrorY { get => InteropRuntime.GetUInt32(__bits, 17, 1); set { if (__bits == null) __bits = new byte[3]; InteropRuntime.SetUInt32(value, __bits, 17, 1); } }
    }
}
