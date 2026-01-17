using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using FileManege;
using BlazorJsonPwa.Application.Interfaces;
using BlazorJsonPwa.Application.Services;
using BlazorJsonPwa.Infrastructure.Storage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IPessoaRepository, LocalStoragePessoaRepository>();
builder.Services.AddScoped<PessoaService>();

await builder.Build().RunAsync();
