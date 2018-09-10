using System;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetExtensions.Test.System
{
    [TestFixture]
    internal sealed class NullExtensions_IfNotNull_Tests
    {
        [Test]
        public void GivenANullObject_ShouldReturnDefaultOfReturnType()
        {
            var @object = (MockClass) null;

            @object.IfNotNull(v => v.ObjectProperty).Should().Be(default(object));
            @object.IfNotNull(v => v.IntProperty).Should().Be(default(int));
            @object.IfNotNull(v => v.LongProperty).Should().Be(default(long));
            @object.IfNotNull(v => v.DateTimeProperty).Should().Be(default(DateTime));
        }

        [FsCheck.NUnit.Property]
        public void GivenANonNullObject_ShouldReturnSelectedValue(
            object objectValue,
            int intValue,
            long longValue,
            DateTime dateTimeValue)
        {
            var @object = new MockClass
            {
                ObjectProperty = objectValue,
                LongProperty = longValue,
                IntProperty = intValue,
                DateTimeProperty = dateTimeValue
            };

            @object.IfNotNull(v => v.ObjectProperty).Should().Be(objectValue);
            @object.IfNotNull(v => v.LongProperty).Should().Be(longValue);
            @object.IfNotNull(v => v.IntProperty).Should().Be(intValue);
            @object.IfNotNull(v => v.DateTimeProperty).Should().Be(dateTimeValue);
        }

        [Test]
        public void GivenANullNullableStruct_ShouldReturnDefaultOfReturnType()
        {
            var @object = (MockStruct?)null;

            @object.IfNotNull(v => v.ObjectProperty).Should().Be(default(object));
            @object.IfNotNull(v => v.IntProperty).Should().Be(default(int));
            @object.IfNotNull(v => v.LongProperty).Should().Be(default(long));
            @object.IfNotNull(v => v.DateTimeProperty).Should().Be(default(DateTime));
        }

        [FsCheck.NUnit.Property]
        public void GivenANonNullNullableStruct_ShouldReturnSelectedValue(
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

        private class MockClass
        {
            public int IntProperty { get; set; }
            public long LongProperty { get; set; }
            public object ObjectProperty { get; set; }
            public DateTime DateTimeProperty { get; set; }
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