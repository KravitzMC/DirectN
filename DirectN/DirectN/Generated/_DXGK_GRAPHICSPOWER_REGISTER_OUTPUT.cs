﻿// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_GRAPHICSPOWER_REGISTER_OUTPUT
    {
        public IntPtr DeviceHandle;
        public DEVICE_POWER_STATE InitialGrfxPowerState;
        public IntPtr SetSharedPowerComponentStateCb;
        public IntPtr UnregisterCb;
    }
}
