﻿// generated from <Windows SDK Path>\um\wmcodecdsp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("73f0be8e-57f7-4f01-aa66-9f57340cfe0e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMCodecPrivateData
    {
        [PreserveSig]
        HRESULT SetPartialOutputType(/* [in] */ ref _DMOMediaType pmt);
        
        [PreserveSig]
        HRESULT GetPrivateData(/* [size_is][unique][out][in] */ [In, Out, MarshalAs(UnmanagedType.LPArray)] byte[] pbData, /* [out][in] */ ref uint pcbData);
    }
}
