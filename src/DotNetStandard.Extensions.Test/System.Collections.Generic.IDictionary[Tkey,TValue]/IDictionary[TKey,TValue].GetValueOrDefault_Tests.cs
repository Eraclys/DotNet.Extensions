using System;
using System.Collections.Generic;
using FluentAssertions;
using FsCheck;
using NUnit.Framework;

namespace DotNetStandard.Extensions.Test
{
    [TestFixture]
    internal sealed class DictionaryExtensions_GetValueOrDefault_Tests
    {
        [FsCheck.NUnit.Property]
        public void WhenKeyDoesNotExist_ReturnDefaultValue(NonNull<string> nonNullKey)
        {
            var key = nonNullKey.Item;

            new Dictionary<string, int>().GetValueOrDefault(key).Should().Be(default(int));
            new Dictionary<string, string>().GetValueOrDefault(key).Should().Be(default(string));
            new Dictionary<string, int?>().GetValueOrDefault(key).Should().Be(default(int?));
            new Dictionary<string, DateTime>().GetValueOrDefault(key).Should().Be(default(DateTime));
        }

        [FsCheck.NUnit.Property]
        public void WhenKeyDoesNotExistAndDefaultIsProvided_ReturnProvidedDefault(NonNull<string> nonNullKey, int defaultInt, string defaultString, int? defaultNullableInt, DateTime defaultDateTime)
        {
            var key = nonNullKey.Item;

            new Dictionary<string, int>().GetValueOrDefault(key, defaultInt).Should().Be(defaultInt);
            new Dictionary<string, int?>().GetValueOrDefault(key, defaultNullableInt).Should().Be(defaultNullableInt);
            new Dictionary<string, DateTime>().GetValueOrDefault(key, defaultDateTime).Should().Be(defaultDateTime);
            new Dictionary<string, string>().GetValueOrDefault(key, defaultString).Should().Be(defaultString);
        }

        [FsCheck.NUnit.Property]
        public void WhenKeyExists_ShouldReturnValue(NonNull<string> nonNullKey, int expectedValue)
        {
            var key = nonNullKey.Item;

            var dictionary = new Dictionary<string, int> { { key, expectedValue } };

            var result = dictionary.GetValueOrDefault(key);
            result.Should().Be(expectedValue);
        }
    }
}
