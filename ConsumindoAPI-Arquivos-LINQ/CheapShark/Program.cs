// See https://aka.ms/new-console-template for more information
using CheapShark.Service.HttpClientService;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

Console.WriteLine("\nConsumindo API CheapShark.........\n");



//GET
var serviceCollection = new ServiceCollection();
_ = serviceCollection.AddLogging(configure => configure.AddConsole());
_ = serviceCollection.AddHttpClientService("https://www.cheapshark.com/api/1.0/deals");  
var serviceProvider = serviceCollection.BuildServiceProvider(); 
var httpClientService = serviceProvider.GetRequiredService<CheapShark.Domain.interfaces.IHttpClientService>();
var deals = await httpClientService.GetAsync<List<CheapShark.Domain.Models.GameDeal>>("deals");
if (deals != null)
{
    foreach (var deal in deals.Take(5))
    {
        deal.ExibirNoConsole();
    }
  
}
else
{
    Console.WriteLine("Nenhum dado retornado da API.");
}
    





Console.WriteLine("\nFinalizado. Tecle ENTER para sair.");
Console.ReadLine(); 