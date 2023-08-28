using System;

namespace Example;

internal class Program
{
	static void Main(string[] args)
	{
		Console.Write("Enter the number: ");

		var response = Console.ReadLine();

		if (!int.TryParse(response, out var num))
		{
			Console.WriteLine("Invliad Number!");
			return;
		}

		for (int i = 1; i <= num; i++)
		{
			Console.WriteLine(i);
		}
	}
}
