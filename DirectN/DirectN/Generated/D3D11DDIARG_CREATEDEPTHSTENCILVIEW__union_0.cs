﻿// generated from <Windows SDK Path>\um\d3d10umddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11DDIARG_CREATEDEPTHSTENCILVIEW__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D10DDIARG_TEX1D_DEPTHSTENCILVIEW Tex1D { get => InteropRuntime.Get<D3D10DDIARG_TEX1D_DEPTHSTENCILVIEW>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D10DDIARG_TEX1D_DEPTHSTENCILVIEW>(value, __bits, 0, 96); } }
        public D3D10DDIARG_TEX2D_DEPTHSTENCILVIEW Tex2D { get => InteropRuntime.Get<D3D10DDIARG_TEX2D_DEPTHSTENCILVIEW>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D10DDIARG_TEX2D_DEPTHSTENCILVIEW>(value, __bits, 0, 96); } }
        public D3D10DDIARG_TEXCUBE_DEPTHSTENCILVIEW TexCube { get => InteropRuntime.Get<D3D10DDIARG_TEXCUBE_DEPTHSTENCILVIEW>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D10DDIARG_TEXCUBE_DEPTHSTENCILVIEW>(value, __bits, 0, 96); } }
    }
}
