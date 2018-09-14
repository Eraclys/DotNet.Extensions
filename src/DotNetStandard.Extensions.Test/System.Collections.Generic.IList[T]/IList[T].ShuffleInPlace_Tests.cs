using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions.Test
{
    [TestFixture]
    internal sealed class ListExtensions_ShuffleInPlace_Tests
    {
        [Test]
        public void WhenNullSource_ThrowException()
        {
            Assert.Throws<NullReferenceException>(() => ((IList<int>) null).ShuffleInPlace());
        }

        [Test]
        public void WhenEmptySource_ShouldBeUnchanged()
        {
            var array = new long[0];
            array.ShuffleInPlace();

            array.Should().BeEmpty();
        }

        [Test]
        public void GivenAPopulatedCollection_ShouldShuffleTheArray()
        {
            var original = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            original.ShuffleInPlace();

            Console.WriteLine($"shuffled: {string.Join(",", original)}");

            original.Should().NotBeAscendingInOrder();
        }
    }
}
