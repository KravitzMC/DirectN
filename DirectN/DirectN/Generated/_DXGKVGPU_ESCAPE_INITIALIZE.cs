﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(179,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKVGPU_ESCAPE_INITIALIZE
    {
        public _DXGKVGPU_ESCAPE_HEAD Header;
        public Guid VmGuid;
    }
}
