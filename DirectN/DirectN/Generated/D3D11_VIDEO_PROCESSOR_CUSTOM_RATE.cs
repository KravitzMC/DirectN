﻿// generated from <Windows SDK Path>\um\d3d11.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_VIDEO_PROCESSOR_CUSTOM_RATE
    {
        public DXGI_RATIONAL CustomRate;
        public uint OutputFrames;
        public bool InputInterlaced;
        public uint InputFramesOrFields;
    }
}
