using FluentAssertions;
using NUnit.Framework;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions.Test
{

    [TestFixture]
    internal sealed class NullableExtensions_Else_Tests
    {
        [FsCheck.NUnit.Property]
        public void GivenANull_ShouldReturnAlternative(int? alternative)
        {
            ((int?)null).Else(alternative).Should().Be(alternative);
            ((int?)null).Else(() => alternative).Should().Be(alternative);
        }

        [FsCheck.NUnit.Property]
        public void GivenANonNull_ShouldReturnOriginal(int? originalValue, int? alternative)
        {
            if (originalValue == null)
            {
                return;
            }

            originalValue.Else(alternative).Should().Be(originalValue);
            originalValue.Else(() => alternative).Should().Be(originalValue);
        }
    }
}
