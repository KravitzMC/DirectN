﻿// generated from <Windows SDK Path>\um\d3d11_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_TEXTURE3D_DESC1
    {
        public uint Width;
        public uint Height;
        public uint Depth;
        public uint MipLevels;
        public DXGI_FORMAT Format;
        public D3D11_USAGE Usage;
        public uint BindFlags;
        public uint CPUAccessFlags;
        public uint MiscFlags;
        public D3D11_TEXTURE_LAYOUT TextureLayout;
    }
}
