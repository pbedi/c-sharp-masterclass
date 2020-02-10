using System;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;

namespace _15_LinqWithXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentsXML =
                 @"<Students>
                    <Student>
                        <Name>Toni</Name>
                        <Age>21</Age>
                        <University>Yale</University>
                        <Semester>2</Semester>
                    </Student>
                    <Student>
                        <Name>Carla</Name>
                        <Age>17</Age>
                        <University>Yale</University>
                        <Semester>6</Semester>
                    </Student>
                    <Student>
                        <Name>Leyla</Name>
                        <Age>19</Age>
                        <University>Oxford</University>
                        <Semester>4</Semester>
                    </Student>
                    <Student>
                        <Name>Ruby</Name>
                        <Age>24</Age>
                        <University>Oxford</University>
                        <Semester>4</Semester>
                    </Student>
                 </Students>";
            XDocument studentXdoc = new XDocument();
            studentXdoc = XDocument.Parse(studentsXML);

            var students = from student in studentXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Semester = student.Element("Semester").Value
                           };
            foreach(var student in students)
            {
                Console.WriteLine("Student {0} with age {1} of University {2}", student.Name, student.Age, student.University);
            }

            var sortedStudents = from student in students orderby student.Age select student;
            Console.WriteLine("Sorted on Age List");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("Student {0} with age {1} in Semester {2} of University {3}", student.Name, student.Age, student.Semester, student.University);
            }

            Console.ReadKey();
        }
    }
}
