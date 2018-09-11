using System;
using JetBrains.Annotations;

namespace DotNet.Extensions.System
{
    public static class ComparableExtensions
    {
        public static T WithMaxValueOf<T>([NotNull] this T value, T maxValue)
            where T : IComparable<T>
        {
            return value.CompareTo(maxValue) > 0 ? maxValue : value;
        }

        public static T WithMinValueOf<T>([NotNull] this T value, T maxValue)
            where T : IComparable<T>
        {
            return value.CompareTo(maxValue) < 0 ? maxValue : value;
        }
    }
}
