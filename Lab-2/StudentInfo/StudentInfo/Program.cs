using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("CSE");
            Department d2 = new Department("EEE");

            Student s1 = new Student("nahida", "19-41190-2", 3.1);
            Student s2 = new Student("AKASH", "19-41191-2", 3.20);
            Student s3 = new Student("Himel", "19-41231-2", 3.30);
            Student s4 = new Student("Navay", "19-41516-2", 2.50);

            Course c1 = new Course("SE", "seK");
            Course c2 = new Course("ED", "edN");
            Course c3 = new Course("MATH 5", "math5N");
            Course c4 = new Course("BS", "bsb");
            Course c5 = new Course("ECO", "ecof");


            d1.AddStudent(s1, s2);
            d2.AddStudent(s3);
            d2.AddStudent(s4);

            d1.PrintStudent();
            d2.PrintStudent();

            Console.WriteLine("\n_____________________\n\nAdding Droping\n\n_____________________\n");

            s1.AddCourse(c1);
            s1.AddCourse(c2);
            s1.AddCourse(c3);
            s1.AddCourse(c4);
            

            s1.DropCourse(c5);

            s1.AddCourse(c1);
           

            s2.AddCourse(c1);
            s3.AddCourse(c1);
            s4.AddCourse(c1);

            s1.ShowCourses();
            s2.ShowCourses();

            c1.ShowStudents();
            c2.ShowStudents();

            Console.ReadLine();
        }
    }
}