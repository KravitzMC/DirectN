﻿// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CLOSEALLOCATION
    {
        public uint NumAllocations;
        public IntPtr pOpenHandleList;
    }
}
