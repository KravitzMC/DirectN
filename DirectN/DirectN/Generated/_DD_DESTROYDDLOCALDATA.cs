﻿// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_DESTROYDDLOCALDATA
    {
        public uint dwFlags;
        public IntPtr pDDLcl;
        public HRESULT ddRVal;
    }
}
