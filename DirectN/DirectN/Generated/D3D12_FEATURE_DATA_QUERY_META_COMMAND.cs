﻿// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_QUERY_META_COMMAND
    {
        public Guid CommandId;
        public uint NodeMask;
        public IntPtr pQueryInputData;
        public IntPtr QueryInputDataSizeInBytes;
        public IntPtr pQueryOutputData;
        public IntPtr QueryOutputDataSizeInBytes;
    }
}
