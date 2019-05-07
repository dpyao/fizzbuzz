using System;
using Xunit;

namespace fizzbuzz.tests
{
    public class Tests
    {
        [Fact]
        public void ShouldReturnNumber()
        {
            var program = new Program();
            var actual = Program.GetPrintedList();

            Assert.Equal(100, actual.Count);
            Assert.Equal("1", actual[0]);
            Assert.Equal("2", actual[1]);
            Assert.Equal("4", actual[3]);
            Assert.Equal("7", actual[6]);
        }

        [Fact]
        public void ShouldReturnFizzIfTheNumberIsDivisibleByThreeOrItHasThree()
        {
            var program = new Program();
            var actual = Program.GetPrintedList();
            
            Assert.Equal("Fizz", actual[2]);
            Assert.Equal("Fizz", actual[5]);
            Assert.Equal("Fizz", actual[8]);
            Assert.Equal("Fizz", actual[11]);
            Assert.Equal("Fizz", actual[17]);
            Assert.Equal("Fizz", actual[12]);
            Assert.Equal("Fizz", actual[22]);
            Assert.Equal("Fizz", actual[32]);
            Assert.Equal("Fizz", actual[42]);
        }
        
        [Fact]
        public void ShouldReturnBuzzIfTheNumberIsDivisibleByFiveOrItHasFive()
        {
            var program = new Program();
            var actual = Program.GetPrintedList();
            
            Assert.Equal("Buzz", actual[4]);
            Assert.Equal("Buzz", actual[9]);
            Assert.Equal("Buzz", actual[19]);
            Assert.Equal("Buzz", actual[24]);
            Assert.Equal("Buzz", actual[49]);
            Assert.Equal("Buzz", actual[99]);
//            Assert.Equal("Buzz", actual[51]); -- what should be printed if a number is divisible by 3 and it has 5?
            Assert.Equal("Buzz", actual[55]);
            Assert.Equal("Buzz", actual[57]);
            Assert.Equal("Buzz", actual[58]);
        }
        
        [Fact]
        public void ShouldReturnFizzBuzzIfTheNumberIsDivisibleByThreeAndFive()
        {
            var program = new Program();
            var actual = Program.GetPrintedList();
            
            Assert.Equal("FizzBuzz", actual[14]);
            Assert.Equal("FizzBuzz", actual[29]);
            Assert.Equal("FizzBuzz", actual[44]);
            Assert.Equal("FizzBuzz", actual[59]);
        }
    }
}