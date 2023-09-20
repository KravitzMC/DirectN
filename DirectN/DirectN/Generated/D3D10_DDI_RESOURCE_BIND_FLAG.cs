﻿// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;

namespace DirectN
{
    [Flags]
    public enum D3D10_DDI_RESOURCE_BIND_FLAG
    {
        D3D10_DDI_BIND_VERTEX_BUFFER = 0x00000001,
        D3D10_DDI_BIND_INDEX_BUFFER = 0x00000002,
        D3D10_DDI_BIND_CONSTANT_BUFFER = 0x00000004,
        D3D10_DDI_BIND_SHADER_RESOURCE = 0x00000008,
        D3D10_DDI_BIND_STREAM_OUTPUT = 0x00000010,
        D3D10_DDI_BIND_RENDER_TARGET = 0x00000020,
        D3D10_DDI_BIND_DEPTH_STENCIL = 0x00000040,
        D3D10_DDI_BIND_PIPELINE_MASK = 0x0000007F,
        D3D10_DDI_BIND_PRESENT = 0x00000080,
        D3D10_DDI_BIND_MASK = 0x000000FF,
        D3D11_DDI_BIND_UNORDERED_ACCESS = 0x00000100,
        D3D11_DDI_BIND_DECODER = 0x00000200,
        D3D11_DDI_BIND_VIDEO_ENCODER = 0x00000400,
        D3D11_DDI_BIND_CAPTURE = 0x00000800,
        D3D11_DDI_BIND_PIPELINE_MASK = 0x00000F7F,
        D3D11_DDI_BIND_MASK = 0x00000FFF,
    }
}
