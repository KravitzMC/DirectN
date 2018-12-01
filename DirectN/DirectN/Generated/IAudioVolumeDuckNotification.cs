﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\audiopolicy.h(841,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("c3b284d4-6d39-4359-b3cf-b56ddb3bb39c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioVolumeDuckNotification
    {
        [PreserveSig]
        HRESULT OnVolumeDuckNotification(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string sessionID, /* [in] */ uint countCommunicationSessions);
        
        [PreserveSig]
        HRESULT OnVolumeUnduckNotification(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string sessionID);
    }
}
