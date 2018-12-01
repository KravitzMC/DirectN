﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(7233,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d3c4ef59-49ce-4381-9071-d5bcd044c770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFContentEnabler
    {
        [PreserveSig]
        HRESULT GetEnableType(/* [out] __RPC__out */ out Guid pType);
        
        [PreserveSig]
        HRESULT GetEnableURL(/* [size_is][size_is][out] __RPC__deref_out_ecount_full_opt(*pcchURL) */ out IntPtr ppwszURL, /* [out] __RPC__out */ out uint pcchURL, /* [unique][out][in] __RPC__inout_opt */ ref __MIDL___MIDL_itf_mfidl_0000_0031_0001 pTrustStatus);
        
        [PreserveSig]
        HRESULT GetEnableData(/* [size_is][size_is][out] __RPC__deref_out_ecount_full_opt(*pcbData) */ out byte[] ppbData, /* [out] __RPC__out */ out uint pcbData);
        
        [PreserveSig]
        HRESULT IsAutomaticSupported(/* [out] __RPC__out */ out bool pfAutomatic);
        
        [PreserveSig]
        HRESULT AutomaticEnable();
        
        [PreserveSig]
        HRESULT MonitorEnable();
        
        [PreserveSig]
        HRESULT Cancel();
    }
}
