using Microsoft.EntityFrameworkCore;

namespace MyShop.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }

        public DbSet<Bicycle> Bicycles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Bicycle>().HasData(
              new Bicycle
              {
                  Id = 1,
                  Brand = "Trek",
                  Model = "FX 1",
                  Year = 2022,
                  Type = "Hybrid",
                  Price = 450.00m,
                  Color = "Black",
                  ImageFileName = "trek-fx1-black.jpg"
              },
                new Bicycle
                {
                    Id = 2,
                    Brand = "Giant",
                    Model = "TCR Advanced Pro 1 Disc",
                    Year = 2023,
                    Type = "Road",
                    Price = 3500.00m,
                    Color = "Red",
                    ImageFileName = "giant-tcr-red.jpg"
                },
                new Bicycle
                {
                    Id = 3,
                    Brand = "Specialized",
                    Model = "Rockhopper Expert 29",
                    Year = 2022,
                    Type = "Mountain",
                    Price = 1100.00m,
                    Color = "Blue",
                    ImageFileName = "specialized-rockhopper-blue.jpg"
                },
                new Bicycle
                {
                    Id = 4,
                    Brand = "Cannondale",
                    Model = "Synapse Carbon 105",
                    Year = 2023,
                    Type = "Road",
                    Price = 2000.00m,
                    Color = "White",
                    ImageFileName = "cannondale-synapse-white.jpg"
                },
                new Bicycle
                {
                    Id = 5,
                    Brand = "Trek",
                    Model = "Marlin 5",
                    Year = 2022,
                    Type = "Mountain",
                    Price = 550.00m,
                    Color = "Green",
                    ImageFileName = "trek-marlin-green.jpg"
                }
             );
        }
    }
}
