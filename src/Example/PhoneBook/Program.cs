using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace PhoneBook;

internal class Program
{
	static void Main()
	{
		const string DATA_FILENAME = "Data.json";

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
					File.WriteAllText(DATA_FILENAME, JsonConvert.SerializeObject(contacts, Formatting.Indented));
					break;

				case 4:
					if (!File.Exists(DATA_FILENAME))
					{
						Console.WriteLine($"{DATA_FILENAME} doesn't exist");
						break;
					}

					var content = File.ReadAllText(DATA_FILENAME);
					contacts = JsonConvert.DeserializeObject<List<Contact>>(content);
					break;

				case 5:
					return;
			}
		}
	}
}
