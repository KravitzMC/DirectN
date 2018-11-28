﻿using System;

namespace DirectN
{
    [Flags]
    public enum D2D1_DRAW_TEXT_OPTIONS
    {
        D2D1_DRAW_TEXT_OPTIONS_NO_SNAP = 0x00000001,
        D2D1_DRAW_TEXT_OPTIONS_CLIP = 0x00000002,
        D2D1_DRAW_TEXT_OPTIONS_ENABLE_COLOR_FONT = 0x00000004,
        D2D1_DRAW_TEXT_OPTIONS_DISABLE_COLOR_BITMAP_SNAPPING = 0x00000008,
        D2D1_DRAW_TEXT_OPTIONS_NONE = 0x00000000,
    }
}