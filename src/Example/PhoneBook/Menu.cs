using System;
using System.Linq;
using System.Collections.Generic;

namespace PhoneBook;

class Menu
{
	public static int Show(params string[] options)
	{
		return Show((IEnumerable<string>)options);
	}

	public static int Show(IEnumerable<string> options)
	{
		var list = options.ToList();

		int row = 1;
		int count = list.Count;

		foreach (var option in list)
		{
			Console.WriteLine($"  {row++}- {option}");
		}

		Console.WriteLine();
		Console.WriteLine();

		for (;;)
		{
			Console.Write($"Enter your choice (1-{count})? ");
			var response = Console.ReadLine();

			int num;
			if (int.TryParse(response, out num))
			{
				if (num >= 1 && num <= count)
					return num;
			}
		}
	}
}
