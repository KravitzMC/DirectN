﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(988,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSAUDIO_PRESENTATION_POSITION
    {
        public ulong u64PositionInBlocks;
        public ulong u64QPCPosition;
    }
}