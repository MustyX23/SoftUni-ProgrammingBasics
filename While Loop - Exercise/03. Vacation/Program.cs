using System;
namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyOnHand = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int spendingCounter = 0;

            while (moneyOnHand < moneyNeeded && spendingCounter < 5)
            {
                string spendOrSave = Console.ReadLine();
                double moneySpend = double.Parse(Console.ReadLine());
                daysCounter++;
                if (spendOrSave == "save")
                {
                    moneyOnHand += moneySpend;
                    spendingCounter = 0;
                }
                else
                {
                    moneyOnHand -= moneySpend;
                    if (moneyOnHand < 0)
                    {
                        moneyOnHand = 0;
                    }
                    spendingCounter++;

                    if (spendingCounter == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(daysCounter);
                        break;
                    }
                }

            }
            if (moneyOnHand >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }

        }
    }
}
