using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double centimeters = (a * 2.54);

            Console.WriteLine(centimeters);

        }
    }
}
