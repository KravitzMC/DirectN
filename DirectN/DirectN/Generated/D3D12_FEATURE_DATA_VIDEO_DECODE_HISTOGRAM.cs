﻿// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM
    {
        public uint NodeIndex;
        public Guid DecodeProfile;
        public uint Width;
        public uint Height;
        public DXGI_FORMAT DecodeFormat;
        public D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS Components;
        public uint BinCount;
        public uint CounterBitDepth;
    }
}
