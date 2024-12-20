namespace DmitriiSFedotov.PizzaMachine.Pizzas;

internal class PepperoniCreator : ICreator
{
    public IPizza Create()
    {
        return new PepperoniPizza();
    }
}
