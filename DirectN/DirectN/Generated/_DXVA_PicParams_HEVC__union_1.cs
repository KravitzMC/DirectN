﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(1186,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_HEVC__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public _DXVA_PicParams_HEVC__union_1__struct_0 __field_0 => InteropRuntime.GetBits<_DXVA_PicParams_HEVC__union_1__struct_0>(__bits, 0, 32);
        public uint dwCodingParamToolFlags => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
    }
}
