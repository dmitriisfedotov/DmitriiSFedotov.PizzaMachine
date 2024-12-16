using DmitriiSFedotov.PizzaMachine.Enums;
using DmitriiSFedotov.PizzaMachine.Exceptions;
using DmitriiSFedotov.PizzaMachine.Pizzas;
using System.Threading.Tasks;

internal class PizzaStore
{
    public async Task OrderPizza(PizzaType pizzaType)
    {
        IPizza pizza = pizzaType switch
        {
            PizzaType.Pepperoni => new PepperoniPizza(),
            PizzaType.Hawaiian => new HawaiianPizza(),
            PizzaType.Margarita => new MargaritaPizza(),
            PizzaType.FourCheeses => new FourCheesesPizza(),
            _ => throw new IncorrectChoiceException("Некорректный выбор! Попробуйте снова!")
        };

        await pizza.CollectAsync();
        await pizza.CookAsync();
        await pizza.PackAsync();
    }
}
