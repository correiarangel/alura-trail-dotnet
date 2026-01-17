namespace BlazorJsonPwa.Domain;

public sealed class Pessoa
{
    public string Nome { get; init; } = string.Empty;
    public int Idade { get; init; }
    public string Email { get; init; } = string.Empty;
}
