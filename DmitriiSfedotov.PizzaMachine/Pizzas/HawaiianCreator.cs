namespace DmitriiSFedotov.PizzaMachine.Pizzas;

internal class HawaiianCreator : ICreator
{
    public IPizza Create()
    {
        return new HawaiianPizza();
    }
}
