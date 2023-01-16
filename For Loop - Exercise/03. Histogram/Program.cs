using System;
namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1++;
                    //p1 = 12 / 20 * 100 = 60.00%
                }
                else if (num < 400)
                {
                    p2++;
                    //p2 = 2 / 20 * 100 = 10.00%
                }
                else if (num < 600)
                {
                    p3++;
                    //p3 = 1 / 20 * 100 = 5.00 %
                }
                else if (num < 800)
                {
                    p4++;
                    //p4 = 3 / 20 * 100 = 15.00%
                }
                else
                {
                    p5++;
                    //p4 = 3 / 20 * 100 = 15.00 %
                }



            }
            Console.WriteLine($"{(double)p1 / n * 100:f2}%");
            Console.WriteLine($"{(double)p2 / n * 100:f2}%");
            Console.WriteLine($"{(double)p3 / n * 100:f2}%");
            Console.WriteLine($"{(double)p4 / n * 100:f2}%");
            Console.WriteLine($"{(double)p5 / n * 100:f2}%");

        }
    }
}









