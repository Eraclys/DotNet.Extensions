using System.Collections.Generic;
using FluentAssertions;
using FsCheck;
using NUnit.Framework;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions.Test
{
    [TestFixture]
    internal sealed class EnumerableExtensions_ElseEmpty_Tests
    {
        [Test]
        public void GivenNull_ShouldReturnEmptyEnumerable()
        {
            var result = ((IEnumerable<int>)null).ElseEmpty();

            result.Should().NotBeNull();
            result.Should().BeEmpty();
        }

        [FsCheck.NUnit.Property]
        public void GivenNonNull_ShouldReturnOriginal(NonNull<List<int>> notNullitems)
        {
            var items = notNullitems.Item;

            var result = items.ElseEmpty();

            result.Should().BeSameAs(items);
        }
    }
}
