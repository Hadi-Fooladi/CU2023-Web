using System;

namespace PhoneBook;

internal class Program
{
	static void Main()
	{
		var contact = new Contact();
		contact.Read();
		Console.WriteLine(contact);
	}
}
