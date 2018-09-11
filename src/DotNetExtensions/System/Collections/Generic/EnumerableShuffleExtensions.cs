using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace DotNetExtensions.System.Collections.Generic
{
    public static class EnumerableShuffleExtensions
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

            var provider = randomGenerator ?? RandomGenerator.Default;

            var newArray = items.ToArray();
            var n = newArray.Length;

            while (n > 1)
            {
                n--;
                var k = provider.Next(n + 1);
                var value = newArray[k];

                newArray[k] = newArray[n];
                newArray[n] = value;
            }

            return newArray;
        }
    }
}
