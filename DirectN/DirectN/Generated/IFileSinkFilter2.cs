﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(6374,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("00855b90-ce1b-11d0-bd4f-00a0c911ce86"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IFileSinkFilter2 : IFileSinkFilter
    {
        // IFileSinkFilter
        [PreserveSig]
        new HRESULT SetFileName(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszFileName, /* [annotation][unique][in] _In_opt_ */ ref _AMMediaType pmt);
        
        [PreserveSig]
        new HRESULT GetCurFile(/* [annotation][out] _Out_ */ out IntPtr ppszFileName, /* [annotation][out] _Out_ */ out _AMMediaType pmt);
        
        // IFileSinkFilter2
        [PreserveSig]
        HRESULT SetMode(/* [in] */ uint dwFlags);
        
        [PreserveSig]
        HRESULT GetMode(/* [annotation][out] _Out_ */ out uint pdwFlags);
    }
}
