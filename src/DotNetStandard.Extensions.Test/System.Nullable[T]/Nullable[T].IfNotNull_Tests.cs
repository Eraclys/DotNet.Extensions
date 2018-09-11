using System;
using FluentAssertions;
using NUnit.Framework;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions.Test
{
    [TestFixture]
    internal sealed class NullableExtensions_IfNotNull_Tests
    {
        [Test]
        public void GivenANull_ShouldReturnDefaultOfReturnType()
        {
            var @object = (MockStruct?)null;

            @object.IfNotNull(v => v.ObjectProperty).Should().Be(default(object));
            @object.IfNotNull(v => v.IntProperty).Should().Be(default(int));
            @object.IfNotNull(v => v.LongProperty).Should().Be(default(long));
            @object.IfNotNull(v => v.DateTimeProperty).Should().Be(default(DateTime));
        }

        [FsCheck.NUnit.Property]
        public void GivenANonNull_ShouldReturnSelectedValue(
            object objectValue,
            int intValue,
            long longValue,
            DateTime dateTimeValue)
        {
            MockStruct? nullableStruct = new MockStruct
            {
                ObjectProperty = objectValue,
                LongProperty = longValue,
                IntProperty = intValue,
                DateTimeProperty = dateTimeValue
            };

            nullableStruct.IfNotNull(v => v.ObjectProperty).Should().Be(objectValue);
            nullableStruct.IfNotNull(v => v.LongProperty).Should().Be(longValue);
            nullableStruct.IfNotNull(v => v.IntProperty).Should().Be(intValue);
            nullableStruct.IfNotNull(v => v.DateTimeProperty).Should().Be(dateTimeValue);
        }

        private struct MockStruct
        {
            public int IntProperty { get; set; }
            public long LongProperty { get; set; }
            public object ObjectProperty { get; set; }
            public DateTime DateTimeProperty { get; set; }
        }
    }
}
