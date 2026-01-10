

using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using CheapShark.Domain.interfaces;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;


namespace CheapShark.Service.HttpClientService
{
    public class HttpClientService : IHttpClientService
    {

        private readonly HttpClient _httpClient;
        private readonly ILogger<HttpClientService> _logger;
        private readonly JsonSerializerOptions _jsonSerializerOptions;

        public HttpClientService(HttpClient? httpClient, ILogger<HttpClientService>? logger)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _jsonSerializerOptions = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };
        }

        public async Task<T?> GetAsync<T>(string endpoint, CancellationToken cancellationToken = default)
        {
            try
            {
                _logger.LogInformation("Executando GET para {Endpoint}", endpoint);

                var response = await _httpClient.GetAsync(endpoint, cancellationToken);

                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogWarning("Resposta não bem-sucedida ({StatusCode}) para {Endpoint}", response.StatusCode, endpoint);
                    return default;
                }

                var content = await response.Content.ReadAsStringAsync(cancellationToken);
                return JsonSerializer.Deserialize<T>(content, _jsonSerializerOptions);
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "Erro HTTP ao executar GET para {Endpoint}", endpoint);
                throw new AbandonedMutexException("Erro ao acessar o serviço remoto.", ex);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro inesperado ao executar GET para {Endpoint}", endpoint);
                throw new AbandonedMutexException("Erro inesperado ao acessar o serviço remoto.", ex);
            }
        }

        public async Task<TResponse?> PostAsync<TRequest, TResponse>(string endpoint, TRequest data, CancellationToken cancellationToken = default)
        {
            try
            {
                _logger.LogInformation("Executando POST para {Endpoint}", endpoint);

                var json = JsonSerializer.Serialize(data, _jsonSerializerOptions);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(endpoint, content, cancellationToken);

                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogWarning("POST falhou com status {StatusCode} para {Endpoint}",
                        response.StatusCode, endpoint);
                    return default;
                }

                var responseContent = await response.Content.ReadAsStringAsync(cancellationToken);
                return JsonSerializer.Deserialize<TResponse>(responseContent, _jsonSerializerOptions);
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "Erro HTTP ao executar POST para {Endpoint}", endpoint);
                throw new AbandonedMutexException("Erro ao acessar o serviço remoto.", ex);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro inesperado ao executar POST para {Endpoint}", endpoint);
                throw new AbandonedMutexException("Erro inesperado ao acessar o serviço remoto.", ex);
            }
        }

        public async Task<TResponse?> PutAsync<TRequest, TResponse>(string endpoint, TRequest data, CancellationToken cancellationToken = default)
        {
            try
            {
                _logger.LogInformation("Executando PUT para {Endpoint}", endpoint);

                var json = JsonSerializer.Serialize(data, _jsonSerializerOptions);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PutAsync(endpoint, content, cancellationToken);

                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogWarning("PUT falhou com status {StatusCode} para {Endpoint}",
                        response.StatusCode, endpoint);
                    return default;
                }

                var responseContent = await response.Content.ReadAsStringAsync(cancellationToken);
                return JsonSerializer.Deserialize<TResponse>(responseContent, _jsonSerializerOptions);
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "Erro HTTP ao executar PUT para {Endpoint}", endpoint);
                throw new AbandonedMutexException("Erro ao acessar o serviço remoto.", ex);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro inesperado ao executar PUT para {Endpoint}", endpoint);
                throw new AbandonedMutexException("Erro inesperado ao acessar o serviço remoto.", ex);
            }
        }

        public async Task<bool> DeleteAsync(string endpoint, CancellationToken cancellationToken = default)
        {
            try
            {
                _logger.LogInformation("Executando DELETE para {Endpoint}", endpoint);

                var response = await _httpClient.DeleteAsync(endpoint, cancellationToken);

                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogWarning("DELETE falhou com status {StatusCode} para {Endpoint}",
                        response.StatusCode, endpoint);
                    return false;
                }

                return true;
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "Erro HTTP ao executar DELETE para {Endpoint}", endpoint);
                throw new AbandonedMutexException("Erro ao acessar o serviço remoto.", ex);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro inesperado ao executar DELETE para {Endpoint}", endpoint);
                throw new AbandonedMutexException("Erro inesperado ao acessar o serviço remoto.", ex);
            }
        }
    }
}