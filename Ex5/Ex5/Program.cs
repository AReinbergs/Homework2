using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Excercuse";
            string appVersion = "5";
            string appCreator = "Alvis Reinbergs";
            string repeat = "1";

            while(repeat == "1")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0}: {1} created by {2}", appName, appVersion, appCreator);
                Console.ResetColor();

                //Input
                int n = 0;
                int i;
                Int64 sum = 0;
                Int64 t = 1;

                Console.WriteLine("Enter a number of series");
                string input = Console.ReadLine();

                while(!int.TryParse(input, out n))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not a number");
                    Console.ResetColor();
                    input = Console.ReadLine();
                }

                for (i = 1; i <= n && t > 0; i++)
                {
                    Console.Write("{0} + ", t);
                    sum = sum + t;

                    t = (t * 10) + 1;
                }

                if (t <= 0)
                {
                    Console.WriteLine("You exceeded the number of max Intigers");
                } 
                Console.Write("\nThe Sume is: {0}\n", sum);

                Console.WriteLine("Enter 1 to repeat...");

                repeat = Console.ReadLine();
                //Console.ReadKey();

            }

        }
    }
}
