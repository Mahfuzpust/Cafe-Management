﻿using Cafe.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cafe.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):
            base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "BMW", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Mercedes", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Ferrari", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Company>().HasData(
               new Company
               {
                   Id = 1,
                   Name = "Tech Solution",
                   StreetAddress = "123 Tech St",
                   City = "Tech City",
                   PostalCode = "12121",
                   State = "IL",
                   PhoneNumber = "6669990000"
               },
               new Company
               {
                   Id = 2,
                   Name = "Vivid Books",
                   StreetAddress = "999 Vid St",
                   City = "Vid City",
                   PostalCode = "66666",
                   State = "IL",
                   PhoneNumber = "7779990000"
               },
               new Company
               {
                   Id = 3,
                   Name = "Readers Club",
                   StreetAddress = "999 Main St",
                   City = "Lala land",
                   PostalCode = "99999",
                   State = "NY",
                   PhoneNumber = "1113335555"
               }
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
                     CategoryId = 1,
                     ImageUrl = ""
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
                    CategoryId = 2,
                    ImageUrl = ""
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
                    CategoryId = 3,
                    ImageUrl = ""
                }
                );
        }
    }
}
