using System;

namespace Module2_Assignment
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int lines = 8;

			ChessBoard (lines);

		}

		static void ChessBoard (int lines)
		{
			if (lines > 1) 
			{
				ChessBoard (lines - 1);
			}

			if (lines % 2 == 1) {
				Console.WriteLine ("XOXOXOXO");
			} else {
				Console.WriteLine ("OXOXOXOX");
			}
		}
	}
}
