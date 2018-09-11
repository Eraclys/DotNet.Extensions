using System;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class StringExtensions
    {
        public static TimeSpan? ToTimeSpan(this string value)
        {
            return TimeSpan.TryParse(value, out var temp) ? temp : (TimeSpan?)null;
        }

        public static TimeSpan? ToTimeSpan(this string value, IFormatProvider formatProvider)
        {
            return TimeSpan.TryParse(value, formatProvider, out var temp) ? temp : (TimeSpan?)null;
        }
    }
}
