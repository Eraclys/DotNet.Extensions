using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace DotNet.Extensions.System.Collections.Generic
{
    public static class EnumerableForEachExtensions
    {
        public static void ForEach<T>([CanBeNull] this IEnumerable<T> items, Action<T> action)
        {
            if (items == null)
            {
                return;
            }

            foreach (var item in items)
            {
                action(item);
            }
        }

        public static void ForEach<T>([CanBeNull] this IEnumerable<T> items, Action<int, T> action)
        {
            if (items == null)
            {
                return;
            }

            var index = 0;

            foreach (var item in items)
            {
                action(index++, item);
            }
        }
    }
}
