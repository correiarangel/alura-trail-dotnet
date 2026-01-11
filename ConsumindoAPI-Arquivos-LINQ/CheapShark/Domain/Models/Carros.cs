using System.Text.Json.Serialization;

namespace CheapShark.Domain.Models;

public class Veiculo
{
    [JsonPropertyName("marca")]
    public string? Marca { get; set; }

    [JsonPropertyName("modelo")]
    public string? Modelo { get; set; }

    [JsonPropertyName("ano")]
    public int Ano { get; set; }

    [JsonPropertyName("tipo")]
    public string? Tipo { get; set; }

    [JsonPropertyName("motor")]
    public string? Motor { get; set; }
    [JsonPropertyName("transmissao")]
    public string? Transmissao { get; set; }

    [JsonPropertyName("autonomia")]
    public string? Autonomia { get; set; }
}
