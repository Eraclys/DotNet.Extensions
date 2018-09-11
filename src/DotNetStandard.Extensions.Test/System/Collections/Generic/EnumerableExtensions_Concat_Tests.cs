using System;
using System.Collections.Generic;
using System.Linq;
using DotNetStandard.Extensions.System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetStandard.Extensions.Test.System.Collections.Generic
{
    [TestFixture]
    internal sealed class EnumerableExtensions_Concat_Tests
    {
        [FsCheck.NUnit.Property]
        public void GivenNull_Append_ShouldReturnArrayWithConcatenatedItem(object concatValue)
        {
            var result = ((IEnumerable<object>)null).Append(concatValue);

            result.Should().BeEquivalentTo(new[] { concatValue });
        }

        [FsCheck.NUnit.Property]
        public void GivenNonNull_Append_ShouldReturnOriginalPlusItemAtTheEndOfTheCollection(List<object> items, object item)
        {
            if (items == null)
            {
                return;
            }

            var result = items.Append(item);

            result.Should().BeEquivalentTo(items.Concat(new []{item}));
        }

        [FsCheck.NUnit.Property]
        public void GivenNull_Prepend_ShouldThrowException(object concatValue)
        {
            var result = ((IEnumerable<object>)null).Prepend(concatValue);

            result.Should().BeEquivalentTo(new[] { concatValue });
        }

        [FsCheck.NUnit.Property]
        public void GivenNonNull_Prepend_ShouldReturnOriginalPlusItemAtTheBeginningOfTheCollection(List<object> items, object item)
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