﻿// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKVGPU_ESCAPE_READ_PCI_CONFIG
    {
        public _DXGKVGPU_ESCAPE_HEAD Header;
        public uint Offset;
        public uint Size;
    }
}
