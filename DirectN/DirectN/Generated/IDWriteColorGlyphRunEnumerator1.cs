﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_3.h(1875,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Enumerator for an ordered collection of color glyph runs.
    /// </summary>
    [Guid("7c5f86da-c7a1-4f05-b8e1-55a179fe5a35"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteColorGlyphRunEnumerator1
    {
        [PreserveSig]
        HRESULT GetCurrentRun(/* _Outptr_ */ out DWRITE_COLOR_GLYPH_RUN1 colorGlyphRun);
    }
}
