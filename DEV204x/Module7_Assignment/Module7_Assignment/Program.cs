using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_Assignment
{
    class Assignment7
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

            // Add grades to students
            student1.AddGrade(95);
            student1.AddGrade(81);
            student1.AddGrade(85);
            student1.AddGrade(84);
            student1.AddGrade(78);

            student2.AddGrade(75);
            student2.AddGrade(84);
            student2.AddGrade(69);
            student2.AddGrade(81);
            student2.AddGrade(90);

            student3.AddGrade(78);
            student3.AddGrade(68);
            student3.AddGrade(79);
            student3.AddGrade(82);
            student3.AddGrade(80);
            
            // Define a course object
            Course course = new Course("Programming with C#");

            // Assign the 3 student objects to the course
            course.AddStudent(student1);
            course.AddStudent(student2);
            course.AddStudent(student3);

            // Define a teacher object
            Teacher teacher1 = new Teacher("George", "Washington");

            // Assign the teacher object to the course
            course.AddTeacher(teacher1);

            // Define a new degree object
            Degree degree = new Degree("Bachelor");

            // Assign the course object to the degree's course object
            degree.Courses = course;

            // Define a new uprogram object
            UProgram uprogram = new UProgram("Information Technology");

            // Assign the degree object to the uprogram's degree object
            uprogram.Degrees = degree;

            // Call method to list students in the course
            course.ListStudents();
        }

        // 1. Create a Person base class with common attributes for a person
        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime Birthday { get; set; }

            public Person(string fName, string lName)
            {
                this.FirstName = fName;
                this.LastName = lName;
            }
        }

        // 2. Make your Student and Teacher classes inherit from the Person base class
        class Student : Person
        {
            private static int enrolledCount = 0;
            private Stack grades = new Stack();

            // 3. Modify your Student and Teacher classes so that they inherit the common attributes from Person
            public Student(string fName, string lName)
                : base(fName, lName)
            {
                enrolledCount++; // Increases enrolledCount by 1 when default constructor is called
            }

            // Returns read-only enrolled count
            public static int EnrolledCount
            {
                get { return enrolledCount; }
            }

            // 4. Modify your Student and Teacher classes so they include characteristics specific to their type
            public void TakeTest()
            {
                Console.WriteLine("{0} {1} took the test.", this.FirstName, this.LastName);
            }

            // Method to add grades to the stack
            public void AddGrade(decimal grade)
            {
                grades.Push(grade);
            }
        }

        // 2. Make your Student and Teacher classes inherit from the Person base class
        class Teacher : Person
        {
            // 3. Modify your Student and Teacher classes so that they inherit the common attributes from Person
            public Teacher(string fName, string lName) : base(fName, lName) { }

            // 4. Modify your Student and Teacher classes so they include characteristics specific to their type
            public void GradeTest()
            {
                Console.WriteLine("{0} {1} graded the test.", this.FirstName, this.LastName);
            }
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
            private ArrayList students = new ArrayList();
            private ArrayList teachers = new ArrayList();

            public Course(string name)
            {
                this.Name = name;
            }

            // Method to output all students in the students ArrayList
            public void ListStudents()
            {
                foreach (Object student in students)
                {
                    Student stud = (Student)student;
                    Console.WriteLine("{0} {1}", stud.FirstName, stud.LastName);
                }
            }

            // Method to add students
            public void AddStudent(Student student)
            {
                students.Add(student);
            }

            // Method to add teachers
            public void AddTeacher(Teacher teacher)
            {
                teachers.Add(teacher);
            }
        }
    }
}