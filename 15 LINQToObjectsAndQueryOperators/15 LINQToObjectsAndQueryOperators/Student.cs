using System;
using System.Collections.Generic;
using System.Text;

namespace _15_LINQToObjectsAndQueryOperators
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        //Foreign key
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student {0} with Id {1} Gender {2} age {3} from University with the Id {4}", Name, Id, Gender, Age, UniversityId);
        }
    }
}
