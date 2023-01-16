using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Четем данните от конзолата
            // - Депозит - double
            double deposit = double.Parse(Console.ReadLine());
            // - срок - int
            int term = int.Parse(Console.ReadLine());
            // Годишен лихвен процент - double
            double rate = double.Parse(Console.ReadLine());


            // 2. Изчисляваме сумата: сума = депозирана сума  + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
            double sum = deposit + term * ((deposit * (rate/100)) / 12);

            // 3. Отпечатване на резултата на конзолата (сума)\
            Console.WriteLine(sum);
        }
    }
}