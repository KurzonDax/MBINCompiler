﻿namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x1C)]
    public class GcShipAIDeathData : NMSTemplate
    {
        /* 0x000 */ public float DroneDeathTime;            // 3FE66666h
        /* 0x004 */ public float DroneDeathForce;           // 41000000h
        /* 0x008 */ public float DroneDeathBoomTotalTime;   // 3ECCCCCDh
        /* 0x00C */ public float DroneDeathOffset;          // 41A00000h
        /* 0x010 */ public int DroneNumDeathBooms;          // 2
        /* 0x014 */ public float DroneDeathTimeout;         // 40000000h
		/* 0x018 */ public float BrakeForce;                // 3F800000h
    }
}
