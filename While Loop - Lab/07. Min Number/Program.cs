using System;
namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string num;
            int minNum = int.MaxValue;

            while ((num = Console.ReadLine()) != "Stop")
            {
                int num1 = int.Parse(num);
                if (num1 < minNum)
                {
                    minNum = num1;
                }
            }
            Console.WriteLine(minNum);



        }
    }
}