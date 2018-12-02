﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(310,9)
using System;
using System.Runtime.InteropServices;
using DDPIXELFORMAT = DirectN._DDPIXELFORMAT;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VIDEOMEMORYINFO
    {
        public ulong fpPrimary;
        public uint dwFlags;
        public uint dwDisplayWidth;
        public uint dwDisplayHeight;
        public int lDisplayPitch;
        public DDPIXELFORMAT ddpfDisplay;
        public uint dwOffscreenAlign;
        public uint dwOverlayAlign;
        public uint dwTextureAlign;
        public uint dwZBufferAlign;
        public uint dwAlphaAlign;
        public IntPtr pvPrimary;
    }
}