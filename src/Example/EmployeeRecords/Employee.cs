using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRecords;

class Employee
{
	internal string FirstName { get; set; }
	public string LastName { get; set; }

	public DateTime BirthDate { get; set; }

	//private string _firstName;

	//public string FirstName
	//{
	//	get => _firstName;
	//	set => _firstName = value;
	//}

	public string FullName
	{
		//get => FirstName + " " + LastName;
		get => $"{FirstName} {LastName}";
	}

	public string FullName2 => $"{FirstName} {LastName}";

	public int Age => (int)((DateTime.Now - BirthDate).TotalDays / 365);

	public override string ToString()
	{
		return $"{FullName} (Age: {Age})";
	}

	public void Read()
	{
		Console.WriteLine("Enter First Name: ");
		FirstName = Console.ReadLine();

		Console.WriteLine("Enter Last Name: ");
		LastName = Console.ReadLine();

		BirthDate = DateTime.Now;
	}
}
