using FluentAssertions;
using FsCheck;
using NUnit.Framework;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions.Test
{
    [TestFixture]
    internal sealed class ObjectExtensions_IsNot_Tests
    {
        [Test]
        public void GivenANull_ShouldReturnFalse()
        {
            ((object)null).IsNotNull().Should().BeFalse();
        }

        [FsCheck.NUnit.Property]
        public void GivenANonNull_ShouldReturnTrue(NonNull<object> nonNullObject)
        {
            var @object = nonNullObject.Item;

            @object.IsNotNull().Should().BeTrue();
        }
    }
}
