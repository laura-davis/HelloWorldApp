using System;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

namespace HelloWorldApp.Pages
{
    public class CurrencyConverter : PageModel
    {
        public StringValues amount;
        public double conversion;
        private double stringToDouble;


        public void OnGet()
        {
        }

        public void OnPost()
        {
            this.amount = Request.Form["amount"];
            this.stringToDouble = Convert.ToDouble(amount);
            this.conversion = stringToDouble * 1.12;
        }
    }
}