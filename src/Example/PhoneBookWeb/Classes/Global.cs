using Newtonsoft.Json;

namespace PhoneBookWeb;

static class Global
{
	private static int s_id;

    public static string Root { get; private set; }

    public static List<Contact> Contacts = new();

    public static void Add(Contact contact)
    {
	    s_id++;
        contact.Id = s_id;
        Contacts.Add(contact);
        SaveContactsToFile();
    }

    public static void Init(string root)
    {
        Root = root;

        var filePath = Path.Combine(Root, "Contacts.json");
        if (File.Exists(filePath))
        {
            var json = File.ReadAllText(filePath);
            Contacts = JsonConvert.DeserializeObject<List<Contact>>(json)!;
            s_id = Contacts.Max(c => c.Id);
        }
    }

    public static void SaveContactsToFile()
    {
        var json = JsonConvert.SerializeObject(Contacts, Formatting.Indented);
        var filePath = Path.Combine(Root, "Contacts.json");

        File.WriteAllText(filePath, json);
    }
}
