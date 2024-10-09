using SecTask.Models;

namespace SecTask.Repositories
{
    public class PizzaModelRepositories
    {

        private List<PizzaModel> pizzaModel = new List<PizzaModel>
        {
            new PizzaModel {Id=0,Title="Capricio",Src="capriccio.jpg",Description="Сыр моцарелла, Соус \"Барбекю\", Соус \"Кальяри\", Пепперони, Овощи гриль, Бекон, Ветчина",Price="660Р"},
            new PizzaModel {Id=1, Title="XXL",Src="xxl.jpg",Description="Сыр моцарелла, Соус \"Барбекю\", Соус \"Кальяри\", Пепперони, Овощи гриль, Бекон, Ветчина",Price="780Р"},
            new PizzaModel {Id=2,Title="4 вкуса",Src="4_vkusa.jpg",Description="Сыр моцарелла, Соус \"Барбекю\", Соус \"Кальяри\", Пепперони, Овощи гриль, Бекон, Ветчина",Price="630Р"},
            new PizzaModel {Id=3,Title="Амазонка",Src="amazonka.jpg",Description="Соус \"Томатный\", Сыр моцарелла, Куриная грудка, Брокколи, Огурцы маринованные",Price="650Р"}
        };
        public List<PizzaModel> GetPizzaModels()
        {
            return pizzaModel;
        }

        public PizzaModel FindById (int id)
        {
            var pizzaById = pizzaModel.FirstOrDefault(x => x.Id == id);
            return (pizzaById);
        }

        

    }
}
