﻿// generated from <Windows SDK Path>\um\d3d12sdklayers.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_INFO_QUEUE_FILTER_DESC
    {
        public uint NumCategories;
        public IntPtr pCategoryList;
        public uint NumSeverities;
        public IntPtr pSeverityList;
        public uint NumIDs;
        public IntPtr pIDList;
    }
}
