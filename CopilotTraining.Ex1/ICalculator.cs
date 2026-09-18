namespace CopilotTraining.Ex1
{
    /// <summary>
    /// Defines calculator operations.
    /// </summary>
    public interface ICalculator
    {
        /// <summary>
        /// Calculates the sum of the provided integers. Returns 0 for null input.
        /// </summary>
        /// <param name="values">Array of integers to sum.</param>
        /// <returns>Sum of integers.</returns>
        int Sum(int[]? values);
    }
}
