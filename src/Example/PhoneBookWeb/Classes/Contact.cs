using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PhoneBookWeb;

public class Contact
{
    public int Id { get; set; }

    [Display(Name = "First Name:")]
    public string FirstName { get; set; }

    [Display(Name = "Last Name:")]
    public string LastName { get; set; }
    
    [EmailAddress]
    [Display(Name = "Email:")]
    public string Email { get; set; }
    
    [Display(Name = "Phone #:")]
    [Phone]
    public string PhoneNumber { get; set; }

    [Display(Name = "Gender:")]
    public string Gender { get; set; }

    public static readonly List<SelectListItem> Genders = new()
    {
        new() { Value = "M", Text = "Male" },
        new() { Value = "F", Text = "Female" },
        new() { Value = "O", Text = "Other" },
    };
}
