using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace DotNet.Extensions.System.Collections.Generic
{
    public static class EnumerableElseEmpty
    {
        [NotNull]
        public static IEnumerable<T> ElseEmpty<T>([CanBeNull] this IEnumerable<T> items)
        {
            return items ?? Enumerable.Empty<T>();
        }
    }
}