﻿// generated from <Windows SDK Path>\um\d3d11.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_RENDER_TARGET_VIEW_DESC
    {
        public DXGI_FORMAT Format;
        public D3D11_RTV_DIMENSION ViewDimension;
        public D3D11_RENDER_TARGET_VIEW_DESC__union_0 __union_2;
    }
}
