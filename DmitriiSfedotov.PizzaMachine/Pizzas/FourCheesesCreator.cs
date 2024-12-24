namespace DmitriiSFedotov.PizzaMachine.Pizzas;

internal class FourCheesesCreator : IPizzaCreator
{
    public IPizza Create()
    {
        return new FourCheesesPizza();
    }
}
