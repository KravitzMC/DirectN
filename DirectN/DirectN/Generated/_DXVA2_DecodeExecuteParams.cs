﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva2api.h(635,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA2_DecodeExecuteParams
    {
        public uint NumCompBuffers;
        public IntPtr pCompressedBuffers;
        public IntPtr pExtensionData;
    }
}
