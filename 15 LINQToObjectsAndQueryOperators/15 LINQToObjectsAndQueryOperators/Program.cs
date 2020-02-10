using System;
using System.Collections.Generic;
using System.Linq;

namespace _15_LINQToObjectsAndQueryOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversityManager universityManager = new UniversityManager();
            universityManager.MaleStudents();
            universityManager.FemaleStudents();
            universityManager.SortStudentByAge();
            universityManager.AllStudentsFromAUni("Oxford");
            int[] myInts = { 30, 12, 4, 3, 15 };
            IEnumerable<int> sortedInts = from i in myInts orderby i select i;  // assending sort
            IEnumerable<int> reverseInts = sortedInts.Reverse();
            int counter = 1;
            Console.WriteLine("Using Reverse function or Linq");
            foreach (int j in reverseInts)
            {
                Console.WriteLine("{0}) number is {1}", counter, j);
                counter++;
            }
            IEnumerable<int> reversedInts = from i in myInts orderby i descending select i;  // descending sort
            counter = 1;
            Console.WriteLine("Using descending order in Linq query");
            foreach (int k in reversedInts)
            {
                Console.WriteLine("{0}) number is {1}", counter, k);
                counter++;
            }
            universityManager.StudentsAndNameCollection();
            Console.ReadLine();
        }
    }
}
