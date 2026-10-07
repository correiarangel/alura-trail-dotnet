using Microsoft.EntityFrameworkCore;
using MuvieApi.Models;

namespace MuvieApi.Data;
public class MovieContext(DbContextOptions<MovieContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Section>()
        .HasKey(section => new { section.Id, section.MovieId });

        modelBuilder.Entity<Section>()
        .HasOne(section => section.Cinema)
        .WithMany(cinema => cinema.Sections)
        .HasForeignKey(section => section.CinemaId);

        modelBuilder.Entity<Section>()
        .HasOne(section => section.Movie)
        .WithMany(movie => movie.Sections)
        .HasForeignKey(section => section.MovieId);

        modelBuilder.Entity<Address>()
        .HasOne(address => address.Cinema)
        .WithOne(cinema => cinema.Address)
        .OnDelete(DeleteBehavior.Cascade);


    }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Section> Sections { get; set; }
}