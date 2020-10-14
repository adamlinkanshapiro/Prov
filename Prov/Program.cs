using System;

namespace Prov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose any number between 1 and 30");

            Console.WriteLine("1, 2, 3, 4, 5");

            string userInput;
            userInput = Console.ReadLine().ToLower();

            if (userInput == "1")
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Miss");

            }

            else if (userInput == "5")
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Hit");
            }
        }
    }
}