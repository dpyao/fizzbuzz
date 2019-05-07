using System;
using Xunit;

namespace fizzbuzz.tests
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            var program = new Program();
            var actual = program.getPrintedList();

            Assert.Equal(100, actual.Count);
            Assert.Equal(1, actual[0]);
            Assert.Equal(50, actual[49]);
            Assert.Equal(100, actual[99]);
        }
    }
}