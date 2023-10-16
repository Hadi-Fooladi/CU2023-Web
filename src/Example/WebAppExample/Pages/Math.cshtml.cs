using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppExample.Pages
{
    public class MathModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int Num1 { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Num2 { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Op { get; set; }

        public void OnGet()
        {
        }
    }
}
