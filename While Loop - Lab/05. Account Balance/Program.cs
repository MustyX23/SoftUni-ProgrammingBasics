using System;
namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double sumTotal = 0;

            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                double money = double.Parse(input);
                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sumTotal += money;
                Console.WriteLine($"Increase: {money:f2}");

            }
            Console.WriteLine($"Total: {sumTotal:f2}");

        }
    }
}