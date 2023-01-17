using System;

namespace _03._Courier_Express
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string service = Console.ReadLine();
            double range = double.Parse(Console.ReadLine());

            double price = 0;

            if (service == "standard")
            {
                if (weight < 1)
                {
                    price += range * 0.03;
                }
                else if (weight >= 1 && weight <= 10)
                {
                    price += range * 0.05;
                }
                else if (weight >= 11 && weight <= 40)
                {
                    price += range * 0.10;
                }
                else if (weight >= 41 && weight <= 90)
                {
                    price += range * 0.15;
                }
                else if (weight >= 91 && weight <= 150)
                {
                    price += range * 0.20;
                }
            }
            else if (service == "express")
            {
                if (weight < 1)
                {
                    price += range * 0.03 + 0.03 * 0.8 * weight * range;
                }
                else if (weight >= 1 && weight <= 10)
                {
                    price += range * 0.05 + 0.05 * 0.4 * weight * range;
                }
                else if (weight >= 11 && weight <= 40)
                {
                    price += range * 0.10 + 0.10 * 0.05 * weight * range;
                }
                else if (weight >= 41 && weight <= 90)
                {
                    price += range * 0.15 + 0.15 * 0.02 * weight * range;

                }
                else if (weight >= 91 && weight <= 150)
                {
                    price += range * 0.20 + 0.20 * 0.01 * weight * range;
                }

            }

            Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {price:f2} lv.");
        }
    }
}
