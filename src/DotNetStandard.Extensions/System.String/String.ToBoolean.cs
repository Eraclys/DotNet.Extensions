
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class StringExtensions
    {
        public static bool? ToBoolean(this string value)
        {
            return bool.TryParse(value, out var temp) ? temp : (bool?)null;
        }
    }
}
