using System;
using System.Diagnostics.CodeAnalysis;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                leftSum = leftSum + num;
            }
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                rightSum = rightSum + num;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {rightSum}");
            }
            else
            {
                int diff = Math.Abs(rightSum - leftSum);
                Console.WriteLine($"No, diff = {diff}");
            }



        }
    }
}
