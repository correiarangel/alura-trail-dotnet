using BlazorJsonPwa.Application.Interfaces;
using BlazorJsonPwa.Domain;

namespace BlazorJsonPwa.Application.Services;

public sealed class PessoaService(IPessoaRepository repository)
{
    private readonly IPessoaRepository _repository = repository;

    public Task SalvarPessoaAsync(Pessoa pessoa)
        => _repository.SalvarPessoaAsync(pessoa);

    public Task<Pessoa?> ObterPessoaAsync()
        => _repository.ObterPessoaAsync();

    public Task SalvarListaAsync(IReadOnlyList<Pessoa> pessoas)
        => _repository.SalvarListaAsync(pessoas);

    public Task<IReadOnlyList<Pessoa>> ObterListaAsync()
        => _repository.ObterListaAsync();

    public async Task<IReadOnlyList<Pessoa>> FiltrarPorIdadeAsync(int idade)
    {
        var pessoas = await _repository.ObterListaAsync();
        return pessoas.Where(p => p.Idade == idade).ToList();
    }
}
