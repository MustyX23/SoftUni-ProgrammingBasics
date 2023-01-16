using System;
using System.Xml.Schema;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // 1. Четем данните и  ги записваме като променливи от тип "int".
           int pages = int.Parse(Console.ReadLine());
           int pagePerHours = int.Parse(Console.ReadLine());
           int days = int.Parse(Console.ReadLine());

            // 2. Изчисляваме общото време за броя на книгата за час 

            int totalHours = pages / pagePerHours;
           
            // 3. Необходимите часове на ден: общо време / дни, с които разполага  = 5 часа на ден
            int hoursPerDay = totalHours / days;

          // 4. Отпечатваме резултата на конзолата (необходими часове на ден)

            Console.WriteLine(hoursPerDay);


        }


    }
}
