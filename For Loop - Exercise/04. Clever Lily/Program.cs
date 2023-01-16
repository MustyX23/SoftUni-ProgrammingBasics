using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Security.Cryptography;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int age = int.Parse(Console.ReadLine());
            double priceOfWashingMachine = double.Parse(Console.ReadLine());
            int priceOfToy = int.Parse(Console.ReadLine());
            int money = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += i * 5 - 1;
                }
                else
                {
                    money += priceOfToy;
                }
            }

            if (money >= priceOfWashingMachine)
            {
                Console.WriteLine($"Yes! {money - priceOfWashingMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceOfWashingMachine - money:f2}");
            }



        }
    }
}