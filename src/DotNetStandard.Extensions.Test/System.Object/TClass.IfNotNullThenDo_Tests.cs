using FluentAssertions;
using NUnit.Framework;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions.Test
{
    [TestFixture]
    internal sealed class ObjectExtensions_IfNotNullThenDo_Tests
    {
        [Test]
        public void GivenANull_ShouldNotCallAction()
        {
            var callCount = 0;

            ((object)null).IfNotNullThenDo(v => callCount++);

            callCount.Should().Be(0);
        }

        [FsCheck.NUnit.Property]
        public void GivenANonNull_ShouldCallAction(object @object)
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
    }
}
