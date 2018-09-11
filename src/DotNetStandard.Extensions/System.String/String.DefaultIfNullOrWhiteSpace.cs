using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class StringExtensions
    {
        [NotNull]
        public static string DefaultIfNullOrWhiteSpace([CanBeNull] this string value, string @defaultValue)
        {
            return string.IsNullOrWhiteSpace(value) ? @defaultValue : value;
        }
    }
}
