﻿// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_MARKDEVICEASERROR
    {
        public uint hDevice;
        public _D3DKMT_DEVICE_ERROR_REASON Reason;
    }
}
