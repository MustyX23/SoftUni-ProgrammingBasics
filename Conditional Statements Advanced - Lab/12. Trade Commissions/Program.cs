using System;
namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            string sofiaTown = "Sofia";
            string plovdivTown = "Plovdiv";
            string varnaTown = "Varna";

            bool isSmallerThanFiveHundred = sales >= 0 && sales <= 500;
            bool isSmallerThan1000 = sales > 500 && sales <= 1000;
            bool isSmallerThan10000 = sales > 1000 && sales <= 10000;
            bool biggerThan10000 = sales > 10000;
            double comission = -1.0;

            if (town == sofiaTown)
            {
                if (isSmallerThanFiveHundred)
                {
                    comission = 0.05;
                }
                else if (isSmallerThan1000)
                {
                    comission = 0.07;
                }
                else if (isSmallerThan10000)
                {
                    comission = 0.08;
                }
                else if (biggerThan10000)
                {
                    comission = 0.12;
                }
            }
            else if (town == varnaTown)
            {
                if (isSmallerThanFiveHundred)
                {
                    comission = 0.045;
                }
                else if (isSmallerThan1000)
                {
                    comission = 0.075;
                }
                else if (isSmallerThan10000)
                {
                    comission = 0.1;
                }
                else if (biggerThan10000)
                {
                    comission = 0.13;
                }
            }
            else if (town == plovdivTown)
            {
                if (isSmallerThanFiveHundred)
                {
                    comission = 0.055;
                }
                else if (isSmallerThan1000)
                {
                    comission = 0.08;
                }
                else if (isSmallerThan10000)
                {
                    comission = 0.12;
                }
                else if (biggerThan10000)
                {
                    comission = 0.145;
                }
            }

            if (comission < 0.0)
            {
                Console.WriteLine("error");
            }
            else
            {
                double result = sales * comission;
                Console.WriteLine(result.ToString("f2"));
            }

        }
    }
}
