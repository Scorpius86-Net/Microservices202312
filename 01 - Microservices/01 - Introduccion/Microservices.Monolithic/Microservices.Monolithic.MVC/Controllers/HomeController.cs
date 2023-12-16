using Microservices.Monolithic.MVC.Helper;
using Microservices.Monolithic.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Microservices.Monolithic.MVC.Controllers
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

        public IActionResult Confirm(Order order)
        {
            EmailSender.SendEmailToDispatch(order);
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