using System.Text.Json;
using Lib.Domain.Interface;
using Lib.Domain.Models;
using Microsoft.CSharp.RuntimeBinder;

namespace Lib.Application.Service;

class ClientHttpService : ILocalClientHttp
{
    private HttpClient _httpClient = new HttpClient();
    private const string Url = "https://guilhermeonrails.github.io/api-csharp-songs/songs.json";
    
    public async Task<List<Music>> GetStringAsync()
    {
        try
        {
        string respose = await _httpClient.GetStringAsync(Url);
        var musics = JsonSerializer.Deserialize<List<Music>>(respose)!;    
        return musics;
        }
        catch(HttpRequestException  err)
        {
            throw new HttpRequestException(err.Message);
        }
        catch(Exception err)
        {
            throw new Exception(err.Message);
        }
    }
}
