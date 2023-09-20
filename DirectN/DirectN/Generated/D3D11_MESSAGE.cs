﻿// generated from <Windows SDK Path>\um\d3d11sdklayers.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_MESSAGE
    {
        public D3D11_MESSAGE_CATEGORY Category;
        public D3D11_MESSAGE_SEVERITY Severity;
        public D3D11_MESSAGE_ID ID;
        [MarshalAs(UnmanagedType.LPStr)] 
        public byte pDescription;
        public IntPtr DescriptionByteLength;
    }
}
