﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dtypes.h(416,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DLVERTEX__union_2
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public float z { get => InteropRuntime.GetSingle(__bits, 0, 32); set => InteropRuntime.SetSingle(value, __bits, 0, 32); }
        public float dvZ { get => InteropRuntime.GetSingle(__bits, 0, 32); set => InteropRuntime.SetSingle(value, __bits, 0, 32); }
    }
}
