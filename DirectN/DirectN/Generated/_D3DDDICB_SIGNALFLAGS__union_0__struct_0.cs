﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(1193,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_SIGNALFLAGS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint SignalAtSubmission => InteropRuntime.GetUInt32Bits(__bits, 0, 1);
        public uint EnqueueCpuEvent => InteropRuntime.GetUInt32Bits(__bits, 1, 1);
        public uint AllowFenceRewind => InteropRuntime.GetUInt32Bits(__bits, 2, 1);
        public uint Reserved => InteropRuntime.GetUInt32Bits(__bits, 3, 28);
        public uint DXGK_SIGNAL_FLAG_INTERNAL0 => InteropRuntime.GetUInt32Bits(__bits, 31, 1);
    }
}
