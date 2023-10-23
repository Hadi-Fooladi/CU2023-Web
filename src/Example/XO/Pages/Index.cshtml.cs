using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace XO.Pages
{
    public class IndexModel : PageModel
    {
        public Game Game { get; set; }

        public void OnGet(string? s)
        {
            Game = s == null ? new Game() : new Game(s);

        }
    }
}