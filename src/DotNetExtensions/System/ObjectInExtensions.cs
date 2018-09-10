using System.Linq;

namespace DotNetExtensions.System
{
    public static class ObjectInExtensions
    {
        public static bool In<T>(this T value, params T[] values)
        {
            return values != null && values.Contains(value);
        }
    }
}
