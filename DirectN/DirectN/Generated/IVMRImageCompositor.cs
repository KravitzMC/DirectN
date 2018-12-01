﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(20189,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("7a4fb5af-479f-4074-bb40-ce6722e43c82"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVMRImageCompositor
    {
        [PreserveSig]
        HRESULT InitCompositionTarget(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pD3DDevice, /* [in] */ IntPtr pddsRenderTarget);
        
        [PreserveSig]
        HRESULT TermCompositionTarget(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pD3DDevice, /* [in] */ IntPtr pddsRenderTarget);
        
        [PreserveSig]
        HRESULT SetStreamMediaType(/* [in] */ uint dwStrmID, /* [in] */ ref _AMMediaType pmt, /* [in] */ bool fTexture);
        
        [PreserveSig]
        HRESULT CompositeImage(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pD3DDevice, /* [in] */ IntPtr pddsRenderTarget, /* [in] */ ref _AMMediaType pmtRenderTarget, /* [in] */ long rtStart, /* [in] */ long rtEnd, /* [in] */ uint dwClrBkGnd, /* [in] */ ref _VMRVIDEOSTREAMINFO pVideoStreamInfo, /* [in] */ uint cStreams);
    }
}
