using Microsoft.EntityFrameworkCore;
using MuvieApi.Models;

namespace MuvieApi.Data;
public class MovieContext(DbContextOptions<MovieContext> options) : DbContext(options)
{
    public DbSet<Movie> Movies { get; set; }
}