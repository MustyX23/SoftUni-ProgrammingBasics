using System;
namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Създаваме променлива, която да пази стъпките, които е минала
            int steps = 0;
            //2. Създаваме си променлива, която да пази входа, който получаваме(string)
            string input;

            //3. Пускаме цикъл, който да се изпълнява, докато не постигне целта си
            while (steps < 10000)
            {
                input = Console.ReadLine();
                // Проверяваме дали сме получили командата "Going home"
                if (input == "Going home")
                {
                    // => ако е командата: 
                    steps += int.Parse(Console.ReadLine());
                    // ==> спираме изпълнението на цикъла
                    break;
                }

                //=> ако не е:
                steps += int.Parse(input);
            }

            //4. Проверяваме дали е изпълнила целта си
            if (steps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{Math.Abs(10000 - steps)} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(10000 - steps)} more steps to reach goal.");
            }

        }
    }
}
