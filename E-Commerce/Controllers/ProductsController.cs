using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using static Businesslayer.Logic.ProductProcessor;

namespace E_Commerce.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View(GetProducts());
        }

        [HttpGet]
        public async Task<IActionResult> Product(int id)
        {
            var product = GetProducts().FirstOrDefault(x => x.Id == id);
            ViewBag.ProductName = product.Model;
            return View("Product", product);
        }

        public IActionResult Product()
        {
            return View();
        }

        public List<ProductViewModel> GetProducts()
        {
            List<ProductViewModel> products = new List<ProductViewModel>();
            var data = LoadProducts();

            products = data.Select(x => new ProductViewModel()
            {
                Id = x.Id,
                Brand = x.Brand,
                Model = x.Model,
                Images = x.Images,
                Size = x.Size,
                InStock = x.InStock,
                Price = x.Price
            }).ToList();

            return products;
        }
    }
}
