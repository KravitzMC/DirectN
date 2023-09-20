﻿// generated from <Windows SDK Path>\shared\dxgi1_5.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_HDR_METADATA_HDR10
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public ushort[] RedPrimary;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public ushort[] GreenPrimary;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public ushort[] BluePrimary;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public ushort[] WhitePoint;
        public uint MaxMasteringLuminance;
        public uint MinMasteringLuminance;
        public ushort MaxContentLightLevel;
        public ushort MaxFrameAverageLightLevel;
    }
}
