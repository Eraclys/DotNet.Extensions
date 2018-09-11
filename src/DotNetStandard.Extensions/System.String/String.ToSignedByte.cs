using System;
using System.Globalization;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class StringExtensions
    {
        public static sbyte? ToSignedByte(this string value)
        {
            return sbyte.TryParse(value, out var temp) ? temp : (sbyte?)null;
        }

        public static sbyte? ToSignedByte(this string value, NumberStyles numberStyles, IFormatProvider formatProvider)
        {
            return sbyte.TryParse(value, numberStyles, formatProvider, out var temp) ? temp : (sbyte?)null;
        }
    }
}
