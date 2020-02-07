using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace _15_LINQToObjectsAndQueryOperators
{
    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;
        //constructor
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Oxford" });

            //students
            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Philip", Gender = "male", Age = 22, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Cathy", Gender = "female", Age = 22, UniversityId = 2 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male - Students: ");

            foreach(Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Female - Students: ");

            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }

        public void SortStudentByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;
            Console.WriteLine("Students sorted by age:");

            foreach(Student student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromAUni(string universityName)
        {
            var studendsFromAUni = from student in students
                                   join university in universities on student.UniversityId equals university.Id
                                   where university.Name == universityName select student;
            Console.WriteLine("Students from University: {0}", universityName);

            foreach (Student student in studendsFromAUni)
            {
                student.Print();
            }
        }
    }
}
