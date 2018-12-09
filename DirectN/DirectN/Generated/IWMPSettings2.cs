﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmp.h(7215,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("fda937a4-eece-4da5-a0b6-39bf89ade2c2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPSettings2 : IWMPSettings
    {
        // IWMPSettings
        [PreserveSig]
        new HRESULT get_isAvailable(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItem, /* [retval][out] */ out VARIANT_BOOL pIsAvailable);
        
        [PreserveSig]
        new HRESULT get_autoStart(/* [retval][out] */ out VARIANT_BOOL pfAutoStart);
        
        [PreserveSig]
        new HRESULT put_autoStart(/* [in] */ short fAutoStart);
        
        [PreserveSig]
        new HRESULT get_baseURL(/* [retval][out] */ out IntPtr pbstrBaseURL);
        
        [PreserveSig]
        new HRESULT put_baseURL(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrBaseURL);
        
        [PreserveSig]
        new HRESULT get_defaultFrame(/* [retval][out] */ out IntPtr pbstrDefaultFrame);
        
        [PreserveSig]
        new HRESULT put_defaultFrame(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrDefaultFrame);
        
        [PreserveSig]
        new HRESULT get_invokeURLs(/* [retval][out] */ out VARIANT_BOOL pfInvokeURLs);
        
        [PreserveSig]
        new HRESULT put_invokeURLs(/* [in] */ short fInvokeURLs);
        
        [PreserveSig]
        new HRESULT get_mute(/* [retval][out] */ out VARIANT_BOOL pfMute);
        
        [PreserveSig]
        new HRESULT put_mute(/* [in] */ short fMute);
        
        [PreserveSig]
        new HRESULT get_playCount(/* [retval][out] */ out long plCount);
        
        [PreserveSig]
        new HRESULT put_playCount(/* [in] */ int lCount);
        
        [PreserveSig]
        new HRESULT get_rate(/* [retval][out] */ out double pdRate);
        
        [PreserveSig]
        new HRESULT put_rate(/* [in] */ double dRate);
        
        [PreserveSig]
        new HRESULT get_balance(/* [retval][out] */ out long plBalance);
        
        [PreserveSig]
        new HRESULT put_balance(/* [in] */ int lBalance);
        
        [PreserveSig]
        new HRESULT get_volume(/* [retval][out] */ out long plVolume);
        
        [PreserveSig]
        new HRESULT put_volume(/* [in] */ int lVolume);
        
        [PreserveSig]
        new HRESULT getMode(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrMode, /* [retval][out] */ out VARIANT_BOOL pvarfMode);
        
        [PreserveSig]
        new HRESULT setMode(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrMode, /* [in] */ short varfMode);
        
        [PreserveSig]
        new HRESULT get_enableErrorDialogs(/* [retval][out] */ out VARIANT_BOOL pfEnableErrorDialogs);
        
        [PreserveSig]
        new HRESULT put_enableErrorDialogs(/* [in] */ short fEnableErrorDialogs);
        
        // IWMPSettings2
        [PreserveSig]
        HRESULT get_defaultAudioLanguage(/* [retval][out] */ out long plLangID);
        
        [PreserveSig]
        HRESULT get_mediaAccessRights(/* [retval][out] */ out IntPtr pbstrRights);
        
        [PreserveSig]
        HRESULT requestMediaAccessRights(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrDesiredAccess, /* [retval][out] */ out VARIANT_BOOL pvbAccepted);
    }
}
