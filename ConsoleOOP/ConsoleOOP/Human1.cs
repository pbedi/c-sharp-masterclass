using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleOOP
{
    class Human1
    {
        private string firstName;
        private string lastName;
        private string eyeColour;
        private int age;

        //constructor 
        public Human1(string fname, string lname, string eColour, int ag)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.eyeColour = eColour;
            this.age = ag;
        }

        //member
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I am {0} {1}, my eye colour is {2}, and my age is {3}", this.firstName, this.lastName, this.eyeColour, this.age);
        }
    }
}
