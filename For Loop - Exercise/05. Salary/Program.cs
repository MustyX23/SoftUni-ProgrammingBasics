using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Security.Cryptography;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            string website;

            for (int i = 1; i <= n; i++)
            {
                website = Console.ReadLine();

                if (website == "Facebook")
                {
                    salary -= 150;
                }
                else if (website == "Instagram")
                {
                    salary -= 100;
                }
                else if (website == "Reddit")
                {
                    salary -= 50;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }

            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }



        }
    }
}