using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetExtensions.Test
{
    [TestFixture]
    internal sealed class EnumerableExtensions_ForEach_Tests
    {
        [Test]
        public void GivenNull_ShouldNotCallAction()
        {
            var items = (IEnumerable<int>) null;
            var callCount = 0;

            items.ForEach(v => callCount++);

            callCount.Should().Be(0);
        }

        [Test]
        public void GivenEmptyEnumerable_ShouldNotCallAction()
        {
            var items = Enumerable.Empty<int>();
            var callCount = 0;

            items.ForEach(v => callCount++);

            callCount.Should().Be(0);
        }

        [Test]
        public void GivenPopulatedEnumerable_ShouldCallAction()
        {
            var items = Enumerable.Range(0, 10).ToArray();

            var callCount = 0;

            items.ForEach(v =>
            {
                v.Should().Be(items[callCount]);
                callCount++;
            });

            callCount.Should().Be(items.Length);
        }
    }

    [TestFixture]
    internal sealed class EnumerableExtensions_ForEachWithIndex_Tests
    {
        [Test]
        public void GivenNull_ShouldNotCallAction()
        {
            var items = (IEnumerable<int>)null;
            var callCount = 0;

            items.ForEach((i, v) => callCount++);

            callCount.Should().Be(0);
        }

        [Test]
        public void GivenEmptyEnumerable_ShouldNotCallAction()
        {
            var items = Enumerable.Empty<int>();
            var callCount = 0;

            items.ForEach((i,v) => callCount++);

            callCount.Should().Be(0);
        }

        [Test]
        public void GivenPopulatedEnumerable_ShouldCallAction()
        {
            var items = Enumerable.Range(0, 10).ToArray();

            var callCount = 0;

            items.ForEach((i,v) =>
            {
                i.Should().Be(callCount);
                v.Should().Be(items[callCount]);
                callCount++;
            });

            callCount.Should().Be(items.Length);
        }
    }
}
