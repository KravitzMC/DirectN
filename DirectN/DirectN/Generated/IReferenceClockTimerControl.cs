﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(2548,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ebec459c-2eca-4d42-a8af-30df557614b8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IReferenceClockTimerControl
    {
        [PreserveSig]
        HRESULT SetDefaultTimerResolution(long timerResolution);
        
        [PreserveSig]
        HRESULT GetDefaultTimerResolution(/* [annotation] _Out_ */ out long pTimerResolution);
    }
}
