using DmitriiSFedotov.PizzaMachine.Constants;
using Microsoft.VisualBasic;
using System;
using System.Threading.Tasks;

namespace DmitriiSFedotov.PizzaMachine.Pizzas;

class FourCheesesPizza : IPizza
{
    public string Name => "Четыре сыра";

    public async Task CollectAsync()
    {
        Console.WriteLine($"{Name} собирается");

        await Task.Delay(PizzaTimes.FourCheesesCollectTimeInMs);
    }

    public async Task CookAsync()
    {
        Console.WriteLine($"{Name} запекается");

        await Task.Delay(PizzaTimes.FourCheesesCookTimeInMs);
    }

    public async Task PackAsync()
    {
        Console.WriteLine($"{Name} упаковывается");

        await Task.Delay(PizzaTimes.FourCheesesPackTimeInMs);
    }
}