﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(1766,1)
using System;

namespace DirectN
{
    [Flags]
    public enum PROPDESC_VIEW_FLAGS
    {
        PDVF_DEFAULT = 0x00000000,
        PDVF_CENTERALIGN = 0x00000001,
        PDVF_RIGHTALIGN = 0x00000002,
        PDVF_BEGINNEWGROUP = 0x00000004,
        PDVF_FILLAREA = 0x00000008,
        PDVF_SORTDESCENDING = 0x00000010,
        PDVF_SHOWONLYIFPRESENT = 0x00000020,
        PDVF_SHOWBYDEFAULT = 0x00000040,
        PDVF_SHOWINPRIMARYLIST = 0x00000080,
        PDVF_SHOWINSECONDARYLIST = 0x00000100,
        PDVF_HIDELABEL = 0x00000200,
        PDVF_HIDDEN = 0x00000800,
        PDVF_CANWRAP = 0x00001000,
        PDVF_MASK_ALL = 0x00001BFF,
    }
}
