using System;

namespace _11_Enums
{
    enum Day { Mon, Tue, Wed, Thu, Fri, Sat, Sun};
    enum Month { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec};

    class Program
    {
        static void Main(string[] args)
        {
            Day fri = Day.Fri;
            Day sun = Day.Sun;

            Day a = Day.Fri;
            Console.WriteLine(fri == a);

            Console.WriteLine("Printing from Day Enum Monday and its position in the array");
            Console.WriteLine(Day.Mon);
            Console.WriteLine((int) Day.Mon);

            Console.WriteLine("Printing from Month Enum of January after changing starting postion to 1 and its position in the array");
            Console.WriteLine(Month.Jan);
            Console.WriteLine((int)Month.Jan);
            
        }
    }
}
