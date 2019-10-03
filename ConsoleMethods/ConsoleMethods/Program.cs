using System;

namespace ConsoleMethods
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var num = int.Parse("abc");
                Console.WriteLine("Converted to: {0}", num);
            }
            catch (Exception)
            {
                Console.WriteLine("Parse: Conversion failed.")
            }
            int number;
            var result = int.TryParse("abc", out number);
            if(result)
            {
                Console.WriteLine("Converted to: {0}", number );
            }
            else
            {
                Console.WriteLine("TryParse: Conversion failed.");
            }
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5, 6 }));
        }
        static void UsePoint()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);

                point.Move(new Point(100, 200));
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);
            }
            catch (Exception)
            {

                Console.WriteLine("An unexted error occured");
            }
        }
    }
}
