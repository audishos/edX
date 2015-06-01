using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mod_9_Homework
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        public Person(string fName, string lName, string city)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.City = city;
        }
    }

    class Student : Person
    {
        private static int enrolledCount = 0;
        private Stack<Decimal> grades = new Stack<Decimal>();

        // Modify your Student and Teacher classes so that they inherit the common attributes from Person
        public Student(string fName, string lName, string city)
            : base(fName, lName, city)
        {
            enrolledCount++; // Increases enrolledCount by 1 when default constructor is called
        }

        // Returns read-only enrolled count
        public static int EnrolledCount
        {
            get { return enrolledCount; }
        }

        // Modify your Student and Teacher classes so they include characteristics specific to their type
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

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        int currentStudent = 0; // Used for cycling through student records

        public MainWindow()
        {
            InitializeComponent();
        }

        // Method to clear all text boxes
        public void ClearText()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student(txtFirstName.Text, txtLastName.Text, txtCity.Text);
            students.Add(student);
            currentStudent = students.Count;
            ClearText();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            // Cycle back through student records
            if (currentStudent > 0)
            {
                currentStudent--;
                txtFirstName.Text = students[currentStudent].FirstName;
                txtLastName.Text = students[currentStudent].LastName;
                txtCity.Text = students[currentStudent].City;
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            // Cycle forward through student records
            if (currentStudent < students.Count - 1)
            {
                currentStudent++;
                txtFirstName.Text = students[currentStudent].FirstName;
                txtLastName.Text = students[currentStudent].LastName;
                txtCity.Text = students[currentStudent].City;
            }

            // If at the end of the list, clear text fields for new entry and add 1 to currentStudent
            else if(currentStudent == students.Count - 1)
            {
                currentStudent++;
                ClearText();
            }

            // If past the end of the list, clear text fields for new entry
            else
            {
                ClearText();
            }
        }
    }
}
