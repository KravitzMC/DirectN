﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_2.h(657,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The IDWriteFont interface represents a physical font in a font collection.
    /// </summary>
    [Guid("29748ed6-8c9c-4a6a-be0b-d912e8538944"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFont2
    {
        [PreserveSig]
        bool IsColorFont();
    }
}
