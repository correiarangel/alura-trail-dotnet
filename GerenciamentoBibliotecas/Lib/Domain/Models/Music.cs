using System.Text.Json.Serialization;

namespace Lib.Domain.Models;

internal class Music
{
    private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

    [JsonPropertyName("song")]
    public string? Name { get; set; }
    
    [JsonPropertyName("artist")]
    public string? Artist { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duration { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tonalidade {
        get
        {
            return tonalidades[Key];
        }
    }
    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artist}");
        Console.WriteLine($"Música: {Name}");
        Console.WriteLine($"Duração em segundos: {Duration /1000}");
        Console.WriteLine($"Gênero musical: {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }
}