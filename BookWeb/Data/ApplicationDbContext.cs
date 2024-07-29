using BookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BookWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Adventure", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Classic", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Graphic Novel", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Mystery", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Fantasy", DisplayOrder = 6 },
                new Category { Id = 7, Name = "Historical Fiction", DisplayOrder = 7 },
                new Category { Id = 8, Name = "Horror", DisplayOrder = 8 },
                new Category { Id = 9, Name = "Literary Fiction", DisplayOrder = 9 },
                new Category { Id = 10, Name = "Romance", DisplayOrder = 10 },
                new Category { Id = 11, Name = "Science Fiction", DisplayOrder = 11 },
                new Category { Id = 12, Name = "Short Story", DisplayOrder = 12 },
                new Category { Id = 13, Name = "Thriller", DisplayOrder = 13 },
                new Category { Id = 14, Name = "Biography", DisplayOrder = 14 },
                new Category { Id = 15, Name = "Poetry", DisplayOrder = 15 },
                new Category { Id = 16, Name = "Self-Help", DisplayOrder = 16 },
                new Category { Id = 17, Name = "True Crime", DisplayOrder = 17 },
                new Category { Id = 18, Name = "Historical", DisplayOrder = 18 },
                new Category { Id = 19, Name = "Children", DisplayOrder = 19 },
                new Category { Id = 20, Name = "Young Adult", DisplayOrder = 20 }
            );

        }
    }
}
