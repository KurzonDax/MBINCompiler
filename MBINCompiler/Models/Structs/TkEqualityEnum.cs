﻿using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkEqualityEnum : NMSTemplate
    {
        public int EqualityEnum;
        public string[] EqualityEnumValues()
        {
            return new[] { "Equal", "Greater", "Less"};
        }
    }
}
