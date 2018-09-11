using System.Collections.Generic;
using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class EnumerableExtensions
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
    }
}