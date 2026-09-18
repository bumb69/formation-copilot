using System;
using Microsoft.Extensions.DependencyInjection;

namespace CopilotTraining.Ex1
{
    internal static class Program
    {
        private static void Main()
        {
            // Configure dependency injection
            var services = new ServiceCollection();
            services.AddSingleton<ICalculator, Calculator>();

            using var provider = services.BuildServiceProvider();

            var calculator = provider.GetRequiredService<ICalculator>();

            int[]? values = new[] { 1, 2, 3 };
            Console.WriteLine($"Sum([1,2,3]) = {calculator.Sum(values)}");
            Console.WriteLine($"Sum(null) = {calculator.Sum(null)}");
        }
    }
}
