using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Workforce_Demo
{
    public class Boss:Employee
    {
        protected string CompanyCar { get; set; }

        public Boss()
        {
           
        }
        public Boss(string name, int salary, string car) : base(name, salary)
        {
            this.CompanyCar = car;
        }

        public void Lead()
        {
            Console.WriteLine("I'm the boss! My name is {0}, and I own {1}", this.Name, this.CompanyCar);
        }
    }
}
