using System;
using System.Collections.Generic;
using System.Text;

namespace CopilotTraining.Ex1
{
    public static class Utilities
    {
        /// <summary>
        /// Calculates the sum of an array of integers.
        /// </summary>
        /// <param name="values">The array of integers to sum</param>
        /// <returns>The sum of the integers in the array. </returns>
        public static int Sum(int[]? values)
        {
            if (values is null)
            {
                return 0;
            }

            int sum = 0;
            foreach (int value in values)
            {
                sum += value;
            }
            return sum;
        }       
    }
}
