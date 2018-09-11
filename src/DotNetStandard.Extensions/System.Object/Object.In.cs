using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class ObjectExtensions
    {
        public static bool In<T>(this T value, [CanBeNull] params T[] values)
        {
            return values != null && values.Contains(value);
        }

        public static bool In<T>(this T value, IEqualityComparer<T> equalityComparer, [CanBeNull] params T[] values)
        {
            return values != null && values.Contains(value, equalityComparer);
        }
    }
}
