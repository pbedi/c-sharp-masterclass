using System;

namespace AccessModifiers
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirtDate(DateTime birthdate)
        {
            //if(!String.IsNullOrEmpty(birthdate))
            this._birthdate = birthdate;
        }

        public DateTime GetBirthDate()
        {
            return _birthdate;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirtDate(new DateTime(1982, 1, 1));

            Console.WriteLine("BD=" + person.GetBirthDate());
        }
    }
}
