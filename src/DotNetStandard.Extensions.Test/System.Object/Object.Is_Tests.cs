using System;
using FluentAssertions;
using NUnit.Framework;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions.Test
{
    [TestFixture]
    internal sealed class ObjectExtensions_Is_Tests
    {
        [Test]
        public void WhenValueIsNull_ShouldReturnFalse()
        {
            ((object)null).Is<object>().Should().BeFalse();
            ((DateTime?)null).Is<DateTime>().Should().BeFalse();
            ((int?)null).Is<int>().Should().BeFalse();
            ((A)null).Is<A>().Should().BeFalse();
            ((B)null).Is<B>().Should().BeFalse();
            ((C)null).Is<C>().Should().BeFalse();
        }

        [Test]
        public void WhenValueIsNotExactType_ShouldReturnFalse()
        {
            new A().Is<B>().Should().BeFalse();
            new A().Is<C>().Should().BeFalse();
            new B().Is<A>().Should().BeFalse();
            new B().Is<C>().Should().BeFalse();
            new C().Is<A>().Should().BeFalse();
            new C().Is<B>().Should().BeFalse();
        }

        [Test]
        public void WhenValueIsExactType_ShouldReturnTrue()
        {
            new A().Is<A>().Should().BeTrue();
            new B().Is<B>().Should().BeTrue();
            new B().CastTo<A>().Is<B>().Should().BeTrue();
            new C().Is<C>().Should().BeTrue();
            new C().CastTo<A>().Is<C>().Should().BeTrue();
            new C().CastTo<B>().Is<C>().Should().BeTrue();
        }

        private class A { }
        private class B : A { }
        private class C : B { }
    }
}
