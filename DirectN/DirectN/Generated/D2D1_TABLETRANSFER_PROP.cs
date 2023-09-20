﻿// generated from <Windows SDK Path>\um\d2d1effects.h
namespace DirectN
{
    /// <summary>
    /// The enumeration of the Table Transfer effect's top level properties. Effect description: Remaps the color intensities of the input bitmap based on a transfer function generated by a user specified list of values for each RGBA channel.
    /// </summary>
    public enum D2D1_TABLETRANSFER_PROP
    {
        /// <summary>
        /// Property Name: "RedTable" Property Type: (blob)
        /// </summary>
        D2D1_TABLETRANSFER_PROP_RED_TABLE = 0,
        
        /// <summary>
        /// Property Name: "RedDisable" Property Type: BOOL
        /// </summary>
        D2D1_TABLETRANSFER_PROP_RED_DISABLE = 1,
        
        /// <summary>
        /// Property Name: "GreenTable" Property Type: (blob)
        /// </summary>
        D2D1_TABLETRANSFER_PROP_GREEN_TABLE = 2,
        
        /// <summary>
        /// Property Name: "GreenDisable" Property Type: BOOL
        /// </summary>
        D2D1_TABLETRANSFER_PROP_GREEN_DISABLE = 3,
        
        /// <summary>
        /// Property Name: "BlueTable" Property Type: (blob)
        /// </summary>
        D2D1_TABLETRANSFER_PROP_BLUE_TABLE = 4,
        
        /// <summary>
        /// Property Name: "BlueDisable" Property Type: BOOL
        /// </summary>
        D2D1_TABLETRANSFER_PROP_BLUE_DISABLE = 5,
        
        /// <summary>
        /// Property Name: "AlphaTable" Property Type: (blob)
        /// </summary>
        D2D1_TABLETRANSFER_PROP_ALPHA_TABLE = 6,
        
        /// <summary>
        /// Property Name: "AlphaDisable" Property Type: BOOL
        /// </summary>
        D2D1_TABLETRANSFER_PROP_ALPHA_DISABLE = 7,
        
        /// <summary>
        /// Property Name: "ClampOutput" Property Type: BOOL
        /// </summary>
        D2D1_TABLETRANSFER_PROP_CLAMP_OUTPUT = 8,
        
        /// <summary>
        /// Property Name: "ClampOutput" Property Type: BOOL
        /// </summary>
        D2D1_TABLETRANSFER_PROP_FORCE_DWORD = -1,
    }
}
