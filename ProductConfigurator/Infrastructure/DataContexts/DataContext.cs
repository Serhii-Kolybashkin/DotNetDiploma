using BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataContexts
{
    public class DataContext : DbContext
    {
        public DbSet<PartComponent> components { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<ProductAssembled> productAssembledes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(nameof(DataContext));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
