﻿// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_GETPITCH
    {
        public IntPtr hCryptoSession;
        public IntPtr hResource;
        public uint SubResourceIndex;
        public uint Pitch;
    }
}
