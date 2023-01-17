using System;
namespace RandomPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //• На първия ред - цената на тениската – реално число в интервала[1.00... 1000.00]
            double teniska = double.Parse(Console.ReadLine());
            double topka = double.Parse(Console.ReadLine());

            double shorti = 0.75 * teniska;
            double chorapi = 0.20 * shorti;
            double butonki = 2 * (teniska + shorti);
            double s = teniska + shorti + chorapi + butonki;
            double sum = s - s * 0.15;
            if (sum >= topka)
            {
                Console.WriteLine($"Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {sum:f2} lv.");

            }
            else if (topka > sum)
            {
                Console.WriteLine($"No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {topka - sum:f2} lv. more.");
            }



        }
    }
}
