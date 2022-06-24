using System;
using Xunit;
using UnitTestingExercise.Tests;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(7, 4, 8, 19)]
        [InlineData(6, 6, 6, 18)]
        [InlineData(1, 0, 1, 2)]
        [InlineData(15, 21, 25, 61)]
        //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var test = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = test.Add(num1, num2, num3);

            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(7, 7, 0)]
        [InlineData(4, 0, 4)]
        [InlineData(6, 2, 4)]
        [InlineData(15, 8, 7)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test = new Calculator();

            //Act
            var actual = test.Subtract(minuend, subtrahend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 3, 6)]
        [InlineData(5, 0, 0)]
        [InlineData(2, 6, 12)]
        [InlineData(15, 4, 60)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test = new Calculator();
            //Act
            var actual = test.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 0, 0)]
        [InlineData(6, 3, 2)]
        [InlineData(7, 2, 3)]
        [InlineData(18, 6, 3)]
        [InlineData(25, 5, 5)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var test = new Calculator();
            //Act
            var actual = test.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
