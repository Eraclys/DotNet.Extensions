using DotNet.Extensions.System;
using FluentAssertions;
using NUnit.Framework;

namespace DotNet.Extensions.Test.System
{
    [TestFixture]
    internal sealed class ComparableExtensions_WithMaxValueOf_Tests
    {
        [Test]
        public void WhenValueIsBelowMaxValue_ReturnValue()
        {
            15.WithMaxValueOf(19).Should().Be(15);
            (-999).WithMaxValueOf(-666).Should().Be(-999);
        }

        [Test]
        public void WhenValueIsAboveMaxValue_ReturnMaxValue()
        {
            25.WithMaxValueOf(17).Should().Be(17);
            (-875).WithMaxValueOf(-9879).Should().Be(-9879);
        }
    }
}
