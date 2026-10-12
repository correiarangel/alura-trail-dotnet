using System.Net.Http.Json;
using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;
using ScreenSound.Web.Response;

namespace ScreenSound.Web.Services;

public class AuthAPI(IHttpClientFactory factory) : AuthenticationStateProvider
{
    private bool _isAuthenticated = false;
    private readonly HttpClient _httpClient = factory.CreateClient("API");

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var userMain = new ClaimsPrincipal();

        var response = await _httpClient.GetAsync("auth/manage/info");

        if (response.IsSuccessStatusCode)
        {

            var infoPerson = await response.Content.ReadFromJsonAsync<InfoPessoaResponse?>();

            if (infoPerson is not null)
            {
                Claim[] dados = [
                    new Claim(ClaimTypes.Name, infoPerson.Email),
                    new Claim(ClaimTypes.Email, infoPerson.Email)
                ];
                var identity = new ClaimsIdentity(dados, "cookies");

                userMain = new ClaimsPrincipal(identity);
            }

        }

        return new AuthenticationState(userMain);
    }

    public async Task<AuthResponse> LoginAsync(string email, string senha)
    {
        var response = await _httpClient.PostAsJsonAsync("auth/login?useCookies=true", new
        {
            email,
            password = senha
        });

        if (response.IsSuccessStatusCode)
        {
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
            _isAuthenticated = true;
            return new AuthResponse { Sucesso = true };
        }

        return new AuthResponse { Sucesso = false, Erros = ["Login/senha inválidos"] };
    }

    public async Task LogoutAsync()
    {
        await _httpClient.PostAsync("auth/logout", null);
        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        _isAuthenticated = false;
    }

    public async Task<bool> IsLoged()
    {
    var state = await GetAuthenticationStateAsync();
    return state.User.Identity?.IsAuthenticated ?? false;
    }
}