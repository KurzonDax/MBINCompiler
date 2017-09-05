﻿namespace MBINCompiler.Models.Structs
{
    public class GcPlayerStickData : NMSTemplate        // probably in the GcPlayerGlobals
    {
        /* 0x000 */ public float AcceleratorStickPoint;     // 3F733333h
        /* 0x004 */ public float AcceleratorMinTime;        // 3E4CCCCDh
        /* 0x008 */ public float Accelerate;                // 3BA3D70Ah
        /* 0x00C */ public float AccelerateAngle;           // 41700000h
        /* 0x010 */ public float Turn;                      // 3F800000h
        /* 0x014 */ public float TurnFast;                  // 40A00000h
        /* 0x018 */ public float StickyFactor;              // 3F800000h
    }
}
