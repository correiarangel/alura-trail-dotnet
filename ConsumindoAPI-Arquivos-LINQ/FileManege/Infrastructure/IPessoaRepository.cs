using BlazorJsonPwa.Domain;

namespace BlazorJsonPwa.Application.Interfaces;

public interface IPessoaRepository
{
    Task SalvarPessoaAsync(Pessoa pessoa);
    Task<Pessoa?> ObterPessoaAsync();

    Task SalvarListaAsync(IReadOnlyList<Pessoa> pessoas);
    Task<IReadOnlyList<Pessoa>> ObterListaAsync();
}