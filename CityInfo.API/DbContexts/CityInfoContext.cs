using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.DbContexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<PointOfInterest> PointsOfInterest { get; set; } = null!;

        public CityInfoContext(DbContextOptions<CityInfoContext> options)
            : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasData(
                new City("Bristol")
                {
                    Id = 1,
                    Description = "The home of TripHop"
                },
                new City("Exeter")
                {
                    Id = 2,
                    Description = "Memories of Flowerpot"
                },
                new City("Glastonbury")
                {
                    Id = 3,
                    Description = "Never a dull moment"
                });

            modelBuilder.Entity<PointOfInterest>()
                .HasData(
                new PointOfInterest("The Hippodrome")
                {
                    Id = 1,
                    CityId = 1,
                    Description = "Theatre"
                },
                new PointOfInterest("St Georges Park")
                {
                    Id = 2,
                    CityId = 1,
                    Description = "Old School Snake Run"
                },
                new PointOfInterest("FlowerPot")
                {
                    Id = 3,
                    CityId = 2,
                    Description = "Modern Concrete"
                },
                new PointOfInterest("Ikea")
                {
                    Id = 4,
                    CityId = 2,
                    Description = "To lose the wife in"
                },
                new PointOfInterest("Town Centre")
                {
                    Id = 5,
                    CityId = 3,
                    Description = "Cafe Delight, maybe a Morris Dancer?"
                },
                new PointOfInterest("Somerton Road")
                {
                    Id = 6,
                    CityId = 3,
                    Description = "Long gone wooden park"
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
