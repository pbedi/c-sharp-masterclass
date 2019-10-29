using System;
using System.Collections.Generic;
using System.Text;

namespace _09_01_Polymorphic_Parameters
{
    class Audi: Car
    {
        protected string Model { get; set; }
        private string Brand { get; set; }

        public Audi(string hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
            this.Brand = "Audi";
        }

        public override void ShowDetails()
        {
            Console.WriteLine("This Car's Brand is {2} has {0} power HP and color {1}", this.HP, this.Color, this.Brand);
        }

        public override void Repair()
        {
            Console.WriteLine("The Audi {0} was repaired!", this.Model);
        }
    }
}
