﻿// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETVIDEOPROTECTEDREGION
    {
        public uint PhysicalAdapterIndex;
        public uint SegmentIndex;
        public uint VprIndex;
        public IntPtr CurrentStartOffset;
        public IntPtr CurrentSize;
        public IntPtr NewStartOffset;
        public IntPtr NewSize;
    }
}
