﻿// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_RELEASESWIZZLINGRANGE
    {
        public IntPtr hAllocation;
        public uint PrivateDriverData;
        public uint RangeId;
    }
}
