using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_Assignment
{
    class Assignment4
    {
        // Define number of students and number of teachers
        const int numStudents = 3;
        const int numTeachers = 1;

        static void Main(string[] args)
        {
            // Define 3 student objects
            Student student1 = new Student("Nicola", "Tesla");
            Student student2 = new Student("Alexander", "Graham Bell");
            Student student3 = new Student("Leonardo", "DaVinci");

            // Define a course object
            Course course = new Course("Programming with C#");

            // Assign the 3 student objects to the course's student objects
            course.Students[0] = student1;
            course.Students[1] = student2;
            course.Students[2] = student3;

            // Define a teacher object
            Teacher teacher1 = new Teacher("George", "Washington");

            // Assign the teacher object to the course's teacher object
            course.Teachers[0] = teacher1;

            // Define a new degree object
            Degree degree = new Degree("Bachelor");

            // Assign the course object to the degree's course object
            degree.Courses = course;

            // Define a new uprogram object
            UProgram uprogram = new UProgram("Information Technology");

            // Assign the degree object to the uprogram's degree object
            uprogram.Degrees = degree;

            // Output
            Console.WriteLine("The {0} contains the {1} degree", uprogram.Name, uprogram.Degrees.Name);
            Console.WriteLine();
            Console.WriteLine("The {0} degree contains the course {1}", degree.Name, degree.Courses.Name);
            Console.WriteLine();
            Console.WriteLine("The {0} course contains {1} student(s)", course.Name, Student.EnrolledCount);
        }

        // Base class for Student and Teacher
        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime Birthday { get; set; }

            public Person(string fName, string lName)
            {
                FirstName = fName;
                LastName = lName;
            }
        }

        // Student class, derived from Person
        class Student : Person
        {
            private static int enrolledCount = 0;
            
            
            public Student(string fName, string lName) : base(fName, lName)
            {
                enrolledCount++; // Increases enrolledCount by 1 when default constructor is called
            }

            // Returns read-only enrolled count
            public static int EnrolledCount
            {
                get { return enrolledCount; }
            }
        }

        // Teacher class, derived from Person
        class Teacher : Person
        {
            public Teacher(string fName, string lName) : base(fName, lName){}
        }

        // Program class
        class UProgram
        {
            public string Name { get; set; }
            public Degree Degrees { get; set; }

            public UProgram(string name)
            {
                this.Name = name;
            }
        }

        // Degree class
        class Degree
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public int CreditsRequired { get; set; }
            public Course Courses { get; set; }

            public Degree(string name)
            {
                this.Name = name;
            }
        }

        // Course class
        class Course
        {
            public string Name { get; set; }
            public string Code { get; set; }
            public int CreditsEarned { get; set; }
            private Student[] students = new Student[numStudents];
            private Teacher[] teachers = new Teacher[numTeachers];

            public Course(string name)
            {
                this.Name = name;
            }

            public Student[] Students
            {
                get { return students; }
                set { students = value; }
            }

            public Teacher[] Teachers
            {
                get { return teachers; }
                set { teachers = value; }
            }
        }
    }
}
