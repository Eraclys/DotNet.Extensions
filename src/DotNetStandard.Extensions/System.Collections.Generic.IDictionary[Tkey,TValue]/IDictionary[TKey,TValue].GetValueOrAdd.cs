using System;
using System.Collections.Generic;
using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class DictionaryExtensions
    {
        [NotNull]
        public static TValue GetValueOrAdd<TKey, TValue>(
            [NotNull] this IDictionary<TKey, TValue> dictionary,
            [NotNull] TKey key,
            [NotNull] Func<TValue> createFunc)
        {
            if (!dictionary.TryGetValue(key, out var value))
            {
                dictionary[key] = value = createFunc();
            }

            return value;
        }
    }
}
