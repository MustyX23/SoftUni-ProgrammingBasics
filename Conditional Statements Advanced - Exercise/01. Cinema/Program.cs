using System;
namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            double income = 0;

            if (type == "Premiere")
            {
                income = rows * colums * 12.00;
            }
            else if (type == "Normal")
            {
                income = rows * colums * 7.50;
            }
            else if (type == "Discount")
            {
                income = rows * colums * 5.00;
            }

            Console.WriteLine($"{income:F2} leva");
        }
    }
}