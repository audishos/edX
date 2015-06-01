using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_Assignment
{
    class Assignment4
    {
        // Create a struct to represent a student
        struct Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime Birthday { get; set; }
        }

        // Create a struct to represent a teacher
        struct Teacher
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime Birthday { get; set; }
        }

        // Create a struct to represent a program
        struct Program
        {
            public string Name { get; set; }
            public string Degree { get; set; }
            public int CreditsRequired { get; set; }
        }

        // Create a struct to represent a course
        struct Course
        {
            public string Name { get; set; }
            public string Code { get; set; }
            public int CreditsEarned { get; set; }
        }

        static void Main(string[] args)
        {
            // Create an array to hold 5 student structs
            Student[] students = new Student[5];

            // Accidentally overwrote assign 4 code w/ assign 5 code
            // Saved the challenge code separately so submitting it instead

            // Use an appropriate looping structure to add values to all student structs in the array
            // by prompting a user of the application to enter values for fields
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Enter information for student {0}", i + 1);
                Console.WriteLine("-----------------------------------------");
                Console.Write("First Name: ");
                students[i].FirstName = Console.ReadLine();
                Console.Write("Last Name: ");
                students[i].LastName = Console.ReadLine();
                Console.Write("Birthday: ");
                students[i].Birthday = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine();
            }

            // create another loop to iterate over the array and write the values to the console window
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Student {0} information", i + 1);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("First Name: {0}", students[i].FirstName);
                Console.WriteLine("Last Name: {0}", students[i].LastName);
                Console.WriteLine("Birthday: {0}", students[i].Birthday);
                Console.WriteLine();
            }

        }
    }
}
