using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleOOP
{
    public class Members
    {
        // members - private
        private string memberName;
        private string jobTitle;
        private int salary;

        // members - public
        public int age;

        // member - property
        public string JobTitle {
            get
            {
                return this.jobTitle;
            }
            set
            {
                this.jobTitle = value;
            }
        }

        // public member method
        public void Introducing(bool isFriend)
        {
            Console.WriteLine("Hi, My name is {0}, and my job title is {1}, I am {2} years old", this.memberName, this.JobTitle, this.age);
            if (isFriend)
            {
                SharingPrivateInfo();
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", this.salary);
        }
        // member constructor
        public Members()
        {
            memberName = "Philip";
            age = 50;
            jobTitle = "Engineer";
            salary = 56000;
            Console.WriteLine("Object created");
        }

        //member - finaliser - destructor
        ~Members()
        {
            //clean up statement
            Console.WriteLine("Destruction of Members object");
            Debug.WriteLine("Destruction of Members object");
        }
    }
}
