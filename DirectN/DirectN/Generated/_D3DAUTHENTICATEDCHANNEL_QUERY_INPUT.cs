﻿// generated from <Windows SDK Path>\shared\d3d9types.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DAUTHENTICATEDCHANNEL_QUERY_INPUT_32
    {
        public Guid QueryType;
        public IntPtr hChannel;
        public uint SequenceNumber;
    }

    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DAUTHENTICATEDCHANNEL_QUERY_INPUT_64
    {
        public Guid QueryType;
        public IntPtr hChannel;
        public uint SequenceNumber;
    }
}
