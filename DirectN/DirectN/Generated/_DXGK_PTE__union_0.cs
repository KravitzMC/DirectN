﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(203,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_PTE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGK_PTE__union_0__struct_0 __field_0 { get => InteropRuntime.Get<_DXGK_PTE__union_0__struct_0>(__bits, 0, 64); set => InteropRuntime.Set<_DXGK_PTE__union_0__struct_0>(value, __bits, 0, 64); }
        public ulong Flags { get => InteropRuntime.GetUInt64(__bits, 0, 64); set => InteropRuntime.SetUInt64(value, __bits, 0, 64); }
    }
}
