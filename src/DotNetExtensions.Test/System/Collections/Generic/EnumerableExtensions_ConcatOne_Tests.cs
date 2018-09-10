using System;
using System.Collections.Generic;
using System.Linq;
using DotNetExtensions.System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetExtensions.Test.System.Collections.Generic
{
    [TestFixture]
    internal sealed class EnumerableExtensions_ConcatOne_Tests
    {
        [FsCheck.NUnit.Property]
        public void GivenNull_ShouldThrowException(int? concatValue)
        {
            Assert.Throws<ArgumentNullException>(() => { ((IEnumerable<int?>) null).ConcatOne(concatValue); });
        }

        [FsCheck.NUnit.Property]
        public void GivenNonNull_ShouldReturnOriginal(List<int?> items, int? item)
        {
            if (items == null)
            {
                return;
            }

            var result = items.ConcatOne(item);

            result.Should().BeEquivalentTo(items.Concat(new []{item}));
        }
    }
}