﻿// generated from <Windows SDK Path>\um\ddkmapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDOPENSURFACEIN
    {
        public IntPtr hDirectDraw;
        public IntPtr dwSurfaceHandle;
        public IntPtr pfnSurfaceClose;
        public IntPtr pContext;
    }
}
