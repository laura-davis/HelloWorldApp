using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

namespace HelloWorldApp.Pages
{
    public class HelloWorld : PageModel
    {
        public StringValues name;

        public void OnGet()
        {
        }

        public void OnPost()
        {
            this.name = Request.Form["name"];
        }
    }
}