using System;
using System.Collections.Generic;
using System.Linq;
using DotNetExtensions.System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetExtensions.Test.System.Collections.Generic
{
    [TestFixture]
    internal sealed class EnumerableExtensions_Shuffle_Tests
    {
        [Test]
        public void GivenANullCollection_ShouldReturnAnEmptyArray()
        {
            var shuffled = ((List<int>)null).Shuffle();

            shuffled.Should().BeEmpty();
        }

        [Test]
        public void GivenAnEmptyCollection_ShouldReturnAnEmptyArray()
        {
            var shuffled = Enumerable.Empty<long>().Shuffle();

            shuffled.Should().BeEmpty();
        }

        [Test]
        public void GivenAPopulatedCollection_ShouldReturnANewShuffledArray()
        {
            var original = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var shuffled = original.Shuffle();

            Console.WriteLine($"original: {string.Join(",", original)}");
            Console.WriteLine($"shuffled: {string.Join(",", shuffled)}");

            shuffled.Should().BeEquivalentTo(original);
            shuffled.Should().NotBeAscendingInOrder();
        }
    }
}
