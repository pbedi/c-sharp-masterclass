using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleOOP
{
    //this class is a blueprint for a datatype
    class Human
    {
        string firstName = "Philip";
        public string lastName { get; set; }

        //member
        public void IntroduceMyself()
        {
            lastName = "Bedi";
            Console.WriteLine("Hi, I am {0} {1}", firstName, lastName);
        }
    }
}
