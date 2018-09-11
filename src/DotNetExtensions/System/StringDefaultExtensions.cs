using JetBrains.Annotations;

namespace DotNetExtensions.System
{
    public static class StringDefaultExtensions
    {
        [NotNull]
        public static string DefaultIfNullOrEmpty([CanBeNull] this string value, string @defaultValue)
        {
            return string.IsNullOrEmpty(value) ? @defaultValue : value;
        }

        [NotNull]
        public static string DefaultIfNullOrWhiteSpace([CanBeNull] this string value, string @defaultValue)
        {
            return string.IsNullOrWhiteSpace(value) ? @defaultValue : value;
        }
    }
}