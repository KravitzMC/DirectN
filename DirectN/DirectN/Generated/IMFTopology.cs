﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(3828,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("83cf873a-f6da-4bc8-823f-bacfd55dc433"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTopology : IMFAttributes
    {
        // IMFAttributes
        [PreserveSig]
        new HRESULT GetItem(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [full][out][in] __RPC__inout_opt */ PropVariant pValue);
        
        [PreserveSig]
        new HRESULT GetItemType(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [out] __RPC__out */ out _MF_ATTRIBUTE_TYPE pType);
        
        [PreserveSig]
        new HRESULT CompareItem(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* __RPC__in */ PropVariant Value, /* [out] __RPC__out */ out bool pbResult);
        
        [PreserveSig]
        new HRESULT Compare(/* __RPC__in_opt */ IMFAttributes pTheirs, _MF_ATTRIBUTES_MATCH_TYPE MatchType, /* [out] __RPC__out */ out bool pbResult);
        
        [PreserveSig]
        new HRESULT GetUINT32(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [out] __RPC__out */ out uint punValue);
        
        [PreserveSig]
        new HRESULT GetUINT64(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [out] __RPC__out */ out ulong punValue);
        
        [PreserveSig]
        new HRESULT GetDouble(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [out] __RPC__out */ out double pfValue);
        
        [PreserveSig]
        new HRESULT GetGUID(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [out] __RPC__out */ out Guid pguidValue);
        
        [PreserveSig]
        new HRESULT GetStringLength(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [out] __RPC__out */ out uint pcchLength);
        
        [PreserveSig]
        new HRESULT GetString(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [size_is][out] __RPC__out_ecount_full(cchBufSize) */ [MarshalAs(UnmanagedType.LPWStr)] string pwszValue, uint cchBufSize, /* [full][out][in] __RPC__inout_opt */ ref uint pcchLength);
        
        [PreserveSig]
        new HRESULT GetAllocatedString(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [size_is][size_is][out] __RPC__deref_out_ecount_full_opt(( *pcchLength + 1 ) ) */ out IntPtr ppwszValue, /* [out] __RPC__out */ out uint pcchLength);
        
        [PreserveSig]
        new HRESULT GetBlobSize(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [out] __RPC__out */ out uint pcbBlobSize);
        
        [PreserveSig]
        new HRESULT GetBlob(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [size_is][out] __RPC__out_ecount_full(cbBufSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pBuf, uint cbBufSize, /* [full][out][in] __RPC__inout_opt */ ref uint pcbBlobSize);
        
        [PreserveSig]
        new HRESULT GetAllocatedBlob(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [size_is][size_is][out] __RPC__deref_out_ecount_full_opt(*pcbSize) */ out byte[] ppBuf, /* [out] __RPC__out */ out uint pcbSize);
        
        [PreserveSig]
        new HRESULT GetUnknown(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [PreserveSig]
        new HRESULT SetItem(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* __RPC__in */ PropVariant Value);
        
        [PreserveSig]
        new HRESULT DeleteItem(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey);
        
        [PreserveSig]
        new HRESULT DeleteAllItems();
        
        [PreserveSig]
        new HRESULT SetUINT32(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, uint unValue);
        
        [PreserveSig]
        new HRESULT SetUINT64(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, ulong unValue);
        
        [PreserveSig]
        new HRESULT SetDouble(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, double fValue);
        
        [PreserveSig]
        new HRESULT SetGUID(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidValue);
        
        [PreserveSig]
        new HRESULT SetString(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPWStr)] string wszValue);
        
        [PreserveSig]
        new HRESULT SetBlob(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [size_is][in] __RPC__in_ecount_full(cbBufSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pBuf, uint cbBufSize);
        
        [PreserveSig]
        new HRESULT SetUnknown(/* __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, /* [in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object pUnknown);
        
        [PreserveSig]
        new HRESULT LockStore();
        
        [PreserveSig]
        new HRESULT UnlockStore();
        
        [PreserveSig]
        new HRESULT GetCount(/* [out] __RPC__out */ out uint pcItems);
        
        [PreserveSig]
        new HRESULT GetItemByIndex(uint unIndex, /* [out] __RPC__out */ out Guid pguidKey, /* [full][out][in] __RPC__inout_opt */ PropVariant pValue);
        
        [PreserveSig]
        new HRESULT CopyAllItems(/* [in] __RPC__in_opt */ IMFAttributes pDest);
        
        // IMFTopology
        [PreserveSig]
        HRESULT GetTopologyID(/* [out] __RPC__out */ out ulong pID);
        
        [PreserveSig]
        HRESULT AddNode(/* [in] */ IMFTopologyNode pNode);
        
        [PreserveSig]
        HRESULT RemoveNode(/* [in] */ IMFTopologyNode pNode);
        
        [PreserveSig]
        HRESULT GetNodeCount(/* [out] __RPC__out */ out ushort pwNodes);
        
        [PreserveSig]
        HRESULT GetNode(/* [in] */ ushort wIndex, /* [out] __RPC__deref_out_opt */ out IMFTopologyNode ppNode);
        
        [PreserveSig]
        HRESULT Clear();
        
        [PreserveSig]
        HRESULT CloneFrom(/* [in] __RPC__in_opt */ IMFTopology pTopology);
        
        [PreserveSig]
        HRESULT GetNodeByID(/* [in] */ ulong qwTopoNodeID, /* [out] __RPC__deref_out_opt */ out IMFTopologyNode ppNode);
        
        [PreserveSig]
        HRESULT GetSourceNodeCollection(/* [out] __RPC__deref_out_opt */ out IMFCollection ppCollection);
        
        [PreserveSig]
        HRESULT GetOutputNodeCollection(/* [out] __RPC__deref_out_opt */ out IMFCollection ppCollection);
    }
}
