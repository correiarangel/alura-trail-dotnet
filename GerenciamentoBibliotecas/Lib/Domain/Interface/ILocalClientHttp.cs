using Lib.Domain.Models;

namespace Lib.Domain.Interface;

interface ILocalClientHttp
{
    Task<List<Music>> GetStringAsync();
    /*Task<Stream> GetStreamAsync(string url);
    Task<HttpResponseMessage> GetAsync(string url);
    Task<HttpResponseMessage> PostAsync(string url, HttpContent content);
    Task<HttpResponseMessage> PutAsync(string url, HttpContent content);
    Task<HttpResponseMessage> DeleteAsync(string url);*/
}
