﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FracVisualisationSoftware.Misc.Extensions
{
    public static class MathExtensionMethods
    {
        public static bool IsNumeric(this object value)
        {
            return value is sbyte
                   || value is byte
                   || value is short
                   || value is ushort
                   || value is int
                   || value is uint
                   || value is long
                   || value is ulong
                   || value is float
                   || value is double
                   || value is decimal;
        }
    }
}
