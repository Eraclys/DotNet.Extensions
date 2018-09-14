using FluentAssertions;
using NUnit.Framework;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions.Test
{
    [TestFixture]
    internal sealed class NullableExtensions_IsNotNull_Tests
    {
        [Test]
        public void GivenANull_ShouldReturnFalse()
        {
            ((int?)null).IsNotNull().Should().BeFalse();
        }

        [FsCheck.NUnit.Property]
        public void GivenANonNull_ShouldReturnTrue(int? value)
        {
            if (value == null)
            {
                return;
            }

            value.IsNotNull().Should().BeTrue();
        }
    }
}
