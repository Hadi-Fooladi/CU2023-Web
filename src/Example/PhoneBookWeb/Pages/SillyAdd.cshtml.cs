using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PhoneBookWeb.Pages
{
    public class SillyAddModel : PageModel
    {
        public IActionResult OnGet(string first, string last, string phone, string email)
        {
            Global.Contacts.Add(new Contact
            {
                FirstName = first,
                LastName = last,
                PhoneNumber = phone,
                Email = email
            });

            return RedirectToPage("Index");
        }
    }
}
