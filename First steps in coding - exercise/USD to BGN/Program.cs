using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Запазваме щатските долари, идващи от конзолата в променлива, която ще е от тип double
            double usd = double.Parse(Console.ReadLine());

            // 2. Преобразуваме щатските долари в лева, като използваме курса 1 USD = 1.79549 BGN.

            double bgn = usd * 1.79549;

            // 3. Да си изведем резултат на конзолата БГН

            Console.WriteLine(bgn);


        }

    }

}
