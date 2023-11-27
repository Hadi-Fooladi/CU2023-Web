using System.ComponentModel.DataAnnotations;

namespace PhoneBookClient;

public class Contact
{
    public string FirstName { get; set; }

    public string LastName { get; set; }
    
    public string Email { get; set; }
    
    public string PhoneNumber { get; set; }

    public string Gender { get; set; }
}
