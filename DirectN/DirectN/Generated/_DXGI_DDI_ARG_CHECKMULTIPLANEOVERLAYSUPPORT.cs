﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxgiddi.h(451,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGI_DDI_ARG_CHECKMULTIPLANEOVERLAYSUPPORT
    {
        public ulong hDevice;
        public int VidPnSourceId;
        public uint NumPlaneInfo;
        public IntPtr pPlaneInfo;
        public bool Supported;
    }
}
