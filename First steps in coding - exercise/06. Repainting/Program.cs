using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nailon = int.Parse(Console.ReadLine());
            int boq = int.Parse(Console.ReadLine());
            int raz = int.Parse(Console.ReadLine());
            int chas = int.Parse(Console.ReadLine());

            double sn = (nailon + 2) * 1.5;
            double sb = (boq + 0.10 * boq) * 14.5;
            double sr = raz * 5;
            double t = 0.4;
            double mat = sn + sb + sr + t;
            double mai = (mat * 0.30) * chas;
            Console.WriteLine(mat + mai);





        }
    }
}
