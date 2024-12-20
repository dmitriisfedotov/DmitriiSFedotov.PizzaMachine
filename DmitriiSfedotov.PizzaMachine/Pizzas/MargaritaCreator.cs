namespace DmitriiSFedotov.PizzaMachine.Pizzas;

internal class MargaritaCreator : ICreator
{
    public IPizza Create()
    {
        return new MargaritaPizza();
    }
}
