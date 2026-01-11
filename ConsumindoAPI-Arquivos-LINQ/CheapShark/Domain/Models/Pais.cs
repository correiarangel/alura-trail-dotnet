using System.Text.Json.Serialization;

namespace CheapShark.Domain.Models;

public class Pais
{
    [JsonPropertyName("name")]
    public string? Nome { get; set; }

    [JsonPropertyName("capital")]
    public string? Capital { get; set; }

    [JsonPropertyName("population")]
    public long Populacao { get; set; }

    [JsonPropertyName("continente")]
    public string Continente { get; set; }

    [JsonPropertyName("idioma")]
    public string Idioma { get; set; }

}
