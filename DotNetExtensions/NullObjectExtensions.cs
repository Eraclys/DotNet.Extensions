using System;
using JetBrains.Annotations;

namespace DotNetExtensions
{
    public static class NullObjectExtensions
    {
        public static void IfNotNullThenDo<TObject>([CanBeNull] this TObject value, Action<TObject> action)
            where TObject : class
        {
            if (value != null)
            {
                action(value);
            }
        }

        public static void IfHasValueThenDo<TValue>([CanBeNull] this TValue? value, Action<TValue> action)
            where TValue : struct
        {
            if (value.HasValue)
            {
                action(value.Value);
            }
        }

        [CanBeNull]
        public static TResult IfNotNull<TObject, TResult>([CanBeNull] this TObject value, Func<TObject, TResult> selector)
            where TObject : class
        {
            return value != null ? selector(value) : default(TResult);
        }

        [CanBeNull]
        public static TResult IfNotNull<TValue, TResult>([CanBeNull] this TValue? value, Func<TValue, TResult> selector)
            where TValue : struct
        {
            return value.HasValue ? selector(value.Value) : default(TResult);
        }
    }
}
