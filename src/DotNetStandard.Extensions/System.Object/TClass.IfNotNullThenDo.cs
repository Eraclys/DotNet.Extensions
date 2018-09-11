using System;
using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class ObjectExtensions
    {
        public static void IfNotNullThenDo<T>([CanBeNull] this T value, [NotNull] Action<T> action)
            where T : class
        {
            if (value != null)
            {
                action(value);
            }
        }
    }

}
