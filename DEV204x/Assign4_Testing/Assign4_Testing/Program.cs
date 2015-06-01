using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03
{
    class Program
    {
        static void GetStudentInfo()
        {
            //get student input
            Console.WriteLine("Enter the student's first name: ");
            string student_First_Name = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string student_Last_Name = Console.ReadLine();
            Console.WriteLine("Enter the student's city");
            string student_City = Console.ReadLine();

            ////Assign Student fields. UNCOMMENT BLOCK BELOW and COMMENT BLOCK ABOVE for fast check
            //string student_First_Name = "Eric";
            //string student_Last_Name = "Firth";
            ////student_Birthdate = "01/01/1982";
            //string student_City = "New York City";

            //blank line
            Console.WriteLine();

            //print student details
            PrintStudentDetails(student_First_Name, student_Last_Name, student_City);

            //blank line
            Console.WriteLine();
        }

        static void GetTeacherInfo()
        {
            //get teacher input
            Console.WriteLine("Enter the teacher's first name: ");
            string teacher_First_Name = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name");
            string teacher_Last_Name = Console.ReadLine();
            Console.WriteLine("Enter the teacher's city");
            string teacher_City = Console.ReadLine();

            ////Assign teacher fields. UNCOMMENT BLOCK BELOW and COMMENT BLOCK ABOVE for fast check
            //string teacher_First_Name = "Tom";
            //string teacher_Last_Name = "Smith";
            //string teacher_City = "New York City";

            //blank line
            Console.WriteLine();

            //print teacher details
            PrintStudentDetails(teacher_First_Name, teacher_Last_Name, teacher_City);

            //blank line
            Console.WriteLine();
        }

        static void GetCourseInfo()
        {
            //get course input
            Console.WriteLine("Enter the course name: ");
            string course_Name = Console.ReadLine();
            Console.WriteLine("Enter the course teacher: ");
            string course_Teacher = Console.ReadLine();
            Console.WriteLine("Enter the course number: ");
            string course_Number = Console.ReadLine();

            ////Assign course fields. UNCOMMENT BLOCK BELOW and COMMENT BLOCK ABOVE for fast check
            //string course_Name = "Data Structures";
            //string course_Teacher = "Tom Smith";
            //string course_Number = "301";

            //blank line
            Console.WriteLine();

            //print teacher details
            PrintCourseDetails(course_Name, course_Number, course_Teacher);

            //blank line
            Console.WriteLine();
        }

        static void GetProgramInfo()
        {
            //get Program input
            Console.WriteLine("Enter the program name (i.e. Computer Science): ");
            string program_Name = Console.ReadLine();
            Console.WriteLine("Enter the program Degrees Offered (i.e. Bachelor's Degree): ");
            string program_Degrees_Offered = Console.ReadLine();
            Console.WriteLine("Enter the program department head");
            string program_Department_Head = Console.ReadLine();

            ////Assign Program fields. UNCOMMENT BLOCK BELOW and COMMENT BLOCK ABOVE for fast check
            //string program_Name = "Computer Science";
            //string program_Degrees_Offered = "Bachelor's Degree";
            //string program_Department_Head = "Jane Nelson";

            //blank line
            Console.WriteLine();

            //print Program details
            PrintProgramDetails(program_Name, program_Degrees_Offered, program_Department_Head);

            //blank line
            Console.WriteLine();
        }

        static void GetDegreeInfo()
        {
            //get Degree input
            Console.WriteLine("Enter the degree name (i.e. Bachelor of Science): ");
            string degree_Name = Console.ReadLine();
            Console.WriteLine("Enter the degree major");
            string degree_Major = Console.ReadLine();
            Console.WriteLine("Enter the degree credits required");
            string degree_Credits_Required = Console.ReadLine();

            ////Assign Degree fields. UNCOMMENT BLOCK BELOW and COMMENT BLOCK ABOVE for fast check
            //string degree_Name = "Bachelor of Science";
            //string degree_Major = "Computer Science";
            //string degree_Credits_Required = "120";

            //blank line
            Console.WriteLine();

            //print Degree details
            PrintDegreeDetails(degree_Name, degree_Major, degree_Credits_Required);

            //blank line
            Console.WriteLine();
        }
        //Print methods
        static void PrintStudentDetails(string first, string last, string city)
        {
            Console.WriteLine("{0} {1} lives in {2}.", first, last, city);
        }

        static void PrintTeacherDetails(string first, string last, string city)
        {
            Console.WriteLine("{0} {1} lives in {2}.", first, last, city);
        }

        static void PrintCourseDetails(string name, string number, string teacher)
        {
            Console.WriteLine("{0}, course number {1}, is taught by {2}.", name, number, teacher);
        }

        static void PrintProgramDetails(string name, string degree, string head)
        {
            Console.WriteLine("The {0} department offers a {1} and is heaed by {2}.", name, degree, head);
        }

        static void PrintDegreeDetails(string name, string major, string credits)
        {
            Console.WriteLine("A {0} in {1} requires {2} credits.", name, major, credits);
        }

        //ONLY THROWING EXCEPTION. NOT HANDLING. Following instructions and staff guidance in discussion board.
        static void ValidateBirthdate()
        {
            //Console.WriteLine("ValidateBirthdate() called");
            throw new NotImplementedException();
        }
        static void Main(string[] args)
        {
            //call methods
            GetStudentInfo();
            GetTeacherInfo();
            GetCourseInfo();
            GetProgramInfo();
            GetDegreeInfo();
            ValidateBirthdate();

        }
    }
}