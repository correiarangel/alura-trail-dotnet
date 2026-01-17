// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;
using CheapShark.Constant;
using CheapShark.Domain.Filter;
using CheapShark.Domain.interfaces;
using CheapShark.Domain.Models;
using CheapShark.Service.HttpClientService;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;

Console.WriteLine("\nConsumindo API CheapShark.........\n");



//GET

var serviceCollection = new ServiceCollection();
_ = serviceCollection.AddLogging(configure => configure.AddConsole());
_ = serviceCollection.AddHttpClientService(ConstantsString.URL_MUSIC);  
var serviceProvider = serviceCollection.BuildServiceProvider(); 

var httpClientService = serviceProvider.GetRequiredService<IHttpClientService>();
var musics = await httpClientService.GetAsync<List<Musica>>("songs.json");

if (musics != null)
{


var musicasFavoritasDoGuilherme = new MusicasFavoritas("Guilherme");
musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(musics[980]);
musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(musics[513]);
musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(musics[1024]);
musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(musics[999]);
musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(musics[37]);

musicasFavoritasDoGuilherme.GerarDocumentoTXTComAsMusicasFavoritas();

musicasFavoritasDoGuilherme.GerarArquivoJon();

    Console.WriteLine($"///////// {musics.Count} Musica(s)");
    //LingFilter.FilterAllGenerisMusicsArtist(musics,"U2");  
    LingFilter.FilterAllGenerisMusicsArtist(musics,2020);  
}
else
{
    Console.WriteLine("Nenhum dado retornado da API.");
}


/*
Console.WriteLine("Digite o Id para buscar:");
var input = Console.ReadLine();

if (!int.TryParse(input, out int characterId))
{
    Console.WriteLine("Id inválido.");
    return;
}

var serviceCollection = new ServiceCollection();
serviceCollection.AddLogging(configure => configure.AddConsole());
serviceCollection.AddHttpClientService(ConstantsString.URL_CHARACTERS);

var serviceProvider = serviceCollection.BuildServiceProvider();
var httpClientService = serviceProvider.GetRequiredService<IHttpClientService>();

var character = await httpClientService.GetAsync<Character>(characterId.ToString());

if (character != null)
{
    character.ExibirNoConsole();
}
else
{
    Console.WriteLine("Personagem não encontrado.");
}
*/


/*
var serviceCollection = new ServiceCollection();
_ = serviceCollection.AddLogging(configure => configure.AddConsole());
_ = serviceCollection.AddHttpClientService(ConstantsString.URL_MOVIES);  
var serviceProvider = serviceCollection.BuildServiceProvider(); 

var httpClientService = serviceProvider.GetRequiredService<IHttpClientService>();
var movies = await httpClientService.GetAsync<List<Movie>>("TopMovies.json");

if (movies != null)
{
    Console.WriteLine($"///////// {movies.Count} Fime(s)");
    foreach (var movie in movies)
    {
        movie.ExibirNoConsole();
    }
  
}
else
{
    Console.WriteLine("Nenhum dado retornado da API.");
}
*/
/*
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
  */



Console.WriteLine("\nFinalizado. Tecle ENTER para sair.");
Console.ReadLine(); 