using System.Collections.Generic;
using JetBrains.Annotations;

namespace DotNetStandard.Extensions.System.Collections.Generic
{
    public static class EnumerableToHashSetExtensions
    {
        [NotNull]
        public static HashSet<T> ToHashSet<T>([CanBeNull] this IEnumerable<T> items)
        {
            var hashSet = new HashSet<T>();

            if (items != null)
            {
                foreach (var item in items)
                {
                    hashSet.Add(item);
                }
            }

            return hashSet;
        }
    }
}
