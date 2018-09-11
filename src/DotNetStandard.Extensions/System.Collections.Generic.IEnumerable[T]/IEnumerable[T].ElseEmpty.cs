using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class EnumerableExtensions
    {
        [NotNull]
        public static IEnumerable<T> ElseEmpty<T>([CanBeNull] this IEnumerable<T> items)
        {
            return items ?? Enumerable.Empty<T>();
        }
    }
}