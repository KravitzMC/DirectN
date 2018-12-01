﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1svg.h(601,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Interface describing an SVG attribute.
    /// </summary>
    [Guid("c9cdb0dd-f8c9-4e70-b7c2-301c80292c5e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1SvgAttribute
    {
        [PreserveSig]
        void GetElement(/* _Outptr_result_maybenull_ */ out ID2D1SvgElement element);
        
        [PreserveSig]
        HRESULT Clone(/* _COM_Outptr_ */ out ID2D1SvgAttribute attribute);
    }
}
