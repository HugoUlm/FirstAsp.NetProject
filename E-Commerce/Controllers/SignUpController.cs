using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using Datalayer;
using static Datalayer.BusinessLogic.CustomerProcessor;

namespace E_Commerce.Controllers
{
    public class SignUpController : Controller
    {
        private readonly ILogger<SignUpController> _logger;

        public SignUpController(ILogger<SignUpController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public async Task<IActionResult> Registers()
        {
            List<CountryViewModel> CountryInfo = new List<CountryViewModel>();

            using (var client = new HttpClient())
            {
                HttpResponseMessage apiResponse = await client.GetAsync("https://restcountries.com/v2/all");

                if (apiResponse.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api
                    var CountryResponse = apiResponse.Content.ReadAsStringAsync().Result;
                    //Deserializing the response recieved from web api and storing into the Employee list
                    CountryInfo = JsonConvert.DeserializeObject<List<CountryViewModel>>(CountryResponse);
                }
            }

            return View(CountryInfo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(CustomerViewModel customer)
        {
            if (ModelState.IsValid)
            {
                CreateCustomer(customer.EmailAddress, customer.FirstName, customer.LastName, customer.Birth, customer.Country, customer.Gender);
                return RedirectToAction("Index", "SignIn");
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
