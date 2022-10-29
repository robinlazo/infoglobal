using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CountryList.Models;

internal class ContinentSeed : IEntityTypeConfiguration<Continent> {
    public void Configure(EntityTypeBuilder<Continent> model) {
        model.HasData( 
            new Continent {Name = "America", ContinentID = "america"},
            new Continent {Name = "Europe", ContinentID = "europe"},
            new Continent {Name = "Africa", ContinentID = "africa"},
            new Continent {Name = "Asia", ContinentID = "asia"},
            new Continent {Name = "Oceania", ContinentID = "oceania"}
        );
    }
}