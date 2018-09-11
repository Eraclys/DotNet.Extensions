using System;
using System.Globalization;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class StringExtensions
    {
        public static DateTime? ToDateTime(this string value)
        {
            return DateTime.TryParse(value, out var temp) ? temp : (DateTime?)null;
        }

        public static DateTime? ToDateTime(this string value, DateTimeStyles dateTimeStyles, IFormatProvider formatProvider)
        {
            return DateTime.TryParse(value, formatProvider, dateTimeStyles, out var temp) ? temp : (DateTime?)null;
        }
    }
}
