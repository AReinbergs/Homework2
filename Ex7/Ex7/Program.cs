using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Excercise";
            string appVersion = "7";
            string appCreator = "Alvis Reinbergs";

            string end = "1";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: {1} created by {2}", appName, appVersion, appCreator);
            Console.ResetColor();

            while (end == "1")
            {
                Console.WriteLine("Diffine the Array size");
                string size = Console.ReadLine();
                int l;

                while (!int.TryParse(size, out l))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not a number");
                    Console.ResetColor();
                    size = Console.ReadLine();
                }

                int[] index = new int[l];
                int[] sortedIndex = new int[l];

                for (int i = 0; i < index.Length; i++)
                {
                    int userInput;
                    Console.WriteLine("Enter a number");
                    string input = Console.ReadLine();

                    while (!int.TryParse(input, out userInput))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Not a number");
                        Console.ResetColor();
                        input = Console.ReadLine();
                    }
                    index[i] = userInput;
                }

                // ez game to sort
                List<int> listIndex = index.ToList();
                listIndex.Sort();
                listIndex.Reverse();
                sortedIndex = listIndex.ToArray();

                for (int i = 0; i < sortedIndex.Length; i++)
                {
                    Console.WriteLine(sortedIndex[i]);
                }

                Console.WriteLine("Press 1 to repeat...");
                end = Console.ReadLine();
            }
        }
    }
}
