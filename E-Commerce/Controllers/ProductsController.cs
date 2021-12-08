using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using static Businesslayer.Logic.ProductProcessor;
using static Businesslayer.Logic.SizesProcessor;

namespace E_Commerce.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View(GetProducts());
        }

        [HttpGet]
        public async Task<IActionResult> Product(string model)
        {
            var product = GetProducts().FirstOrDefault(x => x.Model == model);
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
            var sizes = LoadSizes();

            products = data.Select(x => new ProductViewModel()
            {
                Id = x.Id,
                Brand = x.Brand,
                Model = x.Model,
                Images = x.Images,
                Sizes = sizes.Select(x => new SizeViewModel { Size = x.Size }),
                InStock = x.InStock,
                Price = x.Price,
                ProductNo = x.ProductNo,
                Description = x.Description
            }).ToList();

            return products;
        }
    }
}
