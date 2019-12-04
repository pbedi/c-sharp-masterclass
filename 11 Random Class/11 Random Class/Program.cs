using System;

namespace _11_Random_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Class!");
            Random dice = new Random();
            int numEyes;

            for (int i=0; i < 10; i++)
            {
                numEyes = dice.Next(1, 7);
                Console.WriteLine("{0}: {1}", i+1, numEyes);
            }
            Console.WriteLine("Ask a question?");
            Console.ReadLine();
            int answerNum = dice.Next(1, 7);
            FortuneTeller(answerNum);
        }

        static void FortuneTeller(int num1)
        {
            string ans;
            if (num1 > 1)
            {
                ans = "Yes";
            } else if ( num1 < 1)
            {
                ans = "No";
            } else
            {
                ans = "May Be";
            }

            Console.WriteLine(ans);
        }
    }
}
