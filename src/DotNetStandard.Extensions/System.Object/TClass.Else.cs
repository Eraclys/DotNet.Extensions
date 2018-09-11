using System;
using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class ObjectExtensions
    {
        [CanBeNull]
        public static T Else<T>([CanBeNull] this T value, [CanBeNull] T alternative)
            where T : class
        {
            return value ?? alternative;
        }

        [CanBeNull]
        public static T Else<T>([CanBeNull] this T value, [NotNull] Func<T> getAlternative)
            where T : class
        {
            return value ?? getAlternative();
        }
    }
}
