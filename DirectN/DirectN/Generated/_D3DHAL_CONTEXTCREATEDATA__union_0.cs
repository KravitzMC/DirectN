﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dhal.h(447,5)
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_CONTEXTCREATEDATA__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3000)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public IntPtr lpDDGbl { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set => InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); }
        public IntPtr lpDDLcl { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set => InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); }
    }
}
