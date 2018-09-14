using System;
using FluentAssertions;
using FsCheck;
using NUnit.Framework;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions.Test
{
    [TestFixture]
    internal sealed class ObjectExtensions_IsDefault_Tests
    {
        [Test]
        public void WhenDefaultValue_ShouldReturnTrue()
        {
            default(object).IsDefault().Should().BeTrue();
            default(DateTime).IsDefault().Should().BeTrue();
            default(int?).IsDefault().Should().BeTrue();
            default(int).IsDefault().Should().BeTrue();
        }

        [Test]
        public void WhenNotDefaultValue_ShouldReturnFalse()
        {
            new object().IsDefault().Should().BeFalse();
            DateTime.Now.IsDefault().Should().BeFalse();
            ((int?)5).IsDefault().Should().BeFalse();
            5.IsDefault().Should().BeFalse();
        }
    }
}
