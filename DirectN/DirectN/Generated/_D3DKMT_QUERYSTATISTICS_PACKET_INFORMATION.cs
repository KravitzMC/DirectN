﻿// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_PACKET_INFORMATION
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public _D3DKMT_QUERYSTATISTICS_QUEUE_PACKET_TYPE_INFORMATION[] QueuePacket;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public _D3DKMT_QUERYSTATISTICS_DMA_PACKET_TYPE_INFORMATION[] DmaPacket;
    }
}
