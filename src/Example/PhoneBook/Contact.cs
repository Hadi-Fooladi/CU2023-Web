using System;
using System.IO;
using Newtonsoft.Json;

namespace PhoneBook;

class Contact
{
	public static Contact From(string packValue)
	{
		var contact = new Contact();
		contact.Unpack(packValue);
		return contact;
	}

	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Email { get; set; }
	public string PhoneNumber { get; set; }

	[JsonIgnore]
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

	public string Pack()
	{
		return string.Join("$%", FirstName, LastName, Email, PhoneNumber);
	}

	public void Unpack(string s)
	{
		var sp = s.Split("$%");
		FirstName = sp[0];
		LastName = sp[1];
		Email = sp[2];
		PhoneNumber = sp[3];
	}
}
