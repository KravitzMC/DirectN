﻿// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_QUERY_DATA_PIPELINE_STATISTICS1
    {
        public ulong IAVertices;
        public ulong IAPrimitives;
        public ulong VSInvocations;
        public ulong GSInvocations;
        public ulong GSPrimitives;
        public ulong CInvocations;
        public ulong CPrimitives;
        public ulong PSInvocations;
        public ulong HSInvocations;
        public ulong DSInvocations;
        public ulong CSInvocations;
        public ulong ASInvocations;
        public ulong MSInvocations;
        public ulong MSPrimitives;
    }
}
