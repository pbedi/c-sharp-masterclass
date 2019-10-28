using System;

namespace _08_Workforce_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Workforce Demo!, press any key to pause");
            Employee employee1 = new Employee("Ritu", 15000);
            //employee1.Work();
            //Console.ReadKey();
            //employee1.Pause();

            Boss boss1 = new Boss("Phil", 50000, "Mercs E350");
            boss1.Lead();

            Trainee trainee1 = new Trainee("Rhythm", 7500, 20, 8);
            trainee1.Work();
            trainee1.Learn();
        }
    }
}
