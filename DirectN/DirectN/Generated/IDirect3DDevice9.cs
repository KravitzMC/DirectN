﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d9helper.h(136,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d0223b96-bf7a-43fd-92bd-a43b0d82b9eb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DDevice9
    {
        [PreserveSig]
        HRESULT TestCooperativeLevel();
        
        [PreserveSig]
        uint GetAvailableTextureMem();
        
        [PreserveSig]
        HRESULT EvictManagedResources();
        
        [PreserveSig]
        HRESULT GetDirect3D(ref IDirect3D9 ppD3D9);
        
        [PreserveSig]
        HRESULT GetDeviceCaps(ref _D3DCAPS9 pCaps);
        
        [PreserveSig]
        HRESULT GetDisplayMode(uint iSwapChain, ref _D3DDISPLAYMODE pMode);
        
        [PreserveSig]
        HRESULT GetCreationParameters(ref _D3DDEVICE_CREATION_PARAMETERS pParameters);
        
        [PreserveSig]
        HRESULT SetCursorProperties(uint XHotSpot, uint YHotSpot, ref IDirect3DSurface9 pCursorBitmap);
        
        [PreserveSig]
        void SetCursorPosition(int X, int Y, uint Flags);
        
        [PreserveSig]
        bool ShowCursor(bool bShow);
        
        [PreserveSig]
        HRESULT CreateAdditionalSwapChain(ref _D3DPRESENT_PARAMETERS_ pPresentationParameters, ref IDirect3DSwapChain9 pSwapChain);
        
        [PreserveSig]
        HRESULT GetSwapChain(uint iSwapChain, ref IDirect3DSwapChain9 pSwapChain);
        
        [PreserveSig]
        uint GetNumberOfSwapChains();
        
        [PreserveSig]
        HRESULT Reset(ref _D3DPRESENT_PARAMETERS_ pPresentationParameters);
        
        [PreserveSig]
        HRESULT Present(ref tagRECT pSourceRect, ref tagRECT pDestRect, ref IntPtr hDestWindowOverride, ref _RGNDATA pDirtyRegion);
        
        [PreserveSig]
        HRESULT GetBackBuffer(uint iSwapChain, uint iBackBuffer, _D3DBACKBUFFER_TYPE Type, ref IDirect3DSurface9 ppBackBuffer);
        
        [PreserveSig]
        HRESULT GetRasterStatus(uint iSwapChain, ref _D3DRASTER_STATUS pRasterStatus);
        
        [PreserveSig]
        HRESULT SetDialogBoxMode(bool bEnableDialogs);
        
        [PreserveSig]
        void SetGammaRamp(uint iSwapChain, uint Flags, ref _D3DGAMMARAMP pRamp);
        
        [PreserveSig]
        void GetGammaRamp(uint iSwapChain, ref _D3DGAMMARAMP pRamp);
        
        [PreserveSig]
        HRESULT CreateTexture(uint Width, uint Height, uint Levels, uint Usage, _D3DFORMAT Format, _D3DPOOL Pool, ref IDirect3DTexture9 ppTexture, ref IntPtr pSharedHandle);
        
        [PreserveSig]
        HRESULT CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, uint Usage, _D3DFORMAT Format, _D3DPOOL Pool, ref IDirect3DVolumeTexture9 ppVolumeTexture, ref IntPtr pSharedHandle);
        
        [PreserveSig]
        HRESULT CreateCubeTexture(uint EdgeLength, uint Levels, uint Usage, _D3DFORMAT Format, _D3DPOOL Pool, ref IDirect3DCubeTexture9 ppCubeTexture, ref IntPtr pSharedHandle);
        
        [PreserveSig]
        HRESULT CreateVertexBuffer(uint Length, uint Usage, uint FVF, _D3DPOOL Pool, ref IDirect3DVertexBuffer9 ppVertexBuffer, ref IntPtr pSharedHandle);
        
        [PreserveSig]
        HRESULT CreateIndexBuffer(uint Length, uint Usage, _D3DFORMAT Format, _D3DPOOL Pool, ref IDirect3DIndexBuffer9 ppIndexBuffer, ref IntPtr pSharedHandle);
        
        [PreserveSig]
        HRESULT CreateRenderTarget(uint Width, uint Height, _D3DFORMAT Format, _D3DMULTISAMPLE_TYPE MultiSample, uint MultisampleQuality, bool Lockable, ref IDirect3DSurface9 ppSurface, ref IntPtr pSharedHandle);
        
        [PreserveSig]
        HRESULT CreateDepthStencilSurface(uint Width, uint Height, _D3DFORMAT Format, _D3DMULTISAMPLE_TYPE MultiSample, uint MultisampleQuality, bool Discard, ref IDirect3DSurface9 ppSurface, ref IntPtr pSharedHandle);
        
        [PreserveSig]
        HRESULT UpdateSurface(ref IDirect3DSurface9 pSourceSurface, ref tagRECT pSourceRect, ref IDirect3DSurface9 pDestinationSurface, ref tagPOINT pDestPoint);
        
        [PreserveSig]
        HRESULT UpdateTexture(ref IDirect3DBaseTexture9 pSourceTexture, ref IDirect3DBaseTexture9 pDestinationTexture);
        
        [PreserveSig]
        HRESULT GetRenderTargetData(ref IDirect3DSurface9 pRenderTarget, ref IDirect3DSurface9 pDestSurface);
        
        [PreserveSig]
        HRESULT GetFrontBufferData(uint iSwapChain, ref IDirect3DSurface9 pDestSurface);
        
        [PreserveSig]
        HRESULT StretchRect(ref IDirect3DSurface9 pSourceSurface, ref tagRECT pSourceRect, ref IDirect3DSurface9 pDestSurface, ref tagRECT pDestRect, _D3DTEXTUREFILTERTYPE Filter);
        
        [PreserveSig]
        HRESULT ColorFill(ref IDirect3DSurface9 pSurface, ref tagRECT pRect, uint color);
        
        [PreserveSig]
        HRESULT CreateOffscreenPlainSurface(uint Width, uint Height, _D3DFORMAT Format, _D3DPOOL Pool, ref IDirect3DSurface9 ppSurface, ref IntPtr pSharedHandle);
        
        [PreserveSig]
        HRESULT SetRenderTarget(uint RenderTargetIndex, ref IDirect3DSurface9 pRenderTarget);
        
        [PreserveSig]
        HRESULT GetRenderTarget(uint RenderTargetIndex, ref IDirect3DSurface9 ppRenderTarget);
        
        [PreserveSig]
        HRESULT SetDepthStencilSurface(ref IDirect3DSurface9 pNewZStencil);
        
        [PreserveSig]
        HRESULT GetDepthStencilSurface(ref IDirect3DSurface9 ppZStencilSurface);
        
        [PreserveSig]
        HRESULT BeginScene();
        
        [PreserveSig]
        HRESULT EndScene();
        
        [PreserveSig]
        HRESULT Clear(uint Count, ref _D3DRECT pRects, uint Flags, uint Color, float Z, uint Stencil);
        
        [PreserveSig]
        HRESULT SetTransform(_D3DTRANSFORMSTATETYPE State, ref _D3DMATRIX pMatrix);
        
        [PreserveSig]
        HRESULT GetTransform(_D3DTRANSFORMSTATETYPE State, ref _D3DMATRIX pMatrix);
        
        [PreserveSig]
        HRESULT MultiplyTransform(_D3DTRANSFORMSTATETYPE __unnamed_0, ref _D3DMATRIX __unnamed_1);
        
        [PreserveSig]
        HRESULT SetViewport(ref _D3DVIEWPORT9 pViewport);
        
        [PreserveSig]
        HRESULT GetViewport(ref _D3DVIEWPORT9 pViewport);
        
        [PreserveSig]
        HRESULT SetMaterial(ref _D3DMATERIAL9 pMaterial);
        
        [PreserveSig]
        HRESULT GetMaterial(ref _D3DMATERIAL9 pMaterial);
        
        [PreserveSig]
        HRESULT SetLight(uint Index, ref _D3DLIGHT9 __unnamed_1);
        
        [PreserveSig]
        HRESULT GetLight(uint Index, ref _D3DLIGHT9 __unnamed_1);
        
        [PreserveSig]
        HRESULT LightEnable(uint Index, bool Enable);
        
        [PreserveSig]
        HRESULT GetLightEnable(uint Index, ref bool pEnable);
        
        [PreserveSig]
        HRESULT SetClipPlane(uint Index, ref float pPlane);
        
        [PreserveSig]
        HRESULT GetClipPlane(uint Index, ref float pPlane);
        
        [PreserveSig]
        HRESULT SetRenderState(_D3DRENDERSTATETYPE State, uint Value);
        
        [PreserveSig]
        HRESULT GetRenderState(_D3DRENDERSTATETYPE State, ref uint pValue);
        
        [PreserveSig]
        HRESULT CreateStateBlock(_D3DSTATEBLOCKTYPE Type, ref IDirect3DStateBlock9 ppSB);
        
        [PreserveSig]
        HRESULT BeginStateBlock();
        
        [PreserveSig]
        HRESULT EndStateBlock(ref IDirect3DStateBlock9 ppSB);
        
        [PreserveSig]
        HRESULT SetClipStatus(ref _D3DCLIPSTATUS9 pClipStatus);
        
        [PreserveSig]
        HRESULT GetClipStatus(ref _D3DCLIPSTATUS9 pClipStatus);
        
        [PreserveSig]
        HRESULT GetTexture(uint Stage, ref IDirect3DBaseTexture9 ppTexture);
        
        [PreserveSig]
        HRESULT SetTexture(uint Stage, ref IDirect3DBaseTexture9 pTexture);
        
        [PreserveSig]
        HRESULT GetTextureStageState(uint Stage, _D3DTEXTURESTAGESTATETYPE Type, ref uint pValue);
        
        [PreserveSig]
        HRESULT SetTextureStageState(uint Stage, _D3DTEXTURESTAGESTATETYPE Type, uint Value);
        
        [PreserveSig]
        HRESULT GetSamplerState(uint Sampler, _D3DSAMPLERSTATETYPE Type, ref uint pValue);
        
        [PreserveSig]
        HRESULT SetSamplerState(uint Sampler, _D3DSAMPLERSTATETYPE Type, uint Value);
        
        [PreserveSig]
        HRESULT ValidateDevice(ref uint pNumPasses);
        
        [PreserveSig]
        HRESULT SetPaletteEntries(uint PaletteNumber, ref tagPALETTEENTRY pEntries);
        
        [PreserveSig]
        HRESULT GetPaletteEntries(uint PaletteNumber, ref tagPALETTEENTRY pEntries);
        
        [PreserveSig]
        HRESULT SetCurrentTexturePalette(uint PaletteNumber);
        
        [PreserveSig]
        HRESULT GetCurrentTexturePalette(ref uint PaletteNumber);
        
        [PreserveSig]
        HRESULT SetScissorRect(ref tagRECT pRect);
        
        [PreserveSig]
        HRESULT GetScissorRect(ref tagRECT pRect);
        
        [PreserveSig]
        HRESULT SetSoftwareVertexProcessing(bool bSoftware);
        
        [PreserveSig]
        bool GetSoftwareVertexProcessing();
        
        [PreserveSig]
        HRESULT SetNPatchMode(float nSegments);
        
        [PreserveSig]
        void GetNPatchMode();
        
        [PreserveSig]
        HRESULT DrawPrimitive(_D3DPRIMITIVETYPE PrimitiveType, uint StartVertex, uint PrimitiveCount);
        
        [PreserveSig]
        HRESULT DrawIndexedPrimitive(_D3DPRIMITIVETYPE __unnamed_0, int BaseVertexIndex, uint MinVertexIndex, uint NumVertices, uint startIndex, uint primCount);
        
        [PreserveSig]
        HRESULT DrawPrimitiveUP(_D3DPRIMITIVETYPE PrimitiveType, uint PrimitiveCount, IntPtr pVertexStreamZeroData, uint VertexStreamZeroStride);
        
        [PreserveSig]
        HRESULT DrawIndexedPrimitiveUP(_D3DPRIMITIVETYPE PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, IntPtr pIndexData, _D3DFORMAT IndexDataFormat, IntPtr pVertexStreamZeroData, uint VertexStreamZeroStride);
        
        [PreserveSig]
        HRESULT ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, ref IDirect3DVertexBuffer9 pDestBuffer, ref IDirect3DVertexDeclaration9 pVertexDecl, uint Flags);
        
        [PreserveSig]
        HRESULT CreateVertexDeclaration(ref _D3DVERTEXELEMENT9 pVertexElements, ref IDirect3DVertexDeclaration9 ppDecl);
        
        [PreserveSig]
        HRESULT SetVertexDeclaration(ref IDirect3DVertexDeclaration9 pDecl);
        
        [PreserveSig]
        HRESULT GetVertexDeclaration(ref IDirect3DVertexDeclaration9 ppDecl);
        
        [PreserveSig]
        HRESULT SetFVF(uint FVF);
        
        [PreserveSig]
        HRESULT GetFVF(ref uint pFVF);
        
        [PreserveSig]
        HRESULT CreateVertexShader(ref uint pFunction, ref IDirect3DVertexShader9 ppShader);
        
        [PreserveSig]
        HRESULT SetVertexShader(ref IDirect3DVertexShader9 pShader);
        
        [PreserveSig]
        HRESULT GetVertexShader(ref IDirect3DVertexShader9 ppShader);
        
        [PreserveSig]
        HRESULT SetVertexShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount);
        
        [PreserveSig]
        HRESULT GetVertexShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount);
        
        [PreserveSig]
        HRESULT SetVertexShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount);
        
        [PreserveSig]
        HRESULT GetVertexShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount);
        
        [PreserveSig]
        HRESULT SetVertexShaderConstantB(uint StartRegister, ref bool pConstantData, uint BoolCount);
        
        [PreserveSig]
        HRESULT GetVertexShaderConstantB(uint StartRegister, ref bool pConstantData, uint BoolCount);
        
        [PreserveSig]
        HRESULT SetStreamSource(uint StreamNumber, ref IDirect3DVertexBuffer9 pStreamData, uint OffsetInBytes, uint Stride);
        
        [PreserveSig]
        HRESULT GetStreamSource(uint StreamNumber, ref IDirect3DVertexBuffer9 ppStreamData, ref uint OffsetInBytes, ref uint pStride);
        
        [PreserveSig]
        HRESULT SetStreamSourceFreq(uint StreamNumber, uint Divider);
        
        [PreserveSig]
        HRESULT GetStreamSourceFreq(uint StreamNumber, ref uint Divider);
        
        [PreserveSig]
        HRESULT SetIndices(ref IDirect3DIndexBuffer9 pIndexData);
        
        [PreserveSig]
        HRESULT GetIndices(ref IDirect3DIndexBuffer9 ppIndexData);
        
        [PreserveSig]
        HRESULT CreatePixelShader(ref uint pFunction, ref IDirect3DPixelShader9 ppShader);
        
        [PreserveSig]
        HRESULT SetPixelShader(ref IDirect3DPixelShader9 pShader);
        
        [PreserveSig]
        HRESULT GetPixelShader(ref IDirect3DPixelShader9 ppShader);
        
        [PreserveSig]
        HRESULT SetPixelShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount);
        
        [PreserveSig]
        HRESULT GetPixelShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount);
        
        [PreserveSig]
        HRESULT SetPixelShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount);
        
        [PreserveSig]
        HRESULT GetPixelShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount);
        
        [PreserveSig]
        HRESULT SetPixelShaderConstantB(uint StartRegister, ref bool pConstantData, uint BoolCount);
        
        [PreserveSig]
        HRESULT GetPixelShaderConstantB(uint StartRegister, ref bool pConstantData, uint BoolCount);
        
        [PreserveSig]
        HRESULT DrawRectPatch(uint Handle, ref float pNumSegs, ref _D3DRECTPATCH_INFO pRectPatchInfo);
        
        [PreserveSig]
        HRESULT DrawTriPatch(uint Handle, ref float pNumSegs, ref _D3DTRIPATCH_INFO pTriPatchInfo);
        
        [PreserveSig]
        HRESULT DeletePatch(uint Handle);
        
        [PreserveSig]
        HRESULT CreateQuery(_D3DQUERYTYPE Type, ref IDirect3DQuery9 ppQuery);
    }
}
