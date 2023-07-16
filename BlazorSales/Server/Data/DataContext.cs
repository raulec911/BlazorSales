using BlazorSales.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorSales.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique();
        }

        public DbSet<Country> Countries { get; set; }
    }
}
