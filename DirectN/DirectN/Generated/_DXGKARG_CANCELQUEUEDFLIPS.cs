﻿// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CANCELQUEUEDFLIPS
    {
        public uint VidPnSourceId;
        public uint LayerIndex;
        public ulong PresentIdCancelRequested;
        public ulong PresentIdCancelled;
    }
}
