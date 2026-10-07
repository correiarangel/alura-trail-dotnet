using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ScreenSound.Banco;

namespace ScreenSound.API;

public class ScreenSoundContextFactory : IDesignTimeDbContextFactory<ScreenSoundContext>
{
    public ScreenSoundContext CreateDbContext(string[] args)
    {
        var connectionString =
            Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection")
            ?? throw new InvalidOperationException("Configure a variável de ambiente ConnectionStrings__DefaultConnection antes de usar o factory.");

        var optionsBuilder = new DbContextOptionsBuilder<ScreenSoundContext>();
        optionsBuilder
            .UseNpgsql(connectionString, npgsql => npgsql.MigrationsAssembly("ScreenSound.API"))
            .UseLazyLoadingProxies();

        return new ScreenSoundContext(optionsBuilder.Options);
    }
}
