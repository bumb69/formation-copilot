using Xunit;

namespace CopilotTraining.Tests
{
    public class SumTests
    {
        [Fact]
        public void Sum_NullArray_ReturnsZero()
        {
            int result = CopilotTraining.Ex1.Utilities.Sum(null);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Sum_Array123_Returns6()
        {
            int[] values = new[] { 1, 2, 3 };
            int result = CopilotTraining.Ex1.Utilities.Sum(values);
            Assert.Equal(6, result);
        }
    }
}
