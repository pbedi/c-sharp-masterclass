using System;
using System.IO;

namespace _09_02_Poly_FileO
{
    class Program
    {
        static void Main(string[] args)
        {
            //reading text
            string text = System.IO.File.ReadAllText(@"C:\Users\pbedi\source\repos\c-sharp-masterclass\assets\textFile.txt");
            Console.WriteLine(text);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\pbedi\source\repos\c-sharp-masterclass\assets\textFile.txt");

            Console.WriteLine("Content of textFile.txt is = ");

            foreach(string line in lines)
            {
                Console.WriteLine("\t" + line);
            }

            // write in file
            WriteToFile write = new WriteToFile();
            string[] lines1 = { "First line", "Second line", "Third line" };
            write.WriteDetails(lines1);

            //method 3
            string[] lines2 = { "250", "242 Third", "Third 240" };

            using(StreamWriter file = new StreamWriter(@"C:\Users\pbedi\source\repos\c-sharp-masterclass\assets\myTextFile.txt"))
            {
               foreach(string line in lines2)
                {
                    if (line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
            Console.WriteLine("File myTextFile.txt updated ");

            using (StreamWriter file = new StreamWriter(@"C:\Users\pbedi\source\repos\c-sharp-masterclass\assets\myTextFile.txt", true))
            {
                file.WriteLine("Additional line");
            }
            Console.WriteLine("File myTextFile.txt updated with additional text ");
        }
    }
}
