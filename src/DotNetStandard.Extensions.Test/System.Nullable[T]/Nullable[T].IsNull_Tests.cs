using FluentAssertions;
using NUnit.Framework;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions.Test
{
    [TestFixture]
    internal sealed class NullableExtensions_IsNull_Tests
    {
        [Test]
        public void GivenANull_ShouldReturnTrue()
        {
            ((int?)null).IsNull().Should().BeTrue();
        }

        [FsCheck.NUnit.Property]
        public void GivenANonNull_ShouldReturnFalse(int? value)
        {
            if (value == null)
            {
                return;
            }

            value.IsNull().Should().BeFalse();
        }
    }
}
