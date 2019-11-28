using System;
using System.Collections;
using System.Collections.Generic;

namespace _11_Access_Modifiers_List_vs_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //immutable - limited to one type
            int[] scores = new int[] { 99, 96, 87, 76 };

            List<int> list = new List<int> { 1, 2, 3, 4 };
            list.Add(0);
            list.Add(32);

            list.Sort();
            list.RemoveRange(2, 2);
            
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("4 contains in the list? " + list.Contains(4));
            int index = list.FindIndex(x => x == 4);
            Console.WriteLine("4 is at the position of {0} in the list " , index);

            list.RemoveAt(index); // to remove from a position
            Console.WriteLine("Final list:");
            list.ForEach(i =>
            {
                Console.WriteLine(i);
            });
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("two");
            arrayList.Add("3");
            arrayList.Add(new Number { n = 4 });
            Console.WriteLine("Printing arrayList");
            foreach(Object o in arrayList)
            {
                Console.WriteLine(o);
            }
            Console.ReadLine();
            
        }
    }

    class Number
    {
        public int n { get; set; }

        public override string ToString()
        {
            return n.ToString();
        }
    }
}
