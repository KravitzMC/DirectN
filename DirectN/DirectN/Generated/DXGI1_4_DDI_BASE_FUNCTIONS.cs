﻿// generated from <Windows SDK Path>\um\dxgiddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI1_4_DDI_BASE_FUNCTIONS
    {
        public IntPtr pfnPresent;
        public IntPtr pfnGetGammaCaps;
        public IntPtr pfnSetDisplayMode;
        public IntPtr pfnSetResourcePriority;
        public IntPtr pfnQueryResourceResidency;
        public IntPtr pfnRotateResourceIdentities;
        public IntPtr pfnBlt;
        public IntPtr pfnResolveSharedResource;
        public IntPtr pfnBlt1;
        public IntPtr pfnOfferResources;
        public IntPtr pfnReclaimResources;
        public IntPtr pfnGetMultiplaneOverlayCaps;
        public IntPtr pfnGetMultiplaneOverlayGroupCaps;
        public IntPtr pfnReserved1;
        public IntPtr pfnPresentMultiplaneOverlay;
        public IntPtr pfnReserved2;
        public IntPtr pfnPresent1;
        public IntPtr pfnCheckPresentDurationSupport;
        public IntPtr pfnTrimResidencySet;
        public IntPtr pfnCheckMultiplaneOverlayColorSpaceSupport;
        public IntPtr pfnPresentMultiplaneOverlay1;
    }
}
