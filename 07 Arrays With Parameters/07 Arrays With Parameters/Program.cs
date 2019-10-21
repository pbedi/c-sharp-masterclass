using System;

namespace _07_Arrays_As_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gradesOfStudents = new int[] { 2, 4, 6, 8, 9 };
            foreach(int grade in gradesOfStudents)
            {
                Console.WriteLine("Score {0}", grade);
            }
            double averageResult = GetAverage(gradesOfStudents);
            Console.WriteLine("Average is {0}", averageResult);

        }

        static double GetAverage(int[] gradeArray)
        {
            double average;
            int size = gradeArray.Length;
            int sum = 0;

            for(int i = 0; i < size; i++)
            {
                sum += gradeArray[i];
            }

            average = (double) sum / size;

            return average;
        }
    }
}
