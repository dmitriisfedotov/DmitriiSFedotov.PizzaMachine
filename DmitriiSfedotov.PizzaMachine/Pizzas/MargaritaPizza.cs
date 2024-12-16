using DmitriiSFedotov.PizzaMachine.Constants;
using System;
using System.Threading.Tasks;

namespace DmitriiSFedotov.PizzaMachine.Pizzas;

public class MargaritaPizza : IPizza
{
    public string Name => "Маргарита";

    public async Task CollectAsync()
    {
        Console.WriteLine($"{Name} собирается");

        await Task.Delay(PizzaTimes.MargaritaCollectTimeInMs);
    }

    public async Task CookAsync()
    {
        Console.WriteLine($"{Name} запекается");

        await Task.Delay(PizzaTimes.MargaritaCookTimeInMs);
    }

    public async Task PackAsync()
    {
        Console.WriteLine($"{Name} упаковывается");

        await Task.Delay(PizzaTimes.MargaritaPackTimeInMs);
    }
}