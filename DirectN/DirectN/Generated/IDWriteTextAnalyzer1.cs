﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_1.h(1422,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Analyzes various text properties for complex script processing.
    /// </summary>
    [Guid("80dad800-e21f-4e83-96ce-bfcce500db7c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextAnalyzer1
    {
        [PreserveSig]
        HRESULT ApplyCharacterSpacing(float leadingSpacing, float trailingSpacing, float minimumAdvanceWidth, uint textLength, uint glyphCount, /* _In_reads_(textLength) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ushort[] clusterMap, /* _In_reads_(glyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] float[] glyphAdvances, /* _In_reads_(glyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] DWRITE_GLYPH_OFFSET[] glyphOffsets, /* _In_reads_(glyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] DWRITE_SHAPING_GLYPH_PROPERTIES[] glyphProperties, /* _Out_writes_(glyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] float[] modifiedGlyphAdvances, /* _Out_writes_(glyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] DWRITE_GLYPH_OFFSET[] modifiedGlyphOffsets);
        
        [PreserveSig]
        HRESULT GetBaseline(/* _In_ */ ref IDWriteFontFace fontFace, DWRITE_BASELINE baseline, bool isVertical, bool isSimulationAllowed, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, /* _In_opt_z_ */ ref char localeName, /* _Out_ */ out int baselineCoordinate, /* _Out_ */ out bool exists);
        
        [PreserveSig]
        HRESULT AnalyzeVerticalGlyphOrientation(/* _In_ */ IDWriteTextAnalysisSource1 analysisSource, uint textPosition, uint textLength, /* _In_ */ IDWriteTextAnalysisSink1 analysisSink);
        
        [PreserveSig]
        HRESULT GetGlyphOrientationTransform(DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, bool isSideways, /* _Out_ */ out DWRITE_MATRIX transform);
        
        [PreserveSig]
        HRESULT GetScriptProperties(DWRITE_SCRIPT_ANALYSIS scriptAnalysis, /* _Out_ */ out DWRITE_SCRIPT_PROPERTIES scriptProperties);
        
        [PreserveSig]
        HRESULT GetTextComplexity(/* _In_reads_(textLength) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] char[] textString, uint textLength, /* _In_ */ ref IDWriteFontFace fontFace, /* _Out_ */ out bool isTextSimple, /* _Out_range_(0, textLength) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] uint[] textLengthRead, /* _Out_writes_to_opt_(textLength, *textLengthRead) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ushort[] glyphIndices);
        
        [PreserveSig]
        HRESULT GetJustificationOpportunities(/* _In_opt_ */ ref IDWriteFontFace fontFace, float fontEmSize, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, uint textLength, uint glyphCount, /* _In_reads_(textLength) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] char[] textString, /* _In_reads_(textLength) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ushort[] clusterMap, /* _In_reads_(glyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] DWRITE_SHAPING_GLYPH_PROPERTIES[] glyphProperties, /* _Out_writes_(glyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] DWRITE_JUSTIFICATION_OPPORTUNITY[] justificationOpportunities);
        
        [PreserveSig]
        HRESULT JustifyGlyphAdvances(float lineWidth, uint glyphCount, /* _In_reads_(glyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_JUSTIFICATION_OPPORTUNITY[] justificationOpportunities, /* _In_reads_(glyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] float[] glyphAdvances, /* _In_reads_(glyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_GLYPH_OFFSET[] glyphOffsets, /* _Out_writes_(glyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] float[] justifiedGlyphAdvances, /* _Out_writes_opt_(glyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_GLYPH_OFFSET[] justifiedGlyphOffsets);
        
        [PreserveSig]
        HRESULT GetJustifiedGlyphs(/* _In_opt_ */ ref IDWriteFontFace fontFace, float fontEmSize, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, uint textLength, uint glyphCount, uint maxGlyphCount, /* _In_reads_opt_(textLength) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ushort[] clusterMap, /* _In_reads_(glyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] ushort[] glyphIndices, /* _In_reads_(glyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] float[] glyphAdvances, /* _In_reads_(glyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] float[] justifiedGlyphAdvances, /* _In_reads_(glyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] DWRITE_GLYPH_OFFSET[] justifiedGlyphOffsets, /* _In_reads_(glyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] DWRITE_SHAPING_GLYPH_PROPERTIES[] glyphProperties, /* _Out_range_(glyphCount, maxGlyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] uint[] actualGlyphCount, /* _Out_writes_opt_(textLength) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ushort[] modifiedClusterMap, /* _Out_writes_to_(maxGlyphCount, *actualGlyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] ushort[] modifiedGlyphIndices, /* _Out_writes_to_(maxGlyphCount, *actualGlyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] float[] modifiedGlyphAdvances, /* _Out_writes_to_(maxGlyphCount, *actualGlyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] DWRITE_GLYPH_OFFSET[] modifiedGlyphOffsets);
    }
}
