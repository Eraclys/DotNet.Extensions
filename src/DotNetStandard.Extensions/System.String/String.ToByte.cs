using System;
using System.Globalization;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class StringExtensions
    {
        public static byte? ToByte(this string value)
        {
            return byte.TryParse(value, out var temp) ? temp : (byte?)null;
        }

        public static byte? ToByte(this string value, NumberStyles numberStyles, IFormatProvider formatProvider)
        {
            return byte.TryParse(value, numberStyles, formatProvider, out var temp) ? temp : (byte?)null;
        }
    }
}
