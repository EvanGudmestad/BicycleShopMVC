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
                },
                new Bicycle
                {
                    Id = 6,
                    Brand = "Giant",
                    Model = "Escape 3",
                    Year = 2023,
                    Type = "Hybrid",
                    Price = 400.00m,
                    Color = "Silver",
                    ImageFileName = "giant-escape-silver.jpg"
                },
                new Bicycle
                {
                    Id = 7,
                    Brand = "Specialized",
                    Model = "Sirrus X 3.0",
                    Year = 2022,
                    Type = "Hybrid",
                    Price = 700.00m,
                    Color = "Black",
                    ImageFileName = "specialized-sirrus-black.jpg"
                },
                new Bicycle
                {
                    Id = 8,
                    Brand = "Cannondale",
                    Model = "Topstone Carbon Lefty 3",
                    Year = 2023,
                    Type = "Gravel",
                    Price = 3000.00m,
                    Color = "Orange",
                    ImageFileName = "cannondale-topstone-orange.jpg"
                },
                new Bicycle
                {
                    Id = 9,
                    Brand = "Trek",
                    Model = "Domane SL 5",
                    Year = 2023,
                    Type = "Road",
                    Price = 2500.00m,
                    Color = "Blue",
                    ImageFileName = "trek-domane-blue.jpg"
                },
                new Bicycle
                {
                    Id = 10,
                    Brand = "Giant",
                    Model = "Talon 29 3",
                    Year = 2022,
                    Type = "Mountain",
                    Price = 700.00m,
                    Color = "Yellow",
                    ImageFileName = "giant-talon-yellow.jpg"

                }
             );
        }
    }
}
