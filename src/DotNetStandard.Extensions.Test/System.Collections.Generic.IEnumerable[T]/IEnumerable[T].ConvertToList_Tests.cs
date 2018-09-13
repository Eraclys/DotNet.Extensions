using System.Collections.Generic;
using FluentAssertions;
using FsCheck;
using NUnit.Framework;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions.Test
{
    [TestFixture]
    internal sealed class EnumerableExtensions_ConvertToList_Tests
    {
        [Test]
        public void GivenNull_ShouldReturnEmptyList()
        {
            var result = ((IEnumerable<int>)null).ConvertToList();

            result.Should().NotBeNull();
            result.Should().BeEmpty();
            result.Should().BeAssignableTo<IList<int>>();
        }

        [FsCheck.NUnit.Property]
        public void GivenNonList_ShouldReturnNewList(NonNull<Dictionary<int, string>> notNullitems)
        {
            var items = notNullitems.Item;

            var result = items.ConvertToList();

            result.Should().NotBeSameAs(items);
            result.Should().BeAssignableTo<IList<KeyValuePair<int, string>>>();
        }

        [FsCheck.NUnit.Property]
        public void GivenList_ShouldReturnSameReference(NonNull<List<int>> notNullitems)
        {
            var items = notNullitems.Item;

            var result = items.ConvertToList();

            result.Should().BeSameAs(items);
            result.Should().BeAssignableTo<IList<int>>();
        }
    }
}
