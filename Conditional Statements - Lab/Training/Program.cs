using System;
namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int evenSum;
            int oddSum;
            for (int x = firstNum; x <= secondNum; x++)
            {
                evenSum = 0;
                oddSum = 0;

                string currentNum = x.ToString();

                for (int y = 0; y < currentNum.Length; y++)
                {
                    if (y % 2 == 0)
                    {
                        evenSum += currentNum[y];
                    }
                    else
                    {
                        oddSum += currentNum[y];
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write($"{currentNum} ");
                }
            }
        }
    }
}



