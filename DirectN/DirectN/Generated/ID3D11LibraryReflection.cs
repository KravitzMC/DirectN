﻿// generated from <Windows SDK Path>\um\d3d11shader.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("54384f1b-5b3e-4bb7-ae01-60ba3097cbb6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11LibraryReflection
    {
        [PreserveSig]
        HRESULT GetDesc(/* THIS_ _Out_ */ out _D3D11_LIBRARY_DESC pDesc);
        
        [PreserveSig]
        ID3D11FunctionReflection GetFunctionByIndex(/* THIS_ _In_ */ int FunctionIndex);
    }
}
