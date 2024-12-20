namespace DmitriiSFedotov.PizzaMachine.Pizzas;

internal class FourCheesesCreator : ICreator
{
    public IPizza Create()
    {
        return new FourCheesesPizza();
    }
}
