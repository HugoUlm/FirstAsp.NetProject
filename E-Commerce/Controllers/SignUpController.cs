using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using static Businesslayer.Logic.CustomerProcessor;

namespace E_Commerce.Controllers
{

    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Register()
        {
            GenericSignUpViewModel model = new GenericSignUpViewModel();
            model.Countries = new List<CountryViewModel>();

            using (var client = new HttpClient())
            {
                HttpResponseMessage apiResponse = await client.GetAsync("https://restcountries.com/v2/all");

                if (apiResponse.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api
                    var countryResponse = apiResponse.Content.ReadAsStringAsync().Result;
                    //Deserializing the response recieved from web api and storing into the Employee list
                    model.Countries = JsonConvert.DeserializeObject<List<CountryViewModel>>(countryResponse).ToList();
                }
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(GenericSignUpViewModel model) // Send confirmation e-mail
        {
            if (ModelState.IsValid)
            {
                CreateCustomer(model.Customer.EmailAddress, model.Customer.Password, model.Customer.FirstName, model.Customer.LastName, model.Customer.Birth, model.Customer.Country, model.Customer.Gender);
                return RedirectToAction("Index", "SignIn");
            }
            Thread.Sleep(3000);
            return RedirectToAction("Register");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
