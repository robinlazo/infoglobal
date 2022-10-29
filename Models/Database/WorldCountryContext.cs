using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace CountryList.Models;
public class WorldCountryContext : DbContext
{

    public DbSet<Country> Countries { get; set; }
    public DbSet<Continent> Continents { get; set; }
    public WorldCountryContext(DbContextOptions<WorldCountryContext> options) : base(options) {}

    protected override void OnConfiguring(DbContextOptionsBuilder builder) {
        builder.EnableSensitiveDataLogging(true);
    }
    protected override void OnModelCreating(ModelBuilder builder) {
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new CountrySeed());
        builder.ApplyConfiguration(new ContinentSeed());


        builder.Entity<Continent>()
                        .HasMany(c => c.Countries)
                        .WithOne(c => c.Continent)
                        .OnDelete(DeleteBehavior.Restrict);
    }
}