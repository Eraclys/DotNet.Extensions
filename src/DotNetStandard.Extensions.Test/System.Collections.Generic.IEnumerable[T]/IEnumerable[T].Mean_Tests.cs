using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions.Test
{
    [TestFixture]
    internal sealed class EnumerableExtensions_Mean_Tests
    {
        [Test]
        public void WhenSourceIsNull_ShouldThrowException()
        {
            Assert.Throws<ArgumentNullException>(() => ((IEnumerable<int>)null).Mean());
            Assert.Throws<ArgumentNullException>(() => ((IEnumerable<long>)null).Mean());
            Assert.Throws<ArgumentNullException>(() => ((IEnumerable<float>)null).Mean());
            Assert.Throws<ArgumentNullException>(() => ((IEnumerable<double>)null).Mean());
            Assert.Throws<ArgumentNullException>(() => ((IEnumerable<decimal>)null).Mean());
        }

        [Test]
        public void WhenSourceIsEmpty_ShouldThrowException()
        {
            Assert.Throws<InvalidOperationException>(() => Enumerable.Empty<int>().Mean());
            Assert.Throws<InvalidOperationException>(() => Enumerable.Empty<long>().Mean());
            Assert.Throws<InvalidOperationException>(() => Enumerable.Empty<float>().Mean());
            Assert.Throws<InvalidOperationException>(() => Enumerable.Empty<double>().Mean());
            Assert.Throws<InvalidOperationException>(() => Enumerable.Empty<decimal>().Mean());
        }

        [Test]
        public void WhenSourceHasValues_ShouldReturnMean()
        {
            new int[] {2, 7, 9}.Mean().Should().Be(6);
            new long[] { 2, 7, 9 }.Mean().Should().Be(6);
            new float[] { 2, 7, 9 }.Mean().Should().Be(6);
            new double[] { 2, 7, 9 }.Mean().Should().Be(6);
            new decimal[] { 2, 7, 9 }.Mean().Should().Be(6);
        }
    }
}
