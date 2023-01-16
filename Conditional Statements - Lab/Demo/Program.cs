using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата ширина и дължина на тортата
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            //2. Изчисляваме колко са парчетата торта
            int cakeSize = w * h;

            string input = Console.ReadLine();
            int cakePeieces;

            //3. Създаваме цикъл, който да се изпълнява до получаване на "STOP"
            while (input != "STOP")
            {
                cakePeieces = int.Parse(input);
                // => проверяваме дали има достатъчно
                if (cakePeieces > cakeSize)
                {
                    // => ако няма достатъчно:
                    // ==> отпечатваме колко недостигат и спираме цикъла
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakePeieces - cakeSize)} pieces more.");
                    cakeSize -= cakePeieces;
                    break;
                }

                // => ако има достатъчно:
                // ==> изваждаме броя, който си взимат от отаналите парчета
                cakeSize -= cakePeieces;

                input = Console.ReadLine();
            }

            if (cakeSize > 0)
            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }

        }
    }
}