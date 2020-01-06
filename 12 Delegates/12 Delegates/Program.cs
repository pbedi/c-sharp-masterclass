using System;

namespace _12_Delegates
{
    class Program
    {
        public delegate double PerformCalculation(double x, double y);

        public static double Addition(double a, double b)
        {
            Console.WriteLine("a+b is : " + (a+b));
            return a + b;
        }

        public static double Division(double a, double b)
        {
            Console.WriteLine("a/b is : " + (a / b));
            return a / b;
        }

        public static double Subtract(double a, double b)
        {
            Console.WriteLine("a - b is : " + (a - b));
            return a - b;
        }

        static void Main(string[] args)
        {
            PerformCalculation getSum = Addition;
            getSum(5.0, 6.0);

            PerformCalculation getQuotient = Division;

            getQuotient(15.0 , 3.0);
            Console.WriteLine("Multi Calculation");

            PerformCalculation multiCalc = getSum + getQuotient;
            multiCalc += Subtract;

            multiCalc(6.4, 3.2);
        }
    }
}
