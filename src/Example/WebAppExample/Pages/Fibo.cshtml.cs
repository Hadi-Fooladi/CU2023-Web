using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppExample.Pages
{
    public class FiboModel : PageModel
    {
        public int Number { get; set; }

        public void OnGet(int num)
        {
            Number = num;
        }
    }
}
