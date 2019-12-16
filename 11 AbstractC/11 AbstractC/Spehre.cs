using System;
using System.Collections.Generic;
using System.Text;

namespace _11_AbstractC
{
    internal class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere(double radius)
        {
            Name = "Spehre";
            this.Radius = radius;
        }
        public override double Volume()
        {
            return Math.PI * ( Math.Pow(this.Radius, 3)) * 4 / 3;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"\nThe radius of Sphere is {Radius} and volume is {this.Volume()}" );
        }
    }
}
