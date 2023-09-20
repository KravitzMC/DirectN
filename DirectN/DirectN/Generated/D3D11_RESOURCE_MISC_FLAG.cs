﻿// generated from <Windows SDK Path>\um\d3d11.h
using System;

namespace DirectN
{
    [Flags]
    public enum D3D11_RESOURCE_MISC_FLAG
    {
        D3D11_RESOURCE_MISC_GENERATE_MIPS = 0x00000001,
        D3D11_RESOURCE_MISC_SHARED = 0x00000002,
        D3D11_RESOURCE_MISC_TEXTURECUBE = 0x00000004,
        D3D11_RESOURCE_MISC_DRAWINDIRECT_ARGS = 0x00000010,
        D3D11_RESOURCE_MISC_BUFFER_ALLOW_RAW_VIEWS = 0x00000020,
        D3D11_RESOURCE_MISC_BUFFER_STRUCTURED = 0x00000040,
        D3D11_RESOURCE_MISC_RESOURCE_CLAMP = 0x00000080,
        D3D11_RESOURCE_MISC_SHARED_KEYEDMUTEX = 0x00000100,
        D3D11_RESOURCE_MISC_GDI_COMPATIBLE = 0x00000200,
        D3D11_RESOURCE_MISC_SHARED_NTHANDLE = 0x00000800,
        D3D11_RESOURCE_MISC_RESTRICTED_CONTENT = 0x00001000,
        D3D11_RESOURCE_MISC_RESTRICT_SHARED_RESOURCE = 0x00002000,
        D3D11_RESOURCE_MISC_RESTRICT_SHARED_RESOURCE_DRIVER = 0x00004000,
        D3D11_RESOURCE_MISC_GUARDED = 0x00008000,
        D3D11_RESOURCE_MISC_TILE_POOL = 0x00020000,
        D3D11_RESOURCE_MISC_TILED = 0x00040000,
        D3D11_RESOURCE_MISC_HW_PROTECTED = 0x00080000,
        D3D11_RESOURCE_MISC_SHARED_DISPLAYABLE = 0x00100000,
        D3D11_RESOURCE_MISC_SHARED_EXCLUSIVE_WRITER = 0x00200000,
    }
}
