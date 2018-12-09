﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmcodecdsp.h(2855,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4c06bb9b-626c-4614-8329-cc6a21b93fa0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMFrameInterpProps
    {
        [PreserveSig]
        HRESULT SetFrameRateIn(/* [in] */ int lFrameRate, /* [in] */ int lScale);
        
        [PreserveSig]
        HRESULT SetFrameRateOut(/* [in] */ int lFrameRate, /* [in] */ int lScale);
        
        [PreserveSig]
        HRESULT SetFrameInterpEnabled(/* [in] */ bool bFIEnabled);
        
        [PreserveSig]
        HRESULT SetComplexityLevel(/* [in] */ int iComplexity);
    }
}
