﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ocidl.h(1924,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("01e44665-24ac-101b-84ed-08002b2ec713"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPropertyPage2 : IPropertyPage
    {
        // IPropertyPage
        [PreserveSig]
        new HRESULT SetPageSite(/* [in] __RPC__in_opt */ IPropertyPageSite pPageSite);
        
        [PreserveSig]
        new HRESULT Activate(/* [in] __RPC__in */ IntPtr hWndParent, /* [in] __RPC__in */ IntPtr pRect, /* [in] */ bool bModal);
        
        [PreserveSig]
        new HRESULT Deactivate();
        
        [PreserveSig]
        new HRESULT GetPageInfo(/* [out] __RPC__out */ out tagPROPPAGEINFO pPageInfo);
        
        [PreserveSig]
        new HRESULT SetObjects(/* [in] */ uint cObjects, /* [size_is][in] __RPC__in_ecount_full(cObjects) */ [MarshalAs(UnmanagedType.IUnknown)] object ppUnk);
        
        [PreserveSig]
        new HRESULT Show(/* [in] */ uint nCmdShow);
        
        [PreserveSig]
        new HRESULT Move(/* [in] __RPC__in */ IntPtr pRect);
        
        [PreserveSig]
        new HRESULT IsPageDirty();
        
        [PreserveSig]
        new HRESULT Apply();
        
        [PreserveSig]
        new HRESULT Help(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string pszHelpDir);
        
        [PreserveSig]
        new HRESULT TranslateAcceleratorA(/* [in] __RPC__in */ ref tagMSG pMsg);
        
        // IPropertyPage2
        [PreserveSig]
        HRESULT EditProperty(/* [in] */ int dispID);
    }
}
