using Microservices.SOA.Client.Helper;
using Microservices.SOA.Client.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace Microservices.SOA.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Order order)
        {

            order.Price = PriceCalculator.GetPrice(order);
            return View("Review", order);
        }

        public async Task<IActionResult> ConfirmAsync(Order order)
        {
            var client = new HttpClient { BaseAddress = new Uri("https://localhost:44326/") };
            var dataAsString = JsonConvert.SerializeObject(order);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await client.PostAsync("api/Dispatch", content);
            response.EnsureSuccessStatusCode();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}