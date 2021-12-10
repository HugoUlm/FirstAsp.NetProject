using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace E_Commerce.Controllers
{
    public class ShoppingCartController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ShoppingCartViewModel cart = new ShoppingCartViewModel();
            cart.Items = new List<ShoppingCartItemViewModel>();

            var value = HttpContext.Session.GetString("cartItem");
            if (value != null)
            {
                var item = JsonConvert.DeserializeObject<ShoppingCartItemViewModel>(value);
                cart.Items.Add(new ShoppingCartItemViewModel
                {
                    Id = item.Id,
                    Brand = item.Brand,
                    Model = item.Model,
                    Price = item.Price,
                    ProductNo = item.ProductNo,
                    Size = item.Size,
                    Images = item.Images
                });
                return View(value == null ? default(ShoppingCartViewModel) : cart);
            }

            return View(cart);
        }
    }
}
