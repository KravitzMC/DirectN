﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dhal.h(521,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_TEXTURECREATEDATA
    {
        public ulong dwhContext;
        public IntPtr lpDDS;
        public uint dwHandle;
        public HRESULT ddrval;
    }
}
