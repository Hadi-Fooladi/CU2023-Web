using Newtonsoft.Json;

namespace PhoneBookWeb;

static class Global
{
    public static string Root { get; private set; }

    public static List<Contact> Contacts = new();

    public static void Add(Contact contact)
    {
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
        }
    }

    static void SaveContactsToFile()
    {
        var json = JsonConvert.SerializeObject(Contacts, Formatting.Indented);
        var filePath = Path.Combine(Root, "Contacts.json");

        File.WriteAllText(filePath, json);
    }
}
