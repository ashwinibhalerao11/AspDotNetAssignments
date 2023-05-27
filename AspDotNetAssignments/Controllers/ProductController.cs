using AspDotNetAssignments.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetAssignments.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            List<Product> Products = new List<Product>()
            {
                new Product{Id=1,Name="Keyboard",Price=1999},
                new Product{Id=2,Name="LaptopDell",Price=50000},
                new Product{Id=3,Name="Mouse",Price=1199},
                new Product{Id=4,Name="Keyboard",Price=1999},
                new Product{Id=5,Name="Laptop",Price=50000},
            };
            ViewBag.Products = Products;
            return View();
        }
    }
}
