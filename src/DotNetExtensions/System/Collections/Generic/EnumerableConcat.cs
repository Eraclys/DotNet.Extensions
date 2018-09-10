using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace DotNetExtensions.System.Collections.Generic
{
    public static class EnumerableConcat
    {
        [NotNull]
        public static IEnumerable<T> Append<T>([NotNull] this IEnumerable<T> items, T value)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            foreach (var item in items)
            {
                yield return item;
            }

            yield return value;
        }

        [NotNull]
        public static IEnumerable<T> Prepend<T>([NotNull] this IEnumerable<T> items, T value)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            yield return value;

            foreach (var item in items)
            {
                yield return item;
            }
        }
    }
}