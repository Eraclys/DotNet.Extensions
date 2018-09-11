using System.Collections.Generic;
using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class EnumerableExtensions
    {
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