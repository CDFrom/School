using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysInCSharp
{
	class Program
	{
		static void Populate(int[,] a, int seed)
		{
			Random r = new Random(seed);
			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					a[i, j] = r.Next(1, 10);
				}
			}
		}
		static void ShowArray(int[,] a)
		{
			int i, j;
			for (i = 0; i < a.GetLength(0); i++)
			{
				for (j = 0; j < a.GetLength(1); j++)
				{
					Console.Write(string.Format("{0,3}", a[i, j]) + " "); //0-parameter 3-width
				}
				Console.WriteLine();
			}
		}
		static int FindSumDiagonal(int[,] a)
		{
			int sum = 0;
			for (int i = 0; i < a.GetLength(0); i++)
			{
				sum += a[i, a.GetLength(0) - i - 1];
			}
			return sum;
		}
		public static void Main()
		{
			int[,] a;
			Console.WriteLine("Enter Array Size \'n\' (odd): ");
			int n = int.Parse(Console.ReadLine());
			a = new int[n, n];
			Console.WriteLine("Enter Random Seed Number: ");
			int seed = int.Parse(Console.ReadLine());
			Populate(a, seed);
			Console.WriteLine("Array Elements: ");
			ShowArray(a);
			Console.WriteLine("The summation of diagonal elements is: " + FindSumDiagonal(a));
			Console.Read();
		}
	}
}
