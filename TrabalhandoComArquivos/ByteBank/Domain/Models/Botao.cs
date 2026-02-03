namespace ByteBank.Domain.Models;
class Botao(string texto, CoresBotao cor)
{
    public string Texto { get; } = texto;
    public CoresBotao Cor { get; set; } = cor;
}