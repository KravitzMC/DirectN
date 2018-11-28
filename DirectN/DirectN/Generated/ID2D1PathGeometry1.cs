﻿using System;
using System.Runtime.InteropServices;
using D2D1_MATRIX_3X2_F = DirectN.D2D_MATRIX_3X2_F;
using D2D1_POINT_2F = DirectN.D2D_POINT_2F;
using D2D1_RECT_F = DirectN.D2D_RECT_F;

namespace DirectN
{
    [Guid("62baa2d2-ab54-41b7-b872-787e0106a421"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1PathGeometry1 : ID2D1PathGeometry
    {
        // ID2D1Geometry
        [PreserveSig]
        new HRESULT GetBounds(ref D2D1_MATRIX_3X2_F worldTransform, ref D2D1_RECT_F bounds);

        [PreserveSig]
        new HRESULT GetWidenedBounds(float strokeWidth, ID2D1StrokeStyle strokeStyle, ref D2D1_MATRIX_3X2_F worldTransform, float flatteningTolerance, ref D2D1_RECT_F bounds);

        [PreserveSig]
        new HRESULT StrokeContainsPoint(D2D1_POINT_2F point, float strokeWidth, ID2D1StrokeStyle strokeStyle, ref D2D1_MATRIX_3X2_F worldTransform, float flatteningTolerance, out bool contains);

        [PreserveSig]
        new HRESULT FillContainsPoint(D2D1_POINT_2F point, ref D2D1_MATRIX_3X2_F worldTransform, float flatteningTolerance, out bool contains);

        [PreserveSig]
        new HRESULT CompareWithGeometry(ID2D1Geometry inputGeometry, ref D2D1_MATRIX_3X2_F inputGeometryTransform, float flatteningTolerance, out D2D1_GEOMETRY_RELATION relation);

        [PreserveSig]
        new HRESULT Simplify(D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption, ref D2D1_MATRIX_3X2_F worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink geometrySink);

        [PreserveSig]
        new HRESULT Tessellate(ref D2D1_MATRIX_3X2_F worldTransform, float flatteningTolerance, ID2D1TessellationSink tessellationSink);

        [PreserveSig]
        new HRESULT CombineWithGeometry(ID2D1Geometry inputGeometry, D2D1_COMBINE_MODE combineMode, ref D2D1_MATRIX_3X2_F inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink geometrySink);

        [PreserveSig]
        new HRESULT Outline(ref D2D1_MATRIX_3X2_F worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink geometrySink);

        [PreserveSig]
        new HRESULT ComputeArea(ref D2D1_MATRIX_3X2_F worldTransform, float flatteningTolerance, out float area);

        [PreserveSig]
        new HRESULT ComputeLength(ref D2D1_MATRIX_3X2_F worldTransform, float flatteningTolerance, out float length);

        [PreserveSig]
        new HRESULT ComputePointAtLength(float length, ref D2D1_MATRIX_3X2_F worldTransform, float flatteningTolerance, ref D2D1_POINT_2F point, ref D2D1_POINT_2F unitTangentVector);

        [PreserveSig]
        new HRESULT Widen(float strokeWidth, ID2D1StrokeStyle strokeStyle, ref D2D1_MATRIX_3X2_F worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink geometrySink);

        // ID2D1PathGeometry
        [PreserveSig]
        new HRESULT Open(out ID2D1GeometrySink geometrySink);

        [PreserveSig]
        new HRESULT Stream(ID2D1GeometrySink geometrySink);

        [PreserveSig]
        new HRESULT GetSegmentCount(out int count);

        [PreserveSig]
        new HRESULT GetFigureCount(out int count);

        // ID2D1PathGeometry1
        [PreserveSig]
        HRESULT ComputePointAndSegmentAtLength(
            float length,
            int startSegment,
            ref D2D1_MATRIX_3X2_F worldTransform,
            float flatteningTolerance,
            out D2D1_POINT_DESCRIPTION pointDescription
            );
    }
}