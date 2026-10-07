using System.Net.Http.Json;
using ScreenSound.Web.Response;

namespace ScreenSound.Web.Services
{
    public class AuthAPI(IHttpClientFactory factory)
    {
 
        private readonly HttpClient _httpClient = factory.CreateClient("API");


        public async Task<AuthResponse> LoginAsync(string email, string senha)
        {
          var response =   await _httpClient.PostAsJsonAsync("auth/login", new 
            {
                email, 
                Password = senha 
            });

            if (!response.IsSuccessStatusCode)
            {
                return new AuthResponse
                {
                    Sucesso = false,
                    Errorrs = new string[] { "Falha ao realizar login." }
                };
            }
            return new AuthResponse
            {
                Sucesso = true
            };
        }
    }
}