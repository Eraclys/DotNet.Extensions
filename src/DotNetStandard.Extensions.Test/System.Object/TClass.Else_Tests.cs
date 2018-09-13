using FluentAssertions;
using FsCheck;
using NUnit.Framework;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions.Test
{
    [TestFixture]
    internal sealed class ObjectExtensions_Else_Tests
    {
        [FsCheck.NUnit.Property]
        public void GivenANull_ShouldReturnAlternative(object alternative)
        {
            ((object)null).Else(alternative).Should().Be(alternative);
            ((object)null).Else(() => alternative).Should().Be(alternative);
        }

        [FsCheck.NUnit.Property]
        public void GivenANonNull_ShouldReturnOriginal(NonNull<object> nonNullOriginalValue, object alternative)
        {
            var originalValue = nonNullOriginalValue.Item;

            originalValue.Else(alternative).Should().Be(originalValue);
            originalValue.Else(() => alternative).Should().Be(originalValue);
        }
    }
}
