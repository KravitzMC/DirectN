﻿// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagHANDLETABLE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public IntPtr[] objectHandle;
    }
}
