using ScreenSound.Menu;
using ScreenSound.Models;

internal class RegistrarBanda(IOpenAIClientService openAIClientService) : Menu
{
    private readonly IOpenAIClientService _openAIClientService = openAIClientService;

    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);

        _openAIClientService.ObterResumoAsync(nomeDaBanda).ContinueWith(task =>
        {
            banda.Resumo = task.Result??"Resumo não disponível.";
            Console.WriteLine($"Resumo da banda {banda.Nome}: {banda.Resumo}");
        }).Wait();

        bandasRegistradas.Add(nomeDaBanda, banda);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();

    }

}