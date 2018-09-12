using System;
using FluentAssertions;
using NUnit.Framework;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions.Test
{
    [TestFixture]
    internal sealed class ArrayExtensions_Slice_Tests
    {
        [FsCheck.NUnit.Property]
        public void WhenANull_ShouldReturnEmptyArray(int index)
        {
            var fromIndex = Math.Abs(index);

            ((int[]) null).Slice(fromIndex).Should().BeEmpty();
        }

        [FsCheck.NUnit.Property]
        public void WhenFromIndexIsNegative_ShouldThrowException(int[] array, int index)
        {
            var fromIndex = (-Math.Abs(index)).WithMaxValueOf(-1);

            Assert.Throws<ArgumentException>(() => { array.Slice(fromIndex); });
        }

        [FsCheck.NUnit.Property]
        public void WhenFromIndexIsGreaterThanToIndex_ShouldThrowException(int[] array, int index)
        {
            var fromIndex = Math.Abs(index);
            var toIndex = fromIndex - 1;

            Assert.Throws<ArgumentException>(() => { array.Slice(fromIndex, toIndex); });
        }

        [Test]
        public void ShouldReturnSubsetOfArray()
        {
            new[] {'a', 'b', 'c', 'd'}.Slice(0, 2).Should().BeEquivalentTo(new[] {'a', 'b'});
            new[] {'a', 'b', 'c', 'd'}.Slice(1, 3).Should().BeEquivalentTo(new[] {'b', 'c'});
            new[] {'a', 'b', 'c', 'd'}.Slice(1).Should().BeEquivalentTo(new[] {'b', 'c', 'd'});
            new[] {'a', 'b', 'c', 'd'}.Slice(0).Should().BeEquivalentTo(new[] {'a', 'b', 'c', 'd'});
        }
    }
}
