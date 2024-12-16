using DmitriiSFedotov.PizzaMachine.Constants;
using System;
using System.Threading.Tasks;

namespace DmitriiSFedotov.PizzaMachine.Pizzas;

class HawaiianPizza : IPizza
{
    public string Name => "Гавайская";

    public async Task CollectAsync()
    {
        Console.WriteLine($"{Name} собирается");

        await Task.Delay(PizzaTimes.HawaiianCollectTimeInMs);
    }

    public async Task CookAsync()
    {
        Console.WriteLine($"{Name} запекается");

        await Task.Delay(PizzaTimes.HawaiianCookTimeInMs);
    }

    public async Task PackAsync()
    {
        Console.WriteLine($"{Name} упаковывается");

        await Task.Delay(PizzaTimes.HawaiianPackTimeTimeInMs);
    }
}