using System;
using System.Globalization;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class StringExtensions
    {
        public static uint? ToUnsignedInt32(this string value)
        {
            return uint.TryParse(value, out var temp) ? temp : (uint?)null;
        }

        public static uint? ToUnsignedInt32(this string value, NumberStyles numberStyles, IFormatProvider formatProvider)
        {
            return uint.TryParse(value, numberStyles, formatProvider, out var temp) ? temp : (uint?)null;
        }
    }
}
