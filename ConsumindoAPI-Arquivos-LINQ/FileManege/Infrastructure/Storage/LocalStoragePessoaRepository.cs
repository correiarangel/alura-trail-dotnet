using System.Text.Json;
using Microsoft.JSInterop;
using BlazorJsonPwa.Application.Interfaces;
using BlazorJsonPwa.Domain;

namespace BlazorJsonPwa.Infrastructure.Storage;

public sealed class LocalStoragePessoaRepository(IJSRuntime js) : IPessoaRepository
{
    private const string PEESOA_KEY = "PEESOA_KEY";
    private const string PEESOAS_KEY = "PEESOAS_KEY";

    private readonly IJSRuntime _js = js;

       public async Task SalvarPessoaAsync(Pessoa pessoa)
    {
        var json = JsonSerializer.Serialize(pessoa);
        await _js.InvokeVoidAsync("localStorage.setItem", PEESOA_KEY, json);
    }

    public async Task<Pessoa?> ObterPessoaAsync()
    {
        var json = await _js.InvokeAsync<string>(
            "localStorage.getItem", PEESOAS_KEY);

        if (string.IsNullOrWhiteSpace(json))
            return null;

        return JsonSerializer.Deserialize<Pessoa>(json);
    }

    public async Task SalvarListaAsync(IReadOnlyList<Pessoa> pessoas)
    {
        var json = JsonSerializer.Serialize(pessoas);
        await _js.InvokeVoidAsync("localStorage.setItem", PEESOAS_KEY, json);
    }

    public async Task<IReadOnlyList<Pessoa>> ObterListaAsync()
    {
        var json = await _js.InvokeAsync<string>("localStorage.getItem", PEESOAS_KEY);

        if (string.IsNullOrWhiteSpace(json))
            return Array.Empty<Pessoa>();

        return JsonSerializer.Deserialize<List<Pessoa>>(json) ?? [];
    }
}
