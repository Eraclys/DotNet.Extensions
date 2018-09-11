using System;
using System.Globalization;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class StringExtensions
    {
        public static long? ToInt64(this string value)
        {
            return long.TryParse(value, out var temp) ? temp : (long?)null;
        }

        public static long? ToInt64(this string value, NumberStyles numberStyles, IFormatProvider formatProvider)
        {
            return long.TryParse(value, numberStyles, formatProvider, out var temp) ? temp : (long?)null;
        }
    }
}
