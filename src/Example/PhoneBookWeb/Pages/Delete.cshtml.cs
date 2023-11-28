using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PhoneBookWeb.Pages
{
    public class DeleteModel : PageModel
    {
        public Contact Contact { get; set; }

        public void OnGet(int id)
        {
            Contact = Global.GetContactById(id);
        }

        public IActionResult OnPost(int id)
        {
            Global.DeleteContactById(id);
            return RedirectToPage("Index");
        }
    }
}
