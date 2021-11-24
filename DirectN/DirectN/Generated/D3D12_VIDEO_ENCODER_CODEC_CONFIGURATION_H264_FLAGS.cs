﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(6027,1)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS
    {
        D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_NONE = 0x00000000,
        D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_USE_CONSTRAINED_INTRAPREDICTION = 0x00000001,
        D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_USE_ADAPTIVE_8x8_TRANSFORM = 0x00000002,
        D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_ENABLE_CABAC_ENCODING = 0x00000004,
        D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_ALLOW_REQUEST_INTRA_CONSTRAINED_SLICES = 0x00000008,
    }
}