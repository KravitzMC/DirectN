﻿// generated from <Windows SDK Path>\um\d3d10umddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10DDIARG_CREATERENDERTARGETVIEW__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D10DDIARG_BUFFER_RENDERTARGETVIEW Buffer { get => InteropRuntime.Get<D3D10DDIARG_BUFFER_RENDERTARGETVIEW>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D10DDIARG_BUFFER_RENDERTARGETVIEW>(value, __bits, 0, 64); } }
        public D3D10DDIARG_TEX1D_RENDERTARGETVIEW Tex1D { get => InteropRuntime.Get<D3D10DDIARG_TEX1D_RENDERTARGETVIEW>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D10DDIARG_TEX1D_RENDERTARGETVIEW>(value, __bits, 0, 96); } }
        public D3D10DDIARG_TEX2D_RENDERTARGETVIEW Tex2D { get => InteropRuntime.Get<D3D10DDIARG_TEX2D_RENDERTARGETVIEW>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D10DDIARG_TEX2D_RENDERTARGETVIEW>(value, __bits, 0, 96); } }
        public D3D10DDIARG_TEX3D_RENDERTARGETVIEW Tex3D { get => InteropRuntime.Get<D3D10DDIARG_TEX3D_RENDERTARGETVIEW>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D10DDIARG_TEX3D_RENDERTARGETVIEW>(value, __bits, 0, 96); } }
        public D3D10DDIARG_TEXCUBE_RENDERTARGETVIEW TexCube { get => InteropRuntime.Get<D3D10DDIARG_TEXCUBE_RENDERTARGETVIEW>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D10DDIARG_TEXCUBE_RENDERTARGETVIEW>(value, __bits, 0, 96); } }
    }
}
