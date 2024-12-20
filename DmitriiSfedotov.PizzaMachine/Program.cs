using DmitriiSFedotov.PizzaMachine.Enums;
using DmitriiSFedotov.PizzaMachine.Exceptions;
using DmitriiSFedotov.PizzaMachine.Helpers;
using DmitriiSFedotov.PizzaMachine.Pizzas;
using System;

var pizzaStore = new PizzaStore();

while (true)
{
    foreach (var pizzaType in Enum.GetValues<PizzaType>())
    {
        Console.WriteLine($"{(int)pizzaType}. {pizzaType}");
    }

    var selectedIndex = ConsoleHelper.ReadFromConsole("\nВыберите товар: ");

    var selectedPizzaType = (PizzaType)selectedIndex;

    try
    {
        await pizzaStore.OrderPizza(selectedPizzaType);
    }
    catch (IncorrectChoiceException exception)
    {
        Console.WriteLine(exception.Message);
    }
}


