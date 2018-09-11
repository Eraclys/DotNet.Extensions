using System;
using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class ObjectExtensions
    {
        [CanBeNull]
        public static TResult IfNotNull<T, TResult>([CanBeNull] this T value, [NotNull] Func<T, TResult> selector)
            where T : class
        {
            return value != null ? selector(value) : default(TResult);
        }
    }
}