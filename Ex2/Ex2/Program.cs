using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction
            string Name = "Alvis Reinbergs";
            string appName = "Excercise";
            string appVersion = "1";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: {1}, created by {2}", appName, appVersion, Name);
            Console.ResetColor();

            //Number one
            Console.WriteLine("Enter the first number");

            int n1 = 0;
            string numberInput1 = Console.ReadLine();

            while(!int.TryParse(numberInput1, out n1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a number, enter a new one");
                Console.ResetColor();
                numberInput1 = Console.ReadLine();
            }

            //Number two
            Console.WriteLine("Enter the second number");

            int n2 = 0;
            string numberInput2 = Console.ReadLine();

            while (!int.TryParse(numberInput2, out n2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a number, enter a new one");
                Console.ResetColor();
                numberInput2 = Console.ReadLine();
            }

            //Number three
            Console.WriteLine("Enter the third number");

            int n3 = 0;
            string numberInput3 = Console.ReadLine();

            while (!int.TryParse(numberInput3, out n3))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a number, enter a new one");
                Console.ResetColor();
                numberInput3 = Console.ReadLine();
            }

            //Result
            int[] array = { n1, n2, n3 };
            int max = array.Max();

            Console.WriteLine("You have entered the following numbers: {0}; {1}; {2}", n1, n2, n3);
            Console.WriteLine("The biggest number is {0}", max);

            Console.WriteLine("Press Enter to exit...");
            Console.ReadKey();
        }
    }
}
