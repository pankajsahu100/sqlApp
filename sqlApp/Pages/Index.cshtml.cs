using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sqlApp.Models;
using sqlApp.Services;

namespace sqlApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> products;

        public void OnGet()
        {
            ProductService productservice =new ProductService();
            products =productservice.GetProducts();
        }
    }
}