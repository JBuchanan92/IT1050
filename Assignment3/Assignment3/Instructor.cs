using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Instructor
    {

        public string Name;
        public string CourseName;
    
        public void SetStudentGrade(Student NameOfStudent, int Grade)
        {
            NameOfStudent.Grade = Grade;
        }

        public void PrintInstructorInfo()
        {
            Console.WriteLine(this.Name + this.CourseName);
        }




    }
}
