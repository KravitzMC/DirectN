﻿// generated from <Windows SDK Path>\um\mfobjects.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a27003cf-2354-4f2a-8d6a-ab7cff15437e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFAsyncCallback
    {
        [PreserveSig]
        HRESULT GetParameters(/* [out] __RPC__out */ out uint pdwFlags, /* [out] __RPC__out */ out uint pdwQueue);
        
        [PreserveSig]
        HRESULT Invoke(/* [in] __RPC__in_opt */ IMFAsyncResult pAsyncResult);
    }
}
