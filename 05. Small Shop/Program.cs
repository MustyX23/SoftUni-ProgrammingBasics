using System;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfProduct = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (city == "Sofia")
            {
                if (nameOfProduct == "coffee") price = quantity * 0.50;
                else if (nameOfProduct == "water") price = quantity * 0.80;
                else if (nameOfProduct == "beer") price = quantity * 1.20;
                else if (nameOfProduct == "sweets") price = quantity * 1.45;
                else if (nameOfProduct == "peanuts") price = quantity * 1.60;
            }
            else if (city == "Plovdiv")
            {
                if (nameOfProduct == "coffee") price = quantity * 0.40;
                else if (nameOfProduct == "water") price = quantity * 0.70;
                else if (nameOfProduct == "beer") price = quantity * 1.15;
                else if (nameOfProduct == "sweets") price = quantity * 1.30;
                else if (nameOfProduct == "peanuts") price = quantity * 1.50;
            }
            else if (city == "Varna")
            {
                if (nameOfProduct == "coffee") price = quantity * 0.45;
                else if (nameOfProduct == "water") price = quantity * 0.70;
                else if (nameOfProduct == "beer") price = quantity * 1.10;
                else if (nameOfProduct == "sweets") price = quantity * 1.35;
                else if (nameOfProduct == "peanuts") price = quantity * 1.55;
            }


            Console.WriteLine(price);
        }
    }
}
