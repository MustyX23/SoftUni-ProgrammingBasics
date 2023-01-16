using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Четем радиани от конзолата и ги записваме променлива от double

            double radians = double.Parse(Console.ReadLine());

            // 2. Преобразуваме радиани (десетични числа) в градуси

            double degrees = radians * 180 / Math.PI;


            // 3. Отпечатваме на конзолата

            Console.WriteLine(degrees);

        }
    }
}
