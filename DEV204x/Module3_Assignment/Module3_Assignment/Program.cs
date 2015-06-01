using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInfo();
            GetTeacherInfo();
            GetCourseInfo();
        }

        //Get info for a student
        static void GetStudentInfo()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthdate: ");
            
            DateTime birthdate = new DateTime();

            birthdate = Convert.ToDateTime(Console.ReadLine());

            //Not sure that I'm doing exception handling correctly here
            //If not, please let me know what I'm doing wrong. Thanks! :)
            try
            {
                ValidateBirthdate(birthdate);
                PrintPersonDetails(firstName, lastName, birthdate);
            }
            catch (Exception)
            {
                Console.WriteLine("Student must be 18 years of age.");
            }

        }

        //Validate that the student is at least 18 years of age
        private static void ValidateBirthdate(DateTime birthdate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthdate.Year;

            if (age < 18)
            {
                throw new Exception();
            }
        }

        //Print student/teacher details
        static void PrintPersonDetails(string first, string last, DateTime birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}-{3}-{4}", first, last, birthday.Year, birthday.Month, birthday.Day);
        }

        //Get info for a teacher
        static void GetTeacherInfo()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's birthdate: ");

            DateTime birthdate = new DateTime();
            birthdate = Convert.ToDateTime(Console.ReadLine());

            PrintPersonDetails(firstName, lastName, birthdate);
        }

        //Get info for a course
        static void GetCourseInfo()
        {
            Console.WriteLine("Enter the course name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the course code: ");
            string code = Console.ReadLine();
            Console.WriteLine("Enter the course start date: ");
            string start = Console.ReadLine();

            PrintCourseInfo(name, code, start);
        }

        //Print course details
        static void PrintCourseInfo(string name, string code, string start)
        {
            Console.WriteLine("{0} : {1} starts on: {2}", name, code, start);
        }

        //Rinse and repeat for 'program' and 'degree' (I wish there was more variety to this...)
    }
}
