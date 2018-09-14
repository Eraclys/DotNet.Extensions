// ReSharper disable CheckNamespace
using JetBrains.Annotations;

namespace DotNetStandard.Extensions
{
    public static partial class ObjectExtensions
    {
        [CanBeNull]
        public static T As<T>(this object value)
            where T : class
        {
            return value as T;
        }
    }
}
