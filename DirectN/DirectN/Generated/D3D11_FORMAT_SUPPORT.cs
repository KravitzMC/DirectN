﻿// generated from <Windows SDK Path>\um\d3d11.h
using System;

namespace DirectN
{
    [Flags]
    public enum D3D11_FORMAT_SUPPORT
    {
        D3D11_FORMAT_SUPPORT_BUFFER = 0x00000001,
        D3D11_FORMAT_SUPPORT_IA_VERTEX_BUFFER = 0x00000002,
        D3D11_FORMAT_SUPPORT_IA_INDEX_BUFFER = 0x00000004,
        D3D11_FORMAT_SUPPORT_SO_BUFFER = 0x00000008,
        D3D11_FORMAT_SUPPORT_TEXTURE1D = 0x00000010,
        D3D11_FORMAT_SUPPORT_TEXTURE2D = 0x00000020,
        D3D11_FORMAT_SUPPORT_TEXTURE3D = 0x00000040,
        D3D11_FORMAT_SUPPORT_TEXTURECUBE = 0x00000080,
        D3D11_FORMAT_SUPPORT_SHADER_LOAD = 0x00000100,
        D3D11_FORMAT_SUPPORT_SHADER_SAMPLE = 0x00000200,
        D3D11_FORMAT_SUPPORT_SHADER_SAMPLE_COMPARISON = 0x00000400,
        D3D11_FORMAT_SUPPORT_SHADER_SAMPLE_MONO_TEXT = 0x00000800,
        D3D11_FORMAT_SUPPORT_MIP = 0x00001000,
        D3D11_FORMAT_SUPPORT_MIP_AUTOGEN = 0x00002000,
        D3D11_FORMAT_SUPPORT_RENDER_TARGET = 0x00004000,
        D3D11_FORMAT_SUPPORT_BLENDABLE = 0x00008000,
        D3D11_FORMAT_SUPPORT_DEPTH_STENCIL = 0x00010000,
        D3D11_FORMAT_SUPPORT_CPU_LOCKABLE = 0x00020000,
        D3D11_FORMAT_SUPPORT_MULTISAMPLE_RESOLVE = 0x00040000,
        D3D11_FORMAT_SUPPORT_DISPLAY = 0x00080000,
        D3D11_FORMAT_SUPPORT_CAST_WITHIN_BIT_LAYOUT = 0x00100000,
        D3D11_FORMAT_SUPPORT_MULTISAMPLE_RENDERTARGET = 0x00200000,
        D3D11_FORMAT_SUPPORT_MULTISAMPLE_LOAD = 0x00400000,
        D3D11_FORMAT_SUPPORT_SHADER_GATHER = 0x00800000,
        D3D11_FORMAT_SUPPORT_BACK_BUFFER_CAST = 0x01000000,
        D3D11_FORMAT_SUPPORT_TYPED_UNORDERED_ACCESS_VIEW = 0x02000000,
        D3D11_FORMAT_SUPPORT_SHADER_GATHER_COMPARISON = 0x04000000,
        D3D11_FORMAT_SUPPORT_DECODER_OUTPUT = 0x08000000,
        D3D11_FORMAT_SUPPORT_VIDEO_PROCESSOR_OUTPUT = 0x10000000,
        D3D11_FORMAT_SUPPORT_VIDEO_PROCESSOR_INPUT = 0x20000000,
        D3D11_FORMAT_SUPPORT_VIDEO_ENCODER = 0x40000000,
    }
}
