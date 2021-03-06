﻿namespace MBINCompiler.Models.Structs
{
    public class GcShipWeapons : NMSTemplate     // size: 0x40, in global?
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Projectile;
        /* 0x10 */ public GcStatsTypes Stat;
        /* 0x14 */ public bool IsProjectile;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x15 */ public byte[] Padding15;
        [NMS(Size = 0x10)]
        /* 0x18 */ public string Reticle;
        /* 0x28 */ public float AutoAimAngle;
        /* 0x2C */ public float AutoAimExtraAngle;
        /* 0x30 */ public bool ShowOverheatSwitch;
        /* 0x34 */ public float OverheatCoolTime;
        /* 0x38 */ public float CoolRate;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
