using System;
using System.Collections.Generic;
using System.Text;

namespace _11_AbstractC
{
    internal class Cube: Shape
    {
        public double Length { get; set; }

        public Cube(double length)
        {
            Name = "Cube";
            this.Length = length;
        }
        public override double Volume()
        {
            return Math.Pow(this.Length, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"\nThe Cube has a length of {Length} and Volume is {this.Volume()}");
        }
    }
}
