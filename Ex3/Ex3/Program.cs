using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //introduction
            string appCreator = "Alvis Reinbergs";
            string appName = "Exercise";
            string appVersion = "3";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: {1} created by {2}", appName, appVersion, appCreator);
            Console.ResetColor();

            //First digit

            int x = 0;

            Console.WriteLine("Enter the X coordinates");
            string First = Console.ReadLine();

            while(!int.TryParse(First, out x))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a number");
                Console.ResetColor();
                First = Console.ReadLine();
            }

            //Second digit

            int y = 0;

            Console.WriteLine("Enter the Y coordinates");
            string Second = Console.ReadLine();

            while (!int.TryParse(Second, out y))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a number");
                Console.ResetColor();
                Second = Console.ReadLine();
            }

            //Qudrats 
            if (x==0 && y == 0)
            {
                Console.WriteLine("The coordinates are in the zero quadrant");
            } else if (x>0 && y > 0)
            {
                Console.WriteLine("The coordinates are in the 1st quadrant");
            } else if(x<0 && y > 0)
            {
                Console.WriteLine("The coordinates are in the 2nd quadrant");
            } else if (x < 0 && y < 0)
            {
                Console.WriteLine("The coordinates are in the 3rd quadrant");
            } else if(x > 0 && y < 0)
            {
                Console.WriteLine("The coordinates are in the 4th quadrant");
            } else if(x==0 && y > 0)
            {
                Console.WriteLine("The The coordinates are between the 1st and 2nd quadrant");
            } else if (x==0 && y < 0)
            {
                Console.WriteLine("The The coordinates are between the 3rd and 4th quadrant");
            } else if (x>0 && y == 0)
            {
                Console.WriteLine("The The coordinates are between the 1st and 4th quadrant");
            } else if (x<0 && y == 0)
            {
                Console.WriteLine("The The coordinates are between the 2nd and 3rd quadrant");
            }



            //End
            Console.WriteLine("Press Enter to exit...");
            Console.ReadKey();
        }
    }
}
