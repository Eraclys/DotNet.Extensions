using System.Collections.Generic;
using DotNetExtensions.System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetExtensions.Test.System.Collections.Generic
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
        public void GivenNonList_ShouldReturnNewList(Dictionary<int, string> items)
        {
            if (items == null)
            {
                return;
            }

            var result = items.ConvertToList();

            result.Should().NotBeSameAs(items);
            result.Should().BeAssignableTo<IList<KeyValuePair<int, string>>>();
        }

        [FsCheck.NUnit.Property]
        public void GivenList_ShouldReturnSameReference(List<int> items)
        {
            if (items == null)
            {
                return;
            }

            var result = items.ConvertToList();

            result.Should().BeSameAs(items);
            result.Should().BeAssignableTo<IList<int>>();
        }
    }
}
