using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int heightFeet;
            double heightInches;
            double totalHeightCM;

            System.Console.Write("What is your first name?");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your middle initial?");
            middleInitial = System.Console.ReadLine();

            System.Console.Write("What is your last name?");
            lastName = System.Console.ReadLine();

            fullName = firstName + " " + middleInitial + " " + lastName;

            System.Console.WriteLine(fullName);

            System.Console.Write("What is your height in feet?");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many inches beyond your base height in feet?");
            heightInches = double.Parse(System.Console.ReadLine());

            totalHeightCM = (heightFeet * 12) + (heightInches) * 2.54; 

            System.Console.WriteLine(totalHeightCM);

            System.Console.Write("How old are you? ");
            int age = int.Parse(System.Console.ReadLine());

            System.Console.Write("Are you an American Citizen? ");
            bool isCitizen = bool.Parse(System.Console.ReadLine());

            bool canVote = age > 17 && isCitizen;

            System.Console.WriteLine(canVote);

            System.Threading.Thread.Sleep(5000);

            
















        }
    }
}
