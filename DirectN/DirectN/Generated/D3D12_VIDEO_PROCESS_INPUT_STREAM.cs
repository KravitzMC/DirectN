﻿// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_PROCESS_INPUT_STREAM
    {
        public IntPtr pTexture2D;
        public uint Subresource;
        public D3D12_VIDEO_PROCESS_REFERENCE_SET ReferenceSet;
    }
}
