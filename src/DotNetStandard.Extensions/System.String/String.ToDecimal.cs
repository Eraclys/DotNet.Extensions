using System;
using System.Globalization;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class StringExtensions
    {
        public static decimal? ToDecimal(this string value)
        {
            return decimal.TryParse(value, out var temp) ? temp : (decimal?)null;
        }

        public static decimal? ToDecimal(this string value, NumberStyles numberStyles, IFormatProvider formatProvider)
        {
            return decimal.TryParse(value, numberStyles, formatProvider, out var temp) ? temp : (decimal?)null;
        }
    }
}
