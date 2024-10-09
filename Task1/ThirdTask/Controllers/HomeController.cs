using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ThirdTask.Models;
using ThirdTask.Repositiries;
using NLog;
using System.Net.Http.Headers;

namespace ThirdTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Logger logger = NLog.LogManager.Setup().LoadConfigurationFromFile().GetCurrentClassLogger();
        public JsonResult GetPizzaJson()
        {
            try
            {
                PizzaModelRepositories pizzaModelRepositories = new PizzaModelRepositories();

                return Json(pizzaModelRepositories.GetPizzaModels());
            }
            catch (Exception e)
            {
                logger.Error(e, "Ошибка при получении списка пицц");

                return Json(new { success = false, message = "Произошла ошибка при загрузке данных." });
            }
        }
        public JsonResult CRUD(PizzaModel pizza, string status)
        {
            try
            {
                PizzaModelRepositories pizzaModelRepositories = new PizzaModelRepositories();
                pizzaModelRepositories.CRUDPizza(pizza, status);
                return Json("Операция успешно прошла");

            }
            catch (Exception e)
            {
                return Json("Во время операция произошла ошибка");
                    }
        }
        public JsonResult DetailJson(int JsonId)
        {
            PizzaModelRepositories pizzaModelRepositories = new PizzaModelRepositories();
            var pizza = pizzaModelRepositories.FindById(JsonId);
            return Json(pizza);
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
