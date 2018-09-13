using System.Collections.Generic;
using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class DictionaryExtensions
    {
        [NotNull]
        public static TValue GetValueOrDefault<TKey, TValue>(
            [NotNull] this IDictionary<TKey, TValue> dictionary,
            [NotNull] TKey key,
            TValue @default = default(TValue))
        {
            return dictionary.TryGetValue(key, out var value) ? value : @default;
        }
    }
}
