using System;
using System.Security.Authentication.ExtendedProtection;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double bk = a - a * 0.4;
            double be = bk - 0.20 * bk;
            double bt = be / 4;
            double ba = bt / 5;

            double razhodi = (bk + be + bt + ba + a);
            Console.WriteLine(razhodi);




        }
    }
}
