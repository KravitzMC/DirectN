﻿// generated from <Windows SDK Path>\um\d3d11.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("b0e06fe0-8192-4e1a-b1ca-36d7414710b2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11ShaderResourceView : ID3D11View
    {
        // ID3D11DeviceChild
        [PreserveSig]
        new void GetDevice(/* [annotation] _Outptr_ */ out ID3D11Device ppDevice);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _Inout_ */ ref uint pDataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_ */ uint DataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* optional(IUnknown) */ IntPtr pData);
        
        // ID3D11View
        [PreserveSig]
        new void GetResource(/* [annotation] _Outptr_ */ out ID3D11Resource ppResource);
        
        // ID3D11ShaderResourceView
        [PreserveSig]
        void GetDesc(/* [annotation] _Out_ */ out D3D11_SHADER_RESOURCE_VIEW_DESC pDesc);
    }
}
