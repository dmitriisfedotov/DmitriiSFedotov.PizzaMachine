namespace DmitriiSFedotov.PizzaMachine.Pizzas;

internal class MargaritaCreator : IPizzaCreator
{
    public IPizza Create()
    {
        return new MargaritaPizza();
    }
}
