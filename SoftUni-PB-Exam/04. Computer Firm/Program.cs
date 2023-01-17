using System;
namespace RandomPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int obshtopr = 0;
            double srednoReiting = 0;
            int osashtestvenipr = 0;

            for (int i = 1; i <= num; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int reiting = n % 10;
                int vazmojniProdajbi = n / 10;
                if (reiting == 2)
                {
                    osashtestvenipr = 0;
                    srednoReiting += reiting;
                    obshtopr += osashtestvenipr;

                }
                else if (reiting == 3)
                {
                    osashtestvenipr = vazmojniProdajbi * 50 / 100;
                    srednoReiting += reiting;
                    obshtopr += osashtestvenipr;

                }
                else if (reiting == 4)
                {
                    osashtestvenipr = vazmojniProdajbi * 70 / 100;
                    srednoReiting += reiting;
                    obshtopr += osashtestvenipr;

                }
                else if (reiting == 5)
                {
                    osashtestvenipr = vazmojniProdajbi * 85 / 100;
                    srednoReiting += reiting;
                    obshtopr += osashtestvenipr;

                }
                else if (reiting == 6)
                {
                    osashtestvenipr = vazmojniProdajbi;
                    srednoReiting += reiting;
                    obshtopr += osashtestvenipr;

                }

            }

            Console.WriteLine($"{obshtopr:f2}");
            Console.WriteLine($"{srednoReiting / num:f2}");

        }
    }
}
