using JetBrains.Annotations;

namespace DotNetStandard.Extensions.System
{
    public static class StringAssertionsExtensions
    {
        [ContractAnnotation("value:null => true")]
        public static bool IsNullOrEmpty([CanBeNull] this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        [ContractAnnotation("value:null => true")]
        public static bool IsNullOrWhiteSpace([CanBeNull] this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
    }
}
