using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Person
    {

        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;

        public static double SumofAllAges;

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }


        public void PrintNameAndAge()
        {
            Console.WriteLine("My name is " + this.GetFullName() + ".");
            Console.WriteLine("My age is " + this.Age + ".");
        }





}
}
