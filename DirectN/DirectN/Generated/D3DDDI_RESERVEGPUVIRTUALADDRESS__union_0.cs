﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(1442,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDI_RESERVEGPUVIRTUALADDRESS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint hPagingQueue => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
        public uint hAdapter => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
    }
}
