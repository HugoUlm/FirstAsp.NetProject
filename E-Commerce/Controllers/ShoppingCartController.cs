using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace E_Commerce.Controllers
{
    public class ShoppingCartController : Controller
    {
        /// <summary>
        /// Fetches items from session and displays all items in cart and saves to a new session.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            ShoppingCartViewModel cart = new ShoppingCartViewModel();
            cart.Items = new List<ShoppingCartItemViewModel>();
            var value = HttpContext.Session.GetString("cartItem");

            if (value != null)
            {
                var item = JsonConvert.DeserializeObject<ShoppingCartViewModel>(value);
                cart.Items.AddRange(item.Items);
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart.Items));

                return View(value == null ? default(ShoppingCartViewModel) : cart);
            }

            return View(cart);
        }
    }
}
