using System;
using JetBrains.Annotations;

namespace DotNet.Extensions.System
{
    public static class NullExtensions
    {
        public static void IfNotNullThenDo<TObject>([CanBeNull] this TObject value, [NotNull] Action<TObject> action)
            where TObject : class
        {
            if (value != null)
            {
                action(value);
            }
        }

        public static void IfHasValueThenDo<TValue>([CanBeNull] this TValue? value, [NotNull] Action<TValue> action)
            where TValue : struct
        {
            if (value.HasValue)
            {
                action(value.Value);
            }
        }

        [CanBeNull]
        public static TResult IfNotNull<TObject, TResult>([CanBeNull] this TObject value, [NotNull] Func<TObject, TResult> selector)
            where TObject : class
        {
            return value != null ? selector(value) : default(TResult);
        }

        [CanBeNull]
        public static TResult IfNotNull<TValue, TResult>([CanBeNull] this TValue? value, [NotNull] Func<TValue, TResult> selector)
            where TValue : struct
        {
            return value.HasValue ? selector(value.Value) : default(TResult);
        }

        [CanBeNull]
        public static TObject Else<TObject>([CanBeNull] this TObject value, [CanBeNull] TObject alternative)
            where TObject : class
        {
            return value ?? alternative;
        }

        [CanBeNull]
        public static TObject Else<TObject>([CanBeNull] this TObject value, [NotNull] Func<TObject> getAlternative)
            where TObject : class
        {
            return value ?? getAlternative();
        }

        [CanBeNull]
        public static TValue? Else<TValue>([CanBeNull] this TValue? value, [CanBeNull] TValue? alternative)
            where TValue : struct
        {
            return value ?? alternative;
        }

        [CanBeNull]
        public static TValue? Else<TValue>([CanBeNull] this TValue? value, [NotNull] Func<TValue?> getAlternative)
            where TValue : struct
        {
            return value ?? getAlternative();
        }
    }
}
