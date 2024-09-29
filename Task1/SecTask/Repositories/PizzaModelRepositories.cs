
using SecTask.Models;

namespace SecTask.Repositories
{
    public class PizzaModelRepositories
    {
        
        private List<PizzaModel> pizzaModel = new List<PizzaModel>
        {
            new PizzaModel {Title="Capricio",Src="capriccio.jpg",Description="Сыр моцарелла, Соус \"Барбекю\", Соус \"Кальяри\", Пепперони, Овощи гриль, Бекон, Ветчина",Price="660Р"},
            new PizzaModel {Title="XXXL",Src="xxxl.jpg",Description="Сыр моцарелла, Соус \"Барбекю\", Соус \"Кальяри\", Пепперони, Овощи гриль, Бекон, Ветчина",Price="780Р"},
            new PizzaModel {Title="4 вкуса",Src="4-vkusa.jpg",Description="Сыр моцарелла, Соус \"Барбекю\", Соус \"Кальяри\", Пепперони, Овощи гриль, Бекон, Ветчина",Price="630Р"},
            new PizzaModel {Title="Амазонка",Src="amazonka.jpg",Description="Соус \"Томатный\", Сыр моцарелла, Куриная грудка, Брокколи, Огурцы маринованные",Price="650Р"}
        };
        public List<PizzaModel> GetPizzaModels()
        {
            return pizzaModel;
        }


    }
}
