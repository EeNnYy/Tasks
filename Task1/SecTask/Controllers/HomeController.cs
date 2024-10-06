using Microsoft.AspNetCore.Mvc;
using SecTask.Models;
using SecTask.Repositories;
using System.Diagnostics;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using System.Xml;
using NLog;
using Microsoft.Extensions.Logging;
using NLog.Web;



namespace SecTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Logger logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();

        public JsonResult GetPizzaJson()
        {
            try
            {
                throw new Exception("");
                PizzaModelRepositories pizzaModelRepositories = new PizzaModelRepositories();

                return Json(pizzaModelRepositories.GetPizzaModels());
            }
            catch (Exception e)
            {
                logger.Error(e, "Ошибка при получении списка пицц");
               
                return Json(new { success = false, message = "Произошла ошибка при загрузке данных." });
            }

        }
        public JsonResult DetailJson(int JsonId)
        {
            PizzaModelRepositories pizzaModelRepositories = new PizzaModelRepositories();
            var pizza= pizzaModelRepositories.FindById(JsonId);
            return Json(pizza);
        }
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Detail(int id)
        {
            PizzaModelRepositories pizzaModelRepositories = new PizzaModelRepositories();
            var pizza = pizzaModelRepositories.FindById(id);
            return View(pizza);
        }
        public IActionResult IndexNew()
        {
            PizzaModelRepositories pizzaModelRepositories = new PizzaModelRepositories();
            return View(pizzaModelRepositories.GetPizzaModels());
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
