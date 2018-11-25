using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction
            string appName = "Excercise";
            string appVersion = "1";
            string appAuthor = "Alvis Reinbergs";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();


            //Asks for a year
            Console.WriteLine("Enter a year");

            //Reads the variable
            int number = 0;
            string year = Console.ReadLine();

            while(!int.TryParse(year, out number))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a number");
                Console.ResetColor();
                year = Console.ReadLine();
            }

            if (DateTime.IsLeapYear(number))
            {
                Console.WriteLine("The {0} year is a leap year", number);
            } else
            {
                Console.WriteLine("The {0} year is not a leap year", number);
            }


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
