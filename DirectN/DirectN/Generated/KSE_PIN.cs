﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ks.h(1050,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSE_PIN
    {
        public KSIDENTIFIER Event;
        public uint PinId;
        public uint Reserved;
    }
}
