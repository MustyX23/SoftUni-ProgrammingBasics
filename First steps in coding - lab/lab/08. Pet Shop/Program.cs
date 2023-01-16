using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fdDogs = int.Parse(Console.ReadLine());
            int fdCats = int.Parse(Console.ReadLine());

            double prDogs = fdDogs * 2.50;
            double prCats = fdCats * 4;
            double s = prCats + prDogs;

            Console.WriteLine($"{s} lv.");


        }
    }
}