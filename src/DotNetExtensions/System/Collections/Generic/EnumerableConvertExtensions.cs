using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace DotNetExtensions.System.Collections.Generic
{
    public static class EnumerableConvertExtensions
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
