using System;
using JetBrains.Annotations;

// ReSharper disable CheckNamespace
namespace DotNetStandard.Extensions
{
    public static partial class ArrayExtensions
    {
        [NotNull]
        public static T[] Slice<T>([CanBeNull] this T[] items, int startIndex, int endIndex = int.MaxValue)
        {
            if (startIndex < 0)
            {
                throw new ArgumentException("startIndex must be positive", nameof(startIndex));
            }

            if (startIndex > endIndex)
            {
                throw new ArgumentException("startIndex is greater than endIndex", nameof(startIndex));
            }

            if (items == null)
            {
                return new T[0];
            }

            endIndex = endIndex.WithMaxValueOf(items.Length);
            var length = endIndex - startIndex;
            var result = new T[length];

            Array.Copy(items, startIndex, result, 0, length);

            return result;
        }
    }
}
