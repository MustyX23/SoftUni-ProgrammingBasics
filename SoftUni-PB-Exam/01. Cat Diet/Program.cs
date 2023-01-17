using System;
namespace Cat_Diet
{
    class Program
    {
        static void Main(string[] args)
        {
            double fats = int.Parse(Console.ReadLine());
            double proteins = int.Parse(Console.ReadLine());
            double carbs = int.Parse(Console.ReadLine());
            double calories = int.Parse(Console.ReadLine());
            double water = int.Parse(Console.ReadLine());

            double fatsGrams = ((fats / 100) * 2500) / 9;
            double proteinGrams = ((proteins / 100) * 2500) / 4;
            double carbGrams = ((carbs / 100) * 2500) / 4;

            double weight = fatsGrams + proteinGrams + carbGrams;
            double weightPerGrams = 2500 / weight;

            double oneGrams = weightPerGrams * (1 - water / 100);
            Console.WriteLine($"{oneGrams:F4}");


        }
    }
}
