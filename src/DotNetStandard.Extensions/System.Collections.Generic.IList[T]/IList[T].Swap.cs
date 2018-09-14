using System.Collections.Generic;
using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class ListExtensions
    {
        public static void Swap<T>([NotNull] this IList<T> items, int i, int j)
        {
            if (i == j)
            {
                return;
            }

            var temp = items[i];
            items[i] = items[j];
            items[j] = temp;
        }
    }
}
