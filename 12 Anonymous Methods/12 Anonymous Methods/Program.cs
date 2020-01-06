using System;

namespace _12_Anonymous_Methods
{
    class Program
    {
        public delegate string GetTextDelegate(string name);

        public delegate double GetResultDelegate(double a, double b);

        static void Main(string[] args)
        {
            // Anonymous method / Inline Delegate
            GetTextDelegate getTextDelegate = delegate (string name)
            {
                return "Hello, " + name;
            };

            Console.WriteLine(getTextDelegate("Philip"));
            // method compiles first
            SayHello();
            // pass anonymous method
            Display(getTextDelegate);

            // Lambda expression
            GetTextDelegate getHelloText = (string name) => { return "Hello from LBD, " + name; };

            Console.WriteLine(getHelloText("Gurender"));

            // Statement Lambda

            GetTextDelegate getGoodbyeText = (string name) =>
            {
                Console.WriteLine("I'm inside of a statement Lambda");
                return "Goodbye, " + name;
            };

            Console.WriteLine(getGoodbyeText("Philip"));

            GetTextDelegate getWelcomeText = name => "Welcome, " + name;

            Console.WriteLine(getWelcomeText("Gurender"));

            GetResultDelegate addNumbers = (a, b) => a + b;

            Console.WriteLine("Addition of 5 and 17 is: " + addNumbers(5,17));

            GetResultDelegate multiplyNumbers = (a, b) => a * b;

            Console.WriteLine("Multiplication of 5 and 7 is: " + multiplyNumbers(5,7));

            //using function
            DisplayNum(addNumbers);
            DisplayNum(multiplyNumbers);
        }

        static void Display(GetTextDelegate getTextDelegate)
        {
            Console.WriteLine(getTextDelegate("World!"));
        }

        public static void SayHello()
        {
            Console.WriteLine("Hello All!");
        }

        static void DisplayNum(GetResultDelegate getResultDelegate)
        {
            Console.WriteLine(getResultDelegate(3.7, 8.9));
        }
    }
}
