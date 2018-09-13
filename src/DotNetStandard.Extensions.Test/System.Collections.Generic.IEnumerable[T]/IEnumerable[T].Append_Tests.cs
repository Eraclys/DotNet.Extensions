using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using FsCheck;
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
        public void GivenNonNull_ShouldReturnOriginalPlusItemAtTheEndOfTheCollection(NonNull<List<object>> notNullitems, object item)
        {
            var items = notNullitems.Item;

            var result = items.Append(item);

            result.Should().BeEquivalentTo(items.Concat(new []{item}));
        }
    }
}