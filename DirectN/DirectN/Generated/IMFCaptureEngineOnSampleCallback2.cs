﻿// generated from <Windows SDK Path>\um\mfcaptureengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e37ceed7-340f-4514-9f4d-9c2ae026100b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCaptureEngineOnSampleCallback2 : IMFCaptureEngineOnSampleCallback
    {
        // IMFCaptureEngineOnSampleCallback
        [PreserveSig]
        new HRESULT OnSample(/* [annotation][in] _In_opt_ */ IMFSample pSample);
        
        // IMFCaptureEngineOnSampleCallback2
        [PreserveSig]
        HRESULT OnSynchronizedEvent(/* [annotation][in] _In_ */ IMFMediaEvent pEvent);
    }
}
