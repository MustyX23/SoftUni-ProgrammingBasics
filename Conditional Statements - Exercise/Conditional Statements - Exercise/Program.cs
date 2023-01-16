using System;

namespace Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int time = a + b + c;

            int min = time / 60;
            int sec = time % 60;

            if (sec >= 10)
            {
                Console.WriteLine($"{min}:{sec}");
            }
            else
            {
                Console.WriteLine($"{min}:0{sec}");
            }


        }
    }
}
