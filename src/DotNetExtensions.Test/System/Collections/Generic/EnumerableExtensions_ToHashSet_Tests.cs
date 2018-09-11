using System.Collections.Generic;
using System.Linq;
using DotNetExtensions.System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetExtensions.Test.System.Collections.Generic
{
    [TestFixture]
    internal sealed class EnumerableExtensions_ToHashSet_Tests
    {
        [Test]
        public void GivenANullCollection_ShouldReturnAnEmptyHashSet()
        {
            var actual = ((List<int>)null).ToHashSet();

            actual.Should().BeEmpty();
            actual.Should().BeOfType<HashSet<int>>();
        }

        [Test]
        public void GivenAnEmptyCollection_ShouldReturnAnEmptyHashSet()
        {
            var actual = Enumerable.Empty<long>().ToHashSet();

            actual.Should().BeEmpty();
            actual.Should().BeOfType<HashSet<long>>();
        }

        [Test]
        public void GivenAPopulatedCollection_ShouldReturnAnHashSet()
        {
            var original = new[] { 1, 2, 2, 3, 3, 3, 4, 4, 4 };
            var actual = original.ToHashSet();
            var expected = new[] {1, 2, 3, 4};

            actual.Should().BeOfType<HashSet<int>>();
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
