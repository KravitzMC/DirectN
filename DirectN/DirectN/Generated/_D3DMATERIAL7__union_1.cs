﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dtypes.h(756,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DMATERIAL7__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] __bits;
        public _D3DCOLORVALUE ambient => InteropRuntime.GetBits<_D3DCOLORVALUE>(__bits, 0, 128);
        public _D3DCOLORVALUE dcvAmbient => InteropRuntime.GetBits<_D3DCOLORVALUE>(__bits, 0, 128);
    }
}
