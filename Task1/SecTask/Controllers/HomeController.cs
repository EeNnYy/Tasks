using Microsoft.AspNetCore.Mvc;
using SecTask.Models;
using SecTask.Repositories;
using System.Diagnostics;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using System.Xml;



namespace SecTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       public JsonResult GetPizzaJson ()
        {
;           PizzaModelRepositories pizzaModelRepositories = new PizzaModelRepositories ();

            return Json(pizzaModelRepositories.GetPizzaModels());
        }
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Index()
        {
            PizzaModelRepositories pizzaModelRepositories = new PizzaModelRepositories();
            return View(pizzaModelRepositories.GetPizzaModels());
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
