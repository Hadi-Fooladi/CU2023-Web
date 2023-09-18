using System;

namespace PhoneBook;

internal class Program
{
	static void Main()
	{
		var contact = new Contact();

		string[] options =
		{
			"Read",
			"Write",
			"Exit"
		};

		for (;;)
		{
			Console.WriteLine("\n\n --- Menu\n\n");

			var choice = Menu.Show(options);

			Console.WriteLine();
			Console.WriteLine();

			switch (choice)
			{
				case 1:
					contact.Read();
					break;

				case 2:
					Console.WriteLine(contact);
					break;

				case 3:
					return;
			}
		}
	}
}
