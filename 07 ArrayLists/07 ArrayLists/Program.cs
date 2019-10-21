using System;
using System.Collections;

namespace _07_ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring ArrayList
            ArrayList myArrayList = new ArrayList();
            ArrayList myArrayList2 = new ArrayList(100); // define the size
            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);
            Console.WriteLine("Total count at start {0}", myArrayList.Count);
            // delete element with a specific value from the array list - just one instance if there are more than one entry with same value
            myArrayList.Remove(13);
            Console.WriteLine("Total count first removal {0}", myArrayList.Count);
            
            // delete element at a specific position/ index
            myArrayList.RemoveAt(0); // will remove first entry i.e. 25

            Console.WriteLine("Total final count {0}", myArrayList.Count);

            double sum = 0;

            foreach(object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                } else if (obj is double)
                {
                    sum += (double)obj;
                } else if (obj is string)
                {
                    Console.WriteLine(" The item is a string: " + obj);
                }
            }
            Console.WriteLine("Total final count {0}", sum);
        }
    }
}
