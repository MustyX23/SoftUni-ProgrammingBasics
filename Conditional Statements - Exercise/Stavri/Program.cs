using System;

namespace _01._Christmas_Preparation_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numPaper = double.Parse(Console.ReadLine());
            double numCloth = double.Parse(Console.ReadLine());
            double numGlue = double.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine()) / 100.0;

            double totalCost = 0;
            double percentTotalCost = 0;

            double pricePaper = numPaper * 5.80;
            double priceCloth = numCloth * 7.20;
            double priceGlue = numGlue * 1.20;

            totalCost = pricePaper + priceCloth + priceGlue;

            Console.WriteLine($"{percentTotalCost:f2}");
        }
    }
}
