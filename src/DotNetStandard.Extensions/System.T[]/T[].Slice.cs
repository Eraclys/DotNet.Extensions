using System;
using JetBrains.Annotations;

namespace DotNetStandard.Extensions
{
    public static partial class ArrayExtensions
    {
        [NotNull]
        public static T[] Slice<T>([CanBeNull] this T[] items, int fromIndex, int toIndex = int.MaxValue)
        {
            if (fromIndex < 0)
            {
                throw new ArgumentException("fromIndex must be positive", nameof(fromIndex));
            }

            if (fromIndex > toIndex)
            {
                throw new ArgumentException("fromIndex is greater than to Index", nameof(fromIndex));
            }

            if (items == null)
            {
                return new T[0];
            }

            toIndex = toIndex.WithMaxValueOf(items.Length);
            var length = toIndex - fromIndex;
            var result = new T[length];

            Array.Copy(items, fromIndex, result, 0, length);

            return result;
        }
    }
}
