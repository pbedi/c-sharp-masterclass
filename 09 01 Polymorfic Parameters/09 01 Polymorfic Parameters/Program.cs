using System;
using System.Collections.Generic;

namespace _09_01_Polymorphic_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi("200","Blue","A4"),
                new BMW("250","Silver","M3")
            };
            foreach(var car1 in cars)
            {
                car1.ShowDetails();
                car1.Repair();
            }
            Car bmwZ3 = new BMW("330", "White", "M3");
            bmwZ3.SetCarIDInfo(25672, "PhilB");
            bmwZ3.ShowDetails();
            bmwZ3.GetCarIDInfo();
            Console.ReadKey();
            
        }
    }
}
