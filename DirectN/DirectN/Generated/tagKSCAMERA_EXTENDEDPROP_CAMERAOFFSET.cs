﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ksmedia.h(6142,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKSCAMERA_EXTENDEDPROP_CAMERAOFFSET
    {
        public int PitchAngle;
        public int YawAngle;
        public uint Flag;
        public uint Reserved;
    }
}
