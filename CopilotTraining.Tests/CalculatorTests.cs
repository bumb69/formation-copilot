using System;
using Xunit;
using CopilotTraining.Ex1;

namespace CopilotTraining.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Sum_Null_ReturnsZero()
        {
            ICalculator calculator = new Calculator();
            int result = calculator.Sum(null);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Sum_Array123_Returns6()
        {
            ICalculator calculator = new Calculator();
            int result = calculator.Sum(new[] { 1, 2, 3 });
            Assert.Equal(6, result);
        }

        [Fact]
        public void Sum_Overflow_ThrowsOverflowException()
        {
            ICalculator calculator = new Calculator();
            int[] values = new[] { int.MaxValue, 1 };
            Assert.Throws<OverflowException>(() => calculator.Sum(values));
        }
    }
}
