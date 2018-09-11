using DotNet.Extensions.System;
using FluentAssertions;
using NUnit.Framework;

namespace DotNet.Extensions.Test.System
{
    [TestFixture]
    internal sealed class NullExtensions_IfNotNullThenDo_Tests
    {
        [Test]
        public void GivenANullObject_ShouldNotCallAction()
        {
            var callCount = 0;

            ((object)null).IfNotNullThenDo(v => callCount++);

            callCount.Should().Be(0);
        }

        [FsCheck.NUnit.Property]
        public void GivenANonNullObject_ShouldCallAction(object @object)
        {
            if (@object == null)
            {
                return;
            }

            var callCount = 0;

            object value = null;

            @object.IfNotNullThenDo(v =>
            {
                value = v;
                callCount++;
            });

            value.Should().Be(@object);
            callCount.Should().Be(1);
        }

        [Test]
        public void GivenANullNullableStruct_ShouldNotCallAction()
        {
            var callCount = 0;

            ((int?)null).IfHasValueThenDo(v => callCount++);

            callCount.Should().Be(0);
        }

        [Test]
        public void GivenANonNullNullableStruct_ShouldCallAction()
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
