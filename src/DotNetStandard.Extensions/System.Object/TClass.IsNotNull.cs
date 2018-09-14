using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class ObjectExtensions
    {
        [ContractAnnotation("value:notnull => true")]
        public static bool IsNotNull<T>([CanBeNull] this T value)
            where T : class
        {
            return value != null;
        }
    }
}
