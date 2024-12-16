using DmitriiSFedotov.PizzaMachine.Constants;
using System;
using System.Threading.Tasks;

namespace DmitriiSFedotov.PizzaMachine.Pizzas;

public class PepperoniPizza : IPizza
{
    public string Name => "Пепперони";

    public async Task CollectAsync()
    {
        Console.WriteLine($"{Name} собирается");

        await Task.Delay(PizzaTimes.PepperoniCollectTimeInMs);
    }

    public async Task CookAsync()
    {
        Console.WriteLine($"{Name} запекается");

        await Task.Delay(PizzaTimes.PepperoniCookTimeInMs);
    }
    
    public async Task PackAsync()
    {
        Console.WriteLine($"{Name} упаковывается");

        await Task.Delay(PizzaTimes.PepperoniPackTimaeInMs);
    }
}