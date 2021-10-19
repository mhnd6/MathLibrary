using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MathLibrary.Test
{
    public class OperationTests
    {
        [Theory]
        [InlineData(2,2,4)]
        [InlineData(2, 5, 7)]
        [InlineData(10, 2, 12)]
        [InlineData(200, 2, 202)]
        public void AdditionTest(int number1, int number2, int expected)
        {
            Operations operations = new Operations();

            int actual = operations.Addition(number1, number2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubstractionTest()
        {
            Operations operations = new Operations();
            int expected = 0;

            int actual = operations.Substraction(2, 2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MultipluctonTest()
        {
            Operations operations = new Operations();
            int expected = 2;

            int actual = operations.Multipluction(1, 2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivitionTest()
        {
            Operations operations = new Operations();
            double expected = 2;

            double actual = operations.Divition(4, 2);

            Assert.Equal(expected, actual);
        }
    }
}
