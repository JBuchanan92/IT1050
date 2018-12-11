using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Student
    {

        public string Name;
        public int Grade;
        public Instructor Teacher;

        public void SetGrade(int Grade)
        {
            this.Grade = Grade;
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine("Student: " + this.Name);
            Console.WriteLine("Instructor: " + this.Teacher.Name);
            Console.WriteLine("Course: " + this.Teacher.CourseName);
            Console.WriteLine("Grade: " + this.Grade + "\n");
        }

    }
}
