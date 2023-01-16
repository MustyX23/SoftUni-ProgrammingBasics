using System;
using System.Diagnostics.CodeAnalysis;

namespace Stavri_grandfather
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumDegreesRakia = 0;

            for (int i = 1; i <= n; i++)
            {
                double quantityRakia = double.Parse(Console.ReadLine());
                double degrees = double.Parse(Console.ReadLine());
                sumDegreesRakia += quantityRakia * degrees;
            }
        }
    }
}
