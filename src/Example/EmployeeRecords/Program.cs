using System;
using System.Collections.Generic;

namespace EmployeeRecords
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var employees = new List<Employee>();

			bool shouldExit = false;
			while (!shouldExit)
			{
				var choice = Menu();

				switch (choice)
				{
				case '1':
					ShowHeader("New Employee");
					var employee = new Employee();
					employee.Read();
					employees.Add(employee);
					break;

				case '2':
					ShowHeader("All Employees");
					int row = 1;
					foreach (var x in employees)
						Console.WriteLine($"{row++}- {x}");
					break;

				case '3':
					shouldExit = true;
					break;
				}
			}
		}

		static void ShowHeader(string header)
		{
			Console.WriteLine();
			Console.WriteLine(header);
			Console.WriteLine();
		}

		static int Menu()
		{
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine(" --- Menu");
			Console.WriteLine();
			Console.WriteLine("   1. Add new employee");
			Console.WriteLine("   2. Show all employees");
			Console.WriteLine("   3. Exit");
			Console.WriteLine();
			Console.Write("? ");

			char ch;
			do
			{
				var key = Console.ReadKey(true);
				ch = key.KeyChar;
			} while (ch <'1' || ch > '3');

			Console.WriteLine(ch);
			return ch;
		}
	}
}