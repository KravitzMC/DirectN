﻿// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_EXTENSION_COMMAND_INFO_0063
    {
        public Guid CommandId;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Name;
        public D3D12DDI_COMMAND_QUEUE_FLAGS CommandQueueFlags;
    }
}
