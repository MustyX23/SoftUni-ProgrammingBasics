using System;
using System.Security.Authentication.ExtendedProtection;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pile = int.Parse(Console.ReadLine());
            int riba = int.Parse(Console.ReadLine());
            int vegan = int.Parse(Console.ReadLine());

            double p = pile * 10.35;
            double r = riba * 12.40;
            double v = vegan * 8.15;
            

            double sum = p + r + v;



            double desert = 0.2 * sum;
            double dostavka = 2.50;

            double cena = sum + desert + dostavka;


            Console.WriteLine(cena);
          
        }
    }
}