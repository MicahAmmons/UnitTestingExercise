using UnitTestingExercise;
using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(4, 7, 1, 12)]
        [InlineData(6, 5, 9, 20)]
        [InlineData(12, 55, 100, 167)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            Calculator instance = new Calculator();
            //Act
            int actual = instance.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(100, 100, 0)]
        [InlineData(300, 100, 200)]
        [InlineData(50, 10, 40)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            Calculator instance = new Calculator();
            //Act
            int actual = instance.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 5, 10)]
        [InlineData(0, 500, 0)]
        [InlineData(5, 40, 200)]
        [InlineData(50, 10, 500)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            Calculator instance = new Calculator();
            //Act
            int actual = instance.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(1000, 500, 2)]
        [InlineData(1000, 5, 200)]
        [InlineData(2500, 5, 500)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            Calculator instance = new Calculator();
            //Act
            int actual = instance.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        //[InlineData(10, 5, 1.5)]
        //[InlineData(20, 20, 2)]
        //[InlineData(5, 20, 5)]
        //[InlineData(16, 14, 1.875)]
        public void AddFactTest()
        {
            //Arrange
 
            //Act
            var actual = Calculator.AddFact(3, 5);
            //Assert
            Assert.Equal(8, actual);
        }
        [Fact]
        public void SubtractFactTest()
        {
            //Arrange

            //Act
            var actual = Calculator.SubtractFact(10, 5);
            //Assert
            Assert.Equal(5, actual);
        }


    }

}

