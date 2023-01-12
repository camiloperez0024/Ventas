using Microsoft.EntityFrameworkCore;
using Ventas.Data.Entities;

namespace Ventas.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) // permite conectar a la base de datos
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<State>().HasIndex("Name", "CountryId").IsUnique(); // un departamento unico por pais
            modelBuilder.Entity<City>().HasIndex("Name", "StateId").IsUnique(); // una ciudad por pais
        }
    }
}
