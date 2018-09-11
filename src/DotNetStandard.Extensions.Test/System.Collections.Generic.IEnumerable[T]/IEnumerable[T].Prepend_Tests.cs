using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
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
        public void GivenNonNull_ShouldReturnOriginalPlusItemAtTheBeginningOfTheCollection(List<object> items, object item)
        {
            if (items == null)
            {
                return;
            }

            var result = items.Prepend(item);

            result.Should().BeEquivalentTo(new[] { item }.Concat(items));
        }
    }
}
