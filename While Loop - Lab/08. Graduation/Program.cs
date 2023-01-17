using System;
namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            int badMarks = 0;
            double totalMarks = 0;

            while (grade <= 12)
            {
                double marks = double.Parse(Console.ReadLine());

                if (marks < 4)
                {
                    badMarks++;

                    if (badMarks > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        return;
                    }

                }
                else
                {
                    grade++;
                    totalMarks += marks;
                }

            }
            double averageMark = totalMarks / (12);
            Console.WriteLine($"{name} graduated. Average grade: {averageMark:f2}");
        }
    }
}