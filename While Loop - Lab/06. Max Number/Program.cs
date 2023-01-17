using System;
namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string num;
            int maxNum = int.MinValue;

            while ((num = Console.ReadLine()) != "Stop")
            {
                int num1 = int.Parse(num);
                if (num1 > maxNum)
                {
                    maxNum = num1;
                }
            }
            Console.WriteLine(maxNum);



        }
    }
}