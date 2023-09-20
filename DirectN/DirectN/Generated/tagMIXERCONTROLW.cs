﻿// generated from <Windows SDK Path>\um\mmeapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct tagMIXERCONTROLW
    {
        public uint cbStruct;
        public uint dwControlID;
        public uint dwControlType;
        public uint fdwControl;
        public uint cMultipleItems;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)] 
        public string szShortName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)] 
        public string szName;
        public tagMIXERCONTROLW__union_0 Bounds;
        public tagMIXERCONTROLW__union_1 Metrics;
    }
}
