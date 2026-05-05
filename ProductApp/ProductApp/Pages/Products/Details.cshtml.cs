using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductApp.Models;
using System.Linq;

namespace ProductApp.Pages.Products
{
    public class DetailsModel : PageModel
    {
        public Product? Product { get; set; }

        public void OnGet(int id)
        {
            Product = IndexModel.Products.FirstOrDefault(p => p.ProductID == id);
        }
    }
}