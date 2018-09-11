using System;
using System.Globalization;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class StringExtensions
    {
        public static float? ToFloat(this string value)
        {
            return float.TryParse(value, out var temp) ? temp : (float?)null;
        }

        public static float? ToFloat(this string value, NumberStyles numberStyles, IFormatProvider formatProvider)
        {
            return float.TryParse(value, numberStyles, formatProvider, out var temp) ? temp : (float?)null;
        }
    }
}
