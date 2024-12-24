using DmitriiSFedotov.PizzaMachine.Enums;
using DmitriiSFedotov.PizzaMachine.Exceptions;
using DmitriiSFedotov.PizzaMachine.Pizzas;
using System.Collections.Generic;
using System.Threading.Tasks;

internal class PizzaStore
{
    private readonly Dictionary<PizzaType, IPizzaCreator> _creators = new Dictionary<PizzaType, IPizzaCreator>();
    public PizzaStore()
    {
        _creators = new ()
        {
            [PizzaType.Pepperoni] = new PepperoniCreator(),
            [PizzaType.Hawaiian] = new HawaiianCreator(),
            [PizzaType.Margarita] = new MargaritaCreator(),
            [PizzaType.FourCheeses] = new FourCheesesCreator()
        };
    }
    public async Task OrderPizza(PizzaType pizzaType)
    {
        if (!_creators.TryGetValue(pizzaType, out var creator))
        {
            throw new IncorrectChoiceException("Некорректный выбор! Попробуйте снова!");
        }

        IPizza pizza = creator.Create();

        await pizza.CollectAsync();
        await pizza.CookAsync();
        await pizza.PackAsync();
    }
}
