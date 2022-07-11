using StringLengthCounter;
using System;
using Xunit;

namespace TextTesting
{
    public class UnitTest1
    {
        LengthHelper value = new LengthHelper();
        [Fact]
        public Boolean   Test1()
        {
            int  check=value.findLength("prasanna");
            return check.Equals(8);
        }
       

        [Fact]
        public void Check_Value()
        {
            Assert.Equal(8, value.findLength("prasanna"));
        }

        [Fact]
        public void  checked_length()
        {
            Assert.Equal(3, value.findLength("123"));

        }

        [Fact]
        public void checked_length_null()
        {
            Assert.Equal(0, value.findLength(null));

        }

        [Theory]
        [InlineData("")]
        public void Inline_value(string text)
        {
            Assert.Equal(0, value.findLength(text));
        }

        [Fact]
        public void check12345678()
        {
            Assert.Equal("123456789010".Length, value.findLength("123456789010"));

        }

    }
}
