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
            var actual = program.GetPrintedList();

            Assert.Equal(100, actual.Count);
            Assert.Equal("1", actual[0]);
            Assert.Equal("2", actual[1]);
            Assert.Equal("4", actual[3]);
            Assert.Equal("7", actual[6]);

            Assert.Equal("Fizz", actual[2]);
            Assert.Equal("Fizz", actual[5]);
            Assert.Equal("Fizz", actual[8]);
            Assert.Equal("Fizz", actual[11]);
            Assert.Equal("Fizz", actual[17]);
            
            Assert.Equal("Buzz", actual[4]);
            Assert.Equal("Buzz", actual[9]);
            Assert.Equal("Buzz", actual[19]);
            Assert.Equal("Buzz", actual[24]);
            Assert.Equal("Buzz", actual[49]);
            Assert.Equal("Buzz", actual[99]);
            
            Assert.Equal("FizzBuzz", actual[14]);
            Assert.Equal("FizzBuzz", actual[29]);
            Assert.Equal("FizzBuzz", actual[44]);
            Assert.Equal("FizzBuzz", actual[59]);
        }
    }
}