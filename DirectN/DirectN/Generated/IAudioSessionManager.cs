﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\audiopolicy.h(731,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("bfa971f1-4d5e-40bb-935e-967039bfbee4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioSessionManager
    {
        [PreserveSig]
        HRESULT GetAudioSessionControl(/* [annotation][in] _In_opt_ */ Guid AudioSessionGuid, /* [annotation][in] _In_ */ uint StreamFlags, /* [annotation][out] _Outptr_ */ out IAudioSessionControl SessionControl);
        
        [PreserveSig]
        HRESULT GetSimpleAudioVolume(/* [annotation][in] _In_opt_ */ Guid AudioSessionGuid, /* [annotation][in] _In_ */ uint StreamFlags, /* [annotation][out] _Outptr_ */ out ISimpleAudioVolume AudioVolume);
    }
}
