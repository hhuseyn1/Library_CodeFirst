using Library_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace Library_CodeFirst.Contexts
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-HUSEYN;Initial Catalog=Test;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>()
             .HasMany(e => e.Book)
             .WithMany(e => e.Student);

            modelBuilder.Entity<Books>()
              .HasMany(e => e.Student)
              .WithMany(e => e.Book);
        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Books> Books { get; set; }

    }
}
