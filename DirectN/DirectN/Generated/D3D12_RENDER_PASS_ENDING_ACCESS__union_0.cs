﻿// generated from <Windows SDK Path>\um\d3d12.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RENDER_PASS_ENDING_ACCESS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 76)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS Resolve { get => InteropRuntime.Get<D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS>(__bits, 0, 608); set { if (__bits == null) __bits = new byte[76]; InteropRuntime.Set<D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS>(value, __bits, 0, 608); } }
    }
}
