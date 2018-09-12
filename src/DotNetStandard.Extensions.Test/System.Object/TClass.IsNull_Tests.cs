using FluentAssertions;
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
        public void GivenANonNull_ShouldReturnFalse(object value)
        {
            if (value == null)
            {
                return;
            }

            value.IsNull().Should().BeFalse();
        }
    }
}
