using System.Net.Http.Headers;
using ThirdTask.Models;
namespace ThirdTask.Repositiries
{
    public class PizzaModelRepositories
    {
        private PizzaContext PizzaContext=new PizzaContext();
        
        public List <PizzaModel> GetPizzaModels()
        {
            var pizzas= PizzaContext.Pizzas.ToList();
            return pizzas.Select(pizza=>new PizzaModel(pizza)).ToList();
        }

        public PizzaModel FindById(int id)
        {
            var pizzaById = PizzaContext.Pizzas.FirstOrDefault(x => x.Id == id);
            return new PizzaModel(pizzaById);
        }
        public bool CRUDPizza(PizzaModel pizza, string status)
        {
            switch (status)
            {
                case "add":
                    var newPizza = new Pizza
                    {
                        Title = pizza.Title,
                        Description = pizza.Description,
                        Price = pizza.Price,
                        Source = pizza.Src
                    };
                    PizzaContext.Pizzas.Add(newPizza);
                    PizzaContext.SaveChanges();
                    return true;
                case "refresh":
                    var existingPizza = PizzaContext.Pizzas.FirstOrDefault(x => x.Id == pizza.Id);
                    if (existingPizza != default)
                    {
                        existingPizza.Title = pizza.Title;
                        existingPizza.Description = pizza.Description;
                        existingPizza.Price = pizza.Price;
                        existingPizza.Source = pizza.Src;
                        PizzaContext.SaveChanges(); 
                    }
                    return true;
                case "delete":
                    var pizzaToDelete = PizzaContext.Pizzas.FirstOrDefault(x => x.Id == pizza.Id);
                    if (pizzaToDelete != default)
                    {
                        PizzaContext.Pizzas.Remove(pizzaToDelete);
                        PizzaContext.SaveChanges(); 
                    }
                    return true;
                default:
                    return false;
            }
        }


    }
}
