namespace CopilotTraining.Ex1
{
    /// <summary>
    /// Default implementation of <see cref="ICalculator"/> that provides
    /// numeric operations such as summing integer arrays.
    /// </summary>
    public class Calculator : ICalculator
    {
        /// <summary>
        /// Calculates the sum of the provided integers.
        /// Returns 0 when <paramref name="values"/> is null.
        /// Throws <see cref="OverflowException"/> if the computed sum
        /// is greater than <see cref="int.MaxValue"/>.
        /// </summary>
        /// <param name="values">Array of integers to sum (may be null).</param>
        /// <returns>The sum as an <see cref="int"/>.</returns>
        public int Sum(int[]? values)
        {
            if (values is null)
            {
                return 0;
            }

            long total = 0;
            foreach (int v in values)
            {
                total += v;
                if (total > int.MaxValue)
                {
                    throw new OverflowException("Sum exceeds Int32.MaxValue.");
                }
            }

            return (int)total;
        }
    }
}
