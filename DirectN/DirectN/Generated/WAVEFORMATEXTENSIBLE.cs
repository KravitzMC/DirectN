﻿// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct WAVEFORMATEXTENSIBLE
    {
        public tWAVEFORMATEX Format;
        public __struct_ksmedia_3__union_0 Samples;
        public uint dwChannelMask;
        public Guid SubFormat;
    }
}
