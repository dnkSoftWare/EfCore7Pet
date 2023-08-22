using System.Reflection;
using Microsoft.EntityFrameworkCore;
using WebApplication.Entities;
using WebApplication.Entities.Seeding;

namespace WebApplication;

public sealed class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base()
    {
        // Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    public DbSet<Genre> Genres { get; set; }
    public DbSet<Actor> Actors { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Comment> MovieComments { get; set; }
    public DbSet<MovieActor> MovieActors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=test_db1;Username=postgres;Password=vasya");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        InitialSeeding.Seed(modelBuilder);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<string>().HaveMaxLength(150);
    }
}
