using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace DotNetStandard.Extensions.System
{
    public static class ObjectInExtensions
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
