// ReSharper disable CheckNamespace
namespace DotNetStandard.Extensions
{
    public static partial class ObjectExtensions
    {
        public static T CastTo<T>(this object value)
        {
            return (T)value;
        }
    }
}
