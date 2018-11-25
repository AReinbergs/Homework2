using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction
            string appName = "Excercise";
            string appVersion = "4";
            string appCreator = "Alvis Reinbergs";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: {1} createdy by {2}", appName, appVersion, appCreator);
            Console.ResetColor();

            //Asking for lines
            Console.WriteLine("Enter the amont of lines in pryamid");
            int line = 0;
            string lineAmount = Console.ReadLine();

            while (!int.TryParse(lineAmount, out line))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a number");
                Console.ResetColor();
                lineAmount = Console.ReadLine();
            }

            //Pyramid
            int row, col, space, temp=1;
            int i = line;

            for (row=1; row<=line; row++)
            {
               for (space = line; space>=row; space--)
                {
                    Console.Write(" ");
                }                
                    for (col = 1; col <=row; col++)
                    {
                        Console.Write(temp+" ");
                        temp++;
                    }
                
                Console.WriteLine();
            }

           

            Console.WriteLine("Press Enter to exit...");
            Console.ReadKey();
        }
    }
}
