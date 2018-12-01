﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11.h(14390,1)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D11_CREATE_DEVICE_FLAG
    {
        D3D11_CREATE_DEVICE_SINGLETHREADED = 0x00000001,
        D3D11_CREATE_DEVICE_DEBUG = 0x00000002,
        D3D11_CREATE_DEVICE_SWITCH_TO_REF = 0x00000004,
        D3D11_CREATE_DEVICE_PREVENT_INTERNAL_THREADING_OPTIMIZATIONS = 0x00000008,
        D3D11_CREATE_DEVICE_BGRA_SUPPORT = 0x00000020,
        D3D11_CREATE_DEVICE_DEBUGGABLE = 0x00000040,
        D3D11_CREATE_DEVICE_PREVENT_ALTERING_LAYER_SETTINGS_FROM_REGISTRY = 0x00000080,
        D3D11_CREATE_DEVICE_DISABLE_GPU_TIMEOUT = 0x00000100,
        D3D11_CREATE_DEVICE_VIDEO_SUPPORT = 0x00000800,
    }
}
