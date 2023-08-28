using System;

namespace Example;

internal class Program
{
	static void Main(string[] args)
	{
		int[] numbers;
		int[,] multi;

		//int num = GetNumber();
		//if (num == -1)
		//{
		//	return;
		//}

		int rows = GetNumber(), cols = GetNumber();

		if (rows == -1 || cols == -1) return;

		multi = new int[rows, cols];

		for(int row = 0; row < rows;row++)
		for (int col = 0; col < cols; col++)
			multi[row, col] = row * col;

		//numbers = new int[num];

		//for (int ndx = 0; ndx < num; ndx++)
		//	numbers[ndx] = ndx;

		//foreach (var number in numbers)
		//{
		//	Console.WriteLine(number);
		//}

		return;

		//Console.Write("Enter the number: ");


		//for (int i = 1; i <= num; i++)
		//{
		//	Console.WriteLine(i);
		//}
	}

	static int GetNumber()
	{
		var response = Console.ReadLine();

		if (int.TryParse(response, out var num))
			return num;

		return -1;
	}
}
