using System;

namespace ConsoleConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer("Philip", 1);
            var person = new Person
            {
                FirstName = "Philip",
                LastName = "Bedi"
            };
        }
    }
}
