using System;
using System.Collections.Generic;
using System.Text;

namespace _15_LINQToObjectsAndQueryOperators
{
    public class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("University {0} with Id {1}", Name, Id);
        }
    }
}
