﻿// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6816dad3-2b4b-4c8e-8149-874c3483a753"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMIStreamProps
    {
        [PreserveSig]
        HRESULT GetProperty(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [out] */ out WMT_ATTR_DATATYPE pType, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref uint pdwSize);
    }
}
