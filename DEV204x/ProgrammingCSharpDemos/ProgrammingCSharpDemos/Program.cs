using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgrammingCSharpDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables, Operators, and Expressions

            double myDouble = 1234.6;
            int myInt;
            // Cast double to int by placing the type modifier ahead of the type to be converted
            // in parentheses
            myInt = Convert.ToInt32(myDouble);


            // A statement declaring a variable using a data type int (integer)
            // and assigning a value
            //int myVar = 2;

            
            //// A statement declaring another int variable
            //// Assignment takes place on another line.
            //int secondVar;
            //secondVar = 10;

            //int sum = myVar + secondVar;
            //int product = myVar * secondVar;
            //int remainder = myVar % secondVar;
            //double value = (double)myVar / (double)secondVar;

            //Console.WriteLine(sum);
            //Console.WriteLine(product);
            //Console.WriteLine(remainder);
            //Console.WriteLine(value);

            //string firstName = "Tom";
            //string lastName = "Sawyer";

            //string fullName = firstName + " " + lastName;
            //Console.WriteLine(fullName);
            //Console.WriteLine("{0} {1}", firstName, lastName);


            #endregion

            #region Decision Statements

            //int condition1;
            //int condition2;
            //int switchCondition;

            // if sample
            //condition1 = 1;
            //if (condition1 == 1)
            //{
            //    Console.WriteLine("comparison evaluated to true.");
            //}

            //Console.WriteLine("This executes after the if, regardless of condition.");


            //// if-else sample
            //condition1 = 3;
            //if (condition1 == 1)
            //{
            //    Console.WriteLine("comparison evaluated to true");
            //}
            //else
            //{
            //    Console.WriteLine("comparison evaluated to false.");
            //}


            //// if-else-if sample
            //condition1 = 1;
            //condition2 = 2;
            //if (condition1 == 1)
            //{
            //    Console.WriteLine("condition1 is true.");
            //}
            //else if (condition2 == 2)
            //{
            //    Console.WriteLine("condition2 is true.");
            //}
            //else
            //{
            //    Console.WriteLine("Neither condition is true.");
            //}


            ////switch sample
            //switchCondition = 3;

            //switch (switchCondition)
            //{
            //    case 1:
            //        Console.WriteLine("Value is 1");
            //        break;

            //    case 2:
            //        Console.WriteLine("Value is 2");
            //        break;

            //    case 3:
            //        Console.WriteLine("Value is 3");
            //        break;

            //    default:
            //        Console.WriteLine("Value is " + switchCondition);
            //        break;
            //}

        #endregion

            #region Repetition Statements

            //int whileCounter = 0;
            //int doCounter = 0;

            //// for loop sample
            //Console.WriteLine("for loop");
            //Console.WriteLine();

            //for (int forCounter = 0; forCounter < 10; forCounter++)
            //{
            //    Console.WriteLine("forCounter is at " + forCounter);
            //}



            //// while loop sample
            //Console.WriteLine();
            //Console.WriteLine("while loop");
            //Console.WriteLine();

            //while(whileCounter < 5)
            //{
            //    Console.WriteLine("whileCounter is at " + whileCounter);
            //    whileCounter++;
            //}


            //// do-while sample
            //Console.WriteLine();
            //Console.WriteLine("do-while loop");
            //Console.WriteLine();

            //do
            //{
            //    Console.WriteLine("doCounter is at " + doCounter);
            //    doCounter++;
            //} while (doCounter < 5);


            // recursion sample
            //Console.WriteLine();
            //Console.WriteLine("recursion");
            //Console.WriteLine();

            //long value = Factorial(10);
            //Console.WriteLine(value);



        //static long Factorial(int n)
        //{
        //    if (n == 0)
        //    {
        //        return 1;
        //    }

        //    return n * Factorial(n - 1);
        //}

            #endregion

            #region Methods

            // Demonstrating methods
            // First method returns nothing and accepts no parameters
            //PrintSomething();

            // Create some variables for use in a method call
            int first = 10;
            int second = 2;
            string sValue;

            // This method call will expect a single value returned
            // So the return value must be assigned to something
            // We also pass in two arguments to the method
            //int result = Sum(first, second);
            //Console.WriteLine(result);

            // C# methods typically only return a single value
            // You can use out or ref as a way of returning multiple items from a method
            // Using out
            //ReturnMultiOut(out first, out sValue);
            //Console.WriteLine("{0}, {1}", first.ToString(), sValue);

            // Using ref requires that the variables be initialized first
            //sValue = "";
            //ReturnMultiRef(ref first, ref sValue);
            //Console.WriteLine("{0}, {1}", first.ToString(), sValue);

            // Using named parameters
            //Area(length: 35, width: 50);

            // Using optional parameters
            //OptionalParams(10, 20);



            #endregion

            #region Exception Handling

            StreamReader sr = new StreamReader();
            try
            {
                sr = File.OpenText("data.txt");
                Console.WriteLine("The first line of this file is {0}", sr.ReadLine());
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: '{0}'", e);
            }
            finally
            {
                sr.Close();
            }

        #endregion



        }

        #region Called Methods
        static void PrintSomething()
        {
            Console.WriteLine("Something");
        }

        static int Sum(int value1, int value2)
        {
            return value1 + value2;
        }

        static void ReturnMultiOut(out int i, out string s)
        {
            i = 25;
            s = "using out";
        }

        static void ReturnMultiRef(ref int i, ref string s)
        {
            i = 50;
            s = "using ref";
        }

        static void Area(int length, int width)
        {
            Console.WriteLine("The area is {0}", length * width);
        }

        static void OptionalParams(int one, int two, string s = "default text")
        {
            Console.WriteLine("{0}, {1}, {2}", one, two, s);
        }

        #endregion
    }
}
