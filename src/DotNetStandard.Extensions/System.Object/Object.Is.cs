// ReSharper disable CheckNamespace
using JetBrains.Annotations;

namespace DotNetStandard.Extensions
{
    public static partial class ObjectExtensions
    {
        public static bool Is<T>([CanBeNull] this object value)
        {
            return value?.GetType() == typeof(T);
        }
    }
}
