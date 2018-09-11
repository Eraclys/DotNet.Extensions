using System;
using System.Globalization;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class StringExtensions
    {
        public static int? ToInt32(this string value)
        {
            return int.TryParse(value, out var temp) ? temp : (int?)null;
        }

        public static int? ToInt32(this string value, NumberStyles numberStyles, IFormatProvider formatProvider)
        {
            return int.TryParse(value, numberStyles, formatProvider, out var temp) ? temp : (int?)null;
        }
    }
}
