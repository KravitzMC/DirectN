﻿// generated from <Windows SDK Path>\um\d3dhal.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_TEXTUREGETSURFDATA
    {
        public IntPtr dwhContext;
        public IntPtr lpDDS;
        public uint dwHandle;
        public HRESULT ddrval;
    }
}
