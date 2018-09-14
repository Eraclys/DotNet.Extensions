using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class ObjectExtensions
    {
        public static bool IsDefault<T>([CanBeNull] this T value)
        {
            return Equals(value, default(T));
        }
    }
}
