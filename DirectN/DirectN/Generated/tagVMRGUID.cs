﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(19400,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagVMRGUID
    {
        public IntPtr pGUID;
        public Guid GUID;
    }
}
