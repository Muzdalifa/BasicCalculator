using System;
using Xunit;
using Assignment1_BasicCalculator;

namespace Assigment1_BasicCalculator.Test
{
    public class ProgramTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 0, 2)] 
        [InlineData(7, 3, 10)]
        [InlineData(0, 0, 0)]
        [InlineData(-7, -9, -16)]
        [InlineData(double.MaxValue, -9, double.MaxValue)]
        public void AddTwoNumbersCorrect(double firstNumber, double secondNumber, double expected)
        {
            //Act
            double result = Program.Addition(firstNumber, secondNumber);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 1.9, 3)]
        [InlineData(double.MinValue, -9, double.MinValue)]
        public void AddTwoNumbersIncorrect(double firstNumber, double secondNumber, double expected)
        {
            //Act
            double result = Program.Addition(firstNumber, secondNumber);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 0, 1)]
        [InlineData(0, -9, 9)]
        [InlineData(7, 3, 4)]
        [InlineData(0, 0, 0)]
        [InlineData(-7, -9, 2)]
        [InlineData(double.MaxValue, -9, double.MaxValue)]
        public void SubstractTwoNumbersCorrect(double firstNumber, double secondNumber, double expected)
        {
            //Act
            double result = Program.Substraction(firstNumber, secondNumber);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 0, 0)]
        [InlineData(-7, -9, -16)]
        [InlineData(double.MaxValue, -9, double.MaxValue)]
        public void SubstractTwoNumbersIncorrect(double firstNumber, double secondNumber, double expected)
        {
            //Act
            double result = Program.Substraction(firstNumber, secondNumber);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 0, 0)]
        [InlineData(-7, -9, 63)]
        [InlineData(5, 3, 15)]
        [InlineData(0, 0, 0)]
        [InlineData(-4, 8, -32)]
        public void MultiplyTwoNumbersCorrect(double firstNumber, double secondNumber, double expected)
        {
            //Act
            double result = Program.Multiplication(firstNumber, secondNumber);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 0, 10)]
        [InlineData(-4, 8, 12)]
        [InlineData(-4, 8, 32)]
        [InlineData(double.MaxValue, 9, double.MaxValue)]
        public void MultiplyTwoNumbersIncorrect(double firstNumber, double secondNumber, double expected)
        {
            //Act
            double result = Program.Multiplication(firstNumber, secondNumber);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(50, 50, 1)]
        [InlineData(-8, -4, 2)]
        [InlineData(0, -4, 0)]
        public void DivideTwoNumbersCorrect(double firstNumber, double secondNumber, double expected)
        {
            //Act
            double result = Program.Division(firstNumber, secondNumber);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void DivideByZeroThrowException()
        {
            //Act
            DivideByZeroException result = Assert.Throws<DivideByZeroException>(() => Program.Division(7, 0));

            Assert.Equal("You can not divide by zero.", result.Message);
        }

        [Theory]
        [InlineData((new double[] { 1, 2, 3, 4, 5 }), 15)]
        [InlineData((new double[] { -1, -1 }), -2)]
        [InlineData((new double[] { (-12), (-3), 5, 24 }), 14)]
        [InlineData((new double[] { double.MaxValue, double.MaxValue, double.MaxValue }), double.PositiveInfinity)]
        public void AddArrayCorrect(double[] arrayNumber, double expected)
        {
            //
            //Assert
            Assert.Equal(expected, Program.Addition(arrayNumber));
        }

        [Theory]
        [InlineData(new double[] { 7, 9, 8, 2 }, -12)]
        [InlineData(new double[] { -3, 3 }, -6)]
        [InlineData((new double[] { (-12), (-3), 5, 24 }), -38)]
        public void SubstractArrayCorrect(double[] arrayNumber, double expected)
        {
            //Assert
            Assert.Equal(expected, Program.Substraction(arrayNumber));
        }

    }

}
