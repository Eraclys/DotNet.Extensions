using System.Collections.Generic;
using FluentAssertions;
using FsCheck;
using NUnit.Framework;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions.Test
{
    [TestFixture]
    internal sealed class DictionaryExtensions_GetValueOrAdd_Tests
    {
        [FsCheck.NUnit.Property]
        public void WhenKeyDoesNotExist_CreateNewDictionaryEntry(NonNull<string> nonNullKey, int onCreateValue)
        {
            var key = nonNullKey.Item;

            var dictionary = new Dictionary<string, int>();

            var result = dictionary.GetValueOrAdd(key, () => onCreateValue);

            result.Should().Be(onCreateValue);
            dictionary.ContainsKey(key).Should().BeTrue();
            dictionary[key].Should().Be(onCreateValue);
        }

        [FsCheck.NUnit.Property]
        public void WhenKeyExists_ShouldReturnValue(NonNull<string> nonNullKey, int originalValue, int onCreateValue)
        {
            var key = nonNullKey.Item;

            var dictionary = new Dictionary<string, int> { { key, originalValue } };

            var result = dictionary.GetValueOrAdd(key, () => onCreateValue);

            result.Should().Be(originalValue);
            dictionary.ContainsKey(key).Should().BeTrue();
            dictionary[key].Should().Be(originalValue);
        }
    }
}