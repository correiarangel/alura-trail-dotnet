using System;
using CheapShark.Domain.interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CheapShark.Service.HttpClientService
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddHttpClientService(
            this IServiceCollection services,
            string baseAddress)
        {
            services.AddHttpClient<IHttpClientService, HttpClientService>(client =>
            {
                client.BaseAddress = new Uri(baseAddress);
                client.Timeout = TimeSpan.FromSeconds(30);
                client.DefaultRequestHeaders.Add("Accept", "application/json");
            });

            return services;
        }
    }
}