using System.Collections.Generic;
using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class DictionaryExtensions
    {
        [NotNull]
        public static IDictionary<TKey, TValue> AddOrUpdate<TKey, TValue>(
            [NotNull] this IDictionary<TKey, TValue> dictionary,
            [NotNull] TKey key,
            TValue value)
        {
            dictionary[key] = value;
            return dictionary;
        }
    }
}
