using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PhoneBookWeb.Pages
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Contact Contact { get; set; }

        public void OnGet(int id)
        {
	        Contact = Global.GetContactById(id);
        }

        public IActionResult OnPost(int id)
        {
	        var contact = Global.GetContactById(id);

            contact.FirstName = Contact.FirstName;
            contact.LastName = Contact.LastName;
            contact.Email = Contact.Email;
            contact.PhoneNumber = Contact.PhoneNumber;
            contact.Gender = Contact.Gender;

            Global.SaveContactsToFile();
            return RedirectToPage("Index");
        }
    }
}
