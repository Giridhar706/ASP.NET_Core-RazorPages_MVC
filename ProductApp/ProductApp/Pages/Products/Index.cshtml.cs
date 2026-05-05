using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductApp.Models;

namespace ProductApp.Pages.Products
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Product NewProduct { get; set; } = new Product();

        // keep data in memory
        public static List<Product> Products { get; set; } = new List<Product>();

        public void OnGet() { }

        public IActionResult OnPost()
        {
            NewProduct.ProductID = Products.Count + 1;   // auto id
            Products.Add(NewProduct);

            return RedirectToPage();
        }
    }
}