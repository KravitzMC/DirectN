﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(1372,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_VP9__union_1__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] __bits;
        public byte mode_ref_delta_enabled => InteropRuntime.GetByteBits(__bits, 0, 1);
        public byte mode_ref_delta_update => InteropRuntime.GetByteBits(__bits, 1, 1);
        public byte use_prev_in_find_mv_refs => InteropRuntime.GetByteBits(__bits, 2, 1);
        public byte ReservedControlInfo5Bits => InteropRuntime.GetByteBits(__bits, 3, 5);
    }
}
