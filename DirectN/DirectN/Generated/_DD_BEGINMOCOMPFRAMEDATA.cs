﻿// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;
using PDD_MOTIONCOMP_LOCAL = DirectN._DD_MOTIONCOMP_LOCAL;
using PDD_SURFACE_LOCAL = DirectN._DD_SURFACE_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_BEGINMOCOMPFRAMEDATA
    {
        public IntPtr lpDD;
        public IntPtr lpMoComp;
        public IntPtr lpDestSurface;
        public uint dwInputDataSize;
        public IntPtr lpInputData;
        public uint dwOutputDataSize;
        public IntPtr lpOutputData;
        public HRESULT ddRVal;
    }
}
