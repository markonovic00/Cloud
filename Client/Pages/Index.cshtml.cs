using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bookstore;
using Microsoft.ServiceFabric.Data.Collections;
using Microsoft.ServiceFabric.Services.Runtime;
using Common.Models;

namespace Client.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Book book = new Book();
            book.Name = Request.Form["Name"];
            book.Count = Convert.ToInt32(Request.Form["Count"]);
            ViewData["BookStore"] = book.Name + Environment.NewLine + book.Count;
        }
    }
}
