﻿// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_EVICT
    {
        public uint hDevice;
        public uint NumAllocations;
        public IntPtr AllocationList;
        public D3DDDI_EVICT_FLAGS Flags;
        public ulong NumBytesToTrim;
    }
}
