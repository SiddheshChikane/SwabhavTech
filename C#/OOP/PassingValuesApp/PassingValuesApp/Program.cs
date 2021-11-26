using System;

namespace PassingValuesApp
{
	class Program
	{
		public static void Main()
		{
			int mark = 200;
			UpdateMarkToZero(mark);
			Console.WriteLine(mark);

			int[] manyMarks = { 30, 60, 90, 50 };
			UpdateManyMarksToZero(manyMarks);
			foreach (int score in manyMarks)
			{
				Console.WriteLine(score);
			}
			Console.ReadKey();
		}

		public static void UpdateMarkToZero(int pmark)
		{
			pmark = 10;
		}

		public static void UpdateManyMarksToZero(int[] manyMarks)
		{
			for (int i = 0; i < manyMarks.Length; i++)
			{
				manyMarks[i] = 0;
			}
		}
	}
}
