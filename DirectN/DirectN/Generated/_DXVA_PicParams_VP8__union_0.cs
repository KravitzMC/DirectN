﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(1418,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_VP8__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXVA_PicParams_VP8__union_0__struct_0 __field_0 { get => InteropRuntime.Get<_DXVA_PicParams_VP8__union_0__struct_0>(__bits, 0, 8); set => InteropRuntime.Set<_DXVA_PicParams_VP8__union_0__struct_0>(value, __bits, 0, 8); }
        public byte wFrameTagFlags { get => InteropRuntime.GetByte(__bits, 0, 8); set => InteropRuntime.SetByte(value, __bits, 0, 8); }
    }
}
