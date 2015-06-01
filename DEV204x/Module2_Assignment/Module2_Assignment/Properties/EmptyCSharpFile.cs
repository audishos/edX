using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Chess Colors
			string black = "X";
			string white = "O";
			#endregion

			#region Row creation
			for (int i = 0; i < 8; i++)
			{
				if (i % 2 == 0)
				{
					Console.WriteLine();
					for (int j = 0; j < 8; j++)
					{
						if (j % 2 == 0)
						{
							Console.Write(black);
						}
						else
						{
							Console.Write(white);
						}
					}
				}
				else
				{
					Console.WriteLine();
					for (int j = 0; j < 8; j++)
					{
						if (j % 2 == 0)
						{
							Console.Write(white);
						}
						else
						{
							Console.Write(black);
						}
					}
				}

			}
			Console.WriteLine();
			#endregion 
		}
	}
}