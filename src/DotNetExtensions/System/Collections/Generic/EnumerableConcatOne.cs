using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace DotNetExtensions.System.Collections.Generic
{
    public static class EnumerableConcatOne
    {
        [NotNull]
        public static IEnumerable<T> ConcatOne<T>([NotNull] this IEnumerable<T> items, T item)
        {
            return items.Concat(new[] {item});
        }
    }
}