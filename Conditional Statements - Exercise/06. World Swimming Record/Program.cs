using System;

namespace SwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double recordseconds = double.Parse(Console.ReadLine());
            double distancemeters = double.Parse(Console.ReadLine());
            double timefor1meterins = double.Parse(Console.ReadLine());

            //Calculations

            double alltimeforIvan = distancemeters * timefor1meterins;
            //how many times slow
            double slowtime = Math.Floor(distancemeters / 15);


            // alltimeslow
            double alltimeslow = slowtime * 12.5;

            double alltimecal = alltimeforIvan + alltimeslow;

            if (alltimecal < recordseconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {alltimecal:F2} seconds.");
            }
            else
            {
                double secondsneeded = alltimecal - recordseconds;
                Console.WriteLine($"No, he failed! He was {secondsneeded:F2} seconds slower.");
            }
        }
    }
}
