﻿// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAW_MODE_SPECIFIC_CAPS
    {
        public uint Head;
        public uint Caps;
        public uint CKeyCaps;
        public uint FxCaps;
        public uint MaxVisibleOverlays;
        public uint MinOverlayStretch;
        public uint MaxOverlayStretch;
    }
}
