﻿// generated from <Windows SDK Path>\um\d3d11.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_TEXCUBE_ARRAY_SRV
    {
        public uint MostDetailedMip;
        public uint MipLevels;
        public uint First2DArrayFace;
        public uint NumCubes;
    }
}
