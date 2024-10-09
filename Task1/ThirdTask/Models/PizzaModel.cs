
using ThirdTask.Repositiries;

namespace ThirdTask.Models
{
    public class PizzaModel
    {
        public PizzaModel()
        {
            
        }
        public PizzaModel(Pizza pizza)
        {
            Id = pizza.Id;
            Title= pizza.Title;
            Src=pizza.Source;
            Description= pizza.Description;
            Price = pizza.Price;
        }
        public int Id { get; set; }

        public string Title { get; set; } 

        public string Src { get; set; } 

        public string Description { get; set; } 

        public string Price { get; set; }
    }
}
