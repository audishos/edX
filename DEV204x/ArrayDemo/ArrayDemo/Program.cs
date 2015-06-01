using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] intArray = new int[10];
            //intArray[0] = 10;
            //intArray[1] = 20;

            //int[] newArray = { 1, 2, 3, 4, 5 };

            //for (int i = 0; i < newArray.Length; i++)
            //{
            //    Console.WriteLine(newArray[i]);
            //}

            int[,] twoDArray = { { 3, 2 }, { 4, 5 }, { 5, 6 } };

            for (int x = 0; x < twoDArray.GetLength(0); x++)
            {
                for (int y = 0; y < twoDArray.GetLength(1); y++)
                {
                    int value = twoDArray[x, y];
                    Console.WriteLine(value.ToString());
                }
            }
        }
    }
}
