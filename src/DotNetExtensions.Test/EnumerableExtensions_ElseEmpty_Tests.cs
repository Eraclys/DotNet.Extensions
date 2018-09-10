using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetExtensions.Test
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
        public void GivenNonNull_ShouldReturnOriginal(List<int> items)
        {
            if (items == null)
            {
                return;
            }

            var result = items.ElseEmpty();

            result.Should().BeSameAs(items);
        }
    }
}
