using System;

namespace DmitriiSFedotov.PizzaMachine.Helpers;

public static class ConsoleHelper
{
    public static int ReadFromConsole(string message)
    {
        bool parsed;
        int elementsCount;

        Console.Write(message);

        do
        {
            string? input = Console.ReadLine();
            parsed = int.TryParse(input, out elementsCount);
            if (!parsed)
            {
                Console.WriteLine("Некорректный выбор! Попробуйте снова!");
            }
        } while (!parsed);
        return elementsCount;
    }
}