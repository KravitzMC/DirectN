﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dcommon.h(737,1)
using System;

namespace DirectN
{
    [Flags]
    public enum _D3D_SHADER_INPUT_FLAGS
    {
        D3D_SIF_USERPACKED = 0x00000001,
        D3D_SIF_COMPARISON_SAMPLER = 0x00000002,
        D3D_SIF_TEXTURE_COMPONENT_0 = 0x00000004,
        D3D_SIF_TEXTURE_COMPONENT_1 = 0x00000008,
        D3D_SIF_TEXTURE_COMPONENTS = 0x0000000C,
        D3D_SIF_UNUSED = 0x00000010,
        D3D10_SIF_USERPACKED = 0x00000001,
        D3D10_SIF_COMPARISON_SAMPLER = 0x00000002,
        D3D10_SIF_TEXTURE_COMPONENT_0 = 0x00000004,
        D3D10_SIF_TEXTURE_COMPONENT_1 = 0x00000008,
        D3D10_SIF_TEXTURE_COMPONENTS = 0x0000000C,
        D3D_SIF_FORCE_DWORD = 0x7FFFFFFF,
    }
}
