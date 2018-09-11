using DotNetStandard.Extensions.System;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetStandard.Extensions.Test.System
{
    [TestFixture]
    internal sealed class ComparableExtensions_WithMinValueOf_Tests
    {
        [Test]
        public void WhenValueIsBelowMinValue_ReturnMinValue()
        {
            14.WithMinValueOf(20).Should().Be(20);
            (-888).WithMinValueOf(-555).Should().Be(-555);
        }

        [Test]
        public void WhenValueIsAboveMinValue_ReturnValue()
        {
            33.WithMinValueOf(12).Should().Be(33);
            (-7895).WithMinValueOf(-89879).Should().Be(-7895);
        }
    }
}