using System.Collections.Generic;
using FluentAssertions;
using FsCheck;
using NUnit.Framework;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions.Test
{
    [TestFixture]
    internal sealed class DictionaryExtensions_AddOrUpdate_Tests
    {
        [FsCheck.NUnit.Property]
        public void WhenKeyDoesNotExist_ShouldCreateNewDictionaryEntry(NonNull<string> nonNullKey, int value)
        {
            var key = nonNullKey.Item;

            var dictionary = new Dictionary<string, int>();

            var result = dictionary.AddOrUpdate(key, value);

            result.Should().BeSameAs(dictionary);
            result.ContainsKey(key).Should().BeTrue();
            result[key].Should().Be(value);
        }

        [FsCheck.NUnit.Property]
        public void WhenKeyExists_ShouldReplaceDictionaryEntry(NonNull<string> nonNullKey, int originalValue, int newValue)
        {
            var key = nonNullKey.Item;

            var dictionary = new Dictionary<string, int> {{key, originalValue}};

            var result = dictionary.AddOrUpdate(key, newValue);

            result.Should().BeSameAs(dictionary);
            result.ContainsKey(key).Should().BeTrue();
            result[key].Should().Be(newValue);
        }
    }
}
