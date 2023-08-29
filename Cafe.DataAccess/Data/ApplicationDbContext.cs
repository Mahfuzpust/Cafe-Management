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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "BMW", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Mercedes", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Ferrari", DisplayOrder = 3 }
                );
        }
    }
}
