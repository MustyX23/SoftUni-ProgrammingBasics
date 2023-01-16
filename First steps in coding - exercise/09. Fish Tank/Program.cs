using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dyljina = int.Parse(Console.ReadLine());
            int shirochina = int.Parse(Console.ReadLine());
            int visochina = int.Parse(Console.ReadLine());
            double procent=double.Parse(Console.ReadLine());

            double v = dyljina * shirochina * visochina;
            double l = v * 0.001;
 
            double ln = procent / 100;

            Console.WriteLine(l * (1-ln));






        }
    }
}
