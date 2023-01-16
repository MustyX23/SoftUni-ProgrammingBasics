using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();


            if (a == "square")
            {
                double s = double.Parse(Console.ReadLine());
                double area = (s * s);
                Console.WriteLine($"{area:F3}");
            }
            else if (a == "rectangle")
            {
                double s = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double area = s * h;
                Console.WriteLine($"{area:F3}");
            }
            else if (a == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double area = Math.PI * r * r;
                Console.WriteLine($"{area:F3}");
            }
            else if (a == "triangle")
            {
                double s = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double area = s * h / 2;
                Console.WriteLine($"{area:F3}");
            }
        }
    }
}
