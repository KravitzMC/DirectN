﻿// generated from <Windows SDK Path>\um\d3d10sdklayers.h
namespace DirectN
{
    public enum D3D10_MESSAGE_ID
    {
        D3D10_MESSAGE_ID_UNKNOWN = 0,
        D3D10_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_HAZARD = 1,
        D3D10_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_HAZARD = 2,
        D3D10_MESSAGE_ID_DEVICE_VSSETSHADERRESOURCES_HAZARD = 3,
        D3D10_MESSAGE_ID_DEVICE_VSSETCONSTANTBUFFERS_HAZARD = 4,
        D3D10_MESSAGE_ID_DEVICE_GSSETSHADERRESOURCES_HAZARD = 5,
        D3D10_MESSAGE_ID_DEVICE_GSSETCONSTANTBUFFERS_HAZARD = 6,
        D3D10_MESSAGE_ID_DEVICE_PSSETSHADERRESOURCES_HAZARD = 7,
        D3D10_MESSAGE_ID_DEVICE_PSSETCONSTANTBUFFERS_HAZARD = 8,
        D3D10_MESSAGE_ID_DEVICE_OMSETRENDERTARGETS_HAZARD = 9,
        D3D10_MESSAGE_ID_DEVICE_SOSETTARGETS_HAZARD = 10,
        D3D10_MESSAGE_ID_STRING_FROM_APPLICATION = 11,
        D3D10_MESSAGE_ID_CORRUPTED_THIS = 12,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER1 = 13,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER2 = 14,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER3 = 15,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER4 = 16,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER5 = 17,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER6 = 18,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER7 = 19,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER8 = 20,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER9 = 21,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER10 = 22,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER11 = 23,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER12 = 24,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER13 = 25,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER14 = 26,
        D3D10_MESSAGE_ID_CORRUPTED_PARAMETER15 = 27,
        D3D10_MESSAGE_ID_CORRUPTED_MULTITHREADING = 28,
        D3D10_MESSAGE_ID_MESSAGE_REPORTING_OUTOFMEMORY = 29,
        D3D10_MESSAGE_ID_IASETINPUTLAYOUT_UNBINDDELETINGOBJECT = 30,
        D3D10_MESSAGE_ID_IASETVERTEXBUFFERS_UNBINDDELETINGOBJECT = 31,
        D3D10_MESSAGE_ID_IASETINDEXBUFFER_UNBINDDELETINGOBJECT = 32,
        D3D10_MESSAGE_ID_VSSETSHADER_UNBINDDELETINGOBJECT = 33,
        D3D10_MESSAGE_ID_VSSETSHADERRESOURCES_UNBINDDELETINGOBJECT = 34,
        D3D10_MESSAGE_ID_VSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT = 35,
        D3D10_MESSAGE_ID_VSSETSAMPLERS_UNBINDDELETINGOBJECT = 36,
        D3D10_MESSAGE_ID_GSSETSHADER_UNBINDDELETINGOBJECT = 37,
        D3D10_MESSAGE_ID_GSSETSHADERRESOURCES_UNBINDDELETINGOBJECT = 38,
        D3D10_MESSAGE_ID_GSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT = 39,
        D3D10_MESSAGE_ID_GSSETSAMPLERS_UNBINDDELETINGOBJECT = 40,
        D3D10_MESSAGE_ID_SOSETTARGETS_UNBINDDELETINGOBJECT = 41,
        D3D10_MESSAGE_ID_PSSETSHADER_UNBINDDELETINGOBJECT = 42,
        D3D10_MESSAGE_ID_PSSETSHADERRESOURCES_UNBINDDELETINGOBJECT = 43,
        D3D10_MESSAGE_ID_PSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT = 44,
        D3D10_MESSAGE_ID_PSSETSAMPLERS_UNBINDDELETINGOBJECT = 45,
        D3D10_MESSAGE_ID_RSSETSTATE_UNBINDDELETINGOBJECT = 46,
        D3D10_MESSAGE_ID_OMSETBLENDSTATE_UNBINDDELETINGOBJECT = 47,
        D3D10_MESSAGE_ID_OMSETDEPTHSTENCILSTATE_UNBINDDELETINGOBJECT = 48,
        D3D10_MESSAGE_ID_OMSETRENDERTARGETS_UNBINDDELETINGOBJECT = 49,
        D3D10_MESSAGE_ID_SETPREDICATION_UNBINDDELETINGOBJECT = 50,
        D3D10_MESSAGE_ID_GETPRIVATEDATA_MOREDATA = 51,
        D3D10_MESSAGE_ID_SETPRIVATEDATA_INVALIDFREEDATA = 52,
        D3D10_MESSAGE_ID_SETPRIVATEDATA_INVALIDIUNKNOWN = 53,
        D3D10_MESSAGE_ID_SETPRIVATEDATA_INVALIDFLAGS = 54,
        D3D10_MESSAGE_ID_SETPRIVATEDATA_CHANGINGPARAMS = 55,
        D3D10_MESSAGE_ID_SETPRIVATEDATA_OUTOFMEMORY = 56,
        D3D10_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDFORMAT = 57,
        D3D10_MESSAGE_ID_CREATEBUFFER_INVALIDSAMPLES = 58,
        D3D10_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDUSAGE = 59,
        D3D10_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDBINDFLAGS = 60,
        D3D10_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDCPUACCESSFLAGS = 61,
        D3D10_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDMISCFLAGS = 62,
        D3D10_MESSAGE_ID_CREATEBUFFER_INVALIDCPUACCESSFLAGS = 63,
        D3D10_MESSAGE_ID_CREATEBUFFER_INVALIDBINDFLAGS = 64,
        D3D10_MESSAGE_ID_CREATEBUFFER_INVALIDINITIALDATA = 65,
        D3D10_MESSAGE_ID_CREATEBUFFER_INVALIDDIMENSIONS = 66,
        D3D10_MESSAGE_ID_CREATEBUFFER_INVALIDMIPLEVELS = 67,
        D3D10_MESSAGE_ID_CREATEBUFFER_INVALIDMISCFLAGS = 68,
        D3D10_MESSAGE_ID_CREATEBUFFER_INVALIDARG_RETURN = 69,
        D3D10_MESSAGE_ID_CREATEBUFFER_OUTOFMEMORY_RETURN = 70,
        D3D10_MESSAGE_ID_CREATEBUFFER_NULLDESC = 71,
        D3D10_MESSAGE_ID_CREATEBUFFER_INVALIDCONSTANTBUFFERBINDINGS = 72,
        D3D10_MESSAGE_ID_CREATEBUFFER_LARGEALLOCATION = 73,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDFORMAT = 74,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_UNSUPPORTEDFORMAT = 75,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_INVALIDSAMPLES = 76,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDUSAGE = 77,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDBINDFLAGS = 78,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDCPUACCESSFLAGS = 79,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDMISCFLAGS = 80,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_INVALIDCPUACCESSFLAGS = 81,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_INVALIDBINDFLAGS = 82,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_INVALIDINITIALDATA = 83,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_INVALIDDIMENSIONS = 84,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_INVALIDMIPLEVELS = 85,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_INVALIDMISCFLAGS = 86,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_INVALIDARG_RETURN = 87,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_OUTOFMEMORY_RETURN = 88,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_NULLDESC = 89,
        D3D10_MESSAGE_ID_CREATETEXTURE1D_LARGEALLOCATION = 90,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDFORMAT = 91,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_UNSUPPORTEDFORMAT = 92,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_INVALIDSAMPLES = 93,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDUSAGE = 94,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDBINDFLAGS = 95,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDCPUACCESSFLAGS = 96,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDMISCFLAGS = 97,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_INVALIDCPUACCESSFLAGS = 98,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_INVALIDBINDFLAGS = 99,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_INVALIDINITIALDATA = 100,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_INVALIDDIMENSIONS = 101,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_INVALIDMIPLEVELS = 102,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_INVALIDMISCFLAGS = 103,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_INVALIDARG_RETURN = 104,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_OUTOFMEMORY_RETURN = 105,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_NULLDESC = 106,
        D3D10_MESSAGE_ID_CREATETEXTURE2D_LARGEALLOCATION = 107,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDFORMAT = 108,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_UNSUPPORTEDFORMAT = 109,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_INVALIDSAMPLES = 110,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDUSAGE = 111,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDBINDFLAGS = 112,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDCPUACCESSFLAGS = 113,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDMISCFLAGS = 114,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_INVALIDCPUACCESSFLAGS = 115,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_INVALIDBINDFLAGS = 116,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_INVALIDINITIALDATA = 117,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_INVALIDDIMENSIONS = 118,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_INVALIDMIPLEVELS = 119,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_INVALIDMISCFLAGS = 120,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_INVALIDARG_RETURN = 121,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_OUTOFMEMORY_RETURN = 122,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_NULLDESC = 123,
        D3D10_MESSAGE_ID_CREATETEXTURE3D_LARGEALLOCATION = 124,
        D3D10_MESSAGE_ID_CREATESHADERRESOURCEVIEW_UNRECOGNIZEDFORMAT = 125,
        D3D10_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDESC = 126,
        D3D10_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDFORMAT = 127,
        D3D10_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDIMENSIONS = 128,
        D3D10_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDRESOURCE = 129,
        D3D10_MESSAGE_ID_CREATESHADERRESOURCEVIEW_TOOMANYOBJECTS = 130,
        D3D10_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDARG_RETURN = 131,
        D3D10_MESSAGE_ID_CREATESHADERRESOURCEVIEW_OUTOFMEMORY_RETURN = 132,
        D3D10_MESSAGE_ID_CREATERENDERTARGETVIEW_UNRECOGNIZEDFORMAT = 133,
        D3D10_MESSAGE_ID_CREATERENDERTARGETVIEW_UNSUPPORTEDFORMAT = 134,
        D3D10_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDESC = 135,
        D3D10_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDFORMAT = 136,
        D3D10_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDIMENSIONS = 137,
        D3D10_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDRESOURCE = 138,
        D3D10_MESSAGE_ID_CREATERENDERTARGETVIEW_TOOMANYOBJECTS = 139,
        D3D10_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDARG_RETURN = 140,
        D3D10_MESSAGE_ID_CREATERENDERTARGETVIEW_OUTOFMEMORY_RETURN = 141,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_UNRECOGNIZEDFORMAT = 142,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDESC = 143,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDFORMAT = 144,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDIMENSIONS = 145,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDRESOURCE = 146,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_TOOMANYOBJECTS = 147,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDARG_RETURN = 148,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_OUTOFMEMORY_RETURN = 149,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_OUTOFMEMORY = 150,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_TOOMANYELEMENTS = 151,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDFORMAT = 152,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_INCOMPATIBLEFORMAT = 153,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOT = 154,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDINPUTSLOTCLASS = 155,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_STEPRATESLOTCLASSMISMATCH = 156,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOTCLASSCHANGE = 157,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSTEPRATECHANGE = 158,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDALIGNMENT = 159,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_DUPLICATESEMANTIC = 160,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_UNPARSEABLEINPUTSIGNATURE = 161,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_NULLSEMANTIC = 162,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_MISSINGELEMENT = 163,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_NULLDESC = 164,
        D3D10_MESSAGE_ID_CREATEVERTEXSHADER_OUTOFMEMORY = 165,
        D3D10_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERBYTECODE = 166,
        D3D10_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERTYPE = 167,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADER_OUTOFMEMORY = 168,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERBYTECODE = 169,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERTYPE = 170,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTOFMEMORY = 171,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERBYTECODE = 172,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERTYPE = 173,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMENTRIES = 174,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSTREAMSTRIDEUNUSED = 175,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDDECL = 176,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_EXPECTEDDECL = 177,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSLOT0EXPECTED = 178,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSLOT = 179,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_ONLYONEELEMENTPERSLOT = 180,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDCOMPONENTCOUNT = 181,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTARTCOMPONENTANDCOMPONENTCOUNT = 182,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDGAPDEFINITION = 183,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_REPEATEDOUTPUT = 184,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSTREAMSTRIDE = 185,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGSEMANTIC = 186,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MASKMISMATCH = 187,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_CANTHAVEONLYGAPS = 188,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DECLTOOCOMPLEX = 189,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGOUTPUTSIGNATURE = 190,
        D3D10_MESSAGE_ID_CREATEPIXELSHADER_OUTOFMEMORY = 191,
        D3D10_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERBYTECODE = 192,
        D3D10_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERTYPE = 193,
        D3D10_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDFILLMODE = 194,
        D3D10_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDCULLMODE = 195,
        D3D10_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDDEPTHBIASCLAMP = 196,
        D3D10_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDSLOPESCALEDDEPTHBIAS = 197,
        D3D10_MESSAGE_ID_CREATERASTERIZERSTATE_TOOMANYOBJECTS = 198,
        D3D10_MESSAGE_ID_CREATERASTERIZERSTATE_NULLDESC = 199,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHWRITEMASK = 200,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHFUNC = 201,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFAILOP = 202,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILZFAILOP = 203,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILPASSOP = 204,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFUNC = 205,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFAILOP = 206,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILZFAILOP = 207,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILPASSOP = 208,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFUNC = 209,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_TOOMANYOBJECTS = 210,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_NULLDESC = 211,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLEND = 212,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLEND = 213,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOP = 214,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLENDALPHA = 215,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLENDALPHA = 216,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOPALPHA = 217,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_INVALIDRENDERTARGETWRITEMASK = 218,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_TOOMANYOBJECTS = 219,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_NULLDESC = 220,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDFILTER = 221,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDADDRESSU = 222,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDADDRESSV = 223,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDADDRESSW = 224,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMIPLODBIAS = 225,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMAXANISOTROPY = 226,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDCOMPARISONFUNC = 227,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMINLOD = 228,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMAXLOD = 229,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_TOOMANYOBJECTS = 230,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_NULLDESC = 231,
        D3D10_MESSAGE_ID_CREATEQUERYORPREDICATE_INVALIDQUERY = 232,
        D3D10_MESSAGE_ID_CREATEQUERYORPREDICATE_INVALIDMISCFLAGS = 233,
        D3D10_MESSAGE_ID_CREATEQUERYORPREDICATE_UNEXPECTEDMISCFLAG = 234,
        D3D10_MESSAGE_ID_CREATEQUERYORPREDICATE_NULLDESC = 235,
        D3D10_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_TOPOLOGY_UNRECOGNIZED = 236,
        D3D10_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_TOPOLOGY_UNDEFINED = 237,
        D3D10_MESSAGE_ID_IASETVERTEXBUFFERS_INVALIDBUFFER = 238,
        D3D10_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_OFFSET_TOO_LARGE = 239,
        D3D10_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_BUFFERS_EMPTY = 240,
        D3D10_MESSAGE_ID_IASETINDEXBUFFER_INVALIDBUFFER = 241,
        D3D10_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_FORMAT_INVALID = 242,
        D3D10_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_OFFSET_TOO_LARGE = 243,
        D3D10_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_OFFSET_UNALIGNED = 244,
        D3D10_MESSAGE_ID_DEVICE_VSSETSHADERRESOURCES_VIEWS_EMPTY = 245,
        D3D10_MESSAGE_ID_VSSETCONSTANTBUFFERS_INVALIDBUFFER = 246,
        D3D10_MESSAGE_ID_DEVICE_VSSETCONSTANTBUFFERS_BUFFERS_EMPTY = 247,
        D3D10_MESSAGE_ID_DEVICE_VSSETSAMPLERS_SAMPLERS_EMPTY = 248,
        D3D10_MESSAGE_ID_DEVICE_GSSETSHADERRESOURCES_VIEWS_EMPTY = 249,
        D3D10_MESSAGE_ID_GSSETCONSTANTBUFFERS_INVALIDBUFFER = 250,
        D3D10_MESSAGE_ID_DEVICE_GSSETCONSTANTBUFFERS_BUFFERS_EMPTY = 251,
        D3D10_MESSAGE_ID_DEVICE_GSSETSAMPLERS_SAMPLERS_EMPTY = 252,
        D3D10_MESSAGE_ID_SOSETTARGETS_INVALIDBUFFER = 253,
        D3D10_MESSAGE_ID_DEVICE_SOSETTARGETS_OFFSET_UNALIGNED = 254,
        D3D10_MESSAGE_ID_DEVICE_PSSETSHADERRESOURCES_VIEWS_EMPTY = 255,
        D3D10_MESSAGE_ID_PSSETCONSTANTBUFFERS_INVALIDBUFFER = 256,
        D3D10_MESSAGE_ID_DEVICE_PSSETCONSTANTBUFFERS_BUFFERS_EMPTY = 257,
        D3D10_MESSAGE_ID_DEVICE_PSSETSAMPLERS_SAMPLERS_EMPTY = 258,
        D3D10_MESSAGE_ID_DEVICE_RSSETVIEWPORTS_INVALIDVIEWPORT = 259,
        D3D10_MESSAGE_ID_DEVICE_RSSETSCISSORRECTS_INVALIDSCISSOR = 260,
        D3D10_MESSAGE_ID_CLEARRENDERTARGETVIEW_DENORMFLUSH = 261,
        D3D10_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_DENORMFLUSH = 262,
        D3D10_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_INVALID = 263,
        D3D10_MESSAGE_ID_DEVICE_IAGETVERTEXBUFFERS_BUFFERS_EMPTY = 264,
        D3D10_MESSAGE_ID_DEVICE_VSGETSHADERRESOURCES_VIEWS_EMPTY = 265,
        D3D10_MESSAGE_ID_DEVICE_VSGETCONSTANTBUFFERS_BUFFERS_EMPTY = 266,
        D3D10_MESSAGE_ID_DEVICE_VSGETSAMPLERS_SAMPLERS_EMPTY = 267,
        D3D10_MESSAGE_ID_DEVICE_GSGETSHADERRESOURCES_VIEWS_EMPTY = 268,
        D3D10_MESSAGE_ID_DEVICE_GSGETCONSTANTBUFFERS_BUFFERS_EMPTY = 269,
        D3D10_MESSAGE_ID_DEVICE_GSGETSAMPLERS_SAMPLERS_EMPTY = 270,
        D3D10_MESSAGE_ID_DEVICE_SOGETTARGETS_BUFFERS_EMPTY = 271,
        D3D10_MESSAGE_ID_DEVICE_PSGETSHADERRESOURCES_VIEWS_EMPTY = 272,
        D3D10_MESSAGE_ID_DEVICE_PSGETCONSTANTBUFFERS_BUFFERS_EMPTY = 273,
        D3D10_MESSAGE_ID_DEVICE_PSGETSAMPLERS_SAMPLERS_EMPTY = 274,
        D3D10_MESSAGE_ID_DEVICE_RSGETVIEWPORTS_VIEWPORTS_EMPTY = 275,
        D3D10_MESSAGE_ID_DEVICE_RSGETSCISSORRECTS_RECTS_EMPTY = 276,
        D3D10_MESSAGE_ID_DEVICE_GENERATEMIPS_RESOURCE_INVALID = 277,
        D3D10_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDDESTINATIONSUBRESOURCE = 278,
        D3D10_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCESUBRESOURCE = 279,
        D3D10_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCEBOX = 280,
        D3D10_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCE = 281,
        D3D10_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDDESTINATIONSTATE = 282,
        D3D10_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCESTATE = 283,
        D3D10_MESSAGE_ID_COPYRESOURCE_INVALIDSOURCE = 284,
        D3D10_MESSAGE_ID_COPYRESOURCE_INVALIDDESTINATIONSTATE = 285,
        D3D10_MESSAGE_ID_COPYRESOURCE_INVALIDSOURCESTATE = 286,
        D3D10_MESSAGE_ID_UPDATESUBRESOURCE_INVALIDDESTINATIONSUBRESOURCE = 287,
        D3D10_MESSAGE_ID_UPDATESUBRESOURCE_INVALIDDESTINATIONBOX = 288,
        D3D10_MESSAGE_ID_UPDATESUBRESOURCE_INVALIDDESTINATIONSTATE = 289,
        D3D10_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_DESTINATION_INVALID = 290,
        D3D10_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_DESTINATION_SUBRESOURCE_INVALID = 291,
        D3D10_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_SOURCE_INVALID = 292,
        D3D10_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_SOURCE_SUBRESOURCE_INVALID = 293,
        D3D10_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_FORMAT_INVALID = 294,
        D3D10_MESSAGE_ID_BUFFER_MAP_INVALIDMAPTYPE = 295,
        D3D10_MESSAGE_ID_BUFFER_MAP_INVALIDFLAGS = 296,
        D3D10_MESSAGE_ID_BUFFER_MAP_ALREADYMAPPED = 297,
        D3D10_MESSAGE_ID_BUFFER_MAP_DEVICEREMOVED_RETURN = 298,
        D3D10_MESSAGE_ID_BUFFER_UNMAP_NOTMAPPED = 299,
        D3D10_MESSAGE_ID_TEXTURE1D_MAP_INVALIDMAPTYPE = 300,
        D3D10_MESSAGE_ID_TEXTURE1D_MAP_INVALIDSUBRESOURCE = 301,
        D3D10_MESSAGE_ID_TEXTURE1D_MAP_INVALIDFLAGS = 302,
        D3D10_MESSAGE_ID_TEXTURE1D_MAP_ALREADYMAPPED = 303,
        D3D10_MESSAGE_ID_TEXTURE1D_MAP_DEVICEREMOVED_RETURN = 304,
        D3D10_MESSAGE_ID_TEXTURE1D_UNMAP_INVALIDSUBRESOURCE = 305,
        D3D10_MESSAGE_ID_TEXTURE1D_UNMAP_NOTMAPPED = 306,
        D3D10_MESSAGE_ID_TEXTURE2D_MAP_INVALIDMAPTYPE = 307,
        D3D10_MESSAGE_ID_TEXTURE2D_MAP_INVALIDSUBRESOURCE = 308,
        D3D10_MESSAGE_ID_TEXTURE2D_MAP_INVALIDFLAGS = 309,
        D3D10_MESSAGE_ID_TEXTURE2D_MAP_ALREADYMAPPED = 310,
        D3D10_MESSAGE_ID_TEXTURE2D_MAP_DEVICEREMOVED_RETURN = 311,
        D3D10_MESSAGE_ID_TEXTURE2D_UNMAP_INVALIDSUBRESOURCE = 312,
        D3D10_MESSAGE_ID_TEXTURE2D_UNMAP_NOTMAPPED = 313,
        D3D10_MESSAGE_ID_TEXTURE3D_MAP_INVALIDMAPTYPE = 314,
        D3D10_MESSAGE_ID_TEXTURE3D_MAP_INVALIDSUBRESOURCE = 315,
        D3D10_MESSAGE_ID_TEXTURE3D_MAP_INVALIDFLAGS = 316,
        D3D10_MESSAGE_ID_TEXTURE3D_MAP_ALREADYMAPPED = 317,
        D3D10_MESSAGE_ID_TEXTURE3D_MAP_DEVICEREMOVED_RETURN = 318,
        D3D10_MESSAGE_ID_TEXTURE3D_UNMAP_INVALIDSUBRESOURCE = 319,
        D3D10_MESSAGE_ID_TEXTURE3D_UNMAP_NOTMAPPED = 320,
        D3D10_MESSAGE_ID_CHECKFORMATSUPPORT_FORMAT_DEPRECATED = 321,
        D3D10_MESSAGE_ID_CHECKMULTISAMPLEQUALITYLEVELS_FORMAT_DEPRECATED = 322,
        D3D10_MESSAGE_ID_SETEXCEPTIONMODE_UNRECOGNIZEDFLAGS = 323,
        D3D10_MESSAGE_ID_SETEXCEPTIONMODE_INVALIDARG_RETURN = 324,
        D3D10_MESSAGE_ID_SETEXCEPTIONMODE_DEVICEREMOVED_RETURN = 325,
        D3D10_MESSAGE_ID_REF_SIMULATING_INFINITELY_FAST_HARDWARE = 326,
        D3D10_MESSAGE_ID_REF_THREADING_MODE = 327,
        D3D10_MESSAGE_ID_REF_UMDRIVER_EXCEPTION = 328,
        D3D10_MESSAGE_ID_REF_KMDRIVER_EXCEPTION = 329,
        D3D10_MESSAGE_ID_REF_HARDWARE_EXCEPTION = 330,
        D3D10_MESSAGE_ID_REF_ACCESSING_INDEXABLE_TEMP_OUT_OF_RANGE = 331,
        D3D10_MESSAGE_ID_REF_PROBLEM_PARSING_SHADER = 332,
        D3D10_MESSAGE_ID_REF_OUT_OF_MEMORY = 333,
        D3D10_MESSAGE_ID_REF_INFO = 334,
        D3D10_MESSAGE_ID_DEVICE_DRAW_VERTEXPOS_OVERFLOW = 335,
        D3D10_MESSAGE_ID_DEVICE_DRAWINDEXED_INDEXPOS_OVERFLOW = 336,
        D3D10_MESSAGE_ID_DEVICE_DRAWINSTANCED_VERTEXPOS_OVERFLOW = 337,
        D3D10_MESSAGE_ID_DEVICE_DRAWINSTANCED_INSTANCEPOS_OVERFLOW = 338,
        D3D10_MESSAGE_ID_DEVICE_DRAWINDEXEDINSTANCED_INSTANCEPOS_OVERFLOW = 339,
        D3D10_MESSAGE_ID_DEVICE_DRAWINDEXEDINSTANCED_INDEXPOS_OVERFLOW = 340,
        D3D10_MESSAGE_ID_DEVICE_DRAW_VERTEX_SHADER_NOT_SET = 341,
        D3D10_MESSAGE_ID_DEVICE_SHADER_LINKAGE_SEMANTICNAME_NOT_FOUND = 342,
        D3D10_MESSAGE_ID_DEVICE_SHADER_LINKAGE_REGISTERINDEX = 343,
        D3D10_MESSAGE_ID_DEVICE_SHADER_LINKAGE_COMPONENTTYPE = 344,
        D3D10_MESSAGE_ID_DEVICE_SHADER_LINKAGE_REGISTERMASK = 345,
        D3D10_MESSAGE_ID_DEVICE_SHADER_LINKAGE_SYSTEMVALUE = 346,
        D3D10_MESSAGE_ID_DEVICE_SHADER_LINKAGE_NEVERWRITTEN_ALWAYSREADS = 347,
        D3D10_MESSAGE_ID_DEVICE_DRAW_VERTEX_BUFFER_NOT_SET = 348,
        D3D10_MESSAGE_ID_DEVICE_DRAW_INPUTLAYOUT_NOT_SET = 349,
        D3D10_MESSAGE_ID_DEVICE_DRAW_CONSTANT_BUFFER_NOT_SET = 350,
        D3D10_MESSAGE_ID_DEVICE_DRAW_CONSTANT_BUFFER_TOO_SMALL = 351,
        D3D10_MESSAGE_ID_DEVICE_DRAW_SAMPLER_NOT_SET = 352,
        D3D10_MESSAGE_ID_DEVICE_DRAW_SHADERRESOURCEVIEW_NOT_SET = 353,
        D3D10_MESSAGE_ID_DEVICE_DRAW_VIEW_DIMENSION_MISMATCH = 354,
        D3D10_MESSAGE_ID_DEVICE_DRAW_VERTEX_BUFFER_STRIDE_TOO_SMALL = 355,
        D3D10_MESSAGE_ID_DEVICE_DRAW_VERTEX_BUFFER_TOO_SMALL = 356,
        D3D10_MESSAGE_ID_DEVICE_DRAW_INDEX_BUFFER_NOT_SET = 357,
        D3D10_MESSAGE_ID_DEVICE_DRAW_INDEX_BUFFER_FORMAT_INVALID = 358,
        D3D10_MESSAGE_ID_DEVICE_DRAW_INDEX_BUFFER_TOO_SMALL = 359,
        D3D10_MESSAGE_ID_DEVICE_DRAW_GS_INPUT_PRIMITIVE_MISMATCH = 360,
        D3D10_MESSAGE_ID_DEVICE_DRAW_RESOURCE_RETURN_TYPE_MISMATCH = 361,
        D3D10_MESSAGE_ID_DEVICE_DRAW_POSITION_NOT_PRESENT = 362,
        D3D10_MESSAGE_ID_DEVICE_DRAW_OUTPUT_STREAM_NOT_SET = 363,
        D3D10_MESSAGE_ID_DEVICE_DRAW_BOUND_RESOURCE_MAPPED = 364,
        D3D10_MESSAGE_ID_DEVICE_DRAW_INVALID_PRIMITIVETOPOLOGY = 365,
        D3D10_MESSAGE_ID_DEVICE_DRAW_VERTEX_OFFSET_UNALIGNED = 366,
        D3D10_MESSAGE_ID_DEVICE_DRAW_VERTEX_STRIDE_UNALIGNED = 367,
        D3D10_MESSAGE_ID_DEVICE_DRAW_INDEX_OFFSET_UNALIGNED = 368,
        D3D10_MESSAGE_ID_DEVICE_DRAW_OUTPUT_STREAM_OFFSET_UNALIGNED = 369,
        D3D10_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_LD_UNSUPPORTED = 370,
        D3D10_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_SAMPLE_UNSUPPORTED = 371,
        D3D10_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_SAMPLE_C_UNSUPPORTED = 372,
        D3D10_MESSAGE_ID_DEVICE_DRAW_RESOURCE_MULTISAMPLE_UNSUPPORTED = 373,
        D3D10_MESSAGE_ID_DEVICE_DRAW_SO_TARGETS_BOUND_WITHOUT_SOURCE = 374,
        D3D10_MESSAGE_ID_DEVICE_DRAW_SO_STRIDE_LARGER_THAN_BUFFER = 375,
        D3D10_MESSAGE_ID_DEVICE_DRAW_OM_RENDER_TARGET_DOES_NOT_SUPPORT_BLENDING = 376,
        D3D10_MESSAGE_ID_DEVICE_DRAW_OM_DUAL_SOURCE_BLENDING_CAN_ONLY_HAVE_RENDER_TARGET_0 = 377,
        D3D10_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_AT_FAULT = 378,
        D3D10_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_POSSIBLY_AT_FAULT = 379,
        D3D10_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_NOT_AT_FAULT = 380,
        D3D10_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_INVALIDARG_RETURN = 381,
        D3D10_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_OUTOFMEMORY_RETURN = 382,
        D3D10_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_BADINTERFACE_RETURN = 383,
        D3D10_MESSAGE_ID_DEVICE_DRAW_VIEWPORT_NOT_SET = 384,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_TRAILING_DIGIT_IN_SEMANTIC = 385,
        D3D10_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_TRAILING_DIGIT_IN_SEMANTIC = 386,
        D3D10_MESSAGE_ID_DEVICE_RSSETVIEWPORTS_DENORMFLUSH = 387,
        D3D10_MESSAGE_ID_OMSETRENDERTARGETS_INVALIDVIEW = 388,
        D3D10_MESSAGE_ID_DEVICE_SETTEXTFILTERSIZE_INVALIDDIMENSIONS = 389,
        D3D10_MESSAGE_ID_DEVICE_DRAW_SAMPLER_MISMATCH = 390,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_TYPE_MISMATCH = 391,
        D3D10_MESSAGE_ID_BLENDSTATE_GETDESC_LEGACY = 392,
        D3D10_MESSAGE_ID_SHADERRESOURCEVIEW_GETDESC_LEGACY = 393,
        D3D10_MESSAGE_ID_CREATEQUERY_OUTOFMEMORY_RETURN = 394,
        D3D10_MESSAGE_ID_CREATEPREDICATE_OUTOFMEMORY_RETURN = 395,
        D3D10_MESSAGE_ID_CREATECOUNTER_OUTOFRANGE_COUNTER = 396,
        D3D10_MESSAGE_ID_CREATECOUNTER_SIMULTANEOUS_ACTIVE_COUNTERS_EXHAUSTED = 397,
        D3D10_MESSAGE_ID_CREATECOUNTER_UNSUPPORTED_WELLKNOWN_COUNTER = 398,
        D3D10_MESSAGE_ID_CREATECOUNTER_OUTOFMEMORY_RETURN = 399,
        D3D10_MESSAGE_ID_CREATECOUNTER_NONEXCLUSIVE_RETURN = 400,
        D3D10_MESSAGE_ID_CREATECOUNTER_NULLDESC = 401,
        D3D10_MESSAGE_ID_CHECKCOUNTER_OUTOFRANGE_COUNTER = 402,
        D3D10_MESSAGE_ID_CHECKCOUNTER_UNSUPPORTED_WELLKNOWN_COUNTER = 403,
        D3D10_MESSAGE_ID_SETPREDICATION_INVALID_PREDICATE_STATE = 404,
        D3D10_MESSAGE_ID_QUERY_BEGIN_UNSUPPORTED = 405,
        D3D10_MESSAGE_ID_PREDICATE_BEGIN_DURING_PREDICATION = 406,
        D3D10_MESSAGE_ID_QUERY_BEGIN_DUPLICATE = 407,
        D3D10_MESSAGE_ID_QUERY_BEGIN_ABANDONING_PREVIOUS_RESULTS = 408,
        D3D10_MESSAGE_ID_PREDICATE_END_DURING_PREDICATION = 409,
        D3D10_MESSAGE_ID_QUERY_END_ABANDONING_PREVIOUS_RESULTS = 410,
        D3D10_MESSAGE_ID_QUERY_END_WITHOUT_BEGIN = 411,
        D3D10_MESSAGE_ID_QUERY_GETDATA_INVALID_DATASIZE = 412,
        D3D10_MESSAGE_ID_QUERY_GETDATA_INVALID_FLAGS = 413,
        D3D10_MESSAGE_ID_QUERY_GETDATA_INVALID_CALL = 414,
        D3D10_MESSAGE_ID_DEVICE_DRAW_PS_OUTPUT_TYPE_MISMATCH = 415,
        D3D10_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_GATHER_UNSUPPORTED = 416,
        D3D10_MESSAGE_ID_DEVICE_DRAW_INVALID_USE_OF_CENTER_MULTISAMPLE_PATTERN = 417,
        D3D10_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_STRIDE_TOO_LARGE = 418,
        D3D10_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_INVALIDRANGE = 419,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_EMPTY_LAYOUT = 420,
        D3D10_MESSAGE_ID_DEVICE_DRAW_RESOURCE_SAMPLE_COUNT_MISMATCH = 421,
        D3D10_MESSAGE_ID_LIVE_OBJECT_SUMMARY = 422,
        D3D10_MESSAGE_ID_LIVE_BUFFER = 423,
        D3D10_MESSAGE_ID_LIVE_TEXTURE1D = 424,
        D3D10_MESSAGE_ID_LIVE_TEXTURE2D = 425,
        D3D10_MESSAGE_ID_LIVE_TEXTURE3D = 426,
        D3D10_MESSAGE_ID_LIVE_SHADERRESOURCEVIEW = 427,
        D3D10_MESSAGE_ID_LIVE_RENDERTARGETVIEW = 428,
        D3D10_MESSAGE_ID_LIVE_DEPTHSTENCILVIEW = 429,
        D3D10_MESSAGE_ID_LIVE_VERTEXSHADER = 430,
        D3D10_MESSAGE_ID_LIVE_GEOMETRYSHADER = 431,
        D3D10_MESSAGE_ID_LIVE_PIXELSHADER = 432,
        D3D10_MESSAGE_ID_LIVE_INPUTLAYOUT = 433,
        D3D10_MESSAGE_ID_LIVE_SAMPLER = 434,
        D3D10_MESSAGE_ID_LIVE_BLENDSTATE = 435,
        D3D10_MESSAGE_ID_LIVE_DEPTHSTENCILSTATE = 436,
        D3D10_MESSAGE_ID_LIVE_RASTERIZERSTATE = 437,
        D3D10_MESSAGE_ID_LIVE_QUERY = 438,
        D3D10_MESSAGE_ID_LIVE_PREDICATE = 439,
        D3D10_MESSAGE_ID_LIVE_COUNTER = 440,
        D3D10_MESSAGE_ID_LIVE_DEVICE = 441,
        D3D10_MESSAGE_ID_LIVE_SWAPCHAIN = 442,
        D3D10_MESSAGE_ID_D3D10_MESSAGES_END = 443,
        D3D10_MESSAGE_ID_D3D10L9_MESSAGES_START = 1048576,
        D3D10_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_STENCIL_NO_TWO_SIDED = 1048577,
        D3D10_MESSAGE_ID_CREATERASTERIZERSTATE_DepthBiasClamp_NOT_SUPPORTED = 1048578,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_NO_COMPARISON_SUPPORT = 1048579,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_EXCESSIVE_ANISOTROPY = 1048580,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_BORDER_OUT_OF_RANGE = 1048581,
        D3D10_MESSAGE_ID_VSSETSAMPLERS_NOT_SUPPORTED = 1048582,
        D3D10_MESSAGE_ID_VSSETSAMPLERS_TOO_MANY_SAMPLERS = 1048583,
        D3D10_MESSAGE_ID_PSSETSAMPLERS_TOO_MANY_SAMPLERS = 1048584,
        D3D10_MESSAGE_ID_CREATERESOURCE_NO_ARRAYS = 1048585,
        D3D10_MESSAGE_ID_CREATERESOURCE_NO_VB_AND_IB_BIND = 1048586,
        D3D10_MESSAGE_ID_CREATERESOURCE_NO_TEXTURE_1D = 1048587,
        D3D10_MESSAGE_ID_CREATERESOURCE_DIMENSION_OUT_OF_RANGE = 1048588,
        D3D10_MESSAGE_ID_CREATERESOURCE_NOT_BINDABLE_AS_SHADER_RESOURCE = 1048589,
        D3D10_MESSAGE_ID_OMSETRENDERTARGETS_TOO_MANY_RENDER_TARGETS = 1048590,
        D3D10_MESSAGE_ID_OMSETRENDERTARGETS_NO_DIFFERING_BIT_DEPTHS = 1048591,
        D3D10_MESSAGE_ID_IASETVERTEXBUFFERS_BAD_BUFFER_INDEX = 1048592,
        D3D10_MESSAGE_ID_DEVICE_RSSETVIEWPORTS_TOO_MANY_VIEWPORTS = 1048593,
        D3D10_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_ADJACENCY_UNSUPPORTED = 1048594,
        D3D10_MESSAGE_ID_DEVICE_RSSETSCISSORRECTS_TOO_MANY_SCISSORS = 1048595,
        D3D10_MESSAGE_ID_COPYRESOURCE_ONLY_TEXTURE_2D_WITHIN_GPU_MEMORY = 1048596,
        D3D10_MESSAGE_ID_COPYRESOURCE_NO_TEXTURE_3D_READBACK = 1048597,
        D3D10_MESSAGE_ID_COPYRESOURCE_NO_TEXTURE_ONLY_READBACK = 1048598,
        D3D10_MESSAGE_ID_CREATEINPUTLAYOUT_UNSUPPORTED_FORMAT = 1048599,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_NO_ALPHA_TO_COVERAGE = 1048600,
        D3D10_MESSAGE_ID_CREATERASTERIZERSTATE_DepthClipEnable_MUST_BE_TRUE = 1048601,
        D3D10_MESSAGE_ID_DRAWINDEXED_STARTINDEXLOCATION_MUST_BE_POSITIVE = 1048602,
        D3D10_MESSAGE_ID_CREATESHADERRESOURCEVIEW_MUST_USE_LOWEST_LOD = 1048603,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_MINLOD_MUST_NOT_BE_FRACTIONAL = 1048604,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_MAXLOD_MUST_BE_FLT_MAX = 1048605,
        D3D10_MESSAGE_ID_CREATESHADERRESOURCEVIEW_FIRSTARRAYSLICE_MUST_BE_ZERO = 1048606,
        D3D10_MESSAGE_ID_CREATESHADERRESOURCEVIEW_CUBES_MUST_HAVE_6_SIDES = 1048607,
        D3D10_MESSAGE_ID_CREATERESOURCE_NOT_BINDABLE_AS_RENDER_TARGET = 1048608,
        D3D10_MESSAGE_ID_CREATERESOURCE_NO_DWORD_INDEX_BUFFER = 1048609,
        D3D10_MESSAGE_ID_CREATERESOURCE_MSAA_PRECLUDES_SHADER_RESOURCE = 1048610,
        D3D10_MESSAGE_ID_CREATERESOURCE_PRESENTATION_PRECLUDES_SHADER_RESOURCE = 1048611,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_NO_INDEPENDENT_BLEND_ENABLE = 1048612,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_NO_INDEPENDENT_WRITE_MASKS = 1048613,
        D3D10_MESSAGE_ID_CREATERESOURCE_NO_STREAM_OUT = 1048614,
        D3D10_MESSAGE_ID_CREATERESOURCE_ONLY_VB_IB_FOR_BUFFERS = 1048615,
        D3D10_MESSAGE_ID_CREATERESOURCE_NO_AUTOGEN_FOR_VOLUMES = 1048616,
        D3D10_MESSAGE_ID_CREATERESOURCE_DXGI_FORMAT_R8G8B8A8_CANNOT_BE_SHARED = 1048617,
        D3D10_MESSAGE_ID_VSSHADERRESOURCES_NOT_SUPPORTED = 1048618,
        D3D10_MESSAGE_ID_GEOMETRY_SHADER_NOT_SUPPORTED = 1048619,
        D3D10_MESSAGE_ID_STREAM_OUT_NOT_SUPPORTED = 1048620,
        D3D10_MESSAGE_ID_TEXT_FILTER_NOT_SUPPORTED = 1048621,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_NO_SEPARATE_ALPHA_BLEND = 1048622,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_NO_MRT_BLEND = 1048623,
        D3D10_MESSAGE_ID_CREATEBLENDSTATE_OPERATION_NOT_SUPPORTED = 1048624,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_NO_MIRRORONCE = 1048625,
        D3D10_MESSAGE_ID_DRAWINSTANCED_NOT_SUPPORTED = 1048626,
        D3D10_MESSAGE_ID_DRAWINDEXEDINSTANCED_NOT_SUPPORTED_BELOW_9_3 = 1048627,
        D3D10_MESSAGE_ID_DRAWINDEXED_POINTLIST_UNSUPPORTED = 1048628,
        D3D10_MESSAGE_ID_SETBLENDSTATE_SAMPLE_MASK_CANNOT_BE_ZERO = 1048629,
        D3D10_MESSAGE_ID_CREATERESOURCE_DIMENSION_EXCEEDS_FEATURE_LEVEL_DEFINITION = 1048630,
        D3D10_MESSAGE_ID_CREATERESOURCE_ONLY_SINGLE_MIP_LEVEL_DEPTH_STENCIL_SUPPORTED = 1048631,
        D3D10_MESSAGE_ID_DEVICE_RSSETSCISSORRECTS_NEGATIVESCISSOR = 1048632,
        D3D10_MESSAGE_ID_SLOT_ZERO_MUST_BE_D3D10_INPUT_PER_VERTEX_DATA = 1048633,
        D3D10_MESSAGE_ID_CREATERESOURCE_NON_POW_2_MIPMAP = 1048634,
        D3D10_MESSAGE_ID_CREATESAMPLERSTATE_BORDER_NOT_SUPPORTED = 1048635,
        D3D10_MESSAGE_ID_OMSETRENDERTARGETS_NO_SRGB_MRT = 1048636,
        D3D10_MESSAGE_ID_COPYRESOURCE_NO_3D_MISMATCHED_UPDATES = 1048637,
        D3D10_MESSAGE_ID_D3D10L9_MESSAGES_END = 1048638,
    }
}
