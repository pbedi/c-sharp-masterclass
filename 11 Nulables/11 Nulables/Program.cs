using System;

namespace _11_Nulables
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 1342;

            double? num3 = new Double?();
            double? num4 = 3.1425;

            bool? boolval1 = new bool?();

            Console.WriteLine("Our nullable numbers are: {0},{1},{2},{3}", num1, num2, num3,num4);
            Console.WriteLine("Nullable boolean is: {0}", boolval1);

            double? num5 = 13.1;
            double? num6 = null;
            double num7;

            if(num5 == null)
            {
                num7 = 0.0;
            } else
            {
                num7 = (double)num5;
            }

            Console.WriteLine("Value of num7 is {0}", num7);
            // Shorter: The NULL coalesing operator ??
            num7 = num6 ?? 8.53;
            Console.WriteLine("Value of num7 is {0}", num7);
            num7 = num5 ?? 8.53;
            Console.WriteLine("Value of num7 is {0}", num7);
        }
    }
}
