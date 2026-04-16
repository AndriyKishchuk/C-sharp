using Microsoft.EntityFrameworkCore;

namespace Projekt_13
{
    internal class AplicationContext : DbContext
    {
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Categories> Categories { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=books.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Categories)
                .WithMany(c => c.Book)
                .HasForeignKey(b => b.CategoriesId);

            modelBuilder.Entity<Book>()
                .Property(t => t.Title).IsRequired();

            modelBuilder.Entity<Book>()
               .Property(b => b.IsDeleted).HasDefaultValue(false);
        }

    }
}
