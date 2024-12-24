using DmitriiSFedotov.PizzaMachine.Enums;
using DmitriiSFedotov.PizzaMachine.Exceptions;
using DmitriiSFedotov.PizzaMachine.Pizzas;
using System.Threading.Tasks;

internal class PizzaStore
{
    public async Task OrderPizza(PizzaType pizzaType)
    {
        IPizzaCreator creator = pizzaType switch
        {
            PizzaType.Pepperoni => new PepperoniCreator(),
            PizzaType.Hawaiian => new HawaiianCreator(),
            PizzaType.Margarita => new MargaritaCreator(),
            PizzaType.FourCheeses => new FourCheesesCreator(),
            _ => throw new IncorrectChoiceException("Некорректный выбор! Попробуйте снова!")
        };

        IPizza pizza = creator.Create();

        await pizza.CollectAsync();
        await pizza.CookAsync();
        await pizza.PackAsync();
    }
}
