﻿// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_MBctrl_H264__union_1__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public ushort[] LumaIntraPredModes;
        public _DXVA_MBctrl_H264__union_1__struct_0__union_0 __union_1;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public byte[] ReservedIntra24Bits;
    }
}
