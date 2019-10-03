using System;

namespace ConsoleLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ForLoop(10);
            PrintOddNumbers(20);
            DoWhileLoop(5);
            WhileLoop(7);
            CountPeople();
        }

        public static void ForLoop( int  max)
        {
            Console.WriteLine("For Loop Started");
            for (int i =1; i <= max; i++)
            {
                Console.WriteLine("Step = " + i);
            }
        }

        public static void PrintOddNumbers(int max)
        {
            Console.WriteLine("Odd numbers between 1 to {0}", max);
            for (int i = 1; i < max; i += 2)
            {
                Console.WriteLine("Odd number = " + i);
            }
        }

        public static void DoWhileLoop(int max)
        {
            int counter = 0;
            Console.WriteLine("Do While Loop started");
            do
            {
                Console.WriteLine("Step = " + counter);
                counter++;
            } while (counter < max);
        }

        public static void WhileLoop (int max)
        {
            int counter = 0;
            Console.WriteLine("While Loop started");
            while (counter < max)
            {
                Console.WriteLine("While Loop Step = " + counter);
                counter++;
            };
        }

        public static void CountPeople()
        {
            int counter = 0;
            string enteredText = "";
            Console.WriteLine("Counting people");
            while(enteredText.Length == 0)
            {
                Console.WriteLine("Please press to increase the number by one or anything else + enter to finish the program");
                enteredText = Console.ReadLine();
                counter++;
                Console.WriteLine("Current people count is {0}", counter);
            }
        }
    }
}
