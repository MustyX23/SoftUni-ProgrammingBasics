using System;
namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            string nextBook;
            int counter = 0;
            while ((nextBook = Console.ReadLine()) != "No More Books")
            {
                if (nextBook == favouriteBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }
                counter++;

            }
            if (nextBook != favouriteBook)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
            counter++;
        }
    }
}
