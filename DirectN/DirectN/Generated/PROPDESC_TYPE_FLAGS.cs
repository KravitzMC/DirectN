﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(1744,1)
using System;

namespace DirectN
{
    [Flags]
    public enum PROPDESC_TYPE_FLAGS
    {
        PDTF_DEFAULT = 0x00000000,
        PDTF_MULTIPLEVALUES = 0x00000001,
        PDTF_ISINNATE = 0x00000002,
        PDTF_ISGROUP = 0x00000004,
        PDTF_CANGROUPBY = 0x00000008,
        PDTF_CANSTACKBY = 0x00000010,
        PDTF_ISTREEPROPERTY = 0x00000020,
        PDTF_INCLUDEINFULLTEXTQUERY = 0x00000040,
        PDTF_ISVIEWABLE = 0x00000080,
        PDTF_ISQUERYABLE = 0x00000100,
        PDTF_CANBEPURGED = 0x00000200,
        PDTF_SEARCHRAWVALUE = 0x00000400,
        PDTF_DONTCOERCEEMPTYSTRINGS = 0x00000800,
        PDTF_ALWAYSINSUPPLEMENTALSTORE = 0x00001000,
        PDTF_ISSYSTEMPROPERTY = unchecked((int)0x80000000),
        PDTF_MASK_ALL = unchecked((int)0x80001FFF),
    }
}
