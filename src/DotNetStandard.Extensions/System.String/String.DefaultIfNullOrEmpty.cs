using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class StringExtensions
    {
        [NotNull]
        public static string DefaultIfNullOrEmpty([CanBeNull] this string value, string @defaultValue)
        {
            return string.IsNullOrEmpty(value) ? @defaultValue : value;
        }
    }
}