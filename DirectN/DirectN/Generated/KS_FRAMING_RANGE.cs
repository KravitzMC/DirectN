﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ks.h(1720,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KS_FRAMING_RANGE
    {
        public uint MinFrameSize;
        public uint MaxFrameSize;
        public uint Stepping;
    }
}
