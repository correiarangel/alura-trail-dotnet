using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ScreenSound.Banco;

namespace ScreenSound.API;

public class ScreenSoundContextFactory : IDesignTimeDbContextFactory<ScreenSoundContext>
{
    public ScreenSoundContext CreateDbContext(string[] args)
    {
        var basePath = Directory.GetCurrentDirectory();
        var apiPath = Path.Combine(basePath, "ScreenSound.API");
        if (!File.Exists(Path.Combine(basePath, "appsettings.json")) && Directory.Exists(apiPath))
        {
            basePath = apiPath;
        }

        var configuration = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json", optional: true)
            .AddJsonFile("appsettings.Development.json", optional: true)
            .AddUserSecrets<Program>(optional: true)
            .AddEnvironmentVariables()
            .Build();

        var connectionString =
            configuration.GetConnectionString("DefaultConnection")
            ?? Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection")
            ?? throw new InvalidOperationException(
                "Configure a Connection String 'DefaultConnection' em User Secrets ou na variável de ambiente ConnectionStrings__DefaultConnection antes de usar o factory.");

        var optionsBuilder = new DbContextOptionsBuilder<ScreenSoundContext>();
        optionsBuilder
            .UseNpgsql(connectionString, npgsql => npgsql.MigrationsAssembly("ScreenSound.API"))
            .UseLazyLoadingProxies();

        return new ScreenSoundContext(optionsBuilder.Options);
    }
}
