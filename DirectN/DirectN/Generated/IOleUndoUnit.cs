﻿// generated from <Windows SDK Path>\um\ocidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("894ad3b0-ef97-11ce-9bc9-00aa00608e01"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IOleUndoUnit
    {
        [PreserveSig]
        HRESULT Do(/* [in] __RPC__in_opt */ IOleUndoManager pUndoManager);
        
        [PreserveSig]
        HRESULT GetDescription(/* [out] __RPC__deref_out_opt */ out IntPtr pBstr);
        
        [PreserveSig]
        HRESULT GetUnitType(/* [out] __RPC__out */ out Guid pClsid, /* [out] __RPC__out */ out int plID);
        
        [PreserveSig]
        HRESULT OnNextAdd();
    }
}
