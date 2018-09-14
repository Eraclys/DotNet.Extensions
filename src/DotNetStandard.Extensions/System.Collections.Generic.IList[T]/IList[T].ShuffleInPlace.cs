using System.Collections.Generic;
using JetBrains.Annotations;

// ReSharper disable CheckNamespace
namespace DotNetStandard.Extensions
{
    public static partial class ListExtensions
    {
        /// <summary>
        ///  Fisher-Yates shuffle
        /// </summary>
        public static void ShuffleInPlace<T>(
            [NotNull] this IList<T> items,
            [CanBeNull] IRandomGenerator randomGenerator = null)
        {
            var provider = randomGenerator ?? RandomGenerator.Default;

            var n = items.Count;

            while (n > 1)
            {
                n--;
                var k = provider.Next(n + 1);

                items.Swap(k, n);
            }
        }
    }
}
