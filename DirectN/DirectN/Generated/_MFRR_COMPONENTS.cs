﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(7429,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFRR_COMPONENTS
    {
        public uint dwRRInfoVersion;
        public uint dwRRComponents;
        public IntPtr pRRComponents;
    }
}