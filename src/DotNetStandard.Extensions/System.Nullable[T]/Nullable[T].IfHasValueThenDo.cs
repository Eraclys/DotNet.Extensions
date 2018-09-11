using System;
using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class NullableExtensions
    {
        public static void IfHasValueThenDo<T>([CanBeNull] this T? value, [NotNull] Action<T> action)
            where T : struct
        {
            if (value.HasValue)
            {
                action(value.Value);
            }
        }
    }
}
