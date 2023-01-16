using System;

namespace _05._Godzilla_vs._Kong_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nVideo = int.Parse(Console.ReadLine());
            int nCPU = int.Parse(Console.ReadLine());
            int nRAM = int.Parse(Console.ReadLine());

            double priceVideo = 250;
            double video = nVideo * priceVideo;

            double priceCPU = video * 0.35;
            double cpu = nCPU * priceCPU;

            double priceRAM = video * 0.10;
            double ram = nRAM * priceRAM;

            double fullPrice = video + cpu + ram;

            if (nVideo > nCPU)
            {
                fullPrice = fullPrice - (fullPrice * 0.15);
            }
            else
            {
                fullPrice = video + cpu + ram;
            }
            if (budget >= fullPrice)
            {
                double moneyLeft = budget - fullPrice;
                Console.WriteLine($"You have {moneyLeft:f2} leva left!");
            }
            else
            {
                double moneyNeeded = fullPrice - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva more!");
            }

        }
    }
}
