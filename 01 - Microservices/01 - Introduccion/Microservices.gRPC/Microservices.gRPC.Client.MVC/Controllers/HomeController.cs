using Grpc.Net.Client;
using Microservices.gRPC.API.Protos;
using Microservices.gRPC.Client.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Microservices.gRPC.Client.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //disable https
            //AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);

            var channel = GrpcChannel.ForAddress("https://localhost:7004");
            Products.ProductsClient productsClient = new Products.ProductsClient(channel);
            ListResponse listResponse = productsClient.List(new Empty());
            return View(listResponse.Products.ToList<ProductDto>());
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