namespace DmitriiSFedotov.PizzaMachine.Pizzas;

internal class HawaiianCreator : IPizzaCreator
{
    public IPizza Create()
    {
        return new HawaiianPizza();
    }
}
