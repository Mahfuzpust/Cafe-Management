using Cafe.Models;
using Microsoft.EntityFrameworkCore;

namespace Cafe.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):
            base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "BMW", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Mercedes", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Ferrari", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Title = "The New Food Village",
                     FoodName = "Pizza",
                     Description = "A model may be static or dynamic. In a static model, a single variable is taken as a key element for calculating cost and time.",
                     FoodCode = "SWB012345698",
                     ListPrice = 200,
                     Price = 180,
                     Price50 = 160,
                     Price100 = 130,
                 },
                new Product
                {
                    Id = 2,
                    Title = "The Pasta",
                    FoodName = "Pasta",
                    Description = "A model may be static or dynamic. In a static model, a single variable is taken as a key element for calculating cost and time.",
                    FoodCode = "SWB012345698",
                    ListPrice = 300,
                    Price = 250,
                    Price50 = 220,
                    Price100 = 200,
                },
                new Product
                {
                    Id = 3,
                    Title = "Cabab",
                    FoodName = "New Cabab",
                    Description = "A model may be static or dynamic. In a static model, a single variable is taken as a key element for calculating cost and time.",
                    FoodCode = "SWB012345698",
                    ListPrice = 320,
                    Price = 300,
                    Price50 = 280,
                    Price100 = 250,
                }
                );
        }
    }
}
