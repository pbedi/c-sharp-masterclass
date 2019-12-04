using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace _11_Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string pattern = @"\d";
            Regex regex = new Regex(pattern);

            string text = "Hi there 77, my number is 12314";

            MatchCollection matchColl = regex.Matches(text);
            Console.WriteLine("{0} hits found:\n {1}", matchColl.Count, text);
            foreach(Match hit in matchColl)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
            }
        }
    }
}
