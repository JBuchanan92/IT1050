using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor John = new Instructor();
            John.Name = "John";
            John.CourseName = "English";

            Instructor Mike = new Instructor();
            Mike.Name = "Mike";
            Mike.CourseName = "Math";

            Student Jane = new Student();
            Jane.Name = "Jane";
            Jane.Teacher = John;

            Student Joe = new Student();
            Joe.Name = "Joe";
            Joe.Teacher = John;

            Student Melissa = new Student();
            Melissa.Name = "Melissa";
            Melissa.Teacher = Mike;

            Student Matt = new Student();
            Matt.Name = "Matt";
            Matt.Teacher = Mike;

            John.SetStudentGrade(Jane, 95);
            John.SetStudentGrade(Joe, 85);
            Mike.SetStudentGrade(Melissa, 90);
            Mike.SetStudentGrade(Matt, 92);

            Jane.PrintStudentInfo();
            Joe.PrintStudentInfo();
            Melissa.PrintStudentInfo();
            Matt.PrintStudentInfo();



        }
    }
}
