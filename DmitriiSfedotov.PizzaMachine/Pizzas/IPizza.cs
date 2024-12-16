using System.Threading.Tasks;

internal interface IPizza
{
    string Name { get; }

    Task CollectAsync();

    Task CookAsync();

    Task PackAsync();
}
 