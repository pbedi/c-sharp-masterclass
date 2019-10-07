using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Arrays
{
    public class ForLoop
    {
        int[] nums = new int[10];

        public ForLoop()
        {
            Console.WriteLine("For Loop");
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }
            Console.WriteLine("  Value at postion 4 is {0}", nums[3]);
            int counter = 0;
            Console.WriteLine("Result from ForEach loop");
            foreach(int k in nums)
            {
                Console.WriteLine("  Element at {0} is {1}", counter, k+10);
                counter++;
            }
        }

        public int[] GetNum()
        {
            return nums;
        }
        
      

    }
}
