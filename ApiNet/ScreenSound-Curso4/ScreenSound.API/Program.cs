using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ScreenSound.API.Endpoints;
using ScreenSound.Banco;
using ScreenSound.Modelos;
using ScreenSound.Shared.Dados.Models;
using ScreenSound.Shared.Modelos.Modelos;
using System.Data.SqlTypes;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

if (string.IsNullOrWhiteSpace(connectionString))
{
    throw new InvalidOperationException(
        "Connection string 'DefaultConnection' ausente. Configure-a em User Secrets ou na variável de ambiente ConnectionStrings__DefaultConnection.");
}

builder.Services.AddDbContext<ScreenSoundContext>((options) =>
{
    options
            .UseNpgsql(connectionString, npgsql => npgsql.MigrationsAssembly("ScreenSound.API"))
            // .UseSqlServer(builder.Configuration.GetConnectionString("ScreenSoundDB")) // SQL Server legado.
            .UseLazyLoadingProxies();
});

builder.Services
    .AddIdentityApiEndpoints<PerssonWithPermission>()
    .AddEntityFrameworkStores<ScreenSoundContext>();

builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

// Permite que o cookie do Identity seja trafegado entre o Blazor WebAssembly e a API (Cross-Origin em portas locais distintas: 7015 e 7089)
builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.SameSite = SameSiteMode.None;
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
});

builder.Services.AddTransient<DAL<PerssonWithPermission>>();
builder.Services.AddTransient<DAL<Artista>>();
builder.Services.AddTransient<DAL<Musica>>();
builder.Services.AddTransient<DAL<Genero>>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddCors(
    options => options.AddPolicy(
        "wasm",
        policy => policy.WithOrigins([builder.Configuration["BackendUrl"] ?? "https://localhost:7089",
            builder.Configuration["FrontendUrl"] ?? "https://localhost:7015"])
            .AllowAnyMethod()
            .SetIsOriginAllowed(pol => true)
            .AllowAnyHeader()
            .AllowCredentials()));


var app = builder.Build();

app.UseCors("wasm");

app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();

app.AddEndPointsArtistas();
app.AddEndPointsMusicas();
app.AddEndPointGeneros();
//Rotulo de autorização do enpoit      
app.MapGroup("auth").MapIdentityApi<PerssonWithPermission>().WithTags("Autenticação");

app.MapPost("auth/logout", async ([FromServices] SignInManager<PerssonWithPermission> signInManager) =>
{
    await signInManager.SignOutAsync();
    return Results.Ok();
}).WithTags("Autenticação");

app.UseSwagger();
app.UseSwaggerUI();

if (app.Environment.IsDevelopment())
{
    using var scope = app.Services.CreateScope();
    var context = scope.ServiceProvider.GetRequiredService<ScreenSoundContext>();
    context.Database.Migrate();
}

app.Run();
