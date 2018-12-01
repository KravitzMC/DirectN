﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dcommon.h(578,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("00000000-0000-0000-0000-000000000000"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3DInclude
    {
        [PreserveSig]
        HRESULT Open(_D3D_INCLUDE_TYPE IncludeType, [MarshalAs(UnmanagedType.LPStr)] string pFileName, IntPtr pParentData, [MarshalAs(UnmanagedType.IUnknown)] object ppData, ref uint pBytes);
        
        [PreserveSig]
        HRESULT Close(IntPtr pData);
    }
}
