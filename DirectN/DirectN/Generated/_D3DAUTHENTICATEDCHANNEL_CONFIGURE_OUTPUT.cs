﻿// generated from <Windows SDK Path>\shared\d3d9types.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT
    {
        public _D3D_OMAC omac;
        public Guid ConfigureType;
        public IntPtr hChannel;
        public uint SequenceNumber;
        public HRESULT ReturnCode;
    }
}
