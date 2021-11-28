using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

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

        public async Task<IActionResult> Register()
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
