using System.Text.Json;
using BlazorJsonPwa.Domain;

namespace FileManege.Application.Factory;

public static class PessoaJsonFactory
{
    public static string GerarPessoa(Pessoa pessoa)
        => JsonSerializer.Serialize(pessoa, new JsonSerializerOptions
        {
            WriteIndented = true
        });

    public static string GerarLista(IEnumerable<Pessoa> pessoas)
        => JsonSerializer.Serialize(pessoas, new JsonSerializerOptions
        {
            WriteIndented = true
        });
}
