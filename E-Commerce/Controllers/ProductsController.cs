using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using static Businesslayer.Logic.ProductProcessor;
using static Businesslayer.Logic.SizesProcessor;
using static Businesslayer.Logic.ShoppingCartProcessor;
using Newtonsoft.Json;

namespace E_Commerce.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View(GetProducts());
        }
        public IActionResult Product()
        {
            return View();
        }

        [HttpGet]
        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductViewModel product, string size)
        {
            ShoppingCartItemViewModel cart = new ShoppingCartItemViewModel();
            var products = LoadProducts();

            foreach (var productItem in products)
            {
                if (productItem.Id == product.Id)
                {
                    cart = new ShoppingCartItemViewModel()
                    {
                        Id = productItem.Id,
                        Brand = productItem.Brand,
                        Model = productItem.Model,
                        Price = productItem.Price,
                        Images = productItem.Images,
                        ProductNo = productItem.ProductNo,
                        Size = Convert.ToInt32(size)
                    };
                }
            }
            HttpContext.Session.SetString("cartItem", JsonConvert.SerializeObject(cart));

            return RedirectToAction("Index", "ShoppingCart");
        }

        [HttpGet]
        public async Task<IActionResult> Product(string model)
        {
            var product = GetProducts().FirstOrDefault(x => x.Model == model);
            return View("Product", product);
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
                Sizes = sizes.Select(x => new SizeViewModel() { Size = x.Size }).ToList(),
                InStock = x.InStock,
                Price = x.Price,
                ProductNo = x.ProductNo,
                Description = x.Description
            }).ToList();

            return products;
        }
    }
}
