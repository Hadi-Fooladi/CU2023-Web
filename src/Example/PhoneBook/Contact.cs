using System;

namespace PhoneBook;

class Contact
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Email { get; set; }
	public string PhoneNumber { get; set; }

	public string FullName => $"{FirstName} {LastName}";

	public void Read()
	{
		FirstName = Prompt("First Name: ");
		LastName = Prompt("Last Name: ");
		Email = Prompt("Email: ");
		PhoneNumber = Prompt("Phone #: ");
	}

	public static string Prompt(string message)
	{
		Console.Write(message);
		return Console.ReadLine();
	}

	public override string ToString()
	{
		return $"{FullName} (Email: {Email}) (Phone: {PhoneNumber})";
	}
}
