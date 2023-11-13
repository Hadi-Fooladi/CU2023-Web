using System.ComponentModel.DataAnnotations;

namespace PhoneBookWeb;

public class Contact
{
    [Display(Name = "First Name:")]
    public string FirstName { get; set; }

    [Display(Name = "Last Name:")]
    public string LastName { get; set; }
    
    [Display(Name = "Email:")]
    public string Email { get; set; }
    
    [Display(Name = "Phone #:")]
    public string PhoneNumber { get; set; }
}
