using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class EnumerableExtensions
    {
        [NotNull]
        public static IList<T> ConvertToList<T>([CanBeNull] this IEnumerable<T> items)
        {
            if (items == null)
            {
                return new List<T>();
            }

            return items as IList<T> ?? items.ToList();
        }
    }
}
