﻿// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_DEALLOCATE
    {
        public IntPtr hResource;
        public uint NumAllocations;
        public IntPtr HandleList;
    }
}
