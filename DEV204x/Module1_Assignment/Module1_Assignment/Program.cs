using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Module1_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentFName;
            string studentLName;
            string studentBirthdate;
            string studentAddress1;
            string studentAddress2;
            string studentCity;
            string studentStateProvince;
            string studentZipPostal;
            string studentCountry;
            string studentMajor;
            string studentMinor;

            string profFName;
            string profLName;
            string profBirthdate;
            string profAddress;
            string profCity;
            string profStateProvince;
            string profZipPostal;
            string profCountry;

            string degreeName;
            string degreeType;
            double degreeCreditsRequired;

            string programName;
            string programDegree;
            string programDepartmentHead;

            string courseName;
            string courseCode;
            string courseProf;
            double courseLength;

            studentFName = "Audisho";
            studentLName = "Sada";
            studentBirthdate = "April 5, 1988";
            studentAddress1 = "159 Beverley St";
            studentAddress2 = "Apt 3";
            studentCity = "Toronto";
            studentStateProvince = "Ontario";
            studentZipPostal = "M5T 1Y7";
            studentCountry = "Canada";
            studentMajor = "CS";
            studentMinor = "NA";

            profFName = "Bruce";
            profLName = "Wayne";
            profBirthdate = "February 19, 1975";
            profAddress = "1007 Mountain Drive";
            profCity = "Gotham";
            profStateProvince = "New Jersey";
            profZipPostal = "94514";
            profCountry = "USA";

            degreeName = "Bachelor of Science";
            degreeType = "BSc";
            degreeCreditsRequired = 40.0;

            programName = "Computer Science";
            programDegree = "BSc";
            programDepartmentHead = "James Gordon";

            courseName = "Programming with C#";
            courseCode = "DEV204x";
            courseProf = "Bruce Wayne";
            courseLength = 4.5;

            Console.WriteLine("Student");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Name: {0} {1}", studentFName, studentLName);
            Console.WriteLine("DOB: {0}", studentBirthdate);
            Console.WriteLine("Address: {0} {1}", studentAddress1, studentAddress2);
            Console.WriteLine("City: {0}", studentCity);
            Console.WriteLine("State/Province: {0}", studentStateProvince);
            Console.WriteLine("ZIP/Postal: {0}", studentZipPostal);
            Console.WriteLine("Country: {0}", studentCountry);
            Console.WriteLine("Major: {0}", studentMajor);
            Console.WriteLine("Minor {0}", studentMinor);
           
            Console.WriteLine();
            
            Console.WriteLine("Professor");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Name: {0} {1}", profFName, profLName);
            Console.WriteLine("Birthdate: {0}", profBirthdate);
            Console.WriteLine("Address: {0}", profAddress);
            Console.WriteLine("City: {0}", profCity);
            Console.WriteLine("State/Province: {0}", profStateProvince);
            Console.WriteLine("ZIP/Postal: {0}", profZipPostal);
            Console.WriteLine("Country: {0}", profCountry);
         
            Console.WriteLine();
            
            Console.WriteLine("Degree");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Name: {0}", degreeName);
            Console.WriteLine("Type: {0}", degreeType);
            Console.WriteLine("Credits Required: {0}", degreeCreditsRequired);
         
            Console.WriteLine();
            
            Console.WriteLine("Program");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Name: {0}", programName);
            Console.WriteLine("Degree: {0}", programDegree);
            Console.WriteLine("Department Head: {0}", programDepartmentHead);
          
            Console.WriteLine();
            
            Console.WriteLine("Course");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Name: {0}", courseName);
            Console.WriteLine("Code: {0}", courseCode);
            Console.WriteLine("Professor: {0}", courseProf);
            Console.WriteLine("Hours Per Week: {0}", courseLength);
          
            Console.WriteLine();
            Console.WriteLine();
          
            Console.WriteLine("Enter new course information");
            Console.Write("Name: ");
            courseName = Console.ReadLine();
            Console.Write("Code: ");
            courseCode = Console.ReadLine();
            Console.Write("Professor: ");
            courseProf = Console.ReadLine();
            Console.Write("Hours Per Week: ");
            courseLength = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Course");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Name: {0}", courseName);
            Console.WriteLine("Code: {0}", courseCode);
            Console.WriteLine("Professor: {0}", courseProf);
            Console.WriteLine("Hours Per Week: {0}", courseLength);
           
            Console.WriteLine();
            Console.WriteLine();        
        }
    }
}
