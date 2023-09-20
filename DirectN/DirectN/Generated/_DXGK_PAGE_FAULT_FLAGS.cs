﻿// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;

namespace DirectN
{
    [Flags]
    public enum _DXGK_PAGE_FAULT_FLAGS
    {
        DXGK_PAGE_FAULT_WRITE = 0x00000001,
        DXGK_PAGE_FAULT_FENCE_INVALID = 0x00000002,
        DXGK_PAGE_FAULT_ADAPTER_RESET_REQUIRED = 0x00000004,
        DXGK_PAGE_FAULT_ENGINE_RESET_REQUIRED = 0x00000008,
        DXGK_PAGE_FAULT_FATAL_HARDWARE_ERROR = 0x00000010,
        DXGK_PAGE_FAULT_IOMMU = 0x00000020,
        DXGK_PAGE_FAULT_HW_CONTEXT_VALID = 0x00000040,
        DXGK_PAGE_FAULT_PROCESS_HANDLE_VALID = 0x00000080,
    }
}
