﻿// generated from <Windows SDK Path>\um\dwrite.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Association of text and its writing system script as well as some display attributes.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_SCRIPT_ANALYSIS
    {
        /// <summary>
        /// Zero-based index representation of writing system script.
        /// </summary>
        public ushort script;
        /// <summary>
        /// Additional shaping requirement of text.
        /// </summary>
        public DWRITE_SCRIPT_SHAPES shapes;
    }
}
