using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
