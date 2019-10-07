using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Arrays
{
    public class MultiDim
    {
        // 2 dim
        int[,] multiDim = new int[2,10];

        // 3 dim
        string[,,] multiStr = new string[,,]
        {
            {
                { "000", "001"},
                { "010", "011"}
            }
        };

        int[,] array2D = new int[,]
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };
        public MultiDim()
        {
            Console.WriteLine("Initiating MultiDim Class");
            multiStr[0, 0, 0] = "000";
            multiStr[0, 0, 1] = "002";
            //multiStr[0, 0, 2] = "003";
            multiStr[0, 1, 0] = "020";
            multiStr[0, 1, 1] = "022";
            //multiStr[0, 1, 2] = "023";
        }
        
        public void printArray2D(int pos1,int pos2)
        {
            Console.WriteLine("  Value from array2D at [{0},{1}] is {2}", pos1, pos2,array2D[pos1,pos2]);
        }

        public void printArray3D(int pos1, int pos2, int pos3)
        {
            
            Console.WriteLine("  Value from multiStr 3D at [{0},{1},{2}] is {3}", pos1, pos2, pos3, multiStr[pos1, pos2,pos3]);
        }
    }

}
