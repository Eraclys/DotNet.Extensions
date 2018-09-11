using FluentAssertions;
using NUnit.Framework;

// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions.Test
{
    [TestFixture]
    internal sealed class NullableExtensions_IfHasValueThenDo_Tests
    {
        [Test]
        public void GivenANull_ShouldNotCallAction()
        {
            var callCount = 0;

            ((int?)null).IfHasValueThenDo(v => callCount++);

            callCount.Should().Be(0);
        }

        [Test]
        public void GivenANonNull_ShouldCallAction()
        {
            var callCount = 0;

            int? nullableStruct = 1;
            var value = 0;

            nullableStruct.IfHasValueThenDo(v =>
            {
                value = v;
                callCount++;
            });

            value.Should().Be(nullableStruct.Value);
            callCount.Should().Be(1);
        }
    }
}
