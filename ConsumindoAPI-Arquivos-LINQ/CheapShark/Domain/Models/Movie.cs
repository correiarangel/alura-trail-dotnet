using System.Text.Json.Serialization;

namespace CheapShark.Domain.Models;

public class Movie
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("rank")]
    public string? Rank { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("fullTitle")]
    public string? FullTitle { get; set; }

    [JsonPropertyName("year")]
    public string? Year { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("crew")]
    public string? Crew { get; set; }

    [JsonPropertyName("imDbRating")]
    public string? ImDbRating { get; set; }

    [JsonPropertyName("imDbRatingCount")]
    public string? ImDbRatingCount { get; set; }

public void ExibirNoConsole()
{
    Console.WriteLine("\n--------------- Filme --------------------");
    Console.WriteLine($"Id: {Id}");
    Console.WriteLine($"Rank: {Rank}");
    Console.WriteLine($"Título: {Title}");
    Console.WriteLine($"Título Completo: {FullTitle}");
    Console.WriteLine($"Ano: {Year}");
    Console.WriteLine($"Imagem: {Image}");
    Console.WriteLine($"Elenco/Direção: {Crew}");
    Console.WriteLine($"Nota IMDb: {ImDbRating}");
    Console.WriteLine($"Votos IMDb: {ImDbRatingCount}");
    Console.WriteLine("------------------------------------------\n");
}

}
