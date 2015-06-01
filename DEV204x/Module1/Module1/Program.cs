using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            // A statement declaring a variable using a data type int
            // and assigning a value
            int myVar = 2;

            // A statement declaring another int variable
            // Assignment takes place on another line
            int secondVar;
            secondVar = 10;

            int sum = myVar + secondVar;
            int product = myVar * secondVar;
            int remainder = myVar % secondVar;
            double value = (double)myVar / (double)secondVar;

            //Console.WriteLine(sum.ToString());
            //Console.WriteLine(product);
            //Console.WriteLine(remainder);
            //Console.WriteLine(value);

            string firstName = "Tom";
            string lastName = "Sawyer";

            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            Console.WriteLine("{0} {1}", firstName, lastName);
        }
    }
}
