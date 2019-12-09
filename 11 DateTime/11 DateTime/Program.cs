using System;

namespace _11_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2019, 10, 18);
            Console.WriteLine("My Friend's birthday is {0}", dateTime);
            // write date time of today at screen
            Console.WriteLine(DateTime.Today);
            //write current time on screen
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Tomorrow's date is {0}", GetTomorrow());
            Console.WriteLine("Today's day of the week is {0}", DateTime.Today.DayOfWeek);
            Console.WriteLine("First day of the year in {0} was {1}", 1967, GetFirstDayOfYear(1999));
            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("Days in the month of Feb were: {0}", days);
            //current time
            DateTime now = DateTime.Now;
            Console.WriteLine("Minutes: {0}", now.Minute);

            Console.WriteLine("{0} o'clock, {1} minutes and {2} seconds", now.Hour, now.Minute, now.Second);
            Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            DateTime dateTime1;
            if(DateTime.TryParse(input, out dateTime1))
            {
                Console.WriteLine("You entered: {0}", dateTime1);
                TimeSpan daysPassed = now.Subtract(dateTime1);
                Console.WriteLine("Days passed since: {0}", daysPassed.Days);
            } else
            {
                Console.WriteLine("Wrong input: {0}", input);
            }
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static System.DayOfWeek GetFirstDayOfYear(int year)
        {
            DateTime dateTime = new DateTime(year, 1, 1);
            return dateTime.DayOfWeek;
        }
    }
}
