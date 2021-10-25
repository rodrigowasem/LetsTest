using LetsUnit.Domain;
using System;
using Xunit;

namespace LetsUnit.UnitTests
{
    public class FizzBuzzUnitTests
    {
        private FizzBuzz sut;
        public FizzBuzzUnitTests()
        {
            sut = new FizzBuzz();
        }
        [Fact]
        public void FizzBuzz_Of3_ReturnsFizz()
        {
            var expected = "Fizz";
            var actual = sut.Of(3);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FizzBuzz_Of5_ReturnsBuzz()
        {
            var expected = "Buzz";
            var actual = sut.Of(5);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FizzBuzz_Of3And5_ReturnsFizzBuzz()
        {
            var expected = "FizzBuzz";
            var actual = sut.Of(15);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FizzBuzz_Of0_ReturnsFizzBuzz()
        {
            var expected = "FizzBuzz";
            var actual = sut.Of(0);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FizzBuzz_Of_Any_ReturnsAny()
        {
            var expected = "7";
            var actual = sut.Of(7);
            Assert.Equal(expected, actual);
        }
    }
}
