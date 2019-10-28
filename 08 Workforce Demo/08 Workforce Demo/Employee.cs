using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _08_Workforce_Demo
{
    public class Employee
    {
        protected string Name { get; set; }
        protected int Salary { get; set; }

        private bool isWorking = false;
        private int currntHours = 0;
        private Timer timer;
        private int WorkingHours = 8;

        public Employee()
        {
            this.Name = "Philip";
            this.Salary = 10000;
        }

        public Employee(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine("Work Started");
            this.timer = new Timer(TimerCallback, null, 0, 1000);
        }

        private void TimerCallback(Object o)
        {
            if (this.currntHours < this.WorkingHours)
            {
                ++this.currntHours;
                Console.WriteLine("Worked so far {0}", this.currntHours);
                GC.Collect();
            } else
            {
                Pause();
            }
        }
        public void Pause()
        {
            Console.WriteLine("Taking a brack after {0} hours", this.currntHours);
            this.timer.Dispose();
        }
    }
}
