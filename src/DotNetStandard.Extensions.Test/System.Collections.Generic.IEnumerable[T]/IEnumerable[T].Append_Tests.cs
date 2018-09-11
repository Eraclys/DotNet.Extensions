using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions.Test
{
    [TestFixture]
    internal sealed class EnumerableExtensions_Append_Tests
    {
        [FsCheck.NUnit.Property]
        public void GivenNull_ShouldReturnArrayWithConcatenatedItem(object concatValue)
        {
            var result = ((IEnumerable<object>)null).Append(concatValue);

            result.Should().BeEquivalentTo(new[] { concatValue });
        }

        [FsCheck.NUnit.Property]
        public void GivenNonNull_ShouldReturnOriginalPlusItemAtTheEndOfTheCollection(List<object> items, object item)
        {
            if (items == null)
            {
                return;
            }

            var result = items.Append(item);

            result.Should().BeEquivalentTo(items.Concat(new []{item}));
        }
    }
}