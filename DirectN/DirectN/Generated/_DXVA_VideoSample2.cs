﻿// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_VideoSample2
    {
        public uint Size;
        public uint Reserved;
        public long rtStart;
        public long rtEnd;
        public uint SampleFormat;
        public uint SampleFlags;
        public IntPtr lpDDSSrcSurface;
        public tagRECT rcSrc;
        public tagRECT rcDst;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public _DXVA_AYUVsample2[] Palette;
    }
}
