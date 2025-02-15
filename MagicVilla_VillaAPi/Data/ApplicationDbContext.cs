using MagicVilla_VillaAPi.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }
        public DbSet<LocalUser> LocalUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Luxurious villa with ocean view",
                    Rate = 500.0,
                    ImageUrl = "https://example.com/royal-villa.jpg",
                    Amenity = "Pool, Spa, Private Beach",
                    Occupancy = 4,
                    Sqft = 2000,
                    CreatedData = new DateTime(2024, 2, 12),
                    UpdatedData = new DateTime(2024, 2, 12)
                },
                new Villa
                {
                    Id = 2,
                    Name = "Mountain Retreat",
                    Details = "Cozy villa in the mountains",
                    Rate = 350.0,
                    ImageUrl = "https://example.com/mountain-retreat.jpg",
                    Amenity = "Fireplace, Hiking Trails, Hot Tub",
                    Occupancy = 6,
                    Sqft = 1500,
                    CreatedData = new DateTime(2024, 2, 12),
                    UpdatedData = new DateTime(2024, 2, 12)
                },
                new Villa
                {
                    Id = 3,
                    Name = "Seaside Escape",
                    Details = "A villa near the beautiful beach",
                    Rate = 450.0,
                    ImageUrl = "https://example.com/seaside-escape.jpg",
                    Amenity = "Beach Access, BBQ, Surfing Gear",
                    Occupancy = 5,
                    Sqft = 1800,
                    CreatedData = new DateTime(2024, 2, 12),
                    UpdatedData = new DateTime(2024, 2, 12)
                },
                new Villa
                {
                    Id = 4,
                    Name = "Forest Haven",
                    Details = "Peaceful retreat surrounded by trees",
                    Rate = 300.0,
                    ImageUrl = "https://example.com/forest-haven.jpg",
                    Amenity = "Hiking, Wildlife Watching, Fireplace",
                    Occupancy = 4,
                    Sqft = 1300,
                    CreatedData = new DateTime(2024, 2, 12),
                    UpdatedData = new DateTime(2024, 2, 12)
                },
                new Villa
                {
                    Id = 5,
                    Name = "Desert Oasis",
                    Details = "A luxurious stay in the heart of the desert",
                    Rate = 400.0,
                    ImageUrl = "https://example.com/desert-oasis.jpg",
                    Amenity = "Infinity Pool, Camel Rides, Private Chef",
                    Occupancy = 3,
                    Sqft = 1700,
                    CreatedData = new DateTime(2024, 2, 12),
                    UpdatedData = new DateTime(2024, 2, 12)
                }
            );
        }

    }
}
