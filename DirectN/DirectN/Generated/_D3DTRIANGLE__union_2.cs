﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dtypes.h(1802,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DTRIANGLE__union_2
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] __bits;
        public ushort v3 => InteropRuntime.GetUInt16Bits(__bits, 0, 16);
        public ushort wV3 => InteropRuntime.GetUInt16Bits(__bits, 0, 16);
    }
}