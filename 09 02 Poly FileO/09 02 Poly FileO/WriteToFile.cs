using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _09_02_Poly_FileO
{
    public class WriteToFile
    {
        public void WriteDetails(string[] lines)
        {
            File.WriteAllLines(@"C:\Users\pbedi\source\repos\c-sharp-masterclass\assets\textFile1.txt", lines);
            Console.WriteLine("File has been written");
        }
    }
}
