using System;

namespace Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vacation = double.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());
            double total = p * 2.6 + d * 3 + b * 4.1 + m * 8.2 + t * 2;
            if (p + d + b + m + t >= 50)
            {
                total = total - (total * 0.25);
            }
            total = total - (total * 0.1);
            if (total >= vacation)
            {
                double v = total - vacation;
                Console.WriteLine($"Yes! {v:F2} lv left.");
            }
            else
            {
                double v = vacation - total;
                Console.WriteLine($"Not enough money! {v:F2} lv needed.");
            }
        }
    }
}


