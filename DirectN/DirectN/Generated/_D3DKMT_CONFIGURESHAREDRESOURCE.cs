﻿// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CONFIGURESHAREDRESOURCE
    {
        public uint hDevice;
        public uint hResource;
        public byte IsDwm;
        public IntPtr hProcess;
        public byte AllowAccess;
    }
}
