using System.Collections.Generic;
using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class EnumerableExtensions
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
