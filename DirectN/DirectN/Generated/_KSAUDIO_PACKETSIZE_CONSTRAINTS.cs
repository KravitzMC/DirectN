﻿// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _KSAUDIO_PACKETSIZE_CONSTRAINTS
    {
        public uint MinPacketPeriodInHns;
        public uint PacketSizeFileAlignment;
        public uint Reserved;
        public uint NumProcessingModeConstraints;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public _KSAUDIO_PACKETSIZE_SIGNALPROCESSINGMODE_CONSTRAINT[] ProcessingModeConstraints;
    }
}
