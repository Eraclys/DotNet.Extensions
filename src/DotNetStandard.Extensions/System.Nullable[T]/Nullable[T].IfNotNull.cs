using System;
using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class NullableExtensions
    {
        [CanBeNull]
        public static TResult IfNotNull<T, TResult>([CanBeNull] this T? value, [NotNull] Func<T, TResult> selector)
            where T : struct
        {
            return value.HasValue ? selector(value.Value) : default(TResult);
        }
    }
}