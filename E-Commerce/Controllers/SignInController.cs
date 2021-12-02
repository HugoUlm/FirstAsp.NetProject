using Microsoft.AspNetCore.Mvc;
using static Businesslayer.Logic.CustomerProcessor;

namespace E_Commerce.Controllers
{
    public class SignInController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var data = LoadCustomers();

            foreach (var customer in data)
            {
                if (customer.EmailAddress.Equals(""))
                {

                }
            }
            return View();
        }
    }
}
