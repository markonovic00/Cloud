using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Common.Models;

namespace Client.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Bank bank = new Bank();
            bank.Name = Request.Form["Name"];
            bank.Year = Convert.ToInt32(Request.Form["Year"]);
            ViewData["Bank"] = bank.Name + Environment.NewLine + bank.Year;
        }
    }

}
