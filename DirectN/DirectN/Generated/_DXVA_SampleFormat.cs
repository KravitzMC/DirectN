﻿// generated from <Windows SDK Path>\um\dxva.h
using System;

namespace DirectN
{
    [Flags]
    public enum _DXVA_SampleFormat
    {
        DXVA_SampleFormatMask = 0x000000FF,
        DXVA_SampleUnknown = 0x00000000,
        DXVA_SamplePreviousFrame = 0x00000001,
        DXVA_SampleProgressiveFrame = 0x00000002,
        DXVA_SampleFieldInterleavedEvenFirst = 0x00000003,
        DXVA_SampleFieldInterleavedOddFirst = 0x00000004,
        DXVA_SampleFieldSingleEven = 0x00000005,
        DXVA_SampleFieldSingleOdd = 0x00000006,
        DXVA_SampleSubStream = 0x00000007,
    }
}
