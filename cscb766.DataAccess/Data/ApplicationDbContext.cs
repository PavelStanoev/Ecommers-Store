using cscb766.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace cscb766.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Action",
                    DisplayOrder = 1,
                },
                new Category
                {
                    Id = 2,
                    Name = "SciFi",
                    DisplayOrder = 2,
                });

            modelBuilder.Entity<Product>().HasData(
               new Product
               {
                   Id = 1,
                   Name = "Microwave Rice",
                   Description = "Savor the delicious taste of traditional Thai Jasmine rice and satisfy your desire for Southeast Asian cuisine in just 90 seconds.",
                   Brand = "Ben's Original",
                   ListPrice = 5.45,
                   DiscountPrice = 4.99,
                   CategoryId = 1,
                   ImageUrl = ""
               },
                new Product
                {
                    Id = 2,
                    Name = "Milk Chocolate Truffles",
                    Description = "Discover our classic LINDOR Milk Chocolate Truffles. Since 1845, the Lindt Master Chocolatiers have combined their expertise with the highest quality ingredients from around the world to produce the finest chocolates.",
                    Brand = "Lindt",
                    ListPrice = 9.50,
                    DiscountPrice = 7.50,
                    CategoryId = 1,
                    ImageUrl = ""

                },
                new Product
                {
                    Id = 3,
                    Name = "Milk",
                    Description = "Olympus fresh milk, produced from fresh milk carefully selected from selected farms, is the excellent choice for a brisk morning.",
                    Brand = "Olympus",
                    ListPrice = 3.30,
                    DiscountPrice = 2.50,
                    CategoryId = 2,
                    ImageUrl = ""

                },
                new Product
                {
                    Id = 4,
                    Name = "Whole chicken",
                    Description = "Fresh chicken is suitable for grilling, in the oven, boiling and making delicious soup. Without added water, preservatives and phosphates.",
                    Brand = "Gradus",
                    ListPrice = 8.80,
                    DiscountPrice = 8.10,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Name = "Chips",
                    Description = "Curly potato chips with barbecue flavor.",
                    Brand = "Crunchips",
                    ListPrice = 3.00,
                    DiscountPrice = 2.80,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Name = "Corona Estrella",
                    Description = "The beer of Barcelona",
                    Brand = "Estrella",
                    ListPrice = 2.80,
                    DiscountPrice = 2.20,
                    CategoryId = 1,
                    ImageUrl = ""

                });
        }
    }
}
