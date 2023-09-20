﻿// generated from <Windows SDK Path>\um\d3d11.h
using System;

namespace DirectN
{
    [Flags]
    public enum D3D11_FORMAT_SUPPORT2
    {
        D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_ADD = 0x00000001,
        D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_BITWISE_OPS = 0x00000002,
        D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_COMPARE_STORE_OR_COMPARE_EXCHANGE = 0x00000004,
        D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_EXCHANGE = 0x00000008,
        D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_SIGNED_MIN_OR_MAX = 0x00000010,
        D3D11_FORMAT_SUPPORT2_UAV_ATOMIC_UNSIGNED_MIN_OR_MAX = 0x00000020,
        D3D11_FORMAT_SUPPORT2_UAV_TYPED_LOAD = 0x00000040,
        D3D11_FORMAT_SUPPORT2_UAV_TYPED_STORE = 0x00000080,
        D3D11_FORMAT_SUPPORT2_OUTPUT_MERGER_LOGIC_OP = 0x00000100,
        D3D11_FORMAT_SUPPORT2_TILED = 0x00000200,
        D3D11_FORMAT_SUPPORT2_SHAREABLE = 0x00000400,
        D3D11_FORMAT_SUPPORT2_MULTIPLANE_OVERLAY = 0x00004000,
    }
}
