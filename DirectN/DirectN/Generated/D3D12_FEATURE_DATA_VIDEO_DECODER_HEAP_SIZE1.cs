﻿// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE1
    {
        public D3D12_VIDEO_DECODER_HEAP_DESC VideoDecoderHeapDesc;
        public bool Protected;
        public ulong MemoryPoolL0Size;
        public ulong MemoryPoolL1Size;
    }
}
