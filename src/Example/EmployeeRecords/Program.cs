namespace EmployeeRecords
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//var employee = new Employee();
			//Employee employee = new Employee();
			Employee employee = new()
			{
				FirstName = "John",
				LastName = "Doe",
				BirthDate = new DateTime(1956, 4, 23)
			};

			Console.WriteLine(employee);
		}
	}
}