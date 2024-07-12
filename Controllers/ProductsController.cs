using DeltaWarehouse.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeltaWarehouse.Controllers
{
    public class ProductsController : Controller
    {
        public List<ProductService> prod;
        public ProductsController()
        {
            prod = new List<ProductService>()
            {
                new ProductService() { ProductId = 1001, Name = "Tools Gears", Description = "Gear tools production specification" },
                new ProductService() { ProductId = 2001, Name = "Panel", Description = "Switch Gear Panels " },
                new ProductService() { ProductId = 2008, Name = "DocTonar", Description = "Document Solar Objects" },
            };
        }
        public IActionResult Index()
        {
            return View(prod);
        }
    }
}
