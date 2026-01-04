using ScreenSound.Menu;
using ScreenSound.Models;

internal class Sair:Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("\nTchau! Obrigado por utilizar o Screen Sound!\n");
    }
}