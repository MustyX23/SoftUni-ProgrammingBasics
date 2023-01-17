using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badmarks = int.Parse(Console.ReadLine());
            int badMarksCounter = 0;
            double sumMarks = 0;
            int solvedProblemsCount = 0;
            string lastTask = "";
            bool isFailed = true;


            while (badMarksCounter < badmarks)
            {
                string problemName = Console.ReadLine();

                if (problemName == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int marks = int.Parse(Console.ReadLine());
                if (marks <= 4)
                {
                    badMarksCounter++;
                }
                sumMarks += marks;
                solvedProblemsCount++;
                lastTask = problemName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {badMarksCounter} poor grades.");
            }
            else
            {
                double average = (sumMarks / solvedProblemsCount);
                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine($"Number of problems: {solvedProblemsCount}");
                Console.WriteLine($"Last problem: {lastTask}");
            }

        }
    }
} 

