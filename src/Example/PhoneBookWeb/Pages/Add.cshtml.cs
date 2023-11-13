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
            Global.Add(Contact);

            return RedirectToPage("Index");
        }
    }
}
