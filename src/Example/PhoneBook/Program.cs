using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace PhoneBook;

internal class Program
{
	static void Main()
	{
		const string DATA_FILENAME = "Data.txt";

		var contacts = new List<Contact>();

		string[] options =
		{
			"New Contact",
			"Write Contacts",
			"Save",
			"Load",
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
					File.WriteAllLines(DATA_FILENAME, contacts.Select(c => c.Pack()));
					break;

				case 4:
					if (!File.Exists(DATA_FILENAME))
					{
						Console.WriteLine($"{DATA_FILENAME} doesn't exist");
						break;
					}

					contacts = File.ReadAllLines(DATA_FILENAME)
						.Select(Contact.From)
						.ToList();
					break;

				case 5:
					return;
			}
		}
	}
}
