﻿// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_WAITFORSYNCHRONIZATIONOBJECTFROMGPU
    {
        public uint hContext;
        public uint ObjectCount;
        public IntPtr ObjectHandleArray;
        public _D3DKMT_WAITFORSYNCHRONIZATIONOBJECTFROMGPU__union_0 __union_3;
    }
}
