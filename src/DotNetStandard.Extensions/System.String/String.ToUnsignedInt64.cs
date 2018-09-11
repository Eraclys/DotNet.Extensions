using System;
using System.Globalization;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class StringExtensions
    {
        public static ulong? ToUnsignedInt64(this string value)
        {
            return ulong.TryParse(value, out var temp) ? temp : (ulong?)null;
        }

        public static ulong? ToUnsignedInt64(this string value, NumberStyles numberStyles, IFormatProvider formatProvider)
        {
            return ulong.TryParse(value, numberStyles, formatProvider, out var temp) ? temp : (ulong?)null;
        }
    }
}
