﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wingdi.h(913,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagBITMAPINFO
    {
        public tagBITMAPINFOHEADER bmiHeader;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public tagRGBQUAD[] bmiColors;
    }
}
