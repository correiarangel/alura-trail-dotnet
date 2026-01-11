using System.Text.Json.Serialization;
namespace CheapShark.Domain.Models;

public class Character
{
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("gender")]
    public string? Gender { get; set; }

    [JsonPropertyName("culture")]
    public string? Culture { get; set; }

    [JsonPropertyName("born")]
    public string? Born { get; set; }

    [JsonPropertyName("died")]
    public string? Died { get; set; }

    [JsonPropertyName("titles")]
    public List<string>? Titles { get; set; }

    [JsonPropertyName("aliases")]
    public List<string>? Aliases { get; set; }

    [JsonPropertyName("father")]
    public string? Father { get; set; }

    [JsonPropertyName("mother")]
    public string? Mother { get; set; }

    [JsonPropertyName("spouse")]
    public string? Spouse { get; set; }

    [JsonPropertyName("allegiances")]
    public List<string>? Allegiances { get; set; }

    [JsonPropertyName("books")]
    public List<string>? Books { get; set; }

    [JsonPropertyName("povBooks")]
    public List<string>? PovBooks { get; set; }

    [JsonPropertyName("tvSeries")]
    public List<string>? TvSeries { get; set; }

    [JsonPropertyName("playedBy")]
    public List<string>? PlayedBy { get; set; }


    public void ExibirNoConsole()
{
    Console.WriteLine("\n----------- Personagem -----------");
    Console.WriteLine($"Nome: {Name ?? "N/A"}");
    Console.WriteLine($"Gênero: {Gender ?? "N/A"}");
    Console.WriteLine($"Cultura: {Culture ?? "N/A"}");
    Console.WriteLine($"Nascimento: {Born ?? "N/A"}");
    Console.WriteLine($"Morte: {Died ?? "N/A"}");

    Console.WriteLine($"Pai: {Father ?? "N/A"}");
    Console.WriteLine($"Mãe: {Mother ?? "N/A"}");
    Console.WriteLine($"Cônjuge: {Spouse ?? "N/A"}");

    Console.WriteLine($"Títulos: {FormatarLista(Titles)}");
    Console.WriteLine($"Apelidos: {FormatarLista(Aliases)}");
    Console.WriteLine($"Alianças: {FormatarLista(Allegiances)}");
    Console.WriteLine($"Livros: {FormatarLista(Books)}");
    Console.WriteLine($"POV Books: {FormatarLista(PovBooks)}");
    Console.WriteLine($"Séries de TV: {FormatarLista(TvSeries)}");
    Console.WriteLine($"Interpretado por: {FormatarLista(PlayedBy)}");

    Console.WriteLine("----------------------------------\n");
}

private static string FormatarLista(List<string>? lista)
{
    if (lista == null || lista.Count == 0)
        return "N/A";

    return string.Join(", ", lista);
}

}
