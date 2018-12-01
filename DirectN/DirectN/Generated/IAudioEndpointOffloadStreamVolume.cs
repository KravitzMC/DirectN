﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\audioengineendpoint.h(752,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("64f1dd49-71ca-4281-8672-3a9eddd1d0b6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioEndpointOffloadStreamVolume
    {
        [PreserveSig]
        HRESULT GetVolumeChannelCount(/* [out] */ out uint pu32ChannelCount);
        
        [PreserveSig]
        HRESULT SetChannelVolumes(/* [in] */ uint u32ChannelCount, /* [in] */ ref float pf32Volumes, /* [in] */ AUDIO_CURVE_TYPE u32CurveType, /* [in] */ ref long pCurveDuration);
        
        [PreserveSig]
        HRESULT GetChannelVolumes(/* [in] */ uint u32ChannelCount, /* [out] */ out float pf32Volumes);
    }
}
