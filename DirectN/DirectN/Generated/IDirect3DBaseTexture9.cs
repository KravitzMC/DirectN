﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d9helper.h(143,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("580ca87e-1d3c-4d54-991d-b7d3e3c298ce"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DBaseTexture9 : IDirect3DResource9
    {
        // IDirect3DResource9
        [PreserveSig]
        new HRESULT GetDevice(ref IDirect3DDevice9 ppDevice);
        
        [PreserveSig]
        new HRESULT SetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid refguid, IntPtr pData, uint SizeOfData, uint Flags);
        
        [PreserveSig]
        new HRESULT GetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid refguid, [MarshalAs(UnmanagedType.IUnknown)] object pData, ref uint pSizeOfData);
        
        [PreserveSig]
        new HRESULT FreePrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid refguid);
        
        [PreserveSig]
        new uint SetPriority(uint PriorityNew);
        
        [PreserveSig]
        new uint GetPriority();
        
        [PreserveSig]
        new void PreLoad();
        
        [PreserveSig]
        new _D3DRESOURCETYPE GetType();
        
        // IDirect3DBaseTexture9
        [PreserveSig]
        uint SetLOD(uint LODNew);
        
        [PreserveSig]
        uint GetLOD();
        
        [PreserveSig]
        uint GetLevelCount();
        
        [PreserveSig]
        HRESULT SetAutoGenFilterType(_D3DTEXTUREFILTERTYPE FilterType);
        
        [PreserveSig]
        _D3DTEXTUREFILTERTYPE GetAutoGenFilterType();
        
        [PreserveSig]
        void GenerateMipSubLevels();
    }
}
