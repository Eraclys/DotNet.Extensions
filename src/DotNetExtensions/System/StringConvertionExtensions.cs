using System;
using System.Globalization;

namespace DotNetExtensions.System
{
    public static class StringConvertionExtensions
    {
        public static sbyte? ToSignedByte(this string value)
        {
            return sbyte.TryParse(value, out var temp) ? temp : (sbyte?)null;
        }

        public static sbyte? ToSignedByte(this string value, NumberStyles numberStyles, IFormatProvider formatProvider)
        {
            return sbyte.TryParse(value, numberStyles, formatProvider, out var temp) ? temp : (sbyte?)null;
        }

        public static short? ToShort(this string value)
        {
            return short.TryParse(value, out var temp) ? temp : (short?)null;
        }

        public static short? ToShort(this string value, NumberStyles numberStyles, IFormatProvider formatProvider)
        {
            return short.TryParse(value, numberStyles, formatProvider, out var temp) ? temp : (short?)null;
        }

        public static int? ToInt32(this string value)
        {
            return int.TryParse(value, out var temp) ? temp : (int?)null;
        }

        public static int? ToInt32(this string value, NumberStyles numberStyles, IFormatProvider formatProvider)
        {
            return int.TryParse(value, numberStyles, formatProvider, out var temp) ? temp : (int?)null;
        }

        public static long? ToInt64(this string value)
        {
            return long.TryParse(value, out var temp) ? temp : (long?)null;
        }

        public static long? ToInt64(this string value, NumberStyles numberStyles, IFormatProvider formatProvider)
        {
            return long.TryParse(value, numberStyles, formatProvider, out var temp) ? temp : (long?)null;
        }

        public static byte? ToByte(this string value)
        {
            return byte.TryParse(value, out var temp) ? temp : (byte?)null;
        }

        public static byte? ToByte(this string value, NumberStyles numberStyles, IFormatProvider formatProvider)
        {
            return byte.TryParse(value, numberStyles, formatProvider, out var temp) ? temp : (byte?)null;
        }

        public static ushort? ToUnsignedShort(this string value)
        {
            return ushort.TryParse(value, out var temp) ? temp : (ushort?)null;
        }

        public static ushort? ToUnsignedShort(this string value, NumberStyles numberStyles, IFormatProvider formatProvider)
        {
            return ushort.TryParse(value, numberStyles, formatProvider, out var temp) ? temp : (ushort?)null;
        }

        public static uint? ToUnsignedInt32(this string value)
        {
            return uint.TryParse(value, out var temp) ? temp : (uint?)null;
        }

        public static uint? ToUnsignedInt32(this string value, NumberStyles numberStyles, IFormatProvider formatProvider)
        {
            return uint.TryParse(value, numberStyles, formatProvider, out var temp) ? temp : (uint?)null;
        }

        public static ulong? ToUnsignedInt64(this string value)
        {
            return ulong.TryParse(value, out var temp) ? temp : (ulong?)null;
        }

        public static ulong? ToUnsignedInt64(this string value, NumberStyles numberStyles, IFormatProvider formatProvider)
        {
            return ulong.TryParse(value, numberStyles, formatProvider, out var temp) ? temp : (ulong?)null;
        }

        public static float? ToFloat(this string value)
        {
            return float.TryParse(value, out var temp) ? temp : (float?)null;
        }

        public static float? ToFloat(this string value, NumberStyles numberStyles, IFormatProvider formatProvider)
        {
            return float.TryParse(value, numberStyles, formatProvider, out var temp) ? temp : (float?)null;
        }

        public static double? ToDouble(this string value)
        {
            return double.TryParse(value, out var temp) ? temp : (double?)null;
        }

        public static double? ToDouble(this string value, NumberStyles numberStyles, IFormatProvider formatProvider)
        {
            return double.TryParse(value, numberStyles, formatProvider, out var temp) ? temp : (double?)null;
        }

        public static decimal? ToDecimal(this string value)
        {
            return decimal.TryParse(value, out var temp) ? temp : (decimal?)null;
        }

        public static decimal? ToDecimal(this string value, NumberStyles numberStyles, IFormatProvider formatProvider)
        {
            return decimal.TryParse(value, numberStyles, formatProvider, out var temp) ? temp : (decimal?)null;
        }

        public static bool? ToBoolean(this string value)
        {
            return bool.TryParse(value, out var temp) ? temp : (bool?)null;
        }

        public static char? ToChar(this string value)
        {
            return char.TryParse(value, out var temp) ? temp : (char?)null;
        }

        public static DateTime? ToDateTime(this string value)
        {
            return DateTime.TryParse(value, out var temp) ? temp : (DateTime?)null;
        }

        public static DateTime? ToDateTime(this string value, DateTimeStyles dateTimeStyles, IFormatProvider formatProvider)
        {
            return DateTime.TryParse(value, formatProvider, dateTimeStyles, out var temp) ? temp : (DateTime?)null;
        }

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
