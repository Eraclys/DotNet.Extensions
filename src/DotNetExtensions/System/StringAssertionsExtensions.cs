using JetBrains.Annotations;

namespace DotNetExtensions.System
{
    public static class StringAssertionsExtensions
    {
        public static bool IsNullOrEmpty([CanBeNull] this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsNullOrWhiteSpace([CanBeNull] this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
    }
}
