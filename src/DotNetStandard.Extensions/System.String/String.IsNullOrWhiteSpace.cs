using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class StringExtensions
    {
        [ContractAnnotation("value:null => true")]
        public static bool IsNullOrWhiteSpace([CanBeNull] this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
    }
}
