﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11.h(9732,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_ENCRYPTED_BLOCK_INFO
    {
        public uint NumEncryptedBytesAtBeginning;
        public uint NumBytesInSkipPattern;
        public uint NumBytesInEncryptPattern;
    }
}
