using System;

namespace _07___Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[5];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 5, 7, 11 };
            jaggedArray[2] = new int[] { 12, 21 };

            //alternative way
            int[][] jaggedArrayAlt = new int[][]
            {
                new int[] { 2, 3, 5, 7, 11},
                new int[] { 5, 7, 11 }
            };

            Console.WriteLine("The value of the middle of the first entry is {0}", jaggedArrayAlt[0][2]);
            int pos = 1;
            foreach(int[] item in jaggedArrayAlt)
            {
                Console.WriteLine( "The item at {0} has {1} number of items", pos, item.Length );
                foreach (int item1 in item)
                {
                    Console.WriteLine("  The item {0}", item1 );
                }
                pos++;
            }
            FriendsFamily frindsFamily = new FriendsFamily();
            frindsFamily.GetFriends();
        }
    }
}
