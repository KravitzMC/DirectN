﻿// generated from <Windows SDK Path>\shared\dxgi1_6.h
using System;

namespace DirectN
{
    [Flags]
    public enum DXGI_ADAPTER_FLAG3
    {
        DXGI_ADAPTER_FLAG3_NONE = 0x00000000,
        DXGI_ADAPTER_FLAG3_REMOTE = 0x00000001,
        DXGI_ADAPTER_FLAG3_SOFTWARE = 0x00000002,
        DXGI_ADAPTER_FLAG3_ACG_COMPATIBLE = 0x00000004,
        DXGI_ADAPTER_FLAG3_SUPPORT_MONITORED_FENCES = 0x00000008,
        DXGI_ADAPTER_FLAG3_SUPPORT_NON_MONITORED_FENCES = 0x00000010,
        DXGI_ADAPTER_FLAG3_KEYED_MUTEX_CONFORMANCE = 0x00000020,
        DXGI_ADAPTER_FLAG3_FORCE_DWORD = unchecked((int)0xFFFFFFFF),
    }
}
