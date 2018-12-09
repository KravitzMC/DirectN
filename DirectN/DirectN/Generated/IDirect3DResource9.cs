﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d9helper.h(139,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("05eec05d-8f7d-4362-b999-d1baf357c704"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DResource9
    {
        [PreserveSig]
        HRESULT GetDevice(ref IDirect3DDevice9 ppDevice);
        
        [PreserveSig]
        HRESULT SetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid refguid, IntPtr pData, uint SizeOfData, uint Flags);
        
        [PreserveSig]
        HRESULT GetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid refguid, [MarshalAs(UnmanagedType.IUnknown)] object pData, ref uint pSizeOfData);
        
        [PreserveSig]
        HRESULT FreePrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid refguid);
        
        [PreserveSig]
        uint SetPriority(uint PriorityNew);
        
        [PreserveSig]
        uint GetPriority();
        
        [PreserveSig]
        void PreLoad();
        
        [PreserveSig]
        _D3DRESOURCETYPE GetType();
    }
}
