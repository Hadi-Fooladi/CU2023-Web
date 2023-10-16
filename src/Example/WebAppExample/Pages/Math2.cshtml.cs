using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppExample.Pages
{ 
    public class Math2Model : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public MathInput Input { get; set; }

        public void OnGet()
        {
        }
    }
}
