﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dnthal.h(763,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_DP2UPDATEPALETTE
    {
        public uint dwPaletteHandle;
        public ushort wStartIndex;
        public ushort wNumEntries;
    }
}
