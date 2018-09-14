using System;
using System.Text.RegularExpressions;
using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class StringExtensions
    {
        public static bool IsMatch([CanBeNull] this string value, [NotNull] string pattern)
        {
            return value != null && Regex.IsMatch(value, pattern);
        }

        public static bool IsMatch([CanBeNull] this string value, [NotNull] string pattern, RegexOptions options)
        {
            return value != null && Regex.IsMatch(value, pattern, options);
        }

        public static bool IsMatch([CanBeNull] this string value, [NotNull] string pattern, RegexOptions options, TimeSpan matchTimeout)
        {
            return value != null && Regex.IsMatch(value, pattern, options, matchTimeout);
        }
    }
}
