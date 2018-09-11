using System.Collections.Generic;
using JetBrains.Annotations;

namespace DotNet.Extensions.System.Collections.Generic
{
    public static class EnumerableConcat
    {
        [NotNull]
        public static IEnumerable<T> Append<T>([CanBeNull] this IEnumerable<T> items, T value)
        {
            if (items != null)
            {
                foreach (var item in items)
                {
                    yield return item;
                }
            }

            yield return value;
        }

        [NotNull]
        public static IEnumerable<T> Prepend<T>([CanBeNull] this IEnumerable<T> items, T value)
        {
            yield return value;

            if (items == null)
            {
                yield break;
            }

            foreach (var item in items)
            {
                yield return item;
            }
        }
    }
}