﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfapi.h(3393,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFCameraExtrinsic_CalibratedTransform
    {
        public Guid CalibrationId;
        public _MF_FLOAT3 Position;
        public _MF_QUATERNION Orientation;
    }
}