﻿// generated from <Windows SDK Path>\um\d3dtypes.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DTRANSFORMDATA
    {
        public uint dwSize;
        public IntPtr lpIn;
        public uint dwInSize;
        public IntPtr lpOut;
        public uint dwOutSize;
        public IntPtr lpHOut;
        public uint dwClip;
        public uint dwClipIntersection;
        public uint dwClipUnion;
        public _D3DRECT drExtent;
    }
}
