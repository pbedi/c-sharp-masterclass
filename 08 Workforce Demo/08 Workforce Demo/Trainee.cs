using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Workforce_Demo
{
    public class Trainee: Employee
    {
        protected int WorkingHours { get; set; }
        protected int SchoolHours { get; set; }

        public Trainee()
        {
               
        }

        public Trainee(string name, int salary, int workingH, int schoolH):base(name,salary)
        {
            this.WorkingHours = workingH;
            this.SchoolHours = schoolH;
        }

        public void Learn()
        {
            Console.WriteLine("I study for {0} hours", this.SchoolHours);
        }
        public new void Work()
        {
            Console.WriteLine("I work for {0} hours", this.WorkingHours);
        }
    }
}
