using DotNetStandard.Extensions.System;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetStandard.Extensions.Test.System
{
    [TestFixture]
    internal sealed class NullExtensions_Else_Tests
    {
        [FsCheck.NUnit.Property]
        public void GivenANullObject_ShouldReturnAlternative(object alternative)
        {
            ((object)null).Else(alternative).Should().Be(alternative);
            ((object)null).Else(() => alternative).Should().Be(alternative);
        }

        [FsCheck.NUnit.Property]
        public void GivenANonNullObject_ShouldReturnOriginal(object originalValue, object alternative)
        {
            if (originalValue == null)
            {
                return;
            }

            originalValue.Else(alternative).Should().Be(originalValue);
            originalValue.Else(() => alternative).Should().Be(originalValue);
        }

        [FsCheck.NUnit.Property]
        public void GivenANullNullableStruct_ShouldReturnAlternative(int? alternative)
        {
            ((int?)null).Else(alternative).Should().Be(alternative);
            ((int?)null).Else(() => alternative).Should().Be(alternative);
        }

        [FsCheck.NUnit.Property]
        public void GivenANonNullNullableStruct_ShouldReturnOriginal(int? originalValue, int? alternative)
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