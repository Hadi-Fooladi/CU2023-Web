using PhoneBookWeb;

namespace PhoneBookWeb;

static class Global
{
    public static List<Contact> Contacts = new()
    {
        new Contact
        {
            FirstName = "John",
            LastName = "Doe",
            PhoneNumber = "123-456-7890",
            Email = "JohnDoe@gmail.com"
        }
    };
}
