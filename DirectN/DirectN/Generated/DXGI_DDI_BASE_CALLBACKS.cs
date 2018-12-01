﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxgiddi.h(972,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DDI_BASE_CALLBACKS
    {
        public IntPtr pfnPresentCb;
        public IntPtr pfnPresentMultiplaneOverlayCb;
        public IntPtr pfnPresentMultiplaneOverlay1Cb;
        public IntPtr pfnSubmitPresentBltToHwQueueCb;
        public IntPtr pfnSubmitPresentToHwQueueCb;
    }
}