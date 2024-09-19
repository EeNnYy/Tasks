using Microsoft.AspNetCore.Mvc;
using SecTask.Models;
using SecTask.Repositories;
using System.Diagnostics;

namespace SecTask.Controllers
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
            PizzaModelRepositories pizzaModelRepositories = new PizzaModelRepositories(); 
            return View(pizzaModelRepositories.GetPizzaModels());
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
