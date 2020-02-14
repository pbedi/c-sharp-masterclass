using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace _15_LinqToSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSqlDataClassesDataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["_15_LinqToSQL.Properties.Settings.PunjututorialDBConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);

            //InsertUniversities("Oxford");
            //InsertStudents("Yale", "Carla", "female");
            //InsertLectures();
            //AssociateStudentWithLecture();
            //GetUniversityOfTony();
            //GetTonisLecturs();
            //GetAllStudentsFromYale();
            //GetAllUniversitiesWithTransgenders();
            //getAllLecturesTaughtAtOxford();
            //UpdateToni();
            DeleteTracy();
        }

        public void InsertUniversities(string name)
        {
            // to delete all records
            //dataContext.ExecuteCommand("delete from University");
            University uniObj = new University();
            uniObj.Name = name;
            dataContext.Universities.InsertOnSubmit(uniObj);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudents(string uni, string stuName, string gender)
        {
            // to delete all records
            //dataContext.ExecuteCommand("delete from Student");
            University objUni = dataContext.Universities.First(un => un.Name.Equals(uni));
            University oxford = dataContext.Universities.First(un => un.Name.Equals("Oxford"));
            List<Student> students = new List<Student>();

            students.Add(new Student { Name = stuName, Gender = gender, UniversityId = objUni.Id });
            students.Add(new Student { Name = "Toni", Gender = "male", University = objUni });
            students.Add(new Student { Name = "Leyla", Gender = "female", University = oxford });
            students.Add(new Student { Name = "James", Gender = "male", University = oxford });
            students.Add(new Student { Name = "Tracy", Gender = "trans-gender", University = oxford });
            students.Add(new Student { Name = "Neol", Gender = "trans-gender", University = oxford });

            dataContext.Students.InsertAllOnSubmit(students);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void InsertLectures()
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Maths" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "History" });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Lectures;
        }

        public void AssociateStudentWithLecture()
        {
            Student carla = dataContext.Students.First(stu => stu.Name.Equals("Carla"));
            Student toni = dataContext.Students.First(stu => stu.Name.Equals("Toni"));
            Student leyla = dataContext.Students.First(stu => stu.Name.Equals("Leyla"));
            Student james = dataContext.Students.First(stu => stu.Name.Equals("James"));

            Lecture maths = dataContext.Lectures.First(lec => lec.Name.Equals("Maths"));
            Lecture history = dataContext.Lectures.First(lec => lec.Name.Equals("History"));

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = carla, Lecture = maths });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = toni, Lecture = maths });

            StudentLecture slToni = new StudentLecture();
            slToni.Student = toni;
            slToni.LectureId = history.Id;
            dataContext.StudentLectures.InsertOnSubmit(slToni);
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = leyla, Lecture = history });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = james, Lecture = maths });
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.StudentLectures;
        }

        public void GetUniversityOfTony()
        {
            Student toni = dataContext.Students.First(stu => stu.Name.Equals("Toni"));
            University universityOfTony = toni.University;

            List<University> universities = new List<University>();
            universities.Add(universityOfTony);

            MainDataGrid.ItemsSource = universities;
        }

        public void GetTonisLecturs()
        {
            Student toni = dataContext.Students.First(stu => stu.Name.Equals("Toni"));
            var tonisLectures = from sl in toni.StudentLectures select sl.Lecture;

            MainDataGrid.ItemsSource = tonisLectures;
        }

        public void GetAllStudentsFromYale()
        {
            var studentsFromYale = from student in dataContext.Students where student.University.Name == "Yale" select student;

            MainDataGrid.ItemsSource = studentsFromYale;
        }

        public void GetAllUniversitiesWithTransgenders()
        {
            var universitiesWithTG = from student in dataContext.Students
                                     join university in dataContext.Universities on student.University equals university
                                     where student.Gender == "trans-gender" select university;

            MainDataGrid.ItemsSource = universitiesWithTG;
        }

        public void getAllLecturesTaughtAtOxford()
        {
            var lectureTought = from student in dataContext.Students
                                join studentLecture in dataContext.StudentLectures 
                                on student.Id equals studentLecture.StudentId //join 
                                //lecture in dataContext.Lectures on studentLecture.LectureId equals lecture.Id
                                where student.University.Name == "Oxford"
                                select studentLecture.Lecture;
            MainDataGrid.ItemsSource = lectureTought;
        }

        public void UpdateToni()
        {
            Student Toni = dataContext.Students.First(st => st.Name == "Toni");
            Toni.Name = "Antonio";

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void DeleteTracy()
        {
            Student Tracy = dataContext.Students.First(st => st.Name == "Tracy");

            dataContext.Students.DeleteOnSubmit(Tracy);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }
    }
}
