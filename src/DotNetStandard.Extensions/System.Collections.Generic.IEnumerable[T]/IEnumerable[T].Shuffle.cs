using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class EnumerableExtensions
    {
        /// <summary>
        ///  Fisher-Yates shuffle
        /// </summary>
        [NotNull]
        public static T[] Shuffle<T>(
            [CanBeNull] this IEnumerable<T> items,
            [CanBeNull] IRandomGenerator randomGenerator = null)
        {
            if (items == null)
            {
                return new T[0];
            }

            var newArray = items.ToArray();

            newArray.ShuffleInPlace(randomGenerator);

            return newArray;
        }
    }
}
