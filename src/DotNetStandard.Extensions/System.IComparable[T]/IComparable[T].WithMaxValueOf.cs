using System;
using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class ComparableExtensions
    {
        public static T WithMaxValueOf<T>([NotNull] this T value, T maxValue)
            where T : IComparable<T>
        {
            return value.CompareTo(maxValue) > 0 ? maxValue : value;
        }
    }
}
