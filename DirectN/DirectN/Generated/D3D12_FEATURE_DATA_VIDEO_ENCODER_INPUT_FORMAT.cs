﻿// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_INPUT_FORMAT
    {
        public uint NodeIndex;
        public D3D12_VIDEO_ENCODER_CODEC Codec;
        public D3D12_VIDEO_ENCODER_PROFILE_DESC Profile;
        public DXGI_FORMAT Format;
        public bool IsSupported;
    }
}
