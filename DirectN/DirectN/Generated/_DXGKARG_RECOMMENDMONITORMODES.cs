﻿// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_RECOMMENDMONITORMODES
    {
        public uint VideoPresentTargetId;
        public IntPtr hMonitorSourceModeSet;
        public IntPtr pMonitorSourceModeSetInterface;
    }
}
