
// ReSharper disable CheckNamespace
namespace DotNetStandard.Extensions
{
    public static partial class StringExtensions
    {
        public static char? ToChar(this string value)
        {
            return char.TryParse(value, out var temp) ? temp : (char?)null;
        }
    }
}
