using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppExample.Pages
{
    public class Math3Model : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public MathInput Input { get; set; }

        public string Text { get; set; }

        public void OnGet()
        {
            int num1 = Input.Num1;
            int num2 = Input.Num2;
            string s = Input.Op;

            int result = 0;
            char op = '?';

            switch (s)
            {
                case "add": result = num1 + num2; op = '+'; break;
                case "sub": result = num1 - num2; op = '-'; break;
                case "mul": result = num1 * num2; op = '*'; break;
                case "div": result = num1 / num2; op = '/'; break;
            }

            if (op == '?')
            {
                Text = "Invalid Operator";
            }
            else
            {
                Text = $"{num1} {op} {num2} = {result}";
            }
        }
    }
}
