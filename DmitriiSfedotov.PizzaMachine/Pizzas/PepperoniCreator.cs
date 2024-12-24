namespace DmitriiSFedotov.PizzaMachine.Pizzas;

internal class PepperoniCreator : IPizzaCreator
{
    public IPizza Create()
    {
        return new PepperoniPizza();
    }
}
