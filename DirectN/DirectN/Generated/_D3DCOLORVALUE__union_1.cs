﻿// generated from <Windows SDK Path>\um\d3dtypes.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DCOLORVALUE__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public float g { get => InteropRuntime.GetSingle(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetSingle(value, __bits, 0, 32); } }
        public float dvG { get => InteropRuntime.GetSingle(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetSingle(value, __bits, 0, 32); } }
    }
}
