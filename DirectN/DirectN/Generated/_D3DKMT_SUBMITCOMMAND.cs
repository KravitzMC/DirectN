﻿// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SUBMITCOMMAND
    {
        public ulong Commands;
        public uint CommandLength;
        public _D3DKMT_SUBMITCOMMANDFLAGS Flags;
        public ulong PresentHistoryToken;
        public uint BroadcastContextCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public uint[] BroadcastContext;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public uint NumPrimaries;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public uint[] WrittenPrimaries;
        public uint NumHistoryBuffers;
        public IntPtr HistoryBufferArray;
    }
}
