using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double price = 7.61;

            double s = a * price;
            double dc = s * 0.18;
            double fp = s - dc;



            Console.WriteLine($"The final price is: {fp} lv.");
            Console.WriteLine($"The discount is: {dc} lv.");



        }
    }
}
