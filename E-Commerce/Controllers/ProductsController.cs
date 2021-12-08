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
            List<ProductViewModel> products = new List<ProductViewModel>();
            var data = LoadProducts();

            products = data.Select(x => new ProductViewModel()
            {
                Brand = x.Brand,
                Model = x.Model,
                Images = x.Images,
                Size = x.Size,
                InStock = x.InStock,
                Price = x.Price
            }).ToList();

            return View(products);
        }
    }
}
