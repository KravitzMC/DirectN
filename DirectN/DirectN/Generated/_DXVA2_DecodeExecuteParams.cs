﻿// generated from <Windows SDK Path>\um\dxva2api.h
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
