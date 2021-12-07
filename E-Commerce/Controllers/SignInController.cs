using E_Commerce.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Web.Helpers;
using static Businesslayer.Logic.CustomerProcessor;

namespace E_Commerce.Controllers
{
    [Authorize]
    public class SignInController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Index(LogInViewModel model)
        {
            if (ModelState.IsValid)
            {
                var data = LoadCustomers();

                foreach (var customer in data)
                {
                    if (model.EmailAddress.Equals(customer.EmailAddress) && ValidateLogIn(customer.PasswordHash, model.Password))
                    {
                        AuthCustomer(model);
                        Thread.Sleep(3000);
                        return RedirectToAction("Index", "Home");
                    }
                }
            }

            return View();
        }

        private bool ValidateLogIn(string hashedPassword,string enteredPassword)
        {
            var doesMatch = Crypto.VerifyHashedPassword(hashedPassword, enteredPassword);
            return doesMatch;
        }

        private void AuthCustomer(LogInViewModel model)
        {
            var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, model.EmailAddress) }, CookieAuthenticationDefaults.AuthenticationScheme);
            var principle = new ClaimsPrincipal(identity);
            var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principle);
        }
    }
}
