using FluentAssertions;
using FsCheck;
using NUnit.Framework;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions.Test
{
    [TestFixture]
    internal sealed class ObjectExtensions_IsNull_Tests
    {
        [Test]
        public void GivenANull_ShouldReturnTrue()
        {
            ((object)null).IsNull().Should().BeTrue();
        }

        [FsCheck.NUnit.Property]
        public void GivenANonNull_ShouldReturnFalse(NonNull<object> nonNullObject)
        {
            var @object = nonNullObject.Item;

            @object.IsNull().Should().BeFalse();
        }
    }
}
