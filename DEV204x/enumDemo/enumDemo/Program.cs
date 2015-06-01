using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumDemo
{
    class Program
    {
        enum Days { Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        static void Main(string[] args)
        {
            int x = (int)Days.Sunday;
            int y = (int)Days.Friday;
            Console.WriteLine("Sun = {0}", x);
            Console.WriteLine("Fri = {0}", y);

        }
    }
}
