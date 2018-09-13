using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using FsCheck;
using NUnit.Framework;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions.Test
{
    [TestFixture]
    internal sealed class EnumerableExtensions_Prepend_Tests
    {
        [FsCheck.NUnit.Property]
        public void GivenNull_ShouldThrowException(object concatValue)
        {
            var result = ((IEnumerable<object>)null).Prepend(concatValue);

            result.Should().BeEquivalentTo(new[] { concatValue });
        }

        [FsCheck.NUnit.Property]
        public void GivenNonNull_ShouldReturnOriginalPlusItemAtTheBeginningOfTheCollection(NonNull<List<object>> nonNullItems, object item)
        {
            var items = nonNullItems.Item;

            var result = items.Prepend(item);

            result.Should().BeEquivalentTo(new[] { item }.Concat(items));
        }
    }
}
