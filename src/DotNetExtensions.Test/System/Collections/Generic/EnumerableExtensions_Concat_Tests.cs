using System;
using System.Collections.Generic;
using System.Linq;
using DotNetExtensions.System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetExtensions.Test.System.Collections.Generic
{
    [TestFixture]
    internal sealed class EnumerableExtensions_Concat_Tests
    {
        [FsCheck.NUnit.Property]
        public void GivenNull_Append_ShouldThrowException(object concatValue)
        {
            Assert.Throws<ArgumentNullException>(() => { ((IEnumerable<object>) null).Append(concatValue).ToList(); });
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
            Assert.Throws<ArgumentNullException>(() => { ((IEnumerable<object>)null).Prepend(concatValue).ToList(); });
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