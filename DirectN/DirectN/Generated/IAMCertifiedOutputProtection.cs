﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(17460,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("6feded3e-0ff1-4901-a2f1-43f7012c8515"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMCertifiedOutputProtection
    {
        [PreserveSig]
        HRESULT KeyExchange(/* [annotation][out] _Out_ */ out Guid pRandom, /* [annotation][out] _Outptr_result_bytebuffer_(*pdwLengthCertGH) */ out byte[] VarLenCertGH, /* [annotation][out] _Out_ */ out uint pdwLengthCertGH);
        
        [PreserveSig]
        HRESULT SessionSequenceStart(/* [in] */ ref _AMCOPPSignature pSig);
        
        [PreserveSig]
        HRESULT ProtectionCommand(/* [in] */ ref _AMCOPPCommand cmd);
        
        [PreserveSig]
        HRESULT ProtectionStatus(/* [in] */ ref _AMCOPPStatusInput pStatusInput, /* [annotation][out] _Out_ */ out _AMCOPPStatusOutput pStatusOutput);
    }
}
