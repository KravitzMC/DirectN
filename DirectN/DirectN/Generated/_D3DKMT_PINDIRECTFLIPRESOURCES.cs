﻿// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_PINDIRECTFLIPRESOURCES
    {
        public uint hDevice;
        public uint ResourceCount;
        public IntPtr pResourceList;
    }
}
