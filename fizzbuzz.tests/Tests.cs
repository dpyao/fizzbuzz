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
            Assert.Equal("1", actual[0]);
            Assert.Equal("Buzz", actual[49]);
            Assert.Equal("Buzz", actual[99]);
            
            Assert.Equal("Fizz", actual[2]);
            Assert.Equal("Fizz", actual[5]);
            Assert.Equal("Fizz", actual[8]);
            
            Assert.Equal("Buzz", actual[4]);
            Assert.Equal("Buzz", actual[9]);
            Assert.Equal("Buzz", actual[14]);
        }
    }
}