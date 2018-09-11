using System;
using System.Globalization;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class StringExtensions
    {
        public static short? ToShort(this string value)
        {
            return short.TryParse(value, out var temp) ? temp : (short?)null;
        }

        public static short? ToShort(this string value, NumberStyles numberStyles, IFormatProvider formatProvider)
        {
            return short.TryParse(value, numberStyles, formatProvider, out var temp) ? temp : (short?)null;
        }
    }
}
