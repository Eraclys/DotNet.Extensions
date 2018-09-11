using System;
using System.Globalization;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class StringExtensions
    {
        public static ushort? ToUnsignedShort(this string value)
        {
            return ushort.TryParse(value, out var temp) ? temp : (ushort?)null;
        }

        public static ushort? ToUnsignedShort(this string value, NumberStyles numberStyles, IFormatProvider formatProvider)
        {
            return ushort.TryParse(value, numberStyles, formatProvider, out var temp) ? temp : (ushort?)null;
        }
    }
}
