using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    public class SignInController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
