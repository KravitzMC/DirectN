﻿// generated from <Windows SDK Path>\shared\ks.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSQUERYBUFFER
    {
        public KSIDENTIFIER Event;
        public IntPtr EventData;
        public IntPtr Reserved;
    }
}
