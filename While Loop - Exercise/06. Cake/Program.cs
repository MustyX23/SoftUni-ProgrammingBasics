using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int cakeSize = w * h;
            string input;
            int cakeParts;

            while ((input = Console.ReadLine()) != "STOP")
            {
                cakeParts = int.Parse(input);
                if (cakeParts > cakeSize)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeParts - cakeSize)} pieces more.");
                    cakeSize -= cakeParts;
                    break;
                }
                cakeSize -= cakeParts;

            }
            if (cakeSize > 0)

            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }


        }
    }
}