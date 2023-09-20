﻿// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("458e1fd1-b1b2-4750-a6e1-9c10f03bed92"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcValidator2 : IDxcValidator
    {
        // IDxcValidator
        [PreserveSig]
        new HRESULT Validate(/* _In_ */ IDxcBlob pShader, /* // Shader to validate. _In_ */ uint Flags, /* // Validation flags. _COM_Outptr_ */ out IDxcOperationResult ppResult);
        
        // IDxcValidator2
        [PreserveSig]
        HRESULT ValidateWithDebug(/* _In_ */ IDxcBlob pShader, /* // Shader to validate. _In_ */ uint Flags, /* optional(DxcBuffer) */ IntPtr pOptDebugBitcode, /* // Optional debug module bitcode to provide line numbers _COM_Outptr_ */ out IDxcOperationResult ppResult);
    }
}
