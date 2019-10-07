using System;

namespace _07_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Arrays!");
            int[] grades = new int[5];
            int[] gradeOfClassA = { 20, 13, 15, 16, 19 };
            Console.WriteLine("  Length of gradeOfClassA is {0}", gradeOfClassA.Length);

            ForLoop forloop = new ForLoop();
            Console.WriteLine("Total number of items in nums Array is {0} and value at postion 4 is {1}", forloop.GetNum().Length, forloop.GetNum()[3]);
            MultiDim multiDim = new MultiDim();
            multiDim.printArray2D(1, 2);
            multiDim.printArray3D(0, 0, 1);
        }
    }
}
