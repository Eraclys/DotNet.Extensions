using System;
using System.Globalization;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class StringExtensions
    {
        public static double? ToDouble(this string value)
        {
            return double.TryParse(value, out var temp) ? temp : (double?)null;
        }

        public static double? ToDouble(this string value, NumberStyles numberStyles, IFormatProvider formatProvider)
        {
            return double.TryParse(value, numberStyles, formatProvider, out var temp) ? temp : (double?)null;
        }
    }
}
