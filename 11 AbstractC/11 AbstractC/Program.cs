using System;

namespace _11_AbstractC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bunch of shapes!");
            Shape[] shapes = { new Sphere(4), new Cube(3) };

            foreach(Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine("{0} has a volume of {1}", shape.Name, shape.Volume());
                Cube iceCude = shape as Cube;
                if(iceCude == null)
                {
                    Console.WriteLine( "This Shape is not cube");
                }

                if (iceCude is Cube)
                {
                    Console.WriteLine("This Shape is a cube");
                }
            }

            object cube1 = new Cube(7);
            Cube cube2 = (Cube)cube1;
            Console.WriteLine( "{0} has a Volume of {1}", cube2.Name, cube2.Volume());
        }
    }
}
