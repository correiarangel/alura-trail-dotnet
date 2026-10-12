

namespace ScreenSound.API.Response;

public record AvaliacaoArtistaResponse(int ArtistaId, double Nota)
{
    public double? Classificacao { get; set; }
};
