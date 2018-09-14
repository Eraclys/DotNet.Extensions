using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class NullableExtensions
    {
        [ContractAnnotation("value:null => true")]
        public static bool IsNull<T>([CanBeNull] this T? value)
            where T : struct
        {
            return value == null;
        }
    }
}
