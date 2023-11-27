using Newtonsoft.Json;

namespace PhoneBookClient
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Test();

			Thread.Sleep(5000);

			Console.Write("\n\nPress any key to exit...");
			Console.ReadKey();
		}

		static async void Test()
		{
			var client = new HttpClient
			{
				BaseAddress = new Uri("https://localhost:44338/")
			};

			var response = await client.GetStringAsync("api/Main/GetContacts");

			Console.WriteLine(response);

			int row = 1;
			var contacts = JsonConvert.DeserializeObject<List<Contact>>(response);
			foreach (var contact in contacts)
			{
				Console.WriteLine($"{row++}- {contact.FirstName} {contact.LastName}");
			}
		}
	}
}