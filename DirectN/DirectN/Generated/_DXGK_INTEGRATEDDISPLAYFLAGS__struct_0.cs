﻿// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_INTEGRATEDDISPLAYFLAGS__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGK_DISPLAYPANELORIENTATION UndockedOrientation { get => InteropRuntime.Get<_DXGK_DISPLAYPANELORIENTATION>(__bits, 0, 2); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_DXGK_DISPLAYPANELORIENTATION>(value, __bits, 0, 2); } }
        public _DXGK_DISPLAYPANELORIENTATION DockedOrientation { get => InteropRuntime.Get<_DXGK_DISPLAYPANELORIENTATION>(__bits, 2, 2); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_DXGK_DISPLAYPANELORIENTATION>(value, __bits, 2, 2); } }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 4, 28); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 4, 28); } }
    }
}
