using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook;

internal class Program
{
	static void Main()
	{
		var contacts = new List<Contact>();

		string[] options =
		{
			"New Contact",
			"Write Contacts",
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
					var contact = new Contact();
					contact.Read();
					contacts.Add(contact);
					break;

				case 2:
					Console.WriteLine("All Contacts:\n\n");

					//Console.WriteLine(string.Join(", ", contacts));

					int row = 1;
					foreach (var c in contacts)
						Console.WriteLine($"{row++}- {c}");
					break;

				case 3:
					return;
			}
		}
	}
}
