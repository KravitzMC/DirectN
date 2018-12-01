﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(205,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_PTE__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public ulong Valid => InteropRuntime.GetUInt64Bits(__bits, 0, 1);
        public ulong Zero => InteropRuntime.GetUInt64Bits(__bits, 1, 1);
        public ulong CacheCoherent => InteropRuntime.GetUInt64Bits(__bits, 2, 1);
        public ulong ReadOnly => InteropRuntime.GetUInt64Bits(__bits, 3, 1);
        public ulong NoExecute => InteropRuntime.GetUInt64Bits(__bits, 4, 1);
        public ulong Segment => InteropRuntime.GetUInt64Bits(__bits, 5, 5);
        public ulong LargePage => InteropRuntime.GetUInt64Bits(__bits, 10, 1);
        public ulong PhysicalAdapterIndex => InteropRuntime.GetUInt64Bits(__bits, 11, 6);
        public ulong PageTablePageSize => InteropRuntime.GetUInt64Bits(__bits, 17, 2);
        public ulong SystemReserved0 => InteropRuntime.GetUInt64Bits(__bits, 19, 1);
        public ulong Reserved => InteropRuntime.GetUInt64Bits(__bits, 20, 44);
    }
}
