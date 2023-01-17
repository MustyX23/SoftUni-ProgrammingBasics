using System;
namespace Hair_Salon
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = int.Parse(Console.ReadLine());
            int sum = 0;
            string input = string.Empty;
            double totalSum;

            while ((input = Console.ReadLine()) != "closed")
            {
                if (input == "haircut")
                {
                    string input2 = Console.ReadLine();
                    if (input2 == "mens")
                    {
                        sum += 15;
                    }
                    else if (input2 == "ladies")
                    {
                        sum += 20;
                    }
                    else if (input2 == "kids")
                    {
                        sum += 10;
                    }

                }

                else if (input == "color")
                {
                    string input2 = Console.ReadLine();
                    if (input2 == "touch up")
                    {
                        sum += 20;
                    }
                    else if (input2 == "full color")
                    {
                        sum += 30;
                    }
                }
                if (goal <= sum)
                {
                    Console.WriteLine("You have reached your target for the day!");
                    Console.WriteLine($"Earned money: {sum}lv.");
                    return;
                }

            }
            double moneyMore = goal - sum;

            if (goal > sum)
            {
                Console.WriteLine($"Target not reached! You need {moneyMore}lv. more.");
                Console.WriteLine($"Earned money: {sum}lv.");
                return;
            }



        }
    }
}
