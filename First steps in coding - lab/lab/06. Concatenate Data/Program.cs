using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = (Console.ReadLine());
            string lastName = (Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string town = (Console.ReadLine());

            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");

        }
    }
}