using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PhoneBookWeb.Pages
{
    public class AddModel : PageModel
    {
		[BindProperty]
        public Contact Contact { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            if (Contact.Email.Contains("@gmail.com"))
            {
                ModelState.AddModelError(string.Empty, "Gmail is not supported");
                return Page();
            }



            Global.Add(Contact);

            return RedirectToPage("Index");
        }
    }
}
