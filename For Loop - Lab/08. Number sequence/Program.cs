using System;
using System.Diagnostics.CodeAnalysis;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxValue = int.MinValue;
            int minValue = int.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > maxValue)
                {
                    maxValue = num;
                }
                if (num < minValue)
                {
                    minValue = num;
                }
            }

            Console.WriteLine($"Max number: {maxValue}");
            Console.WriteLine($"Min number: {minValue}");

        }
    }
}
