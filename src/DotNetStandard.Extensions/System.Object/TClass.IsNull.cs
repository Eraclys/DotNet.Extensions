using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class ObjectExtensions
    {
        [ContractAnnotation("value:null => true")]
        public static bool IsNull<T>([CanBeNull] this T value)
            where T : class
        {
            return value == null;
        }
    }
}
